using MemoryPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using UnityEngine.EventSystems;

namespace MetaMystia;

// ---------------- NetPacket ----------------
[MemoryPackable]
public partial class NetPacket
{
    public List<NetAction> Actions { get; set; } = new List<NetAction>();

    public byte[] ToBytesWithLength()
    {
        byte[] body = MemoryPackSerializer.Serialize(this);
        byte[] result = new byte[4 + body.Length];
        BitConverter.GetBytes(body.Length).CopyTo(result, 0);
        Buffer.BlockCopy(body, 0, result, 4, body.Length);
        return result;
    }

    public static NetPacket FromBytes(byte[] data)
    {
        return MemoryPackSerializer.Deserialize<NetPacket>(data)!;
    }

    public NetAction GetFirstAction()
    {
        if (Actions.Count > 0)
        {
            return Actions[0];
        }
        throw new Exception("No action in this packet!");
    }
}

// ---------------- PacketBuffer ----------------
public class PacketBuffer
{
    private System.IO.MemoryStream buffer = new System.IO.MemoryStream();

    public void Write(byte[] data, int offset, int count)
    {
        buffer.Position = buffer.Length;
        buffer.Write(data, offset, count);
        buffer.Position = 0;
    }

    public List<NetPacket> ExtractPackets()
    {
        List<NetPacket> packets = new List<NetPacket>();
        while (true)
        {
            if (buffer.Length - buffer.Position < 4) break;
            byte[] lenBytes = new byte[4];
            buffer.Read(lenBytes, 0, 4);
            int bodyLength = BitConverter.ToInt32(lenBytes, 0);
            if (buffer.Length - buffer.Position < bodyLength)
            {
                buffer.Position -= 4; // 回退
                break;
            }
            byte[] body = new byte[bodyLength];
            buffer.Read(body, 0, bodyLength);
            packets.Add(NetPacket.FromBytes(body));
        }

        // 剩余数据移到新的 MemoryStream
        if (buffer.Position < buffer.Length)
        {
            byte[] leftover = buffer.ToArray()[(int)buffer.Position..];
            buffer = new System.IO.MemoryStream();
            buffer.Write(leftover, 0, leftover.Length);
            buffer.Position = 0;
        }
        else
        {
            buffer = new System.IO.MemoryStream();
        }

        return packets;
    }
}

// ---------------- TCP Server ----------------
public class TcpServer
{
    private static BepInEx.Logging.ManualLogSource Log => Plugin.Instance.Log;
    private TcpListener listener;
    public TcpClient currentClient {get; private set;} = null;
    private object lockObj = new object();
    private bool running = false;

    public TcpServer(int port)
    {
        listener = new TcpListener(IPAddress.Any, port);
    }

    public void Start()
    {
        listener.Start();
        running = true;
        Log.LogMessage("[S] Server started...");
        listener.BeginAcceptTcpClient(AcceptCallback, null);
    }

    private void AcceptCallback(IAsyncResult ar)
    {
        if (!running) return; // 已经停止
        TcpClient client = listener.EndAcceptTcpClient(ar);

        lock (lockObj)
        {
            if (currentClient != null)
            {
                Log.LogMessage("[S] Rejecting new connection: already have a client.");
                client.Close();
                listener.BeginAcceptTcpClient(AcceptCallback, null);
                return;
            }

            currentClient = client;
        }

        MpManager.Instance.OnConnected(client, true);

        Log.LogMessage("[S] Client connected.");

        var buffer = new PacketBuffer();
        var stream = client.GetStream();

        ThreadPool.QueueUserWorkItem(_ =>
        {
            byte[] recv = new byte[1024];
            try
            {
                while (running)
                {
                    int bytesRead = stream.Read(recv, 0, recv.Length);
                    if (bytesRead == 0) break;

                    buffer.Write(recv, 0, bytesRead);
                    var packets = buffer.ExtractPackets();
                    foreach (var p in packets)
                    {
                        foreach (var action in p.Actions)
                        {
                            if (action is PingAction ping)
                            {
                                Log.LogInfo($"[S] Received {action.Type}: { ping.Timestamp}");
                            } 
                            else if (action is SyncAction sync)
                            {
                                Log.LogInfo($"[S] Received {action.Type}: {sync.ToString()}");
                            }
                            else
                            {
                                Log.LogInfo($"[S] Received {action.Type}");
                            }
                            MpManager.OnAction(action);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (running) Log.LogWarning($"[S] Client disconnected : {ex.Message}");
            }
            finally
            {
                lock (lockObj) { currentClient = null; }
                client.Close();
                Log.LogMessage($"[S] Client disconnected ");
                MpManager.Instance.OnDisconnected();
            }
        });

        if (running) listener.BeginAcceptTcpClient(AcceptCallback, null);
    }

    // ===================== 主动断开当前客户端 =====================
    public void DisconnectClient()
    {
        lock (lockObj)
        {
            if (currentClient != null)
            {
                Log.LogMessage("[S] Disconnecting current client...");
                currentClient.Close();
                currentClient = null;
                MpManager.Instance.OnDisconnected();
            }
            else
            {
                Log.LogMessage("[S] No client to disconnect.");
            }
        }
    }
    
    public void Stop()
    {
        running = false;
        listener.Stop();

        DisconnectClient();

        Log.LogMessage("[S] Server stopped.");
    }
}
// ===================== TCP Client with Heartbeat & Auto-Reconnect =====================
public class TcpClientWrapper
{
    private static BepInEx.Logging.ManualLogSource Log => Plugin.Instance.Log;
    private string host;
    private int port;
    public TcpClient client {get; private set;}
    private NetworkStream stream;
    private PacketBuffer buffer = new PacketBuffer();
    private Thread recvThread;
    private Thread heartbeatThread;
    private bool running = false;
    private const int MaxRetryTimes = 1;

    public TcpClientWrapper(string host, int port)
    {
        this.host = host;
        this.port = port;
        Connect();
    }

    private void Connect()
    {
        var retryTimes = 0;
        while (retryTimes < MaxRetryTimes)
        {
            try
            {
                client = new TcpClient();
                client.Connect(host, port);
                stream = client.GetStream();
                running = true;

                recvThread = new Thread(ReceiveLoop) { IsBackground = true };
                recvThread.Start();

                heartbeatThread = new Thread(HeartbeatLoop) { IsBackground = true };
                heartbeatThread.Start();

                Log.LogMessage("[C] Connected to server.");

                return;
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[C] Connection failed, reason: {ex.Message},  {ex.StackTrace}");
                retryTimes++;
            }
        }
        throw new Exception($"Failed to connect to server after {retryTimes} attempt(s)");
    }

    private void ReceiveLoop()
    {
        byte[] recv = new byte[1024];
        try
        {
            while (running)
            {
                int bytesRead = stream.Read(recv, 0, recv.Length);
                if (bytesRead == 0) throw new Exception("Server disconnected.");
                buffer.Write(recv, 0, bytesRead);
                var packets = buffer.ExtractPackets();
                foreach (var p in packets)
                {
                    foreach (var action in p.Actions)
                    {
                        if (action is PongAction pong)
                        {
                            Log.LogInfo($"[C] Received {action.Type}: {pong.Timestamp}");
                        }
                        else if (action is SyncAction sync)
                        {
                            Log.LogInfo($"[C] Received {action.Type}: {sync.ToString()}");
                        }
                        else
                        {
                            Log.LogInfo($"[C] Received {action.Type}");
                        }
                        MpManager.OnAction(action);
                    }
                }
            }
        }
        catch
        {
            Log.LogMessage("[C] Disconnected. Reconnecting...");
            MpManager.Instance.OnDisconnected();
            running = false;
            Thread.Sleep(2000);
            Connect();
        }
    }

    private void HeartbeatLoop()
    {
        while (true)
        {
            if (running)
            {
                MpManager.Instance.SendPing();
            }
            Thread.Sleep(2000);
        }
    }

    public void Send(NetPacket packet)
    {
        if (!running) return;
        try
        {
            byte[] data = packet.ToBytesWithLength();
            stream.Write(data, 0, data.Length);
        }
        catch
        {
            running = false;
        }
    }

    public static void Send(TcpClient client, NetPacket packet)
    {
        var stream = client.GetStream();
        byte[] data = packet.ToBytesWithLength();
        stream.Write(data, 0, data.Length);
    }

    public void Close()
    {
        running = false;
        MpManager.Instance.OnDisconnected();
        Log.LogMessage("[C] Disconnected from server.");
        stream?.Close();
        client?.Close();
    }
}
public enum ActionType : ushort
{
    PING,
    PONG,
    HELLO,
    SYNC,
    READY,
    MESSAGE
}

[MemoryPackable]
[MemoryPackUnion((ushort)ActionType.PING, typeof(PingAction))]
[MemoryPackUnion((ushort)ActionType.PONG, typeof(PongAction))]
[MemoryPackUnion((ushort)ActionType.HELLO, typeof(HelloAction))]
[MemoryPackUnion((ushort)ActionType.SYNC, typeof(SyncAction))]
[MemoryPackUnion((ushort)ActionType.READY, typeof(ReadyAction))]
[MemoryPackUnion((ushort)ActionType.MESSAGE, typeof(MessageAction))]
public abstract partial class NetAction
{
    public abstract ActionType Type { get; }
    public abstract void OnReceived();

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize((object)this,
            new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = false,
                IncludeFields = true
            });
    }
}


[MemoryPackable]
public partial class PingAction : NetAction
{
    public override ActionType Type => ActionType.PING;
    public long Timestamp { get; set; }
    public override void OnReceived()
    {
        MpManager.Instance.UpdateLatency(Timestamp);
        MpManager.Instance.ResponsePong();
    }
    public static NetPacket CreatePingPacket(long timestamp)
    {
        NetPacket packet = new NetPacket { };
        packet.Actions.Add(new PingAction { Timestamp = timestamp });
        return packet;
    }
    public static NetPacket CreatePingPacket()
    {
        return CreatePingPacket(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }
}

[MemoryPackable]
public partial class PongAction : NetAction
{
    public override ActionType Type => ActionType.PONG;
    public long Timestamp { get; set; }
    public override void OnReceived()
    {
        MpManager.Instance.UpdateLatency(Timestamp);
    }
    public static NetPacket CreatePongPacket()
    {
        NetPacket packet = new NetPacket { };
        packet.Actions.Add(new PongAction { Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() });
        return packet;
    }
}

[MemoryPackable]
public partial class HelloAction : NetAction
{
    public override ActionType Type => ActionType.HELLO;
    public string PeerId { get; set; } = "";
    public override void OnReceived()
    {
        MpManager.Instance.PeerId = PeerId;
    }
}


[MemoryPackable]
public partial class SyncAction : NetAction
{
    public override ActionType Type => ActionType.SYNC;
    public float Vx {get; set; }
    public float Vy {get; set; }
    public float Px {get; set; }
    public float Py {get; set; }
    public bool IsSprinting{get; set;}
    public string MapLabel {get; set; }
    public override void OnReceived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
            KyoukoManager.Instance.SyncFromPeer(MapLabel, IsSprinting,
                new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }
}


[MemoryPackable]
public partial class ReadyAction : NetAction
{
    public override ActionType Type => ActionType.READY;
    public bool IsReady {get; set; }
    public override void OnReceived()
    {
        KyoukoManager.isReady = true;
        if (MystiaManager.isReady) // 10->11: 需要先显示「准备完成」对话框再在其回调中执行 OnDayOver
        {
            PluginManager.Instance.RunOnMainThread(() =>
            {
                Utils.ShowReadyDialog(true, () =>
                {
                    DayScene.SceneManager.Instance.OnDayOver();
                });
            });
        }
        // else: 00->01: Nope
        Plugin.Instance.Log.LogInfo("Kyouko is ready");
    }
}

[MemoryPackable]
public partial class MessageAction : NetAction
{
    public override ActionType Type => ActionType.MESSAGE;
    private const int maxMessageLen = 1024;
    public string Message {get; private set; }
    public override void OnReceived()
    {
        PluginManager.Console.AddPeerMessage(Message);
    }
    private static MessageAction CreateMsgAction(string msg)
    {
        if (msg.Length <= maxMessageLen)
        {
            return new MessageAction{Message = msg};
        } 
        else
        {
            return new MessageAction{Message = msg[..maxMessageLen] };
        }
    }
    public static NetPacket CreateMsgPacket(string msg)
    {
        NetPacket packet = new NetPacket { };
        packet.Actions.Add(CreateMsgAction(msg));
        return packet;
    }
}
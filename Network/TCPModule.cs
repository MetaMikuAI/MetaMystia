using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MemoryPack;
using System.Collections.Generic;

namespace MetaMystia;

// ---------------- NetPacket ----------------
[MemoryPackable]
public partial class NetPacket
{
    public List<NetAction> Actions { get; set; } = [];

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

    public static NetPacket Create(NetAction netAction)
    {
        NetPacket packet = new() { };
        packet.Actions.Add(netAction);
        return packet;
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
public class TcpServer(int port)
{
    private static BepInEx.Logging.ManualLogSource Log => Plugin.Instance.Log;
    private TcpListener listener = new TcpListener(IPAddress.Any, port);
    private TcpClient currentClient = null;
    private object lockObj = new();
    private bool running = false;
    private Thread heartbeatThread;
    private const int HeartbeatLoopInterval = 3000;
    private const int BufferLen = 2048;

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

        MpManager.OnConnected(client, true);

        Log.LogMessage("[S] Client connected.");

        heartbeatThread = new Thread(HeartbeatLoop) { IsBackground = true };
        heartbeatThread.Start();

        var buffer = new PacketBuffer();
        var stream = client.GetStream();

        ThreadPool.QueueUserWorkItem(_ =>
        {
            byte[] recv = new byte[BufferLen];
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
                MpManager.OnDisconnected();
            }
        });

        if (running) listener.BeginAcceptTcpClient(AcceptCallback, null);
    }

    private void HeartbeatLoop()
    {
        while (running && currentClient != null)
        {
            MpManager.SendPing();
            Thread.Sleep(HeartbeatLoopInterval);
        }
    }

    public void DisconnectClient()
    {
        lock (lockObj)
        {
            if (currentClient != null)
            {
                Log.LogMessage("[S] Disconnecting current client...");
                currentClient.Close();
                currentClient = null;
                MpManager.OnDisconnected();
            }
            else
            {
                Log.LogMessage("[S] No client to disconnect.");
            }
        }
    }

    public void Send(NetPacket packet)
    {
        lock (lockObj)
        {
            if (currentClient == null || !running) return;
            try
            {
                TcpClientWrapper.Send(currentClient, packet);
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[S] Send failed: {ex.Message}");
                DisconnectClient();
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
    private const int HeartbeatLoopInterval = 3000;
    private object sendLock = new();

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
                        MpManager.OnAction(action);
                    }
                }
            }
        }
        catch
        {
            Log.LogMessage("[C] Disconnected. Reconnecting...");
            MpManager.OnDisconnected();
            running = false;
            Thread.Sleep(2000);
            try
            {
                Connect();
            }
            catch (Exception ex)
            {
                Log.LogError($"[C] {ex.Message}: {ex.StackTrace}");
            }
        }
    }

    private void HeartbeatLoop()
    {
        while (running)
        {
            MpManager.SendPing();
            Thread.Sleep(HeartbeatLoopInterval);
        }
    }

    public void Send(NetPacket packet)
    {
        if (!running) return;
        lock (sendLock)
        {
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
        MpManager.OnDisconnected();
        Log.LogMessage("[C] Disconnected from server.");
        stream?.Close();
        client?.Close();
    }
}

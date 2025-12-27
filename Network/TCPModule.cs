using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using MemoryPack;

namespace MetaMystia;

// ---------------- NetPacket ----------------
[MemoryPackable]
public partial class NetPacket
{
    public NetAction[] Actions { get; set; } = [];

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
        if (Actions.Length > 0)
        {
            return Actions[0];
        }
        throw new Exception("No action in this packet!");
    }

    public NetPacket(NetAction[] Actions)
    {
        this.Actions = Actions;
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
[AutoLog]
public sealed partial class TcpServer : IDisposable
{

    private readonly TcpListener listener;
    private TcpClient currentClient;

    private readonly object lockObj = new();

    private volatile bool running;
    private Thread heartbeatThread;

    private const int HeartbeatLoopInterval = 3000;
    private const int BufferLen = 4096;
    public string GetRealConnectedIp => ((IPEndPoint)currentClient.Client.RemoteEndPoint).Address.ToString();

    public TcpServer(int port)
    {
        listener = new TcpListener(IPAddress.Any, port);
    }

    // =========================
    // 生命周期
    // =========================

    public void Start()
    {
        lock (lockObj)
        {
            if (running) return;
            running = true;
        }

        listener.Start();
        Log.LogMessage("[S] Server started.");

        BeginAccept();
    }

    public void Stop()
    {
        lock (lockObj)
        {
            if (!running) return;
            running = false;
        }

        try { listener.Stop(); } catch { }

        CloseClientInternal();

        Log.LogMessage("[S] Server stopped.");
    }

    public void Dispose()
    {
        Stop();
    }

    // =========================
    // Accept
    // =========================

    private void BeginAccept()
    {
        try
        {
            listener.BeginAcceptTcpClient(AcceptCallback, null);
        }
        catch (ObjectDisposedException)
        {
            // 正常 Stop
        }
    }

    private void AcceptCallback(IAsyncResult ar)
    {
        TcpClient client;

        try
        {
            client = listener.EndAcceptTcpClient(ar);
        }
        catch (ObjectDisposedException)
        {
            return;
        }
        catch (Exception ex)
        {
            Log.LogWarning($"[S] Accept failed: {ex.Message}");
            return;
        }

        bool accepted = false;

        lock (lockObj)
        {
            if (!running)
            {
                client.Close();
                return;
            }

            if (currentClient == null)
            {
                currentClient = client;
                accepted = true;
            }
        }

        if (!accepted)
        {
            Log.LogMessage("[S] Rejecting connection: already have a client.");
            client.Close();
            BeginAccept();
            return;
        }

        Log.LogMessage("[S] Client connected.");
        MpManager.OnConnected(GetRealConnectedIp);

        StartHeartbeat();
        StartReceiveLoop(client);

        BeginAccept();
    }

    // =========================
    // 接收循环
    // =========================

    private void StartReceiveLoop(TcpClient client)
    {
        ThreadPool.QueueUserWorkItem(_ =>
        {
            var buffer = new PacketBuffer();
            var recv = new byte[BufferLen];

            try
            {
                while (IsClientAlive(client))
                {
                    var stream = client.GetStream();
                    int read = stream.Read(recv, 0, recv.Length);
                    if (read == 0)
                        break;

                    buffer.Write(recv, 0, read);

                    foreach (var packet in buffer.ExtractPackets())
                    {
                        foreach (var action in packet.Actions)
                        {
                            MpManager.OnAction(action);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (running)
                    Log.LogWarning($"[S] Receive error: {ex.Message}");
            }
            finally
            {
                HandleClientDisconnected(client);
            }
        });
    }

    // =========================
    // 心跳
    // =========================

    private void StartHeartbeat()
    {
        heartbeatThread = new Thread(() =>
        {
            while (true)
            {
                TcpClient client;

                lock (lockObj)
                {
                    if (!running)
                        break;

                    client = currentClient;
                }

                if (client == null)
                    break;

                try
                {
                    MpManager.SendPing();
                }
                catch
                {
                    // SendPing 内部失败会由接收线程清理
                }

                Thread.Sleep(HeartbeatLoopInterval);
            }

            Log.LogMessage("[S] Heartbeat thread terminated.");
        })
        {
            IsBackground = true
        };

        heartbeatThread.Start();
    }

    // =========================
    // 发送
    // =========================

    public void Send(NetPacket packet)
    {
        TcpClient client;

        lock (lockObj)
        {
            if (!running || currentClient == null)
            {
                Log.LogWarning($"[S] Send failed: not running or currentClient is null");
                return;
            }

            client = currentClient;
        }

        try
        {
            var stream = client.GetStream();
            byte[] data = packet.ToBytesWithLength();
            stream.Write(data, 0, data.Length);
        }
        catch (Exception ex)
        {
            Log.LogWarning($"[S] Send failed: {ex.Message}, {ex.StackTrace}");
            CloseClientInternal();
        }
    }

    // =========================
    // 断开处理（唯一出口）
    // =========================

    public void DisconnectClient() => CloseClientInternal();

    private void HandleClientDisconnected(TcpClient client)
    {
        bool shouldNotify = false;

        lock (lockObj)
        {
            if (currentClient == client)
            {
                currentClient = null;
                shouldNotify = true;
            }
        }

        try { client.Close(); } catch { }

        if (shouldNotify)
        {
            Log.LogMessage("[S] Client disconnected.");
            MpManager.OnDisconnected();
        }
    }

    private void CloseClientInternal()
    {
        TcpClient client = null;

        lock (lockObj)
        {
            client = currentClient;
            currentClient = null;
        }

        if (client != null)
        {
            try { client.Close(); } catch { }
            Log.LogMessage("[S] Client disconnected.");
            MpManager.OnDisconnected();
        }
    }

    // =========================
    // 工具
    // =========================

    private bool IsClientAlive(TcpClient client)
    {
        lock (lockObj)
        {
            return running && currentClient == client;
        }
    }

    public bool HasAliveClient
    {
        get
        {
            lock (lockObj)
            {
                if (!running || currentClient == null)
                    return false;

                return IsTcpClientAlive_NoLock(currentClient);
            }
        }
    }

    private bool IsTcpClientAlive_NoLock(TcpClient client)
    {
        try
        {
            var socket = client.Client;

            // 已关闭
            if (socket == null || !socket.Connected)
                return false;

            // 对端已关闭连接（FIN）
            if (socket.Poll(0, SelectMode.SelectRead) && socket.Available == 0)
                return false;

            return true;
        }
        catch
        {
            return false;
        }
    }
}

// ===================== TCP Client with Heartbeat & Auto-Reconnect =====================
[AutoLog]
public sealed partial class TcpClientWrapper : IDisposable
{
    private readonly string host;
    private readonly int port;

    private TcpClient client;
    private NetworkStream stream;
    private PacketBuffer buffer = new PacketBuffer();

    private Task receiveTask;
    private Task heartbeatTask;

    private CancellationTokenSource cts;
    private readonly object sendLock = new();

    private int closed = 0;
    private int connected = 0;

    private const int BufferLen = 4096;
    private const int ConnectTimeoutMs = 10000;
    private const int HeartbeatIntervalMs = 3000;
    private const int ReconnectDelayMs = 3000;

    public bool IsConnected => Volatile.Read(ref connected) == 1;

    public string GetRealConnectedIp => ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

    public TcpClientWrapper(string host, int port)
    {
        this.host = host;
        this.port = port;
    }

    // =========================
    // 生命周期入口
    // =========================

    public async Task StartAsync(CancellationToken token = default)
    {
        EnsureNotDisposed();
        await ConnectInternalAsync(token);
    }

    public void Dispose()
    {
        Close();
    }

    // =========================
    // 连接 / 重连
    // =========================

    private async Task ConnectInternalAsync(CancellationToken token)
    {
        CloseInternal(resetClosedFlag: false);

        Log.LogMessage("[C] Connecting...");

        var tcp = new TcpClient();

        try
        {
            using var timeoutCts =
                CancellationTokenSource.CreateLinkedTokenSource(token);

            timeoutCts.CancelAfter(ConnectTimeoutMs);

            await tcp.ConnectAsync(host, port)
                     .WaitAsync(timeoutCts.Token);

            client = tcp;
            stream = client.GetStream();
            buffer = new PacketBuffer();

            cts = new CancellationTokenSource();
            var loopToken = cts.Token;

            receiveTask = Task.Run(() => ReceiveLoopAsync(loopToken), loopToken);
            heartbeatTask = Task.Run(() => HeartbeatLoopAsync(loopToken), loopToken);

            Volatile.Write(ref connected, 1);
            Log.LogMessage("[C] Connected.");
        }
        catch
        {
            tcp.Dispose();
            throw;
        }
    }

    private async Task ScheduleReconnectAsync()
    {
        if (Volatile.Read(ref closed) == 1)
            return;

        if (Interlocked.CompareExchange(ref connected, 0, 1) != 1)
            return;

        CloseInternal(resetClosedFlag: false);

        MpManager.OnDisconnected();
        Log.LogWarning("[C] Disconnected. Reconnecting...");
        try
        {
            await Task.Delay(ReconnectDelayMs, cts.Token);
            await ConnectInternalAsync(CancellationToken.None);
        }
        catch (Exception ex)
        {
            Log.LogError($"[C] Reconnect failed: {ex.Message}");
        }
    }

    // =========================
    // 接收循环
    // =========================

    private async Task ReceiveLoopAsync(CancellationToken token)
    {
        byte[] recv = new byte[BufferLen];

        try
        {
            while (!token.IsCancellationRequested)
            {
                int read = await stream!.ReadAsync(recv, 0, recv.Length, token);
                if (read == 0)
                    throw new SocketException();

                buffer.Write(recv, 0, read);

                var packets = buffer.ExtractPackets();
                foreach (var packet in packets)
                {
                    foreach (var action in packet.Actions)
                    {
                        MpManager.OnAction(action);
                    }
                }
            }
        }
        catch (OperationCanceledException)
        {
            // 正常退出
        }
        catch (Exception ex)
        {
            Log.LogWarning($"[C] ReceiveLoop error: {ex.Message}");
            await ScheduleReconnectAsync();
        }
        finally
        {
            Log.LogWarning("[C] ReceiveLoop terminated.");
        }
    }

    // =========================
    // 心跳循环
    // =========================

    private async Task HeartbeatLoopAsync(CancellationToken token)
    {
        try
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    MpManager.SendPing();
                }
                catch (Exception ex)
                {
                    Log.LogWarning($"[C] Heartbeat failed: {ex.Message}");
                    await ScheduleReconnectAsync();
                    return;
                }

                await Task.Delay(HeartbeatIntervalMs, token);
            }
        }
        catch (OperationCanceledException)
        {
        }
        finally
        {
            Log.LogWarning("[C] HeartbeatLoop terminated.");
        }
    }

    // =========================
    // 发送
    // =========================

    public void Send(NetPacket packet)
    {
        if (!IsConnected || stream == null)
            return;

        lock (sendLock)
        {
            try
            {
                byte[] data = packet.ToBytesWithLength();
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[C] Send failed: {packet.GetFirstAction()}, reason {ex.Message}, {ex.StackTrace}");
                _ = ScheduleReconnectAsync();
            }
        }
    }

    // =========================
    // 关闭
    // =========================

    public void Close()
    {
        if (Interlocked.Exchange(ref closed, 1) == 1)
            return;

        CloseInternal(resetClosedFlag: false);
        MpManager.OnDisconnected();
        Log.LogMessage("[C] Closed.");
    }

    private void CloseInternal(bool resetClosedFlag)
    {
        Volatile.Write(ref connected, 0);

        try { cts?.Cancel(); } catch { }

        try { stream?.Dispose(); } catch { }
        try { client?.Dispose(); } catch { }

        stream = null;
        client = null;

        if (resetClosedFlag)
            Interlocked.Exchange(ref closed, 0);
    }

    private void EnsureNotDisposed()
    {
        if (Volatile.Read(ref closed) == 1)
            throw new ObjectDisposedException(nameof(TcpClientWrapper));
    }
}
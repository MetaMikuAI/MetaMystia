using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using MemoryPack;

namespace MetaMystia.Network;

// ---------------- NetPacket ----------------
[MemoryPackable]
public partial class NetPacket
{
    public Action[] Actions { get; set; } = [];

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

    public Action GetFirstAction()
    {
        if (Actions.Length > 0)
        {
            return Actions[0];
        }
        throw new Exception("No action in this packet!");
    }

    public NetPacket(Action[] Actions)
    {
        this.Actions = Actions;
    }

    public static NetPacket FromSingleAction(Action action) => new([action]);
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

    public List<(NetPacket packet, byte[] rawBody)> ExtractPackets()
    {
        var packets = new List<(NetPacket, byte[])>();
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
            packets.Add((NetPacket.FromBytes(body), body));
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

// ---- 用于 zero-copy relay 的常量 ----
// 在单 Action NetPacket 中，SenderUid 的字节偏移:
// ObjectHeader(1) + ArrayLen(4) + UnionTag(1) + ObjectHeader(1) + Type(2) + TimestampMs(8) = 17
internal static class RelayConstants
{
    /// <summary>
    /// SenderUid(int32 LE) 在单 Action NetPacket body 中的起始偏移
    /// </summary>
    public const int SenderUidOffset = 17;
}

// ---------------- TCP Server (Star Topology: Host) ----------------
[AutoLog]
public sealed partial class TcpServer : IDisposable
{
    // ---- 内部：每个客机独立的发送会话（异步发送队列，避免主线程阻塞） ----
    private sealed class ClientSession
    {
        public readonly TcpClient Tcp;
        private readonly BlockingCollection<byte[]> _sendQueue = new(boundedCapacity: 512);

        public ClientSession(TcpClient tcp, int uid, TcpServer server)
        {
            Tcp = tcp;
            Tcp.SendTimeout = 10_000; // 10s safety net
            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    var stream = Tcp.GetStream();
                    foreach (var data in _sendQueue.GetConsumingEnumerable())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }
                catch (Exception)
                {
                    server.HandleClientDisconnected(uid);
                }
            });
        }

        public bool TrySend(byte[] data)
        {
            try { return _sendQueue.TryAdd(data); }
            catch { return false; }
        }

        /// <summary>
        /// 仅在队列未拥塞时入队（用于低优先级包如位置同步）
        /// </summary>
        public bool TrySendLowPriority(byte[] data)
        {
            if (_sendQueue.Count > _sendQueue.BoundedCapacity / 4) return false;
            return TrySend(data);
        }

        public void Close()
        {
            try { Tcp.Close(); } catch { }
            try { _sendQueue.CompleteAdding(); } catch { }
        }
    }

    private readonly TcpListener listener;
    private readonly ConcurrentDictionary<int, ClientSession> clients = new();
    private int _nextUid = 0;

    private volatile bool running;
    private Thread heartbeatThread;

    private const int HeartbeatLoopInterval = 3000;
    private const int BufferLen = 4096;

    public TcpServer(int port, bool enableIPv6 = false)
    {
        if (enableIPv6)
        {
            listener = new TcpListener(IPAddress.IPv6Any, port);
            listener.Server.DualMode = true;
        }
        else
        {
            listener = new TcpListener(IPAddress.Any, port);
        }
    }

    /// <summary>
    /// 为新连入的客机分配递增 UID（主机自身为 0）
    /// </summary>
    public int AssignNextUid() => Interlocked.Increment(ref _nextUid);

    // =========================
    // 生命周期
    // =========================

    public void Start()
    {
        if (running) return;
        running = true;

        listener.Start();
        Log.LogMessage("[S] Server started.");

        StartHeartbeat();
        BeginAccept();
    }

    public void Stop()
    {
        if (!running) return;
        running = false;

        try { listener.Stop(); } catch { }

        DisconnectAllClients();

        Log.LogMessage("[S] Server stopped.");
    }

    public void Dispose() => Stop();

    // =========================
    // Accept（支持多客户端）
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
        TcpClient tcp;

        try
        {
            tcp = listener.EndAcceptTcpClient(ar);
        }
        catch (ObjectDisposedException)
        {
            return;
        }
        catch (Exception ex)
        {
            Log.LogWarning($"[S] Accept failed: {ex.Message}");
            BeginAccept();
            return;
        }

        if (!running)
        {
            tcp.Close();
            return;
        }

        int uid = AssignNextUid();
        clients[uid] = new ClientSession(tcp, uid, this);

        var ip = ((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString();
        Log.LogMessage($"[S] Client uid={uid} connected from {ip}");

        StartReceiveLoop(tcp, uid);
        BeginAccept();
    }

    // =========================
    // 接收循环（每个客户端独立线程）
    // =========================

    private void StartReceiveLoop(TcpClient client, int uid)
    {
        ThreadPool.QueueUserWorkItem(_ =>
        {
            var buffer = new PacketBuffer();
            var recv = new byte[BufferLen];

            try
            {
                while (running && clients.ContainsKey(uid))
                {
                    var stream = client.GetStream();
                    int read = stream.Read(recv, 0, recv.Length);
                    if (read == 0)
                        break;

                    buffer.Write(recv, 0, read);

                    foreach (var (packet, rawBody) in buffer.ExtractPackets())
                    {
                        foreach (var action in packet.Actions)
                        {
                            MpManager.OnActionFromClient(action, uid, rawBody);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (running)
                    Log.LogWarning($"[S] Receive error (uid={uid}): {ex.Message}");
            }
            finally
            {
                HandleClientDisconnected(uid);
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
            while (running)
            {
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

    /// <summary>
    /// 向所有已连接客机广播
    /// </summary>
    public void Broadcast(NetPacket packet)
    {
        if (!running) return;
        byte[] data = packet.ToBytesWithLength();

        foreach (var kvp in clients)
        {
            if (!kvp.Value.TrySend(data))
                Log.LogWarning($"[S] Broadcast to uid={kvp.Key}: send queue full, packet dropped.");
        }
    }

    /// <summary>
    /// 低优先级广播（拥塞时丢弃，用于位置同步等）
    /// </summary>
    public void BroadcastLowPriority(NetPacket packet)
    {
        if (!running) return;
        byte[] data = packet.ToBytesWithLength();

        foreach (var kvp in clients)
        {
            kvp.Value.TrySendLowPriority(data);
        }
    }

    /// <summary>
    /// 向指定 uid 的客机发送
    /// </summary>
    public void SendTo(int uid, NetPacket packet)
    {
        if (!running || !clients.TryGetValue(uid, out var session)) return;

        byte[] data = packet.ToBytesWithLength();
        if (!session.TrySend(data))
            Log.LogWarning($"[S] SendTo uid={uid}: send queue full, packet dropped.");
    }

    /// <summary>
    /// 向除 exceptUid 以外的所有客机发送（主机转发用）
    /// </summary>
    public void SendToExcept(int exceptUid, NetPacket packet)
    {
        if (!running) return;
        byte[] data = packet.ToBytesWithLength();
        SendRawToExcept(exceptUid, data);
    }

    /// <summary>
    /// Zero-copy relay：用已带长度前缀的原始字节直接广播给除 exceptUid 以外的所有客机。
    /// </summary>
    public void SendRawToExcept(int exceptUid, byte[] dataWithLength)
    {
        if (!running) return;

        foreach (var kvp in clients)
        {
            if (kvp.Key == exceptUid) continue;
            if (!kvp.Value.TrySend(dataWithLength))
                Log.LogWarning($"[S] SendRawToExcept uid={kvp.Key}: send queue full, packet dropped.");
        }
    }

    // =========================
    // 断开处理
    // =========================

    /// <summary>
    /// 断开指定客机
    /// </summary>
    public void DisconnectClient(int uid) => HandleClientDisconnected(uid);

    /// <summary>
    /// 断开所有客机
    /// </summary>
    public void DisconnectAllClients()
    {
        foreach (var kvp in clients)
        {
            kvp.Value.Close();
        }
        clients.Clear();
    }

    private void HandleClientDisconnected(int uid)
    {
        if (clients.TryRemove(uid, out var session))
        {
            session.Close();
            Log.LogMessage($"[S] Client uid={uid} disconnected.");
            MpManager.OnClientDisconnected(uid);
        }
    }

    // =========================
    // 工具
    // =========================

    /// <summary>
    /// 是否有任何已连接的客机
    /// </summary>
    public bool HasAnyClient => !clients.IsEmpty;

    /// <summary>
    /// 当前已连接客机数
    /// </summary>
    public int ClientCount => clients.Count;

    /// <summary>
    /// 获取指定客机的 IP
    /// </summary>
    public string GetClientIp(int uid)
    {
        if (clients.TryGetValue(uid, out var session))
        {
            try { return ((IPEndPoint)session.Tcp.Client.RemoteEndPoint)?.Address.ToString() ?? "?"; }
            catch { return "?"; }
        }
        return "?";
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
    private Task sendTask;

    private CancellationTokenSource cts;
    private BlockingCollection<byte[]> _sendQueue;

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

        // Resolve address family: if the host parses as an IPv6 address, use InterNetworkV6;
        // otherwise default to InterNetwork. DNS names use ConnectAsync which resolves automatically.
        TcpClient tcp;
        if (IPAddress.TryParse(host, out var parsedAddr) && parsedAddr.AddressFamily == AddressFamily.InterNetworkV6)
        {
            tcp = new TcpClient(AddressFamily.InterNetworkV6);
        }
        else
        {
            tcp = new TcpClient();
        }

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

            _sendQueue = new BlockingCollection<byte[]>(boundedCapacity: 512);

            receiveTask = Task.Run(() => ReceiveLoopAsync(loopToken), loopToken);
            heartbeatTask = Task.Run(() => HeartbeatLoopAsync(loopToken), loopToken);
            sendTask = Task.Run(() => SendLoopAsync(loopToken), loopToken);

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
                foreach (var (packet, _) in packets)
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

    private async Task SendLoopAsync(CancellationToken token)
    {
        try
        {
            foreach (var data in _sendQueue.GetConsumingEnumerable(token))
            {
                await stream!.WriteAsync(data, 0, data.Length, token);
            }
        }
        catch (OperationCanceledException) { }
        catch (Exception ex)
        {
            Log.LogWarning($"[C] SendLoop error: {ex.Message}");
            await ScheduleReconnectAsync();
        }
    }

    public void Send(NetPacket packet)
    {
        if (!IsConnected)
            return;

        try
        {
            byte[] data = packet.ToBytesWithLength();
            if (!_sendQueue.TryAdd(data))
                Log.LogWarning("[C] Send queue full, packet dropped.");
        }
        catch (Exception ex)
        {
            Log.LogWarning($"[C] Send enqueue failed: {ex.Message}");
        }
    }

    /// <summary>
    /// 发送队列是否拥塞（填充率 > 25%）
    /// </summary>
    public bool IsSendCongested => _sendQueue != null && _sendQueue.Count > _sendQueue.BoundedCapacity / 4;

    /// <summary>
    /// 低优先级发送：拥塞时直接丢弃（用于位置同步等）
    /// </summary>
    public void SendLowPriority(NetPacket packet)
    {
        if (!IsConnected || IsSendCongested)
            return;

        try
        {
            byte[] data = packet.ToBytesWithLength();
            _sendQueue.TryAdd(data);
        }
        catch { }
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
        try { _sendQueue?.CompleteAdding(); } catch { }

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

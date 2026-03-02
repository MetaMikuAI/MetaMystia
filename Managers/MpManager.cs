using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

using MetaMystia.Network;
using MetaMystia.Patch;
using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia;

[AutoLog]
public static partial class MpManager
{
    public enum ROLE
    {
        Host,
        Client
    }

    #region Const Values
    private const int TCP_PORT = 40815;
    public const int HOST_UID = 0;
    public const int UNASSIGNED_UID = -1;
    private const string SyncActionCommandID = "SyncAction";
    #endregion

    #region Multiplayer Related Values
    public static string PlayerId { get => ConfigManager.GetPlayerId(); set => ConfigManager.SetPlayerId(value); }
    public static string PeerAddress { get; set; }
    public static string PeerId { get; set; }
    public static long Latency { get; private set; } = 0;

    public static int ConnectedPlayersCount => PlayerManager.Peers.Count;
    public static int AllPlayersCount => ConnectedPlayersCount + 1;
    #endregion

    private static TcpServer server = null;
    private static TcpClientWrapper client = null;
    private static ROLE Role;
    public static bool IsRunning { get; private set; }
    public static bool IsHost => Role == ROLE.Host;
    public static bool IsClient => Role == ROLE.Client;
    private static bool IsConnecting = false;
    public static bool IsConnected => (IsHost ? server?.HasAnyClient : client?.IsConnected) ?? false;
    public static bool IsConnectedClient => IsConnected && IsClient;
    public static bool IsConnectedHost => IsConnected && IsHost;
    public static string RoleTag => IsHost ? "[S]" : "[C]";
    public static string RoleName => IsHost ? "Host" : "Client";

    private static ConcurrentDictionary<int, long> pingSendTimes = new();
    public static long TimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0;
    public static long GetSynchronizedTimestampNow => TimestampNow - TimeOffset;
    private static int _pingId = 0;

    #region SinglePlay GamePlay Getters
    public static Common.UI.Scene LocalScene { get; private set; } = Common.UI.Scene.EmptyScene;
    public static Common.UI.Scene PeerScene = Common.UI.Scene.EmptyScene;
    #endregion


    #region 剧情相关（待删除）
    // public static bool InStory => Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Playing || Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Delayed;
    public static bool InStory => false; // disable
    public static bool ShouldSkipAction => !IsConnected || InStory;
    #endregion

    public const string PeerGetCharacterUnitNotNullCommand = "PeerGetCharacterUnitNotNullCommand";

    public static int WorkTimeSecondOverride = 9 * 60;

    public static void SwitchRole(bool stop_existed_server = true)
    {
        Log.Message($"Switching role from {Role} to {(IsHost ? "Client" : "Host")}");
        if (IsHost)
        {
            if (stop_existed_server)
            {
                server?.Stop();
                server = null;
            }
            Role = ROLE.Client;
        }
        else
        {
            client?.Close();
            server = new(TCP_PORT);
            server.Start();
            Role = ROLE.Host;
        }
    }

    public static bool Start(ROLE r = ROLE.Host)
    {
        Log.Info($"{DebugText}");
        if (!Plugin.AllPatched)
        {
            PluginManager.Console.LogToConsole($"Cannot start multiplayer, patch failure!\n{DebugText}");
            Log.Fatal($"Cannot start multiplayer, patch failure!\n{DebugText}");
            return false;
        }

        if (IsRunning)
        {
            Log.LogWarning("MpManager is already running");
            return true;
        }

        IsRunning = true;
        PeerId = "<Unknown>";
        Role = r;

        switch (r)
        {
            case ROLE.Host:
                PlayerManager.Local.Uid = HOST_UID;
                server = new(TCP_PORT);
                server.Start();
                Log.LogInfo("Starting MpManager as host");
                break;
            case ROLE.Client:
                PlayerManager.Local.Uid = UNASSIGNED_UID;
                Log.LogInfo("Starting MpManager as client");
                break;
        }
        return true;
    }

    public static void Stop()
    {
        if (!IsRunning)
            return;

        Log.LogInfo("Stopping MpManager");
        IsRunning = false;

        try
        {
            server?.Stop();
            server = null;
            client?.Close();
            client = null;
        }
        catch (Exception e)
        {
            Log.LogError($"Error stopping: {e.Message}");
        }
        Log.LogInfo("MpManager has stopped");
    }

    public static bool Restart()
    {
        Stop();
        return Start(Role);
    }

    public static async Task<bool> ConnectToPeerAsync(string peerIp, int port = TCP_PORT, bool stop_existed_server = true)
    {
        if (!IsRunning && !Start(ROLE.Client))
        {
            return false;
        }

        if (IsConnected)
        {
            Log.LogWarning("[C] Already connected to a peer. Please disconnect first.");
            return false;
        }

        if (IsConnecting)
        {
            Log.LogWarning("[C] Now try connecting to a peer, please wait..");
            return false;
        }

        try
        {
            IsConnecting = true;
            if (IsHost)
            {
                SwitchRole(stop_existed_server);
            }
            PluginManager.Console.LogToConsole(TextId.MpConnecting.Get(peerIp, port));
            Log.LogInfo($"[C] Connecting to {peerIp}:{port}...");
            client = new(peerIp, port);
            await client.StartAsync();
            OnClientConnected(client.GetRealConnectedIp);
            Log.LogMessage($"[C] Successfully connected to peer {peerIp}:{port}");

            return true;
        }
        catch (Exception e)
        {
            Log.LogError($"[C] Error connecting to peer: {e.Message}");
            return false;
        }
        finally
        {
            IsConnecting = false;
        }
    }

    /// <summary>
    /// 客机 TCP 连接建立后调用：发送 Hello 包给主机
    /// </summary>
    public static void OnClientConnected(string ip)
    {
        PeerAddress = ip;
        HelloAction.Send();
    }

    /// <summary>
    /// 客机收到 HelloAck 后调用：握手完成，启动同步
    /// </summary>
    public static void OnHandshakeComplete(string hostId)
    {
        PeerId = hostId;
        SceneTransitAction.Send(LocalScene);
        CommandScheduler.EnqueueInterval(SyncActionCommandID, 0.5f, SyncAction.Send);
        Notify.ShowOnMainThread(TextId.MultiplayerConnected.Get());
    }

    /// <summary>
    /// 主机对新客机握手完成后调用
    /// </summary>
    public static void OnPeerHandshakeComplete(int uid, string peerId)
    {
        PeerId = peerId;
        CommandScheduler.EnqueueInterval(SyncActionCommandID, 0.5f, SyncAction.Send);
    }

    /// <summary>
    /// 客机断开连接时调用
    /// </summary>
    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";
        PlayerManager.ClearPeers();
        PlayerManager.Local.Uid = UNASSIGNED_UID;
        CommandScheduler.RemoveKeyFromKeyQueue(PeerGetCharacterUnitNotNullCommand);
        CommandScheduler.CancelInterval(SyncActionCommandID);
        Notify.ShowOnMainThread(TextId.MultiplayerDisconnected.Get());
    }

    /// <summary>
    /// 主机侧：某个客机断开连接时调用
    /// </summary>
    public static void OnClientDisconnected(int uid)
    {
        if (PlayerManager.Peers.TryGetValue(uid, out var peer))
        {
            Log.LogMessage($"Client uid={uid} (id='{peer.Id}') disconnected");
            Network.PeerLeaveAction.BroadcastPeerLeave(uid);
            PlayerManager.RemovePeer(uid);
        }
        if (PlayerManager.Peers.IsEmpty)
        {
            CommandScheduler.CancelInterval(SyncActionCommandID);
        }
    }

    /// <summary>
    /// 主机侧：收到客机发来的 Action。主机先处理，如果 Action 标记了 HostRelay 则转发。
    /// </summary>
    public static void OnActionFromClient(Network.Action action, int clientUid)
    {
        // 注入发送者 UID
        action.SenderUid = clientUid;

        // 主机先本地处理
        action.OnReceived();

        // 检查是否需要转发给其他客机
        if (action.GetType().GetCustomAttributes(typeof(Network.Action.HostRelayAttribute), false).Length > 0)
        {
            var packet = NetPacket.FromSingleAction(action);
            server?.SendToExcept(clientUid, packet);
        }
    }

    /// <summary>
    /// 客机侧：收到主机发来的 Action
    /// </summary>
    public static void OnAction(Network.Action action)
    {
        action.OnReceived();
    }

    #region 发送方法

    /// <summary>
    /// 客机→主机，或主机→所有客机广播
    /// </summary>
    public static void SendToHostOrBroadcast(NetPacket packet)
    {
        if (IsHost)
        {
            server?.Broadcast(packet);
        }
        else
        {
            client?.Send(packet);
        }
    }

    /// <summary>
    /// 客机→主机
    /// </summary>
    public static void SendToHost(NetPacket packet)
    {
        if (!IsClient) return;
        client?.Send(packet);
    }

    /// <summary>
    /// 主机→指定客机
    /// </summary>
    public static void SendToClient(int uid, NetPacket packet)
    {
        if (!IsHost) return;
        server?.SendTo(uid, packet);
    }

    /// <summary>
    /// 主机→除了 exceptUid 以外的所有客机
    /// </summary>
    public static void SendToAllExcept(int exceptUid, NetPacket packet)
    {
        if (!IsHost) return;
        server?.SendToExcept(exceptUid, packet);
    }

    #endregion

    public static void DisconnectPeer()
    {
        if (IsConnected)
        {
            if (IsHost)
            {
                server.DisconnectAllClients();
            }
            else
            {
                client.Close();
            }
            Log.LogMessage("All peer connections disconnected");
        }
    }

    /// <summary>
    /// 主机断开指定客机
    /// </summary>
    public static void DisconnectClient(int uid)
    {
        if (!IsHost) return;
        server?.DisconnectClient(uid);
    }

    /// <summary>
    /// Peer A -> Ping -> Peer B
    /// Peer A <- Pong <- Peer B
    /// Peer A calculates latency
    /// </summary>
    public static void SendPing()
    {
        if (!IsConnected) return;
        var t = TimestampNow;
        int id = _pingId++;
        pingSendTimes[id] = t;
        if (IsHost)
        {
            // 主机向所有客机发 Ping
            var action = new PingAction { Id = id };
            var packet = NetPacket.FromSingleAction(action);
            server?.Broadcast(packet);
        }
        else
        {
            PingAction.SendPing(id);
        }
    }

    public static void UpdateLatency(int id)
    {
        if (!pingSendTimes.TryRemove(id, out long t)) return;
        Latency = (TimestampNow - t) / 2;
    }

    public static string GetStatus()
    {
        StringBuilder status = new();
        status.AppendLine($"Mystia ID: {PlayerId}");
        status.AppendLine($"Local Port: {TCP_PORT}");
        status.AppendLine($"Running: {(IsRunning ? "Yes" : "No")}");
        status.AppendLine($"Connected: {(IsConnected ? "Yes" : "No")}");
        if (IsConnected)
        {
            status.AppendLine($"Kyouko ID: {PeerId}");
            status.AppendLine($"Kyouko Address: {PeerAddress ?? "<Unknown>"}");
            status.AppendLine($"Latency: {Latency} ms");
        }

        return status.ToString();
    }

    public static string BriefStatus
    {
        get
        {
            if (!Plugin.AllPatched)
            {
                return $"{TextId.ModPatchFailure.Get()} {BriefDebugText}";
            }
            if (!IsRunning)
            {
                return "Multiplayer: Off";
            }
            if (IsConnected)
            {
                return $"Multiplayer: {RoleTag} Connected to {PeerId} ({PeerAddress}), ping: {Latency} ms";
            }
            else
            {
                return $"Multiplayer: On (Not connected) as {RoleName}";
            }
        }
    }

    public static string DebugText
    {
        get
        {
            StringBuilder sb = new();
            sb.AppendLine($"{BriefDebugText}");
            sb.AppendLine($"{BriefStatus}");
            return sb.ToString();
        }
    }

    private static string BriefDebugText =>
        $"{Plugin.GameVersion}: {Plugin.ModVersion}, {System.Runtime.InteropServices.RuntimeInformation.OSDescription}, {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}, {DateTimeOffset.Now}";

    public static void OnSceneTransit(Common.UI.Scene newScene)
    {
        Log.Message($"LocalScene transit from {LocalScene} -> {newScene}");
        SceneTransitAction.Send(newScene);
        LocalScene = newScene;
        if (newScene == Common.UI.Scene.MainScene && IsConnected)
        {
            Log.Message($"Transit to {newScene}, disconnecting peers");
            DisconnectPeer();
        }
    }

    public static void DayOver()
    {
        if (!IsConnectedHost) return;
        Log.Message($"DayOver check: AllDayOver={PlayerManager.AllDayOver}");
        if (PlayerManager.AllDayOver)
        {
            ReadyAction.Broadcast(ReadyType.DayOver);

            // For host who will not receive DayOver allready
            CommandScheduler.EnqueueWithNoCondition(() =>
            {
                Notify.ShowOnMainThread(TextId.AllReadyTransition.Get());
                DaySceneManagerPatch.OnDayOver();
            });
        }
    }

    public static void PrepOver()
    {
        if (!IsConnectedHost) return;
        Log.Message($"PrepOver check: AllPrepOver={PlayerManager.AllPrepOver}");

        if (PlayerManager.AllPrepOver)
        {
            ReadyAction.Broadcast(ReadyType.PrepOver);

            // For host who will not receive PrepOver allready
            CommandScheduler.EnqueueWithNoCondition(IzakayaConfigPannelPatch.PrepOver);
        }
    }
}

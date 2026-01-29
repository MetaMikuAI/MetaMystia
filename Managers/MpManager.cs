using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MetaMystia.Network;
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
    public const long SERVER_ID = 0;
    public const long NOT_CONNECTED_CLIENT_ID = -1;
    private const string SyncActionCommandID = "SyncAction";
    #endregion

    #region Multiplayer Related Values
    public static string PlayerId { get; set { field = value; Log.Info($"Player ID set to: {value}"); } } = Environment.MachineName;
    public static string PeerAddress { get; set; }
    public static string PeerId { get; set; }
    public static long Latency { get; private set; } = 0;

    public static int ConnectedPlayersCount => IsConnected ? 1 : 0;
    public static int AllPlayersCount => ConnectedPlayersCount + 1;
    #endregion

    private static TcpServer server = null;
    private static TcpClientWrapper client = null;
    private static ROLE Role;
    public static bool IsRunning { get; private set; }
    public static bool IsHost => Role == ROLE.Host;
    public static bool IsClient => Role == ROLE.Client;
    private static bool IsConnecting = false;
    public static bool IsConnected => (IsHost ? server?.HasAliveClient : client?.IsConnected) ?? false;
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
    public static List<string> ActiveDLCLabel => DLCManager.ActiveDLCLabel;
    public static bool InStory => Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Playing || Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Delayed;
    public static bool ShouldSkipAction => !IsConnected || InStory;
    public static bool InputAvailable => Common.UI.UniversalGameManager.IsInputEnabled;

    public static string GameVersion => Common.LoadingSceneManager.VersionData;
    public static string ModVersion => MyPluginInfo.PLUGIN_VERSION;
    public static Language Language => Common.UI.EscapeUtility.EscConfigPannel.CurrentSettings.CurrentLanguage.GetLanguage();

    public const string PeerGetCharacterUnitNotNullCommand = "PeerGetCharacterUnitNotNullCommand";

    #endregion
    #region Multiplayer GamePlay Getters

    public static float MultiplayerTipModifier => AllPlayersCount switch
    {
        1 => 1.0f,  // 4 min = 4 + time pause
        2 => 0.8f,  // 9 min = 7.2
        3 => 0.75f, // 11 min = 8.25
        4 => 0.68f, // 13 min = 8.84
        _ => 0.6f
    };
    public static float MultiplayerFundModifier => AllPlayersCount switch
    {
        1 => 1.0f,  // 4 min = 4 + time pause
        2 => 0.9f,  // 9 min = 8.1
        3 => 0.85f, // 11 min = 9.35
        4 => 0.8f,  // 13 min = 10.4
        _ => 0.7f
    };
    public static int WorkTimeModifier => AllPlayersCount switch
    {
        1 => 4 * 60,
        2 => 9 * 60,
        3 => 11 * 60,
        4 => 13 * 60,
        _ => 15
    };

    #endregion

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
        if (!Plugin.AllPatched)
        {
            PluginManager.Console.LogToConsole($"Cannot start multiplayer, patch failure!\n{DumpDebugText()}");
            Log.Fatal($"Cannot start multiplayer, patch failure!\n{DumpDebugText()}");
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
        Log.Info(DumpDebugText());
        switch (r)
        {
            case ROLE.Host:
                server = new(TCP_PORT);
                server.Start();
                Log.LogInfo("Starting MpManager as host");
                break;
            case ROLE.Client:
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

    public static void Initialize()
    {
        Log.LogInfo($"MpManager initialized");
        MystiaManager.Initialize();
        PeerManager.Initialize();
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
            OnConnected(client.GetRealConnectedIp);
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

    public static void OnConnected(string ip)
    {
        // PeerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        PeerAddress = ip;
        HelloAction.Send();
        SceneTransitAction.Send(LocalScene);
        CommandScheduler.EnqueueInterval(SyncActionCommandID, 0.5f, SyncAction.Send);
        CommandScheduler.EnqueueKey(
            key: PeerGetCharacterUnitNotNullCommand,
            executeWhen: () => PeerManager.GetCharacterUnit() != null,
            execute: () =>
            {
                if (!InStory)
                {
                    PeerManager.EnableCollision(true);
                }
                PeerManager.GetCharacterComponent()?.UpdateIcon(false);
            },
            timeoutSeconds: 120
        );
        Notify.ShowOnMainThread($"联机系统：已连接！");
    }


    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";
        DLCManager.ClearPeer();
        CommandScheduler.EnqueueWithNoCondition(() =>
        {
            if (PeerManager.GetCharacterUnit() != null)
            {
                PeerManager.EnableCollision(false);
                PeerManager.GetCharacterComponent()?.UpdateIcon(true);
            }
        });
        CommandScheduler.RemoveKeyFromKeyQueue(PeerGetCharacterUnitNotNullCommand);
        CommandScheduler.CancelInterval(SyncActionCommandID);
        Notify.ShowOnMainThread($"联机系统：连接已断开！");
    }

    public static void OnAction(Network.Action action)
    {
        action.OnReceived();
    }

    public static void SendToHostOrBroadcast(NetPacket packet)
    {
        if (IsHost)
        {
            server?.Send(packet);
        }
        else
        {
            client?.Send(packet);
        }
    }

    public static void SendToPeer(NetPacket packet)
    {
        if (IsHost)
        {
            server?.Send(packet);
        }
        else
        {
            client?.Send(packet);
        }
    }

    public static void DisconnectPeer()
    {
        if (IsConnected)
        {
            if (IsHost)
            {
                server.DisconnectClient();
            }
            else
            {
                client.Close();
            }
            Log.LogMessage("Peer connection disconnected");
        }
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
        PingAction.SendToPeer(0, id);
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

    public static string GetBriefStatus()
    {
        if (!Plugin.AllPatched)
        {
            return "Patch failure!!! The game will not function normally! Please remove the mod or contact mod developer!";
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
            return $"Multiplayer: On (Not connected) as {(Role == ROLE.Host ? "Host" : "Client")}";
        }
    }

    public static string DumpDebugText()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{DateTimeOffset.Now}, {System.Runtime.InteropServices.RuntimeInformation.OSDescription}, {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}");
        sb.AppendLine($"{GameVersion}, {PluginManager.Label}");
        sb.AppendLine(GetBriefStatus());
        sb.AppendLine($"DLC: {string.Join(", ", ActiveDLCLabel)}");
        return sb.ToString();
    }

    public static void OnSceneTransit(Common.UI.Scene newScene)
    {
        Log.Message($"LocalScene transit from {LocalScene} -> {newScene}");
        SceneTransitAction.Send(newScene);
        LocalScene = newScene;
    }

    public static void DayOver(long clientId)
    {
        if (!IsConnectedHost) return;
        Log.Message($"{PeerId} dayover");
        if (PeerManager.IsDayOver && MystiaManager.IsDayOver)
        {
            ReadyAction.Broadcast(ReadyType.DayOver);

            // For host who will not receive DayOver allready
            CommandScheduler.EnqueueWithNoCondition(() => Dialog.ShowReadyDialog(true, DaySceneManagerPatch.OnDayOver));
        }
    }

    public static void PrepOver(long clientId)
    {
        if (!IsConnectedHost) return;
        Log.Message($"{PeerId} prep over");

        if (PeerManager.IsPrepOver && MystiaManager.IsPrepOver)
        {
            ReadyAction.Broadcast(ReadyType.PrepOver);

            // For host who will not receive PrepOver allready
            CommandScheduler.EnqueueWithNoCondition(IzakayaConfigPannelPatch.PrepOver);
        }
    }
}

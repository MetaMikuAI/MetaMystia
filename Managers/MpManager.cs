using System;
using System.Text;
using System.Threading.Tasks;

namespace MetaMystia;

[AutoLog]
public static partial class MpManager
{
    public enum ROLE
    {
        Host,
        Client
    }

    private const int TCP_PORT = 40815;
    private static string _playerId = Environment.MachineName;
    public static string PlayerId { get { return _playerId; } set { _playerId = value; Log.LogInfo($"Player ID set to: {value}"); } }
    private static TcpServer server = null;
    private static TcpClientWrapper client = null;
    private static ROLE Role;
    private static ROLE GameRole;
    public static bool IsRunning { get; private set; }
    public static bool IsConnected => (IsHost ? server?.HasAliveClient : client?.IsConnected)?? false;
    public static string PeerAddress {get; set;}
    public static string PeerId {get; set;}
    public static long Latency {get; private set;} = 0;
    private static System.Collections.Concurrent.ConcurrentDictionary<int, long> pingSendTimes = new();
    public static long TimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0;
    public static long GetSynchronizedTimestampNow => TimestampNow - TimeOffset;
    private static int _pingId = 0;

    public static bool IsConnectedClient => IsConnected && IsClient;
    public static bool IsConnectedHost => IsConnected && IsHost;
    public static bool IsHost => Role == ROLE.Host;
    public static bool IsClient => Role == ROLE.Client;
    public static string RoleTag => IsHost ? "[S]" : "[C]";
    public static string RoleName => IsHost ? "Host" : "Client";

    public static bool IsGameRoleHost => GameRole == ROLE.Host;
    public static bool IsGameRoleClient => GameRole == ROLE.Client;

    public static Common.UI.Scene LocalScene {get; private set;} = Common.UI.Scene.EmptyScene;
    public static Common.UI.Scene PeerScene;

    public static System.Collections.Generic.List<string> ActiveDLCLabel => DLCManager.ActiveDLCLabel;
    public static System.Collections.Generic.List<string> PeerActiveDLCLabel => DLCManager.PeerActiveDLCLabel;

    public static bool InStory => Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Playing || Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Delayed;
    public static bool InputAvailable => Common.UI.UniversalGameManager.IsInputEnabled;

    public static string GameVersion => Common.LoadingSceneManager.VersionData;
    public static string ModVersion => MyPluginInfo.PLUGIN_VERSION;
    public static string PeerGameVersion = "";
    
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
        GameRole = Role;
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
        GameRole = Role;
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
        KyoukoManager.Initialize();
    }

    public static bool Restart()
    {
        Stop();
        return Start(Role);
    }

    public static async Task<bool> ConnectToPeerAsync(string peerIp, int port = TCP_PORT, bool stop_existed_server = true)
    {
        if (!IsRunning)
        {
            if (!Start(ROLE.Client))
            {
                return false;
            }
        }

        if (IsConnected)
        {
            Log.LogWarning("[C] Already connected to a peer. Please disconnect first.");
            return false;
        }

        try
        {
            if (IsHost)
            {
                SwitchRole(stop_existed_server);
            }

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
    }

    public static void OnConnected(string ip)
    {
        // PeerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        PeerAddress = ip;
        HelloAction.Send();
        SceneTransitAction.Send(LocalScene);
        SyncAction.Send();
        Notify.ShowOnMainThread($"联机系统：已连接！");
    }
    

    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";
        PeerGameVersion = "";
        DLCManager.ClearPeer();
        Notify.ShowOnMainThread($"联机系统：连接已断开！");
    }

    public static void OnAction(NetAction action)
    {
        action.OnReceived();
    }

    public static void SendToPeer(NetPacket packet)
    {
        if (IsConnected)
        {
            packet.GetFirstAction().LogActionSend(true);
            if (IsHost)
            {
                server.Send(packet);
            }
            else
            {
                client.Send(packet);
            }
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
        SendToPeer(PingAction.CreatePingPacket(id));
    }

    public static void SendPong(int id)
    {
        SendToPeer(PongAction.CreatePongPacket(id));
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
}

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
        Client,
        Both    // For debug
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
    public static long GetTimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0;
    public static long GetSynchronizedTimestampNow => GetTimestampNow - TimeOffset;
    private static int _pingId = 0;

    public static bool IsConnectedClient => IsConnected && IsClient;
    public static bool IsConnectedHost => IsConnected && IsHost;
    public static bool IsHost => Role == ROLE.Host;
    public static bool IsClient => Role == ROLE.Client;
    public static string RoleTag => IsHost ? "[S]" : "[C]";

    public static bool IsGameRoleHost => GameRole == ROLE.Host;
    public static bool IsGameRoleClient => GameRole == ROLE.Client;

    public static Common.UI.Scene LocalScene => PluginManager.CurrentGameScene;

    public static System.Collections.Generic.List<string> LocalActiveDLCLabel => DLCManager.ActiveDLCLabel;
    public static System.Collections.Generic.List<string> PeerActiveDLCLabel => DLCManager.PeerActiveDLCLabel;

    public static void Start(ROLE r = ROLE.Host)
    {
        if (IsRunning)
        {
            Log.LogWarning("MpManager is already running");
            return;
        }

        IsRunning = true;
        PeerId = "<Unknown>";
        Role = r;
        GameRole = Role;

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
            case ROLE.Both:
                server.Start();
                Log.LogInfo("Starting MpManager as both host and client");
                break;
        }
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
            client?.Close();
            OnDisconnected();
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
        MystiaManager.Instance.Initialize();
        KyoukoManager.Initialize();
    }

    public static void Restart()
    {
        Stop();
        Start(Role);
    }

    public static async Task<bool> ConnectToPeerAsync(string peerIp, int port = TCP_PORT)
    {
        if (!IsRunning)
        {
            Start(ROLE.Client);
        }

        if (IsConnected)
        {
            Log.LogWarning("[C] Already connected to a peer. Please disconnect first.");
            return false;
        }

        try
        {
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
        SendHello();
        SendSync();
        Notify.ShowOnMainThread($"联机系统：已连接！");
    }
    

    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";
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
        var t = GetTimestampNow;
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
        Latency = (GetTimestampNow - t) / 2;
    }

    public static void SendHello()
    {
        SendToPeer(new NetPacket([new HelloAction { 
            PeerId = PlayerId,
            PeerActiveDLCLabel = LocalActiveDLCLabel,
            Version = MyPluginInfo.PLUGIN_VERSION,
            CurrentGameScene = LocalScene,
            PeerDLCBeverages = DLCManager.Beverages,
            PeerDLCCookers = DLCManager.Cookers,
            PeerDLCFoods = DLCManager.Foods,
            PeerDLCNormalGuests = DLCManager.NormalGuests,
            PeerDLCRecipes = DLCManager.Recipes,
            PeerDLCSpecialGuests = DLCManager.SpecialGuests,
        }]));
    }

    public static void SendSync()
    {
        if (!IsConnected)
        {
            return;
        }

        var inputDirection = MystiaManager.InputDirection;
        var position = MystiaManager.Instance.GetPosition();

        NetPacket packet;
        if (LocalScene == Common.UI.Scene.WorkScene)
        {
            packet = new NetPacket([new NightSyncAction
            {
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                Px = position.x,
                Py = position.y
            }]);
        }
        else
        {
            var mapLabel = MystiaManager.MapLabel;
            var isSprinting = MystiaManager.IsSprinting;

            packet = new NetPacket([new SyncAction
            {
                IsSprinting = isSprinting,
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                MapLabel = mapLabel,
                Px = position.x,
                Py = position.y
            }]);
        }

        SendToPeer(packet);
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
            return "Multiplayer: On (Not connected)";
        }
    }
}

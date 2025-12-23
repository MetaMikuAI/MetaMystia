using System;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;

namespace MetaMystia;

public static class MpManager
{
    public enum ROLE
    {
        Host,
        Client,
        Both    // For debug
    }

    private static ManualLogSource Log => Plugin.Instance.Log;
    private const int TCP_PORT = 40815;
    private static string _playerId = Environment.MachineName;
    public static string PlayerId { get { return _playerId; } set { _playerId = value; Log.LogInfo($"Player ID set to: {value}"); } }
    private static TcpServer server = null;
    private static TcpClientWrapper client = null;
    public static ROLE Role {get; private set;}
    public static bool IsRunning { get; private set; }
    public static bool IsConnected => (Role == ROLE.Host ? server?.HasAliveClient : client?.IsConnected)?? false;
    public static string PeerAddress {get; set;}
    public static string PeerId {get; set;}
    public static long Latency {get; private set;} = 0;
    private static System.Collections.Concurrent.ConcurrentDictionary<int, long> pingSendTimes = new();
    public static long GetTimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0;
    public static long GetSynchronizedTimestampNow => GetTimestampNow - TimeOffset;
    private static int _pingId = 0;

    public static bool IsConnectedClient => IsConnected && Role == ROLE.Client;
    public static bool IsConnectedHost => IsConnected && Role == ROLE.Host;

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
    }
    

    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";
    }

    public static void OnAction(NetAction action)
    {
        action.OnReceived();
    }

    private static void SendToPeer(NetPacket packet)
    {
        if (IsConnected)
        {
            packet.GetFirstAction().LogActionSend(true, Role == ROLE.Host ? "[S] " : "[C] ");
            if (Role == ROLE.Host)
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
            if (Role == ROLE.Host)
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
        SendToPeer(new NetPacket([new HelloAction { PeerId = PlayerId }]));
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
        if (PluginManager.CurrentGameScene == Common.UI.Scene.WorkScene)
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

    public static void SendReady()
    {
        NetPacket packet = new NetPacket([new ReadyAction
        {
            IsReady = true
        }]);
        SendToPeer(packet);
    }

    public static void SendMessage(string message)
    {
        FloatingTextHelper.ShowFloatingTextSelfOnMainThread(message);
        PluginManager.Instance.RunOnMainThread(() => Notify.Show($"你: {message}"));
        SendToPeer(MessageAction.CreateMsgPacket(message));
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
            return $"Multiplayer: [{(Role == ROLE.Host ? "S" : "C")}] Connected to {PeerId} ({PeerAddress}), ping: {Latency} ms";
        }
        else
        {
            return "Multiplayer: On (Not connected)";
        }
    }

    public static void SendSelectedIzakaya(string mapLabel, int level)
    {
        NetPacket packet = new NetPacket([new SelectAction
        {
            MapLabel = mapLabel,
            Level = level
        }]);
        SendToPeer(packet);
    }
    public static void SendConfirmedIzakaya(string mapLabel, int level)
    {
        NetPacket packet = new NetPacket([new ConfirmAction
        {
            MapLabel = mapLabel,
            Level = level
        }]);
        SendToPeer(packet);
    }

    public static void SendPrep(PrepAction.Table prepTable, bool ready = false)
    {
        NetPacket packet = new NetPacket([new PrepAction
        {
            PrepTable = prepTable,
            Ready = ready
        }]);
        SendToPeer(packet);
    }

    
    public static void SendCook(int gridIndex, SellableFood food, int recipeId)
    {
        NetPacket packet = new NetPacket([new CookAction
        {
            GridIndex = gridIndex,
            RecipeId = recipeId,
            Food = food
        }]);
        SendToPeer(packet);
    }

    public static void SendExtract(int gridIndex)
    {
        NetPacket packet = new NetPacket([new ExtractAction
        {
            GridIndex = gridIndex
        }]);
        SendToPeer(packet);
    }

    public static void SendQTE(int gridIndex, float qteScore)
    {
        NetPacket packet = new NetPacket([new QTEAction
        {
            GridIndex = gridIndex,
            QTEScore = qteScore
        }]);
        SendToPeer(packet);
    }
    
    public static void SendStoreFood(SellableFood food)
    {
        NetPacket packet = new NetPacket([new StoreFoodAction
        {
            Food = food
        }]);
        SendToPeer(packet);
    }

    public static void SendExtractFood(SellableFood food)
    {
        NetPacket packet = new NetPacket([new ExtractFoodAction
        {
            Food = food
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestSpawn(int guest, bool isSpecial, string uuid, 
        UnityEngine.Color? bgColor = null, UnityEngine.Color? textColor = null, int? guest2 = null)
    {
        NetPacket packet = new NetPacket([new GuestSpawnAction
        {
            GuestId = guest,
            IsSpecial = isSpecial,
            UUID = uuid,
            BGColor = bgColor,
            TextColor = textColor,
            GuestId2 = guest2
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestSeated(string guestUniqId, int deskId, bool firstSpawn)
    {
        NetPacket packet = new NetPacket([new GuestSeatedAction
        {
            GuestUniqId = guestUniqId,
            DeskId = deskId,
            FirstSpawn = firstSpawn
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestGenNormalOrder(string guestUniqId, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodId, requestBevId, deskCode, notShowInUI, isFree);
        NetPacket packet = new NetPacket([new GuestGenNormalOrderAction
        {
            GuestUniqId = guestUniqId,
            Order = order,
            Message = message
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestGenSPOrder(string guestUniqId, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodTag, requestBevTag, deskCode, notShowInUI, isFree);
        NetPacket packet = new NetPacket([new GuestGenSPOrderAction
        {
            GuestUniqId = guestUniqId,
            Order = order,
            Message = message
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestServe(string guestUniqId, SellableFood food, int beverageId, GuestServeAction.ServeType type)
    {
        NetPacket packet = new NetPacket([new GuestServeAction
        {
            GuestUniqId = guestUniqId,
            Food = food,
            BeverageId = beverageId,
            FoodType = type
        }]);
        SendToPeer(packet);
    }

    public static void SendGuestLeave(string guest, GuestLeaveAction.LeaveType leaveType)
    {
        NetPacket packet = new NetPacket([new GuestLeaveAction
        {
            GuestUniqId = guest,
            LType = leaveType
        }]);
        SendToPeer(packet);
    }
}

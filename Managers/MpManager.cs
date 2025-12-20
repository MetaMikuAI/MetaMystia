using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
    public static bool IsConnected { get; private set; }
    public static string PeerAddress {get; set;}
    public static string PeerId {get; set;}
    public static long Latency {get; private set;} = 0;
    private static System.Collections.Concurrent.ConcurrentDictionary<int, long> pingSendTimes = new();
    public static long GetTimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0;
    public static long GetSynchronizedTimestampNow => GetTimestampNow - TimeOffset;
    private static int _pingId = 0;

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

    public static bool ConnectToPeer(string peerIp, int port = TCP_PORT)
    {
        if (IsConnected)
        {
            Log.LogWarning("[C] Already connected to a peer. Please disconnect first.");
            return false;
        }

        if (!IsRunning)
        {
            Start(ROLE.Client);
        }
        try
        {
            Log.LogInfo($"[C] Connecting to {peerIp}:{port}...");
            client = new(peerIp, port);
            OnConnected(client.client);
            Log.LogMessage($"[C] Successfully connected to peer {peerIp}:{port}");

            return true;
        }
        catch (Exception e)
        {
            Log.LogError($"[C] Error connecting to peer: {e.Message}");
            return false;
        }
    }


    public static void OnConnected(TcpClient client)
    {
        PeerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        IsConnected = true;
        SendHello();
        SendSync();
    }

    public static void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        PeerId = "<Unknown>";

        IsConnected = false;
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
        SendToPeer(NetPacket.Create(new HelloAction { PeerId = PlayerId }));
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
            packet = NetPacket.Create(new NightSyncAction
            {
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                Px = position.x,
                Py = position.y
            });
        }
        else
        {
            var mapLabel = MystiaManager.MapLabel;
            var isSprinting = MystiaManager.IsSprinting;

            packet = NetPacket.Create(new SyncAction
            {
                IsSprinting = isSprinting,
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                MapLabel = mapLabel,
                Px = position.x,
                Py = position.y
            });
        }

        SendToPeer(packet);
    }

    public static void SendReady()
    {
        NetPacket packet = NetPacket.Create(new ReadyAction
        {
            IsReady = true
        });
        SendToPeer(packet);
    }

    public static void SendMessage(string message)
    {
        FloatingTextHelper.ShowFloatingTextSelfOnMainThread(message);
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
        NetPacket packet = NetPacket.Create(new SelectAction
        {
            MapLabel = mapLabel,
            Level = level
        });
        SendToPeer(packet);
    }
    public static void SendConfirmedIzakaya(string mapLabel, int level)
    {
        NetPacket packet = NetPacket.Create(new ConfirmAction
        {
            MapLabel = mapLabel,
            Level = level
        });
        SendToPeer(packet);
    }

    public static void SendPrep(PrepAction.Table prepTable, bool ready = false)
    {
        NetPacket packet = NetPacket.Create(new PrepAction
        {
            PrepTable = prepTable,
            Ready = ready
        });
        SendToPeer(packet);
    }

    
    public static void SendCook(int gridIndex, SellableFood food, int recipeId)
    {
        NetPacket packet = NetPacket.Create(new CookAction
        {
            GridIndex = gridIndex,
            RecipeId = recipeId,
            Food = food
        });
        SendToPeer(packet);
    }

    public static void SendExtract(int gridIndex)
    {
        NetPacket packet = NetPacket.Create(new ExtractAction
        {
            GridIndex = gridIndex
        });
        SendToPeer(packet);
    }

    public static void SendQTE(int gridIndex, float qteScore)
    {
        NetPacket packet = NetPacket.Create(new QTEAction
        {
            GridIndex = gridIndex,
            QTEScore = qteScore
        });
        SendToPeer(packet);
    }
    
    public static void SendStoreFood(SellableFood food)
    {
        NetPacket packet = NetPacket.Create(new StoreFoodAction
        {
            Food = food
        });
        SendToPeer(packet);
    }

    public static void SendExtractFood(SellableFood food)
    {
        NetPacket packet = NetPacket.Create(new ExtractFoodAction
        {
            Food = food
        });
        SendToPeer(packet);
    }

    public static void SendGuestSpawn(int guest, bool isSpecial, string uuid)
    {
        NetPacket packet = NetPacket.Create(new GuestSpawnAction
        {
            GuestId = guest,
            IsSpecial = isSpecial,
            UUID = uuid
        });
        SendToPeer(packet);
    }

    public static void SendGuestSeated(string guestUniqId, int deskId, bool firstSpawn)
    {
        NetPacket packet = NetPacket.Create(new GuestSeatedAction
        {
            GuestUniqId = guestUniqId,
            DeskId = deskId,
            FirstSpawn = firstSpawn
        });
        SendToPeer(packet);
    }

    public static void SendGuestGenNormalOrder(string guestUniqId, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        NetPacket packet = NetPacket.Create(new GuestGenNormalOrderAction
        {
            GuestUniqId = guestUniqId,
            RequestFoodId = requestFoodId,
            RequestBevId = requestBevId,
            DeskCode = deskCode,
            NotShowInUI = notShowInUI,
            IsFree = isFree,
            Message = message
        });
        SendToPeer(packet);
    }

    public static void SendGuestGenSPOrder(string guestUniqId, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        NetPacket packet = NetPacket.Create(new GuestGenSPOrderAction
        {
            GuestUniqId = guestUniqId,
            RequestFoodTag = requestFoodTag,
            RequestBevTag = requestBevTag,
            DeskCode = deskCode,
            NotShowInUI = notShowInUI,
            IsFree = isFree,
            Message = message
        });
        SendToPeer(packet);
    }
}

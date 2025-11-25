using System;

using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using BepInEx.Logging;
using Il2CppMono;
using UnityEngine;


namespace MetaMystia;

public class MpManager
{
    private static MpManager _instance;
    private static readonly object _lock = new();
    private static ManualLogSource Log => Plugin.Instance.Log;
    private const int TCP_PORT = 40815;
    private string _playerId;
    public string PlayerId {get; set { _playerId = value; Log.LogInfo($"Player ID set to: {value}");}} = System.Environment.MachineName;
    private TcpServer server = new(TCP_PORT);
    private TcpClientWrapper client = null;
    public bool IsHost {get; private set; } = false;
    public bool IsRunning {get; private set;} = false;
    public bool IsConnected {get; private set;} = false;
    public string PeerAddress {get; set;}
    public string PeerId {get; set;} = "<Unknown>";
    private long LastPingTimestamp = 0;
    public long Latency {get; private set;} = 0;

    public static MpManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new MpManager();
                }
            }
            return _instance;
        }
    }

    private MpManager()
    {
    }

    public void Start()
    {
        if (IsRunning)
        {
            Log.LogWarning("MpManager is already running");
            return;
        }

        IsRunning = true;
        Log.LogInfo("Starting MpManager");
        PeerId = "<Unknown>";

        server.Start();
    }

    public void Stop()
    {
        if (!IsRunning)
            return;

        Log.LogInfo("Stopping MpManager");
        IsRunning = false;

        try
        {
            server.Stop();
            client?.Close();
        }
        catch (Exception e)
        {
            Log.LogError($"Error stopping: {e.Message}");
        }

        PeerId = "<Unknown>";
        Log.LogInfo("MpManager has stopped");
    }

    public void Restart()
    {
        Stop();
        Start();
    }

    public void ToggleRunning()
    {
        if (IsRunning)
        {
            Log.LogInfo("Stopping MpManager...");
            Stop();
        }
        else
        {
            Log.LogInfo("Attempting to start MpManager...");
            Start();
        }
    }


    public bool ConnectToPeer(string peerIp)
    {
        if (IsConnected)
        {
            Log.LogWarning("Already connected to a peer. Please disconnect first.");
            return false;
        }

        try
        {
            Log.LogInfo($"Connecting to {peerIp}:{TCP_PORT}...");
            client = new(peerIp, TCP_PORT);
            Log.LogMessage($"Successfully connected to peer {peerIp}:{TCP_PORT}");

            return true;
        }
        catch (Exception e)
        {
            Log.LogError($"Error connecting to peer: {e.Message}");
            return false;
        }
    }


    public void OnConnected(TcpClient client, bool IsHost = false)
    {
        PeerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        Instance.IsConnected = true;
        Instance.IsHost = IsHost;
        SendHello();
        SendPing();
        SendMapLabel();
    }

    public void OnDisconnected()
    {
        PeerAddress = "<Unknown>";
        Instance.IsHost = false;
        Instance.IsConnected = false;
    }

    public void OnAction(NetAction action)
    {
        action.OnReceived();
    }

    private void SendToPeer(NetPacket packet)
    {
        if (!IsConnected)
        {
            Log.LogWarning("Cannot send message: not connected to a peer");
            return;
        }

        if (IsHost)
        {
            Log.LogInfo($"[S] Sending {packet.Actions[0].Type}");

            TcpClientWrapper.Send(server.currentClient, packet);
        } 
        else
        {
            Log.LogInfo($"[C] Sending {packet.Actions[0].Type}");
            client.Send(packet);
        }
    }
    
    public void DisconnectPeer()
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
        }
        Log.LogInfo("Peer connection disconnected");
    }

    public void SendPing()
    {
        if (IsConnected)
        {
            Log.LogInfo("Sending ping to peer");
            LastPingTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            NetPacket pingPacket = new() {  };
            pingPacket.Actions.Add(new PingAction { Timestamp = LastPingTimestamp });
            SendToPeer(pingPacket);
        }
        else
        {
            Log.LogWarning("Cannot send ping: not connected");
        }
    }

    public void ResponsePong()
    {
        if (IsConnected)
        {
            Log.LogInfo("Sending pong to peer");
            NetPacket pongPacket = new() {  };
            pongPacket.Actions.Add(new PongAction { Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() });
            SendToPeer(pongPacket);
        }
        else
        {
            Log.LogWarning("Cannot send ping: not connected");
        }
    }

    public void UpdateLatency(long PongTimestamp)
    {
        Latency = PongTimestamp - LastPingTimestamp;
    }

    public void SendHello()
    {
        if (IsConnected)
        {
            Log.LogInfo("Sending hello to peer");
            NetPacket packet = new() {  };
            packet.Actions.Add(new HelloAction { PeerId = PlayerId });
            SendToPeer(packet);
        }
        else
        {
            Log.LogWarning("Cannot send hello: not connected");
        }
    }

    public void SendMoveData(UnityEngine.Vector2 inputDirection)
    {
        if (IsConnected)
        {
            var position = MystiaManager.Instance.GetPosition();
            NetPacket packet = new() { };
            packet.Actions.Add(new MoveAction
            {
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                Px = position.x,
                Py = position.y
            });
            SendToPeer(packet);
        }
    }

    public void SendSprintData(bool isSprinting)
    {
        if (IsConnected)
        {
            var position = MystiaManager.Instance.GetPosition();
            NetPacket packet = new() { };
            packet.Actions.Add(new SprintAction
            {
                IsSprinting = isSprinting,
                Px = position.x,
                Py = position.y
            });
            SendToPeer(packet);
        }
    }

    public void SendMapLabel()
    {
        if (IsConnected)
        {
            var mapLabel = MystiaManager.MapLabel;
            var position = MystiaManager.Instance.GetPosition();
            NetPacket packet = new() { };
            packet.Actions.Add(new EnterMapAction
            {
                MapLabel = mapLabel,
                Px = position.x,
                Py = position.y
            });
            SendToPeer(packet);
        }
    }

    public void SendReady()
    {
        if (IsConnected)
        {
            NetPacket packet = new() { };
            packet.Actions.Add(new ReadyAction
            {
                IsReady = true
            });
            SendToPeer(packet);
            Log.LogInfo("Sending ready status to peer");
        }
    }


    public string GetStatus()
    {
        StringBuilder status = new StringBuilder();
        status.AppendLine($"Mystia ID: {PlayerId}");
        status.AppendLine($"Local Port: {TCP_PORT}");
        status.AppendLine($"Running: {(IsRunning ? "Yes" : "No")}");
        status.AppendLine($"Connected: {(IsConnected ? "Yes" : "No")}");
        if (IsConnected)
        {
            status.AppendLine($"Kyouko ID: {PeerId}");
        }
        
        if (IsConnected)
        {
            status.AppendLine($"Kyouko Address: {PeerAddress ?? "<Unknown>"}");
        }

        return status.ToString();
    }

    public string GetBriefStatus()
    {
        if (!IsRunning)
        {
            return "Multiplayer: Off";
        }
        if (IsConnected)
        {
            return $"Multiplayer: Connected to {PeerId} ({PeerAddress}), ping: {Latency} ms";
        }
        else
        {
            return "Multiplayer: On (Not connected)";
        }
    }
}

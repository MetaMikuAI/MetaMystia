using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using BepInEx.Logging;
using UnityEngine;

namespace MetaMystia;

public class MultiplayerManager
{
    private static MultiplayerManager _instance;
    private static readonly object _lock = new object();
    private static ManualLogSource Log => Plugin.Instance.Log;

    private const int TCP_PORT = 40815;

    private string playerId = System.Environment.MachineName;
    private string peerId = "<Unknown>";

    private TcpListener _tcpListener;
    private Thread _tcpListenerThread;
    private bool _isRunning = false;
    private bool _isConnected = false;
    private TcpClient _peerConnection;
    private Thread _peerHandlerThread;
    private string _peerAddress;

    public static MultiplayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MultiplayerManager();
                    }
                }
            }
            return _instance;
        }
    }

    private MultiplayerManager()
    {
    }

    public bool IsRunning()
    {
        return _isRunning;
    }

    public bool IsConnected()
    {
        return _isConnected;
    }

    public string GetPeerAddress()
    {
        return _peerAddress;
    }

    public void Start()
    {
        if (_isRunning)
        {
            Log.LogWarning("MultiplayerManager is already running");
            return;
        }

        _isRunning = true;
        Log.LogInfo("Starting MultiplayerManager");
        peerId = "<Unknown>";

        StartTcpListener();
    }

    public void Stop()
    {
        if (!_isRunning)
            return;

        Log.LogInfo("Stopping MultiplayerManager");
        _isRunning = false;

        DisconnectPeer();

        try
        {
            _tcpListener?.Stop();
        }
        catch (Exception e)
        {
            Log.LogError($"Error stopping TCP listener: {e.Message}");
        }

        peerId = "<Unknown>";
        Log.LogInfo("MultiplayerManager has stopped");
    }

    public void Restart()
    {
        Stop();
        Start();
    }

    public string GetPlayerId()
    {
        return playerId;
    }

    public void SetPlayerId(string newId)
    {
        playerId = newId;
        Log.LogInfo($"Player ID set to: {playerId}");
    }

    private void StartTcpListener()
    {
        try
        {
            _tcpListener = new TcpListener(IPAddress.Any, TCP_PORT);
            _tcpListener.Start();
            Log.LogInfo($"TCP listener started on port {TCP_PORT}");

            _tcpListenerThread = new Thread(TcpListenerLoop);
            _tcpListenerThread.IsBackground = true;
            _tcpListenerThread.Start();
        }
        catch (Exception e)
        {
            Log.LogError($"Error starting TCP listener: {e.Message}");
        }
    }

    private void TcpListenerLoop()
    {
        while (_isRunning)
        {
            try
            {
                if (_tcpListener.Pending())
                {
                    if (_isConnected)
                    {
                        TcpClient rejectedClient = _tcpListener.AcceptTcpClient();
                        Log.LogInfo($"Connection from {rejectedClient.Client.RemoteEndPoint} rejected (already connected)");
                        rejectedClient.Close();
                    }
                    else
                    {
                        TcpClient client = _tcpListener.AcceptTcpClient();
                        Log.LogInfo($"Connection from {client.Client.RemoteEndPoint} accepted");
                        AcceptPeerConnection(client);
                        SendHello();
                    }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                if (_isRunning)
                {
                    Log.LogError($"Error in TCP listener loop: {e.Message}");
                }
            }
        }
    }

    public bool ConnectToPeer(string peerIp)
    {
        if (_isConnected)
        {
            Log.LogWarning("Already connected to a peer. Please disconnect first.");
            return false;
        }

        try
        {
            Log.LogInfo($"Connecting to {peerIp}:{TCP_PORT}...");
            TcpClient client = new TcpClient();
            client.Connect(peerIp, TCP_PORT);
            Log.LogInfo($"Successfully connected to peer {peerIp}:{TCP_PORT}");

            _peerAddress = peerIp;
            _isConnected = true;
            _peerConnection = client;

            _peerHandlerThread = new Thread(() => HandlePeerConnection(client));
            _peerHandlerThread.IsBackground = true;
            _peerHandlerThread.Start();

            return true;
        }
        catch (Exception e)
        {
            Log.LogError($"Error connecting to peer: {e.Message}");
            return false;
        }
    }

    private void AcceptPeerConnection(TcpClient client)
    {
        if (_isConnected)
        {
            Log.LogWarning("Already connected to a peer. Please disconnect first.");
            client.Close();
            return;
        }

        _isConnected = true;
        _peerConnection = client;
        _peerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

        Log.LogInfo($"Connection from {_peerAddress} accepted");

        _peerHandlerThread = new Thread(() => HandlePeerConnection(client));
        _peerHandlerThread.IsBackground = true;
        _peerHandlerThread.Start();
    }

    private void HandlePeerConnection(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        StringBuilder messageBuilder = new StringBuilder();

        try
        {
            while (_isRunning && _isConnected && client.Connected)
            {
                if (stream.DataAvailable)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        messageBuilder.Append(data);

                        string accumulated = messageBuilder.ToString();
                        int newlineIndex;
                        while ((newlineIndex = accumulated.IndexOf('\n')) >= 0)
                        {
                            string line = accumulated.Substring(0, newlineIndex).Trim('\r', '\n');
                            accumulated = accumulated.Substring(newlineIndex + 1);

                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                ProcessPeerMessage(line, client);
                            }
                        }
                        messageBuilder.Clear();
                        messageBuilder.Append(accumulated);
                    }
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }
        catch (Exception e)
        {
            Log.LogError($"Error handling peer connection: {e.Message}");
        }
        finally
        {
            Log.LogInfo("Peer connection disconnected");
            DisconnectPeer();
        }
    }

    private void ProcessPeerMessage(string message, TcpClient client)
    {
        Log.LogInfo($"Received peer message: {message}");

        string[] parts = message.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0)
            return;

        string command = parts[0].ToLower();

        switch (command)
        {
            case "ping":
                SendToPeer("pong\n");
                Log.LogInfo("Responding to ping with pong");
                break;

            case "pong":
                Log.LogInfo("Received pong response from peer");
                break;

            case "hello":
                if (parts.Length >= 2)
                {
                    string peerId = parts[1];
                    HandleHello(peerId);
                }
                break;

            case "move":
                // format: move <vx> <vy> <px> <py>
                if (parts.Length >= 5)
                {
                    if (float.TryParse(parts[1], out float vx) && float.TryParse(parts[2], out float vy) &&
                        float.TryParse(parts[3], out float px) && float.TryParse(parts[4], out float py))
                    {
                        KyoukoManager.Instance.UpdateInputDirection(new UnityEngine.Vector2(vx, vy), new UnityEngine.Vector2(px, py)); // todo: change to MystiaManager 
                    }
                }
                break;

            default:
                Log.LogWarning($"Unknown peer command: {command}");
                break;
        }
    }

    private void SendToPeer(string message)
    {
        if (!_isConnected || _peerConnection == null)
        {
            Log.LogWarning("Cannot send message: not connected to a peer");
            return;
        }

        try
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = _peerConnection.GetStream();
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        catch (Exception e)
        {
            Log.LogError($"Error sending to peer: {e.Message}");
            DisconnectPeer();
        }
    }

    public void SendPing()
    {
        if (_isConnected)
        {
            Log.LogInfo("Sending ping to peer");
            SendToPeer("ping\n");
        }
        else
        {
            Log.LogWarning("Cannot send ping: not connected");
        }
    }

    public void SendHello()
    {
        if (_isConnected)
        {
            Log.LogInfo("Sending hello to peer");
            SendToPeer($"hello {GetPlayerId()}\n");
        }
        else
        {
            Log.LogWarning("Cannot send hello: not connected");
        }
    }

    public void HandleHello(string peerId)
    {
        this.peerId = peerId;
        Log.LogInfo($"Received hello from peer: {peerId}");
    }

    public void SendMoveData(UnityEngine.Vector2 inputDirection)
    {
        if (_isConnected)
        {
            // format: move <vx> <vy> <px> <py>
            var position = MystiaManager.Instance.GetPosition();
            if (position.HasValue)
            {
                string message = $"move {inputDirection.x} {inputDirection.y} {position.Value.x} {position.Value.y}\n";
                SendToPeer(message);
            }
        }
    }

    public void DisconnectPeer()
    {
        if (_peerConnection != null)
        {
            try
            {
                _peerConnection.Close();
            }
            catch { }
            _peerConnection = null;
        }

        _isConnected = false;
        _peerAddress = null;

        Log.LogInfo("Peer connection disconnected");
    }

    public string GetStatus()
    {
        StringBuilder status = new StringBuilder();
        status.AppendLine($"Player ID: {GetPlayerId()}");
        status.AppendLine($"Local Port: {TCP_PORT}");
        status.AppendLine($"Running: {(_isRunning ? "Yes" : "No")}");
        status.AppendLine($"Connected: {(_isConnected ? "Yes" : "No")}");
        
        if (_isConnected)
        {
            status.AppendLine($"Peer Address: {_peerAddress ?? "Unknown"}");
        }

        return status.ToString();
    }
}

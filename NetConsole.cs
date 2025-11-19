using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using BepInEx.Logging;
using UnityEngine;

namespace MetaMystia;

public class NetConsole
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private TcpListener listener;
    private Thread listenerThread;
    private bool isRunning = false;
    private List<TcpClient> clients = new List<TcpClient>();
    private Dictionary<string, Action<string[], TcpClient>> commands;

    public NetConsole()
    {
        InitializeCommands();
    }

    private void InitializeCommands()
    {
        commands = new Dictionary<string, Action<string[], TcpClient>>
        {
            { "help", HelpCommand },
            { "echo", EchoCommand },
            { "log", LogCommand },
            { "get", GetCommand },
            { "set", SetCommand },
            { "mp", MultiplayerCommand }
        };
    }

    public void Start()
    {
        if (isRunning)
        {
            Log.LogWarning("NetConsole is already running!");
            return;
        }

        try
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 40814);
            listener.Start();
            isRunning = true;

            listenerThread = new Thread(ListenForConnections);
            listenerThread.IsBackground = true;
            listenerThread.Start();

            Log.LogInfo("NetConsole started on 127.0.0.1:40815");
        }
        catch (Exception e)
        {
            Log.LogError($"Failed to start NetConsole: {e.Message}");
        }
    }

    public void Stop()
    {
        if (!isRunning)
            return;

        isRunning = false;

        foreach (var client in clients)
        {
            try
            {
                client?.Close();
            }
            catch { }
        }
        clients.Clear();

        try
        {
            listener?.Stop();
        }
        catch { }

        Log.LogInfo("NetConsole stopped");
    }

    private void ListenForConnections()
    {
        while (isRunning)
        {
            try
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                    Log.LogInfo($"Client connected from {client.Client.RemoteEndPoint}");

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();

                    SendToClient(client, "MetaMystia NetConsole\n");
                    SendToClient(client, "Enter `help` for a list of commands\n");
                    SendToClient(client, "> ");
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                if (isRunning)
                {
                    Log.LogError($"Error accepting client: {e.Message}");
                }
            }
        }
    }

    private void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        StringBuilder messageBuilder = new StringBuilder();

        try
        {
            while (isRunning && client.Connected)
            {
                if (stream.DataAvailable)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        messageBuilder.Append(data);

                        // Process complete lines
                        string accumulated = messageBuilder.ToString();
                        int newlineIndex;
                        while ((newlineIndex = accumulated.IndexOf('\n')) >= 0)
                        {
                            string line = accumulated.Substring(0, newlineIndex).Trim('\r', '\n');
                            accumulated = accumulated.Substring(newlineIndex + 1);

                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                ProcessCommand(line, client);
                            }

                            SendToClient(client, "> ");
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
            Log.LogError($"Error handling client: {e.Message}");
        }
        finally
        {
            clients.Remove(client);
            client.Close();
            Log.LogInfo("Client disconnected");
        }
    }

    private void ProcessCommand(string input, TcpClient client)
    {
        string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0)
            return;

        string command = parts[0].ToLower();
        string[] args = new string[parts.Length - 1];
        Array.Copy(parts, 1, args, 0, args.Length);

        if (commands.ContainsKey(command))
        {
            try
            {
                commands[command](args, client);
            }
            catch (Exception e)
            {
                SendToClient(client, $"Error executing command: {e.Message}\n");
                Log.LogError($"Error executing command '{command}': {e.Message}");
            }
        }
        else
        {
            SendToClient(client, $"Unknown command: {command}\n");
        }
    }

    private void SendToClient(TcpClient client, string message)
    {
        try
        {
            if (client.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                stream.Flush();
            }
        }
        catch (Exception e)
        {
            Log.LogError($"Error sending to client: {e.Message}");
        }
    }

    // Command: help - List available commands
    private void HelpCommand(string[] args, TcpClient client)
    {
        StringBuilder helpMessage = new StringBuilder("Available commands:\n");
        foreach (var cmd in commands.Keys)
        {
            helpMessage.AppendLine($"- {cmd}");
        }
        SendToClient(client, helpMessage.ToString());
    }
    
    // Command: echo - Echo back the arguments
    private void EchoCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: echo <message>\n");
            return;
        }

        string message = string.Join(" ", args);
        SendToClient(client, message + "\n");
    }

    // Command: log - Log a message to the BepInEx log
    private void LogCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: log <message>\n");
            return;
        }

        string message = string.Join(" ", args);
        Log.LogMessage($"[NetConsole] {message}");
        SendToClient(client, $"Logged: {message}\n");
    }

    // Command: get - Get a field value
    private void GetCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: get <field>\n");
            SendToClient(client, "Available fields: mystia position, mystia moving, mystia inputdirection, kyouko position, kyouko moving, kyouko inputdirection, currentactivemaplabel\n");
            return;
        }

        string field = string.Join(" ", args).ToLower();

        switch (field)
        {
            case "mystia position":
                var mystiaPos = MystiaManager.Instance.GetPosition();
                SendToClient(client, $"Mystia Position: ({mystiaPos.x}, {mystiaPos.y})\n");
                break;

            case "mystia moving":
                var mystiaMoving = MystiaManager.Instance.GetMoving();
                SendToClient(client, $"Mystia Moving: {mystiaMoving}\n");
                break;

            case "mystia inputdirection":
                var mystiaInputDir = MystiaManager.Instance.GetInputDirection();
                SendToClient(client, $"Mystia Input Direction: ({mystiaInputDir.x}, {mystiaInputDir.y}, {mystiaInputDir.z})\n");
                break;

            case "kyouko position":
                var kyoukoPos = KyoukoManager.Instance.GetPosition();
                SendToClient(client, $"Kyouko Position: ({kyoukoPos.x}, {kyoukoPos.y})\n");
                break;

            case "kyouko moving":
                var kyoukoMoving = KyoukoManager.Instance.GetMoving();
                SendToClient(client, $"Kyouko Moving: {kyoukoMoving}\n");
                break;

            case "kyouko movespeed":
                var kyoukoMoveSpeed = KyoukoManager.Instance.GetMoveSpeed();
                SendToClient(client, $"Kyouko Move Speed: {kyoukoMoveSpeed}\n");
                break;

            case "kyouko inputdirection":
                var kyoukoInputDir = KyoukoManager.Instance.GetInputDirection();
                SendToClient(client, $"Kyouko Input Direction: ({kyoukoInputDir.x}, {kyoukoInputDir.y}, {kyoukoInputDir.z})\n");
                break;

            case "currentactivemaplabel":
                var mapLabel = Utils.GetCurrentActiveMapLabel();
                SendToClient(client, $"Current Active Map Label: {mapLabel}\n");
                break;

            default:
                SendToClient(client, $"Unknown field: {field}\n");
                SendToClient(client, "Available fields: mystia position, mystia moving, mystia movespeed, mystia inputdirection, kyouko position, kyouko moving, kyouko movespeed, kyouko inputdirection, currentactivemaplabel\n");
                break;
        }
    }

    // Command: set - Set a field value
    private void SetCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: set <field> <value...>\n");
            SendToClient(client, "Available fields: mystia position <x> <y>, mystia moving <true|false>, mystia movespeed <float>, mystia inputdirection <x> <y> [z], kyouko position <x> <y>, kyouko moving <true|false>, kyouko movespeed <float>, kyouko inputdirection <x> <y> [z]\n");
            return;
        }

        // Parse field name (may be multiple words like "mystia position")
        string firstWord = args[0].ToLower();
        string secondWord = args.Length > 1 ? args[1].ToLower() : "";
        string field = "";
        int valueStartIndex = 0;

        if ((firstWord == "mystia" || firstWord == "kyouko") && (secondWord == "position" || secondWord == "moving" || secondWord == "movespeed" || secondWord == "inputdirection"))
        {
            field = $"{firstWord} {secondWord}";
            valueStartIndex = 2;
        }
        else
        {
            SendToClient(client, "Invalid field name\n");
            SendToClient(client, "Available fields: mystia position <x> <y>, mystia moving <true|false>, mystia movespeed <float>, mystia inputdirection <x> <y> [z], kyouko position <x> <y>, kyouko moving <true|false>, kyouko movespeed <float>, kyouko inputdirection <x> <y> [z]\n");
            return;
        }

        switch (field)
        {
            case "mystia position":
                if (args.Length < valueStartIndex + 2)
                {
                    SendToClient(client, "Usage: set mystia position <x> <y>\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float mystiaX) || !float.TryParse(args[valueStartIndex + 1], out float mystiaY))
                {
                    SendToClient(client, "Invalid coordinates. Usage: set mystia position <x> <y>\n");
                    break;
                }

                var mystiaPosSuccess = MystiaManager.Instance.SetPosition(mystiaX, mystiaY);
                if (mystiaPosSuccess)
                {
                    SendToClient(client, $"Mystia Position set to ({mystiaX}, {mystiaY})\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Mystia position\n");
                }
                break;

            case "mystia moving":
                if (args.Length < valueStartIndex + 1)
                {
                    SendToClient(client, "Usage: set mystia moving <true|false>\n");
                    break;
                }

                if (!bool.TryParse(args[valueStartIndex], out bool mystiaMoving))
                {
                    SendToClient(client, "Invalid value. Usage: set mystia moving <true|false>\n");
                    break;
                }

                var mystiaMovingSuccess = MystiaManager.Instance.SetMoving(mystiaMoving);
                if (mystiaMovingSuccess)
                {
                    SendToClient(client, $"Mystia Moving set to {mystiaMoving}\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Mystia moving status\n");
                }
                break;

            case "mystia movespeed":
                if (args.Length < valueStartIndex + 1)
                {
                    SendToClient(client, "Usage: set mystia movespeed <float>\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float mystiaMoveSpeed))
                {
                    SendToClient(client, "Invalid value. Usage: set mystia movespeed <float>\n");
                    break;
                }

                var mystiaMoveSpeedSuccess = MystiaManager.Instance.SetMoveSpeed(mystiaMoveSpeed);
                if (mystiaMoveSpeedSuccess)
                {
                    SendToClient(client, $"Mystia Move Speed set to {mystiaMoveSpeed}\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Mystia move speed\n");
                }
                break;

            case "mystia inputdirection":
                if (args.Length < valueStartIndex + 2)
                {
                    SendToClient(client, "Usage: set mystia inputdirection <x> <y> [z]\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float mystiaInputX) || !float.TryParse(args[valueStartIndex + 1], out float mystiaInputY))
                {
                    SendToClient(client, "Invalid coordinates. Usage: set mystia inputdirection <x> <y> [z]\n");
                    break;
                }

                float mystiaInputZ = 0;
                if (args.Length >= valueStartIndex + 3)
                {
                    if (!float.TryParse(args[valueStartIndex + 2], out mystiaInputZ))
                    {
                        SendToClient(client, "Invalid z coordinate. Usage: set mystia inputdirection <x> <y> [z]\n");
                        break;
                    }
                }

                var mystiaInputDirSuccess = MystiaManager.Instance.SetInputDirection(mystiaInputX, mystiaInputY, mystiaInputZ);
                if (mystiaInputDirSuccess)
                {
                    SendToClient(client, $"Mystia Input Direction set to ({mystiaInputX}, {mystiaInputY}, {mystiaInputZ})\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Mystia input direction\n");
                }
                break;

            case "kyouko position":
                if (args.Length < valueStartIndex + 2)
                {
                    SendToClient(client, "Usage: set kyouko position <x> <y>\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float kyoukoX) || !float.TryParse(args[valueStartIndex + 1], out float kyoukoY))
                {
                    SendToClient(client, "Invalid coordinates. Usage: set kyouko position <x> <y>\n");
                    break;
                }

                var kyoukoPosSuccess = KyoukoManager.Instance.SetPosition(kyoukoX, kyoukoY);
                if (kyoukoPosSuccess)
                {
                    SendToClient(client, $"Kyouko Position set to ({kyoukoX}, {kyoukoY})\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Kyouko position\n");
                }
                break;

            case "kyouko moving":
                if (args.Length < valueStartIndex + 1)
                {
                    SendToClient(client, "Usage: set kyouko moving <true|false>\n");
                    break;
                }

                if (!bool.TryParse(args[valueStartIndex], out bool kyoukoMoving))
                {
                    SendToClient(client, "Invalid value. Usage: set kyouko moving <true|false>\n");
                    break;
                }

                var kyoukoMovingSuccess = KyoukoManager.Instance.SetMoving(kyoukoMoving);
                if (kyoukoMovingSuccess)
                {
                    SendToClient(client, $"Kyouko Moving set to {kyoukoMoving}\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Kyouko moving status\n");
                }
                break;

            case "kyouko movespeed":
                if (args.Length < valueStartIndex + 1)
                {
                    SendToClient(client, "Usage: set kyouko movespeed <float>\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float kyoukoMoveSpeed))
                {
                    SendToClient(client, "Invalid value. Usage: set kyouko movespeed <float>\n");
                    break;
                }

                var kyoukoMoveSpeedSuccess = KyoukoManager.Instance.SetMoveSpeed(kyoukoMoveSpeed);
                if (kyoukoMoveSpeedSuccess)
                {
                    SendToClient(client, $"Kyouko Move Speed set to {kyoukoMoveSpeed}\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Kyouko move speed\n");
                }
                break;

            case "kyouko inputdirection":
                if (args.Length < valueStartIndex + 2)
                {
                    SendToClient(client, "Usage: set kyouko inputdirection <x> <y> [z]\n");
                    break;
                }

                if (!float.TryParse(args[valueStartIndex], out float kyoukoInputX) || !float.TryParse(args[valueStartIndex + 1], out float kyoukoInputY))
                {
                    SendToClient(client, "Invalid coordinates. Usage: set kyouko inputdirection <x> <y> [z]\n");
                    break;
                }

                float kyoukoInputZ = 0;
                if (args.Length >= valueStartIndex + 3)
                {
                    if (!float.TryParse(args[valueStartIndex + 2], out kyoukoInputZ))
                    {
                        SendToClient(client, "Invalid z coordinate. Usage: set kyouko inputdirection <x> <y> [z]\n");
                        break;
                    }
                }

                var kyoukoInputDirSuccess = KyoukoManager.Instance.SetInputDirection(kyoukoInputX, kyoukoInputY, kyoukoInputZ);
                if (kyoukoInputDirSuccess)
                {
                    SendToClient(client, $"Kyouko Input Direction set to ({kyoukoInputX}, {kyoukoInputY}, {kyoukoInputZ})\n");
                }
                else
                {
                    SendToClient(client, "Failed to set Kyouko input direction\n");
                }
                break;
        }
    }

    // Command: mp - Multiplayer commands
    private void MultiplayerCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: mp <subcommand> [args]\n");
            SendToClient(client, "Subcommands:\n");
            SendToClient(client, "  start            - Start multiplayer\n");
            SendToClient(client, "  stop             - Stop multiplayer\n");
            SendToClient(client, "  restart          - Restart multiplayer\n");
            SendToClient(client, "  status           - Show connection status\n");
            SendToClient(client, "  ping             - Send ping to peer\n");
            SendToClient(client, "  id               - Show local ID\n");
            SendToClient(client, "  connect <ip>     - Connect to peer IP\n");
            SendToClient(client, "  disconnect       - Disconnect from peer\n");
            SendToClient(client, "  debug            - Show debug information\n");
            return;
        }

        string subcommand = args[0].ToLower();

        switch (subcommand)
        {
            case "start":
                MultiplayerManager.Instance.Start();
                SendToClient(client, "Multiplayer started\n");
                break;

            case "stop":
                MultiplayerManager.Instance.Stop();
                SendToClient(client, "Multiplayer stopped\n");
                break;

            case "restart":
                MultiplayerManager.Instance.Restart();
                SendToClient(client, "Multiplayer restarted\n");
                break;

            case "status":
                string status = MultiplayerManager.Instance.GetStatus();
                SendToClient(client, status);
                break;

            case "ping":
                if (!MultiplayerManager.Instance.IsConnected())
                {
                    SendToClient(client, "Error: Not connected to peer\n");
                }
                else
                {
                    MultiplayerManager.Instance.SendPing();
                    SendToClient(client, "Ping sent\n");
                }
                break;

            case "id":
                if (args.Length < 2)
                {
                    SendToClient(client, "Usage: mp id <new_id>\n");
                    break;
                }
                MultiplayerManager.Instance.SetPlayerId(args[1]);
                break;

            case "connect":
                if (args.Length < 2)
                {
                    SendToClient(client, "Usage: mp connect <ip>\n");
                    break;
                }

                string targetIp = args[1];
                if (MultiplayerManager.Instance.ConnectToPeer(targetIp))
                {
                    SendToClient(client, $"Connected to {targetIp}\n");
                }
                else
                {
                    SendToClient(client, $"Failed to connect to {targetIp}\n");
                }
                break;

            case "disconnect":
                if (!MultiplayerManager.Instance.IsConnected())
                {
                    SendToClient(client, "No active connection\n");
                }
                else
                {
                    MultiplayerManager.Instance.DisconnectPeer();
                    SendToClient(client, "Disconnected\n");
                }
                break;

            default:
                SendToClient(client, $"Unknown subcommand: {subcommand}\n");
                SendToClient(client, "Available subcommands: start, stop, restart, status, ping, id, connect, disconnect\n");
                break;
        }
    }

}

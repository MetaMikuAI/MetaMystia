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
            { "set", SetCommand }
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
            SendToClient(client, "Available fields: playerposition, currentactivemaplabel\n");
            return;
        }

        string field = args[0].ToLower();

        switch (field)
        {
            case "playerposition":
                var position = Utils.GetPlayerPosition();
                if (position.HasValue)
                {
                    SendToClient(client, $"PlayerPosition: ({position.Value.x}, {position.Value.y})\n");
                }
                else
                {
                    SendToClient(client, "Failed to get player position\n");
                }
                break;

            case "currentactivemaplabel":
                var mapLabel = Utils.GetCurrentActiveMapLabel();
                if (mapLabel != null)
                {
                    SendToClient(client, $"CurrentActiveMapLabel: {mapLabel}\n");
                }
                else
                {
                    SendToClient(client, "Failed to get current active map label\n");
                }
                break;

            default:
                SendToClient(client, $"Unknown field: {field}\n");
                SendToClient(client, "Available fields: PlayerPosition, CurrentActiveMapLabel\n");
                break;
        }
    }

    // Command: set - Set a field value
    private void SetCommand(string[] args, TcpClient client)
    {
        if (args.Length == 0)
        {
            SendToClient(client, "Usage: set <field> <value...>\n");
            SendToClient(client, "Available fields: PlayerPosition <x> <y>\n");
            return;
        }

        string field = args[0].ToLower();

        switch (field)
        {
            case "playerposition":
                if (args.Length < 3)
                {
                    SendToClient(client, "Usage: set PlayerPosition <x> <y>\n");
                    break;
                }

                if (!float.TryParse(args[1], out float x) || !float.TryParse(args[2], out float y))
                {
                    SendToClient(client, "Invalid coordinates. Usage: set PlayerPosition <x> <y>\n");
                    break;
                }

                var success = Utils.SetPlayerPosition(x, y);
                if (success)
                {
                    SendToClient(client, $"PlayerPosition set to ({x}, {y})\n");
                    break;
                }
                else 
                {
                    SendToClient(client, "Failed to set player position\n");
                    break;
                }

            default:
                SendToClient(client, $"Unknown field: {field}\n");
                SendToClient(client, "Available fields: playerposition <x> <y>\n");
                break;
        }
    }
}

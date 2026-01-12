using System.Collections.Generic;
using System.Threading.Tasks;
using Common.UI;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MetaMystia;

[AutoLog]
public partial class InGameConsole
{
    private bool _isOpen = false;
    public bool IsOpen
    {
        get { return _isOpen; }
        set
        {
            if (_isOpen != value)
            {
                _isOpen = value;
                UpdateGameInputState();
            }
        }
    }

    private string input = "";
    private Vector2 scrollPosition;
    private List<string> logs = [];
    private List<string> inputs = [];
    private int inputsCursor = 0;
    private const int MaxLogs = 1024;
    private bool focusTextField = true;
    private bool moveCursor = false;
    private const string TextFieldControlName = "ConsoleInput";
    private bool justOpened = false;

    public void AddPeerMessage(string message)
    {
        LogToConsole($"[Peer] {message}");
    }

    private void UpdateGameInputState()
    {
        try
        {
            // PluginLog.LogInfo($"Console: UniversalGameManager input availability before set {UniversalGameManager.IsInputEnabled}");
            // UniversalGameManager.UpdatePlayerInputAvailability();
            // UniversalGameManager.IsInputEnabled = !IsOpen;
            UniversalGameManager.UpdatePlayerInputAvailability(!IsOpen);
            // DEYU.AdpUISystem.Managers.AdpUIPanelManager.PlayerInput.m_InputActive = !IsOpen;

            // PluginLog.LogInfo($"Console: UniversalGameManager input availability set to {UniversalGameManager.IsInputEnabled}");

        }
        catch (System.Exception e)
        {
            Log.LogWarning($"Console: Failed to update UniversalGameManager input: {e.Message}");
        }

        // 3. Toggle EventSystem to block UI navigation (Main Menu AD/JK)
        // We use sendNavigationEvents instead of enabled, because disabling the component
        // makes EventSystem.current return null, preventing us from re-enabling it later.
        var eventSystem = EventSystem.current;
        if (eventSystem != null)
        {
            eventSystem.sendNavigationEvents = !IsOpen;
            Log.LogDebug($"Console: EventSystem sendNavigationEvents = {eventSystem.sendNavigationEvents}");
        }
    }

    public void Update()
    {
        // Enforce EventSystem navigation disabled while console is open (handles scene changes)
        if (IsOpen)
        {
            var es = EventSystem.current;
            if (es != null && es.sendNavigationEvents)
            {
                es.sendNavigationEvents = false;
            }
        }

        if (justOpened) justOpened = false;

        if (Input.GetKeyDown(KeyCode.Slash) || Input.GetKeyDown(KeyCode.T))
        {
            if (!IsOpen)
            {
                IsOpen = true;
                input = Input.GetKeyDown(KeyCode.Slash) ? "/" : "";
                focusTextField = true;
                moveCursor = true;
                justOpened = true;
            }
        }

        // ESC handling is done in OnGUI to ensure event consumption
    }

    public void OnGUI()
    {
        if (!IsOpen) return;

        Event e = Event.current;

        // Handle Escape to close
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.Escape)
        {
            IsOpen = false;
            e.Use();
            return;
        }

        // Handle Enter key
        bool submit = false;
        if (e.type == EventType.KeyDown && (e.keyCode == KeyCode.Return || e.keyCode == KeyCode.KeypadEnter))
        {
            submit = true;
            e.Use();
        }

        // Handle UpArrow key
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.UpArrow)
        {
            if (inputsCursor < inputs.Count)
            {
                inputsCursor++;
            }
            if (inputs.Count > 0)
            {
                input = inputs[^inputsCursor];
                focusTextField = false;
                moveCursor = true;
            }
            e.Use();
        }

        // Handle DownArrow key
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.DownArrow)
        {
            if (inputsCursor > 1)
            {
                inputsCursor--;
                input = inputs[^inputsCursor];
            }
            else
            {
                input = "";
            }
            focusTextField = false;
            moveCursor = true;
            e.Use();
        }

        // Consume Slash key if just opened to prevent typing it in the field
        if (justOpened && e.type == EventType.KeyDown && e.character == '/')
        {
            e.Use();
        }

        // UI Layout & Styles
        float width = Screen.width * 0.8f;
        float height = Screen.height * 0.7f;
        float x = (Screen.width - width) / 2;
        float y = (Screen.height - height) / 2;
        float padding = 20f;
        float inputHeight = 40f;
        int fontSize = 24;

        GUIStyle labelStyle = new GUIStyle(GUI.skin.label) { fontSize = fontSize };
        GUIStyle inputStyle = new GUIStyle(GUI.skin.textField) { fontSize = fontSize };
        GUIStyle boxStyle = new GUIStyle(GUI.skin.box) { fontSize = fontSize };

        // Draw background
        GUI.Box(new Rect(x, y, width, height), "Console", boxStyle);

        // Draw logs
        GUILayout.BeginArea(new Rect(x + padding, y + 40, width - 2 * padding, height - 40 - inputHeight - padding));
        scrollPosition = GUILayout.BeginScrollView(scrollPosition);
        foreach (var log in logs)
        {
            GUILayout.Label(log, labelStyle);
        }
        GUILayout.EndScrollView();
        GUILayout.EndArea();

        // Draw input field
        GUI.SetNextControlName(TextFieldControlName);
        input = GUI.TextField(new Rect(x + padding, y + height - inputHeight - padding, width - 2 * padding, inputHeight), input, inputStyle);

        if (focusTextField)
        {
            GUI.FocusControl(TextFieldControlName);
            Log.LogInfo("forcing focus control");
            focusTextField = false;
        }

        // Move cursor to the last of input
        if (moveCursor && Event.current.type == EventType.Repaint)
        {
            int id = GUIUtility.keyboardControl;
            var obj = GUIUtility.GetStateObject(Il2CppType.Of<TextEditor>(), id);
            if (obj != null)
            {
                var editor = obj.Cast<TextEditor>();
                editor.cursorIndex = input.Length;
                editor.selectIndex = input.Length;
            }
            moveCursor = false;
        }


        // Execute command if Enter was pressed
        if (submit)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ExecuteCommand(input, out bool closeConsole);
                inputs.Add(input);
                inputsCursor = 0;
                input = "";
                if (closeConsole)
                {
                    IsOpen = false;
                    return;
                }
            }
            else
            {
                IsOpen = false;
                return;
            }
        }

        // Consume all other KeyDown events to prevent game from receiving them via IMGUI
        if (e.type == EventType.KeyDown && e.keyCode != KeyCode.None)
        {
            e.Use();
        }
    }

    public void LogToConsole(string message)
    {
        logs.Add(message);
        if (logs.Count > MaxLogs) logs.RemoveAt(0);
        scrollPosition.y = float.MaxValue;
    }

    private void ExecuteCommand(string cmd, out bool closeConsole)
    {
        closeConsole = false;
        Log.LogMessage($"Console Command: {cmd}");
        LogToConsole("> " + cmd);

        string[] parts = cmd.Split([' '], System.StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return;

        string command = parts[0].ToLower();
        string[] args = new string[parts.Length - 1];
        System.Array.Copy(parts, 1, args, 0, args.Length);

        bool isMessage = command[0] != '/';
        if (isMessage)
        {
            MessageCommand(cmd);
            closeConsole = true;
        }
        else
        {
            command = command[1..];
            switch (command)
            {
                case "help":
                    HelpCommand();
                    break;
                case "clear":
                    logs.Clear();
                    inputs.Clear();
                    break;
                case "get":
                    GetCommand(args);
                    break;
                case "mp":
                    _ = MultiplayerCommand(args);
                    break;
                case "call":
                    CallCommand(args);
                    break;
                case "debug":
                    LogToConsole(MpManager.DumpDebugText());
                    Log.Message(MpManager.DumpDebugText());
                    break;
                default:
                    LogToConsole("Unknown command: " + command);
                    HelpCommand();
                    break;
            }

        }

    }

    private void HelpCommand()
    {
        LogToConsole("Available commands: /help, /clear, /get, /mp, /call, /debug");
    }

    private void GetCommand(string[] args)
    {
        var availableFields = "currentactivemaplabel, pos";
        if (args.Length == 0)
        {
            LogToConsole("Usage: get <field>");
            LogToConsole($"Available fields: {availableFields}");
            return;
        }

        string field = string.Join(" ", args).ToLower();

        switch (field)
        {
            case "currentactivemaplabel":
                LogToConsole($"Current Active Map Label: {MystiaManager.MapLabel}");
                break;
            case "pos":
                LogToConsole($"Mystia position: {MystiaManager.Instance.GetPosition()}");
                break;
            default:
                LogToConsole($"Unknown field: {field}");
                LogToConsole($"Available fields: {availableFields}");
                break;
        }
    }

    private async Task MultiplayerCommand(string[] args)
    {
        const string subcommandHelp = "Subcommands: start, stop, restart, status, id, connect, disconnect";
        if (args.Length == 0)
        {
            LogToConsole("Usage: /mp <subcommand> [args]");
            LogToConsole(subcommandHelp);
            return;
        }

        string subcommand = args[0].ToLower();

        switch (subcommand)
        {
            case "start":
                if (args.Length < 2)
                {
                    LogToConsole("Usage: /mp start server or /mp start client");
                    break;
                }
                bool start_server = args[1].Equals("server");
                if (MpManager.Start(start_server ? MpManager.ROLE.Host : MpManager.ROLE.Client))
                {
                    LogToConsole("Multiplayer started");
                }
                break;
            case "stop":
                MpManager.Stop();
                LogToConsole("Multiplayer stopped");
                break;
            case "restart":
                if (MpManager.Restart())
                {
                    LogToConsole("Multiplayer restarted");
                }
                break;
            case "status":
                LogToConsole(MpManager.GetStatus());
                break;
            case "id":
                if (args.Length < 2)
                {
                    LogToConsole("Usage: /mp id <new_id>");
                    break;
                }
                MpManager.PlayerId = args[1];
                LogToConsole($"Player ID set to {args[1]}");
                break;
            case "connect":
                if (args.Length < 2)
                {
                    LogToConsole("Usage: /mp connect <ip> <port>(optional)");
                    break;
                }
                // args[0]: connect, args[1]: ip or ip:port, args[2]: port
                string address = args[1];

                string host;
                bool result;

                if (args.Length == 2)
                {
                    int idx = address.LastIndexOf(':');
                    if (idx > 0 && idx != address.Length - 1)
                    {
                        host = address[..idx];
                        string portStr = address[(idx + 1)..];

                        if (int.TryParse(portStr, out int port))
                            result = await MpManager.ConnectToPeerAsync(host, port);
                        else
                            result = await MpManager.ConnectToPeerAsync(address);
                    }
                    else
                    {
                        result = await MpManager.ConnectToPeerAsync(address);
                    }
                }
                else
                {
                    if (int.TryParse(args[2], out int port))
                        result = await MpManager.ConnectToPeerAsync(address, port);
                    else
                        result = await MpManager.ConnectToPeerAsync(address);
                }

                if (result)
                {
                    LogToConsole($"Connected to {address}");
                }
                else
                {
                    LogToConsole($"Failed to connect to {address}");
                }
                break;
            case "disconnect":
                if (!MpManager.IsConnected)
                {
                    LogToConsole("No active connection");
                }
                else
                {
                    MpManager.DisconnectPeer();
                    LogToConsole("Disconnected");
                }
                break;
            default:
                LogToConsole($"Unknown subcommand: {subcommand}");
                LogToConsole(subcommandHelp);
                break;
        }
    }

    private void MessageCommand(string msg)
    {
        if (!MpManager.IsConnected)
        {
            LogToConsole("No active connection");
        }
        else
        {
            MessageAction.Send(msg);
            LogToConsole($"Sent {msg}");
        }
    }

    private void CallCommand(string[] args)
    {
        var availableFields = "getmapsnpcs, movecharacter, try_close_izakaya";
        if (args.Length == 0)
        {
            LogToConsole("Usage: /call <method> [args]");
            LogToConsole($"Available methods: {availableFields}");
            return;
        }

        string method = args[0].ToLower();
        switch (method)
        {
            case "getmapsnpcs":
                try
                {

                    var mapLabel = args.Length >= 2 ? args[1] : MystiaManager.MapLabel;
                    var npcs = GameData.RunTime.DaySceneUtility.RunTimeDayScene.GetMapNPCs(mapLabel);
                    // public unsafe static Dictionary<string, TrackedNPC> GetMapNPCs(string mapLabel);
                    foreach (var npc in npcs)
                    {
                        LogToConsole($"- {npc.Key}"); // TrackedNPC 有 ToString 方法，不过没啥东西
                    }
                    LogToConsole($"Total NPCs found: {npcs.Count}");
                }
                catch (System.Exception e)
                {
                    LogToConsole($"Error calling getmapsnpcs: {e.Message}");
                }
                break;
            case "movecharacter":
                if (args.Length < 6)
                {
                    LogToConsole("Usage: call movecharacter <characterKey> <mapLabel> <x> <y> <rot>");
                    break;
                }
                try
                {
                    string characterKey = args[1];
                    string mapLabel = args[2];
                    float x = float.Parse(args[3]);
                    float y = float.Parse(args[4]);
                    int rot = int.Parse(args[5]);
                    GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter(characterKey, mapLabel, new Vector2(x, y), rot, out var oldNPCData);
                    LogToConsole($"Moved character '{characterKey}' to position ({x}, {y}) rotation {rot} on map '{mapLabel}'.");
                }
                catch (System.Exception e)
                {
                    LogToConsole($"Error calling movecharacter: {e.Message}");
                }
                break;
            case "scene_move":
                if (args.Length < 4)
                {
                    LogToConsole("Usage: call scene_move <characterKey> <x> <y>");
                    break;
                }
                try
                {
                    string characterKey = args[1];
                    float x = float.Parse(args[2]);
                    float y = float.Parse(args[3]);
                    var arr = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<Vector2>(1);
                    arr[0] = new Vector2(x, y);
                    Common.SceneDirector.Instance.MoveCharacter(characterKey, arr, 1.48f, new System.Action(() => { }));
                    LogToConsole($"Moved character '{characterKey}' to position ({x}, {y})'.");
                }
                catch (System.Exception e)
                {
                    LogToConsole($"Error calling scene_move: {e.Message}");
                }
                break;
            case "try_close_izakaya":
                if (MpManager.LocalScene != Scene.WorkScene)
                {
                    LogToConsole($"not in work scene, skip");
                }
                else
                {
                    NightGuestManager.CloseIzakayaIfPossible();
                    LogToConsole($"called try_close_izakaya");
                }
                break;
            default:
                LogToConsole($"Unknown method: {method}");
                LogToConsole($"Available methods: {availableFields}");
                break;
        }
    }
}


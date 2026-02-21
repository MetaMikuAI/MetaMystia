using System.Collections.Generic;
using System.Threading.Tasks;
using Common.UI;
using Il2CppInterop.Runtime;
using MetaMystia.Network;
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
                Log.Info($"console {(value ? "opened" : "closed")}");
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
        LogToConsole(TextId.PeerMessagePrefix.Get(message));
    }

    private void UpdateGameInputState()
    {
        try
        {
            UniversalGameManager.UpdatePlayerInputAvailability(!IsOpen);
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
        LogToConsole(TextId.CommandPrompt.Get(cmd));

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
                    LogToConsole(MpManager.DebugText);
                    Log.Message(MpManager.DebugText);
                    break;
                case "webdebug":
                    OpenWebDebugger(args);
                    break;
                case "enable_bepin_console":
                    BepInEx.ConsoleManager.CreateConsole();
                    LogToConsole(TextId.BepInExConsoleEnabled.Get());
                    System.Console.OutputEncoding = System.Text.Encoding.UTF8;
                    break;
                case "whereami":
                    if (MpManager.LocalScene != Common.UI.Scene.DayScene)
                    {
                        LogToConsole(TextId.NotInDayScene.Get());
                        break;
                    }
                    LogToConsole(TextId.MapInfoDisplay.Get(MystiaManager.MapLabel, MystiaManager.Position));
                    break;
                default:
                    LogToConsole(TextId.UnknownCommand.Get(command));
                    HelpCommand();
                    break;
            }

        }

    }

    private void HelpCommand()
    {
        LogToConsole(TextId.AvailableCommands.Get());
    }

    private void GetCommand(string[] args)
    {
        var availableFields = "currentactivemaplabel, pos";
        if (args.Length == 0)
        {
            LogToConsole(TextId.GetUsage.Get());
            LogToConsole(TextId.AvailableFields.Get(availableFields));
            return;
        }

        string field = string.Join(" ", args).ToLower();

        switch (field)
        {
            case "currentactivemaplabel":
                LogToConsole(TextId.CurrentMapLabel.Get(MystiaManager.MapLabel));
                break;
            case "pos":
                LogToConsole(TextId.MystiaPosition.Get(MystiaManager.Position));
                break;
            default:
                LogToConsole(TextId.UnknownField.Get(field));
                LogToConsole(TextId.AvailableFields.Get(availableFields));
                break;
        }
    }

    private async Task MultiplayerCommand(string[] args)
    {
        if (args.Length == 0)
        {
            LogToConsole(TextId.MpUsageRoot.Get());
            LogToConsole(TextId.MpSubcommandHelp.Get());
            return;
        }

        string subcommand = args[0].ToLower();

        switch (subcommand)
        {
            case "start":
                if (args.Length < 2)
                {
                    LogToConsole(TextId.MpUsageHelp.Get());
                    break;
                }
                if (MpManager.IsRunning)
                {
                    LogToConsole(TextId.MpAlreadyStarted.Get(MpManager.RoleName));
                    break;
                }
                if ("server".Equals(args[1].ToLower()))
                {
                    if (MpManager.Start(MpManager.ROLE.Host))
                    {
                        LogToConsole(TextId.MpStartedAsHost.Get());
                    }
                }
                else if ("client".Equals(args[1].ToLower()))
                {
                    if (MpManager.Start(MpManager.ROLE.Client))
                    {
                        LogToConsole(TextId.MpStartedAsClient.Get());
                    }
                }
                else
                {
                    LogToConsole(TextId.MpUsageHelp.Get());
                }
                break;
            case "stop":
                MpManager.Stop();
                LogToConsole(TextId.MpStopped.Get());
                break;

            case "restart":
                if (MpManager.Restart())
                {
                    LogToConsole(TextId.MpRestarted.Get());
                }
                break;
            case "status":
                LogToConsole(MpManager.GetStatus());
                LogToConsole(MpManager.DebugText);
                break;
            case "id":
                if (args.Length < 2)
                {
                    LogToConsole(TextId.MpUsageSetId.Get());
                    break;
                }
                MpManager.PlayerId = args[1];
                LogToConsole(TextId.MpPlayerIdSet.Get(args[1]));
                break;
            case "connect":
                if (args.Length < 2)
                {
                    LogToConsole(TextId.ConnectCommand.Get());
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
                    LogToConsole(TextId.ConnectCommandConnected.Get(address));
                }
                else
                {
                    LogToConsole(TextId.ConnectCommandFail.Get(address));
                }
                break;
            case "disconnect":
                if (!MpManager.IsConnected)
                {
                    LogToConsole(TextId.MpNoActiveConnection.Get());
                }
                else
                {
                    MpManager.DisconnectPeer();
                    LogToConsole(TextId.MpDisconnected.Get());
                }
                break;
            default:
                LogToConsole(TextId.MpUnknownSubcommand.Get(subcommand));
                LogToConsole(TextId.MpSubcommandHelp.Get());
                break;
        }
    }

    private void MessageCommand(string msg)
    {
        if (!MpManager.IsConnected)
        {
            LogToConsole(TextId.MpNoActiveConnection.Get());
        }
        else
        {
            MessageAction.Send(msg);
            LogToConsole(TextId.MessageSent.Get(msg));
        }
    }

    private void CallCommand(string[] args)
    {
        var availableFields = "getmapsnpcs, movecharacter, try_close_izakaya";
        if (args.Length == 0)
        {
            LogToConsole(TextId.CallUsage.Get());
            LogToConsole(TextId.AvailableMethods.Get(availableFields));
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
                        LogToConsole(TextId.NPCListItem.Get(npc.Key));
                    }
                    LogToConsole(TextId.TotalNPCsFound.Get(npcs.Count));
                }
                catch (System.Exception e)
                {
                    LogToConsole(TextId.ErrorGetMapsnpcs.Get(e.Message));
                }
                break;
            case "movecharacter":
                if (args.Length < 6)
                {
                    LogToConsole(TextId.MoveCharacterUsage.Get());
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
                    LogToConsole(TextId.CharacterMoved.Get(characterKey, x, y, rot, mapLabel));
                }
                catch (System.Exception e)
                {
                    LogToConsole(TextId.ErrorMovecharacter.Get(e.Message));
                }
                break;
            case "scene_move":
                if (args.Length < 4)
                {
                    LogToConsole(TextId.SceneMoveUsage.Get());
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
                    LogToConsole(TextId.CharacterMovedScene.Get(characterKey, x, y));
                }
                catch (System.Exception e)
                {
                    LogToConsole(TextId.ErrorSceneMove.Get(e.Message));
                }
                break;
            case "try_close_izakaya":
                if (MpManager.LocalScene != Scene.WorkScene)
                {
                    LogToConsole(TextId.NotInWorkScene.Get());
                }
                else
                {
                    WorkSceneManager.CloseIzakayaIfPossible();
                    LogToConsole(TextId.CalledTryCloseIzakaya.Get());
                }
                break;
            default:
                LogToConsole(TextId.UnknownMethod.Get(method));
                LogToConsole(TextId.AvailableMethods.Get(availableFields));
                break;
        }
    }

    private void OpenWebDebugger(string[] args)
    {
        if (args.Length < 2 || args[0].ToLower() != "start")
        {
            LogToConsole(TextId.WebDebuggerUsage.Get());
            return;
        }

        if (args[1] != "我已知晓风险并同意启动Web调试器")
        {
            LogToConsole(TextId.InvalidWebDebuggerKey.Get());
            return;
        }

        PluginManager.Debugger ??= new Debugger.WebDebugger();
        PluginManager.Debugger?.Start();
        LogToConsole(TextId.WebDebuggerStarted.Get());
    }
}


using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using Common.CharacterUtility;
using Common.UI;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace MetaMystia
{
    public class InGameConsole
    {
        private bool _isOpen = false;
        public bool IsOpen
        {
            get => _isOpen;
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
        private bool focusTextField = false;
        private const string TextFieldControlName = "ConsoleInput";
        private bool justOpened = false;

        private void UpdateGameInputState()
        {
            var inputGenerator = Object.FindObjectOfType<CharacterControllerInputGeneratorComponent>();
            if (inputGenerator != null)
            {
                inputGenerator.enabled = !IsOpen;
                PluginManager.Log.LogMessage($"Console: InputGenerator enabled = {inputGenerator.enabled}");
            }
            else
            {
                PluginManager.Log.LogWarning("Console: No CharacterControllerInputGeneratorComponent found.");
            }

            try
            {
                // UpdatePlayerInputAvailability is static
                UniversalGameManager.UpdatePlayerInputAvailability(!IsOpen);
                
                if (IsOpen)
                {
                    UniversalGameManager.OpenInputBlockerMenu();
                }
                else
                {
                    UniversalGameManager.CloseInputBlockerMenu();
                }
                
                PluginManager.Log.LogMessage($"Console: UniversalGameManager input availability set to {!IsOpen}");
            }
            catch (System.Exception e)
            {
                PluginManager.Log.LogWarning($"Console: Failed to update UniversalGameManager input: {e.Message}");
            }

            // 3. Toggle EventSystem to block UI navigation (Main Menu AD/JK)
            // We use sendNavigationEvents instead of enabled, because disabling the component
            // makes EventSystem.current return null, preventing us from re-enabling it later.
            var eventSystem = EventSystem.current;
            if (eventSystem != null)
            {
                eventSystem.sendNavigationEvents = !IsOpen;
                PluginManager.Log.LogMessage($"Console: EventSystem sendNavigationEvents = {eventSystem.sendNavigationEvents}");
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

            if (Input.GetKeyDown(KeyCode.Slash))
            {
                if (!IsOpen)
                {
                    IsOpen = true;
                    input = "";
                    focusTextField = true;
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
                input = inputs[^inputsCursor];
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
                PluginManager.Log.LogMessage("forcing focus control");
                focusTextField = false;
            }

            // Execute command if Enter was pressed
            if (submit)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    ExecuteCommand(input);
                    inputs.Add(input);
                    inputsCursor = 0;
                    input = "";
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

        public void Log(string message)
        {
            logs.Add(message);
            if (logs.Count > MaxLogs) logs.RemoveAt(0);
            scrollPosition.y = float.MaxValue;
        }

        private void ExecuteCommand(string cmd)
        {
            PluginManager.Log.LogMessage($"Console Command: {cmd}");
            Log("> " + cmd);

            string[] parts = cmd.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return;

            string command = parts[0].ToLower();
            string[] args = new string[parts.Length - 1];
            System.Array.Copy(parts, 1, args, 0, args.Length);

            switch (command)
            {
                case "help":
                    HelpCommand();
                    break;
                case "clear":
                    logs.Clear();
                    inputs.Clear();
                    break;
                case "echo":
                    EchoCommand(args);
                    break;
                case "log":
                    LogCommand(args);
                    break;
                case "get":
                    GetCommand(args);
                    break;
                case "set":
                    SetCommand(args);
                    break;
                case "mp":
                    MultiplayerCommand(args);
                    break;
                case "call":
                    CallCommand(args);
                    break;
                default:
                    Log("Unknown command: " + command);
                    break;
            }
        }

        private void HelpCommand()
        {
            Log("Available commands: help, clear, echo, log, get, set, mp");
        }

        private void EchoCommand(string[] args)
        {
            if (args.Length == 0)
            {
                Log("Usage: echo <message>");
                return;
            }
            Log(string.Join(" ", args));
        }

        private void LogCommand(string[] args)
        {
            if (args.Length == 0)
            {
                Log("Usage: log <message>");
                return;
            }
            string message = string.Join(" ", args);
            PluginManager.Log.LogMessage($"[Console] {message}");
            Log($"Logged: {message}");
        }

        private void GetCommand(string[] args)
        {
            var availableFields = "currentactivemaplabel, allcharacters";
            if (args.Length == 0)
            {
                Log("Usage: get <field>");
                Log($"Available fields: {availableFields}");
                return;
            }

            string field = string.Join(" ", args).ToLower();

            switch (field)
            {
                case "currentactivemaplabel":
                    Log($"Current Active Map Label: {MystiaManager.MapLabel}");
                    break;
                case "enabledebugconsole":
                    Log($"Debug Console Enabled: {SplashScene.SceneManager.EnableDebugCosole}");
                    break;
                case "pos":
                    Log($"Mystia position: {MystiaManager.Instance.GetPosition()}");
                    break;
                default:
                    Log($"Unknown field: {field}");
                    Log($"Available fields: {availableFields}");
                    break;
            }
        }

        private void SetCommand(string[] args)
        {
            var availableFields = "KyoukoCollider";
            if (args.Length == 0)
            {
                Log("Usage: set <field> <value...>");
                Log($"Available fields: {availableFields}");
                return;
            }

            string field = args[0].ToLower();
            switch (field)
            {
                case "kyoukocollider":
                    if (args.Length < 2)
                    {
                        Log("Usage: set kyoukocollider <on/off>");
                        return;
                    }
                    bool enableCollider = args[1].ToLower() == "on";
                    KyoukoManager.Instance.GetCharacterUnit().UpdateColliderStatus(enableCollider);
                    Log($"Kyouko collider forced {(enableCollider ? "ON" : "OFF")}");
                    break;

                default:
                    Log($"Unknown field: {field}");
                    Log($"Available fields: {availableFields}");
                    break;
            }
        }

        private void MultiplayerCommand(string[] args)
        {
            if (args.Length == 0)
            {
                Log("Usage: mp <subcommand> [args]");
                Log("Subcommands: start, stop, restart, status, ping, id, connect, disconnect");
                return;
            }

            string subcommand = args[0].ToLower();

            switch (subcommand)
            {
                case "start":
                    MpManager.Instance.Start();
                    Log("Multiplayer started");
                    break;
                case "stop":
                    MpManager.Instance.Stop();
                    Log("Multiplayer stopped");
                    break;
                case "restart":
                    MpManager.Instance.Restart();
                    Log("Multiplayer restarted");
                    break;
                case "status":
                    Log(MpManager.Instance.GetStatus());
                    break;
                case "ping":
                    if (!MpManager.Instance.IsConnected)
                    {
                        Log("Error: Not connected to peer");
                    }
                    else
                    {
                        MpManager.Instance.SendPing();
                        Log("Ping sent");
                    }
                    break;
                case "id":
                    if (args.Length < 2)
                    {
                        Log("Usage: mp id <new_id>");
                        break;
                    }
                    MpManager.Instance.PlayerId = args[1];
                    Log($"Player ID set to {args[1]}");
                    break;
                case "connect":
                    if (args.Length < 2)
                    {
                        Log("Usage: mp connect <ip>");
                        break;
                    }
                    string targetIp = args[1];
                    if (MpManager.Instance.ConnectToPeer(targetIp))
                    {
                        Log($"Connected to {targetIp}");
                    }
                    else
                    {
                        Log($"Failed to connect to {targetIp}");
                    }
                    break;
                case "disconnect":
                    if (!MpManager.Instance.IsConnected)
                    {
                        Log("No active connection");
                    }
                    else
                    {
                        MpManager.Instance.DisconnectPeer();
                        Log("Disconnected");
                    }
                    break; 
                default:
                    Log($"Unknown subcommand: {subcommand}");
                    Log("Available subcommands: start, stop, restart, status, ping, id, connect, disconnect");
                    break;
            }
        }

        private void CallCommand(string[] args)
        {
            var availableFields = "getmapsnpcs, movecharacter";
            if (args.Length == 0)
            {
                Log("Usage: call <method> [args]");
                Log($"Available methods: {availableFields}");
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
                            Log($"- {npc.Key}"); // TrackedNPC 有 ToString 方法，不过没啥东西
                        }
                        Log($"Total NPCs found: {npcs.Count}");
                    }
                    catch (System.Exception e)
                    {
                        Log($"Error calling getmapsnpcs: {e.Message}");
                    }
                    break;
                case "movecharacter":
                    if (args.Length < 6)
                    {
                        Log("Usage: call movecharacter <characterKey> <mapLabel> <x> <y> <rot>");
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
                        Log($"Moved character '{characterKey}' to position ({x}, {y}) rotation {rot} on map '{mapLabel}'.");
                    }
                    catch (System.Exception e)
                    {
                        Log($"Error calling movecharacter: {e.Message}");
                    }
                    break;
                case "scene_move":
                    if (args.Length < 4)
                    {
                        Log("Usage: call scene_move <characterKey> <x> <y>");
                        break;
                    }
                    try
                    {
                        string characterKey = args[1];
                        float x = float.Parse(args[2]);
                        float y = float.Parse(args[3]);
                        var arr = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<Vector2>(1);
                        arr[0] = new Vector2(x, y);
                        Common.SceneDirector.Instance.MoveCharacter(characterKey, arr, 1.48f, new System.Action(() => {}));
                        Log($"Moved character '{characterKey}' to position ({x}, {y})'.");
                    }
                    catch (System.Exception e)
                    {
                        Log($"Error calling scene_move: {e.Message}");
                    }
                    break;
                case "sc_move_kyouko_here":
                    try
                    {
                        var arr = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<Vector2>(1);
                        arr[0] = MystiaManager.Instance.GetPosition();
                        Common.SceneDirector.Instance.MoveCharacter(KyoukoManager.KYOUKO_ID, arr, 2.0f, new System.Action(() => {}));
                        Log($"Moved character '{KyoukoManager.KYOUKO_ID}' to position {arr[0]}'.");
                    }
                    catch (System.Exception e)
                    {
                        Log($"Error calling sc_move_kyouko_here: {e.Message}");
                    }
                    break;
                default:
                    Log($"Unknown method: {method}");
                    Log($"Available methods: {availableFields}");
                    break;
            }
        }
    }
}

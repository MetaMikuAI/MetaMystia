#nullable enable
using System;
using System.IO;
using Il2CppInterop.Runtime;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using Common.UI;

using MetaMystia.ConsoleSystem;
using MetaMystia.Network;

namespace MetaMystia.UI;

[AutoLog]
public static partial class InGameConsole
{
    private static bool _isOpen = false;
    public static bool IsOpen
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

    private static string input = "";
    private static Vector2 scrollPosition;
    private static List<string> logs = [];
    private static List<string> inputs = [];
    private static int inputsCursor = 0;
    private const int MaxLogs = 1024;
    private static int MaxHistorySize => ConfigManager.ConsoleHistorySize?.Value ?? 200;
    private static string HistoryFilePath => Path.Combine(
        BepInEx.Paths.ConfigPath, ConfigManager.ConsoleHistoryFile?.Value ?? "MetaMystia_console_history.txt");
    private static bool focusTextField = true;
    private static bool moveCursor = false;
    private const string TextFieldControlName = "ConsoleInput";
    private static bool justOpened = false;

    // Command system
    private static ConsoleContext _consoleContext = null!;
    private static CompletionEngine _completion = new();

    // Deferred log queue: messages that depend on L10N, flushed after language system is ready
    private static readonly List<Func<string>> _deferredLogs = [];
    private static bool _deferredFlushed = false;

    // IMGUI style cache
    private static GUIStyle? _logStyle;
    private static GUIStyle? _inputStyle;
    private static GUIStyle? _completionStyle;
    private static GUIStyle? _completionSelectedStyle;
    private static GUIStyle? _headerStyle;
    private static Texture2D? _bgTexture;
    private static Texture2D? _inputBgTexture;
    private static Texture2D? _completionBgTexture;
    private static Texture2D? _completionSelTexture;
    private static bool _stylesInitialized = false;

    public static void Initialize()
    {
        _consoleContext = new ConsoleContext(LogToConsole);
        CommandRegistry.Initialize();
        LoadHistory();

        // Startup messages — queued for deferred resolution after language system loads
        LogToConsole($"<color=#66CCFF>MetaMystia</color> <color=#888899>v{MyPluginInfo.PLUGIN_VERSION}</color>");
        LogDeferred(() => $"<color=#888899>{TextId.ConsoleStarPrompt.Get()}</color>");
        LogDeferred(() => $"<color=#888899>{TextId.ConsoleHelpHint.Get()}</color>");
    }

    private static void LoadHistory()
    {
        try
        {
            if (File.Exists(HistoryFilePath))
            {
                var lines = File.ReadAllLines(HistoryFilePath);
                inputs.AddRange(lines);
                if (inputs.Count > MaxHistorySize)
                    inputs.RemoveRange(0, inputs.Count - MaxHistorySize);
            }
        }
        catch (Exception ex)
        {
            Log.LogWarning($"Failed to load console history: {ex.Message}");
        }
    }

    private static void SaveHistory()
    {
        try
        {
            var toSave = inputs.Count > MaxHistorySize
                ? inputs.GetRange(inputs.Count - MaxHistorySize, MaxHistorySize)
                : inputs;
            File.WriteAllLines(HistoryFilePath, toSave);
        }
        catch (Exception ex)
        {
            Log.LogWarning($"Failed to save console history: {ex.Message}");
        }
    }

    /// <summary>
    /// Queue a log message that depends on L10N. The factory is evaluated lazily
    /// when <see cref="FlushDeferred"/> is called (after language system is ready).
    /// If already flushed, the message is resolved and printed immediately.
    /// </summary>
    public static void LogDeferred(Func<string> messageFactory)
    {
        if (_deferredFlushed)
            LogToConsole(messageFactory());
        else
            _deferredLogs.Add(messageFactory);
    }

    /// <summary>
    /// Resolve and print all deferred log messages. Call once after L10N is ready (MainScene Awake).
    /// </summary>
    public static void FlushDeferred()
    {
        foreach (var factory in _deferredLogs)
            LogToConsole(factory());
        _deferredLogs.Clear();
        _deferredFlushed = true;
    }

    public static void AddPeerMessage(string senderName, string message)
    {
        LogToConsole(TextId.PeerMessagePrefix.Get(senderName, message));
    }

    public static void ClearLogs()
    {
        logs.Clear();
    }

    private static void UpdateGameInputState()
    {
        try
        {
            UniversalGameManager.UpdatePlayerInputAvailability(!IsOpen);
        }
        catch (System.Exception e)
        {
            Log.LogWarning($"Console: Failed to update UniversalGameManager input: {e.Message}");
        }

        var eventSystem = EventSystem.current;
        if (eventSystem != null)
        {
            eventSystem.sendNavigationEvents = !IsOpen;
        }
    }

    public static void Update()
    {
        if (IsOpen)
        {
            var es = EventSystem.current;
            if (es != null && es.sendNavigationEvents)
                es.sendNavigationEvents = false;
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
                _completion.Reset();
            }
        }
    }

    #region IMGUI Styles

    private static void InitStyles()
    {
        if (_stylesInitialized) return;
        _stylesInitialized = true;

        _bgTexture = MakeTex(1, 1, new Color(0.08f, 0.08f, 0.12f, 0.92f));
        _inputBgTexture = MakeTex(1, 1, new Color(0.12f, 0.12f, 0.18f, 0.95f));
        _completionBgTexture = MakeTex(1, 1, new Color(0.15f, 0.15f, 0.22f, 0.98f));
        _completionSelTexture = MakeTex(1, 1, new Color(0.25f, 0.40f, 0.65f, 0.95f));

        int fontSize = Mathf.Clamp(Screen.height / 40, 16, 28);

        _headerStyle = new GUIStyle(GUI.skin.label)
        {
            fontSize = fontSize + 4,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.MiddleLeft,
            normal = { textColor = new Color(0.85f, 0.85f, 0.95f) }
        };

        _logStyle = new GUIStyle(GUI.skin.label)
        {
            fontSize = fontSize,
            wordWrap = true,
            richText = true,
            normal = { textColor = new Color(0.9f, 0.9f, 0.9f) },
        };
        _logStyle.padding.left = 4;
        _logStyle.padding.right = 4;
        _logStyle.padding.top = 1;
        _logStyle.padding.bottom = 1;

        _inputStyle = new GUIStyle(GUI.skin.textField)
        {
            fontSize = fontSize,
            normal = { textColor = new Color(0.95f, 0.95f, 1f), background = _inputBgTexture },
            focused = { textColor = Color.white, background = _inputBgTexture },
        };
        _inputStyle.padding.left = 8;
        _inputStyle.padding.right = 8;
        _inputStyle.padding.top = 7;
        _inputStyle.padding.bottom = 9;
        _inputStyle.overflow.bottom = 4;

        _completionStyle = new GUIStyle(GUI.skin.label)
        {
            fontSize = fontSize - 2,
            normal = { textColor = new Color(0.8f, 0.8f, 0.85f), background = _completionBgTexture },
        };
        _completionStyle.padding.left = 10;
        _completionStyle.padding.right = 10;
        _completionStyle.padding.top = 4;
        _completionStyle.padding.bottom = 4;
        _completionStyle.margin.left = 0;
        _completionStyle.margin.right = 0;
        _completionStyle.margin.top = 0;
        _completionStyle.margin.bottom = 0;

        _completionSelectedStyle = new GUIStyle(_completionStyle)
        {
            normal = { textColor = Color.white, background = _completionSelTexture },
            fontStyle = FontStyle.Bold
        };
    }

    private static Texture2D MakeTex(int w, int h, Color col)
    {
        var tex = new Texture2D(w, h);
        for (int x = 0; x < w; x++)
            for (int y = 0; y < h; y++)
                tex.SetPixel(x, y, col);
        tex.Apply();
        tex.hideFlags = HideFlags.HideAndDontSave;
        return tex;
    }

    #endregion

    public static void OnGUI()
    {
        if (!IsOpen) return;

        InitStyles();

        Event e = Event.current;

        // Handle Escape
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.Escape)
        {
            if (_completion.IsActive)
                _completion.Dismiss();
            else
                IsOpen = false;
            e.Use();
            return;
        }

        // Handle Tab: Minecraft-style inline cycling
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.Tab)
        {
            if (_completion.HasCompletions)
            {
                var applied = _completion.TabCycle(reverse: e.shift);
                if (applied != null)
                {
                    input = applied;
                    moveCursor = true;
                }
            }
            e.Use();
        }

        // Handle Enter: always submit (no completion acceptance)
        bool submit = false;
        if (e.type == EventType.KeyDown && (e.keyCode == KeyCode.Return || e.keyCode == KeyCode.KeypadEnter))
        {
            submit = true;
            e.Use();
        }

        // Handle Up/Down arrows: history navigation only (no dropdown cycling)
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.UpArrow)
        {
            if (_completion.IsTabCycling)
                _completion.Dismiss();
            if (inputsCursor < inputs.Count)
            {
                inputsCursor++;
                if (inputs.Count > 0)
                {
                    input = inputs[^inputsCursor];
                    moveCursor = true;
                }
            }
            e.Use();
        }
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.DownArrow)
        {
            if (_completion.IsTabCycling)
                _completion.Dismiss();
            if (inputsCursor > 1)
            {
                inputsCursor--;
                input = inputs[^inputsCursor];
            }
            else
                input = "";
            moveCursor = true;
            e.Use();
        }

        // Consume Slash key on justOpened
        if (justOpened && e.type == EventType.KeyDown && e.character == '/')
            e.Use();

        // Layout
        float width = Screen.width * 0.8f;
        float height = Screen.height * 0.7f;
        float x = (Screen.width - width) / 2;
        float y = (Screen.height - height) / 2;
        float padding = 16f;
        float headerHeight = 40f;
        float inputHeight = 46f;

        // Background
        GUI.DrawTexture(new Rect(x, y, width, height), _bgTexture, ScaleMode.StretchToFill);

        // Header
        GUI.Label(new Rect(x + padding, y + 6, width - padding * 2, headerHeight),
            "MetaMystia Console", _headerStyle);

        // Separator line
        GUI.DrawTexture(new Rect(x + padding, y + headerHeight + 2, width - padding * 2, 1),
            MakeTex(1, 1, new Color(0.3f, 0.3f, 0.4f)));

        // Log area
        float logTop = y + headerHeight + 6;
        float logHeight = height - headerHeight - inputHeight - padding * 2 - 6;

        GUILayout.BeginArea(new Rect(x + padding, logTop, width - 2 * padding, logHeight));
        scrollPosition = GUILayout.BeginScrollView(scrollPosition);
        foreach (var log in logs)
            GUILayout.Label(log, _logStyle);
        GUILayout.EndScrollView();
        GUILayout.EndArea();

        // Input field
        float inputY = y + height - inputHeight - padding;
        GUI.SetNextControlName(TextFieldControlName);
        string prevInput = input;
        input = GUI.TextField(new Rect(x + padding, inputY, width - 2 * padding, inputHeight), input, _inputStyle);

        // Detect input text change (typing, not Tab)
        if (input != prevInput)
        {
            _completion.UpdateCompletions(input);
        }

        if (focusTextField)
        {
            GUI.FocusControl(TextFieldControlName);
            focusTextField = false;
        }

        // Move cursor to end
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

        // Draw completion dropdown
        if (_completion.IsActive)
            DrawCompletionDropdown(x + padding, inputY, width - 2 * padding);

        // Execute command on submit
        if (submit)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ExecuteCommand(input, out bool closeConsole);
                inputs.Add(input);
                inputsCursor = 0;
                input = "";
                _completion.Reset();
                SaveHistory();
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

        // Consume all other KeyDown events
        if (e.type == EventType.KeyDown && e.keyCode != KeyCode.None)
            e.Use();
    }

    private static void DrawCompletionDropdown(float x, float inputY, float width)
    {
        float itemHeight = (_completionStyle!.fontSize + 10);

        // Hint mode: show a single non-selectable dim hint
        if (_completion.HasHint)
        {
            float hintHeight = itemHeight + 4;
            float hintY = inputY - hintHeight;
            GUI.DrawTexture(new Rect(x, hintY, width, hintHeight), _completionBgTexture, ScaleMode.StretchToFill);

            var hintStyle = new GUIStyle(_completionStyle)
            {
                fontStyle = FontStyle.Italic,
                normal = { textColor = new Color(0.55f, 0.55f, 0.65f) }
            };
            GUI.Label(new Rect(x, hintY + 2, width, itemHeight),
                $"  {_completion.Hint}", hintStyle);
            return;
        }

        // Normal completion mode
        var completions = _completion.Completions;
        int totalCount = completions.Count;
        int maxVisible = System.Math.Min(totalCount, CompletionEngine.MaxVisibleItems);
        float dropdownHeight = maxVisible * itemHeight + 4;

        // Draw above the input field
        float dropY = inputY - dropdownHeight;
        GUI.DrawTexture(new Rect(x, dropY, width, dropdownHeight), _completionBgTexture, ScaleMode.StretchToFill);

        int offset = _completion.ScrollOffset;
        for (int i = 0; i < maxVisible; i++)
        {
            int itemIndex = offset + i;
            if (itemIndex >= totalCount) break;

            bool isSelected = itemIndex == _completion.SelectedIndex;
            var style = isSelected ? _completionSelectedStyle : _completionStyle;
            float itemY = dropY + 2 + i * itemHeight;

            // Rich text highlights the matching prefix
            string displayText = _completion.FormatWithHighlight(completions[itemIndex]);
            GUI.Label(new Rect(x, itemY, width, itemHeight), displayText, style);
        }

        // Show scroll indicator if there are hidden items
        if (totalCount > maxVisible)
        {
            string indicator = $"[{offset + 1}-{System.Math.Min(offset + maxVisible, totalCount)}/{totalCount}]";
            var indicatorStyle = new GUIStyle(_completionStyle)
            {
                alignment = TextAnchor.MiddleRight,
                normal = { textColor = new Color(0.5f, 0.5f, 0.6f) }
            };
            GUI.Label(new Rect(x, dropY + dropdownHeight - itemHeight, width - 8, itemHeight), indicator, indicatorStyle);
        }
    }

    public static void LogToConsole(string message)
    {
        logs.Add(message);
        if (logs.Count > MaxLogs) logs.RemoveAt(0);
        scrollPosition.y = float.MaxValue;
    }

    private static void ExecuteCommand(string cmd, out bool closeConsole)
    {
        closeConsole = false;
        Log.LogMessage($"Console Command: {cmd}");
        LogToConsole(TextId.CommandPrompt.Get(cmd));

        bool isMessage = cmd[0] != '/';
        if (isMessage)
        {
            // Plain text = chat message
            if (!MpManager.IsConnected)
                LogToConsole(TextId.MpNoActiveConnection.Get());
            else
            {
                MessageAction.Send(cmd);
                LogToConsole(TextId.MessageSent.Get(cmd));
            }
            closeConsole = true;
        }
        else
        {
            // Strip leading '/' and delegate to CommandRegistry
            string commandInput = cmd[1..];
            closeConsole = CommandRegistry.Execute(commandInput, _consoleContext);
        }
    }
}

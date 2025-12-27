using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Common.UI;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace MetaMystia;

[AutoLog]
public partial class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    private readonly string label = $"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} loaded";
    public static InGameConsole Console { get; private set; }
    private bool isTextVisible = true;
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();
    private readonly List<(Action action, Func<bool> condition)> _conditionalActions = new List<(Action, Func<bool>)>();
    public static Scene CurrentGameScene { get; set; } = Scene.MainScene;

    public PluginManager(IntPtr ptr) : base(ptr)
    {
        if (Instance != null)
        {
            Log.LogWarning($"Another instance of PluginManager already exists! Destroying this one.");
            Destroy(this);
            return;
        }
        Instance = this;
    }

    internal static GameObject Create(string name)
    {
        var gameObject = new GameObject(name);
        DontDestroyOnLoad(gameObject);

        gameObject.AddComponent(Il2CppType.Of<PluginManager>());

        return gameObject;
    }

    private void Awake()
    {
        Console = new InGameConsole();
        // MpManager.Start();
    }

    private void OnGUI()
    {
        Console?.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(label);
            info.AppendLine(MpManager.GetBriefStatus());
            GUI.Label(new Rect(10, Screen.height - 50, 600, 50), info.ToString());
        }
    }

    private void Update()
    {
        while (_mainThreadQueue.TryDequeue(out var action))
        {
            try
            {
                action();
                // Log.LogDebug($"Successfully executed action on main thread");
            }
            catch (Exception e)
            {
                Log.LogError($"Error executing on main thread: {e.Message}\n{e.StackTrace}");
            }
        }

        Console?.Update();

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Log.LogInfo($"\n");
        }
        if (Input.GetKeyDown(KeyCode.Backslash)) 
        {
            isTextVisible = !isTextVisible;
            Log.LogMessage($"Toggled text visibility: " + isTextVisible);
        }


        if (Input.GetKeyDown(KeyCode.F10))
        {
            DLCManager.Initialize();
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            Plugin.Debugger??= new Debugger.WebDebugger();
            Plugin.Debugger?.Start();
        }

        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            _ = MpManager.ConnectToPeerAsync("192.168.1.39", 40815); // 这是 SgrYuki 的主机，测试用
        }
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            MpManager.Start();
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            MpManager.Stop();
        }
    }

    public void RunOnMainThread(Action action)
    {
        // Log.LogDebug($"Enqueue action to run on main thread");
        _mainThreadQueue.Enqueue(action);
    }

    public void RunOnMainThread(Action action, Func<bool> condition)
    {
        if (condition == null)
        {
            RunOnMainThread(action);
            return;
        }

        lock (_conditionalActions)
        {
            _conditionalActions.Add((action, condition));
        }
    }

    private void FixedUpdate()
    {
        SgrYuki.Utils.CommandScheduler.Tick();
        lock (_conditionalActions)
        {
            for (int i = _conditionalActions.Count - 1; i >= 0; i--)
            {
                var (action, condition) = _conditionalActions[i];
                bool shouldRun = false;
                try
                {
                    shouldRun = condition();
                }
                catch (Exception e)
                {
                    Log.LogError($"Error checking condition: {e.Message}");
                    _conditionalActions.RemoveAt(i);
                    continue;
                }

                if (shouldRun)
                {
                    RunOnMainThread(action);
                    _conditionalActions.RemoveAt(i);
                }
            }
        }

        switch (CurrentGameScene)
        {
            case Scene.DayScene:
                KyoukoManager.OnFixedUpdate();
                break;
            case Scene.WorkScene:
                KyoukoManager.OnFixedUpdate();
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
    }
}

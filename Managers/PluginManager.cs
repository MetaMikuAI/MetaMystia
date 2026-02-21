using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using Il2CppInterop.Runtime;

using Common.UI;

using SgrYuki;
using SgrYuki.Utils;

using static SgrYuki.Utils.ContainerExtensions;

namespace MetaMystia;

[AutoLog]
public partial class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static readonly string Label = $"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} loaded";
    public static InGameConsole Console { get; private set; }
    public static Debugger.WebDebugger Debugger = null;
    private bool isTextVisible = true;
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();
    private readonly List<(Action action, Func<bool> condition)> _conditionalActions = new List<(Action, Func<bool>)>();
    public static bool DEBUG => Plugin.ConfigDebug.Value;

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
    }

    private void OnGUI()
    {
        Console?.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(Label);
            info.AppendLine(MpManager.BriefStatus);
            GUI.Label(new Rect(10, Screen.height - 50, 600, 50), info.ToString());
        }
    }

    private void Update()
    {
        UpdateRunOnMainThreadQueue();

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


        if (DEBUG)
        {
            #region F1-F6: OverrideRole debug controls
            if (Input.GetKeyDown(KeyCode.F1))
            {
                MpManager.OverrideRole = null;
                Log.LogMessage($"Local OverrideRole -> null (follow transport)");
                Notify.Show($"本地应用层角色: 跟随传输层 {MpManager.RoleTag}");
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                MpManager.OverrideRole = MpManager.ROLE.Host;
                Log.LogMessage($"Local OverrideRole -> Host");
                Notify.Show($"本地应用层角色: Host {MpManager.RoleTag}");
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                MpManager.OverrideRole = MpManager.ROLE.Client;
                Log.LogMessage($"Local OverrideRole -> Client");
                Notify.Show($"本地应用层角色: Client {MpManager.RoleTag}");
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                Network.OverrideRoleAction.Send(null);
                Log.LogMessage($"Remote OverrideRole -> null (follow transport)");
                Notify.Show($"已发送对方应用层角色: 跟随传输层");
            }
            if (Input.GetKeyDown(KeyCode.F5))
            {
                Network.OverrideRoleAction.Send(MpManager.ROLE.Host);
                Log.LogMessage($"Remote OverrideRole -> Host");
                Notify.Show($"已发送对方应用层角色: Host");
            }
            if (Input.GetKeyDown(KeyCode.F6))
            {
                Network.OverrideRoleAction.Send(MpManager.ROLE.Client);
                Log.LogMessage($"Remote OverrideRole -> Client");
                Notify.Show($"已发送对方应用层角色: Client");
            }
            #endregion

            if (Input.GetKeyDown(KeyCode.F9))
            {
                WorkSceneManager.CloseIzakayaIfPossible();
            }
            if (Input.GetKeyDown(KeyCode.F11))
            {
                Debugger ??= new Debugger.WebDebugger();
                Debugger?.Start();
            }
        }
    }

    private void UpdateRunOnMainThreadQueue()
    {
        while (_mainThreadQueue.TryDequeue(out var action))
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Log.LogError($"Error executing on main thread: {e.Message}\n{e.StackTrace}");
            }
        }
    }

    public void RunOnMainThread(Action action) => _mainThreadQueue.Enqueue(action);

    private void FixedUpdate()
    {
        CommandScheduler.Tick();

        switch (MpManager.LocalScene)
        {
            case Scene.DayScene:
                PeerManager.OnFixedUpdate();
                break;
            case Scene.WorkScene:
                PeerManager.OnFixedUpdate();
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
    }
}

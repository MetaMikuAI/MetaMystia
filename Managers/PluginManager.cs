using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Common.UI;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using HarmonyLib;
using Il2CppInterop.Runtime;
using SgrYuki;
using SgrYuki.Utils;
using UnityEngine;

namespace MetaMystia;

[AutoLog]
public partial class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }

    private const string ChangePluginNameCommand = "ChangePluginNameCommand";
    private const int ChangePluginNameCommandInterval = 120;
    private readonly string[] PluginNames = [MyPluginInfo.PLUGIN_NAME, "ShigureMystia"];
    private static string PluginName = MyPluginInfo.PLUGIN_NAME;
    private static string LoadedLabel(string pluginName) => $"{pluginName} v{MpManager.ModVersion} loaded";
    public static string Label => LoadedLabel(PluginName);

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
        CommandScheduler.EnqueueInterval(
            commandId: ChangePluginNameCommand,
            intervalSeconds: ChangePluginNameCommandInterval,
            execute: () => PluginName = PluginNames.GetRandomOne()
        );
    }

    private void OnGUI()
    {
        Console?.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(Label);
            info.AppendLine(MpManager.GetBriefStatus());
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
            if (Input.GetKeyDown(KeyCode.F1))
            {
                var allMerchants = GameData.Core.Collections.DaySceneUtility.DataBaseDay.allMerchants;
                foreach (var kvp in allMerchants)
                {
                    var merchant = kvp.Value;
                    Log.Warning($"Merchant ID: {kvp.Key}");
                    Log.Warning($"  - leastSellNum: \t{merchant.leastSellNum}");
                    Log.Warning($"  - nullDialogPackage: \t{merchant.nullDialogPackage.Count} dialog packages");
                    Log.Warning($"  - welcomeDialogPackage: \t{merchant.welcomeDialogPackage.Count} dialog packages");
                    Log.Warning($"  - priceMultiplierRange: \t{merchant.priceMultiplierRange}");
                    Log.Warning($"  - merchandiseCollection: \t{merchant.merchandiseCollection.Count} items");
                }
            }

            if (Input.GetKeyDown(KeyCode.F9))
            {
                WorkSceneManager.CloseIzakayaIfPossible();
            }
            if (Input.GetKeyDown(KeyCode.F11))
            {
                Debugger ??= new Debugger.WebDebugger();
                Debugger?.Start();
            }

            if (Input.GetKeyDown(KeyCode.RightBracket) || Input.GetKeyDown(KeyCode.KeypadDivide))
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

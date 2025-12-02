using BepInEx.Logging;
using UnityEngine;
using System;
using Il2CppInterop.Runtime;
using System.Collections.Concurrent;
using Common.UI;
using Common.DialogUtility;

namespace MetaMystia;
public class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static ManualLogSource Log => Plugin.Instance.Log;
    public static InGameConsole Console { get; private set; }

    private bool isTextVisible = true;
    private string label = "MetaMystia loaded";
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();
    private static readonly string LOG_TAG = "[PluginManager.cs]";
    public static Common.UI.IzakayaSelectorPanel_New temp_instance = null;
    public static bool temp_bool = false;
    private static int count = 0;

    public PluginManager(IntPtr ptr) : base(ptr)
    {
        if (Instance != null)
        {
            Log.LogWarning($"{LOG_TAG} Another instance of PluginManager already exists! Destroying this one.");
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
        // MpManager.Instance.Start();
    }

    private void OnGUI()
    {
        if (Console != null) Console.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(label);
            info.AppendLine(MpManager.Instance.GetBriefStatus());
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
                Log.LogDebug($"{LOG_TAG} Successfully executed action on main thread");
            }
            catch (System.Exception e)
            {
                Log.LogError($"{LOG_TAG} Error executing on main thread: {e}");
            }
        }

        if (Console != null) Console.Update();

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Log.LogInfo($"\n");
        }
        if (Input.GetKeyDown(KeyCode.Backslash)) {
            isTextVisible = !isTextVisible;
            Log.LogMessage($"{LOG_TAG} Toggled text visibility: " + isTextVisible);
        }
    }

    public void RunOnMainThread(Action action)
    {
        Log.LogDebug($"{LOG_TAG} Enqueue action to run on main thread");
        _mainThreadQueue.Enqueue(action);
    }

    private void FixedUpdate()
    {
        KyoukoManager.Instance.OnFixedUpdate();
        MystiaManager.Instance.OnFixedUpdate();
    }

    private void OnDestroy()
    {
    }
}

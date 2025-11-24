using BepInEx.Logging;
using UnityEngine;
using UnityEngine.UI;
using System;
using Il2CppInterop.Runtime;
using System.Linq;
using System.Collections.Concurrent;

namespace MetaMystia;
public class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static ManualLogSource Log => Plugin.Instance.Log;
    public static InGameConsole Console { get; private set; }

    private bool isTextVisible = true;
    private string label = "MetaMystia loaded";
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();

    public PluginManager(IntPtr ptr) : base(ptr)
    {
        if (Instance != null)
        {
            Log.LogWarning("Another instance of PluginManager already exists! Destroying this one.");
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
        // MultiplayerManager.Instance.Start();
    }

    private void OnGUI()
    {
        if (Console != null) Console.OnGUI();

        if (isTextVisible)
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine(label);
            info.AppendLine(MultiplayerManager.Instance.GetBriefStatus());
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
                Log.LogDebug("[PluginManager] Successfully executed action on main thread");
            }
            catch (Exception e)
            {
                Log.LogError($"Error executing on main thread: {e}");
            }
        }

        if (Console != null) Console.Update();

        if (Input.GetKeyDown(KeyCode.Backslash)) {
            isTextVisible = !isTextVisible;
            Log.LogMessage("Toggled text visibility: " + isTextVisible);
        }
    }

    public void RunOnMainThread(Action action)
    {
        Log.LogInfo($"[PluginManager.cs] Enqueue action to run on main thread");
        _mainThreadQueue.Enqueue(action);
    }

    private void FixedUpdate()
    {
        KyoukoManager.Instance.OnFixedUpdate();
        MystiaManager.Instance.OnFixedUpdate();
        if (Input.GetKeyDown(KeyCode.N))
        {
            Utils.test(false);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Utils.test(true);
        }
    }

    private void OnDestroy()
    {
    }
}

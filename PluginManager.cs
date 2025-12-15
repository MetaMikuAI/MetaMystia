using BepInEx.Logging;
using UnityEngine;
using System;
using Il2CppInterop.Runtime;
using System.Collections.Concurrent;
using Common.UI;
using System.Globalization;

namespace MetaMystia;
public class PluginManager : MonoBehaviour
{
    public static PluginManager Instance { get; private set; }
    public static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[PluginManager.cs]";
    private readonly string label = $"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} loaded";
    public static InGameConsole Console { get; private set; }
    private bool isTextVisible = true;
    private readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();
    public Scene CurrentGameScene { get; set; } = Scene.MainScene;

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
        Console?.OnGUI();

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
            catch (Exception e)
            {
                Log.LogError($"{LOG_TAG} Error executing on main thread: {e.Message}\n{e.StackTrace}");
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
            Log.LogMessage($"{LOG_TAG} Toggled text visibility: " + isTextVisible);
        }

        // F2 
        if (Input.GetKeyDown(KeyCode.F2))
        {
            var characters = Common.SceneDirector.Instance.characterCollection; // Il2CppSystem.Collections.Generic.Dictionary<string, Common.CharacterUtility.CharacterControllerUnit>
            foreach (var kvp in characters)
            {
                Log.LogWarning($"{LOG_TAG} Character Key: {kvp.Key}, Name: {kvp.Value.name}");
            }
            Log.LogWarning("");
            // 经测试，在白天中，玩家角色的 Key 即为 "Self", Name 为 "PlayerInstance"
            // 白天未加载户外场景时，字典中有且仅有 "Self" 一个角色
            // 夜间中，玩家角色的 Key 仍为 "Self", Name 变为 "米斯蒂娅"（可能随 Localization 变化）
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Physics2D.IgnoreCollision(
                Common.SceneDirector.Instance.characterCollection[NightKyoukoManager.KYOUKO_ID].cl2d,
                Common.SceneDirector.Instance.characterCollection["Self"].cl2d,
                true);
            Log.LogMessage($"{LOG_TAG} Ignoring collision between NightKyouko and Self (manual)");
        }
        
        var inputDirection = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.Keypad4))
        {
            inputDirection.x -= 1;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            inputDirection.x += 1;
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            inputDirection.y += 1;
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            inputDirection.y -= 1;
        }
        if (inputDirection != Vector2.zero)
        {
            var magnitude = inputDirection.magnitude;
            inputDirection /= magnitude; // Normalize
            NightKyoukoManager.UpdateInputDirection(inputDirection);
        }
    }

    public void RunOnMainThread(Action action)
    {
        Log.LogDebug($"{LOG_TAG} Enqueue action to run on main thread");
        _mainThreadQueue.Enqueue(action);
    }

    private void FixedUpdate()
    {
        switch (CurrentGameScene)
        {
            case Scene.DayScene:
                KyoukoManager.OnFixedUpdate();
                break;
            case Scene.WorkScene:
                NightKyoukoManager.OnFixedUpdate();
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
    }
}

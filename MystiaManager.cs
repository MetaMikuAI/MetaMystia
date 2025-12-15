using BepInEx.Logging;
using UnityEngine;
using Common.CharacterUtility;

namespace MetaMystia;

public class MystiaManager
{
    private static MystiaManager _instance;
    private static readonly object _lock = new object();
    
    private DayScene.Input.DayScenePlayerInputGenerator _cachedInputGenerator;
    private static ManualLogSource Log => Plugin.Instance.Log;
    public static string MapLabel { get; set; } = "";
    public static bool IsSprinting { get; set; } = false;
    public static Vector2 InputDirection { get; set; } = Vector2.zero;

    public static bool IsReady = false;
    private static readonly string LOG_TAG = "[MystiaManager.cs]";

    public static MystiaManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new MystiaManager();
                }
            }
            return _instance;
        }
    }

    private MystiaManager()
    {
    }

    public void Initialize()
    {
        Log.LogInfo($"{LOG_TAG} MystiaManager initialized");

        _cachedInputGenerator = null;
        MapLabel = "";
        IsSprinting = false;
        InputDirection = Vector2.zero;
        IsReady = false;
    }

    public DayScene.Input.DayScenePlayerInputGenerator GetInputGenerator(bool forceRefresh = false)
    {
        if (_cachedInputGenerator == null || forceRefresh)
        {
            var characters = UnityEngine.Object.FindObjectsOfType<DayScene.Input.DayScenePlayerInputGenerator>();
            if (characters == null || characters.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} Cannot find DayScenePlayerInputGenerator instance");
                return null;
            }
            if (characters.Length > 1)
            {
                Log.LogWarning($"{LOG_TAG} Found {characters.Length} DayScenePlayerInputGenerator instances, using the first one");
            }

            _cachedInputGenerator = characters[0];
        }

        return _cachedInputGenerator;
    }

    public CharacterControllerUnit GetCharacterUnit(bool forceRefresh = false)
    {
        
        switch (PluginManager.CurrentGameScene)
        {
            case Common.UI.Scene.DayScene:
                var inputGenerator = GetInputGenerator(forceRefresh);
                if (inputGenerator == null)
                {
                    Log.LogWarning($"{LOG_TAG} GetInputGenerator returned null");
                    return null;
                }
                var characterUnit = inputGenerator.Character;
                return characterUnit;        
            case Common.UI.Scene.WorkScene:
                if (!Common.SceneDirector.Instance.characterCollection.ContainsKey("Self"))
                {
                    Log.LogWarning($"{LOG_TAG} Character 'Self' not found in character collection");
                    return null;
                }
                return Common.SceneDirector.Instance.characterCollection["Self"];
            default:
                Log.LogWarning($"{LOG_TAG} GetCharacterComponent called in invalid scene");
                return null;
        }
    }

    private Rigidbody2D GetRigidbody2D(bool forceRefresh = false)
    {
        var characterUnit = GetCharacterUnit(forceRefresh);
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} GetCharacterUnit returned null");
            return null;
        }
        var rb = characterUnit.rb2d;
        return rb;
    }

    public Vector2 GetPosition()
    {
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            Log.LogWarning($"{LOG_TAG} GetRigidbody2D returned null");
            return Vector2.zero;
        }
        return rb.position;
    }
}

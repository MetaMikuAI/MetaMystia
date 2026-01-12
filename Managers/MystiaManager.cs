using Common.CharacterUtility;
using UnityEngine;

namespace MetaMystia;

[AutoLog]
public partial class MystiaManager
{
    private static MystiaManager _instance;
    private static readonly object _lock = new object();
    
    private DayScene.Input.DayScenePlayerInputGenerator _cachedInputGenerator;
    public static string MapLabel { get; set; } = "";
    public static bool IsSprinting { get; set; } = false;
    public static Vector2 InputDirection { get; set; } = Vector2.zero;

    public static bool IsDayOver = false;

    public static bool CharacterSpawnedAndInitialized => Common.SceneDirector.instance.characterCollection.ContainsKey("Self");

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
        Log.LogInfo($"MystiaManager initialized");

        _cachedInputGenerator = null;
        MapLabel = "";
        IsSprinting = false;
        InputDirection = Vector2.zero;
        IsDayOver = false;
    }

    public DayScene.Input.DayScenePlayerInputGenerator GetInputGenerator(bool forceRefresh = false)
    {
        if (_cachedInputGenerator == null || forceRefresh)
        {
            var characters = UnityEngine.Object.FindObjectsOfType<DayScene.Input.DayScenePlayerInputGenerator>();
            if (characters == null || characters.Length == 0)
            {
                Log.LogWarning($"Cannot find DayScenePlayerInputGenerator instance");
                return null;
            }
            if (characters.Length > 1)
            {
                Log.LogWarning($"Found {characters.Length} DayScenePlayerInputGenerator instances, using the first one");
            }

            _cachedInputGenerator = characters[0];
        }

        return _cachedInputGenerator;
    }

    public CharacterControllerUnit GetCharacterUnit(bool forceRefresh = false)
    {
        
        switch (MpManager.LocalScene)
        {
            case Common.UI.Scene.DayScene:
                var inputGenerator = GetInputGenerator(forceRefresh);
                if (inputGenerator == null)
                {
                    Log.LogWarning($"GetInputGenerator returned null");
                    return null;
                }
                var characterUnit = inputGenerator.Character;
                return characterUnit;        
            case Common.UI.Scene.WorkScene:
                if (!MystiaManager.CharacterSpawnedAndInitialized)
                {
                    Log.LogWarning($"Character 'Self' not found in character collection");
                    return null;
                }
                return Common.SceneDirector.Instance.characterCollection["Self"];
            default:
                Log.LogWarning($"GetCharacterComponent called in invalid scene");
                return null;
        }
    }

    private Rigidbody2D GetRigidbody2D(bool forceRefresh = false)
    {
        var characterUnit = GetCharacterUnit(forceRefresh);
        if (characterUnit == null)
        {
            Log.LogWarning($"GetCharacterUnit returned null");
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
            Log.LogWarning($"GetRigidbody2D returned null");
            return Vector2.zero;
        }
        return rb.position;
    }
}

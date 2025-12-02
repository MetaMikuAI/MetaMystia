using System;
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

    public static bool isReady = false;
    private static readonly string LOG_TAG = "[MystiaManager.cs]";

    public static MystiaManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MystiaManager();
                    }
                }
            }
            return _instance;
        }
    }

    private MystiaManager()
    {
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

    private CharacterControllerUnit GetCharacterUnit(bool forceRefresh = false)
    {
        var inputGenerator = GetInputGenerator(forceRefresh);
        if (inputGenerator == null)
        {
            Log.LogWarning($"{LOG_TAG} GetInputGenerator returned null");
            return null;
        }
        var characterUnit = inputGenerator.Character;
        return characterUnit;
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

    public void ClearCache()
    {
        _cachedInputGenerator = null;
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

    public bool GetMoving()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} GetCharacterUnit returned null in GetMoving");
            return false;
        }
        return characterUnit.IsMoving;
    }

    public float GetMoveSpeed()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} GetCharacterUnit returned null in GetMoveSpeed");
            return 1.0f;
        }
        return characterUnit.MoveSpeedMultiplier;
    }

    public Vector3 GetInputDirection()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} GetCharacterUnit returned null in GetInputDirection");
            return Vector3.zero;
        }
        return characterUnit.inputDirection;
    }
    
    public void UpdateMapLabel()
    {
        var sceneManager = DayScene.SceneManager.Instance;
        if (sceneManager == null)
        {
            Log.LogError($"{LOG_TAG} Cannot find DayScene.SceneManager instance");
            return;
        }
        MapLabel = sceneManager.CurrentActiveMapLabel;;
    }
}

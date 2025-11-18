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
    public static string MapLabel { get; private set; }

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
                Log.LogMessage("未找到 DayScenePlayerInputGenerator 实例");
                return null;
            }
            if (characters.Length > 1)
            {
                Log.LogWarning($"找到 {characters.Length} 个 DayScenePlayerInputGenerator 实例，使用第一个");
            }

            _cachedInputGenerator = characters[0];
        }

        return _cachedInputGenerator;
    }

    public CharacterControllerUnit GetCharacterUnit(bool forceRefresh = false)
    {
        var inputGenerator = GetInputGenerator(forceRefresh);
        if (inputGenerator == null)
        {
            return null;
        }

        var characterUnit = inputGenerator.Character;
        if (characterUnit == null)
        {
            Log.LogMessage("CharacterControllerUnit 为空");
            return null;
        }

        return characterUnit;
    }

    public Rigidbody2D GetRigidbody2D(bool forceRefresh = false)
    {
        var characterUnit = GetCharacterUnit(forceRefresh);
        if (characterUnit == null)
        {
            return null;
        }

        var rb = characterUnit.rb2d;
        if (rb == null)
        {
            Log.LogMessage("Rigidbody2D 为空");
            return null;
        }

        return rb;
    }

    public void ClearCache()
    {
        _cachedInputGenerator = null;
    }

    public Vector2? GetPosition()
    {
        var rb = GetRigidbody2D();
        return rb?.position;
    }

    public bool SetPosition(float x, float y)
    {
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            Log.LogWarning("Failed to get Rigidbody2D for Mystia");
            return false;
        }

        rb.position = new Vector2(x, y);
        Log.LogInfo($"Mystia position set to ({x}, {y})");
        return true;
    }

    public bool? GetMoving()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return null;
        }

        return characterUnit.IsMoving;
    }

    public bool SetMoving(bool isMoving)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning("Failed to get CharacterControllerUnit for Mystia");
            return false;
        }

        characterUnit.IsMoving = isMoving;
        Log.LogInfo($"Mystia moving status set to {isMoving}");
        return true;
    }

    public float? GetMoveSpeed()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return null;
        }

        return characterUnit.CurrentMoveSpeed;
    }

    public bool SetMoveSpeed(float speed)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning("Failed to get CharacterControllerUnit for Mystia");
            return false;
        }

        characterUnit.MoveSpeedMultiplier = speed;
        Log.LogInfo($"Mystia move speed set to {speed}");
        return true;
    }

    public Vector3 GetInputDirection()
    {
        var characterUnit = GetCharacterUnit();

        return characterUnit.inputDirection;
    }

    public bool SetInputDirection(float x, float y, float z = 0)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning("Failed to get CharacterControllerUnit for Mystia");
            return false;
        }

        characterUnit.inputDirection = new Vector3(x, y, z);
        Log.LogInfo($"Mystia input direction set to ({x}, {y}, {z})");
        return true;
    }

    public void UpdateMapLabel()
    {
        var sceneManager = DayScene.SceneManager.Instance;
        if (sceneManager == null)
        {
            Log.LogError("Cannot find DayScene.SceneManager instance");
            return;
        }
        MapLabel = sceneManager.CurrentActiveMapLabel;
    }
}

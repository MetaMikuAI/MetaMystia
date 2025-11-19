using System;
using BepInEx.Logging;
using UnityEngine;
using Common.CharacterUtility;
using DayScene.Interactables.Collections.ConditionComponents;

namespace MetaMystia;

public class KyoukoManager
{
    private static KyoukoManager _instance;
    private static readonly object _lock = new object();
    
    private const string KYOUKO_ID = "Kyouko";
    private static ManualLogSource Log => Plugin.Instance.Log;

    public static string MapLabel { get; private set; }
    public static bool IsKyoukoVisible { get; private set; } = true;
    private static Vector2 positionOffset;          // 位置偏移量 (收到同步信息时)= 同步位置 - 本地 Kyouko 位置         (FixedUpdate 时计算) positionOffset -= actualCurrectVelocity * Time.fixedDeltaTime;
    private static Vector2 expectedCurrectVelocity; // 预期修正速度 = 位置偏移量 / 修正系数 / Time.fixedDeltaTime               (同步时计算)
    private static Vector2 actualCurrectVelocity;   // 实际修正速度 = min{预期修正速度, positionOffset / Time.fixedDeltaTime}   (FixedUpdate)
    private static float currectCoefficient = 10.0f;        // 修正系数

    public static KyoukoManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new KyoukoManager();
                    }
                }
            }
            return _instance;
        }
    }

    private KyoukoManager()
    {
    }

    public void OnFixedUpdate()
    {
        // 在每个 FixedUpdate 执行位置修正
        if (positionOffset.magnitude > 0.001f)
        {
            // 计算实际修正速度
            float maxCorrection = positionOffset.magnitude / Time.fixedDeltaTime;
            actualCurrectVelocity = Vector2.ClampMagnitude(expectedCurrectVelocity, maxCorrection);
            
            // 应用修正
            positionOffset -= actualCurrectVelocity * Time.fixedDeltaTime;
            
            var rb = GetRigidbody2D();
            Log.LogWarning($"[DEBUG] before: rb.position = {rb.position}");
            rb.position += actualCurrectVelocity * Time.fixedDeltaTime;
            Log.LogWarning($"[DEBUG] after:  rb.position = {rb.position}");
            Log.LogMessage($"[FixedUpdate] Kyouko position correction: offset={positionOffset.magnitude:F4}, velocity={actualCurrectVelocity.magnitude:F4}");
        }
    }

    public CharacterConditionComponent GetCharacterComponent()
    {
        var characters = DayScene.DaySceneMap.allCharacters;
        if (characters == null)
        {
            Log.LogMessage("allCharacters 为空");
            return null;
        }

        if (!characters.ContainsKey(KYOUKO_ID))
        {
            Log.LogMessage($"未找到 ID 为 '{KYOUKO_ID}' 的角色");
            return null;
        }

        var component = characters[KYOUKO_ID];
        if (component == null)
        {
            Log.LogMessage($"角色 '{KYOUKO_ID}' 的 CharacterConditionComponent 为空");
            return null;
        }

        return component;
    }

    public CharacterControllerUnit GetCharacterUnit()
    {
        var component = GetCharacterComponent();
        if (component == null)
        {
            return null;
        }

        var characterUnit = component.Character;
        if (characterUnit == null)
        {
            Log.LogMessage($"角色 '{KYOUKO_ID}' 的 CharacterControllerUnit 为空");
            return null;
        }

        return characterUnit;
    }

    public Rigidbody2D GetRigidbody2D()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return null;
        }

        var rb = characterUnit.rb2d;
        if (rb == null)
        {
            Log.LogMessage($"角色 '{KYOUKO_ID}' 的 Rigidbody2D 为空");
            return null;
        }

        return rb;
    }

    public Vector2 GetPosition()
    {
        var rb = GetRigidbody2D();
        return rb?.position ?? Vector2.zero;
    }

    public bool SetPosition(float x, float y)
    {
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            return false;
        }
        rb.position = new Vector2(x, y);
        Log.LogMessage($"已设置 Kyouko 位置到 ({x}, {y})");
        return true;
    }

    public bool GetMoving()
    {
        var characterUnit = GetCharacterUnit();
        return characterUnit.IsMoving;
    }

    public bool SetMoving(bool isMoving)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return false;
        }
        characterUnit.IsMoving = isMoving;
        Log.LogMessage($"已设置 Kyouko 移动状态为 {isMoving}");
        return true;
    }

    public GameObject GetGameObject()
    {
        var component = GetCharacterComponent();
        return component?.gameObject;
    }

    public void UpdateInputDirection(Vector2 inputDirection, Vector2 syncPosition)
    {
        if (!IsKyoukoVisible)
        {
            Log.LogWarning("Cannot set input direction: Kyouko is not visible");
            return;
        }

        var characterUnit = GetCharacterUnit();
        
        characterUnit.UpdateInputVelocity(inputDirection);
        characterUnit.IsMoving = inputDirection.magnitude > 0;
        Log.LogMessage($"Update input direction: ({inputDirection.x}, {inputDirection.y})");

        positionOffset = syncPosition - characterUnit.rb2d.position;
        expectedCurrectVelocity = positionOffset / currectCoefficient / Time.fixedDeltaTime;
    }

    public void UpdateSprintState(bool isSprinting, Vector2 syncPosition)
    {
        if (!IsKyoukoVisible)
        {
            Log.LogWarning("Cannot set input direction: Kyouko is not visible");
            return;
        }

        var characterUnit = GetCharacterUnit();

        characterUnit.sprintMultiplier = isSprinting ? 1.5f : 1.0f;
        Log.LogMessage($"Update sprint state: {isSprinting}");

        positionOffset = syncPosition - characterUnit.rb2d.position;
        expectedCurrectVelocity = positionOffset / currectCoefficient / Time.fixedDeltaTime;
    }

    public float GetMoveSpeed()
    {
        var characterUnit = GetCharacterUnit();
        return characterUnit.MoveSpeedMultiplier;
    }

    public bool SetMoveSpeed(float speed)
    {
        var characterUnit = GetCharacterUnit();

        characterUnit.MoveSpeedMultiplier = speed;
        Log.LogInfo($"Kyouko move speed set to {speed}");
        return true;
    }

    public Vector3 GetInputDirection()
    {
        var characterUnit = GetCharacterUnit();
        return characterUnit?.inputDirection ?? Vector2.zero;
    }

    public bool SetInputDirection(float x, float y, float z = 0)
    {
        if (!IsKyoukoVisible)
        {
            Log.LogWarning("Cannot set input direction: Kyouko is not visible");
            return false;
        }

        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning("Failed to get CharacterControllerUnit for Kyouko");
            return false;
        }

        characterUnit.inputDirection = new Vector3(x, y, z);
        Log.LogInfo($"Kyouko input direction set to ({x}, {y}, {z})");
        return true;
    }

    public void UpdateMapLabel(string mapLabel)
    {
        MapLabel = mapLabel;
        
        Log.LogMessage($"Updated Kyouko map label to '{mapLabel}'");

        UpdateVisibility();
    }

    public void UpdateVisibility()
    {
        var newVisibility = MapLabel == MystiaManager.MapLabel;
        if (newVisibility == IsKyoukoVisible)
        {
            return;
        }
        IsKyoukoVisible = newVisibility;
        Log.LogMessage($"Kyouko visibility updated to {IsKyoukoVisible} (Kyouko map: '{MapLabel}', Mystia map: '{MystiaManager.MapLabel}')");

        if (IsKyoukoVisible)
        {
            return;
        }
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            return;
        }
        
        rb.position += new Vector2(114514, 114514);
    }
}

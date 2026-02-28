using UnityEngine;

using Common.CharacterUtility;

namespace MetaMystia;

/// <summary>
/// 管理与本地玩家角色相关的状态和数据
/// </summary>
[AutoLog]
public static partial class MystiaManager
{
    private static DayScene.Input.DayScenePlayerInputGenerator _cachedInputGenerator;
    public static string MapLabel { get; set; } = "";
    public static bool IsSprinting { get; set; } = false;
    public static Vector2 InputDirection { get; set; } = Vector2.zero;

    public static bool CharacterSpawnedAndInitialized => Common.SceneDirector.instance.characterCollection.ContainsKey("Self");

    public static bool IsDayOver = false;
    public static bool IsPrepOver = false;
    public static Vector2 Position => GetRigidbody2D()?.position ?? Vector2.zero;

    public static void Initialize()
    {
        Log.LogInfo($"MystiaManager initialized");

        _cachedInputGenerator = null;
        MapLabel = "";
        IsSprinting = false;
        InputDirection = Vector2.zero;
        IsDayOver = false;
        IsPrepOver = false;
    }

    /// <summary>
    /// 获取玩家角色的CharacterControllerUnit实例
    /// 注: 可能在角色生成但未完全初始化时返回null, 调用方需做好空值检查
    /// </summary>
    /// <returns>玩家角色的CharacterControllerUnit实例, 如果未找到则返回null</returns>
    public static CharacterControllerUnit GetCharacterUnit()
    {
        if (Common.SceneDirector.instance == null)
        {
            Log.LogWarning($"SceneDirector instance is null");
            return null;
        }
        if (Common.SceneDirector.Instance.characterCollection.TryGetValue("Self", out var characterUnit))
        {
            return characterUnit;
        }
        Log.LogWarning($"Cannot find character unit for 'Self'");
        return null;
    }

    private static Rigidbody2D GetRigidbody2D(bool forceRefresh = false)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"GetCharacterUnit returned null");
            return null;
        }
        return characterUnit.rb2d;
    }
}

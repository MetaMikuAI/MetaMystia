using Common.CharacterUtility;
using DayScene.Interactables.Collections.ConditionComponents;
using GameData.RunTime.DaySceneUtility;
using Il2CppSystem.Collections.Generic;
using UnityEngine;


namespace MetaMystia;

[AutoLog]
public static partial class KyoukoManager
{
    public static readonly string KYOUKO_ID = "Kyouko";

    public static string MapLabel { get; private set; }

    private static Vector2 actualVelocity;
    private static Vector2 positionOffset;
    private static Vector2 currectVelocity;

    public static bool IsReady = false;

    public static string IzakayaMapLabel = "";
    public static int IzakayaLevel = 0;

    private static bool FirstSync = true;

    public static bool GetIgnoreCollision()
    {
        var character = GetCharacterUnit();
        if (character == null)
        {
            return true;
        }
        var self = Common.SceneDirector.Instance?.characterCollection["Self"];
        if (self == null)
        {
            return true;
        }
        if (character.cl2d == null || self.cl2d == null)
        {
            return true;
        }
        return Physics2D.GetIgnoreCollision(character.cl2d, self.cl2d);
    }

    public static void Initialize()
    {
        MapLabel = "";
        actualVelocity = Vector2.zero;
        positionOffset = Vector2.zero;
        currectVelocity = Vector2.zero;
        IsReady = false;
        FirstSync = true;
        IzakayaMapLabel = "";
        IzakayaLevel = 0;
        Log.LogMessage($"KyoukoManager initialized");
    }

    public static void OnFixedUpdate()
    {
        if (!MpManager.IsConnected || MpManager.InStory)
        {
            return;
        }

        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return;
        }
        // 在每个 FixedUpdate 执行位置修正
        
        // if (positionOffset.magnitude > 0.001f)
        // {
        //     return;
        // }

        // 推测经验公式，数据可能有误：位移(px) = 速度(px/s) * 时间 * 速度倍率(目测5) * 奔跑倍率(1 or 1.5)
        // 实际速度由对端 Kyouko 同步而来
        // 修正速度要保证在「一定时间内」完成位置修正
        // 这里使用较为取巧的方法，使用比较好实现的指数衰减模型（线性还要保存历史数据）
        currectVelocity = positionOffset / 0.5f / 5f;
        positionOffset -= currectVelocity * Time.fixedDeltaTime * 5f * characterUnit.sprintMultiplier;

        // 这样假设位置偏差为 3px, dt = 0.02s
        // currectVelocity = 3 / 0.5 / 5 = 1.2 px/s
        // 位置偏差每帧减少 0.02s * 1.2 px/s * 5 = 0.12 px
        // 每帧修正 0.12px / 3px = 4%
        // 25 帧修正为 96% ^ 25 = 36%
        // 50 帧修正为 96% ^ 50 = 13%
        // 100 帧修正为 96% ^ 100 = 1.7%

        // 由于数据可能有误差，实际计算结果会有不同，但是都是指数衰减的趋势，实测观感还好
        // https://www.bilibili.com/video/av115571395922890?p=3

        // 每 Fixed Frame 都要根据 actualVelocity + currectVelocity 设置实际速度
        var velocity = actualVelocity + currectVelocity;
        if (velocity.magnitude < 0.01f)
        {
            SetMoving(false);
            SetMoveSpeed(1.48f); // 原版 Kyouko 默认速度为 1, Mysita 默认为 1.48
            return;
        }
        SetMoving(true);
        characterUnit.UpdateInputVelocity(velocity);
        if (PluginManager.CurrentGameScene == Common.UI.Scene.DayScene)
        {  
            var trackedNPC = RunTimeDayScene.GetTrackedNPC(KYOUKO_ID);
            var position = characterUnit.rb2d.position;
            trackedNPC?.overridePosition?.position = new KeyValuePair<float, float>( 
                position.x,
                position.y
            ); // TODO: 也许有更优雅的方式？
        }
    }

    public static CharacterControllerUnit GetCharacterUnit()
    {
        switch (MpManager.LocalScene)
        {
            case Common.UI.Scene.DayScene:
                return DayScene.DaySceneMap.TryGetCharacter(KYOUKO_ID)?.Character;        
            case Common.UI.Scene.WorkScene:
                if (!Common.SceneDirector.Instance.characterCollection.ContainsKey(KYOUKO_ID))
                {
                    Log.LogWarning($"Character '{KYOUKO_ID}' not found in character collection, try respawn..");
                    SgrYuki.Utils.CommandScheduler.Enqueue(
                        executeWhen: () => MystiaManager.CharacterSpawnedAndInitialized,
                        executeInfo: $"respawn night kyouko",
                        execute: () => SpawnNightKyouko(MystiaManager.GetPosition(), true, true)
                    );
                    return null;
                }
                return Common.SceneDirector.Instance.characterCollection[KYOUKO_ID];
            default:
                Log.LogWarning($"GetCharacterComponent called in invalid scene");
                return null;
        }
    }

    public static CharacterConditionComponent GetCharacterComponent()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return null;
        }
        var component = characterUnit.GetComponent<CharacterConditionComponent>();
        if (component == null)
        {
            Log.LogWarning($"CharacterConditionComponent of '{KYOUKO_ID}' is null");
            return null;
        }

        return component;
    }

    public static Rigidbody2D GetRigidbody2D()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return null;
        }

        var rb = characterUnit.rb2d;
        if (rb == null)
        {
            Log.LogWarning($"Rigidbody2D of '{KYOUKO_ID}' is null");
            return null;
        }

        return rb;
    }

    public static void SetMoving(bool isMoving)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return;
        }
        if (characterUnit.IsMoving != isMoving)
        {
            characterUnit.IsMoving = isMoving;
            Log.LogDebug($"Kyouko moving state set to {isMoving}");
        }
        return;
    }

    public static void UpdateInputDirection(Vector2 inputDirection)
    {
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            Log.Debug($"Failed to get Rigidbody2D for Kyouko");
            return;
        }
        actualVelocity = inputDirection;

        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.Debug($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        
        // characterUnit.UpdateInputVelocity(inputDirection);
        // 速度设置已由 OnFixedUpdate 负责
        actualVelocity = inputDirection;
        characterUnit.IsMoving = inputDirection.magnitude > 0;
        Log.LogDebug($"Update input direction: ({inputDirection.x}, {inputDirection.y})");
    }

    public static void UpdateSprintState(bool isSprinting)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.Debug($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        characterUnit.sprintMultiplier = isSprinting ? 1.5f : 1.0f;
        Log.LogDebug($"Update sprint state: {isSprinting}");
    }

    public static void UpdateOffsetPosition(Vector2 syncPosition)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.Debug($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        positionOffset = syncPosition - characterUnit.rb2d.position;

        if (positionOffset.magnitude > 3.0f) // 偏差距离超过 3 直接传送
        {
            Log.Info($"Position offset too large ({positionOffset.magnitude}), teleporting Kyouko to sync position");
            GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter(KYOUKO_ID, MapLabel, syncPosition, 0, out var oldNPCData);
            GetCharacterUnit().rb2d.position = syncPosition;
            positionOffset = Vector2.zero;
        }

    }
    public static void SetMoveSpeed(float speed)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        if (characterUnit.MoveSpeedMultiplier == speed)
        {
            return;
        }
        characterUnit.MoveSpeedMultiplier = speed;
        Log.LogDebug($"Kyouko move speed set to {speed}");
    }

    public static void SyncFromPeer(string mapLabel, bool isSprinting, Vector2 inputDirection, Vector2 position)
    {
        if (FirstSync)
        {
            GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter(KYOUKO_ID, mapLabel, position, 0, out var oldNPCData);
            PluginManager.Instance.RunOnMainThread(() =>
            {
                TryAddHeightProcessor();
                IgnoreCollisionWithSelf();
            });
            FirstSync = false;
            Log.LogWarning($"First sync received, added HeightProcessor to Kyouko");
        }

        /*
            MetaMiku 注
                UpdateInputDirection 被触发时会触发更新，每个同步包会同步 mapLabel, isSprinting, 速度, 位置
                如果 Kyouko 不在当前地图，则需更新 MapLabel 和 位置；直接更新 velocity 和 isSprinting 即可，无需进行位置修正
                如果 Kyouko 在当前地图，更新 velocity, isSprinting，并进行位置修正
        */
        Log.LogDebug($"SyncFromPeer, old MapLabel: {MapLabel}, new MapLabel: {mapLabel}, isSprinting: {isSprinting}, inputDirection: ({inputDirection.x}, {inputDirection.y}), position: ({position.x}, {position.y})");
        if (mapLabel != MapLabel)
        {
            Log.LogMessage($"Kyouko map changed from {MapLabel} to {mapLabel}, teleporting to new position");
            MapLabel = mapLabel;
            GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter(KYOUKO_ID, mapLabel, position, 0, out var oldNPCData);
            TryAddHeightProcessor();
            UpdateInputDirection(inputDirection);
            UpdateSprintState(isSprinting);
            SyncAction.Send();
        }
        else 
        {
            Log.LogDebug($"Kyouko is still in the same map {MapLabel}, updating position");
            UpdateInputDirection(inputDirection);
            UpdateSprintState(isSprinting);
            UpdateOffsetPosition(position);
        }
    }

    
    public static void NightSyncFromPeer(Vector2 inputDirection, Vector2 position)
    {
        Log.LogDebug($"NightSyncFromPeer, inputDirection: ({inputDirection.x}, {inputDirection.y}), position: ({position.x}, {position.y})");

        UpdateInputDirection(inputDirection);
        UpdateOffsetPosition(position);
    }

    public static void SpawnNightKyouko(Vector2 position, bool enableHeightProcessor = true, bool ignoreCollisionWithSelf = true)
    {
        if (Common.SceneDirector.Instance.characterCollection.ContainsKey(KYOUKO_ID) || MpManager.InStory)
        {
            Log.LogWarning($"NightKyouko already exists or in story, skip spawning");
            return;
        }
        Common.SceneDirector.Instance.SpawnCharacter(Common.SceneDirector.Identity.Special, 14, position, KYOUKO_ID);
        Log.LogWarning($"Spawned NightKyouko for testing");
        if (enableHeightProcessor)
        {
            TryAddHeightProcessor();
        }
        IgnoreCollisionWithSelf(ignoreCollisionWithSelf);
    }

    public static void TryAddHeightProcessor()
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }

        HeightBlendedInputProcessorComponent heightProcessor;
        if (characterUnit.GetComponent<HeightBlendedInputProcessorComponent>() != null)
        {
            TryInitHeightMap();
            Log.LogWarning($"Kyouko already has HeightBlendedInputProcessorComponent");
            return;
        }

        heightProcessor = characterUnit.AddInputProcessor<HeightBlendedInputProcessorComponent>();
        
        // var selfUnit = Common.SceneDirector.Instance.characterCollection["Self"];
        // var selfHeightProcessor = selfUnit.gameObject.GetComponent<Common.CharacterUtility.HeightBlendedInputProcessorComponent>();
        // heightProcessor.Initialize(selfHeightProcessor.heightMap);
        
        TryInitHeightMap();

        Log.LogInfo($"Added HeightBlendedInputProcessorComponent to NightKyouko");
    }

    private static void TryInitHeightMap()
    {
        var heightProcessor = GetCharacterUnit()?.GetComponent<HeightBlendedInputProcessorComponent>();
        if (heightProcessor == null)
        {
            Log.LogWarning($"HeightBlendedInputProcessorComponent of '{KYOUKO_ID}' is null");
            return;
        }

        switch (MpManager.LocalScene)
        {
            case Common.UI.Scene.DayScene:
                heightProcessor.Initialize(DayScene.SceneManager.Instance.CurrentActiveMap.height);
                break;
            case Common.UI.Scene.WorkScene:
                heightProcessor.Initialize(NightScene.MapManager.Instance.height);
                break;
            default:
                Log.LogInfo($"TryInitHeightMap called in invalid scene");
                break;
        }
    }

    public static void IgnoreCollisionWithSelf(bool ignore = true)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        Physics2D.IgnoreCollision(
            characterUnit.cl2d,
            Common.SceneDirector.Instance.characterCollection["Self"].cl2d,
            ignore);
        Log.LogInfo($"IgnoreCollisionWithSelf set to {ignore}");
    }
}

using BepInEx.Logging;
using UnityEngine;
using Common.CharacterUtility;
using DayScene.Interactables.Collections.ConditionComponents;

namespace MetaMystia;

public class KyoukoManager
{
    public static bool enable = false; // 该开关应随游戏白天场景加载和卸载而变化，避免在非 DayScene 场景中持续执行 OnFixedUpdate
    private static KyoukoManager _instance;
    private static readonly object _lock = new object();
    
    public const string KYOUKO_ID = "Kyouko";
    private static ManualLogSource Log => Plugin.Instance.Log;

    public static string MapLabel { get; private set; }

    private static Vector2 actualVelocity;
    private static Vector2 positionOffset;
    private static Vector2 currectVelocity;

    public static bool isReady = false;

    public static string IzakayaMapLabel = "";
    public static int IzakayaLevel = 0;

    private static readonly string LOG_TAG = "[KyoukoManager.cs]";

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
        if (!enable)
        {
            return;
        }

        if (!MpManager.Instance.IsConnected)
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
    }

    public static CharacterConditionComponent GetCharacterComponent()
    {
        return DayScene.DaySceneMap.TryGetCharacter(KYOUKO_ID);
    }

    public static CharacterControllerUnit GetCharacterUnit()
    {
        var component = GetCharacterComponent();
        if (component == null)
        {
            return null;
        }

        var characterUnit = component.Character;
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} CharacterControllerUnit of '{KYOUKO_ID}' is null");
            return null;
        }

        return characterUnit;
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
            Log.LogWarning($"{LOG_TAG} Rigidbody2D of '{KYOUKO_ID}' is null");
            return null;
        }

        return rb;
    }

    public Vector2 GetPosition()
    {
        var rb = GetRigidbody2D();
        return rb?.position ?? Vector2.zero;
    }

    public void MoveTo(string label, float x, float y)
    {
        if (MapLabel.Equals(label))
        {
            var arr = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<Vector2>(1);
            arr[0] = new Vector2(x, y);
            Common.SceneDirector.Instance.MoveCharacter(KYOUKO_ID, arr, 1.48f, new System.Action(() => {Log.LogMessage("MoveTo Called");}));
        }
    }


    public void SetMoving(bool isMoving)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            return;
        }
        if (characterUnit.IsMoving != isMoving)
        {
            characterUnit.IsMoving = isMoving;
            Log.LogDebug($"{LOG_TAG} Kyouko moving state set to {isMoving}");
        }
        return;
    }

    public void UpdateInputDirection(Vector2 inputDirection)
    {
        var rb = GetRigidbody2D();
        if (rb == null)
        {
            Log.LogWarning($"{LOG_TAG} Failed to get Rigidbody2D for Kyouko");
            return;
        }
        actualVelocity = inputDirection;

        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        
        // characterUnit.UpdateInputVelocity(inputDirection);
        // 速度设置已由 OnFixedUpdate 负责
        actualVelocity = inputDirection;
        characterUnit.IsMoving = inputDirection.magnitude > 0;
        Log.LogDebug($"{LOG_TAG} Update input direction: ({inputDirection.x}, {inputDirection.y})");
    }

    public void UpdateSprintState(bool isSprinting)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        characterUnit.sprintMultiplier = isSprinting ? 1.5f : 1.0f;
        Log.LogDebug($"{LOG_TAG} Update sprint state: {isSprinting}");
    }

    public void UpdateOffsetPosition(Vector2 syncPosition)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        positionOffset = syncPosition - characterUnit.rb2d.position;

        if (positionOffset.magnitude > 3.0f) // 偏差距离超过 3 直接传送
        {
            Log.LogMessage($"{LOG_TAG} Position offset too large ({positionOffset.magnitude}), teleporting Kyouko to sync position");
            GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter("Kyouko", MapLabel, syncPosition, 0, out var oldNPCData);
            positionOffset = Vector2.zero;    
        }

    }
    public void SetMoveSpeed(float speed)
    {
        var characterUnit = GetCharacterUnit();
        if (characterUnit == null)
        {
            Log.LogWarning($"{LOG_TAG} Failed to get CharacterControllerUnit for Kyouko");
            return;
        }
        if (characterUnit.MoveSpeedMultiplier == speed)
        {
            return;
        }
        characterUnit.MoveSpeedMultiplier = speed;
        Log.LogDebug($"{LOG_TAG} Kyouko move speed set to {speed}");
    }
    public void SyncFromPeer(string mapLabel, bool isSprinting, Vector2 inputDirection, Vector2 position)
    {
        /*
            MetaMiku 注
                UpdateInputDirection 被触发时会触发更新，每个同步包会同步 mapLabel, isSprinting, 速度, 位置
                如果 Kyouko 不在当前地图，则需更新 MapLabel 和 位置；直接更新 velocity 和 isSprinting 即可，无需进行位置修正
                如果 Kyouko 在当前地图，更新 velocity, isSprinting，并进行位置修正
        */
        Log.LogDebug($"{LOG_TAG} SyncFromPeer, old MapLabel: {MapLabel}, new MapLabel: {mapLabel}, isSprinting: {isSprinting}, inputDirection: ({inputDirection.x}, {inputDirection.y}), position: ({position.x}, {position.y})");
        if (mapLabel != MapLabel)
        {
            Log.LogMessage($"{LOG_TAG} Kyouko map changed from {MapLabel} to {mapLabel}, teleporting to new position");
            MapLabel = mapLabel;
            GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter("Kyouko", mapLabel, position, 0, out var oldNPCData);
            UpdateInputDirection(inputDirection);
            UpdateSprintState(isSprinting);
            MpManager.Instance.SendSync();
        }
        else 
        {
            Log.LogDebug($"{LOG_TAG} Kyouko is still in the same map {MapLabel}, updating position");
            UpdateInputDirection(inputDirection);
            UpdateSprintState(isSprinting);
            UpdateOffsetPosition(position);
        }
    }
}

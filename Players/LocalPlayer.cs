using UnityEngine;

using Common.CharacterUtility;
using JetBrains.Annotations;

namespace MetaMystia;

/// <summary>
/// 本地玩家，管理与本地操控角色相关的状态
/// </summary>
[AutoLog]
public partial class LocalPlayer : NetPlayer
{
    public bool CharacterSpawnedAndInitialized =>
        Common.SceneDirector.instance.characterCollection.ContainsKey("Self");

    public override CharacterControllerUnit GetCharacterUnit()
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

    /// <summary>
    /// 本地玩家速度直接读取 unit.MoveSpeedMultiplier
    /// </summary>
    public override float Speed
    {
        get => unit?.MoveSpeedMultiplier ?? 1f;
        set { if (unit != null) unit.MoveSpeedMultiplier = value; }
    }

    public override void ResetState()
    {
        base.ResetState();
        Log.LogInfo($"LocalPlayer state reset");
    }

    /// <summary>
    /// 当前地图标签，从 SceneDirector 读取。
    /// 设置时同步更新所有 Peer 的可见状态。
    /// </summary>
    public static new string MapLabel
    {
        get => Common.SceneDirector.Instance.currentActiveScene.Key;
        set
        {
            MapLabel = value;
            foreach (var peer in PlayerManager.Peers.Values)
                peer.UpdateVisibleState();
        }
    }
}

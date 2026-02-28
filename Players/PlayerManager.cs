using System;
using System.Collections.Concurrent;
using System.Linq;
using UnityEngine;

using Common.CharacterUtility;
using DayScene.Interactables.Collections.ConditionComponents;

namespace MetaMystia;

/// <summary>
/// 统一管理本地玩家和所有远程对端玩家
/// </summary>
[AutoLog]
public static partial class PlayerManager
{
    /// <summary>
    /// 本地玩家实例
    /// </summary>
    public static LocalPlayer Local { get; } = new();

    /// <summary>
    /// 所有已连接的远程玩家
    /// </summary>
    public static ConcurrentDictionary<Guid, PeerPlayer> Peers { get; } = new();

    /// <summary>
    /// 当前对端玩家（1v1 便捷访问，返回第一个 Peer）
    /// 多人场景下，调用方应遍历 Peers 集合
    /// </summary>
    public static PeerPlayer Peer => Peers.Values.FirstOrDefault();

    #region Local 便捷属性

    public static string LocalMapLabel => LocalPlayer.MapLabel;
    public static bool LocalIsSprinting { get => Local.IsSprinting; set => Local.IsSprinting = value; }
    public static Vector2 LocalInputDirection { get => Local.InputDirection; set => Local.InputDirection = value; }
    public static bool CharacterSpawnedAndInitialized => Local.CharacterSpawnedAndInitialized;
    public static bool LocalIsDayOver { get => Local.IsDayOver; set => Local.IsDayOver = value; }
    public static bool LocalIsPrepOver { get => Local.IsPrepOver; set => Local.IsPrepOver = value; }
    public static Vector2 LocalPosition => Local.Position;

    #endregion

    #region Peer 聚合属性

    /// <summary>
    /// 所有对端是否都已完成 Day（聚合判断）
    /// 设置时作用于 Peer（1v1 兼容）
    /// </summary>
    public static bool PeerIsDayOver
    {
        get => Peers.Count > 0 && Peers.Values.All(p => p.IsDayOver);
        set { if (Peer != null) Peer.IsDayOver = value; }
    }

    /// <summary>
    /// 所有对端是否都已完成 Prep（聚合判断）
    /// 设置时作用于 Peer（1v1 兼容）
    /// </summary>
    public static bool PeerIsPrepOver
    {
        get => Peers.Count > 0 && Peers.Values.All(p => p.IsPrepOver);
        set { if (Peer != null) Peer.IsPrepOver = value; }
    }

    public static string PeerIzakayaMapLabel
    {
        get => Peer?.IzakayaMapLabel ?? "";
        set { if (Peer != null) Peer.IzakayaMapLabel = value; }
    }

    public static int PeerIzakayaLevel
    {
        get => Peer?.IzakayaLevel ?? 0;
        set { if (Peer != null) Peer.IzakayaLevel = value; }
    }

    #endregion

    #region 资源可用性聚合判断（所有玩家都拥有该资源才视为可用）

    public static bool FoodAvailable(int id) =>
        Local.DataBase.FoodAvailable(id) && Peers.Values.All(p => p.DataBase.FoodAvailable(id));

    public static bool RecipeAvailable(int id) =>
        Local.DataBase.RecipeAvailable(id) && Peers.Values.All(p => p.DataBase.RecipeAvailable(id));

    public static bool BeverageAvailable(int id) =>
        Local.DataBase.BeverageAvailable(id) && Peers.Values.All(p => p.DataBase.BeverageAvailable(id));

    public static bool IngredientAvailable(int id) =>
        Local.DataBase.IngredientAvailable(id) && Peers.Values.All(p => p.DataBase.IngredientAvailable(id));

    public static bool CookerAvailable(int id) =>
        Local.DataBase.CookerAvailable(id) && Peers.Values.All(p => p.DataBase.CookerAvailable(id));

    public static bool ItemAvailable(int id) =>
        Local.DataBase.ItemAvailable(id) && Peers.Values.All(p => p.DataBase.ItemAvailable(id));

    public static bool IzakayaAvailable(int id) =>
        Local.DataBase.IzakayaAvailable(id) && Peers.Values.All(p => p.DataBase.IzakayaAvailable(id));

    public static bool NormalGuestAvailable(int id) =>
        Local.DataBase.NormalGuestAvailable(id) && Peers.Values.All(p => p.DataBase.NormalGuestAvailable(id));

    public static bool SpecialGuestAvailable(int id) =>
        Local.DataBase.SpecialGuestAvailable(id) && Peers.Values.All(p => p.DataBase.SpecialGuestAvailable(id));

    #endregion

    #region 生命周期

    /// <summary>
    /// 初始化玩家管理器，包括全部 peer 的运动状态初始化和角色生成
    /// </summary>
    public static void Initialize()
    {
        Local.Initialize();
        foreach (var peer in Peers.Values)
        {
            peer.Initialize();
            peer.SpawnForScene();
        }
        Log.LogInfo($"PlayerManager initialized (peers kept: {Peers.Count})");
    }

    /// <summary>
    /// 握手成功后，根据对端 Guid 创建并注册 PeerPlayer
    /// </summary>
    public static PeerPlayer AddPeer(Guid guid, string peerId, ResourceDataBase resourceDataBase = null)
    {
        if (Peers.TryGetValue(guid, out var existing))
        {
            Log.LogWarning($"Peer with guid {guid} already exists (id='{existing.Id}'), replacing");
        }
        var peer = new PeerPlayer(guid, resourceDataBase) { Id = peerId };
        peer.Initialize();
        Peers[guid] = peer;
        Log.LogMessage($"Added peer '{peerId}' (guid={guid}, characterId='{peer.CharacterId}')");
        return peer;
    }

    /// <summary>
    /// 移除一个对端玩家
    /// </summary>
    public static bool RemovePeer(Guid guid)
    {
        if (Peers.TryRemove(guid, out var peer))
        {
            Log.LogMessage($"Removed peer '{peer.Id}' (guid={guid})");
            return true;
        }
        return false;
    }

    /// <summary>
    /// 清除所有对端玩家（断开连接时调用）
    /// </summary>
    public static void ClearPeers()
    {
        Peers.Clear();
        Log.LogMessage($"All peers cleared");
    }

    #endregion

    #region FixedUpdate

    /// <summary>
    /// 在 FixedUpdate 中为所有 Peer 执行位置修正
    /// </summary>
    public static void OnFixedUpdate()
    {
        foreach (var peer in Peers.Values)
        {
            peer.OnFixedUpdate();
        }
    }

    #endregion

    #region Peer 静态便捷方法（1v1 兼容，委托给 Peer）

    [OnMainThread]
    public static void EnablePeerCollision(CharacterControllerUnit unit, bool enable = true)
    {
        unit?.UpdateColliderStatus(enable);
        if (unit?.rb2d != null)
            unit.rb2d.isKinematic = !enable;
        Log.Info($"set collision for {unit?.name} to {enable}");
    }

    [OnMainThread]
    public static void EnablePeerCollision(bool enable = true) =>
        EnablePeerCollision(Peer?.GetCharacterUnit(), enable);

    public static bool IsPeerCharacter(string label) =>
        Peers.Values.Any(p => p.Guid.ToString() == label);

    #endregion
}

using System;
using System.Collections.Generic;

using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;

using MetaMystia.Network;
using SgrYuki;

namespace MetaMystia;

/// <summary>
/// 皮肤覆盖管理器。支持两种皮肤来源：
/// 1. Mystia 自身皮肤 (SelfSpriteSet)：Default / Explicit / DLC
/// 2. NPC 皮肤 (DataBaseDay.allNPCs)：通过 NPC 名称获取 GetVisual()
///
/// 皮肤状态的唯一来源是 NetPlayer.Skin（nullable）。
/// Local.Skin != null 即启用，null 即关闭。
/// Peer 同理，PostSpawnSetup 时从自身 Skin 字段读取并应用。
/// </summary>
[AutoLog]
public static partial class SkinManager
{
    public enum SkinSource
    {
        /// <summary>Mystia 的 SelfSpriteSet（Default/Explicit/DLC）</summary>
        Mystia,
        /// <summary>来自 DataBaseDay.allNPCs 的 NPC 精灵图</summary>
        NPC
    }

    public struct SkinSelection
    {
        public SkinSource Source;
        public CharacterSkinSets.SelectedType MystiaType;
        public int MystiaIndex;
        public string NpcName;

        public override readonly string ToString()
        {
            return Source == SkinSource.Mystia
                ? $"Mystia/{MystiaType}/{MystiaIndex}"
                : $"NPC/{NpcName}";
        }
    }

    /// <summary>
    /// 本地皮肤覆盖是否启用
    /// </summary>
    public static bool IsEnabled => PlayerManager.Local?.Skin != null;

    /// <summary>
    /// 当前激活的覆盖皮肤（仅在 IsEnabled 为 true 时安全访问）
    /// </summary>
    public static SkinSelection CurrentSkin => PlayerManager.Local!.Skin!.Value;

    /// <summary>
    /// /skin off 后备份，供 /skin on 恢复
    /// </summary>
    private static SkinSelection? _lastSelection;

    #region 本地皮肤设置

    /// <summary>
    /// 设置 Local.Skin 并应用到本地角色 + 广播到网络
    /// </summary>
    private static void ApplyAndBroadcast(SkinSelection skin)
    {
        PlayerManager.Local.Skin = skin;
        _lastSelection = skin;
        ApplyToLocal();
        if (MpManager.IsConnected)
            SkinChangeAction.Send(skin);
    }

    /// <summary>
    /// /skin on — 重新启用之前选择的皮肤
    /// </summary>
    public static bool Enable()
    {
        if (_lastSelection == null)
        {
            Log.Warning("No skin was previously selected");
            return false;
        }
        ApplyAndBroadcast(_lastSelection.Value);
        Log.Info($"Skin override enabled: {_lastSelection}");
        return true;
    }

    /// <summary>
    /// /skin off — 关闭覆盖，恢复游戏存档中的皮肤
    /// </summary>
    public static void Disable()
    {
        _lastSelection = PlayerManager.Local?.Skin;
        if (PlayerManager.Local != null) PlayerManager.Local.Skin = null;
        RestoreLocal();
        if (MpManager.IsConnected)
            SkinChangeAction.SendDisable();
        Log.Info("Skin override disabled");
    }

    /// <summary>
    /// /skin set Mystia — 设置 Mystia 皮肤并自动启用
    /// </summary>
    public static bool SetMystiaSkin(CharacterSkinSets.SelectedType type, int index)
    {
        var selfSpriteSet = DataBaseCharacter.SelfSpriteSet;
        if (selfSpriteSet == null)
        {
            Log.Error("SelfSpriteSet is null");
            return false;
        }

        switch (type)
        {
            case CharacterSkinSets.SelectedType.Default:
                break;
            case CharacterSkinSets.SelectedType.Explicit:
                if (index < 0 || index >= selfSpriteSet.explicits.Length)
                {
                    Log.Warning($"Invalid explicit index {index}, max={selfSpriteSet.explicits.Length - 1}");
                    return false;
                }
                break;
            case CharacterSkinSets.SelectedType.DLC:
                if (index < 0 || index >= selfSpriteSet.dlcs.Length)
                {
                    Log.Warning($"Invalid dlc index {index}, max={selfSpriteSet.dlcs.Length - 1}");
                    return false;
                }
                break;
            default:
                return false;
        }

        ApplyAndBroadcast(new SkinSelection
        {
            Source = SkinSource.Mystia,
            MystiaType = type,
            MystiaIndex = index,
        });
        return true;
    }

    /// <summary>
    /// /skin set &lt;npcName&gt; — 设置 NPC 皮肤并自动启用
    /// </summary>
    public static bool SetNpcSkin(string npcName)
    {
        if (!DataBaseDay.allNPCs.ContainsKey(npcName))
        {
            Log.Warning($"NPC '{npcName}' not found in allNPCs");
            return false;
        }

        ApplyAndBroadcast(new SkinSelection
        {
            Source = SkinSource.NPC,
            NpcName = npcName,
        });
        return true;
    }

    #endregion

    #region 皮肤解析

    /// <summary>
    /// 将 SkinSelection 解析为引擎可用的 CharacterSpriteSetCompact
    /// </summary>
    public static CharacterSpriteSetCompact ResolveSkin(SkinSelection skin)
    {
        try
        {
            return skin.Source == SkinSource.Mystia
                ? ResolveMystiaSkin(skin.MystiaType, skin.MystiaIndex)
                : ResolveNpcSkin(skin.NpcName);
        }
        catch (Exception e)
        {
            Log.Error($"Failed to resolve skin {skin}: {e.Message}");
            return null;
        }
    }

    public static CharacterSpriteSetCompact ResolveMystiaSkin(CharacterSkinSets.SelectedType type, int index)
    {
        var selfSpriteSet = DataBaseCharacter.SelfSpriteSet;
        if (selfSpriteSet == null) return null;

        return type switch
        {
            CharacterSkinSets.SelectedType.Default => selfSpriteSet.defaultSkin,
            CharacterSkinSets.SelectedType.Explicit => (index >= 0 && index < selfSpriteSet.explicits.Length)
                ? selfSpriteSet.explicits[index] : selfSpriteSet.defaultSkin,
            CharacterSkinSets.SelectedType.DLC => (index >= 0 && index < selfSpriteSet.dlcs.Length)
                ? selfSpriteSet.dlcs[index] : selfSpriteSet.defaultSkin,
            _ => selfSpriteSet.defaultSkin
        };
    }

    public static CharacterSpriteSetCompact ResolveNpcSkin(string npcName)
    {
        if (string.IsNullOrEmpty(npcName)) return null;
        if (DataBaseDay.allNPCs.ContainsKey(npcName))
            return DataBaseDay.allNPCs[npcName].GetVisual();
        Log.Warning($"NPC '{npcName}' not found");
        return null;
    }

    #endregion

    #region 皮肤应用

    /// <summary>
    /// 将 Local.Skin 应用到本地角色（"Self"）
    /// </summary>
    public static void ApplyToLocal()
    {
        var skin = PlayerManager.Local?.Skin;
        if (skin == null) return;
        var compact = ResolveSkin(skin.Value);
        if (compact != null)
            ApplyToUnit("Self", compact);
    }

    /// <summary>
    /// 恢复本地角色为游戏存档中的皮肤
    /// </summary>
    public static void RestoreLocal()
    {
        var currentSkinInfo = RunTimeAlbum.PlayerSkinSet();
        var compact = ResolveMystiaSkin(currentSkinInfo.selectedType, currentSkinInfo.index);
        if (compact != null)
            ApplyToUnit("Self", compact);
    }

    /// <summary>
    /// 将皮肤应用到指定 characterKey 对应的角色单元
    /// </summary>
    public static void ApplyToUnit(string characterKey, CharacterSpriteSetCompact compact)
    {
        if (compact == null) return;
        if (Common.SceneDirector.Instance?.characterCollection?.TryGetValue(characterKey, out var unit) ?? false)
        {
            unit.UpdateCharacterSprite(compact);
            Log.Info($"Applied skin to '{characterKey}': {compact.name}");
        }
    }

    /// <summary>
    /// 收到远程皮肤变更：写入 peer.Skin 并尝试立即应用。
    /// 若 unit 不存在，PostSpawnSetup 会在 spawn 后从 peer.Skin 补应用。
    /// </summary>
    public static void ApplyToPeer(int senderUid, SkinSelection skin)
    {
        if (!PlayerManager.Peers.TryGetValue(senderUid, out var peer)) return;
        peer.Skin = skin;
        var compact = ResolveSkin(skin);
        if (compact != null)
            ApplyToUnit(peer.CharacterId, compact);
    }

    /// <summary>
    /// 清除 Peer 的皮肤并恢复默认外观。
    /// 当前所有 Peer 使用 CharacterModelId=14 (Kyouko)。
    /// </summary>
    public static void RestorePeer(int senderUid)
    {
        if (!PlayerManager.Peers.TryGetValue(senderUid, out var peer)) return;
        peer.Skin = null;
        // TODO: CharacterModelId 可自定义后，需根据实际 modelId 映射默认皮肤
        var compact = ResolveNpcSkin("Kyouko");
        if (compact != null)
            ApplyToUnit(peer.CharacterId, compact);
    }

    #endregion

    #region 网络 / 场景钩子

    /// <summary>
    /// 新连接建立或新 peer 加入时调用（主机和客机都应调用），
    /// 重新广播本地皮肤让新 peer 也能看到。
    /// </summary>
    public static void OnPeerJoined()
    {
        if (!IsEnabled || !MpManager.IsConnected) return;
        SkinChangeAction.Send(CurrentSkin);
    }

    /// <summary>
    /// 场景切换后重新应用本地皮肤（DayScene / WorkScene 初始化时调用）。
    /// 仅应用本地角色；远程 Peer 的皮肤由 PostSpawnSetup 从 peer.Skin 自动应用，无需再次网络发送。
    /// </summary>
    public static void OnSceneEnter()
    {
        if (!IsEnabled) return;
        CommandScheduler.Enqueue(
            executeWhen: () => PlayerManager.Local.unit != null,
            execute: ApplyToLocal,
            timeoutSeconds: 30
        );
    }

    #endregion

    #region 列举可用皮肤

    public static List<(CharacterSkinSets.SelectedType type, int index, string name)> ListMystiaSkins()
    {
        var result = new List<(CharacterSkinSets.SelectedType, int, string)>();
        var selfSpriteSet = DataBaseCharacter.SelfSpriteSet;
        if (selfSpriteSet == null) return result;

        result.Add((CharacterSkinSets.SelectedType.Default, 0, selfSpriteSet.defaultSkin?.name ?? "default"));
        for (int i = 0; i < selfSpriteSet.explicits.Length; i++)
            result.Add((CharacterSkinSets.SelectedType.Explicit, i, selfSpriteSet.explicits[i]?.name ?? $"explicit_{i}"));
        for (int i = 0; i < selfSpriteSet.dlcs.Length; i++)
            result.Add((CharacterSkinSets.SelectedType.DLC, i, selfSpriteSet.dlcs[i]?.name ?? $"dlc_{i}"));
        return result;
    }

    #endregion
}

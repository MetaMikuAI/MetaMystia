using MemoryPack;

using GameData.Core.Collections.CharacterUtility;

using SgrYuki;

namespace MetaMystia.Network;

/// <summary>
/// 皮肤变更网络同步 Action。
/// 当玩家通过 /skin 命令更改皮肤时，广播给所有其他玩家。
/// </summary>
[MemoryPackable]
[AutoLog]
[Action.HostRelay]
public partial class SkinChangeAction : Action
{
    public override ActionType Type => ActionType.SKIN_CHANGE;

    /// <summary>
    /// 是否启用皮肤覆盖。false = 关闭覆盖，恢复默认外观
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// 皮肤来源：0=Mystia, 1=NPC
    /// </summary>
    public int Source { get; set; }

    /// <summary>
    /// Mystia 模式下的皮肤类型 (Default=0, Explicit=1, DLC=2)
    /// </summary>
    public int MystiaType { get; set; }

    /// <summary>
    /// Mystia 模式下的皮肤索引
    /// </summary>
    public int MystiaIndex { get; set; }

    /// <summary>
    /// NPC 模式下的 NPC 名称
    /// </summary>
    public string NpcName { get; set; }

    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (!Enabled)
            {
                SkinManager.RestorePeer(SenderUid);
                return;
            }

            var skin = new SkinManager.SkinSelection
            {
                Source = (SkinManager.SkinSource)Source,
                MystiaType = (CharacterSkinSets.SelectedType)MystiaType,
                MystiaIndex = MystiaIndex,
                NpcName = NpcName
            };
            SkinManager.ApplyToPeer(SenderUid, skin);
        });
    }

    public static void Send(SkinManager.SkinSelection skin)
    {
        var action = new SkinChangeAction
        {
            Enabled = true,
            Source = (int)skin.Source,
            MystiaType = (int)skin.MystiaType,
            MystiaIndex = skin.MystiaIndex,
            NpcName = skin.NpcName ?? ""
        };
        action.SendToHostOrBroadcast();
    }

    public static void SendDisable()
    {
        var action = new SkinChangeAction
        {
            Enabled = false,
        };
        action.SendToHostOrBroadcast();
    }
}

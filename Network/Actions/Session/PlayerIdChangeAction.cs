using MemoryPack;

using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 所有玩家：通告玩家 ID 变更
/// </summary>
[MemoryPackable]
[HostRelay]
public partial class PlayerIdChangeAction : Action
{
    public override ActionType Type => ActionType.PLAYER_ID_CHANGE;

    public string NewPlayerId { get; private set; }

    public override void OnReceivedDerived()
    {
        if (PlayerManager.Peers.TryGetValue(SenderUid, out var peer))
        {
            var oldId = peer.Id;
            peer.Id = NewPlayerId;
            InGameConsole.ShowPassiveFromAnyThread(TextId.PeerPlayerIdChanged.Get(oldId, NewPlayerId));
            // 更新头顶浮动标签
            FloatingTextHelper.UpdatePlayerLabel(SenderUid, NewPlayerId);
        }
    }

    public static void Send(string newId)
    {
        // 更新本地玩家自己的头顶标签
        PlayerManager.Local.Id = newId;
        FloatingTextHelper.UpdatePlayerLabel(PlayerManager.Local.Uid, newId);
        new PlayerIdChangeAction { NewPlayerId = newId }.SendToHostOrBroadcast();
    }
}

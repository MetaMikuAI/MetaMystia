using MemoryPack;

using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 所有客机：通告玩家离开
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class PeerLeaveAction : Action
{
    public override ActionType Type => ActionType.PEER_LEAVE;
    public int PeerUid { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost) return;

        if (PlayerManager.Peers.TryGetValue(PeerUid, out var peer))
        {
            Notify.ShowOnMainThread(TextId.PeerLeft.Get(peer.Id));
            FloatingTextHelper.RemovePlayerLabel(PeerUid);
            PlayerManager.RemovePeer(PeerUid);
        }
    }

    public static void BroadcastPeerLeave(int leavingUid)
    {
        if (!MpManager.IsHost) return;
        var action = new PeerLeaveAction { PeerUid = leavingUid };
        action.SendToHostOrBroadcast();
    }
}

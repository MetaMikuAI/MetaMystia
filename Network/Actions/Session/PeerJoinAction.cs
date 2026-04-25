using MemoryPack;

using MetaMystia.UI;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 所有客机：通告新玩家加入
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class PeerJoinAction : Action
{
    public override ActionType Type => ActionType.PEER_JOIN;

    public PlayerInfo PeerInfo;

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost) return;

        if (PeerInfo.Uid == PlayerManager.Local.Uid) return;

        if (!PlayerManager.Peers.TryGetValue(PeerInfo.Uid, out var peer))
        {
            peer = PlayerManager.AddPeer(PeerInfo);

            // 如果当前在 DayScene，立即为新 peer 生成角色
            if (MpManager.LocalScene == Common.UI.Scene.DayScene)
            {
                peer.ResetMotion();
                peer.SpawnForScene();
            }
        }
        else
        {
            peer.IsDayOver = PeerInfo.IsDayOver;
            peer.IsPrepOver = PeerInfo.IsPrepOver;
        }
        InGameConsole.ShowPassiveFromAnyThread(TextId.PeerJoined.Get(PeerInfo.PeerId));
    }

    /// <summary>
    /// 主机向除 exceptUid 以外的所有客机广播新玩家加入
    /// </summary>
    public static void BroadcastExcept(int newPeerUid, PlayerInfo peerInfo)
    {
        if (!MpManager.IsHost) return;
        if (PlayerManager.Peers.Count <= 1) return;

        var action = new PeerJoinAction
        {
            PeerInfo = peerInfo
        };
        var packet = NetPacket.FromSingleAction(action);
        MpManager.SendToAllExcept(newPeerUid, packet);
    }
}

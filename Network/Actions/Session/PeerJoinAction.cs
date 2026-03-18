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
    public int PeerUid { get; set; }
    public string PeerId { get; set; } = "";
    public ResourceDataBase PeerDataBase { get; set; }
    public PlayerSkin PeerSkin { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost) return;

        if (PeerUid == PlayerManager.Local.Uid) return;

        if (!PlayerManager.Peers.ContainsKey(PeerUid))
        {
            var peer = PlayerManager.AddPeer(PeerUid, PeerId, PeerDataBase, PeerSkin);

            // 如果当前在 DayScene，立即为新 peer 生成角色
            if (MpManager.LocalScene == Common.UI.Scene.DayScene)
            {
                peer.ResetMotion();
                peer.SpawnForScene();
            }
        }
        Notify.ShowOnMainThread(TextId.PeerJoined.Get(PeerId));
    }

    /// <summary>
    /// 主机向除 exceptUid 以外的所有客机广播新玩家加入
    /// </summary>
    public static void BroadcastExcept(int newPeerUid, string peerId, ResourceDataBase dataBase)
    {
        if (!MpManager.IsHost) return;
        if (PlayerManager.Peers.Count <= 1) return;

        var action = new PeerJoinAction
        {
            PeerUid = newPeerUid,
            PeerId = peerId,
            PeerDataBase = dataBase,
            PeerSkin = PlayerManager.Peers.TryGetValue(newPeerUid, out var p) ? p.Skin : new PlayerSkin()
        };
        var packet = NetPacket.FromSingleAction(action);
        MpManager.SendToAllExcept(newPeerUid, packet);
    }
}

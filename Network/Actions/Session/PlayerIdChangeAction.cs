using MemoryPack;

using MetaMystia.UI;

namespace MetaMystia.Network;

[MemoryPackable]
[Action.HostRelay]
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
            Notify.ShowOnMainThread(TextId.PeerPlayerIdChanged.Get(oldId, NewPlayerId));
        }
    }

    public static void Send(string newId)
    {
        new PlayerIdChangeAction { NewPlayerId = newId }.SendToHostOrBroadcast();
    }
}

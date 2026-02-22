using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
public partial class PlayerIdChangeAction : Action
{
    public override ActionType Type => ActionType.PLAYER_ID_CHANGE;

    public string NewPlayerId { get; private set; }

    public override void OnReceivedDerived()
    {
        var oldId = MpManager.PeerId;
        MpManager.PeerId = NewPlayerId;
        Notify.ShowOnMainThread(TextId.PeerPlayerIdChanged.Get(oldId, NewPlayerId));
    }

    public static void Send(string newId)
    {
        new PlayerIdChangeAction { NewPlayerId = newId }.SendToHostOrBroadcast();
    }
}

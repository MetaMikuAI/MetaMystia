using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PongAction : NetAction
{
    public override ActionType Type => ActionType.PONG;
    public int Id { get; set; }

    public override void OnReceived()
    {
        LogActionReceived();
        MpManager.UpdateLatency(Id);
    }
    public static NetPacket CreatePongPacket(int id)
    {
        return NetPacket.Create(new PongAction { Id = id });
    }
}

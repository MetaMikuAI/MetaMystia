using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PingAction : NetAction
{
    public override ActionType Type => ActionType.PING;
    public int Id { get; set; }
    public long Timestamp { get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        MpManager.TimeOffset = (MpManager.GetTimestampNow - Timestamp) / 2;
        MpManager.SendPong(Id);
    }
    public static NetPacket CreatePingPacket(int id)
    {
        return NetPacket.Create(new PingAction
        {
            Id = id,
            Timestamp = MpManager.GetTimestampNow
        });
    }
}

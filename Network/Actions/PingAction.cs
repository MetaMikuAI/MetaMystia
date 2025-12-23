using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PingAction : NetAction
{
    public override ActionType Type => ActionType.PING;
    public int Id { get; set; }
    public long Timestamp { get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Debug, onlyAction, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Debug, false, "");
        MpManager.TimeOffset = (MpManager.GetTimestampNow - Timestamp) / 2;
        MpManager.SendPong(Id);
    }
    public static NetPacket CreatePingPacket(int id)
    {
        return new NetPacket([new PingAction
        {
            Id = id,
            Timestamp = MpManager.GetTimestampNow
        }]);
    }
}

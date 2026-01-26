using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PingAction : NetAction
{
    public override ActionType Type => ActionType.PING;
    public int Id { get; set; }
    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;
    public override void OnReceivedDerived()
    {
        MpManager.TimeOffset = (MpManager.TimestampNow - TimestampMs) / 2;
        PongAction.SendToPeer(SenderId, Id);
    }

    public static void SendToPeer(long peerId, int id)
    {
        new PingAction { Id = id }.SendToPeer(peerId);
    }
}

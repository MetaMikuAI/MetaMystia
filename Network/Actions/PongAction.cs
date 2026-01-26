using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PongAction : NetAction
{
    public override ActionType Type => ActionType.PONG;
    public int Id { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;

    public override void OnReceivedDerived()
    {
        MpManager.UpdateLatency(Id);
    }

    public static void SendToPeer(long peerId, int id)
    {
        new PongAction { Id = id }.SendToPeer(peerId);
    }
}

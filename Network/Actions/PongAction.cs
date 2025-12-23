using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class PongAction : NetAction
{
    public override ActionType Type => ActionType.PONG;
    public int Id { get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Debug, onlyAction, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Debug, false, "");
        MpManager.UpdateLatency(Id);
    }
    public static NetPacket CreatePongPacket(int id)
    {
        return new NetPacket([new PongAction { Id = id }]);
    }
}

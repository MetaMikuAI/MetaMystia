using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
public partial class PongAction : Action
{
    public override ActionType Type => ActionType.PONG;
    public int Id { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;

    public override void OnReceivedDerived()
    {
        MpManager.UpdateLatency(Id);
    }

    /// <summary>
    /// 回复 Pong，方向自动判断：客机→主机，主机→所有客机
    /// </summary>
    public static void SendPong(int id)
    {
        new PongAction { Id = id }.SendToHostOrBroadcast();
    }
}

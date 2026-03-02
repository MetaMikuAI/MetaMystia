using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
public partial class PingAction : Action
{
    public override ActionType Type => ActionType.PING;
    public int Id { get; set; }
    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;
    public override void OnReceivedDerived()
    {
        MpManager.TimeOffset = (MpManager.TimestampNow - TimestampMs) / 2;
        PongAction.SendPong(Id);
    }

    /// <summary>
    /// 客机→主机发送 Ping
    /// </summary>
    public static void SendPing(int id)
    {
        new PingAction { Id = id }.SendToHostOrBroadcast();
    }
}

using MemoryPack;

using MetaMystia.UI;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 客机：连接被拒绝，携带拒绝原因。客机收到后显示通知并断开。
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class RejectAction : Action
{
    public override ActionType Type => ActionType.REJECT;
    public TextId ReasonId { get; set; }
    public string[] ReasonArgs { get; set; } = [];

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Warning;

    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost) return;

        var reason = ReasonId.Get(ReasonArgs);
        Log.LogWarning($"Connection rejected: {reason}");
        InGameConsole.ShowPassiveFromAnyThread(reason);
        MpManager.DisconnectPeer();
    }

    /// <summary>
    /// 主机向指定客机发送拒绝消息，然后断开连接
    /// </summary>
    public static void SendAndDisconnect(int uid, TextId reasonId, params string[] args)
    {
        new RejectAction { ReasonId = reasonId, ReasonArgs = args }.SendToClient(uid);
        MpManager.DisconnectClient(uid);
    }
}

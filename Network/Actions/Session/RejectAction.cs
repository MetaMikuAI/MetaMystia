using System.Threading.Tasks;
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
    public string Reason { get; set; } = "";

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Warning;

    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost) return;

        Log.LogWarning($"Connection rejected: {Reason}");
        InGameConsole.ShowPassiveFromAnyThread(Reason);
        MpManager.DisconnectPeer();
    }

    /// <summary>
    /// 主机向指定客机发送拒绝消息，然后断开连接
    /// </summary>
    public static void SendAndDisconnect(int uid, string reason)
    {
        new RejectAction { Reason = reason }.SendToClient(uid);
        // 延迟断开，给客机时间接收消息
        Task.Run(async () =>
        {
            await Task.Delay(200);
            MpManager.DisconnectClient(uid);
        });
    }
}

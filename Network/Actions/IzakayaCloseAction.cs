using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class IzakayaCloseAction : NetAction
{
    public override ActionType Type => ActionType.IZAKAYA_CLOSE;
    public override void OnReceived()
    {
        LogActionReceived();
        if (NightScene.GuestManagementUtility.GuestsManager.Instance != null)
        {
            CommandScheduler.Enqueue(() => true, () =>
            {
                GuestsManagerPatch.TryCloseIzakaya_Original(NightScene.GuestManagementUtility.GuestsManager.Instance);
                Notify.Show("对方已经打烊啦！");
            });
        }
    }

    public static void Send()
    {
        NetPacket packet = new([new IzakayaCloseAction
        {
        }]);
        SendToPeer(packet);
    }
}

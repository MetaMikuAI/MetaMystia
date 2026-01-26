using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class IzakayaCloseAction : NetAction
{
    public override ActionType Type => ActionType.IZAKAYA_CLOSE;

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        if (NightScene.GuestManagementUtility.GuestsManager.Instance != null)
        {
            if (MpManager.IsConnected && !NightScene.GuestManagementUtility.GuestsManager.Instance.isIzakayaClosing)
            {
                Notify.ShowOnMainThread($"{MpManager.PeerId} 已经打烊啦！");
                CommandScheduler.EnqueueWithNoCondition(
                    execute: () =>
                    {
                        if (WorkSceneManager.WorkTimeLeft > 0)
                        {
                            WorkSceneManager.ModifyWorkTimeLeft(1);
                        }
                    }
                );
            }
        }
    }

    public static void Send()
    {
        var action = new IzakayaCloseAction();
        action.SendToHostOrBroadcast();
    }
}

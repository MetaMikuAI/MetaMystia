using Il2CppInterop.Runtime.Injection;
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
        if (NightScene.GuestManagementUtility.GuestsManager.Instance != null && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            // Do not let client call TryCloseIzakaya, some problem will happen like the client may not be able to close izakaya successfully.
            static void onClient() { 
                if (WorkSceneManager.WorkTimeLeft > 0)
                {
                    WorkSceneManager.ModifyWorkTimeLeft(1); 
                }
            }
            static void onServer() => onClient();
            if (MpManager.IsConnected && !NightScene.GuestManagementUtility.GuestsManager.Instance.isIzakayaClosing)
            {
                Notify.ShowOnMainThread("对方营业时间已经结束啦！");
                CommandScheduler.Enqueue(
                    executeWhen: () => true, 
                    executeInfo: "Peer izakaya closed",
                    execute: MpManager.IsClient ? onClient : onServer
                );
            } 
        }
    }

    public static void Send()
    {
        NetPacket packet = new([new IzakayaCloseAction()]);
        SendToPeer(packet);
    }
}

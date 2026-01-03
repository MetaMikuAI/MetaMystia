using MemoryPack;
using NightScene.GuestManagementUtility;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class SceneTransitAction : NetAction
{
    public override ActionType Type => ActionType.SCENE_TRANSIT;

    [MemoryPackAllowSerialize]
    public Common.UI.Scene Scene {get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        MpManager.PeerScene = Scene;
        bool LocalInWork_PeerInMainOrDay = MpManager.LocalScene == Common.UI.Scene.WorkScene 
            && !GuestsManager.Instance.isIzakayaClosing 
            && !MpManager.InStory 
            && (MpManager.PeerScene == Common.UI.Scene.MainScene || MpManager.PeerScene == Common.UI.Scene.DayScene);
        bool LocalInDay_PeerInMain = MpManager.LocalScene == Common.UI.Scene.DayScene && !MpManager.InStory && MpManager.PeerScene == Common.UI.Scene.MainScene;
        if (LocalInWork_PeerInMainOrDay || LocalInDay_PeerInMain)
        {
            Log.Warning("scene mismatch! will disconnect");
            Notify.ShowOnMainThread("对方切换了存档或返回了主菜单，连接已断开");
            MpManager.DisconnectPeer();
        }
    }

    public static void Send(Common.UI.Scene scene)
    {
        NetPacket packet = new([new SceneTransitAction
        {
            Scene = scene
        }]);
        SendToPeer(packet);
    }
}

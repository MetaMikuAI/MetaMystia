using MemoryPack;

using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class IzakayaCloseAction : Action
{
    public override ActionType Type => ActionType.IZAKAYA_CLOSE;

    /// <summary>
    /// 客机收到主机广播的打烊命令 → 执行本地打烊
    /// </summary>
    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            Log.Message($"Received close command from host");
            Notify.ShowOnMainThread(TextId.PeerClosedIzakaya.Get(MpManager.PeerId));
            WorkSceneManager.CloseIzakayaIfPossible();
        });
    }

    /// <summary>
    /// 主机 → 所有客机：广播打烊命令
    /// </summary>
    public static void Broadcast()
    {
        new IzakayaCloseAction().SendToHostOrBroadcast();
    }
}

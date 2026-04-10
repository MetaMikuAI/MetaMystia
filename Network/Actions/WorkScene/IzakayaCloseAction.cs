using MemoryPack;

using MetaMystia.Patch;
using MetaMystia.UI;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 所有客机：广播打烊
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class IzakayaCloseAction : Action
{
    public override ActionType Type => ActionType.IZAKAYA_CLOSE;

    /// <summary>
    /// 客机收到主机广播的打烊命令 → 设置允许打烊标志并直接触发打烊流程
    /// </summary>
    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            Log.Message($"Received close command from host");
            InGameConsole.ShowPassive(TextId.PeerClosedIzakaya.Get(PlayerManager.GetPeerName(SenderUid)));
            WorkSceneManager.AllowClientClose = true;
            var eventManager = NightScene.EventUtility.EventManager.Instance;
            if (eventManager != null)
            {
                NightSceneEventManagerPatch.StopInstantiationLoopAndCloseIzakaya_Original(eventManager);
            }
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

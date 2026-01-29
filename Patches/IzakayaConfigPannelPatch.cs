using HarmonyLib;
using MetaMystia.Network;
using PrepNightScene.UI;
using SgrYuki.Utils;

namespace MetaMystia;


[HarmonyPatch(typeof(PrepNightScene.UI.IzakayaConfigPannel))]
[AutoLog]
public partial class IzakayaConfigPannelPatch
{
    public static IzakayaConfigPannel instanceRef = null;

    [HarmonyPatch(nameof(IzakayaConfigPannel.OnPanelOpen))]
    [HarmonyPrefix]
    public static void IzakayaConfigPannel_OnPanelOpen_Prefix(IzakayaConfigPannel __instance)
    {
        WorkSceneManager.Clear();
        if (MpManager.IsConnected)
        {
            PrepSceneManager.ClearGroups();
            PrepSceneManager.UpdateAll();
        }
        Log.InfoCaller($"called");
    }

    [HarmonyPatch(nameof(IzakayaConfigPannel.OnPanelOpen))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_OnPanelOpen_Postfix(IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(IzakayaConfigPannel.GoToSpecific))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_GoToSpecific_Postfix()
    {
        if (MpManager.IsConnected == false)
        {
            Log.LogDebug($"Not in multiplayer session, skipping patch");
            return;
        }

        // MetaMiku 注:
        //     游戏原生的 GoToSpecific 会变更玩家的活跃选项面板，即 菜谱/酒水/厨具 三选一
        //     但是还会附带检查除去不合法的 厨具 选项
        //     如果在联机中直接调用该方法，可能会导致 厨具 选项出现不同步的问题
        //     因此这里做了一个补丁，强制在调用 GoToSpecific 之后再重新更新厨具选项
        PluginManager.Instance.RunOnMainThread(() =>
        {
            PrepSceneManager.UpdateCookers();
            PrepSceneManager.UpdateUI();
        });

    }

    [HarmonyPatch(nameof(IzakayaConfigPannel._SolveDailyCompletion_b__61_7))]
    [HarmonyPrefix]
    public static bool _SolveDailyCompletion_b__61_7_Prefix()
    {
        if (!MpManager.IsConnected)
        {
            Log.LogDebug($"Not in multiplayer session, skipping patch");
            return true;
        }
        MystiaManager.IsPrepOver = true;
        Notify.ShowOnMainThread(TextId.MystiaReadyForWork.Get());
        ReadyAction.Send(ReadyType.PrepOver);
        if (MpManager.IsConnectedHost)
        {
            MpManager.PrepOver(MpManager.SERVER_ID);
        }
        return false;
    }

    [HarmonyPatch(nameof(IzakayaConfigPannel._SolveDailyCompletion_b__61_7))]
    [HarmonyReversePatch]
    private static void _SolveDailyCompletion_b__61_7_Original(IzakayaConfigPannel __instance)
    {
        throw new System.NotImplementedException();
    }

    public static void PrepOver()
    {
        Log.Info("PrepOver called");
        string[] ExceptPanels = ["WorkSceneTrayPannel(Clone)", "WorkSceneSustainedPannel(Clone)"];  // 白玉楼测验
        Panel.ClosePanelUntil("IzakayaConfigPannelNew(Clone)", ExceptPanels);
        WorkSceneManager.Clear();
        _SolveDailyCompletion_b__61_7_Original(instanceRef);
    }
}

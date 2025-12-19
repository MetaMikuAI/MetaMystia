using HarmonyLib;
using PrepNightScene.UI;

namespace MetaMystia;


[HarmonyPatch(typeof(PrepNightScene.UI.IzakayaConfigPannel))]
public class IzakayaConfigPannelPatch : PatchBase<IzakayaConfigPannelPatch>
{
    public static IzakayaConfigPannel instanceRef = null;

    [HarmonyPatch(nameof(IzakayaConfigPannel.OnPanelOpen))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_OnPanelOpen_Postfix(IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogInfo($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
    }

    [HarmonyPatch(nameof(IzakayaConfigPannel.GoToSpecific))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_GoToSpecific_Postfix()
    {
        if (MpManager.IsConnected == false)
        {
            Log.LogInfo($"{LOG_TAG} Not in multiplayer session, skipping patch");
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
            Log.LogInfo($"{LOG_TAG} Not in multiplayer session, skipping patch");
            return true;
        }

        // MetaMiku 注:
        //     当 Mystia 确认营业后，Prep 面板关闭，触发但跳过 _SolveDailyCompletion_b__61_7 Ready 信号
        //     等待 Kyouko 也准备好后合并 菜单/酒水/厨具 数据并真正进入工作场景
        //     当收到 Kyouko 的 Ready 信号后，立即返回 Ready 信号并直接调用 _SolveDailyCompletion_b__61_7 以真正进入工作场景
        //     即使双方同时确认营业，也不会导致数据分歧或死锁
        //     Mystia 必须等待对方也 Ready 才能继续的目的是确保数据的一致性
        //     _SolveDailyCompletion_b__61_7 负责关闭 PrepScene 并进入 WorkScene （大概）

        Log.LogInfo($"{LOG_TAG} _SolveDailyCompletion_b__61_7 called");
        var remotePlayerReady = PrepSceneManager.remotePlayerReady;
        if (!PrepSceneManager.localPlayerReady)
        {
            PrepSceneManager.localPlayerReady = true;
            MpManager.SendPrep(PrepSceneManager.localPrepTable, true);
        }
        Log.LogInfo($"{LOG_TAG} remotePlayerReady: {remotePlayerReady}");
        return remotePlayerReady;
    }
}

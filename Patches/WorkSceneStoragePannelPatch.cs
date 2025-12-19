using HarmonyLib;
using NightScene.UI.CookingUtility;
using GameData.Core.Collections;

namespace MetaMystia;


[HarmonyPatch(typeof(NightScene.UI.CookingUtility.WorkSceneStoragePannel))]
public class WorkSceneStoragePannelPatch : PatchBase<WorkSceneStoragePannelPatch>
{

    public static WorkSceneStoragePannel instanceRef = null;

    [HarmonyPatch(nameof(WorkSceneStoragePannel.OnPanelOpen))]
    [HarmonyPostfix]
    public static void OnPanelOpen_Postfix(WorkSceneStoragePannel __instance)
    {
        Plugin.Instance.Log.LogDebug("OnPanelOpen_Postfix called");
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(WorkSceneStoragePannel.OnPanelClose))]
    [HarmonyPrefix]
    public static void OnPanelClose_Prefix()
    {
        Plugin.Instance.Log.LogDebug("OnPanelClose_Prefix called");
        instanceRef = null;
    }

    
    [HarmonyPatch(nameof(WorkSceneStoragePannel.Extract))]
    [HarmonyPrefix]
    public static void OnExtract_Prefix(Sellable toExtract)
    {
        Plugin.Instance.Log.LogDebug("OnExtract_Prefix called");
        SellableFood food = SellableFood.FromSellable(toExtract);
        MpManager.Instance.SendExtractFood(food);
    }
}
using GameData.Core.Collections;
using HarmonyLib;
using NightScene.UI.CookingUtility;

namespace MetaMystia;


[HarmonyPatch(typeof(NightScene.UI.CookingUtility.WorkSceneStoragePannel))]
[AutoLog]
public partial class WorkSceneStoragePannelPatch
{

    public static WorkSceneStoragePannel instanceRef = null;

    [HarmonyPatch(nameof(WorkSceneStoragePannel.OnPanelOpen))]
    [HarmonyPostfix]
    public static void OnPanelOpen_Postfix(WorkSceneStoragePannel __instance)
    {
        Log.LogDebug("OnPanelOpen_Postfix called");
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(WorkSceneStoragePannel.OnPanelClose))]
    [HarmonyPrefix]
    public static void OnPanelClose_Prefix()
    {
        Log.LogDebug("OnPanelClose_Prefix called");
        instanceRef = null;
    }

    
    [HarmonyPatch(nameof(WorkSceneStoragePannel.Extract))]
    [HarmonyPrefix]
    public static void OnExtract_Prefix(Sellable toExtract)
    {
        Log.LogDebug("OnExtract_Prefix called");
        SellableFood food = SellableFood.FromSellable(toExtract);
        ExtractFoodAction.Send(food);
    }
}
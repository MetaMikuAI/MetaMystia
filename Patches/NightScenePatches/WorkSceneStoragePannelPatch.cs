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
    public static bool OnExtract_Prefix(Sellable toExtract)
    {
        Log.Warning("OnExtract_Prefix called");
        if (toExtract.type == Sellable.SellableType.Beverage)
        {
            if (MpManager.IsConnected && !DLCManager.PeerBeverageAvailable(toExtract.id))
            {
                Log.LogWarning($"Peer does not have beverage {toExtract.id}, cannot extract.");
                Notify.ShowOnMainThread("对方未装载有此酒水的 DLC！");
                return false;
            }
        }
        else if (toExtract.type == Sellable.SellableType.Food)
        {
            if (MpManager.IsConnected && !DLCManager.PeerFoodAvailable(toExtract.id))
            {
                Log.LogWarning($"Peer does not have recipe {toExtract.id}, cannot extract.");
                Notify.ShowOnMainThread("对方未装载有此食物的 DLC！");
                return false;
            }
            SellableFood food = SellableFood.FromSellable(toExtract);
            ExtractFoodAction.Send(food);
        }
        return true;
    }
}
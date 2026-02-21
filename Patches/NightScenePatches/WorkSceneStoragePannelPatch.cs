using GameData.Core.Collections;
using HarmonyLib;
using MetaMystia.Network;
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
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(WorkSceneStoragePannel.OnPanelClose))]
    [HarmonyPrefix]
    public static void OnPanelClose_Prefix()
    {
        instanceRef = null;
    }


    [HarmonyPatch(nameof(WorkSceneStoragePannel.Extract))]
    [HarmonyPrefix]
    public static bool OnExtract_Prefix(Sellable toExtract)
    {
        Log.InfoCaller($"{toExtract?.id}, {toExtract?.Text?.Name}");
        if (toExtract.type == Sellable.SellableType.Beverage)
        {
            if (MpManager.IsConnected && !DLCManager.PeerBeverageAvailable(toExtract.id))
            {
                Log.LogWarning($"Peer does not have beverage {toExtract.id}, cannot extract.");
                Notify.ShowOnMainThread(TextId.DLCPeerBeverageNotAvailable.Get(toExtract.id));
                return false;
            }
        }
        else if (toExtract.type == Sellable.SellableType.Food)
        {
            if (MpManager.IsConnected && !DLCManager.PeerFoodAvailable(toExtract.id))
            {
                Log.LogWarning($"Peer does not have recipe {toExtract.id}, cannot extract.");
                Notify.ShowOnMainThread(TextId.DLCPeerFoodNotAvailable.Get(toExtract.id));
                return false;
            }
            SellableFood food = SellableFood.FromSellable(toExtract);
            ExtractFoodAction.Send(food);
        }
        return true;
    }
}

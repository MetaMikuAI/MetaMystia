using HarmonyLib;

namespace MetaMystia;
using NightScene.UI;
using NightScene.UI.GuestManagementUtility;
using SgrYuki.Utils;

[HarmonyPatch(typeof(NightScene.UI.GuestManagementUtility.WorkSceneServePannel))]
[AutoLog]
public partial class WorkSceneServePannelPatch
{
    public static WorkSceneServePannel instanceRef = null;

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelInitialize))]
    [HarmonyPostfix]
    public static void OnPanelInitialize_Postfix(WorkSceneServePannel __instance)
    {
        Plugin.Instance.Log.LogInfo("OnPanelInitialize_Postfix called");
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelDestroyed))]
    [HarmonyPostfix]
    public static void OnPanelDestroyed_Postfix()
    {
        Plugin.Instance.Log.LogInfo("OnPanelDestroyed_Postfix called");
        instanceRef = null;
    }

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelClose))]
    [HarmonyPrefix]
    public static bool OnPanelClose_Prefix(WorkSceneServePannel __instance)
    {
        if (__instance == null)
        {
            return false;
        }
        Log.LogInfo($"OnPanelClose_Prefix called");

        if(MpManager.IsConnected)
        {
            var order = __instance.operatingOrder;
            var guest = __instance.currentGuestController; 

            // if this order is evaluated(by peer serving), try return the food/beverage to tray
            if (order == null || guest == null)
            {
                Log.LogInfo($"order null {order == null}, guest null {guest == null}");

                GameData.Core.Collections.Sellable foodInTray = __instance.willServeFood;
                GameData.Core.Collections.Sellable beverageIdInTray = __instance.willServeBeverage;

                var trayInstance = DEYU.Singletons.Singleton<GameData.RunTime.NightSceneUtility.IzakayaTray>.Instance;
                if (trayInstance != null)
                {
                    if (foodInTray != null)
                    {
                        trayInstance.Receive(foodInTray.Duplicate());
                    }
                    if (beverageIdInTray != null)
                    {
                        trayInstance.Receive(beverageIdInTray.Duplicate());
                    }
                    
                }
                return true;
            }

            var uuid = NightGuestManager.GetGuestUUID(guest);
            if(NightGuestManager.GetGuestOrderFullfilled(uuid))
            {
                Log.LogInfo($"{uuid} GuestOrder Fullfilled !");
                return true;
            }

            SellableFood food = order.ServFood != null ? SellableFood.FromSellable(order.servFood) : null;
            food ??= order.ServedFoodInAir != null ? SellableFood.FromSellable(order.ServedFoodInAir) : null;
            food ??= __instance.willServeFood != null ? SellableFood.FromSellable(__instance.willServeFood) : null;

            int? beverageId = order.ServBeverage?.id ?? order.ServedBeverageInAir?.id ?? __instance.willServeBeverage?.id;

            if (food == null && beverageId == null)
            {
                Log.LogInfo($"{uuid} food and beverage are null !");
                return true;
            }

            if (NightGuestManager.GetGuestOrderServedFood(uuid))
            {
                if (beverageId != null)
                {
                    // food already served, only allow serving beverage
                    MpManager.SendGuestServe(NightGuestManager.GetGuestUUID(guest), null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    NightGuestManager.SetGuestOrderServedBeverage(uuid);
                }
            }
            else if (NightGuestManager.GetGuestOrderServedBeverage(uuid))
            {
                if (food != null)
                {
                    // beverage already served, only allow serving food
                    MpManager.SendGuestServe(NightGuestManager.GetGuestUUID(guest), food, -1, GuestServeAction.ServeType.Food);
                    NightGuestManager.SetGuestOrderServedFood(uuid);
                }
            }
            else
            {
                if (beverageId != null && food != null)
                {
                    // none served, now serving both
                    MpManager.SendGuestServe(NightGuestManager.GetGuestUUID(guest), food, beverageId.Value, GuestServeAction.ServeType.Both);
                    NightGuestManager.SetGuestOrderFullfilled(uuid);
                }
                else if (beverageId != null)
                {
                    // none served, now serving beverage
                    MpManager.SendGuestServe(NightGuestManager.GetGuestUUID(guest), null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    NightGuestManager.SetGuestOrderServedBeverage(uuid);
                }
                else
                {
                    // none served, now serving food
                    MpManager.SendGuestServe(NightGuestManager.GetGuestUUID(guest), food, -1, GuestServeAction.ServeType.Food);
                    NightGuestManager.SetGuestOrderServedFood(uuid);
                }
            }
        
            Log.LogInfo($"{uuid} served status: food {NightGuestManager.GetGuestOrderServedFood(uuid)}, beverage {NightGuestManager.GetGuestOrderServedBeverage(uuid)}; food {food}, beverage {beverageId}");
        }
        return true;

    }

    [HarmonyPatch(nameof(WorkSceneServePannel.InvokeOrderUpdate))]
    [HarmonyPrefix]
    public static bool InvokeOrderUpdate_Prefix(WorkSceneServePannel __instance)
    {
        return __instance != null && __instance.operatingOrder != null;
    }


    [HarmonyPatch(nameof(WorkSceneServePannel.Send))]
    [HarmonyReversePatch]
    public static void Send_Original(WorkSceneServePannel __instance, GameData.Core.Collections.Sellable toSend)
    {
         throw new System.NotImplementedException();
    }
}
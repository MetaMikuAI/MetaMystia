using HarmonyLib;
using NightScene.UI.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;
[HarmonyPatch(typeof(NightScene.UI.GuestManagementUtility.WorkSceneServePannel))]
[AutoLog]
public partial class WorkSceneServePannelPatch
{
    public static WorkSceneServePannel instanceRef = null;
    public static volatile bool ManuallyClosePanel = false;

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelInitialize))]
    [HarmonyPostfix]
    public static void OnPanelInitialize_Postfix(WorkSceneServePannel __instance)
    {
        Log.Debug("OnPanelInitialize_Postfix called");
        instanceRef = __instance;
    }

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelDestroyed))]
    [HarmonyPostfix]
    public static void OnPanelDestroyed_Postfix()
    {
        Log.Debug("OnPanelDestroyed_Postfix called");
        instanceRef = null;
    }

    [HarmonyPatch(nameof(WorkSceneServePannel.OnPanelClose))]
    [HarmonyPrefix]
    public static bool OnPanelClose_Prefix(WorkSceneServePannel __instance)
    {
        if (ManuallyClosePanel) return true;
        if (__instance == null)
        {
            return false;
        }
        Log.LogInfo($"OnPanelClose_Prefix called");

        if(MpManager.IsConnected && !MpManager.InStory)
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

                WorkSceneManager.CloseTrayPanel(__instance);
                return false;
            }

            var uuid = WorkSceneManager.GetGuestUUID(guest);
            if (uuid == null) return true;
            if(WorkSceneManager.GetGuestOrderFullfilled(uuid))
            {
                Log.LogInfo($"{uuid} GuestOrder Fullfilled !");
                return true;
            }

            // SellableFood food = order.ServFood != null ? SellableFood.FromSellable(order.servFood) : null;
            // food ??= order.ServedFoodInAir != null ? SellableFood.FromSellable(order.ServedFoodInAir) : null;
            // food ??= __instance.willServeFood != null ? SellableFood.FromSellable(__instance.willServeFood) : null;
            // int? beverageId = order.ServBeverage?.id ?? order.ServedBeverageInAir?.id ?? __instance.willServeBeverage?.id;

            SellableFood food = __instance.willServeFood != null ? SellableFood.FromSellable(__instance.willServeFood) : null;

            int? beverageId = __instance.willServeBeverage?.id;

            if (food == null && beverageId == null)
            {
                Log.LogInfo($"{uuid} food and beverage are null !");
                return true;
            }

            void LogWarningIfNoServe()
            {
                Log.Warning($"{uuid} fail to serve, status: food {WorkSceneManager.GetGuestOrderServedFood(uuid)}, bev {WorkSceneManager.GetGuestOrderServedBeverage(uuid)}; food {food?.FoodId}, bev {beverageId}");
            }

            if (WorkSceneManager.GetGuestOrderServedFood(uuid))
            {
                if (beverageId != null)
                {
                    // food already served, only allow serving beverage
                    GuestServeAction.Send(uuid, null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    WorkSceneManager.SetGuestOrderServedBeverage(uuid);
                } else LogWarningIfNoServe();
            }
            else if (WorkSceneManager.GetGuestOrderServedBeverage(uuid))
            {
                if (food != null)
                {
                    // beverage already served, only allow serving food
                    GuestServeAction.Send(uuid, food, -1, GuestServeAction.ServeType.Food);
                    WorkSceneManager.SetGuestOrderServedFood(uuid);
                } else LogWarningIfNoServe();
            }
            else
            {
                if (beverageId != null && food != null)
                {
                    // none served, now serving both
                    GuestServeAction.Send(uuid, food, beverageId.Value, GuestServeAction.ServeType.Both);
                    WorkSceneManager.SetGuestOrderFullfilled(uuid);
                }
                else if (beverageId != null)
                {
                    // none served, now serving beverage
                    GuestServeAction.Send(uuid, null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    WorkSceneManager.SetGuestOrderServedBeverage(uuid);
                }
                else
                {
                    // none served, now serving food
                    GuestServeAction.Send(uuid, food, -1, GuestServeAction.ServeType.Food);
                    WorkSceneManager.SetGuestOrderServedFood(uuid);
                }
            } 
        
            Log.LogInfo($"{uuid} served status: food {WorkSceneManager.GetGuestOrderServedFood(uuid)}, beverage {WorkSceneManager.GetGuestOrderServedBeverage(uuid)}; food {food?.FoodId}, beverage {beverageId}");
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
    [HarmonyPrefix]
    public static bool Send_Prefix(WorkSceneServePannel __instance, GameData.Core.Collections.Sellable toSend)
    {
        // This function will not actually send food/bev to guest, because player can revoke them.
        if (toSend != null)
        {
            Log.Info($"toSend {toSend.type}, id={toSend.Id}, {toSend.ToString()}");
        }
        if (toSend == null || __instance == null)
        {
            Log.Error($"toSend is null, will close serve panel");
            CommandScheduler.EnqueueWithNoCondition(() =>
            {
                WorkSceneManager.CloseServePanel(__instance);
            });
            return false;
        }
        return true;
    }
}
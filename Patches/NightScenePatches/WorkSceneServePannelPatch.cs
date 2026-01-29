using HarmonyLib;
using MetaMystia.Network;
using NightScene.UI.GuestManagementUtility;
using SgrYuki;

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

        if (!MpManager.ShouldSkipAction)
        {
            var order = __instance.operatingOrder;
            var guest = __instance.currentGuestController;

            Log.InfoCaller($"target {guest.GetGuestFSM()?.Identifier}");

            // if this order is evaluated(by peer serving), try return the food/beverage to tray
            if (order == null || guest == null)
            {
                Log.InfoCaller($"order null {order == null}, guest null {guest == null}");

                GameData.Core.Collections.Sellable foodInTray = __instance.willServeFood;
                GameData.Core.Collections.Sellable beverageIdInTray = __instance.willServeBeverage;

                var trayInstance = DEYU.Singletons.Singleton<GameData.RunTime.NightSceneUtility.IzakayaTray>.Instance;
                if (trayInstance != null)
                {
                    if (foodInTray != null)
                    {
                        Log.InfoCaller($"returned food in tray");
                        trayInstance.Receive(foodInTray.Duplicate());
                    }
                    if (beverageIdInTray != null)
                    {
                        Log.InfoCaller($"returned bev in tray");
                        trayInstance.Receive(beverageIdInTray.Duplicate());
                    }
                }

                WorkSceneManager.CloseTrayPanel(__instance);
                return false;
            }

            var uuid = WorkSceneManager.GetGuestUUID(guest);
            if (uuid == null) return true;

            var fsm = WorkSceneManager.GetGuestFSM(uuid);
            if (fsm.IsOrderFulfilled())
            {
                Log.InfoCaller($"{fsm.Identifier} GuestOrder Fulfilled !");
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
                Log.DebugCaller($"{fsm.Identifier} food and beverage are null, will not serve");
                return true;
            }

            void LogWarningIfNoServe()
            {
                Log.WarningCaller($"{fsm.Identifier} fail to serve, status: food {fsm.IsOrderFoodServed()}, bev {fsm.IsOrderBeverageServed()}; food {food?.FoodId}, bev {beverageId}");
            }

            if (fsm.IsOrderFoodServed())
            {
                if (beverageId != null)
                {
                    // food already served, only allow serving beverage
                    GuestServeAction.Send(uuid, null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    fsm.SetOrderServedBeverage();
                }
                else LogWarningIfNoServe();
            }
            else if (fsm.IsOrderBeverageServed())
            {
                if (food != null)
                {
                    // beverage already served, only allow serving food
                    GuestServeAction.Send(uuid, food, -1, GuestServeAction.ServeType.Food);
                    fsm.SetOrderServedFood();
                }
                else LogWarningIfNoServe();
            }
            else
            {
                if (beverageId != null && food != null)
                {
                    // none served, now serving both
                    GuestServeAction.Send(uuid, food, beverageId.Value, GuestServeAction.ServeType.Both);
                    fsm.SetOrderFulfilled();
                }
                else if (beverageId != null)
                {
                    // none served, now serving beverage
                    GuestServeAction.Send(uuid, null, beverageId.Value, GuestServeAction.ServeType.Beverage);
                    fsm.SetOrderServedBeverage();
                }
                else
                {
                    // none served, now serving food
                    GuestServeAction.Send(uuid, food, -1, GuestServeAction.ServeType.Food);
                    fsm.SetOrderServedFood();
                }
            }

            Log.InfoCaller($"{fsm.Identifier} served status: food {fsm.IsOrderFoodServed()}, bev {fsm.IsOrderBeverageServed()}; food {food?.FoodId}, beverage {beverageId}");
        }
        return true;

    }

    [HarmonyPatch(nameof(WorkSceneServePannel.InvokeOrderUpdate))]
    [HarmonyPrefix]
    public static bool InvokeOrderUpdate_Prefix(WorkSceneServePannel __instance)
    {
        if (__instance == null || __instance.operatingOrder == null) return false;
        if (MpManager.IsConnected)
        {
            var o = __instance.operatingOrder;
            Log.InfoCaller($"{__instance.currentGuestController?.GetGuestFSM()?.Identifier} Fullfilled {o.IsFullfilled}, f {o.ServFood?.Text?.Name}, b {o.ServBeverage?.Text?.Name}, f air {o.ServedFoodInAir?.Text?.Name}, b air {o.ServedBeverageInAir?.Text?.Name}");
        }
        return true;
    }

    [HarmonyPatch(nameof(WorkSceneServePannel.Send))]
    [HarmonyPrefix]
    public static bool Send_Prefix(WorkSceneServePannel __instance, GameData.Core.Collections.Sellable toSend)
    {
        // This function will not actually send food/bev to guest, because player can revoke them.
        if (toSend != null)
        {
            Log.InfoCaller($"{toSend.type}, id={toSend.Id}, {toSend?.Text?.BriefName}");
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

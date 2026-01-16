using HarmonyLib;
using NightScene.GuestManagementUtility;

namespace MetaMystia;
[HarmonyPatch]
[AutoLog]
public partial class GuestGroupControllerPatch
{
    // [HarmonyPatch(typeof(GuestsManager.__c__DisplayClass171_0), nameof(GuestsManager.__c__DisplayClass171_0.Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0))]
    // [HarmonyPrefix]
    // public static void GenerateOrderInternalPrefix(GuestGroupController toGenerate, GuestsManager.OrderBase orderData)
    // {
    //     Log.LogInfo($"GenerateOrderInternalPrefix called, orderData {orderData} \n");
    // }


    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPrefix]
    public static bool GenerateOrderPrefix(GuestGroupController __instance, bool isFreeOrder, ref string orderGenerationMessage, ref GuestsManager.OrderBase generatedOrder, ref bool __result)
    {
        // Log.LogInfo($"GenerateOrderPrefix called");
        if (MpManager.IsConnectedClient && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if (WorkSceneManager.orders.TryDequeue(out var item))
            {
                (generatedOrder, orderGenerationMessage) = item;

                Log.LogInfo($"generating order from peer: {orderGenerationMessage} ");
                __result = true;
            }
            else
            {
                Log.LogError($"dequeue failed! ");
                return true;
            }
            return false;
        }
        return true;
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPostfix]
    public static void GenerateOrderPostfix(GuestGroupController __instance, bool isFreeOrder, ref string orderGenerationMessage, ref GuestsManager.OrderBase generatedOrder)
    {
        if (__instance == null)
        {
            return;
        }
        if (MpManager.IsConnectedHost && MpManager.LocalScene == Common.UI.Scene.WorkScene && generatedOrder != null && !MpManager.InStory)
        {
            WorkSceneManager.SetGuestStatus(WorkSceneManager.GetGuestUUID(__instance), WorkSceneManager.Status.OrderGenerated);
            switch (generatedOrder.Type)
            {
                case GuestsManager.OrderBase.OrderType.Normal:
                    Log.LogInfo($"orderData NormalOrder");
                    GuestGenNormalOrderAction.Send(WorkSceneManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                case GuestsManager.OrderBase.OrderType.Special:
                    Log.LogInfo($"orderData SpecialOrder");
                    GuestGenSPOrderAction.Send(WorkSceneManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                default:
                    Log.LogError($"orderData wrong type!");
                    break;
            }
        }
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToDesk))]
    [HarmonyPrefix]
    public static bool MoveToDesk_Prefix(GuestGroupController __instance, int deskCode, Il2CppSystem.Action onMovementFinishCallback)
    {
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = WorkSceneManager.GetGuestUUID(__instance);
            if (uuid == null)
            {
                Log.Error($"not found uuid, will use original logic");
                return true;
            }
            var seat = WorkSceneManager.GetGuestDeskcodeSeat(uuid);
            Log.Info($"sending {uuid} to desk {deskCode}, seat {seat}");
            WorkSceneManager.MoveToDesk(__instance, deskCode, onMovementFinishCallback, seat);
            return false;
        }
        return true;
    }

}

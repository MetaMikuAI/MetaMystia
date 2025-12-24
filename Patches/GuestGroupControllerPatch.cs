using HarmonyLib;
using NightScene.GuestManagementUtility;

namespace MetaMystia;
using NightScene.Tiles;

using System.Linq;

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
        if (MpManager.IsConnectedClient)
        {
            if (NightGuestManager.orders.TryDequeue(out var item))
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
        // Log.LogInfo($"GenerateOrderPostfix called, isFreeOrder {isFreeOrder}, orderGenerationMessage {orderGenerationMessage}\n");
        if (__instance == null)
        {
            return;
        }
        if (MpManager.IsConnectedHost)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(__instance), NightGuestManager.Status.OrderGenerated);
            switch (generatedOrder.Type)
            {
                case GuestsManager.OrderBase.OrderType.Normal:
                    Log.LogInfo($"orderData NormalOrder");
                    MpManager.SendGuestGenNormalOrder(NightGuestManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                case GuestsManager.OrderBase.OrderType.Special:
                    Log.LogInfo($"orderData SpecialOrder");
                    MpManager.SendGuestGenSPOrder(NightGuestManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                default:
                    Log.LogError($"orderData wrong type!");
                    break;
            }
        }
    }

    // [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToDesk))]
    // [HarmonyPrefix]
    // public static bool MoveToDesk_Prefix(GuestGroupController __instance, int deskCode, Il2CppSystem.Action onMovementFinishCallback)
    // {
    //     NightGuestManager.MoveToDesk(__instance, deskCode, onMovementFinishCallback);
    //     return false;
    // }

}

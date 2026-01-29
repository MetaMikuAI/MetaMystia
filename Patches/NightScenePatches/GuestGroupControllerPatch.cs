using HarmonyLib;
using MetaMystia.Network;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

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
        Log.Debug($"GenerateOrderPrefix called");
        if (MpManager.IsConnectedClient && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = __instance.GetGuestUUID();
            if (uuid == null)
            {
                Log.Error($"pointer {__instance.Pointer} uuid is null!");
                return true;
            }
            var fsm = __instance.GetGuestFSM();
            if (fsm.DequeueOrder(out var item))
            {
                (generatedOrder, orderGenerationMessage) = item;

                Log.Info($"generating order for {uuid}: {orderGenerationMessage} ");
                __result = true;
            }
            else
            {
                Log.Error($"{uuid} dequeue failed! ");
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
            var uuid = __instance.GetGuestUUID();
            if (uuid == null) return;
            var fsm = WorkSceneManager.GetGuestFSM(uuid);
            fsm.TryGenerateOrder();
            switch (generatedOrder.Type)
            {
                case GuestsManager.OrderBase.OrderType.Normal:
                    GuestGenNormalOrderAction.Send(uuid, generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                case GuestsManager.OrderBase.OrderType.Special:
                    GuestGenSPOrderAction.Send(uuid, generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    break;
                default:
                    Log.LogError($"orderData wrong type!");
                    Log.LogStacktrace();
                    break;
            }
        }
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToDesk))]
    [HarmonyPrefix]
    public static bool MoveToDesk_Prefix(GuestGroupController __instance, int deskCode, Il2CppSystem.Action onMovementFinishCallback)
    {
        if (!MpManager.ShouldSkipAction && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
            if (IsReimuSpellCardTriggered)
            {
                return true;
            }
            var uuid = __instance.GetGuestUUID();
            if (uuid == null)
            {
                Log.Error($"not found uuid, will use original logic");
                return true;
            }
            var seat = WorkSceneManager.GetGuestDeskcodeSeat(uuid);
            Log.Info($"sending {uuid.GetGuestFSM()?.Identifier} to desk {deskCode}, seat {seat}");
            WorkSceneManager.MoveToDesk(__instance, deskCode, onMovementFinishCallback, seat);
            return false;
        }
        return true;
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.EvaluateUnderSparrowTune))]
    [HarmonyPrefix]
    public static void EvaluateUnderSparrowTune_Prefix(GuestGroupController __instance, int oldEvaluate)
    {
        Log.InfoCaller($"{__instance.GetGuestFSM()?.Identifier}, oldEvaluate {oldEvaluate}");
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToSpawn))]
    [HarmonyPrefix]
    public static void MoveToSpawn_Prefix(GuestGroupController __instance)
    {
        if (!MpManager.ShouldSkipAction && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            var fsm = __instance.GetGuestFSM(LogError: false);
            if (fsm == null) return;
            if (WorkSceneManager.CheckStatus(fsm.GuestUUID, WorkSceneManager.Status.Generated))
            {
                Log.WarningCaller($"{fsm.Identifier} trying to leave just after generated? Set to leave");
                fsm?.TryLeave();
                GuestLeaveAction.Send(fsm.GuestUUID, GuestLeaveAction.LeaveType.LeaveFromQueue);
            }
        }
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToSpawn))]
    [HarmonyReversePatch]
    public static void MoveToSpawn_Original(GuestGroupController __instance)
    {
        throw new System.NotImplementedException();
    }
}

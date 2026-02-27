using HarmonyLib;

using NightScene.GuestManagementUtility;

using MetaMystia.Network;
using SgrYuki.Utils;

namespace MetaMystia.Patch;

[HarmonyPatch]
[AutoLog]
public partial class GuestGroupControllerPatch
{
    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPostfix]
    public static void GenerateOrderPostfix(GuestGroupController __instance, bool isFreeOrder, ref string orderGenerationMessage, ref GuestsManager.OrderBase generatedOrder)
    {
        if (__instance == null) return;
        if (MpManager.ShouldSkipAction) return;
        if (MpManager.IsHost && generatedOrder != null)
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
                    Log.ErrorCaller($"orderData wrong type!");
                    Log.LogStacktrace();
                    break;
            }
        }
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToDesk))]
    [HarmonyPrefix]
    public static bool MoveToDesk_Prefix(GuestGroupController __instance, int deskCode, Il2CppSystem.Action onMovementFinishCallback)
    {
        if (MpManager.ShouldSkipAction) return true;

        bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
        if (IsReimuSpellCardTriggered) return true;

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
        if (MpManager.ShouldSkipAction) return;

        var fsm = __instance.GetGuestFSM(LogError: false);
        if (fsm == null) return;
        Log.InfoCaller($"{fsm.Identifier} moving");
        if (WorkSceneManager.CheckStatus(fsm.GuestUUID, WorkSceneManager.Status.Generated))
        {
            Log.WarningCaller($"{fsm.Identifier} trying to leave just after generated? Set to leave");
            fsm?.TryLeave();
            GuestLeaveAction.Send(fsm.GuestUUID, GuestLeaveAction.LeaveType.LeaveFromQueue);
        }
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.MoveToSpawn))]
    [HarmonyReversePatch]
    public static void MoveToSpawn_Original(GuestGroupController __instance)
    {
        throw new System.NotImplementedException();
    }
}

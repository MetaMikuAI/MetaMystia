using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage.Collections;
using HarmonyLib;
using MetaMystia.Network;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

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


[HarmonyPatch]
[AutoLog]
public partial class SpecialGuestsControllerPatch
{
    [HarmonyPatch(typeof(SpecialGuestsController), nameof(SpecialGuestsController.GetOrderFoodText))]
    [HarmonyPostfix]
    public static void GetOrderFoodTextPostfix(GuestsManager.SpecialOrder specialOrder, ref string __result)
    {
        if (Spell_Koakuma.CheckBuff())
        {
            var ret = $"{__result} ({specialOrder.foodRequest.GetFoodTag()})";
            Log.InfoCaller($"id={specialOrder.foodRequest}, original={__result}, ret={ret}");
            __result = ret;
        }
    }

    [HarmonyPatch(typeof(SpecialGuestsController), nameof(SpecialGuestsController.TriggerPositiveBuff))]
    [HarmonyPrefix]
    public static bool TriggerPositiveBuffPrefix(SpecialGuestsController __instance)
    {
        if (__instance.SpecialGuest.Id == 9000)
        {
            Log.InfoCaller($"triggered Spell_Daiyousei");
            Spell_Daiyousei.SpellHandle.Asset.SchedulePositiveBuffExecution(__instance.GetSpellExecutionContext(null, true));
            return false;
        }
        if (__instance.SpecialGuest.Id == 9001)
        {
            Log.InfoCaller($"triggered Spell_Koakuma");
            Spell_Koakuma.SpellHandle.Asset.SchedulePositiveBuffExecution(__instance.GetSpellExecutionContext(null, true));
            return false;
        }
        return true;
    }

    [HarmonyPatch(typeof(SpecialGuestsController), nameof(SpecialGuestsController.TriggerNegativeBuff))]
    [HarmonyPrefix]
    public static bool TriggerNegativeBuffPrefix(SpecialGuestsController __instance)
    {
        if (__instance.SpecialGuest.Id == 9000)
        {
            Log.InfoCaller($"triggered Spell_Daiyousei");
            Spell_Daiyousei.SpellHandle.Asset.ScheduleNegativeBuffExecution(__instance.GetSpellExecutionContext(null, true));
            return false;
        }
        if (__instance.SpecialGuest.Id == 9001)
        {
            Log.InfoCaller($"triggered Spell_Koakuma");
            Spell_Koakuma.SpellHandle.Asset.ScheduleNegativeBuffExecution(__instance.GetSpellExecutionContext(null, true));
            return false;
        }
        return true;
    }

}

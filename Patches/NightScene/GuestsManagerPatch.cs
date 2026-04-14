using System;
using HarmonyLib;

using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;


using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))]
// === 生成与初始化 ===
[TracePatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
[TracePatch(nameof(GuestsManager.SpawnNormalGuestGroup), new[] {
    typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
    typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
    typeof(GuestGroupController.LeaveType),
    typeof(int),
    typeof(bool),
}, DisplayName = "GuestsManager.SpawnNormalGuestGroup_WithArgs")]
[TracePatch(nameof(GuestsManager.SpawnNormalGuestGroup), new Type[0], DisplayName = "GuestsManager.SpawnNormalGuestGroup")]
[TracePatch(nameof(GuestsManager.SpawnManualControlledSpecialGuestGroup))]
[TracePatch("SpawnGuest")]
[TracePatch(nameof(GuestsManager.PostInitializeGuestGroup))]
// === 排队与入座 ===
[TracePatch(nameof(GuestsManager.TrySendToSeat))]
[TracePatch(nameof(GuestsManager.CheckAndSendFromQueue))]
// === 点单与待上菜 ===
[TracePatch("FirstOrder")]
[TracePatch("GenerateOrderSession")]
[TracePatch(nameof(GuestsManager.ExcuteEventAtCorodinate))]
[TracePatch("ShowOrder")]
// === 评价与续单 ===
[TracePatch(nameof(GuestsManager.EvaluateOrder))]
[TracePatch("EvaulateManualOrder")]
[TracePatch("MainOrderCycle")]
[TracePatch("LackMoneyEvaluate")]
// === 耐心与强制离场 ===
[TracePatch("AddToPatientCountdown")]
[TracePatch("RemoveFromPatientCountdown")]
[TracePatch("PatientDepletedLeave")]
[TracePatch("RepellInternal")]
[TracePatch(nameof(GuestsManager.PlayerRepell))]
[TracePatch(nameof(GuestsManager.TryRepellAllQueuedGuestControllers))]
// === 结账与离场 ===
[TracePatch(nameof(GuestsManager.PayAndLeave))]
[TracePatch(nameof(GuestsManager.GuestPay))]
[TracePatch(nameof(GuestsManager.PayByMood))]
[TracePatch("LeaveFromDesk")]
[AutoLog]
public partial class GuestsManagerPatch
{
    // === FSM: None → Constructed ===
    [HarmonyPatch("PostInitializeGuestGroup")]
    [HarmonyPrefix]
    public static void PostInitializeGuestGroup_FSM_Prefix(GuestGroupController initializedController)
    {
        var uuid = WorkSceneManager.StoreGuest(initializedController);
        var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
        fsm.OnSpawned();
    }

    // === FSM: Constructed → SeatMoving ===
    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyPostfix]
    public static void TrySendToSeat_FSM_Postfix(GuestGroupController toTry, bool __result)
    {
        if (!__result) return;
        var fsm = toTry.GetGuestFSM();
        if (fsm == null) return;
        fsm.OnSeatMoveStarted(toTry.DeskCode);
    }

    // === FSM: SeatMoving → SeatedDelay → WaitingServe (首单) ===
    [HarmonyPatch("FirstOrder")]
    [HarmonyPrefix]
    public static void FirstOrder_FSM_Prefix(GuestGroupController first)
    {
        var fsm = first.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.SeatMoving)
            fsm.OnSeated(first.DeskCode);
        fsm.OnOrderOpened(first.DeskCode);
    }

    // === FSM: WaitingServe → Evaluating ===
    [HarmonyPatch(nameof(GuestsManager.EvaluateOrder))]
    [HarmonyPrefix]
    public static void EvaluateOrder_FSM_Prefix(GuestGroupController toEvaluate)
    {
        var fsm = toEvaluate.GetGuestFSM();
        fsm?.OnEvaluationStarted();
    }

    // === FSM: Evaluating → ContinueDecision ===
    [HarmonyPatch("MainOrderCycle")]
    [HarmonyPrefix]
    public static void MainOrderCycle_FSM_Prefix(GuestGroupController toCycle)
    {
        var fsm = toCycle.GetGuestFSM();
        fsm?.OnEvaluationFinished();
    }

    // === FSM: ContinueDecision → WaitingServe (续单成功) ===
    [HarmonyPatch("AddToPatientCountdown")]
    [HarmonyPrefix]
    public static void AddToPatientCountdown_FSM_Prefix(GuestGroupController toCountDown)
    {
        var fsm = toCountDown.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.ContinueDecision)
            fsm.OnContinueOrderOpened(toCountDown.DeskCode);
    }

    // === FSM: WaitingServe → Leaving (桌上耐心耗尽) ===
    [HarmonyPatch("PatientDepletedLeave")]
    [HarmonyPrefix]
    public static void PatientDepletedLeave_FSM_Prefix(GuestGroupController toPatientDepletedLeave)
    {
        var fsm = toPatientDepletedLeave.GetGuestFSM();
        fsm?.OnPatienceExpiredAtDesk();
    }

    // === FSM: Various → Leaving (驱赶) ===
    [HarmonyPatch("RepellInternal")]
    [HarmonyPrefix]
    public static void RepellInternal_FSM_Prefix(GuestGroupController guestGroupController)
    {
        var fsm = guestGroupController.GetGuestFSM();
        fsm?.OnRepelled();
    }

    // === FSM: Various → Leaving (离桌通用入口) ===
    [HarmonyPatch("LeaveFromDesk")]
    [HarmonyPrefix]
    public static void LeaveFromDesk_FSM_Prefix(GuestGroupController toLeave)
    {
        var fsm = toLeave.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.ContinueDecision)
            fsm.OnContinueStopped(GuestFSM.LeaveReason.NotContinue);
        fsm.OnLeaveStarted(GuestFSM.LeaveReason.PayAndLeave);
    }
}

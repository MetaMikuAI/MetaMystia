using System;
using HarmonyLib;

using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;

using MetaMystia.Network;
using SgrYuki.Utils;

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
    // ═══════════════════════════════════════════════════════════
    //  生成与初始化
    // ═══════════════════════════════════════════════════════════

    // === FSM: None → Constructed ===
    [HarmonyPatch("PostInitializeGuestGroup")]
    [HarmonyPrefix]
    public static void PostInitializeGuestGroup_FSM_Prefix(GuestGroupController initializedController)
    {
        var uuid = WorkSceneManager.StoreGuest(initializedController);
        var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
        fsm.OnSpawned();

        // 注册 OnCompletelyLeaveCallback 以触发 Leaving → Left 转移。
        // MoveToSpawn.OnArrive 和 FlyToSpawn._b__2 每个角色到达时都会调用此回调，
        // 多角色群组会触发多次，因此需要检查 FSM 状态避免重复转移。
        var existingCallback = initializedController.OnCompletelyLeaveCallback;
        initializedController.OnCompletelyLeaveCallback = new System.Action<GuestGroupController>(guest =>
        {
            const string traceName = "GuestGroupController.OnCompletelyLeaveCallback";
            tl.OnPrefix(traceName);
            try
            {
                try { existingCallback?.Invoke(guest); } catch { }
                var guestFsm = guest.GetGuestFSM();
                if (guestFsm != null && guestFsm.CurrentState == GuestFSM.State.Leaving)
                {
                    guestFsm.OnLeaveCompleted();
                }
            }
            catch (System.Exception ex)
            {
                tl.OnFinalizer(traceName, ex);
                throw;
            }
            tl.OnPostfix(traceName);
        });
    }

    // --- Network: SpawnNormalGuestGroup (with args) ---
    // 客机不生成顾客，由主机通过 GuestFSMEventAction.Spawned 通知。
    internal static bool SpawnNormalGuestGroup_WithArg_Manual_Call;

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyPrefix]
    public static bool SpawnNormalGuestGroup_WithArg_Prefix(
        ref Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition)
    {
        overrideSpawnPosition ??= new Il2CppSystem.Nullable<UnityEngine.Vector3>();
        if (SpawnNormalGuestGroup_WithArg_Manual_Call) return RunOriginal;
        if (MpManager.IsConnectedClient && !MpManager.InStory)
            return SkipOriginal;
        return RunOriginal;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyPostfix]
    public static void SpawnNormalGuestGroup_WithArg_Postfix(
        NormalGuestsController __result,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
        GuestGroupController.LeaveType leaveType)
    {
        if (__result == null) return;
        if (!MpManager.IsConnectedHost) return;

        var uuid = WorkSceneManager.GetGuestUUID(__result);
        if (uuid == null) return;
        var array = __result.GetAllGuests().ToIl2CppReferenceArray();

        var guestVisualArray = DataBaseCharacter.NormalGuestVisual.Get(array[0].id).SortByToString();
        int visualId1 = guestVisualArray.IndexAtByToString(array[0].CharacterPixel);

        var info = new WorkSceneManager.GuestInfo
        {
            Id = array[0].id,
            VisualId = visualId1,
            IsSpecial = false,
            LeaveType = leaveType
        };
        if (overrideSpawnPosition.HasValue
            && overrideSpawnPosition.Value.sqrMagnitude > 0.25f * 0.25f * 3
            && overrideSpawnPosition.Value.sqrMagnitude < 15 * 15 * 3)
        {
            info.OverrideSpawnPosition = overrideSpawnPosition.Value;
        }
        if (array.Length > 1)
        {
            var guestVisualArray2 = DataBaseCharacter.NormalGuestVisual.Get(array[1].id).SortByToString();
            int visualId2 = guestVisualArray2.IndexAtByToString(array[1].CharacterPixel);
            info.Id2 = array[1].id;
            info.VisualId2 = visualId2;
        }
        GuestFSMEventAction.SendSpawn(uuid, info);
    }

    // --- Network: SpawnSpecialGuestGroup ---
    [HarmonyPatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
    [HarmonyPrefix]
    public static bool SpawnSpecialGuestGroup_Prefix(
        ref int id,
        ref SpecialGuestsController __result)
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedClient)
        {
            __result = null;
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
    [HarmonyPostfix]
    public static void SpawnSpecialGuestGroup_Postfix(
        SpecialGuestsController __result,
        int id,
        GuestGroupController.LeaveType leaveType)
    {
        if (__result == null) return;
        if (!MpManager.IsConnectedHost) return;

        var uuid = WorkSceneManager.GetGuestUUID(__result);
        if (uuid == null) return;
        var info = new WorkSceneManager.GuestInfo
        {
            Id = id,
            IsSpecial = true,
            LeaveType = leaveType
        };
        GuestFSMEventAction.SendSpawn(uuid, info);
    }

    // ═══════════════════════════════════════════════════════════
    //  排队与入座
    // ═══════════════════════════════════════════════════════════

    // === FSM: Constructed → SeatMoving + Network ===
    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyPrefix]
    public static bool TrySendToSeat_Prefix(ref bool __result)
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedClient)
        {
            __result = false;
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyPostfix]
    public static void TrySendToSeat_FSM_Postfix(GuestGroupController toTry, bool firstSpawn, bool __result)
    {
        if (!__result) return;
        var fsm = toTry.GetGuestFSM();
        if (fsm == null) return;
        fsm.OnSeatMoveStarted(toTry.DeskCode);

        if (MpManager.IsConnectedHost)
        {
            var uuid = WorkSceneManager.GetGuestUUID(toTry);
            if (uuid != null)
                GuestFSMEventAction.SendSeatMove(uuid, toTry.DeskCode, fsm.DeskSeatCode, firstSpawn);
        }
    }

    // --- Network: CheckAndSendFromQueue ---
    [HarmonyPatch(nameof(GuestsManager.CheckAndSendFromQueue))]
    [HarmonyPrefix]
    public static bool CheckAndSendFromQueue_Prefix()
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedClient) return SkipOriginal;
        return RunOriginal;
    }

    // ═══════════════════════════════════════════════════════════
    //  点单与待上菜
    // ═══════════════════════════════════════════════════════════

    // === FSM: SeatedDelay → WaitingServe (首单) ===
    // 注：SeatMoving → SeatedDelay 由 RefreshCurrentFundAndOrder hook 触发
    [HarmonyPatch("FirstOrder")]
    [HarmonyPrefix]
    public static void FirstOrder_FSM_Prefix(GuestGroupController first)
    {
        var fsm = first.GetGuestFSM();
        if (fsm == null) return;
        fsm.OnOrderOpened(first.DeskCode);
    }

    // --- Network: GenerateOrderSession ---
    // 客机不独立生成订单，由主机通过 GuestFSMEventAction.OrderOpened 通知。
    [HarmonyPatch("GenerateOrderSession")]
    [HarmonyPrefix]
    public static bool GenerateOrderSession_Prefix()
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedClient) return SkipOriginal;
        return RunOriginal;
    }

    [HarmonyPatch("GenerateOrderSession")]
    [HarmonyPostfix]
    public static void GenerateOrderSession_Postfix(GuestGroupController guestGroup)
    {
        if (!MpManager.IsConnectedHost) return;
        WorkSceneManager.DelayedSafeAddMaxPatient(guestGroup);
    }

    // ═══════════════════════════════════════════════════════════
    //  评价与续单
    // ═══════════════════════════════════════════════════════════

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

    // ═══════════════════════════════════════════════════════════
    //  耐心耗尽与驱赶
    // ═══════════════════════════════════════════════════════════

    // === FSM: WaitingServe → Leaving (桌上耐心耗尽) + Network ===
    [HarmonyPatch("PatientDepletedLeave")]
    [HarmonyPrefix]
    public static bool PatientDepletedLeave_Prefix(GuestGroupController toPatientDepletedLeave)
    {
        var fsm = toPatientDepletedLeave.GetGuestFSM();
        fsm?.OnPatienceExpiredAtDesk();

        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedHost)
        {
            var uuid = WorkSceneManager.GetGuestUUID(toPatientDepletedLeave);
            if (uuid != null)
                GuestFSMEventAction.SendPatienceExpired(uuid);
        }
        if (MpManager.IsConnectedClient) return SkipOriginal;
        return RunOriginal;
    }

    // === FSM: Various → Leaving (驱赶) + Network ===
    [HarmonyPatch("RepellInternal")]
    [HarmonyPrefix]
    public static bool RepellInternal_Prefix(GuestGroupController guestGroupController)
    {
        var fsm = guestGroupController.GetGuestFSM();
        fsm?.OnRepelled();

        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedHost)
        {
            var uuid = WorkSceneManager.GetGuestUUID(guestGroupController);
            if (uuid != null)
                GuestFSMEventAction.SendRepel(uuid);
        }
        if (MpManager.IsConnectedClient) return SkipOriginal;
        return RunOriginal;
    }

    // ═══════════════════════════════════════════════════════════
    //  结账与离场
    // ═══════════════════════════════════════════════════════════

    // --- Network: PayAndLeave ---
    [HarmonyPatch(nameof(GuestsManager.PayAndLeave))]
    [HarmonyPrefix]
    public static bool PayAndLeave_Prefix(GuestGroupController toPayAndLeave)
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedHost)
        {
            var uuid = WorkSceneManager.GetGuestUUID(toPayAndLeave);
            if (uuid != null)
                GuestFSMEventAction.SendLeave(uuid, GuestFSM.LeaveReason.PayAndLeave);
        }
        if (MpManager.IsConnectedClient) return SkipOriginal;
        return RunOriginal;
    }

    // === FSM: Various → Leaving (离桌通用入口) + Network ===
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

    // --- Network: PlayerRepell ---
    // PlayerRepell 由任何玩家发起，主机向客机广播。
    [HarmonyPatch(nameof(GuestsManager.PlayerRepell))]
    [HarmonyPrefix]
    public static bool PlayerRepell_Prefix(int deskCode)
    {
        if (MpManager.ShouldSkipAction) return RunOriginal;
        if (MpManager.IsConnectedClient) return SkipOriginal;

        // 主机：正常执行（RepellInternal 会发送 SendRepel）
        return RunOriginal;
    }

    // ═══════════════════════════════════════════════════════════
    //  ReversePatch — 绕过 Harmony 前缀，直接调用原生方法
    // ═══════════════════════════════════════════════════════════

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyReversePatch]
    public static NormalGuestsController SpawnNormalGuestGroup_WithArg_Original(
        GuestsManager __instance,
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
        GuestGroupController.LeaveType leaveType,
        int targetDeskCode,
        bool shouldFade)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 包装 ReversePatch，设置 Manual_Call 标志以绕过客机前缀阻止。
    /// </summary>
    public static NormalGuestsController SpawnNormalGuestGroup_Original(
        GuestsManager __instance,
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = null,
        GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
        int targetDeskCode = -1,
        bool shouldFade = true)
    {
        SpawnNormalGuestGroup_WithArg_Manual_Call = true;
        var res = __instance.SpawnNormalGuestGroup(
            normalGuests,
            overrideSpawnPosition ?? new Il2CppSystem.Nullable<UnityEngine.Vector3>(),
            leaveType, targetDeskCode, shouldFade);
        SpawnNormalGuestGroup_WithArg_Manual_Call = false;
        return res;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
    [HarmonyReversePatch]
    public static SpecialGuestsController SpawnSpecialGuestGroup_Original(
        GuestsManager __instance,
        int id,
        SpecialGuestsController.GuestSpawnType guestSpawnType,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = null,
        Il2CppSystem.Action<GuestGroupController> onGuestLeave = null,
        GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
        bool recordIzakaya = true,
        int targetDeskCode = -1,
        bool tryToJumpQueue = false,
        Il2CppSystem.Action<Common.CharacterUtility.AStarInputGeneratorComponent> postProcessCharacterCallback = null,
        bool shouldFade = true)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyReversePatch]
    public static bool TrySendToSeat_Original(
        object __instance,
        GuestGroupController toTry,
        bool firstSpawn,
        int targetDeskCode,
        bool shouldOrder)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch("PatientDepletedLeave")]
    [HarmonyReversePatch]
    public static void PatientDepletedLeave_Original(
        GuestsManager __instance,
        GuestGroupController toPatientDepletedLeave)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch("LeaveFromDesk")]
    [HarmonyReversePatch]
    public static void LeaveFromDesk_Original(
        GuestsManager __instance,
        GuestGroupController toLeave,
        GuestGroupController.LeaveType leaveType,
        Il2CppSystem.Action leaveAction,
        bool triggerLeaveBuff)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch("GenerateOrderSession")]
    [HarmonyReversePatch]
    public static void GenerateOrderSession_Original(
        GuestsManager __instance,
        GuestGroupController guestGroup,
        bool doContinue)
    {
        throw new NotImplementedException();
    }
}

using System;
using MemoryPack;
using SgrYuki.Utils;

using NightScene.GuestManagementUtility;

using static MetaMystia.WorkSceneManager;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 全体玩家：广播 GuestFSM 状态转移事件。
/// 客机收到后根据 EventType 重放对应的游戏操作。
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class GuestFSMEventAction : Action
{
    public override ActionType Type => ActionType.GUEST_FSM_EVENT;

    public string UUID { get; set; }
    public GuestFSM.EventType EventType { get; set; }

    // === 条件性负载，按 EventType 选择性填充 ===

    /// <summary> Spawned: 顾客身份信息 </summary>
    [MemoryPackAllowSerialize]
    public GuestInfo SpawnInfo { get; set; }

    /// <summary> SeatMoveStarted: 桌号 </summary>
    public int DeskCode { get; set; } = -1;

    /// <summary> SeatMoveStarted: 座位号 </summary>
    public int DeskSeatCode { get; set; } = -1;

    /// <summary> OrderOpened / ContinueOrderOpened: 订单数据 </summary>
    public GuestOrder Order { get; set; }

    /// <summary> OrderOpened: 订单生成日志 </summary>
    public string OrderMessage { get; set; }

    /// <summary> Leave 相关: 离开原因 </summary>
    public GuestFSM.LeaveReason LeaveReason { get; set; }

    /// <summary> 是否为首次入座 (TrySendToSeat firstSpawn 参数) </summary>
    public bool FirstSpawn { get; set; }


    [CheckScene(Common.UI.Scene.WorkScene)]
    [DiscardOnStory]
    public override void OnReceivedDerived()
    {
        // 仅客机执行重放
        if (MpManager.IsHost) return;

        switch (EventType)
        {
            case GuestFSM.EventType.Spawned:
                OnSpawned();
                break;
            case GuestFSM.EventType.SeatMoveStarted:
                OnSeatMoveStarted();
                break;
            case GuestFSM.EventType.QueueEntered:
                // 排队由 Spawn 后的原版逻辑自然处理，无需额外操作
                break;
            case GuestFSM.EventType.OrderOpened:
            case GuestFSM.EventType.ContinueOrderOpened:
                OnOrderOpened();
                break;
            case GuestFSM.EventType.Repelled:
                OnRepelled();
                break;
            case GuestFSM.EventType.PatienceExpiredAtDesk:
                OnPatienceExpired();
                break;
            case GuestFSM.EventType.QueueTimedOut:
                OnQueueTimedOut();
                break;
            case GuestFSM.EventType.ContinueStopped:
            case GuestFSM.EventType.LeaveStarted:
                OnLeaveStarted();
                break;
            default:
                Log.Info($"GuestFSMEvent {EventType} for {UUID} — no client replay needed");
                break;
        }
    }

    private void OnSpawned()
    {
        if (SpawnInfo == null) { Log.Error($"GuestFSMEvent Spawned: SpawnInfo is null for {UUID}"); return; }

        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () => !MpManager.InStory,
            executeInfo: $"FSMEvent.Spawned: {UUID}, special={SpawnInfo.IsSpecial}",
            execute: () =>
            {
                var fsm = GetOrCreateGuestFSM(UUID);
                SpawnGuestGroup(SpawnInfo, UUID);
            },
            timeoutSeconds: 60
        );
    }

    private void OnSeatMoveStarted()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState is GuestFSM.State.Constructed or GuestFSM.State.Queued
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.SeatMoveStarted: {UUID}, desk={DeskCode}, seat={DeskSeatCode}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) { Log.Error($"SeatMoveStarted: fsm null for {UUID}"); return; }
                var guest = fsm.GuestController;
                if (guest == null) { Log.Error($"SeatMoveStarted: guest null for {fsm.Identifier}"); return; }

                SetGuestDeskcodeSeat(UUID, DeskSeatCode);
                var seated = MetaMystia.Patch.GuestsManagerPatch.TrySendToSeat_Original(
                    GuestsManager.Instance, guest, FirstSpawn, DeskCode, true);
                if (!seated)
                    Log.Error($"SeatMoveStarted: TrySendToSeat failed for {fsm.Identifier}, desk={DeskCode}");
            },
            timeoutSeconds: 10
        );
    }

    private void OnOrderOpened()
    {
        if (Order == null) { Log.Error($"GuestFSMEvent OrderOpened: Order is null for {UUID}"); return; }

        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState is GuestFSM.State.SeatMoving or GuestFSM.State.SeatedDelay
                        or GuestFSM.State.WaitingServe or GuestFSM.State.ContinueDecision
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.OrderOpened: {UUID}, food={Order.RequestFoodIdOrTag}, bev={Order.RequestBevIdOrTag}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) { Log.Error($"OrderOpened: fsm null for {UUID}"); return; }
                var guest = fsm.GuestController;
                if (guest == null) { Log.Error($"OrderOpened: guest null for {fsm.Identifier}"); return; }

                try
                {
                    var allGuests = guest.GetAllGuests()?.ToIl2CppReferenceArray();
                    if (allGuests == null || allGuests.Length == 0)
                    {
                        Log.Error($"OrderOpened: GetAllGuests null/empty for {fsm.Identifier}");
                        return;
                    }
                    GuestsManager.OrderBase orderData = guest.ControllType == GuestsManager.GuestType.Special
                        ? Order.ToSpecialOrder(allGuests[0].Pointer)
                        : Order.ToNormalOrder(allGuests[0]);
                    ClientGenerateOrderSession(guest, orderData, OrderMessage);
                    DelayedSafeAddMaxPatient(guest);
                }
                catch (System.Exception ex)
                {
                    Log.Error($"OrderOpened: error for {fsm.Identifier}: {ex.Message}");
                }
            },
            timeoutSeconds: 30
        );
    }

    private void OnRepelled()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState is not (GuestFSM.State.Leaving or GuestFSM.State.Left or GuestFSM.State.None)
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.Repelled: {UUID}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) return;
                var guest = fsm.GuestController;
                if (guest == null) return;

                fsm.SafeLeaveFromDesk();
            },
            timeoutSeconds: 15
        );
    }

    private void OnPatienceExpired()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState == GuestFSM.State.WaitingServe
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.PatienceExpired: {UUID}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) return;
                var guest = fsm.GuestController;
                if (guest == null) return;

                MetaMystia.Patch.GuestsManagerPatch.PatientDepletedLeave_Original(
                    GuestsManager.Instance, guest);
            },
            timeoutSeconds: 15
        );
    }

    private void OnQueueTimedOut()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState == GuestFSM.State.Queued
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.QueueTimedOut: {UUID}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) return;
                var guest = fsm.GuestController;
                if (guest == null) return;

                guest.MoveToSpawn();
            },
            timeoutSeconds: 15
        );
    }

    private void OnLeaveStarted()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () =>
            {
                var fsm = UUID.GetGuestFSM();
                return fsm != null
                    && fsm.CurrentState is not (GuestFSM.State.Left or GuestFSM.State.None)
                    && !MpManager.InStory;
            },
            executeInfo: $"FSMEvent.LeaveStarted: {UUID}, reason={LeaveReason}",
            execute: () =>
            {
                var fsm = UUID.GetGuestFSM();
                if (fsm == null) return;

                if (IsGuestNull(UUID))
                {
                    Log.Warning($"LeaveStarted: {fsm.Identifier} is invalid, removing");
                    fsm.RemoveInvalidGuest();
                    return;
                }

                fsm.SafeLeaveFromDesk();
            },
            timeoutSeconds: 15
        );
    }

    // === 主机侧发送辅助方法 ===

    public static void Send(string uuid, GuestFSM.EventType eventType, Action<GuestFSMEventAction> configure = null)
    {
        if (!MpManager.IsConnected) return;
        if (!MpManager.IsHost) return;

        var action = new GuestFSMEventAction
        {
            UUID = uuid,
            EventType = eventType
        };
        configure?.Invoke(action);
        action.SendToHostOrBroadcast();
    }

    public static void SendSpawn(string uuid, GuestInfo guestInfo)
    {
        Send(uuid, GuestFSM.EventType.Spawned, a => a.SpawnInfo = guestInfo);
    }

    public static void SendSeatMove(string uuid, int deskCode, int deskSeatCode = -1, bool firstSpawn = false)
    {
        Send(uuid, GuestFSM.EventType.SeatMoveStarted, a =>
        {
            a.DeskCode = deskCode;
            a.DeskSeatCode = deskSeatCode;
            a.FirstSpawn = firstSpawn;
        });
    }

    public static void SendOrder(string uuid, GuestOrder order, string message = null, bool isContinue = false)
    {
        Send(uuid, isContinue ? GuestFSM.EventType.ContinueOrderOpened : GuestFSM.EventType.OrderOpened, a =>
        {
            a.Order = order;
            a.OrderMessage = message;
        });
    }

    public static void SendLeave(string uuid, GuestFSM.LeaveReason reason, GuestFSM.EventType eventType = GuestFSM.EventType.LeaveStarted)
    {
        Send(uuid, eventType, a => a.LeaveReason = reason);
    }

    public static void SendRepel(string uuid)
    {
        Send(uuid, GuestFSM.EventType.Repelled);
    }

    public static void SendQueueTimedOut(string uuid)
    {
        Send(uuid, GuestFSM.EventType.QueueTimedOut);
    }

    public static void SendPatienceExpired(string uuid)
    {
        Send(uuid, GuestFSM.EventType.PatienceExpiredAtDesk);
    }
}

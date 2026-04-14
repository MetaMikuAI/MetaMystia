using System;
using System.Collections.Generic;

using NightScene.GuestManagementUtility;

using static NightScene.GuestManagementUtility.GuestsManager;

namespace MetaMystia;

[AutoLog]
public partial class GuestFSM
{
    public enum State
    {
        None,               // 尚未接收到任何顾客生命周期事件
        Constructed,        // 控制器已创建，但还未确定入队还是入座
        Queued,             // 正在等待位排队，尚未占桌
        SeatMoving,         // 已分配桌位，角色正在移动到座位
        SeatedDelay,        // 已落座，处于首单前的短暂延时
        WaitingServe,       // 订单已打开，正在等待料理和酒水送达
        Evaluating,         // 已开始评价，本单不再接受服务
        ContinueDecision,   // 评价结束，正在决定续单还是离开
        Leaving,            // 已开始离桌，正在收尾
        Left,               // 实体已彻底离开场景，本轮生命周期结束
        Manual,             // 手动顾客轨道，由外部脚本驱动
    }

    public enum EventType
    {
        Spawned,                // 自动顾客已生成并进入 FSM
        ManualCreated,          // 手动顾客已创建并进入手动轨道
        QueueEntered,           // 顾客进入等待队列
        QueueTimedOut,          // 排队耐心耗尽，直接放弃离开
        SeatMoveStarted,        // 已决定入座，开始向桌位移动
        Seated,                 // 已真正落座
        FirstOrderDelayStarted, // 落座后首单前的 Await 延时开始
        OrderOpened,            // 新订单已创建，进入待上菜状态
        OrderPartiallyServed,   // 本单只送达了一部分
        OrderFulfilled,         // 本单料理和酒水都已送齐
        EvaluationStarted,      // 开始评价，本单不再接受服务
        EvaluationFinished,     // 评价逻辑完成，进入后续判定
        ContinueOrderOpened,    // 评价后决定续单，并成功开出下一单
        ContinueStopped,        // 评价后决定不再续单，准备离开
        PatienceExpiredAtDesk,  // 桌上耐心耗尽，强制离场
        Repelled,               // 被驱赶或等价的强制赶走
        LeaveStarted,           // 开始离桌/离场收尾
        LeaveCompleted,         // 实体已完全离开场景
        ManualOrderOpened,      // 手动顾客打开订单
        ManualLeaveStarted,     // 手动顾客开始离场
        Reset,                  // 清空当前 FSM，回到初始状态
    }

    public enum LeaveReason
    {
        Unknown,              // 原因未知，只知道开始离开
        NotContinue,          // 评价后不续单，正常收尾离开
        NoMoney,              // 因资金不足无法继续
        ExceedEndurance,      // 特殊顾客超出耐受阈值离开
        PatientDepletedQueue, // 排队耐心耗尽离开
        PatientDepletedDesk,  // 桌上耐心耗尽离开
        Repelled,             // 被玩家或系统驱赶离开
        PayAndLeave,          // 正常付款后离开
        Manual,               // 由外部脚本手动结束
        Cleanup,              // 清理、回收、纠错时强制结束
    }

    public readonly record struct Event(
        EventType Type,
        int DeskCode = -1,
        int DeskSeatCode = -1,
        bool FoodServed = false,
        bool BeverageServed = false,
        LeaveReason? Reason = null,
        string Source = null
    );

    public readonly record struct Transition(
        State From,
        State To,
        Event Event,
        bool Accepted
    );

    private readonly string _guestUUID;

    private State _state = State.None;
    private Transition _lastTransition;
    private LeaveReason? _leaveReason;
    private bool _hasCompletedFirstEvaluation;
    private bool _isManual;

    private GuestGroupController _guestController;
    private WorkSceneManager.GuestInfo _guestInfo;
    private IntPtr _guestControllerPointer;
    private int _deskCode = -1;
    private int _deskSeatCode = -1;
    private (bool foodServed, bool beverageServed) _orderFulfilled;
    private string _cachedGuestName;

    public GuestFSM(string guestUUID)
    {
        _guestUUID = guestUUID;
        Reset();
    }

    public string GuestUUID => _guestUUID;
    public State CurrentState => _state;
    public Transition LastTransition => _lastTransition;
    public LeaveReason? CurrentLeaveReason => _leaveReason;
    public bool HasCompletedFirstEvaluation => _hasCompletedFirstEvaluation;
    public bool IsManual => _isManual;

    public GuestGroupController GuestController => _guestController;
    public WorkSceneManager.GuestInfo GuestInfo => _guestInfo;
    public IntPtr GuestControllerPointer => _guestControllerPointer;
    public int DeskCode => _deskCode;
    public int DeskSeatCode => _deskSeatCode;
    public (bool foodServed, bool beverageServed) OrderFulfilled => _orderFulfilled;

    public string GuestName
    {
        get
        {
            if (_cachedGuestName != null) return _cachedGuestName;
            try
            {
                string name = GuestController?.OnGetGuestName();
                if (name != null) _cachedGuestName = name;
                return name;
            }
            catch
            {
                return _cachedGuestName ?? "<destroyed>";
            }
        }
    }

    public GuestType GuestType
    {
        get
        {
            try
            {
                return GuestController?.ControllType ?? GuestType.Normal;
            }
            catch
            {
                return GuestType.Normal;
            }
        }
    }

    public string Identifier => $"{GuestName}-{GuestUUID}-[{DeskCode + 1}]";

    public void StoreGuest(GuestGroupController guest)
    {
        _guestController = guest;
        _guestControllerPointer = guest.Pointer;
    }

    public void StoreGuestInfo(WorkSceneManager.GuestInfo guestInfo)
    {
        _guestInfo = guestInfo;
    }

    public void SetDeskCode(int deskCode)
    {
        _deskCode = deskCode;
    }

    public void SetDeskSeatCode(int seatCode)
    {
        _deskSeatCode = seatCode;
    }

    public void SetOrderServedFood()
    {
        _orderFulfilled = (true, _orderFulfilled.beverageServed);
    }

    public void SetOrderServedBeverage()
    {
        _orderFulfilled = (_orderFulfilled.foodServed, true);
    }

    public void SetOrderFulfilled()
    {
        _orderFulfilled = (true, true);
    }

    public void ResetOrderServed()
    {
        _orderFulfilled = (false, false);
    }

    public bool IsOrderFoodServed() => _orderFulfilled.foodServed;
    public bool IsOrderBeverageServed() => _orderFulfilled.beverageServed;
    public bool IsOrderFulfilled() => _orderFulfilled.foodServed && _orderFulfilled.beverageServed;

    public bool IsGuestValid()
    {
        try
        {
            if (_guestController == null) return false;
            if (_guestController.guestInstances == null) return false;
            for (int i = 0; i < _guestController.guestInstances.Length; i++)
            {
                if (_guestController.guestInstances[i] == null) return false;
            }
            return true;
        }
        catch (NullReferenceException)
        {
            Log.Error($"{GuestUUID} guest controller invalid, likely due to guest destruction. Marking as invalid.");
            return false;
        }
    }

    public void Reset()
    {
        _state = State.None;
        _lastTransition = default;
        _leaveReason = null;
        _hasCompletedFirstEvaluation = false;
        _isManual = false;
        _orderFulfilled = (false, false);
    }

    // TODO: Seated 事件目前没有精确 hook —— OnArrive 位于编译器生成的 DisplayClass，
    //       字段访问困难，当前由 FirstOrder 触发时直接跳过 SeatedDelay 合并到 WaitingServe。
    //       后续可尝试 hook __c__DisplayClass295_0.Method_Internal_Void_PDM_0 并读取 __4__this 字段。
    // TODO: LeaveCompleted 事件目前没有 hook —— 需要拦截 OnCompletelyLeaveCallback
    //       或监控 GuestGroupController 实体销毁来精确触发 Leaving → Left 转移。
    private static readonly Dictionary<(State, EventType), State> _matrix = new()
    {
        // None
        { (State.None,              EventType.Spawned),                State.Constructed },
        { (State.None,              EventType.ManualCreated),          State.Manual },

        // Constructed
        { (State.Constructed,       EventType.QueueEntered),           State.Queued },
        { (State.Constructed,       EventType.SeatMoveStarted),        State.SeatMoving },
        { (State.Constructed,       EventType.LeaveStarted),           State.Leaving },
        { (State.Constructed,       EventType.LeaveCompleted),         State.Left },

        // Queued
        { (State.Queued,            EventType.SeatMoveStarted),        State.SeatMoving },
        { (State.Queued,            EventType.QueueTimedOut),          State.Leaving },
        { (State.Queued,            EventType.Repelled),               State.Leaving },
        { (State.Queued,            EventType.LeaveStarted),           State.Leaving },
        { (State.Queued,            EventType.LeaveCompleted),         State.Left },

        // SeatMoving
        { (State.SeatMoving,        EventType.Seated),                 State.SeatedDelay },
        { (State.SeatMoving,        EventType.FirstOrderDelayStarted), State.SeatedDelay },
        { (State.SeatMoving,        EventType.Repelled),               State.Leaving },
        { (State.SeatMoving,        EventType.LeaveStarted),           State.Leaving },
        { (State.SeatMoving,        EventType.LeaveCompleted),         State.Left },

        // SeatedDelay
        { (State.SeatedDelay,       EventType.OrderOpened),            State.WaitingServe },
        { (State.SeatedDelay,       EventType.Repelled),               State.Leaving },
        { (State.SeatedDelay,       EventType.LeaveStarted),           State.Leaving },
        { (State.SeatedDelay,       EventType.LeaveCompleted),         State.Left },

        // WaitingServe
        { (State.WaitingServe,      EventType.OrderPartiallyServed),   State.WaitingServe },
        { (State.WaitingServe,      EventType.OrderFulfilled),         State.WaitingServe },
        { (State.WaitingServe,      EventType.EvaluationStarted),      State.Evaluating },
        { (State.WaitingServe,      EventType.PatienceExpiredAtDesk),  State.Leaving },
        { (State.WaitingServe,      EventType.Repelled),               State.Leaving },
        { (State.WaitingServe,      EventType.LeaveStarted),           State.Leaving },
        { (State.WaitingServe,      EventType.LeaveCompleted),         State.Left },

        // Evaluating
        { (State.Evaluating,        EventType.EvaluationFinished),     State.ContinueDecision },
        { (State.Evaluating,        EventType.LeaveStarted),           State.Leaving },
        { (State.Evaluating,        EventType.LeaveCompleted),         State.Left },

        // ContinueDecision
        { (State.ContinueDecision,  EventType.ContinueOrderOpened),    State.WaitingServe },
        { (State.ContinueDecision,  EventType.ContinueStopped),        State.Leaving },
        { (State.ContinueDecision,  EventType.LeaveStarted),           State.Leaving },
        { (State.ContinueDecision,  EventType.LeaveCompleted),         State.Left },

        // Leaving
        { (State.Leaving,           EventType.LeaveStarted),           State.Leaving },
        { (State.Leaving,           EventType.LeaveCompleted),         State.Left },

        // Left: 不接受任何事件

        // Manual
        { (State.Manual,            EventType.ManualOrderOpened),       State.Manual },
        { (State.Manual,            EventType.ManualLeaveStarted),     State.Leaving },
        { (State.Manual,            EventType.LeaveStarted),           State.Leaving },
        { (State.Manual,            EventType.LeaveCompleted),         State.Left },
    };

    public void Apply(Event evt)
    {
        if (evt.Type == EventType.Reset)
        {
            Reset();
            return;
        }

        State from = _state;
        bool accepted = _matrix.TryGetValue((_state, evt.Type), out State to);

        if (accepted)
        {
            ApplyEventData(evt);
            _state = to;
        }
        else
        {
            to = from;
        }

        _lastTransition = new Transition(from, to, evt, accepted);

        if (accepted)
        {
            if (from != to)
            {
                Log.Message($"FSM {from} -> {to} by {evt.Type} ({evt.Source ?? "unknown"}) [{Identifier}]");
            }
        }
        else
        {
            Log.Error($"FSM rejected {evt.Type} in {_state} [{Identifier}]");
        }
    }

    private void ApplyEventData(Event evt)
    {
        if (evt.DeskCode != -1) _deskCode = evt.DeskCode;
        if (evt.DeskSeatCode != -1) _deskSeatCode = evt.DeskSeatCode;

        switch (evt.Type)
        {
            case EventType.Spawned:
                _isManual = false;
                _leaveReason = null;
                _hasCompletedFirstEvaluation = false;
                _orderFulfilled = (false, false);
                break;

            case EventType.ManualCreated:
                _isManual = true;
                _leaveReason = null;
                _hasCompletedFirstEvaluation = false;
                _orderFulfilled = (false, false);
                break;

            case EventType.OrderOpened:
            case EventType.ContinueOrderOpened:
            case EventType.ManualOrderOpened:
                _orderFulfilled = (false, false);
                break;

            case EventType.OrderPartiallyServed:
                _orderFulfilled = (
                    evt.FoodServed || _orderFulfilled.foodServed,
                    evt.BeverageServed || _orderFulfilled.beverageServed
                );
                break;

            case EventType.OrderFulfilled:
                _orderFulfilled = (true, true);
                break;

            case EventType.EvaluationFinished:
                _hasCompletedFirstEvaluation = true;
                break;

            case EventType.QueueTimedOut:
            case EventType.PatienceExpiredAtDesk:
            case EventType.Repelled:
            case EventType.LeaveStarted:
            case EventType.ManualLeaveStarted:
                _leaveReason = evt.Reason ?? _leaveReason;
                break;
        }
    }

    // 便捷入口，给 patch / hook 直接调用
    public void OnSpawned() => Apply(new Event(EventType.Spawned, Source: nameof(OnSpawned)));
    public void OnManualCreated() => Apply(new Event(EventType.ManualCreated, Source: nameof(OnManualCreated)));
    public void OnQueueEntered() => Apply(new Event(EventType.QueueEntered, Source: nameof(OnQueueEntered)));
    public void OnQueueTimedOut() => Apply(new Event(EventType.QueueTimedOut, Reason: LeaveReason.PatientDepletedQueue, Source: nameof(OnQueueTimedOut)));
    public void OnSeatMoveStarted(int deskCode = -1, int deskSeatCode = -1) => Apply(new Event(EventType.SeatMoveStarted, deskCode, deskSeatCode, Source: nameof(OnSeatMoveStarted)));
    public void OnSeated(int deskCode = -1, int deskSeatCode = -1) => Apply(new Event(EventType.Seated, deskCode, deskSeatCode, Source: nameof(OnSeated)));
    public void OnFirstOrderDelayStarted() => Apply(new Event(EventType.FirstOrderDelayStarted, Source: nameof(OnFirstOrderDelayStarted)));
    public void OnOrderOpened(int deskCode = -1) => Apply(new Event(EventType.OrderOpened, deskCode, Source: nameof(OnOrderOpened)));
    public void OnOrderPartiallyServed(bool foodServed, bool beverageServed) => Apply(new Event(EventType.OrderPartiallyServed, FoodServed: foodServed, BeverageServed: beverageServed, Source: nameof(OnOrderPartiallyServed)));
    public void OnOrderFulfilled() => Apply(new Event(EventType.OrderFulfilled, FoodServed: true, BeverageServed: true, Source: nameof(OnOrderFulfilled)));
    public void OnEvaluationStarted() => Apply(new Event(EventType.EvaluationStarted, Source: nameof(OnEvaluationStarted)));
    public void OnEvaluationFinished() => Apply(new Event(EventType.EvaluationFinished, Source: nameof(OnEvaluationFinished)));
    public void OnContinueOrderOpened(int deskCode = -1) => Apply(new Event(EventType.ContinueOrderOpened, deskCode, Source: nameof(OnContinueOrderOpened)));
    public void OnContinueStopped(LeaveReason reason = LeaveReason.NotContinue) => Apply(new Event(EventType.ContinueStopped, Reason: reason, Source: nameof(OnContinueStopped)));
    public void OnPatienceExpiredAtDesk() => Apply(new Event(EventType.PatienceExpiredAtDesk, Reason: LeaveReason.PatientDepletedDesk, Source: nameof(OnPatienceExpiredAtDesk)));
    public void OnRepelled() => Apply(new Event(EventType.Repelled, Reason: LeaveReason.Repelled, Source: nameof(OnRepelled)));
    public void OnLeaveStarted(LeaveReason reason = LeaveReason.Unknown) => Apply(new Event(EventType.LeaveStarted, Reason: reason, Source: nameof(OnLeaveStarted)));
    public void OnLeaveCompleted() => Apply(new Event(EventType.LeaveCompleted, Source: nameof(OnLeaveCompleted)));
    public void OnManualOrderOpened(int deskCode = -1) => Apply(new Event(EventType.ManualOrderOpened, deskCode, Source: nameof(OnManualOrderOpened)));
    public void OnManualLeaveStarted(LeaveReason reason = LeaveReason.Manual) => Apply(new Event(EventType.ManualLeaveStarted, Reason: reason, Source: nameof(OnManualLeaveStarted)));
}

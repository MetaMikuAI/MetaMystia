using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using NightScene.GuestManagementUtility;
using static NightScene.GuestManagementUtility.GuestsManager;

namespace MetaMystia;

[AutoLog]
public partial class GuestFSM
{
    /// <summary>
    /// 状态机转移图：
    /// Null -> PendingGenerate -> Generated -> Seated -> PendingOrder -> OrderGenerated -> OrderEvaluated
    ///                                                      ^                    ^             |
    ///                                                      |____________________|_____________|
    ///
    /// Generated/Seated/PendingOrder/OrderGenerated/OrderEvaluated -> Left
    /// </summary>

    // ============= FSM 状态机相关 =============
    private string _guestUUID;
    private WorkSceneManager.Status _currentState;
    private Dictionary<WorkSceneManager.Status, FSMState> _states;

    // ============= Guest 数据存储 =============
    private GuestGroupController _guestController;
    private WorkSceneManager.GuestInfo _guestInfo;
    private IntPtr _guestControllerPointer;
    private int _deskCode = -1;
    private int _deskSeatCode = -1;
    private (bool foodServed, bool beverageServed) _orderFulfilled = (false, false);
    private ConcurrentQueue<(OrderBase, string)> _orders = new();

    public GuestFSM(string guestUUID)
    {
        _guestUUID = guestUUID;
        _currentState = WorkSceneManager.Status.Null;
        _states = [];
        InitializeStates();
    }

    private void InitializeStates()
    {
        _states[WorkSceneManager.Status.Null] = new NullState(this);
        _states[WorkSceneManager.Status.Left] = new LeftState(this);
        _states[WorkSceneManager.Status.PendingGenerate] = new PendingGenerateState(this);
        _states[WorkSceneManager.Status.Generated] = new GeneratedState(this);
        _states[WorkSceneManager.Status.Seated] = new SeatedState(this);
        _states[WorkSceneManager.Status.PendingOrder] = new PendingOrderState(this);
        _states[WorkSceneManager.Status.OrderGenerated] = new OrderGeneratedState(this);
        _states[WorkSceneManager.Status.OrderEvaluated] = new OrderEvaluatedState(this);
    }

    public WorkSceneManager.Status CurrentState => _currentState;
    public string GuestUUID => _guestUUID;
    public GuestGroupController GuestController => _guestController;
    public WorkSceneManager.GuestInfo GuestInfo => _guestInfo;
    public int DeskCode => _deskCode;
    public int DeskSeatCode => _deskSeatCode;
    public (bool foodServed, bool beverageServed) OrderFulfilled => _orderFulfilled;

    private FSMState fSMState => _states[_currentState];

    // ============= 数据访问方法 =============

    /// <summary>
    /// 存储客人控制器
    /// </summary>
    public void StoreGuest(GuestGroupController guest)
    {
        _guestController = guest;
        _guestControllerPointer = guest.Pointer;
    }

    /// <summary>
    /// 存储客人信息
    /// </summary>
    public void StoreGuestInfo(WorkSceneManager.GuestInfo guestInfo)
    {
        _guestInfo = guestInfo;
    }

    /// <summary>
    /// 设置座位代码
    /// </summary>
    public void SetDeskCode(int deskCode)
    {
        _deskCode = deskCode;
    }

    /// <summary>
    /// 设置座位座号
    /// </summary>
    public void SetDeskSeatCode(int seatCode)
    {
        _deskSeatCode = seatCode;
    }

    /// <summary>
    /// 入队订单
    /// </summary>
    public void EnqueueOrder(OrderBase order, string orderMessage)
    {
        _orders.Enqueue((order, orderMessage));
    }

    /// <summary>
    /// 出队订单
    /// </summary>
    public bool DequeueOrder(out (OrderBase, string) orderTuple)
    {
        return _orders.TryDequeue(out orderTuple);
    }

    /// <summary>
    /// 设置食物已提供
    /// </summary>
    public void SetOrderServedFood()
    {
        _orderFulfilled = (true, _orderFulfilled.beverageServed);
    }

    /// <summary>
    /// 设置饮品已提供
    /// </summary>
    public void SetOrderServedBeverage()
    {
        _orderFulfilled = (_orderFulfilled.foodServed, true);
    }

    /// <summary>
    /// 设置订单全部完成
    /// </summary>
    public void SetOrderFulfilled()
    {
        _orderFulfilled = (true, true);
    }

    /// <summary>
    /// 重置订单提供状态
    /// </summary>
    public void ResetOrderServed()
    {
        _orderFulfilled = (false, false);
    }

    /// <summary>
    /// 获取食物是否已提供
    /// </summary>
    public bool IsOrderFoodServed()
    {
        return _orderFulfilled.foodServed;
    }

    /// <summary>
    /// 获取饮品是否已提供
    /// </summary>
    public bool IsOrderBeverageServed()
    {
        return _orderFulfilled.beverageServed;
    }

    /// <summary>
    /// 获取订单是否全部完成
    /// </summary>
    public bool IsOrderFulfilled()
    {
        return _orderFulfilled.foodServed && _orderFulfilled.beverageServed;
    }

    /// <summary>
    /// 检查客人是否有效
    /// </summary>
    public bool IsGuestValid()
    {
        if (_guestController == null) return false;
        if (_guestController.guestInstances == null) return false;
        for (int i = 0; i < _guestController.guestInstances.Length; i++)
        {
            if (_guestController.guestInstances[i] == null) return false;
        }
        return true;
    }

    public void ChangeState(WorkSceneManager.Status newState)
    {
        if (_currentState == newState) return;

        fSMState.OnExit();
        Log.Message($"{Identifier} FSM state changed {_currentState} -> {newState}");
        _currentState = newState;

        fSMState.OnEnter();
    }

    public string Identifier => $"{GuestController?.OnGetGuestName()}-{GuestUUID}-[{DeskCode + 1}]";

    public void Update()
    {
        fSMState.OnUpdate();
    }

    /// <summary>
    /// 尝试转移到客人已生成状态
    /// </summary>
    public void TryGenerateGuest() => fSMState.TryGenerateGuest();

    /// <summary>
    /// 尝试将客人安排到座位
    /// </summary>
    public void TrySeated() => fSMState.TrySeated();

    /// <summary>
    /// 尝试让客人进入点餐待处理状态
    /// </summary>
    public void TryPendingOrder() => fSMState.TryPendingOrder();

    /// <summary>
    /// 尝试生成客人订单
    /// </summary>
    public void TryGenerateOrder() => fSMState.TryGenerateOrder();

    /// <summary>
    /// 尝试提供食物或饮品
    /// </summary>
    public void TryServeOrder() => fSMState.TryServeOrder();

    /// <summary>
    /// 尝试让客人离开
    /// </summary>
    public void TryLeave() => fSMState.TryLeave();

    /// <summary>
    /// 将客人置为空
    /// </summary>
    public void SetNull() => fSMState.SetNull();

    public abstract class FSMState(GuestFSM fsm)
    {
        protected GuestFSM _fsm = fsm;

        private void LogInvalidTry() => Log.Error($"{_fsm.Identifier} state {_fsm.CurrentState} invalid call {Log.GetOuterCallerName()}");

        public virtual void OnEnter() { }
        public virtual void OnUpdate() { }
        public virtual void OnExit() { }

        /// <summary>
        /// 尝试转移到客人已生成状态
        /// </summary>
        public virtual void TryGenerateGuest() => LogInvalidTry();

        /// <summary>
        /// 尝试将客人安排到座位
        /// </summary>
        public virtual void TrySeated() => LogInvalidTry();

        /// <summary>
        /// 尝试让客人进入点餐待处理状态
        /// </summary>
        public virtual void TryPendingOrder() => LogInvalidTry();

        /// <summary>
        /// 尝试生成客人订单
        /// </summary>
        public virtual void TryGenerateOrder() => LogInvalidTry();

        /// <summary>
        /// 尝试提供食物或饮品
        /// </summary>
        public virtual void TryServeOrder() => LogInvalidTry();

        /// <summary>
        /// 尝试让客人离开
        /// </summary>
        public virtual void TryLeave() => LogInvalidTry();

        /// <summary>
        /// 将客人置为空
        /// </summary>
        public void SetNull()
        {
            Log.Error($"{_fsm.GuestUUID} setting state from {_fsm.CurrentState} to {WorkSceneManager.Status.Null}!");
            _fsm.ChangeState(WorkSceneManager.Status.Null);
        }
    }

    /// <summary>
    /// 空状态 - 客人不存在或已销毁
    /// </summary>
    public class NullState : FSMState
    {
        public NullState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered Null state");
        }

        public override void TryGenerateGuest()
        {
            _fsm.ChangeState(WorkSceneManager.Status.PendingGenerate);
        }
    }

    /// <summary>
    /// 待生成状态 - 主机已生成，等待客户端确认
    /// </summary>
    public class PendingGenerateState : FSMState
    {
        public PendingGenerateState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered PendingGenerate state");
        }

        public override void TrySeated()
        {
            Log.ErrorCaller($"{_fsm.Identifier} attempted to seat while in PendingGenerate, ignored");
        }

        public override void TryGenerateGuest()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Generated);
        }
    }

    /// <summary>
    /// 已生成状态 - 客人已生成，等待安排座位
    /// </summary>
    public class GeneratedState : FSMState
    {
        public GeneratedState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered Generated state");
        }

        public override void TrySeated()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Seated);
        }

        public override void TryLeave()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Left);
        }
    }

    /// <summary>
    /// 已座位状态 - 客人已坐下，等待点餐
    /// </summary>
    public class SeatedState : FSMState
    {
        public SeatedState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered Seated state");
        }

        public override void TryPendingOrder()
        {
            _fsm.ChangeState(WorkSceneManager.Status.PendingOrder);
        }

        public override void TryLeave()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Left);
        }
    }

    /// <summary>
    /// 点餐待处理状态 - 客户端请求点餐，等待主机生成订单
    /// </summary>
    public class PendingOrderState : FSMState
    {
        public PendingOrderState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered PendingOrder state");
        }

        public override void TryGenerateOrder()
        {
            _fsm.ChangeState(WorkSceneManager.Status.OrderGenerated);
        }

        public override void TryLeave()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Left);
        }
    }

    /// <summary>
    /// 订单已生成状态 - 订单已生成，等待提供食物/饮品
    /// </summary>
    public class OrderGeneratedState : FSMState
    {
        public OrderGeneratedState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered OrderGenerated state");
        }

        public override void TryServeOrder()
        {
            _fsm.ChangeState(WorkSceneManager.Status.OrderEvaluated);
        }

        public override void TryPendingOrder()
        {
            Log.InfoCaller($"{_fsm.Identifier} already generated order");
        }

        public override void TryLeave()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Left);
        }
    }

    /// <summary>
    /// 订单已评价状态 - 食物/饮品已提供，评价中或继续点餐
    /// </summary>
    public class OrderEvaluatedState : FSMState
    {
        public OrderEvaluatedState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.Debug($"{_fsm.Identifier} entered OrderEvaluated state");
        }

        public override void TryPendingOrder()
        {
            // 有新订单
            _fsm.ChangeState(WorkSceneManager.Status.PendingOrder);
        }

        public override void TryGenerateOrder()
        {
            _fsm.ChangeState(WorkSceneManager.Status.OrderGenerated);
        }

        public override void TryServeOrder()
        {
            Log.InfoCaller($"{_fsm.Identifier} order already evaluated");
        }

        public override void TryLeave()
        {
            _fsm.ChangeState(WorkSceneManager.Status.Left);
        }
    }

    /// <summary>
    /// 已离开状态 - 客人已离开
    /// </summary>
    public class LeftState : FSMState
    {
        public LeftState(GuestFSM fsm) : base(fsm) { }

        public override void OnEnter()
        {
            Log.LogInfo($"{_fsm.Identifier} entered Left state, guest has left");
        }
    }
}

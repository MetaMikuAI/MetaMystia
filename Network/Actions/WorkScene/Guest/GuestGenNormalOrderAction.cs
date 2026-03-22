using MemoryPack;
using System;

using GameData.Core.Collections.NightSceneUtility;

namespace MetaMystia.Network;

/// <summary>
/// 主机(房主) → 全体玩家：通告某个普通顾客生成了普通订单
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class GuestGenNormalOrderAction : Action
{
    public override ActionType Type => ActionType.GUEST_GEN_NORMAL_ORDER;
    public string GuestUUID { get; set; }

    public GuestOrder Order { get; set; }
    public string Message { get; set; }


    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        var fsm = GuestUUID.GetGuestFSM();
        if (fsm != null && !fsm.IsGuestValid())
        {
            string exeInvalidInfo = $"{fsm.Identifier} is invalid, try leaving";
            WorkSceneManager.EnqueueGuestCommand(
                key: GuestUUID,
                executeWhen: () => !MpManager.InStory,
                execute: () =>
                {
                    Log.Warning(exeInvalidInfo);
                    fsm.TryLeave();
                    fsm.RemoveInvalidGuest();
                    GuestLeaveAction.Send(fsm.GuestUUID, GuestLeaveAction.LeaveType.LeaveFromDesk);
                },
                executeInfo: exeInvalidInfo,
                timeoutSeconds: 30
            );
            Log.Error($"{fsm.Identifier} invalid, will force it leave and not execute gen order");
            return;
        }
        string exeInfo = $"Gen normal order: guid {GuestUUID}, order food {Order.RequestFoodIdOrTag}, bev {Order.RequestFoodIdOrTag}";

        bool executeWhen() => WorkSceneManager.CheckStatusIn(GuestUUID, [WorkSceneManager.Status.PendingOrder, WorkSceneManager.Status.OrderEvaluated]) && !MpManager.InStory;

        void executeGenOrder()
        {
            var fsm = WorkSceneManager.GetGuestFSM(GuestUUID);
            if (fsm == null) { Log.Error($"GenNormalOrder: fsm null for {GuestUUID}"); return; }
            var guest = fsm.GuestController;
            if (guest == null) { Log.Error($"GenNormalOrder: guest null for {fsm.Identifier}"); return; }
            var allGuests = guest.GetAllGuests();
            if (allGuests == null) { Log.Error($"GenNormalOrder: GetAllGuests null for {fsm.Identifier}"); return; }
            var array = allGuests.TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            if (array == null || array.Length == 0) { Log.Error($"GenNormalOrder: allGuests cast/empty for {fsm.Identifier}"); return; }
            var normalOrder = Order.ToNormalOrder(array[0]);
            // fsm.EnqueueOrder(normalOrder, Message);

            try
            {
                // GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);
                WorkSceneManager.ClientGenerateOrderSession(guest, normalOrder, Message);
                WorkSceneManager.DelayedSafeAddMaxPatient(guest);
                fsm.ResetOrderServed();
                fsm.TryGenerateOrder();
            }
            catch (Exception ex)
            {
                Log.Error($"error in generating order for {fsm.Identifier}, reason {ex.Message}, {ex.StackTrace}");
                // if (ex.Message.Contains("AddOrderImpl::Unable to add order") && maxExecuteCount < 1)
                // {
                //     Log.Error($"error in generating order for {GuestUUID}, try execute again");
                //     executeGenOrder(maxExecuteCount + 1);
                // }
            }
        }

        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: executeWhen,
            execute: executeGenOrder,
            executeInfo: exeInfo,
            timeoutSeconds: 30,
            onTimeout: () =>
            {
                if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Seated) && !MpManager.InStory)
                {
                    executeGenOrder();
                }
            }
        );
    }

    public static void Send(string GuestUUID, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodId, requestBevId, deskCode, notShowInUI, isFree);
        var action = new GuestGenNormalOrderAction
        {
            GuestUUID = GuestUUID,
            Order = order,
            Message = message
        };
        action.SendToHostOrBroadcast();
    }
}

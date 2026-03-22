using MemoryPack;
using System;

using GameData.Core.Collections.NightSceneUtility;

namespace MetaMystia.Network;

/// <summary>
/// 主机(房主) → 全体玩家：通告某个稀客生成了特殊订单
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class GuestGenSPOrderAction : Action
{
    public override ActionType Type => ActionType.GUEST_GEN_SPECIAL_ORDER;
    public string GuestUUID { get; set; }
    public GuestOrder Order { get; set; }
    public string Message { get; set; }

    [CheckScene(Common.UI.Scene.WorkScene)]
    [ExecuteAfterStory]
    public override void OnReceivedDerived()
    {
        void executeGenOrder()
        {
            var fsm = WorkSceneManager.GetGuestFSM(GuestUUID);
            if (fsm == null) { Log.Error($"GenSPOrder: fsm null for {GuestUUID}"); return; }
            var guest = fsm.GuestController;
            if (guest == null) { Log.Error($"GenSPOrder: guest null for {fsm.Identifier}"); return; }
            var allGuests = guest.GetAllGuests();
            if (allGuests == null) { Log.Error($"GenSPOrder: GetAllGuests null for {fsm.Identifier}"); return; }
            var array = allGuests.TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            if (array == null || array.Length == 0) { Log.Error($"GenSPOrder: allGuests cast/empty for {fsm.Identifier}"); return; }
            var SPOrder = Order.ToSpecialOrder(array[0].Pointer);
            // fsm.EnqueueOrder(SPOrder, Message);

            try
            {
                // GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);
                WorkSceneManager.ClientGenerateOrderSession(guest, SPOrder, Message);

                WorkSceneManager.DelayedSafeAddMaxPatient(guest);

                fsm.ResetOrderServed();
                fsm.TryGenerateOrder();
            }
            catch (Exception ex)
            {
                Log.Error($"error in generating order for {fsm.Identifier}, reason {ex.Message}, {ex.StackTrace}");
            }
        }
        ;
        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: () => WorkSceneManager.CheckStatusIn(GuestUUID, [WorkSceneManager.Status.PendingOrder, WorkSceneManager.Status.OrderEvaluated]) && !MpManager.InStory,
            executeInfo: $"Gen SP order: guid {GuestUUID}, order food {Order.RequestFoodIdOrTag}, bev {Order.RequestFoodIdOrTag} ",
            execute: executeGenOrder,
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

    public static void Send(string GuestUUID, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodTag, requestBevTag, deskCode, notShowInUI, isFree);
        var action = new GuestGenSPOrderAction
        {
            GuestUUID = GuestUUID,
            Order = order,
            Message = message
        };
        action.SendToHostOrBroadcast();
    }
}


using System;
using GameData.Core.Collections.NightSceneUtility;
using MemoryPack;
using NightScene.GuestManagementUtility;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class GuestGenSPOrderAction : SendAffectStoryAction
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
            var guest = fsm.GuestController;
            var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            var SPOrder = Order.ToSpecialOrder(array[0].Pointer);
            fsm.EnqueueOrder(SPOrder, Message);

            try
            {
                GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);

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


using System;
using GameData.Core.Collections.NightSceneUtility;
using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestGenSPOrderAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_GEN_SPECIAL_ORDER;
    public string GuestUUID { get; set; }
    public GuestOrder Order { get; set; }
    public string Message { get; set; }

    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene)
        {
            return;
        }

        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: () => WorkSceneManager.CheckStatusIn(GuestUUID, [WorkSceneManager.Status.PendingOrder, WorkSceneManager.Status.OrderEvaluated]) && !MpManager.InStory,
            executeInfo: $"Gen SP order: guid {GuestUUID}, order food {Order.RequestFoodIdOrTag}, bev {Order.RequestFoodIdOrTag} ",
            execute: () =>
            {
                var guest = WorkSceneManager.GetGuest(GuestUUID);
                var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
                var SPOrder = Order.ToSpecialOrder(array[0].Pointer);
                WorkSceneManager.orders.Enqueue((SPOrder, Message));

                try
                {
                    GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);

                    WorkSceneManager.DelayedSafeAddMaxPatient(guest);

                    WorkSceneManager.ResetGuestOrderServed(GuestUUID);
                    WorkSceneManager.SetGuestStatus(GuestUUID, WorkSceneManager.Status.OrderGenerated);
                }
                catch (Exception ex)
                {
                    Log.Error($"error in generating order for {GuestUUID}, reason {ex.Message}, {ex.StackTrace}");
                }
            },
            timeoutSeconds: 30
         );
    }

    public static void Send(string GuestUUID, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodTag, requestBevTag, deskCode, notShowInUI, isFree);
        NetPacket packet = new([new GuestGenSPOrderAction
        {
            GuestUUID = GuestUUID,
            Order = order,
            Message = message
        }]);
        SendToHostOrBroadcast(packet);
    }
}


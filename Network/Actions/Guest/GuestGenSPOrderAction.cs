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
    public string GuestUniqId { get; set; }
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

        CommandScheduler.Enqueue(
            executeWhen: () => NightGuestManager.CheckStatusInOrThrow(GuestUniqId, [NightGuestManager.Status.PendingOrder, NightGuestManager.Status.OrderEvaluated]),
            execute: () =>
            {
                var guest = NightGuestManager.GetGuest(GuestUniqId);
                var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
                var SPOrder = Order.ToSpecialOrder(array[0].Pointer);
                NightGuestManager.orders.Enqueue((SPOrder, Message));

                try
                {
                    GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);
                    const int PatientSecs = 30;
                    guest.SetPatient(Math.Min(guest.CurrentPatient + PatientSecs, guest.MaxPatient));


                    NightGuestManager.ResetGuestOrderServed(GuestUniqId);
                    NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.OrderGenerated);
                }
                catch (Exception ex)
                {
                    Log.LogWarning($"error in generating normal order for {GuestUniqId}, reason {ex.Message}, {ex.StackTrace}");
                }
            }
         );
    }

    public static void Send(string guestUniqId, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodTag, requestBevTag, deskCode, notShowInUI, isFree);
        NetPacket packet = new([new GuestGenSPOrderAction
        {
            GuestUniqId = guestUniqId,
            Order = order,
            Message = message
        }]);
        SendToPeer(packet);
    }
}


using System;
using GameData.Core.Collections.NightSceneUtility;
using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestGenNormalOrderAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_GEN_NORMAL_ORDER;
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

        string exeInfo = $"Gen normal order: guid {GuestUUID}, order food {Order.RequestFoodIdOrTag}, bev {Order.RequestFoodIdOrTag}";

        bool executeWhen() => WorkSceneManager.CheckStatusIn(GuestUUID, [WorkSceneManager.Status.PendingOrder, WorkSceneManager.Status.OrderEvaluated]) && !MpManager.InStory;

        void executeGenOrder(int maxExecuteCount)
        {
            var guest = WorkSceneManager.GetGuest(GuestUUID);
            var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            var normalOrder = Order.ToNormalOrder(array[0]);
            WorkSceneManager.orders.Enqueue((normalOrder, Message));

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
                if (ex.Message.Contains("AddOrderImpl::Unable to add order") && maxExecuteCount < 1)
                {
                    Log.Error($"error in generating order for {GuestUUID}, try execute again");
                    executeGenOrder(maxExecuteCount + 1);
                }
            }
        }

        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: executeWhen,
            execute: () => executeGenOrder(0),
            executeInfo: exeInfo,
            timeoutSeconds: 30
        );
    }

    public static void Send(string GuestUUID, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, string message)
    {
        var order = new GuestOrder(requestFoodId, requestBevId, deskCode, notShowInUI, isFree);
        NetPacket packet = new([new GuestGenNormalOrderAction
        {
            GuestUUID = GuestUUID,
            Order = order,
            Message = message
        }]);
        SendToHostOrBroadcast(packet);
    }

}


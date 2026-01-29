using MemoryPack;
using NightScene.GuestManagementUtility;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class GuestLeaveAction : SendAffectStoryAction
{
    public override ActionType Type => ActionType.GUEST_LEAVE;

    public enum LeaveType
    {
        PayAndLeave,            // Host only
        ExBadLeave,             // Host only
        RepelAndLeavePay,       // Both ok
        RepelAndLeaveNoPay,     // Both ok
        PatientDepletedLeave,   // Host only
        PlayerRepel,            // Both ok
        LeaveFromDesk,          // the last function if all above failed, Host only
        LeaveFromQueue          // Both ok
        // FIXME: Any other leave method?
    }

    public string GuestUUID { get; set; }
    public LeaveType LType { get; set; }


    [CheckScene(Common.UI.Scene.WorkScene)]
    [ExecuteAfterStory]
    public override void OnReceivedDerived()
    {
        if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Left))
        {
            Log.Info($"{GuestUUID.GetGuestFSM()?.Identifier} already left, skip");
            return;
        }
        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: () => WorkSceneManager.CheckStatusGreaterOrThrow(GuestUUID, WorkSceneManager.Status.Generated) && !MpManager.InStory,
            executeInfo: $"Leave: guid {GuestUUID}, type {LType}",
            execute: () =>
            {
                var fsm = WorkSceneManager.GetGuestFSM(GuestUUID);
                var guest = fsm.GuestController;
                if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Left))
                {
                    return;
                }

                if (GuestsManager.instance == null)
                {
                    Log.Error($"GuestsManager.instance is null! Action : {ToString()}");
                    return;
                }
                if (guest == null)
                {
                    Log.Error($"guest is null! Action : {ToString()}");
                    return;
                }
                if (!fsm.IsGuestValid())
                {
                    Log.Error($"{fsm.Identifier} is invalid! Action : {ToString()}");
                    fsm.RemoveInvalidGuest();
                    return;
                }
                var deskcode = guest.DeskCode;
                fsm.TryLeave();

                switch (LType)
                {
                    case LeaveType.PayAndLeave:
                        if (guest.IsFirst)
                        {
                            WorkSceneManager.ShowNoMoneyDialog(guest);
                        }
                        GuestsManagerPatch.PayAndLeave_Original(GuestsManager.instance, guest, true);
                        break;
                    case LeaveType.ExBadLeave:
                        GuestsManagerPatch.ExBadLeave_Original(GuestsManager.instance, guest);
                        break;
                    case LeaveType.RepelAndLeavePay:
                        GuestsManagerPatch.RepellAndLeavePay_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, true);
                        break;
                    case LeaveType.RepelAndLeaveNoPay:
                        GuestsManagerPatch.RepellAndLeaveNoPay_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, true);
                        break;
                    case LeaveType.PatientDepletedLeave:
                        GuestsManagerPatch.PatientDepletedLeave_Original(GuestsManager.instance, guest);
                        break;
                    case LeaveType.LeaveFromDesk:
                        GuestsManagerPatch.LeaveFromDesk_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, null, true);
                        break;
                    case LeaveType.PlayerRepel:
                        GuestsManagerPatch.PlayerRepell_Original(GuestsManager.instance, guest.DeskCode);
                        break;
                    case LeaveType.LeaveFromQueue:
                        if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Generated))
                        {
                            GuestGroupControllerPatch.MoveToSpawn_Original(guest);
                        }
                        else
                        {
                            Log.Warning($"received {LeaveType.LeaveFromQueue} but {fsm.Identifier} already seated, try repel..");
                            GuestsManagerPatch.RepellAndLeavePay_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, true);
                        }
                        break;
                }
                // Just in case the LeaveFromDesk method fail
                if (WorkSceneManager.GetInDeskGuest(deskcode)?.GetGuestUUID() == GuestUUID)
                {
                    // TODO: use LeaveFromDesk impl
                    Log.Error($"{fsm.Identifier} still in desk, try remove..");
                    fsm.SafeLeaveFromDesk();
                    // WorkSceneManager.RemoveOccupiedDesk(deskcode);
                    // WorkSceneManager.RemoveOrder(guest);
                    // GuestsManager.instance?.registeredCharacterArrivedEvents?.Remove(deskcode);
                }
            },
            timeoutSeconds: 15
         );
    }

    public static void Send(string guest, LeaveType leaveType)
    {
        var action = new GuestLeaveAction
        {
            GuestUUID = guest,
            LType = leaveType
        };
        action.SendToHostOrBroadcast();
    }
}


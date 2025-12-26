using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestLeaveAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_LEAVE;

    public enum LeaveType
    {
        PayAndLeave,            // Host only
        ExBadLeave,             // Host only
        RepellAndLeavePay,      // Both ok
        RepellAndLeaveNoPay,    // Both ok
        PatientDepletedLeave,   // Host only
        PlayerRepell,           // Both ok
        Other                   // LeaveFromDesk as the last function if all above failed, Host only
        // FIXME: Any other leave method? 
    }

    public string GuestUniqId { get; set; }

    public LeaveType LType { get; set; }

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
            canExecute: () => NightGuestManager.CheckStatusGreaterOrThrow(GuestUniqId, NightGuestManager.Status.Generated),
            execute: () =>
            {
                var guest = NightGuestManager.GetGuest(GuestUniqId);
                if (NightGuestManager.CheckStatus(GuestUniqId, NightGuestManager.Status.Left))
                {
                    return;
                }
                NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.Left);
                if (GuestsManager.instance == null)
                {
                    Log.LogError($"GuestsManager.instance is null! Action : {ToString()}");
                }
                switch (LType)
                {
                    case LeaveType.PayAndLeave:
                        GuestsManagerPatch.PayAndLeave_Original(GuestsManager.instance, guest, true);
                        break;
                    case LeaveType.ExBadLeave:
                        GuestsManagerPatch.ExBadLeave_Original(GuestsManager.instance, guest);
                        break;
                    case LeaveType.RepellAndLeavePay:
                        GuestsManagerPatch.RepellAndLeavePay_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, true);
                        break;
                    case LeaveType.RepellAndLeaveNoPay:
                        GuestsManagerPatch.RepellAndLeaveNoPay_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, true);
                        break;
                    case LeaveType.PatientDepletedLeave:
                        GuestsManagerPatch.PatientDepletedLeave_Original(GuestsManager.instance, guest);
                        break;
                    case LeaveType.Other:
                        GuestsManagerPatch.LeaveFromDesk_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, null, true);
                        break;
                    case LeaveType.PlayerRepell:
                        GuestsManagerPatch.PlayerRepell_Original(GuestsManager.instance, guest.DeskCode);
                        break;
                }
            }
         );
    }

}


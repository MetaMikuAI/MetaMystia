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
        RepelAndLeavePay,      // Both ok
        RepelAndLeaveNoPay,    // Both ok
        PatientDepletedLeave,   // Host only
        PlayerRepel,           // Both ok
        Other                   // LeaveFromDesk as the last function if all above failed, Host only
        // FIXME: Any other leave method? 
    }

    public string GuestUUID { get; set; }

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

        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: () => WorkSceneManager.CheckStatusGreaterOrThrow(GuestUUID, WorkSceneManager.Status.Generated) && !MpManager.InStory,
            executeInfo: $"Leave: guid {GuestUUID}, type {LType}",
            execute: () =>
            {
                var guest = WorkSceneManager.GetGuest(GuestUUID);
                if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Left))
                {
                    return;
                }
                WorkSceneManager.SetGuestStatus(GuestUUID, WorkSceneManager.Status.Left);
                if (GuestsManager.instance == null)
                {
                    Log.LogError($"GuestsManager.instance is null! Action : {ToString()}");
                    return;
                }
                if (guest == null)
                {
                    Log.LogError($"guest is null! Action : {ToString()}");
                    return;
                }
                var deskcode = guest.DeskCode;
                switch (LType)
                {
                    case LeaveType.PayAndLeave:
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
                    case LeaveType.Other:
                        GuestsManagerPatch.LeaveFromDesk_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, null, true);
                        break;
                    case LeaveType.PlayerRepel:
                        GuestsManagerPatch.PlayerRepell_Original(GuestsManager.instance, guest.DeskCode);
                        break;
                }
                // Just in case the LeaveFromDesk method fail
                WorkSceneManager.RemoveOccupiedDesk(deskcode);
                WorkSceneManager.RemoveOrder(guest);
                GuestsManager.instance?.registeredCharacterArrivedEvents?.Remove(deskcode);
            },
            timeoutSeconds: 15
         );
    }

    public static void Send(string guest, LeaveType leaveType)
    {
        NetPacket packet = new([new GuestLeaveAction
        {
            GuestUUID = guest,
            LType = leaveType
        }]);
        SendToHostOrBroadcast(packet);
    }
}


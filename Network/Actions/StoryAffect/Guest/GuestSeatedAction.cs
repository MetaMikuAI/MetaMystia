using MemoryPack;
using NightScene.GuestManagementUtility;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestSeatedAction : SendAffectStoryAction
{
    public override ActionType Type => ActionType.GUEST_SEATED;

    public string GuestUUID { get; set; }
    public int DeskId { get; set; }
    public int SeatId { get; set; }
    public bool FirstSpawn { get; set; }


    [CheckScene(Common.UI.Scene.WorkScene)]
    [ExecuteAfterStory]
    public override void OnReceivedDerived()
    {
        string executeInfo = $"Seated: guid {GuestUUID}, DeskId {DeskId}, SeatId {SeatId}";

        bool executeWhen() => ExecuteWhen(GuestUUID, DeskId);

        void onExecute() => Execute(GuestUUID, DeskId, SeatId, FirstSpawn);

        void beforeExecute()
        {
            if (WorkSceneManager.IsGuestNull(GuestUUID))
            {
                Respawn(GuestUUID);
            }
        }


        WorkSceneManager.EnqueueGuestCommand(
            key: GuestUUID,
            executeWhen: executeWhen,
            executeInfo: executeInfo,
            execute: onExecute,
            beforeExecute: beforeExecute,
            timeoutSeconds: 10
        );
    }

    public static void Respawn(string GuestUUID)
    {
        var fsm = WorkSceneManager.GetGuestFSM(GuestUUID);
        fsm.SetNull();
        fsm.TryGenerateGuest();
        WorkSceneManager.SpawnGuestGroup(fsm.GuestInfo, GuestUUID);
        Log.Warning($"Respawned: guid {GuestUUID}");
    }

    public static void Execute(string GuestUUID, int DeskId, int SeatId, bool FirstSpawn)
    {
        var guestTargetDesk = GuestsManager.instance.GetInDeskGuest(DeskId);
        var fsm = WorkSceneManager.GetGuestFSM(GuestUUID);
        var guest = fsm.GuestController;

        if (guestTargetDesk != null && guestTargetDesk != guest)
        {
            var prevFsm = guestTargetDesk.GetGuestFSM();
            Log.Warning($"{fsm.Identifier}, guestTargetDesk not null, will force set previous {prevFsm?.Identifier} out, DeskId {DeskId}, SeatId {SeatId}");
            // WorkSceneManager.RemoveGuestAndOrder(DeskId);
            prevFsm?.SafeLeaveFromDesk();
        }

        WorkSceneManager.SetGuestDeskcodeSeat(GuestUUID, SeatId);

        var seated = GuestsManagerPatch.TrySendToSeat_Original(GuestsManager.instance, guest, FirstSpawn, DeskId, true);
        if (seated)
        {
            fsm.TrySeated();
            WorkSceneManager.SetGuestDeskcode(GuestUUID, guest.DeskCode);
        }
        else
        {
            Log.Error($"try send to seat fail, guest {fsm.Identifier}, DeskId {DeskId}, SeatId {SeatId}");
        }
    }

    public static bool ExecuteWhen(string GuestUUID, int DeskId)
    {
        if (WorkSceneManager.CheckStatus(GuestUUID, WorkSceneManager.Status.Generated) && !MpManager.InStory)
        {
            if (GuestsManager.instance.GetInDeskGuest(DeskId) == null)
            {
                return true;
            }
            if (!GuestsManager.instance.CheckGuestIsInDesk(DeskId))
            {
                return true;
            }
            var guestTargetDesk = WorkSceneManager.GetInDeskGuest(DeskId).GetGuestUUID();
            return WorkSceneManager.GetGuestDeskcode(guestTargetDesk) != DeskId;
        }
        return false;
    }

    public static void Send(string GuestUUID, int deskId, bool firstSpawn, int seatId)
    {
        var action = new GuestSeatedAction
        {
            GuestUUID = GuestUUID,
            DeskId = deskId,
            FirstSpawn = firstSpawn,
            SeatId = seatId
        };
        action.SendToHostOrBroadcast();
    }
}


using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestSeatedAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SEATED;

    public string GuestUUID { get; set; }

    public int DeskId { get; set; }

    public int SeatId { get; set; }

    public bool FirstSpawn { get; set; }

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
        
        string executeInfo = $"Seated: guid {GuestUUID}, DeskId {DeskId}, SeatId {SeatId}";

        bool executeWhen() => ExecuteWhen(GuestUUID, DeskId);

        void onExecute() => Execute(GuestUUID, DeskId, SeatId, FirstSpawn);

        void beforeExecute()
        {
            if (WorkSceneManager.IsGuestNull(GuestUUID))
            {
                respawn();
            }
        }

        void respawn() => Respawn(GuestUUID);

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
        var info = WorkSceneManager.GetGuestInfo(GuestUUID);
        WorkSceneManager.SetGuestStatus(GuestUUID, WorkSceneManager.Status.PendingGenerate);
        WorkSceneManager.SpawnGuestGroup(info, GuestUUID);
        Log.LogWarning($"Respawned: guid {GuestUUID}");
    }

    public static void Execute(string GuestUUID, int DeskId, int SeatId, bool FirstSpawn)
    {
        var guestTargetDesk = GuestsManager.instance.GetInDeskGuest(DeskId);
        var guest = WorkSceneManager.GetGuest(GuestUUID);

        if (guestTargetDesk != null && guestTargetDesk != guest)
        {
            Log.LogWarning($"guest {GuestUUID}, guestTargetDesk not null, will force set previous guest {WorkSceneManager.GetGuestUUID(guestTargetDesk)} out, DeskId {DeskId}, SeatId {SeatId}");
            WorkSceneManager.RemoveGuestAndOrder(DeskId);
        }

        WorkSceneManager.SetGuestDeskcodeSeat(GuestUUID, SeatId);

        var seated = GuestsManagerPatch.TrySendToSeat_Original(GuestsManager.instance, guest, FirstSpawn, DeskId, true);
        if (seated)
        {
            WorkSceneManager.SetGuestStatus(GuestUUID, WorkSceneManager.Status.Seated);
            WorkSceneManager.SetGuestDeskcode(GuestUUID, guest.DeskCode);
        }
        else
        {
            Log.LogError($"try send to seat fail, guest {GuestUUID}, DeskId {DeskId}, SeatId {SeatId}");
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
            var guestTargetDesk = WorkSceneManager.GetGuestUUID(GuestsManager.instance.GetInDeskGuest(DeskId));
            return WorkSceneManager.GetGuestDeskcode(guestTargetDesk) != DeskId;
        }
        return false;
    }
    
    public static void Send(string GuestUUID, int deskId, bool firstSpawn, int seatId)
    {
        NetPacket packet = new([new GuestSeatedAction
        {
            GuestUUID = GuestUUID,
            DeskId = deskId,
            FirstSpawn = firstSpawn,
            SeatId = seatId
        }]);
        SendToHostOrBroadcast(packet);
    }
}


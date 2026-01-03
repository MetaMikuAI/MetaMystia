using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestSeatedAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SEATED;

    public string GuestUniqId { get; set; }

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

        bool executeWhen()
        {
            if (NightGuestManager.CheckStatus(GuestUniqId, NightGuestManager.Status.Generated) && !MpManager.InStory)
            {
                if (GuestsManager.instance.GetInDeskGuest(DeskId) == null)
                {
                    return true;
                }
                if (!GuestsManager.instance.CheckGuestIsInDesk(DeskId))
                {
                    return true;
                }
                var guestTargetDesk = NightGuestManager.GetGuestUUID(GuestsManager.instance.GetInDeskGuest(DeskId));
                return NightGuestManager.GetGuestDeskcodeSeat(guestTargetDesk) != DeskId + 1;
            }
            return false;
        }

        void respawn()
        {
            var info = NightGuestManager.GetGuestInfo(GuestUniqId);
            NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.PendingGenerate);
            NightGuestManager.SpawnGuestGroup(info, GuestUniqId);
            Log.LogWarning($"Seated-Respawned: guid {GuestUniqId}");
        }

        void onExecute()
        {
            var guestTargetDesk = GuestsManager.instance.GetInDeskGuest(DeskId);
            var guest = NightGuestManager.GetGuest(GuestUniqId);

            if (guestTargetDesk != null && guestTargetDesk != guest)
            {
                Log.LogWarning($"guest {GuestUniqId}, guestTargetDesk not null, will force set previous guest {NightGuestManager.GetGuestUUID(guestTargetDesk)} out, DeskId {DeskId}, SeatId {SeatId}");
                GuestsManager.instance.SetGuestOutDesk(guestTargetDesk);
                GuestsManager.instance.occupiedDesks.Remove(DeskId);
            }

            NightGuestManager.SetGuestDeskcodeSeat(GuestUniqId, SeatId);

            var seated = GuestsManagerPatch.TrySendToSeat_Original(GuestsManager.instance, guest, FirstSpawn, DeskId, true);
            if (seated)
            {
                NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.Seated);
                NightGuestManager.SetGuestDeskcode(GuestUniqId, guest.DeskCode);
            } 
            else
            {
                Log.LogError($"try send to seat fail, guest {GuestUniqId}, DeskId {DeskId}, SeatId {SeatId}");
            }

        }

        void beforeExecute()
        {
            if (NightGuestManager.IsGuestNull(GuestUniqId))
            {
                respawn();
            }
        }
        
        CommandScheduler.Enqueue(
            executeWhen: executeWhen,
            executeInfo: $"Seated: guid {GuestUniqId}, DeskId {DeskId}, SeatId {SeatId}",
            execute: onExecute,
            beforeExecute: beforeExecute,
            timeoutSeconds: 15,
            onTimeout: () =>
            {
                if (NightGuestManager.IsGuestNotNull(GuestUniqId))
                {
                    var prev = GuestsManager.instance.GetInDeskGuest(DeskId);
                    Log.LogWarning($"Seated time-out for {GuestUniqId}, will force set previous guest {NightGuestManager.GetGuestUUID(prev)} out: DeskId {DeskId}, SeatId {SeatId}");
                    GuestsManager.instance.SetGuestOutDesk(prev);
                }
                else
                {
                    Log.LogWarning($"Seated time-out for {GuestUniqId}, guest is null, will re-generate");
                    CommandScheduler.Enqueue(
                        executeWhen: () => !MpManager.InStory,
                        executeInfo: $"Seated-Respawned: guid {GuestUniqId}",
                        execute: respawn
                    );
                    CommandScheduler.Enqueue(
                        executeWhen: executeWhen,
                        executeInfo: $"Seated again: guid {GuestUniqId}, DeskId {DeskId}, SeatId {SeatId}",
                        execute: onExecute,
                        timeoutSeconds: 15
                    );
                }
                onExecute();
            }
        );
    }

    public static void Send(string guestUniqId, int deskId, bool firstSpawn, int seatId)
    {
        NetPacket packet = new([new GuestSeatedAction
        {
            GuestUniqId = guestUniqId,
            DeskId = deskId,
            FirstSpawn = firstSpawn,
            SeatId = seatId
        }]);
        SendToPeer(packet);
    }
}


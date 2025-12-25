using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
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


        CommandScheduler.Enqueue(
            canExecute: () => NightGuestManager.CheckStatusOrThrow(GuestUniqId, NightGuestManager.Status.Generated) && GuestsManager.instance.GetInDeskGuest(DeskId) == null,
            execute: () =>
            {
                var guest = NightGuestManager.GetGuest(GuestUniqId);

                NightGuestManager.SetGuestDeskcodeSeat(GuestUniqId, SeatId);

                GuestsManagerPatch.TrySendToSeat_Original(GuestsManager.instance, guest, FirstSpawn, DeskId, true);

                NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.Seated);
                NightGuestManager.SetGuestDeskcode(GuestUniqId, guest.DeskCode);
            });
    }
}


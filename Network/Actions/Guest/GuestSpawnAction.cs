using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;


[MemoryPackable]
public partial class GuestSpawnAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SPAWN;

    public int GuestId { get; set; }
    public int? Guest1Visualid { get; set; }
    public int? GuestId2 { get; set; }
    public int? Guest2Visualid { get; set; }

    public bool IsSpecial { get; set; }

    public string UUID { get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
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
            executeWhen: () => true,
            execute: () =>
            {
                NightGuestManager.SetGuestStatus(UUID, NightGuestManager.Status.PendingGenerate);
                if (IsSpecial)
                {
                    _ = NightGuestManager.SpawnSpecialGuestGroup(GuestId, UUID);
                }
                else
                {
                    _ = NightGuestManager.SpawnNormalGuestGroup(GuestId, UUID, Guest1Visualid, GuestId2, Guest2Visualid);
                }
            });
    }

    public static void Send(int guest, bool isSpecial, string uuid, int? guest1Visualid = null, int? guest2 = null, int? guest2Visualid = null)
    {
        NetPacket packet = new([new GuestSpawnAction
        {
            GuestId = guest,
            IsSpecial = isSpecial,
            UUID = uuid,
            Guest1Visualid = guest1Visualid,
            Guest2Visualid = guest2Visualid,
            GuestId2 = guest2
        }]);
        SendToPeer(packet);
    }

}


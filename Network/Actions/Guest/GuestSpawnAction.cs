using MemoryPack;
using SgrYuki.Utils;
using static MetaMystia.WorkSceneManager;

namespace MetaMystia;


[MemoryPackable]
public partial class GuestSpawnAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SPAWN;

    [MemoryPackAllowSerialize]
    public GuestInfo GuestInfo;
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

        WorkSceneManager.EnqueueGuestCommand(
            key: UUID,
            executeWhen: () => !MpManager.InStory,
            executeInfo: $"Spawned: guid {UUID}, special {GuestInfo.IsSpecial}",
            execute: () =>
            {
                SetGuestStatus(UUID, Status.PendingGenerate);
                SpawnGuestGroup(GuestInfo, UUID);
            },
            timeoutSeconds: 60
        );
    }

    public static void Send(string uuid, GuestInfo guestInfo)
    {
        NetPacket packet = new([new GuestSpawnAction
        {
            UUID = uuid,
            GuestInfo = guestInfo
        }]);
        SendToHostOrBroadcast(packet);
    }
}


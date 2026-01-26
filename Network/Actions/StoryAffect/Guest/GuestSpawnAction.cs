using MemoryPack;
using static MetaMystia.WorkSceneManager;

namespace MetaMystia;


[MemoryPackable]
public partial class GuestSpawnAction : SendAffectStoryAction
{
    public override ActionType Type => ActionType.GUEST_SPAWN;

    [MemoryPackAllowSerialize]
    public GuestInfo GuestInfo;
    public string UUID { get; set; }


    [CheckScene(Common.UI.Scene.WorkScene)]
    [ExecuteAfterStory]
    public override void OnReceivedDerived()
    {
        EnqueueGuestCommand(
            key: UUID,
            executeWhen: () => !MpManager.InStory,
            executeInfo: $"Spawned: guid {UUID}, special {GuestInfo.IsSpecial}",
            execute: () =>
            {
                // 获取或创建FSM，初始化为Null状态
                var fsm = GetOrCreateGuestFSM(UUID);
                // 转移到PendingGenerate状态
                fsm.TryGenerateGuest();
                // 生成客人
                SpawnGuestGroup(GuestInfo, UUID);
            },
            timeoutSeconds: 60
        );
    }

    public static void Send(string uuid, GuestInfo guestInfo)
    {
        var action = new GuestSpawnAction
        {
            UUID = uuid,
            GuestInfo = guestInfo
        };
        action.SendToHostOrBroadcast();
    }
}


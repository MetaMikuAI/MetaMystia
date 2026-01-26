using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

public enum ReadyType
{
    DayOver,
    PrepOver
}

[MemoryPackable]
[AutoLog]
public partial class ReadyAction : NetAction
{
    public override ActionType Type => ActionType.READY;
    public ReadyType ReadyType;
    public bool AllReady = false;
    public override void OnReceivedDerived()
    {
        switch (ReadyType)
        {
            case ReadyType.DayOver:
                if (MpManager.LocalScene != Common.UI.Scene.DayScene)
                {
                    Log.LogWarning("READY action received outside DayScene, ignoring.");
                    return;
                }
                if (AllReady)
                {
                    CommandScheduler.EnqueueWithNoCondition(() => Dialog.ShowReadyDialog(true, DaySceneManagerPatch.OnDayOver));
                    return;
                }
                PeerManager.IsDayOver = true;
                MpManager.DayOver(SenderId);
                Notify.ShowOnMainThread(TextId.ReadyForWork.Get(MpManager.PeerId));
                break;
            case ReadyType.PrepOver:
                if ((MpManager.LocalScene != Common.UI.Scene.IzakayaPrepScene && MpManager.LocalScene != Common.UI.Scene.WorkScene)
                    || (MpManager.LocalScene == Common.UI.Scene.WorkScene && !WorkSceneManager.InHakugyokurouChallenge))   // 白玉楼
                {
                    Log.LogWarning("READY action received outside IzakayaPrepScene, ignoring.");
                    return;
                }

                if (AllReady)
                {
                    CommandScheduler.EnqueueWithNoCondition(IzakayaConfigPannelPatch.PrepOver);
                    return;
                }
                PeerManager.IsPrepOver = true;
                MpManager.PrepOver(SenderId);
                Notify.ShowOnMainThread(TextId.ReadyForWork.Get(MpManager.PeerId));
                break;
            default:
                break;
        }

    }


    public static void Send(ReadyType readyType)
    {
        var action = new ReadyAction { ReadyType = readyType };
        action.SendToHostOrBroadcast();
    }

    public static void Broadcast(ReadyType readyType)
    {
        var action = new ReadyAction { ReadyType = readyType, AllReady = true };
        action.SendToHostOrBroadcast();
    }
}

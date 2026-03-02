using MemoryPack;

using MetaMystia.Patch;
using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

public enum ReadyType
{
    DayOver,
    PrepOver
}

[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class ReadyAction : Action
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
                    CommandScheduler.EnqueueWithNoCondition(() =>
                    {
                        Notify.ShowOnMainThread(TextId.AllReadyTransition.Get());
                        DaySceneManagerPatch.OnDayOver();
                    });
                    return;
                }
                PlayerManager.SetPeerDayOver(SenderUid);
                MpManager.DayOver();
                PlayerManager.Peers.TryGetValue(SenderUid, out var dayPeer);
                Notify.ShowOnMainThread(TextId.ReadyForWork.Get(dayPeer?.Id ?? "???"));
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
                PlayerManager.SetPeerPrepOver(SenderUid);
                MpManager.PrepOver();
                PlayerManager.Peers.TryGetValue(SenderUid, out var prepPeer);
                Notify.ShowOnMainThread(TextId.ReadyForWork.Get(prepPeer?.Id ?? "???"));
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

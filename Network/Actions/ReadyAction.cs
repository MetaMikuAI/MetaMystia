using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class ReadyAction : NetAction
{
    public override ActionType Type => ActionType.READY;
    public bool IsReady {get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        if (MpManager.LocalScene != Common.UI.Scene.DayScene)
        {
            Log.LogWarning("READY action received outside DayScene, ignoring.");
            return;
        }
        KyoukoManager.IsReady = true;
        if (MystiaManager.IsReady)
        {
            PluginManager.Instance.RunOnMainThread(DaySceneManagerPatch.OnDayOver_Original);
        }
        // else: 00->01: Nope
        Log.LogInfo("Kyouko is ready");
        Notify.ShowOnMainThread($"对方已经准备好营业啦！");
    }

    public static void Send()
    {
        NetPacket packet = new([new ReadyAction
        {
            IsReady = true
        }]);
        SendToPeer(packet);
    }
}

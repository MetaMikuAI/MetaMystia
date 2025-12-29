using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class NightSyncAction : NetAction
{
    public override ActionType Type => ActionType.NIGHTSYNC;
    public float Vx {get; set; }
    public float Vy {get; set; }
    public float Px {get; set; }
    public float Py {get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Debug, onlyAction, prefix);
    }
    public override void OnReceived()
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Debug);
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene || MpManager.InStory)
        {
            Log.Info("skipping on received");
            return;
        }
        PluginManager.Instance.RunOnMainThread(() =>
            KyoukoManager.NightSyncFromPeer(new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }

    public static void Send() => SyncAction.Send();
}

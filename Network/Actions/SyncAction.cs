using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class SyncAction : NetAction
{
    public override ActionType Type => ActionType.SYNC;
    public float Vx {get; set; }
    public float Vy {get; set; }
    public float Px {get; set; }
    public float Py {get; set; }
    public bool IsSprinting{get; set;}
    public string MapLabel {get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Debug, onlyAction, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Debug);
        if (MpManager.LocalScene != Common.UI.Scene.DayScene || MpManager.InStory)
        {
            Log.Info("skipping on received");
            return;
        }
        PluginManager.Instance.RunOnMainThread(() =>
            KyoukoManager.SyncFromPeer(MapLabel, IsSprinting,
                new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }

    // Also send nightsync
    public static void Send()
    {
        if (!MpManager.IsConnected)
        {
            return;
        }
        if (MpManager.InStory || (MpManager.LocalScene != Common.UI.Scene.DayScene && MpManager.LocalScene != Common.UI.Scene.WorkScene))
        {
            Log.Info("skipping send");
            return;
        }

        var inputDirection = MystiaManager.InputDirection;
        var position = MystiaManager.GetPosition();

        NetPacket packet;
        if (MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            packet = new NetPacket([new NightSyncAction
            {
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                Px = position.x,
                Py = position.y
            }]);
        }
        else
        {
            var mapLabel = MystiaManager.MapLabel;
            var isSprinting = MystiaManager.IsSprinting;

            packet = new NetPacket([new SyncAction
            {
                IsSprinting = isSprinting,
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                MapLabel = mapLabel,
                Px = position.x,
                Py = position.y
            }]);
        }

        SendToPeer(packet);
    }
}

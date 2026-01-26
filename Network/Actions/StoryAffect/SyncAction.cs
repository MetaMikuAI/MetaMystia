using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class SyncAction : AffectStoryAction
{
    public override ActionType Type => ActionType.SYNC;
    public float Vx { get; set; }
    public float Vy { get; set; }
    public float Px { get; set; }
    public float Py { get; set; }
    public bool IsSprinting { get; set; }
    public string MapLabel { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;

    [CheckScene(Common.UI.Scene.DayScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
            PeerManager.SyncFromPeer(MapLabel, IsSprinting,
                new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }

    // Also send nightsync
    public static void Send()
    {
        if (MpManager.LocalScene != Common.UI.Scene.DayScene && MpManager.LocalScene != Common.UI.Scene.WorkScene)
        {
            Log.Debug("skipping send");
            return;
        }

        var inputDirection = MystiaManager.InputDirection;
        var position = MystiaManager.Position;

        if (MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            var action = new NightSyncAction
            {
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                Px = position.x,
                Py = position.y
            };
            action.SendToHostOrBroadcast();
        }
        else
        {
            var mapLabel = MystiaManager.MapLabel;
            var isSprinting = MystiaManager.IsSprinting;

            var action = new SyncAction
            {
                IsSprinting = isSprinting,
                Vx = inputDirection.x,
                Vy = inputDirection.y,
                MapLabel = mapLabel,
                Px = position.x,
                Py = position.y
            };
            action.SendToHostOrBroadcast();
        }
    }
}

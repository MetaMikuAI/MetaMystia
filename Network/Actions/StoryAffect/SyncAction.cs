using System;
using MemoryPack;
using UnityEngine;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class SyncAction : AffectStoryAction
{
    public override ActionType Type => ActionType.SYNC;
    public Guid guid { get; set; }
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
            PlayerManager.Peers[guid].SyncFromPeer(MapLabel, IsSprinting, // TODO: 安全一点？
                new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }

    // Also send nightsync
    public static void Send()
    {
        if (!MpManager.IsConnected)
        {
            return;
        }
        if (MpManager.LocalScene != Common.UI.Scene.DayScene && MpManager.LocalScene != Common.UI.Scene.WorkScene)
        {
            return;
        }

        var inputDirection = PlayerManager.LocalInputDirection;
        var position = PlayerManager.LocalPosition;

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
            var mapLabel = PlayerManager.LocalMapLabel;
            var isSprinting = PlayerManager.LocalIsSprinting;

            var action = new SyncAction
            {
                guid = PlayerManager.Local.Guid,
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

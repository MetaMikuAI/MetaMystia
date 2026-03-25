using System;
using MemoryPack;
using UnityEngine;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 全体玩家：通告角色移动同步，主要是白天。
/// </summary>
[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class SyncAction : Action
{
    public override ActionType Type => ActionType.SYNC;
    public float Vx { get; set; }
    public float Vy { get; set; }
    public float Px { get; set; }
    public float Py { get; set; }
    public bool IsSprinting { get; set; }
    public float Speed { get; set; }
    public string MapLabel { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;

    [CheckScene(Common.UI.Scene.DayScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (PlayerManager.Peers.TryGetValue(SenderUid, out var peer))
                peer.SyncFromPeer(MapLabel, IsSprinting, Speed,
                    new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py));
        });
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
        if (!PlayerManager.CharacterSpawnedAndInitialized)
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
                Py = position.y,
                Speed = PlayerManager.Local.Speed
            };
            action.SendToHostOrBroadcast();
        }
        else
        {
            var mapLabel = PlayerManager.LocalMapLabel;
            var isSprinting = PlayerManager.LocalIsSprinting;
            var speed = PlayerManager.Local.Speed;

            var action = new SyncAction
            {
                IsSprinting = isSprinting,
                Speed = speed,
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

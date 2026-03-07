using MemoryPack;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 全体玩家：夜间角色移动同步
/// </summary>
[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class NightSyncAction : Action
{
    public override ActionType Type => ActionType.NIGHTSYNC;
    public float Vx { get; set; }
    public float Vy { get; set; }
    public float Px { get; set; }
    public float Py { get; set; }
    public float Speed { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Debug;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Debug;

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (PlayerManager.Peers.TryGetValue(SenderUid, out var peer))
                peer.NightSyncFromPeer(Speed, new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py));
        });
    }

    public static void Send() => SyncAction.Send();

    public new void SendToHostOrBroadcast() => base.SendToHostOrBroadcast();
}

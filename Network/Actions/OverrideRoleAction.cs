using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class OverrideRoleAction : Action
{
    public override ActionType Type => ActionType.OVERRIDE_ROLE;
    public MpManager.ROLE Role { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        var prev = MpManager.OverrideRole;
        MpManager.OverrideRole = Role;
        Log.Message($"OverrideRole changed by peer: {prev.ToString() ?? "null"} -> {Role.ToString() ?? "null"}");
        Notify.ShowOnMainThread($"联机系统：对方设置了你的应用层角色为 {Role.ToString() ?? "跟随传输层"}");
    }

    /// <summary>
    /// Send an override role command to the peer.
    /// </summary>
    /// <param name="role">null = clear override, Host/Client = set override</param>
    public static void Send(MpManager.ROLE role)
    {
        new OverrideRoleAction { Role = role }.SendToHostOrBroadcast();
    }
}

using MemoryPack;
using SgrYuki;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class OverrideRoleAction : Action
{
    public override ActionType Type => ActionType.OVERRIDE_ROLE;

    /// <summary>
    /// The role to override on the receiving side. null means clear override (follow transport role).
    /// Encoded as: 0 = null, 1 = Host, 2 = Client.
    /// </summary>
    public byte RoleValue { get; set; }

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        MpManager.ROLE? role = RoleValue switch
        {
            1 => MpManager.ROLE.Host,
            2 => MpManager.ROLE.Client,
            _ => null,
        };
        var prev = MpManager.OverrideRole;
        MpManager.OverrideRole = role;
        Log.Message($"OverrideRole changed by peer: {prev?.ToString() ?? "null"} -> {role?.ToString() ?? "null"}");
        Notify.ShowOnMainThread($"联机系统：对方设置了你的应用层角色为 {role?.ToString() ?? "跟随传输层"}");
    }

    /// <summary>
    /// Send an override role command to the peer.
    /// </summary>
    /// <param name="role">null = clear override, Host/Client = set override</param>
    public static void Send(MpManager.ROLE? role)
    {
        byte val = role switch
        {
            MpManager.ROLE.Host => 1,
            MpManager.ROLE.Client => 2,
            _ => 0,
        };
        new OverrideRoleAction { RoleValue = val }.SendToHostOrBroadcast();
    }
}

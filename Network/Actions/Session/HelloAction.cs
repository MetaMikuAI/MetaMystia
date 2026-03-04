using MemoryPack;

using Common.UI;

using MetaMystia.UI;

namespace MetaMystia.Network;

/// <summary>
/// 客机 → 主机：握手请求。主机验证后回复 HelloAckAction。
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class HelloAction : Action
{
    public override ActionType Type => ActionType.HELLO;
    public string PeerId { get; set; } = "";
    public string Version { get; set; } = "";
    public string GameVersion { get; set; } = "";
    public Scene CurrentGameScene { get; set; }
    public ResourceDataBase PeerDataBase { get; set; } // TODO: 数据可能过大，考虑做优化

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;
    public new void LogActionSend() => base.LogActionSend();

    /// <summary>
    /// 仅主机处理：验证客机，分配 UID，回复 HelloAck，通告已有客机
    /// </summary>
    public override void OnReceivedDerived()
    {
        if (!MpManager.IsHost)
        {
            Log.LogWarning("Hello received by non-host, ignoring");
            return;
        }

        // --- 版本校验 ---
        if (Version != Plugin.ModVersion)
        {
            Log.LogError($"Mod version mismatch! Local: {Plugin.ModVersion}, Remote: {Version}");
            // TODO: RejectAction
            MpManager.DisconnectClient(SenderUid);
            return;
        }

        if (GameVersion != Plugin.GameVersion)
        {
            Log.LogError($"Game version mismatch! Local: {Plugin.GameVersion}, Remote: {GameVersion}");
            // TODO: RejectAction
            MpManager.DisconnectClient(SenderUid);
            return;
        }

        // --- 备菜/营业阶段不允许重连 ---
        if (MpManager.LocalScene == Scene.IzakayaPrepScene || MpManager.LocalScene == Scene.WorkScene)
        {
            Log.LogWarning($"Rejecting connection from '{PeerId}' (uid={SenderUid}): " +
                $"reconnection not allowed in {MpManager.LocalScene}");
            Notify.ShowOnMainThread(TextId.PrepWorkReconnectBlocked.Get(PeerId));
            MpManager.DisconnectClient(SenderUid);
            return;
        }

        int assignedUid = SenderUid;

        var peer = PlayerManager.AddPeer(assignedUid, PeerId, PeerDataBase);

        // 如果主机当前在 DayScene，则为新加入的 peer 立即生成角色
        if (MpManager.LocalScene == Scene.DayScene)
        {
            peer.ResetMotion();
            peer.SpawnForScene();
        }

        // 向新客机发送 HelloAck（携带分配的 UID + 所有已有 peer 信息）
        HelloAckAction.SendTo(assignedUid, PeerId);

        // 向所有已有客机通告新玩家加入
        PeerJoinAction.BroadcastExcept(assignedUid, PeerId, PeerDataBase);

        // 启动同步
        MpManager.OnPeerHandshakeComplete(assignedUid, PeerId);

        Notify.ShowOnMainThread(TextId.MpConnected.Get(PeerId));
    }

    /// <summary>
    /// 客机发送 Hello 给主机请求连接
    /// </summary>
    public static void Send()
    {
        new HelloAction
        {
            PeerId = MpManager.PlayerId,
            Version = Plugin.ModVersion,
            CurrentGameScene = MpManager.LocalScene,
            GameVersion = Plugin.GameVersion,
            PeerDataBase = PlayerManager.Local.DataBase
        }.SendToHostOrBroadcast();
    }
}

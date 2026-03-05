using MemoryPack;

using MetaMystia.UI;

namespace MetaMystia.Network;

/// <summary>
/// 主机 → 客机：握手确认，携带分配的 UID 和现有所有 peer 信息
/// </summary>
[MemoryPackable]
[AutoLog]
public partial class HelloAckAction : Action
{
    public override ActionType Type => ActionType.HELLO_ACK;
    public int AssignedUid { get; set; }

    /// <summary>
    /// 主机信息（uid=0）
    /// </summary>
    public PlayerInfo HostInfo { get; set; }

    /// <summary>
    /// 已有 peer 列表（不含新加入者自身和主机）
    /// </summary>
    public PlayerInfo[] ExistingPeers { get; set; } = [];

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;

    /// <summary>
    /// 客机处理：设置自身 UID，注册主机和已有 peer
    /// </summary>
    public override void OnReceivedDerived()
    {
        if (MpManager.IsHost)
        {
            Log.LogWarning("HelloAck received by host, ignoring");
            return;
        }

        // 设置本地 UID
        PlayerManager.Local.Uid = AssignedUid;
        Log.LogMessage($"Assigned UID: {AssignedUid}");

        // 注册主机为 peer (uid=0)
        var hostPeer = PlayerManager.AddPeer(0, HostInfo.PeerId, HostInfo.DataBase);

        // 注册已有的其他 peer
        foreach (var p in ExistingPeers)
        {
            PlayerManager.AddPeer(p.Uid, p.PeerId, p.DataBase);
        }

        // 如果当前在 DayScene（重连），立即为所有 peer 生成角色
        if (MpManager.LocalScene == Common.UI.Scene.DayScene)
        {
            PlayerManager.SpawnPeers();
        }

        MpManager.OnHandshakeComplete(HostInfo.PeerId);
        Notify.ShowOnMainThread(TextId.MpConnected.Get(HostInfo.PeerId));
        SkinManager.OnPeerJoined();
    }

    /// <summary>
    /// 主机向指定客机发送 HelloAck
    /// </summary>
    public static void SendTo(int clientUid, string clientPeerId)
    {
        // 收集已有 peer（不含新加入者自身）
        var existingPeers = new System.Collections.Generic.List<PlayerInfo>();
        foreach (var kvp in PlayerManager.Peers)
        {
            if (kvp.Key == clientUid) continue; // 不发自己
            existingPeers.Add(new PlayerInfo
            {
                Uid = kvp.Key,
                PeerId = kvp.Value.Id,
                DataBase = kvp.Value.DataBase
            });
        }

        var hostInfo = new PlayerInfo
        {
            Uid = 0,
            PeerId = PlayerManager.Local.Id,
            DataBase = PlayerManager.Local.DataBase
        };

        new HelloAckAction
        {
            AssignedUid = clientUid,
            HostInfo = hostInfo,
            ExistingPeers = existingPeers.ToArray()
        }.SendToClient(clientUid);
    }
}

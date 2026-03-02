using MemoryPack;

using MetaMystia.Patch;
using MetaMystia.UI;

namespace MetaMystia.Network;

[MemoryPackable]
[HostRelay]
public partial class SelectAction : Action
{
    public override ActionType Type => ActionType.SELECT;
    public string MapLabel { get; set; } = "";
    public int MapLevel { get; set; } = 0;
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            PlayerManager.SetPeerIzakayaSelection(SenderUid, MapLabel, MapLevel);

            PlayerManager.Peers.TryGetValue(SenderUid, out var senderPeer);
            var peerName = senderPeer?.Id ?? "???";
            Notify.ShowOnMainThread(TextId.PeerSelectedIzakaya.Get(
                $"{peerName}", $"{Utils.GetMapLabelNameCN(MapLabel)} {Utils.GetMapLevelNameCN(MapLevel)}"));

            // 主机收到 SELECT 后自动检查全员是否一致
            if (MpManager.IsHost)
            {
                IzakayaSelectorPanelPatch.TryConfirmSelection();
            }
        });
    }

    public static void Send(string mapLabel, int level)
    {
        new SelectAction
        {
            MapLabel = mapLabel,
            MapLevel = level
        }.SendToHostOrBroadcast();
    }
}

using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
public partial class SelectAction : Action
{
    public override ActionType Type => ActionType.SELECT;
    public string MapLabel { get; set; } = "";
    public int MapLevel { get; set; } = 0;
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            PeerManager.IzakayaMapLabel = MapLabel;
            PeerManager.IzakayaLevel = MapLevel;

            Notify.ShowOnMainThread(TextId.PeerSelectedIzakaya.Get($"{Utils.GetMapLabelNameCN(MapLabel)} {Utils.GetMapLevelNameCN(MapLevel)}"));
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

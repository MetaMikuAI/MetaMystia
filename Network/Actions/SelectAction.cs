using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class SelectAction : NetAction
{
    public override ActionType Type => ActionType.SELECT;
    public string MapLabel { get; set; } = "";
    public int MapLevel { get; set; } = 0;
    public override void OnReceived()
    {
        LogActionReceived();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            KyoukoManager.IzakayaMapLabel = MapLabel;
            KyoukoManager.IzakayaLevel = MapLevel;

            Dialog.ShowInformDialog(MapLabel, MapLevel, null);
        });
    }

    public static void Send(string mapLabel, int level)
    {
        NetPacket packet = new([new SelectAction
        {
            MapLabel = mapLabel,
            MapLevel = level
        }]);
        SendToPeer(packet);
    }
}

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

            Notify.ShowOnMainThread($"对方选择了 {Utils.GetMapLabelNameCN(MapLabel)} {Utils.GetMapLevelNameCN(MapLevel)} 作为开店地点");
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

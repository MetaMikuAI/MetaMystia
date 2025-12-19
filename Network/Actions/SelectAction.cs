using MemoryPack;
using Common.UI;

namespace MetaMystia;

[MemoryPackable]
public partial class SelectAction : NetAction
{
    public override ActionType Type => ActionType.SELECT;
    public string MapLabel { get; set; } = "";
    public int Level { get; set; } = 0;
    public override void OnReceived()
    {
        LogActionReceived();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            KyoukoManager.IzakayaMapLabel = MapLabel;
            KyoukoManager.IzakayaLevel = Level;

            Dialog.ShowInformDialog(KyoukoManager.IzakayaMapLabel, null);
        });
    }
}

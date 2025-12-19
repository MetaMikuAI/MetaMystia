using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class QTEAction : NetAction
{
    public override ActionType Type => ActionType.QTE;
    public int GridIndex { get; set; }
    public float QTEScore { get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            var cookerController = CookManager.GetCookerControllerByIndex(GridIndex);
            if (cookerController == null)
            {
                Log.LogWarning($"Failed to find CookerController with GridIndex={GridIndex}");
                return;
            }
            CookControllerPatch.StartCookCountDown_Original(cookerController, QTEScore, false);
        });
    }
}

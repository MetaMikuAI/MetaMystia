using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class ExtractAction : NetAction
{
    public override ActionType Type => ActionType.EXTRACT;
    public int GridIndex { get; set; }
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
            CookControllerPatch.Extract_Original(cookerController, null);
        });
    }
}

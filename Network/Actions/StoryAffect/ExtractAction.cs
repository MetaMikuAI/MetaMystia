using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class ExtractAction : AffectStoryAction
{
    public override ActionType Type => ActionType.EXTRACT;
    public int GridIndex { get; set; }

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
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

    public static void Send(int gridIndex)
    {
        var action = new ExtractAction
        {
            GridIndex = gridIndex
        };
        action.SendToHostOrBroadcast();
    }
}

using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class QTEAction : AffectStoryAction
{
    public override ActionType Type => ActionType.QTE;
    public int GridIndex { get; set; }
    public float QTEScore { get; set; }

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
            CookControllerPatch.StartCookCountDown_Original(cookerController, QTEScore, false);
        });
    }

    public static void Send(int gridIndex, float qteScore)
    {
        var action = new QTEAction
        {
            GridIndex = gridIndex,
            QTEScore = qteScore
        };
        action.SendToHostOrBroadcast();
    }
}

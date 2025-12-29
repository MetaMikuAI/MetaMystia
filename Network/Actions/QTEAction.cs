using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class QTEAction : NetAction
{
    public override ActionType Type => ActionType.QTE;
    public int GridIndex { get; set; }
    public float QTEScore { get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        if (MpManager.InStory)
        {
            Log.LogInfo("current in story, will skip receive");
        }
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
        if (MpManager.InStory)
        {
            Log.LogInfo("current in story, will skip send");
        }
        NetPacket packet = new([new QTEAction
        {
            GridIndex = gridIndex,
            QTEScore = qteScore
        }]);
        SendToPeer(packet);
    }
}

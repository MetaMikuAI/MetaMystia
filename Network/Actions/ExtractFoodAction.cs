using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class ExtractFoodAction : NetAction
{
    public override ActionType Type => ActionType.EXTRACT_FOOD;
    public SellableFood Food { get; set; }
    public override void OnReceived()
    {
        LogActionReceived(true);
        if (MpManager.InStory)
        {
            Log.LogInfo("current in story, will skip receive");
        }
        PluginManager.Instance.RunOnMainThread(() =>
        {
            GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance?.RemoveStoredFood(Food.GetFromLocal());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup.UpdateElements();
        });
    }

    public static void Send(SellableFood food)
    {
        if (MpManager.InStory)
        {
            Log.LogInfo("current in story, will skip send");
        }
        NetPacket packet = new([new ExtractFoodAction
        {
            Food = food
        }]);
        SendToPeer(packet);
    }
}

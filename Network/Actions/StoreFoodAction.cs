using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class StoreFoodAction : NetAction
{
    public override ActionType Type => ActionType.STORE_FOOD;
    public SellableFood Food { get; set; }
    // public int MessageSender { get; set; }
    public override void OnReceived()
    {
        LogActionReceived(true);
        if (MpManager.InStory)
        {
            Log.LogInfo("current in story, will skip receive");
        }
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigurePatch.StoreFood_Original(Food.ToSellable());
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
        NetPacket packet = new([new StoreFoodAction
        {
            Food = food
        }]);
        SendToPeer(packet);
    }
}

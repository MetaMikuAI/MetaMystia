using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class StoreFoodAction : NetAction
{
    public override ActionType Type => ActionType.STOREFOOD;
    public SellableFood Food { get; set; }
    // public int MessageSender { get; set; }
    public override void OnReceived()
    {
        LogActionReceived(true);
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigurePatch.StoreFood_Original(Food.ToSellable());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup.UpdateElements();
        });
    }

    public static void Send(SellableFood food)
    {
        NetPacket packet = new([new StoreFoodAction
        {
            Food = food
        }]);
        SendToPeer(packet);
    }
}

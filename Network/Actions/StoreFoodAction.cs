using DEYU.AdpUISystem.PanelCollection;
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
        Plugin.Instance.Log.LogInfo("Received StoreFoodAction");
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigurePatch.StoreFood_Original(Food.ToSellable());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup.UpdateElements();
        });
    }
}

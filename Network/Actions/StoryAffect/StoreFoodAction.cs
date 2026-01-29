using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class StoreFoodAction : AffectStoryAction
{
    public override ActionType Type => ActionType.STORE_FOOD;
    public SellableFood Food { get; set; }

    protected override bool OnSendLogOnlyAction => true;
    protected override bool OnReceiveLogOnlyAction => true;

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigurePatch.StoreFood_Original(Food.ToSellable());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup?.UpdateElements();
        });
    }

    public static void Send(SellableFood food)
    {
        var action = new StoreFoodAction
        {
            Food = food
        };
        action.SendToHostOrBroadcast();
    }
}

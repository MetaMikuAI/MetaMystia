using MemoryPack;

using MetaMystia.Patch;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 全体玩家：通告某个料理被放入保温箱中，与 ExtractFood 对应
/// </summary>
[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class StoreFoodAction : Action
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

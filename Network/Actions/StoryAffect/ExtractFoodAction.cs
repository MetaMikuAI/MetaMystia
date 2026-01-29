using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class ExtractFoodAction : AffectStoryAction
{
    public override ActionType Type => ActionType.EXTRACT_FOOD;
    public SellableFood Food { get; set; }

    protected override bool OnSendLogOnlyAction => true;
    protected override bool OnReceiveLogOnlyAction => true;

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance?.RemoveStoredFood(Food.GetFromLocal());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup?.UpdateElements();
        });
    }

    public static void Send(SellableFood food)
    {
        var action = new ExtractFoodAction
        {
            Food = food
        };
        action.SendToHostOrBroadcast();
    }
}

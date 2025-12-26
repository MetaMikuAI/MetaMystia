using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class ExtractFoodAction : NetAction
{
    public override ActionType Type => ActionType.EXTRACTFOOD;
    public SellableFood Food { get; set; }
    public override void OnReceived()
    {
        LogActionReceived(true);
        PluginManager.Instance.RunOnMainThread(() =>
        {
            GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance?.RemoveStoredFood(Food.GetFromLocal());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup.UpdateElements();
        });
    }
}

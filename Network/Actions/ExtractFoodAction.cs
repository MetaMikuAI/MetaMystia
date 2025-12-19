using GameData.Core.Collections;
using JetBrains.Annotations;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class ExtractFoodAction : NetAction
{
    public override ActionType Type => ActionType.EXTRACTFOOD;
    public SellableFood Food { get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo("Received ExtractFoodAction");
        PluginManager.Instance.RunOnMainThread(() =>
        {
            GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.RemoveStoredFood(Food.GetFromLocal());
            WorkSceneStoragePannelPatch.instanceRef?.UpdateFoodField();
            WorkSceneStoragePannelPatch.instanceRef?.m_FoodsGroup.UpdateElements();
        });
    }
}

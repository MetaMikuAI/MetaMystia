using MemoryPack;
using GameData.Core.Collections;

namespace MetaMystia;

[MemoryPackable]
public partial class CookAction : NetAction
{
    public override ActionType Type => ActionType.COOK;
    public int GridIndex { get; set; }
    public int RecipeId {get; set; }
    public SellableFood Food { get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received COOK: CookerIndex={GridIndex}, FoodId={Food.FoodId}, Modifiers=[{string.Join(",", Food.ModifierIds)}]");
        PluginManager.Instance.RunOnMainThread(() =>
        {
            var recipe = RecipeId.RefRecipe();
            if (recipe == null)
            {
                Plugin.Instance.Log.LogWarning($"Failed to create recipe");
                return;
            }

            var food = Food.ToSellable();
            
            var cookerController = CookManager.GetCookerControllerByIndex(GridIndex);
            if (cookerController == null)
            {
                Plugin.Instance.Log.LogWarning($"Failed to find CookerController with GridIndex={GridIndex}");
                return;
            }

            CookControllerPatch.SetCook_Original(cookerController, food, recipe, false);
        });
    }
}

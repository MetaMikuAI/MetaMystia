using GameData.Core.Collections;
using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class CookAction : AffectStoryAction
{
    public override ActionType Type => ActionType.COOK;
    public int GridIndex { get; set; }
    public int RecipeId { get; set; }
    public SellableFood Food { get; set; }

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        Log.LogInfo($"Received COOK: CookerIndex={GridIndex}, FoodId={Food.FoodId}, Modifiers=[{string.Join(",", Food.ModifierIds)}]");
        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (!DLCManager.RecipeAvailable(RecipeId))
            {
                Log.Error($"RecipeId {RecipeId} not available!");
                return;
            }
            var recipe = RecipeId.RefRecipe();
            if (recipe == null)
            {
                Log.LogWarning($"Failed to create recipe");
                return;
            }

            var food = Food.ToSellable();

            var cookerController = CookManager.GetCookerControllerByIndex(GridIndex);
            if (cookerController == null)
            {
                Log.LogWarning($"Failed to find CookerController with GridIndex={GridIndex}");
                return;
            }

            CookControllerPatch.SetCook_Original(cookerController, food, recipe, false);
        });
    }

    public static void Send(int gridIndex, SellableFood food, int recipeId)
    {
        var action = new CookAction
        {
            GridIndex = gridIndex,
            RecipeId = recipeId,
            Food = food
        };
        action.SendToHostOrBroadcast();
    }
}

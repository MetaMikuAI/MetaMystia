using System.Linq;

using GameData.Core.Collections;

using MetaMystia.ResourceEx.Models;
using MetaMystia.ResourceEx.Mappers;

namespace MetaMystia;

public static partial class ResourceExManager
{
    private static void RegisterAllRecipes() => RecipeConfigs.Values.ToList().ForEach(RegisterRecipe);
    private static void RegisterRecipe(RecipeConfig config)
    {
        var recipe = config.ToRuntimeRecipe();
        var success = DataBaseCore.Recipes.TryAdd(config.id, recipe);
        var mappingSuccess = DataBaseCore.RecipesMapping.TryAdd(config.id, "ResourceEx");
        Log.Info($"Registered Recipe ID {config.id} for Food ID {config.foodId}: Success: {success}, Mapping Success: {mappingSuccess}");
    }
}

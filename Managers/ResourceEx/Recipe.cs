using System.Collections.Generic;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;
using UnityEngine;

using MetaMystia.ResourceEx.Models;
using TMPro;
using System.Linq;
using System.Xml.Serialization;

namespace MetaMystia;

public static partial class ResourceExManager
{
    private static void RegisterAllRecipes() => RecipeConfigs.Values.ToList().ForEach(RegisterRecipe);
    private static void RegisterRecipe(RecipeConfig config)
    {
        var recipe = new Recipe(
            id: config.id,
            foodID: config.foodId,
            cookerType: config.cookerType,
            cookTime: config.cookTime,
            ingredients: config.ingredients.ToArray()
        );
        var success = DataBaseCore.Recipes.TryAdd(config.id, recipe);
        var mappingSuccess = DataBaseCore.RecipesMapping.TryAdd(config.id, "ResourceEx");
        Log.Info($"Registered Recipe ID {config.id} for Food ID {config.foodId}: Success: {success}, Mapping Success: {mappingSuccess}");
    }
}

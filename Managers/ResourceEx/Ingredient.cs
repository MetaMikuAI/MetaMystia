using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;
using GameData.Core.Collections;

using MetaMystia.ResourceEx.Models;
using System.Linq;

namespace MetaMystia;

public static partial class ResourceExManager
{
    private static void RegisterAllIngredientLanguages()
    {
        IngredientConfigs.Values.ToList().ForEach(RegisterIngredientLanguage);
    }

    private static void RegisterIngredientLanguage(IngredientConfig config)
    {
        var lang = new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            GetSprite(config.spritePath, config.ModRoot)
        );
        DataBaseLanguage.Ingredients[config.id] = lang; // Ingredients 是 private 的，不能用 TryAdd
        Log.Warning($"Registered language for ingredient {config.id}: {config.name}");
    }

    private static void RegisterAllIngredients()
    {
        IngredientConfigs.Values.ToList().ForEach(RegisterIngredient);
    }

    private static void RegisterIngredient(IngredientConfig config)
    {
        var ingredient = new Ingredient(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            prefix: config.prefix,
            tags: config.tags.ToArray()
        );
        var success = DataBaseCore.Ingredients.TryAdd(ingredient.Id, ingredient);
        Log.Warning($"Registered ingredient object {config.id}: {config.name}, success={success}");
    }
}
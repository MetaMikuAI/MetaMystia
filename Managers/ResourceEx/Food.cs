using System.Collections.Generic;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;
using UnityEngine;

using MetaMystia.ResourceEx.Models;
using System.Linq;

namespace MetaMystia;

public static partial class ResourceExManager
{

    private static void RegisterAllFoods() => FoodConfigs.Values.ToList().ForEach(RegisterFood);

    private static void RegisterFood(FoodConfig config)
    {
        var food = new Sellable(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            tags: config.tags.ToArray(),
            banTags: config.banTags.ToArray(),
            type: Sellable.SellableType.Food,
            additiveTags: new Il2CppSystem.Collections.Generic.List<int>(),
            isCollab: false
        );
        var success = DataBaseCore.Foods.TryAdd(config.id, food);
        var mappingSuccess = DataBaseCore.FoodsMapping.TryAdd(config.id, "ResourceEx");
        Log.Info($"Registered Food ID {config.id} ({config.name}): Success: {success}, Mapping Success: {mappingSuccess}");
    }

    private static void RegisterAllFoodLanguages() => FoodConfigs.Values.ToList().ForEach(RegisterFoodLanguage);

    private static void RegisterFoodLanguage(FoodConfig config)
    {
        var sprite = GetSprite(config.spritePath, config.ModRoot, new Vector2(0.5f, 0.5f));
        var lang = new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            visual: sprite
        );
        DataBaseLanguage.Foods[config.id] = lang;
        Log.Info($"Registered Food Language ID {config.id} ({config.name})");
    }
}

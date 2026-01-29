using System.Linq;
using GameData.Core.Collections;
using GameData.CoreLanguage.Collections;
using MetaMystia.ResourceEx.Mappers;
using MetaMystia.ResourceEx.Models;
using UnityEngine;

namespace MetaMystia;

public static partial class ResourceExManager
{

    private static void RegisterAllFoods() => FoodConfigs.Values.ToList().ForEach(RegisterFood);

    private static void RegisterFood(FoodConfig config)
    {
        var food = config.ToFood();
        var success = DataBaseCore.Foods.TryAdd(config.id, food);
        var mappingSuccess = DataBaseCore.FoodsMapping.TryAdd(config.id, "ResourceEx");
        Log.Info($"Registered Food ID {config.id} ({config.name}): Success: {success}, Mapping Success: {mappingSuccess}");
    }

    private static void RegisterAllFoodLanguages() => FoodConfigs.Values.ToList().ForEach(RegisterFoodLanguage);

    private static void RegisterFoodLanguage(FoodConfig config)
    {
        var sprite = GetSprite(config.spritePath, config.PackageRoot, new Vector2(0.5f, 0.5f));
        var lang = config.ToFoodLanguage(sprite);
        DataBaseLanguage.Foods[config.id] = lang;
        Log.Info($"Registered Food Language ID {config.id} ({config.name})");
    }
}

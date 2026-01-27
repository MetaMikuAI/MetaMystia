using System.Linq;

using GameData.CoreLanguage.Collections;
using GameData.Core.Collections;

using MetaMystia.ResourceEx.Models;
using MetaMystia.ResourceEx.Mappers;

namespace MetaMystia;

public static partial class ResourceExManager
{
    private static void RegisterAllBeverageLanguages()
    {
        BeverageConfigs.Values.ToList().ForEach(RegisterBeverageLanguage);
    }

    private static void RegisterBeverageLanguage(BeverageConfig config)
    {
        var sprite = GetSprite(config.spritePath, config.ModRoot);
        var lang = config.ToBeverageLanguage(sprite);
        DataBaseLanguage.Beverages[config.id] = lang; // Beverages 是 private 的，不能用 TryAdd
        Log.Info($"Registered language for beverage {config.id}: {config.name}");
    }

    private static void RegisterAllBeverages()
    {
        BeverageConfigs.Values.ToList().ForEach(RegisterBeverage);
    }

    private static void RegisterBeverage(BeverageConfig config)
    {
        var beverage = config.ToRuntimeBeverage();
        var success = DataBaseCore.Beverages.TryAdd(beverage.Id, beverage);
        Log.Info($"Registered beverage object {config.id}: {config.name}, success={success}");
    }
}

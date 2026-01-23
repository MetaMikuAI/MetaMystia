using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;
using GameData.Core.Collections;

using MetaMystia.ResourceEx.Models;
using System.Linq;

namespace MetaMystia;

public static partial class ResourceExManager
{
    private static void RegisterAllBeverageLanguages()
    {
        BeverageConfigs.Values.ToList().ForEach(RegisterBeverageLanguage);
    }

    private static void RegisterBeverageLanguage(BeverageConfig config)
    {
        var lang = new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            GetSprite(config.spritePath, config.ModRoot)
        );
        DataBaseLanguage.Beverages[config.id] = lang; // Beverages 是 private 的，不能用 TryAdd
        Log.Info($"Registered language for beverage {config.id}: {config.name}");
    }

    private static void RegisterAllBeverages()
    {
        BeverageConfigs.Values.ToList().ForEach(RegisterBeverage);
    }

    private static void RegisterBeverage(BeverageConfig config)
    {
        var beverage = new Sellable(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            tags: config.tags.ToArray(),
            banTags: new int[0],
            type: Sellable.SellableType.Beverage,
            additiveTags: new Il2CppSystem.Collections.Generic.List<int>(),
            isCollab: false
        );
        var success = DataBaseCore.Beverages.TryAdd(beverage.Id, beverage);
        Log.Info($"Registered beverage object {config.id}: {config.name}, success={success}");
    }
}

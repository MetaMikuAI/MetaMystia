using System;
using System.Linq;
using DEYU.Utils;
using GameData.Core.Collections;
using Il2CppSystem.IO;
using MemoryPack;

namespace MetaMystia;


// optimize & TODO: 实现整个 GameData.Core.Collections.Sellable 即使之包含 Beverage 而不仅仅是 Food
[MemoryPackable]
[AutoLog]
public partial class SellableFood
{
    public int FoodId { get; set; }
    public int Level { get; set; }
    public int[] ModifierIds { get; set; } = [];
    public int[] AdditiveTags { get; set; } = [];
    public int CookId { get; set; }

    public Sellable ToSellable()
    {
        var food = FoodId.AsNewFood();
        food.level = Level;
        food.modifier = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<int>(ModifierIds);
        food.additiveTags = new Il2CppSystem.Collections.Generic.List<int>();
        foreach (var tag in AdditiveTags)
        {
            food.additiveTags.Add(tag);
        }
        var cooker = CookManager.GetCookerByCookerId(CookId);
        var guid = Il2CppSystem.Guid.NewGuid();
        food.RunTimeGUID = new Il2CppSystem.Nullable<Il2CppSystem.Guid>(guid);

        if (cooker != null && cooker?.Id != null)
        {
            var b = NightScene.CookingUtility.CookSystemManager.Instance?.registeredSellables.TryAdd(food.RunTimeGUID.Unbox<Il2CppSystem.Guid>(), cooker);
            Log.Info($"registeredSellables tryadd {food.RunTimeGUID.Unbox<Il2CppSystem.Guid>()} => {cooker?.Id}, result {b}");
        } 
        return food;
    }
    public static SellableFood FromSellable(Sellable sellable)
    {
        var res = new SellableFood
        {
            FoodId = sellable.Id,
            Level = sellable.level,
            ModifierIds = sellable.modifier,
            AdditiveTags = sellable.additiveTags.ToArray()
        };
        if (NightScene.CookingUtility.CookSystemManager.Instance?.GetCooker(sellable, out var cooker) is true)
        {
            Log.Info($"GetCooker id {cooker.Id}");
            res.CookId = cooker.Id;
        }
        return res;
    }

    public Sellable GetFromLocal()
    {
        var storedFoods = GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.GetStoredFoods();
        var matchingFood = from food in storedFoods.ToArray()
                          where food.Id == FoodId &&
                                food.level == Level &&
                                food.modifier.SequenceEqual(ModifierIds) &&
                                food.additiveTags.ToArray().SequenceEqual(AdditiveTags.ToArray())
                          select food;
        
        return matchingFood.FirstOrDefault();
    }
}

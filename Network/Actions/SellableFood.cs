using System.Linq;
using GameData.Core.Collections;
using Il2CppSystem.IO;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class SellableFood
{
    public int FoodId { get; set; }
    public int[] ModifierIds { get; set; } = new int[0];
    public int[] AdditiveTags { get; set; } = new int[0];

    public Sellable ToSellable()
    {
        var food = FoodId.AsNewFood();
        food.modifier = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<int>(ModifierIds);
        food.additiveTags = new Il2CppSystem.Collections.Generic.List<int>();
        foreach (var tag in AdditiveTags)
        {
            food.additiveTags.Add(tag);
        }

        return food;
    }
    public static SellableFood FromSellable(Sellable sellable)
    {
        return new SellableFood
        {
            FoodId = sellable.Id,
            ModifierIds = sellable.modifier,
            AdditiveTags = sellable.additiveTags.ToArray()
        };
    }

    public Sellable GetFromLocal()
    {
        var storedFoods = GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.GetStoredFoods();
        var matchingFood = from food in storedFoods.ToArray()
                          where food.Id == FoodId &&
                                food.modifier.SequenceEqual(ModifierIds) &&
                                food.additiveTags.ToArray().SequenceEqual(AdditiveTags.ToArray())
                          select food;
        
        return matchingFood.FirstOrDefault();
    }
}

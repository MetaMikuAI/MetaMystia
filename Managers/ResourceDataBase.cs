using System.Collections.Generic;
using System.Linq;

using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;

using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

// 依赖: DataBaseCore, DataBaseCharacter, ResourceEx

[MemoryPackable]
[AutoLog]
public partial class ResourceDataBase
{
    // from DataBaseCore
    public List<int> Foods { get; private set; } = [];
    public List<int> Recipes { get; private set; } = [];
    public List<int> Beverages { get; private set; } = [];
    public List<int> Ingredients { get; private set; } = [];
    public List<int> Cookers { get; private set; } = [];
    public List<int> Items { get; private set; } = [];
    public List<int> Izakayas { get; private set; } = [];

    // from DataBaseCharacter
    public List<int> SpecialGuests { get; private set; } = [];
    public List<int> NormalGuests { get; private set; } = [];

    public void LoadResourceIds()
    {
        Foods = DataBaseCore.Foods.ToList().Select(f => f.Key).ToList();
        Recipes = DataBaseCore.Recipes.ToList().Select(r => r.Key).ToList();
        Beverages = DataBaseCore.Beverages.ToList().Select(b => b.Key).ToList();
        Ingredients = DataBaseCore.Ingredients.ToList().Select(i => i.Key).ToList();
        Cookers = DataBaseCore.Cookers.ToList().Select(c => c.Key).ToList();
        Items = DataBaseCore.Items.ToList().Select(i => i.Key).ToList();
        Izakayas = DataBaseCore.Izakayas.ToList().Select(i => i.Key).ToList();

        SpecialGuests = DataBaseCharacter.SpecialGuest.ToList().Select(s => s.Key).ToList();
        NormalGuests = DataBaseCharacter.NormalGuest.ToList().Select(n => n.Key).ToList();
    }

    public void Clear()
    {
        Foods.Clear();
        Recipes.Clear();
        Beverages.Clear();
        Ingredients.Clear();
        Cookers.Clear();
        Items.Clear();
        Izakayas.Clear();

        SpecialGuests.Clear();
        NormalGuests.Clear();
    }

    public void LogDataBase()
    {
        Log.Warning($"Foods: {string.Join(", ", Foods)}");
        Log.Warning($"Recipes: {string.Join(", ", Recipes)}");
        Log.Warning($"Beverages: {string.Join(", ", Beverages)}");
        Log.Warning($"Ingredients: {string.Join(", ", Ingredients)}");
        Log.Warning($"Cookers: {string.Join(", ", Cookers)}");
        Log.Warning($"Items: {string.Join(", ", Items)}");
        Log.Warning($"Izakayas: {string.Join(", ", Izakayas)}");

        Log.Warning($"SpecialGuests: {string.Join(", ", SpecialGuests)}");
        Log.Warning($"NormalGuests: {string.Join(", ", NormalGuests)}");
    }
}

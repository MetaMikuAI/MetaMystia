using System.Collections.Generic;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using SgrYuki.Utils;
using UnityEngine.Playables;

namespace MetaMystia;

[AutoLog]
public static class DLCManager
{
    public static List<string> ActiveDLCLabel => Common.LoadingSceneManager.LoadedGameDataProfile.ActiveDLCLabel.ToManagedList();
    public static List<string> PeerActiveDLCLabel = null;

    public static GameData.Profile.ExpandableGameDataPack CoreDataPack => Common.LoadingSceneManager.LoadedGameDataProfile.coreDataPack; 
    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GameData.Profile.GameDataProfile.DLCGameDataPack> DLCDataPacks => Common.LoadingSceneManager.LoadedGameDataProfile.dlcGameDataPacks;
    
    public static HashSet<int> CoreRecipes {get; private set;} = [];
    public static HashSet<int> CoreCookers {get; private set;} = [];
    public static HashSet<int> CoreFoods {get; private set;} = [];
    public static HashSet<int> CoreBeverages {get; private set;} = [];
    public static HashSet<int> CoreNormalGuests {get; private set;} = [];
    public static HashSet<int> CoreSpecialGuests {get; private set;} = [];

    public static HashSet<int> Recipes {get; private set;} = null;
    public static HashSet<int> Cookers {get; private set;} = null;
    public static HashSet<int> Foods {get; private set;} = null;
    public static HashSet<int> Beverages {get; private set;} = null;
    public static HashSet<int> NormalGuests {get; private set;} = null;
    public static HashSet<int> SpecialGuests {get; private set;} = null;

    public static HashSet<int> PeerRecipes {get; set;} = null;
    public static HashSet<int> PeerCookers {get; set;} = null;
    public static HashSet<int> PeerFoods {get; set;} = null;
    public static HashSet<int> PeerBeverages {get; set;} = null;
    public static HashSet<int> PeerNormalGuests {get; set;} = null;
    public static HashSet<int> PeerSpecialGuests {get; set;} = null;

    public static bool PeerNormalGuestAvailable(int id) => CoreNormalGuests.Contains(id) || PeerNormalGuests.Contains(id);
    public static bool PeerSpecialGuestAvailable(int id) => CoreSpecialGuests.Contains(id) || PeerSpecialGuests.Contains(id);

    public static void Initialize()
    {
        Recipes = GetAllDLCRecipes();
        Cookers = GetAllDLCCookers();
        Foods = GetAllDLCFoods();
        Beverages = GetAllDLCBeverages();
        NormalGuests = GetAllDLCNormalGuests();
        SpecialGuests = GetAllDLCSpecialGuests();

        System.Array.ForEach([CoreRecipes, CoreCookers, CoreFoods, CoreBeverages, CoreNormalGuests, CoreSpecialGuests], hs => hs?.Clear());
        foreach(var item in CoreDataPack.RecipeProfile.Asset?.Cast<GameData.Profile.RecipeProfile>().recipes) CoreRecipes.Add(item.Id);
        foreach(var item in CoreDataPack.CookerProfile.Asset?.Cast<GameData.Profile.CookerProfile>().cookers) CoreCookers.Add(item.Id);
        foreach(var item in CoreDataPack.FoodProfile.Asset?.Cast<GameData.Profile.SellableProfile>().sellables) CoreFoods.Add(item.Id);
        foreach(var item in CoreDataPack.BeverageProfile.Asset?.Cast<GameData.Profile.SellableProfile>().sellables) CoreBeverages.Add(item.Id);
        foreach(var item in CoreDataPack.NormalGuestProfile.Asset?.Cast<GameData.Profile.NormalGuestProfile>().normalGuests) CoreNormalGuests.Add(item.Id);
        foreach(var item in CoreDataPack.SpecialGuestProfile.Asset?.Cast<GameData.Profile.SpecialGuestProfile>().specialGuests) CoreSpecialGuests.Add(item.Id);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Recipe> GetRecipesFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        GameData.Profile.RecipeProfile casted;
        var obj = pack.dlcGameDataPack.RecipeProfile.OperationHandle.Result;
        casted = obj?.Cast<GameData.Profile.RecipeProfile>();
        return casted?.recipes ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Recipe>(0);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Sellable> GetFoodsFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        var obj = pack.dlcGameDataPack.FoodProfile.Asset;
        var casted = obj?.Cast<GameData.Profile.SellableProfile>();
        return casted?.sellables ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Sellable>(0);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Sellable> GetBeveragesFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        var obj = pack.dlcGameDataPack.BeverageProfile.Asset;
        var casted = obj?.Cast<GameData.Profile.SellableProfile>();
        return casted?.sellables ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Sellable>(0);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<NormalGuest> GetNormalGuestsFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        var obj = pack.dlcGameDataPack.NormalGuestProfile.Asset;
        var casted = obj?.Cast<GameData.Profile.NormalGuestProfile>();
        return casted?.normalGuests ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<NormalGuest>(0);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<SpecialGuest> GetSpecialGuestsFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        var obj = pack.dlcGameDataPack.SpecialGuestProfile.Asset;
        var casted = obj?.Cast<GameData.Profile.SpecialGuestProfile>();
        return casted?.specialGuests ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<SpecialGuest>(0);
    }

    private static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Cooker> GetCookersFromDLC(GameData.Profile.GameDataProfile.DLCGameDataPack pack)
    {
        var obj = pack.dlcGameDataPack.CookerProfile.Asset;
        var casted = obj?.Cast<GameData.Profile.CookerProfile>();
        return casted?.cookers ?? new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Cooker>(0);
    }

    private static List<GameData.Profile.GameDataProfile.DLCGameDataPack> GetAllDLCGameDataPacks()
    {
        List<GameData.Profile.GameDataProfile.DLCGameDataPack> res = new();
        foreach (var pack in DLCDataPacks)
        {
            if (pack.key.Equals("DLCMUSIC"))
            {
                continue;
            }
            res.Add(pack);
        }
        return res;
    }

    private static HashSet<int> GetAllDLCRecipes()
    {
        HashSet<int> ids = [];
        foreach(var pack in GetAllDLCGameDataPacks())
        {
            foreach(Recipe item in GetRecipesFromDLC(pack))
            {
                ids.Add(item.Id);
            }
        }
        return ids;
    }

    private static HashSet<int> GetAllDLCFoods()
    {
        HashSet<int> ids = [];
        foreach(var pack in GetAllDLCGameDataPacks())
        {
            foreach(Sellable food in GetFoodsFromDLC(pack))
            {
                ids.Add(food.Id);
            }
        }
        return ids;
    }

    private static HashSet<int> GetAllDLCBeverages()
    {
        HashSet<int> ids = [];
        foreach (var pack in GetAllDLCGameDataPacks())
        {
            foreach(Sellable beverage in GetBeveragesFromDLC(pack))
            {
                ids.Add(beverage.Id);
            }
        }
        return ids;
    }
    
    private static HashSet<int> GetAllDLCNormalGuests()
    {
        HashSet<int> ids = [];
        foreach(var pack in GetAllDLCGameDataPacks())
        {
            foreach(NormalGuest item in GetNormalGuestsFromDLC(pack))
            {
                ids.Add(item.Id);
            }
        }
        return ids;
    }

    private static HashSet<int> GetAllDLCSpecialGuests()
    {
        HashSet<int> ids = [];
        foreach(var pack in GetAllDLCGameDataPacks())
        {
            foreach(SpecialGuest item in GetSpecialGuestsFromDLC(pack))
            {
                ids.Add(item.Id);
            }
        }
        return ids;
    }

    private static HashSet<int> GetAllDLCCookers()
    {
        HashSet<int> ids = [];
        foreach(var pack in GetAllDLCGameDataPacks())
        {
            foreach(Cooker item in GetCookersFromDLC(pack))
            {
                ids.Add(item.Id);
            }
        }
        return ids;
    }
}
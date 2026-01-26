using System.Collections.Generic;
using System.Linq;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using SgrYuki.Utils;
using static GameData.Profile.GameDataProfile;

namespace MetaMystia;

[AutoLog]
public static partial class DLCManager
{
    public static List<string> ActiveDLCLabel { get; private set; } = [];
    public static List<string> PeerActiveDLCLabel = [];
    public static ExpandableGameDataPack CoreDataPack => Common.LoadingSceneManager.LoadedGameDataProfile.coreDataPack;
    public static Il2CppReferenceArray<DLCGameDataPack> DLCDataPacks => Common.LoadingSceneManager.LoadedGameDataProfile.dlcGameDataPacks;

    public static HashSet<int> CoreRecipes { get; private set; } = [];
    public static HashSet<int> CoreCookers { get; private set; } = [];
    public static HashSet<int> CoreFoods { get; private set; } = [];
    public static HashSet<int> CoreBeverages { get; private set; } = [];
    public static HashSet<int> CoreNormalGuests { get; private set; } = [];
    public static HashSet<int> CoreSpecialGuests { get; private set; } = [];
    public static HashSet<string> CoreCollectables { get; private set; } = [];

    public static HashSet<int> Recipes { get; private set; } = null;
    public static HashSet<int> Cookers { get; private set; } = null;
    public static HashSet<int> Foods { get; private set; } = null;
    public static HashSet<int> Beverages { get; private set; } = null;
    public static HashSet<int> NormalGuests { get; private set; } = null;
    public static HashSet<int> SpecialGuests { get; private set; } = null;
    public static HashSet<string> Collectables { get; private set; } = null;


    public static HashSet<int> PeerRecipes { get; set; } = [];
    public static HashSet<int> PeerCookers { get; set; } = [];
    public static HashSet<int> PeerFoods { get; set; } = [];
    public static HashSet<int> PeerBeverages { get; set; } = [];
    public static HashSet<int> PeerNormalGuests { get; set; } = [];
    public static HashSet<int> PeerSpecialGuests { get; set; } = [];

    public static bool RecipeAvailable(int id) => CoreRecipes.Contains(id) || Recipes.Contains(id);
    public static bool PeerRecipeAvailable(int id) => CoreRecipes.Contains(id) || PeerRecipes.Contains(id);
    public static bool PeerCookerAvailable(int id) => CoreCookers.Contains(id) || PeerCookers.Contains(id); // 注, -1 为空位, 可能需要特判
    public static bool PeerFoodAvailable(int id) => CoreFoods.Contains(id) || PeerFoods.Contains(id);
    public static bool PeerBeverageAvailable(int id) => CoreBeverages.Contains(id) || PeerBeverages.Contains(id);
    public static bool PeerNormalGuestAvailable(int id) => CoreNormalGuests.Contains(id) || PeerNormalGuests.Contains(id);
    public static bool PeerSpecialGuestAvailable(int id) => CoreSpecialGuests.Contains(id) || PeerSpecialGuests.Contains(id);
    public static bool SpecialGuestAvailable(int id) => CoreSpecialGuests.Contains(id) || SpecialGuests.Contains(id);
    public static bool CollectableAvailable(string id) => CoreCollectables.Contains(id) || Collectables.Contains(id);


    public static void Initialize()
    {
        ActiveDLCLabel = Common.LoadingSceneManager.LoadedGameDataProfile.ActiveDLCLabel.ToManagedList();
        ActiveDLCLabel.Sort();

        Recipes = GetAllDLCRecipes() ?? [];
        Cookers = GetAllDLCCookers() ?? [];
        Foods = GetAllDLCFoods() ?? [];
        Beverages = GetAllDLCBeverages() ?? [];

        // GetAllDLCBeverages: [1000,1001,1003,1004,2001,2002,3000,5000,5001,5002,5003,5004]
        if (Cookers.Contains(1000)) Beverages.Add(1002);  // 1002(妖精雨露) not contained in GetAllDLCBeverages
        if (Cookers.Contains(2000)) Beverages.Add(2000);  // 2000(鬼杀) not contained in GetAllDLCBeverages
        if (Cookers.Contains(3000)) Beverages.Add(3001);  // 3001(麒麟) not contained in GetAllDLCBeverages
        if (Cookers.Contains(4000))
        {
            Beverages.Add(4000);  // 4000(天地无用) not contained in GetAllDLCBeverages
            Beverages.Add(4001);  // 4001(伶人醉) not contained in GetAllDLCBeverages
        }

        NormalGuests = GetAllDLCNormalGuests() ?? [];
        SpecialGuests = GetAllDLCSpecialGuests() ?? [];
        Collectables = GetAllDLCCollectables() ?? [];

        System.Array.ForEach([CoreRecipes, CoreCookers, CoreFoods, CoreBeverages, CoreNormalGuests, CoreSpecialGuests], hs => hs?.Clear());
        foreach (var item in CoreDataPack.RecipeProfile.Asset?.Cast<RecipeProfile>().recipes) CoreRecipes.Add(item.Id);
        foreach (var item in CoreDataPack.CookerProfile.Asset?.Cast<CookerProfile>().cookers) CoreCookers.Add(item.Id);
        foreach (var item in CoreDataPack.FoodProfile.Asset?.Cast<SellableProfile>().sellables) CoreFoods.Add(item.Id);
        foreach (var item in CoreDataPack.BeverageProfile.Asset?.Cast<SellableProfile>().sellables) CoreBeverages.Add(item.Id);
        foreach (var item in CoreDataPack.NormalGuestProfile.Asset?.Cast<NormalGuestProfile>().normalGuests) CoreNormalGuests.Add(item.Id);
        foreach (var item in CoreDataPack.SpecialGuestProfile.Asset?.Cast<SpecialGuestProfile>().specialGuests) CoreSpecialGuests.Add(item.Id);
        foreach (var item in CoreDataPack.CollectableProfile.Asset?.Cast<DayScene.Interactables.Collectable.CollectableProfile>().collectables) CoreCollectables.Add(item.key);
        ClearPeer();
    }

    public static void ClearPeer()
    {
        PeerRecipes?.Clear();
        PeerCookers?.Clear();
        PeerFoods?.Clear();
        PeerBeverages?.Clear();
        PeerNormalGuests?.Clear();
        PeerSpecialGuests?.Clear();
        PeerActiveDLCLabel = [];
    }

    private static Il2CppReferenceArray<Recipe> GetRecipesFromDLC(DLCGameDataPack pack)
    {
        // GameData.Profile.RecipeProfile casted;
        // var obj = pack.dlcGameDataPack.RecipeProfile.OperationHandle.Result;
        var obj = pack?.dlcGameDataPack?.RecipeProfile?.Asset;
        var casted = obj?.Cast<RecipeProfile>();
        return casted?.recipes ?? new Il2CppReferenceArray<Recipe>(0);
    }

    private static Il2CppReferenceArray<Sellable> GetFoodsFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.FoodProfile?.Asset;
        var casted = obj?.Cast<SellableProfile>();
        return casted?.sellables ?? new Il2CppReferenceArray<Sellable>(0);
    }

    private static Il2CppReferenceArray<Sellable> GetBeveragesFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.BeverageProfile?.Asset;
        var casted = obj?.Cast<SellableProfile>();
        return casted?.sellables ?? new Il2CppReferenceArray<Sellable>(0);
    }

    private static Il2CppReferenceArray<NormalGuest> GetNormalGuestsFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.NormalGuestProfile?.Asset;
        var casted = obj?.Cast<NormalGuestProfile>();
        return casted?.normalGuests ?? new Il2CppReferenceArray<NormalGuest>(0);
    }

    private static Il2CppReferenceArray<SpecialGuest> GetSpecialGuestsFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.SpecialGuestProfile?.Asset;
        var casted = obj?.Cast<SpecialGuestProfile>();
        return casted?.specialGuests ?? new Il2CppReferenceArray<SpecialGuest>(0);
    }

    private static Il2CppReferenceArray<Cooker> GetCookersFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.CookerProfile?.Asset;
        var casted = obj?.Cast<CookerProfile>();
        return casted?.cookers ?? new Il2CppReferenceArray<Cooker>(0);
    }

    private static Il2CppReferenceArray<Collectable> GetCollectablesFromDLC(DLCGameDataPack pack)
    {
        var obj = pack?.dlcGameDataPack?.CollectableProfile?.Asset;
        var casted = obj?.Cast<DayScene.Interactables.Collectable.CollectableProfile>();
        return casted?.collectables ?? new Il2CppReferenceArray<Collectable>(0);
    }

    private static List<DLCGameDataPack> GetAllDLCGameDataPacks()
    {
        return [.. DLCDataPacks.Where(pack => !pack.key.Equals("DLCMUSIC"))];
    }

    private static HashSet<int> GetAllDLCRecipes()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetRecipesFromDLC(pack))
            .Select(r => r.Id)];
    }

    private static HashSet<int> GetAllDLCFoods()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetFoodsFromDLC(pack))
            .Select(food => food.Id)];
    }

    private static HashSet<int> GetAllDLCBeverages()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetBeveragesFromDLC(pack))
            .Select(beverage => beverage.Id)];
    }

    private static HashSet<int> GetAllDLCNormalGuests()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetNormalGuestsFromDLC(pack))
            .Select(item => item.Id)];
    }

    private static HashSet<int> GetAllDLCSpecialGuests()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetSpecialGuestsFromDLC(pack))
            .Select(item => item.Id)];
    }

    private static HashSet<int> GetAllDLCCookers()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(pack => GetCookersFromDLC(pack))
            .Select(item => item.Id)];
    }

    private static HashSet<string> GetAllDLCCollectables()
    {
        return [.. GetAllDLCGameDataPacks()
            .SelectMany(GetCollectablesFromDLC)
            .Select(item => item.key)];
    }
}

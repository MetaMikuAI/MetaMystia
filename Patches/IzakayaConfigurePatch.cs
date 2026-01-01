using GameData.Core.Collections;
using GameData.RunTime.NightSceneUtility;
using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.RunTime.NightSceneUtility.IzakayaConfigure))]
[AutoLog]
public partial class IzakayaConfigurePatch
{
    // MetaMiku 注:
    //     下面分别是 IzakayaConfigure 中 菜单/酒水/厨具 注册与注销 的 hook
    //     但是其中对于 厨具，厨具无论是注册还是注销，都会触发 RegisterToCookers，而只有在注销时才会触发 LogOffFromCookers
    
    [HarmonyPatch(nameof(IzakayaConfigure.RegisterToDailyRecipes))]
    [HarmonyPrefix]
    public static bool RegisterToDailyRecipes_Prefix(int id)
    {
        Log.LogInfo($"RegisterToDailyRecipes: {id}");

        if (MpManager.IsConnected && !DLCManager.PeerRecipeAvailable(id))
        {
            Log.LogWarning($"Peer does not have recipe {id}, skipping...");
            return false;
        }

        PrepSceneManager.localPrepTable.RecipeAdditions[id] = MpManager.GetSynchronizedTimestampNow;
        PrepAction.Send(PrepSceneManager.localPrepTable);
        return true;
    }
    
    [HarmonyPatch(nameof(IzakayaConfigure.RegisterToDailyBeverages))]
    [HarmonyPrefix]
    public static bool RegisterToDailyBeverages_Prefix(int id)
    {
        Log.LogInfo($"RegisterToDailyBeverages: {id}");
        if (MpManager.IsConnected && !DLCManager.PeerBeverageAvailable(id))
        {
            Log.LogWarning($"Peer does not have beverage {id}, skipping...");
            return false;
        }

        PrepSceneManager.localPrepTable.BeverageAdditions[id] = MpManager.GetSynchronizedTimestampNow;
        PrepAction.Send(PrepSceneManager.localPrepTable);
        return true;
    }

    [HarmonyPatch(nameof(IzakayaConfigure.RegisterToCookers))]
    [HarmonyPrefix]
    public static bool RegisterToCookers_Prefix(int id, int index, bool checkPlayerHaveCooker)
    {
        var slots = PrepSceneManager.GetLocalCookerSlots();
        if (index < 0 || index >= slots.Length)
        {
            Log.LogWarning($"RegisterToCookers out of range: id={id}, index={index}, checkPlayerHaveCooker={checkPlayerHaveCooker}");
            return false;
        }

        if (id != -1 && MpManager.IsConnected && !DLCManager.PeerCookerAvailable(id))
        {
            Log.LogWarning($"Peer does not have cooker {id}, skipping...");
            return false;
        }

        long timestamp = MpManager.GetSynchronizedTimestampNow;
        slots[index].Id = id;
        slots[index].Timestamp = timestamp;

        Log.LogInfo($"RegisterToCookers: id={id}, index={index}, ts={timestamp}, checkPlayerHaveCooker={checkPlayerHaveCooker}");

        PrepAction.Send(PrepSceneManager.localPrepTable);
        return true;
    }

    [HarmonyPatch(nameof(IzakayaConfigure.LogoffFromDailyRecipes))]
    [HarmonyPrefix]
    public static void LogoffFromDailyRecipes_Prefix(int id)
    {
        Log.LogInfo($"LogoffFromDailyRecipes: {id}");
        PrepSceneManager.localPrepTable.RecipeDeletions[id] = MpManager.GetSynchronizedTimestampNow;
        PrepAction.Send(PrepSceneManager.localPrepTable);
    }

    [HarmonyPatch(nameof(IzakayaConfigure.LogoffFromDailyBeverages))]
    [HarmonyPrefix]
    public static void LogoffFromDailyBeverages_Prefix(int id)
    {
        Log.LogInfo($"LogoffFromDailyBeverages: {id}");
        PrepSceneManager.localPrepTable.BeverageDeletions[id] = MpManager.GetSynchronizedTimestampNow;
        PrepAction.Send(PrepSceneManager.localPrepTable);
    }

    [HarmonyPatch(nameof(IzakayaConfigure.LogOffFromCookers))]
    [HarmonyPrefix]
    public static void LogOffFromCookers_Prefix(int index)
    {
        Log.LogInfo($"LogOffFromCookers: {index}");
    }


    private static bool _skipPatchStoreFood = false;
    public static void StoreFood_Original(Sellable sellable, int messageSender = -1)
    {
        _skipPatchStoreFood = true;
        IzakayaConfigure.Instance.StoreFood(sellable, messageSender);
        _skipPatchStoreFood = false;
    }
    
    [HarmonyPatch(nameof(IzakayaConfigure.StoreFood))]
    [HarmonyPrefix]
    public static void StoreFood_Prefix(Sellable sellable)
    {
        Log.LogWarning(sellable.ToString());
        if (_skipPatchStoreFood) return;
        if (!MpManager.IsConnected) return;

        var food = SellableFood.FromSellable(sellable);
        StoreFoodAction.Send(food);
    }
    
}
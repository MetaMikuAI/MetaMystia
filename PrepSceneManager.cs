using System.Collections.Generic;
using BepInEx.Logging;
using UnityEngine;

namespace MetaMystia;

public class PrepSceneManager
{
    private static PrepSceneManager _instance;
    private static readonly object _lock = new object();
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[PrepSceneManager.cs]";

    private static long LastChangeTimeMs = 0;

    public static PrepTable localPrepTable = new PrepTable();

    public static int MaxRecipes = 8;
    public static int MaxBeverages = 8;
    public static int MaxCookers = 8;


    // instance 
    public static PrepSceneManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PrepSceneManager();
                    }
                }
            }
            return _instance;
        }
    }

    public enum PrepType
    {
        None = 0,
        Recipe,
        Beverage,
        Cooker,
    }

    public static void MergeFromPeer(PrepTable remotePrepTable)
    {
        bool changed = false;

        changed |= MergeDictionary(localPrepTable.RecipeAdditions, remotePrepTable.RecipeAdditions);
        changed |= MergeDictionary(localPrepTable.RecipeDeletions, remotePrepTable.RecipeDeletions);

        changed |= MergeDictionary(localPrepTable.BeverageAdditions, remotePrepTable.BeverageAdditions);
        changed |= MergeDictionary(localPrepTable.BeverageDeletions, remotePrepTable.BeverageDeletions);

        changed |= MergeDictionary(localPrepTable.CookersAdditions, remotePrepTable.CookersAdditions);
        changed |= MergeDictionary(localPrepTable.CookersDeletions, remotePrepTable.CookersDeletions);

        UpdateMaxLimits();

        // Check limits and trim if necessary
        changed |= CheckAndTrimLimit(localPrepTable.RecipeAdditions, localPrepTable.RecipeDeletions, MaxRecipes);
        changed |= CheckAndTrimLimit(localPrepTable.BeverageAdditions, localPrepTable.BeverageDeletions, MaxBeverages);
        changed |= CheckAndTrimLimit(localPrepTable.CookersAdditions, localPrepTable.CookersDeletions, MaxCookers);

        if (changed)
        {
            Log.LogInfo($"{LOG_TAG} Merged from peer, state changed.");
            PluginManager.Instance.RunOnMainThread(() =>
            {
                UpdateRecipes();
                UpdateBeverages();
            });
            UpdateUI();
        }
    }

    private static bool CheckAndTrimLimit(Dictionary<int, long> additions, Dictionary<int, long> deletions, int limit)
    {
        bool changed = false;
        // Find valid items
        var validItems = new List<KeyValuePair<int, long>>();
        foreach (var kvp in additions)
        {
            int id = kvp.Key;
            long addTs = kvp.Value;
            long delTs = deletions.ContainsKey(id) ? deletions[id] : 0;
            
            if (addTs > delTs)
            {
                validItems.Add(kvp);
            }
        }

        if (validItems.Count > limit)
        {
            // Sort by timestamp descending (latest first)
            validItems.Sort((a, b) => b.Value.CompareTo(a.Value));

            // Remove the latest items until count <= limit
            int removeCount = validItems.Count - limit;
            for (int i = 0; i < removeCount; i++)
            {
                var itemToRemove = validItems[i];
                deletions[itemToRemove.Key] = MpManager.GetSynchronizedTimestampNow;
                changed = true;
                Log.LogInfo($"{LOG_TAG} Trimmed item {itemToRemove.Key} due to limit.");
            }
        }
        return changed;
    }

    private static bool MergeDictionary(Dictionary<int, long> local, Dictionary<int, long> remote)
    {
        bool changed = false;
        foreach (var kvp in remote)
        {
            int id = kvp.Key;
            long ts = kvp.Value;
            if (!local.ContainsKey(id) || ts > local[id])
            {
                local[id] = ts;
                changed = true;
            }
        }
        return changed;
    }

    public static void UpdateRecipes()
    {
        var dailyRecipesList = GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.DailyRecipes;
        if (dailyRecipesList == null)
        {
            Log.LogError($"{LOG_TAG} DailyRecipes list is null!");
            return;
        }

        // Get all available recipes
        var allRecipes = GameData.RunTime.Common.RunTimeStorage.GetAllRecipes();
        // Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GameData.Core.Collections.Recipe> 
        // GameData.RunTime.Common.RunTimeStorage.GetAllRecipes()
        if (allRecipes == null) return;

        // Create a lookup for recipes by ID
        var recipeLookup = new Dictionary<int, GameData.Core.Collections.Recipe>();
        foreach (var recipe in allRecipes)
        {
            if (recipe != null && !recipeLookup.ContainsKey(recipe.Id))
            {
                recipeLookup[recipe.Id] = recipe;
            }
        }

        // Filter valid recipes from localPrepTable
        var validRecipes = new List<KeyValuePair<int, long>>();
        foreach (var kvp in localPrepTable.RecipeAdditions)
        {
            int id = kvp.Key;
            long addTs = kvp.Value;
            long delTs = localPrepTable.RecipeDeletions.ContainsKey(id) ? localPrepTable.RecipeDeletions[id] : 0;

            if (addTs > delTs)
            {
                validRecipes.Add(kvp);
            }
        }

        // Sort by timestamp ascending
        validRecipes.Sort((a, b) => a.Value.CompareTo(b.Value));

        // Update DailyRecipes
        dailyRecipesList.Clear();

        foreach (var kvp in validRecipes)
        {
            if (recipeLookup.TryGetValue(kvp.Key, out var recipe))
            {
                dailyRecipesList.Add(recipe);
            }
            else
            {
                Log.LogWarning($"{LOG_TAG} Recipe with ID {kvp.Key} not found in RunTimeStorage.");
            }
        }
        
        Log.LogInfo($"{LOG_TAG} Updated DailyRecipes with {dailyRecipesList.Count} items.");
    }

    public static void UpdateBeverages()
    {
        var dailyBeveragesList = GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.DailyBeverages;
        if (dailyBeveragesList == null)
        {
            Log.LogError($"{LOG_TAG} DailyBeverages list is null!");
            return;
        }

        // Get all available beverages
        // Returns Il2CppReferenceArray<KeyValuePair<Sellable, int>>
        var allBeverages = GameData.RunTime.Common.RunTimeStorage.GetAllBeverages(); 

        if (allBeverages == null) return;

        // Create a lookup for beverages by ID
        var beverageLookup = new Dictionary<int, GameData.Core.Collections.Sellable>();
        foreach (var kvp in allBeverages)
        {
            // kvp is Il2CppSystem.Collections.Generic.KeyValuePair<Sellable, int>
            var sellable = kvp.Key;
            if (sellable != null && !beverageLookup.ContainsKey(sellable.Id))
            {
                beverageLookup[sellable.Id] = sellable;
            }
        }

        // Filter valid beverages from localPrepTable
        var validBeverages = new List<KeyValuePair<int, long>>();
        foreach (var kvp in localPrepTable.BeverageAdditions)
        {
            int id = kvp.Key;
            long addTs = kvp.Value;
            long delTs = localPrepTable.BeverageDeletions.ContainsKey(id) ? localPrepTable.BeverageDeletions[id] : 0;

            if (addTs > delTs)
            {
                validBeverages.Add(kvp);
            }
        }

        // Sort by timestamp ascending
        validBeverages.Sort((a, b) => a.Value.CompareTo(b.Value));

        // Update DailyBeverages
        dailyBeveragesList.Clear();

        foreach (var kvp in validBeverages)
        {
            if (beverageLookup.TryGetValue(kvp.Key, out var sellable))
            {
                dailyBeveragesList.Add(sellable);
            }
            else
            {
                Log.LogWarning($"{LOG_TAG} Beverage with ID {kvp.Key} not found in RunTimeStorage.");
            }
        }
        
        Log.LogInfo($"{LOG_TAG} Updated DailyBeverages with {dailyBeveragesList.Count} items.");
    }

    public static void UpdateUI()
    {
        PluginManager.Instance.RunOnMainThread(() =>
    {
            IzakayaConfigPannelPatch.instanceRef.SolveDailyCompletion();
            IzakayaConfigPannelPatch.instanceRef.m_CookerGroup.UpdateGroupRaw();
            IzakayaConfigPannelPatch.instanceRef.m_BeverageGroup.UpdateGroupRaw();
            IzakayaConfigPannelPatch.instanceRef.m_RecipeGroup.UpdateGroupRaw();
        });
    }

    public static void UpdateMaxLimits()
    {
        switch (KyoukoManager.IzakayaLevel) 
        {
            case 1:
                MaxRecipes = 8;
                MaxBeverages = 8;
                MaxCookers = 3;
                break;
            case 2:
                MaxRecipes = 8;
                MaxBeverages = 8;
                MaxCookers = 6;
                break;
            case 3:
                MaxRecipes = 8;
                MaxBeverages = 8;
                MaxCookers = 8;
                break;
            default:
                MaxRecipes = 8;
                MaxBeverages = 8;
                MaxCookers = 8;
                break;
        }
    }
}
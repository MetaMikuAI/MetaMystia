using System;
using System.Collections.Generic;
using BepInEx.Logging;
using JetBrains.Annotations;

namespace MetaMystia;

public static class PrepSceneManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[PrepSceneManager.cs]";

    public static PrepAction.Table localPrepTable = new ();

    public static readonly int MaxRecipes = 8;
    public static readonly int MaxBeverages = 8;
    public static readonly int MaxCookers = 8; // 可信联机下双方都不会越界

    public static void MergeFromPeer(PrepAction.Table remotePrepTable)
    {
        bool changed = false;

        changed |= MergeDictionary(localPrepTable.RecipeAdditions, remotePrepTable.RecipeAdditions);
        changed |= MergeDictionary(localPrepTable.RecipeDeletions, remotePrepTable.RecipeDeletions);

        changed |= MergeDictionary(localPrepTable.BeverageAdditions, remotePrepTable.BeverageAdditions);
        changed |= MergeDictionary(localPrepTable.BeverageDeletions, remotePrepTable.BeverageDeletions);

        changed |= MergeCookers(remotePrepTable);

        // Check limits and trim if necessary
        changed |= CheckAndTrimLimit(localPrepTable.RecipeAdditions, localPrepTable.RecipeDeletions, MaxRecipes);
        changed |= CheckAndTrimLimit(localPrepTable.BeverageAdditions, localPrepTable.BeverageDeletions, MaxBeverages);

        if (changed)
        {
            Log.LogInfo($"{LOG_TAG} Merged from peer, state changed.");
            UpdateAll();
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

    private static bool MergeCookers(PrepAction.Table remotePrepTable)
    {
        if (remotePrepTable == null)
        {
            return false;
        }

        var remoteSlots = NormalizeCookerSlots(remotePrepTable.Cookers);
        var localSlots = EnsureLocalCookerSlots();

        bool changed = false;
        for (int i = 0; i < localSlots.Length; i++)
        {
            var remoteSlot = remoteSlots[i];
            var localSlot = localSlots[i];

            if (remoteSlot.Timestamp > localSlot.Timestamp ||
                (remoteSlot.Timestamp == localSlot.Timestamp && remoteSlot.Id != localSlot.Id))
            {
                localSlot.Id = remoteSlot.Id;
                localSlot.Timestamp = remoteSlot.Timestamp;
                changed = true;
            }
        }

        return changed;
    }

    internal static CookerSlot[] GetLocalCookerSlots()
    {
        return EnsureLocalCookerSlots();
    }

    private static CookerSlot[] EnsureLocalCookerSlots()
    {
        if (localPrepTable.Cookers == null)
        {
            localPrepTable.Cookers = CookerSlot.CreateDefaultArray();
        }

        var slots = localPrepTable.Cookers;
        if (slots.Length != CookerSlot.SlotsLength)
        {
            var normalized = CookerSlot.CreateDefaultArray();
            int limit = Math.Min(slots.Length, normalized.Length);
            for (int i = 0; i < limit; i++)
            {
                if (slots[i] != null)
                {
                    normalized[i].Id = slots[i].Id;
                    normalized[i].Timestamp = slots[i].Timestamp;
                }
            }

            localPrepTable.Cookers = normalized;
            slots = normalized;
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i] == null)
            {
                slots[i] = new CookerSlot();
            }
        }

        return slots;
    }

    private static CookerSlot[] NormalizeCookerSlots(CookerSlot[] source)
    {
        var normalized = CookerSlot.CreateDefaultArray();
        if (source == null)
        {
            return normalized;
        }

        int limit = Math.Min(source.Length, normalized.Length);
        for (int i = 0; i < limit; i++)
        {
            var slot = source[i];
            if (slot != null)
            {
                normalized[i].Id = slot.Id;
                normalized[i].Timestamp = slot.Timestamp;
            }
        }

        return normalized;
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
        // var allRecipes = GameData.RunTime.Common.RunTimeStorage.GetAllRecipes(); // 这个是拥有的而不是全部
        var allRecipes = Utils.recipes;
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
                Log.LogWarning($"{LOG_TAG} Recipe with ID {kvp.Key} not found in Utils.");
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
        // var allBeverages = GameData.RunTime.Common.RunTimeStorage.GetAllBeverages(); // 这个是拥有的而不是全部
        var allBeverages = Utils.sellables;

        if (allBeverages == null || allBeverages.Count == 0)
        {
            Log.LogWarning($"{LOG_TAG} Utils.sellables is empty; cannot update beverages.");
            dailyBeveragesList.Clear();
            return;
        }

        // Create a lookup for beverages by ID
        var beverageLookup = new Dictionary<int, GameData.Core.Collections.Sellable>();
        foreach (var sellable in allBeverages)
        {
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
                Log.LogWarning($"{LOG_TAG} Beverage (Sellable) with ID {kvp.Key} not found in Utils.sellables.");
            }
        }
        
        Log.LogInfo($"{LOG_TAG} Updated DailyBeverages with {dailyBeveragesList.Count} items.");
    }
    public static void UpdateCookers()
    {
        var cookerConfigure = GameData.RunTime.NightSceneUtility.IzakayaConfigure.Instance.CookerConfigure;
        if (cookerConfigure == null)
        {
            Log.LogError($"{LOG_TAG} CookerConfigure array is null!");
            return;
        }

        var sourceSlots = EnsureLocalCookerSlots();

        int usableLength = cookerConfigure.Length; // 该数组长度即为实际可用长度(3/6/8)

        for (int i = 0; i < usableLength; i++)
        {
            cookerConfigure[i] = sourceSlots[i].Id;
        }

        for (int i = usableLength; i < cookerConfigure.Length; i++)
        {
            cookerConfigure[i] = -1;
        }

        int activeCount = 0;
        for (int i = 0; i < usableLength; i++)
        {
            if (cookerConfigure[i] >= 0)
            {
                activeCount++;
            }
        }

        Log.LogInfo($"{LOG_TAG} Updated cookersList with {activeCount} active slots (limit {usableLength}).");
    }


    public static void UpdateGroups()
    {
        UpdateRecipes();
        UpdateBeverages();
        UpdateCookers();
    }
    public static void UpdateUI()
    {
        IzakayaConfigPannelPatch.instanceRef.SolveDailyCompletion();
        IzakayaConfigPannelPatch.instanceRef.m_CookerGroup.UpdateGroupRaw();
        IzakayaConfigPannelPatch.instanceRef.m_BeverageGroup.UpdateGroupRaw();
        IzakayaConfigPannelPatch.instanceRef.m_RecipeGroup.UpdateGroupRaw();
    }

    public static void UpdateAll()
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            UpdateGroups();
            UpdateUI();
        });
    }
}
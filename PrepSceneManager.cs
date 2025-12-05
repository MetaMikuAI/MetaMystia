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

    public static int MaxRecipes = 6;
    public static int MaxBeverages = 6;
    public static int MaxCookers = 6;


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

        // Check limits and trim if necessary
        changed |= CheckAndTrimLimit(localPrepTable.RecipeAdditions, localPrepTable.RecipeDeletions, MaxRecipes);
        changed |= CheckAndTrimLimit(localPrepTable.BeverageAdditions, localPrepTable.BeverageDeletions, MaxBeverages);
        changed |= CheckAndTrimLimit(localPrepTable.CookersAdditions, localPrepTable.CookersDeletions, MaxCookers);

        if (changed)
        {
            Log.LogInfo($"{LOG_TAG} Merged from peer, state changed.");
            // TODO: Trigger UI update or logic update here
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
}
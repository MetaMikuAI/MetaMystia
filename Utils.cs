using System;
using System.Collections.Generic;
using BepInEx.Logging;
using GameData.Core.Collections;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace MetaMystia;

public static class Utils
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[Utils.cs]";
    public static List<Sellable> beverages = new List<Sellable>();
    public static List<Sellable> sellables = new List<Sellable>();
    public static List<Recipe> recipes = new List<Recipe>();

    public static string GetMapNameCN(string mapLabel)
    {
        return mapLabel switch
        {
            "Home" => "夜雀小屋",
            "Basement" => "地下室",
            "BeastForest" => "妖怪兽道",
            "HumanVillage" => "人间之里",
            "HakureiShrine" => "博丽神社",
            "ScarletMansion" => "红魔馆",
            "BambooForest" => "迷途竹林",
            "PartyStage" => "舞台",
            "Hakugyokurou" => "白玉楼",
            "DLC1_MagicForest" => "魔法森林",
            "DLC1_YoukaiMountain" => "妖怪之山",
            "DLC2_FormerHell" => "旧地狱",
            "DLC2_EarthSpiritsPalace" => "地灵殿",
            "DLC3_MyourenTemple" => "命莲寺",
            "DLC3_DivineSpiritMausoleum" => "神灵庙",
            "DLC3_HakureiFestival" => "博丽大祭",
            "DLC4_GardenOfTheSun" => "太阳花田",
            "DLC4_ShiningNeedleCastle" => "辉针城",
            "DLC4_ScarletMansionBasement" => "红魔馆地下室",
            "DLC5_Makai" => "魔界",
            "DLC5_LunarCapital" => "月之都",
            _ => mapLabel
        };
    }
    
    public static void DumpSellableProfile(bool forceRefresh = false)
    {
        if (sellables.Count > 0 && !forceRefresh)
        {
            Log.LogInfo($"{LOG_TAG} SellableProfile already dumped, skipping.");
            return;
        }

        try
        {
            var sellableProfileType = Il2CppType.Of<GameData.Profile.SellableProfile>();
            var foundAssets = Resources.FindObjectsOfTypeAll(sellableProfileType);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} No SellableProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"{LOG_TAG} Found {foundAssets.Length} SellableProfile asset(s).");

            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var sellableProfile = foundAssets[assetIndex].TryCast<GameData.Profile.SellableProfile>();
                if (sellableProfile == null)
                {
                    Log.LogWarning($"{LOG_TAG} Object at index {assetIndex} could not be cast to SellableProfile.");
                    continue;
                }
                Log.LogInfo($"{LOG_TAG} Dumping contents of SellableProfile asset at index {assetIndex}:");
                foreach (var sellable in sellableProfile.sellables)
                {
                    sellables.Add(sellable);
                }
            }

        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to dump SellableProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }
    public static void DumpRecipeProfile(bool forceRefresh = false)
    {
        if (recipes.Count > 0 && !forceRefresh)
        {
            Log.LogInfo($"{LOG_TAG} RecipeProfile already dumped, skipping.");
            return;
        }

        recipes.Clear();

        try
        {
            var recipeProfileType = Il2CppType.Of<GameData.Profile.RecipeProfile>();
            var foundAssets = Resources.FindObjectsOfTypeAll(recipeProfileType);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} No RecipeProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"{LOG_TAG} Found {foundAssets.Length} RecipeProfile asset(s).");

            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var recipeProfile = foundAssets[assetIndex].TryCast<GameData.Profile.RecipeProfile>();
                if (recipeProfile == null)
                {
                    Log.LogWarning($"{LOG_TAG} Object at index {assetIndex} could not be cast to RecipeProfile.");
                    continue;
                }
                Log.LogInfo($"{LOG_TAG} Dumping contents of RecipeProfile asset at index {assetIndex}:");
                foreach (var recipe in recipeProfile.recipes)
                {
                    recipes.Add(recipe);
                    Log.LogInfo($"{LOG_TAG} {recipe.id}");
                }
            }

        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to dump SellableProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }
};


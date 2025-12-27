using System;
using System.IO;
using Il2CppInterop.Runtime;
using UnityEngine;


namespace MetaMystia;

[AutoLog]
public static partial class Utils
{
    public static string GetMapLabelNameCN(string mapLabel)
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

    public static string GetMapLevelNameCN(int level)
    {
        return level switch
        {
            1 => "推车",
            2 => "小屋",
            3 => "食堂",
            _ => $"Level {level}",
        };
    }

    public static void test()
    {
        var Ingredients = GameData.CoreLanguage.Collections.DataBaseLanguage.Ingredients;
        foreach (var kvp in Ingredients)
        {
            Log.LogInfo($"Ingredient ID: {kvp.Key}, Name: {kvp.Value.ToString()}");
        }
    }
    public static Sprite GetArtWork(string filePath)
    {
        if (!File.Exists(filePath)) return null;

        var texture2D = new Texture2D(2, 2);
        texture2D.filterMode = FilterMode.Point; 
        
        byte[] fileData = File.ReadAllBytes(filePath);
        ImageConversion.LoadImage(texture2D, fileData);
        
        var sprite = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height),
            new Vector2(0.5f, 0.5f), 100f);
            
        sprite.name = Path.GetFileNameWithoutExtension(filePath);
        return sprite;
    }

    public static void FindAndProcessResources<T>(Action<T> action) where T : UnityEngine.Object
    {
        try
        {
            var type = Il2CppType.Of<T>();
            var foundAssets = Resources.FindObjectsOfTypeAll(type);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"No {typeof(T).Name} assets found in memory.");
                return;
            }

            Log.LogDebug($"Found {foundAssets.Length} {typeof(T).Name} asset(s).");

            for (var i = 0; i < foundAssets.Length; i++)
            {
                var asset = foundAssets[i].TryCast<T>();
                if (asset == null) continue;
                action(asset);
            }
        }
        catch (Exception e)
        {
            Log.LogError($"Failed to process {typeof(T).Name} contents: {e.Message}\n{e.StackTrace}");
        }
    }
};


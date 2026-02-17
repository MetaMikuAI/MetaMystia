using System;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using BepInEx;
using GameData.Core.Collections.CharacterUtility;
using SgrYuki.Utils;
using UnityEngine;

namespace MetaMystia;

/// <summary>
/// 这是一个导出工具类，提供将游戏内资源导出为外部文件的功能，方便美术创作者进行符合原游戏 Sprite 规格的二次创作。
/// 理论上不应在运行时调用此类方法，建议在调试阶段使用后移除相关调用。
/// </summary>
[AutoLog]
public static partial class ExportUtils
{
    public static string ExportRoot { get; set; } = Path.Combine(Paths.GameRootPath, "Exports");

    public static void ExportAllFoodSprite(string exportDir)
    {

        var allFood = GameData.CoreLanguage.Collections.DataBaseLanguage.Foods;
        foreach (var kvp in allFood)
        {
            Log.Warning($"Food ID: {kvp.Key}, BriefName: {kvp.Value.BriefName}, BriefDescription: {kvp.Value.BriefDescription}");
            Sprite sprite = kvp.Value.Visual;
            if (sprite != null)
            {
                var filename = $"Food_{kvp.Key}_{kvp.Value.BriefName}.png";
                var filepath = Path.Combine(exportDir, filename);

                TrySaveSprite(sprite, filepath);
                Log.LogInfo($"Exported: {filepath}");
            }
            else
            {
                Log.LogWarning($"Food ID {kvp.Key} has no sprite.");
            }
        }
    }


    public static void ExportAllSpellSprite(string exportDir)
    {
        var allSpellCardLang = GameData.CoreLanguage.Collections.DataBaseLanguage.SpellLang;

        var allSpellCards = GameData.Core.Collections.NightSceneUtility.DataBaseNight.SpecialGuestSpellPortrayal;
        foreach (var kvp in allSpellCards)
        {
            var spellLang = allSpellCardLang.TryGetValue(kvp.Key, out var lang) ? lang : null;
            string positiveLang = spellLang != null && spellLang.Length > 0 ? spellLang[0]?.Name : "N/A";
            string negativeLang = spellLang != null && spellLang.Length > 1 ? spellLang[1]?.Name : "N/A";
            Log.Warning($"SpellCard ID: {kvp.Key} name: {positiveLang}/{negativeLang}");
            var positiveSpell = kvp.Value.Item1;
            var negativeSpell = kvp.Value.Item2;
            var sprite1 = positiveSpell.Asset.TryCast<Sprite>();
            if (sprite1 != null)
            {
                Log.LogInfo($"Exporting SpellCard {kvp.Key} - {positiveLang}");
                TrySaveSprite(sprite1, Path.Combine(exportDir, $"符卡_{kvp.Key}_奖励_{(positiveLang == "N/A" ? "Unknown" : positiveLang)}.png"));
            }
            var sprite2 = negativeSpell.Asset.TryCast<Sprite>();
            if (sprite2 != null)
            {
                Log.LogInfo($"Exporting SpellCard {kvp.Key} - {negativeLang}");
                TrySaveSprite(sprite2, Path.Combine(exportDir, $"符卡_{kvp.Key}_惩罚_{(negativeLang == "N/A" ? "Unknown" : negativeLang)}.png"));
            }
        }
    }

    public static void ExportAllPortrayals(string exportDir)
    {
        if (!Directory.Exists(exportDir))
            Directory.CreateDirectory(exportDir);

        var specialGuestPortrayals = DataBaseCharacter.SpecialGuestVisual;
        if (specialGuestPortrayals == null)
        {
            Log.LogError("DataBaseCharacter.SpecialGuestVisual is null");
            return;
        }

        foreach (var kvp in specialGuestPortrayals)
        {
            var id = kvp.Key;
            var visualData = kvp.Value;

            if (visualData == null || visualData.characterPortrayal == null || visualData.characterPortrayal.defaultPortrayal == null)
                continue;

            var portrayals = visualData.characterPortrayal.defaultPortrayal.m_VisualAssetAtlasReference;
            if (portrayals == null) continue;

            for (int i = 0; i < portrayals.Length; i++)
            {
                var assetRef = portrayals[i];
                if (assetRef == null) continue;

                Sprite sprite = null;
                if (assetRef.Asset != null)
                {
                    sprite = assetRef.Asset.TryCast<Sprite>();
                }

                if (sprite == null)
                {
                    var handle = assetRef.LoadAssetAsync<Sprite>();
                    sprite = handle.WaitForCompletion();
                }

                if (sprite != null)
                {
                    var subObjectName = assetRef.SubObjectName;
                    if (string.IsNullOrEmpty(subObjectName)) subObjectName = "Unnamed";

                    foreach (var c in Path.GetInvalidFileNameChars())
                    {
                        subObjectName = subObjectName.Replace(c, '_');
                    }

                    var filename = $"Special_{id}_{i}_{subObjectName}.png";
                    var filepath = Path.Combine(exportDir, filename);

                    TrySaveSprite(sprite, filepath);
                    Log.LogInfo($"Exported: {filepath}");
                }
                else
                {
                    Log.LogWarning($"Failed to load sprite for Special_{id}_{i}");
                }
            }
        }
    }

    public static void ExportAllSpriteCompact()
    {
        string exportDir = "E:/Desktop/TMI/SpriteCompacts";
        if (!Directory.Exists(exportDir))
            Directory.CreateDirectory(exportDir);

        Utils.FindAndProcessResources<CharacterSpriteSetCompact>(spriteSet =>
        {
            if (spriteSet == null || spriteSet.mainSprite == null)
                return;

            foreach (var eye in spriteSet.eyeSprite)
            {
                var filename = $"{eye.name}.png";
                var filepath = Path.Combine(exportDir, spriteSet.name, filename);
                Log.Warning($"Exporting eye sprite: {filepath}");
                TrySaveSprite(eye, filepath);
            }
            foreach (var main in spriteSet.mainSprite)
            {
                var filename = $"{main.name}.png";
                var filepath = Path.Combine(exportDir, spriteSet.name, filename);
                Log.Warning($"Exporting main sprite: {filepath}");
                TrySaveSprite(main, filepath);
            }
            Log.Warning($"Exported sprite set: {spriteSet.name}");
        });
    }
    public static void TrySaveSprite(Sprite sprite, string filepath)
    {
        Texture2D readableTexture = null;
        Texture2D finalTexture = null;
        try
        {
            var originalTexture = sprite.texture;
            var rect = sprite.textureRect;

            // 1. 提取裁剪后的区域 (readableTexture)
            if (!originalTexture.isReadable)
            {
                // 使用 RenderTexture 复制不可读的纹理
                var rt = RenderTexture.GetTemporary(
                    originalTexture.width,
                    originalTexture.height,
                    0,
                    RenderTextureFormat.ARGB32,
                    RenderTextureReadWrite.Default);

                Graphics.Blit(originalTexture, rt);
                var previous = RenderTexture.active;
                RenderTexture.active = rt;

                // 创建临时的完整纹理
                var tempFullTexture = new Texture2D(originalTexture.width, originalTexture.height, TextureFormat.RGBA32, false);
                tempFullTexture.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
                tempFullTexture.Apply();

                RenderTexture.active = previous;
                RenderTexture.ReleaseTemporary(rt);

                // 从完整纹理中提取 Sprite 区域
                readableTexture = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGBA32, false);
                var pixels = tempFullTexture.GetPixels((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height);
                readableTexture.SetPixels(pixels);
                readableTexture.Apply();

                // 立即销毁临时纹理
                UnityEngine.Object.DestroyImmediate(tempFullTexture);
            }
            else
            {
                // 纹理可读，直接提取 Sprite 区域
                readableTexture = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGBA32, false);
                var pixels = originalTexture.GetPixels((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height);
                readableTexture.SetPixels(pixels);
                readableTexture.Apply();
            }

            // 2. 创建目标画布并根据偏移放置
            int targetWidth = Mathf.RoundToInt(sprite.rect.width);
            int targetHeight = Mathf.RoundToInt(sprite.rect.height);
            finalTexture = new Texture2D(targetWidth, targetHeight, TextureFormat.RGBA32, false);

            // 填充透明背景
            Color[] transparent = new Color[targetWidth * targetHeight];
            for (int i = 0; i < transparent.Length; i++) transparent[i] = Color.clear;
            finalTexture.SetPixels(transparent);

            // 获取偏移并放置
            Vector2 offset = sprite.textureRectOffset;
            finalTexture.SetPixels(Mathf.RoundToInt(offset.x), Mathf.RoundToInt(offset.y), (int)rect.width, (int)rect.height, readableTexture.GetPixels());
            finalTexture.Apply();

            byte[] pngData = ImageConversion.EncodeToPNG(finalTexture);
            var directory = Path.GetDirectoryName(filepath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.WriteAllBytes(filepath, pngData);
        }
        finally
        {
            if (readableTexture != null)
            {
                UnityEngine.Object.DestroyImmediate(readableTexture);
            }
            if (finalTexture != null)
            {
                UnityEngine.Object.DestroyImmediate(finalTexture);
            }
        }
    }
    public static string DumpDataBase(string exportDir = null)
    {
        var recipesList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.Core.Collections.DataBaseCore.Recipes)
        {
            var recipe = kvp.Value;
            recipesList.Add(new
            {
                id = recipe.Id,
                foodId = recipe.FoodID,
                ingredients = recipe.Ingredients,
                baseCookTime = recipe.BaseCookTime,
                cookerType = recipe.CookerType.ToString()
            });
        }

        var foodsList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.Core.Collections.DataBaseCore.Foods)
        {
            var food = kvp.Value;
            object tags = null;
            try { tags = food.Tags; } catch { }

            foodsList.Add(new
            {
                id = food.Id,
                briefName = food.Text.BriefName,
                briefDescription = food.Text.BriefDescription,
                level = food.Level,
                tags = tags,
                baseValue = food.BaseValue,
            });
        }

        var ingredientsList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.Core.Collections.DataBaseCore.Ingredients)
        {
            var ingredient = kvp.Value;
            object tags = null;
            try { tags = ingredient.Tags; } catch { }

            ingredientsList.Add(new
            {
                id = ingredient.Id,
                name = ingredient.Text.BriefName,
                description = ingredient.Text.BriefDescription,
                level = ingredient.Level,
                prefix = ingredient.Prefix,
                isFish = ingredient.IsFish,
                isMeat = ingredient.IsMeat,
                isVeg = ingredient.IsVeg,
                baseValue = ingredient.BaseValue,
                tags = tags
            });
        }

        var beverageList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.Core.Collections.DataBaseCore.Beverages)
        {
            var beverage = kvp.Value;
            object tags = null;
            try { tags = beverage.Tags; } catch { }

            beverageList.Add(new
            {
                id = beverage.Id,
                briefName = beverage.Text.BriefName,
                briefDescription = beverage.Text.BriefDescription,
                level = beverage.Level,
                tags = tags,
                baseValue = beverage.BaseValue,
            });
        }

        var foodTagsList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.CoreLanguage.Collections.DataBaseLanguage.FoodTags)
        {
            foodTagsList.Add(new
            {
                id = kvp.Key,
                name = kvp.Value,
            });
        }

        var bevTagsList = new System.Collections.Generic.List<object>();
        foreach (var kvp in GameData.CoreLanguage.Collections.DataBaseLanguage.BeverageTags)
        {
            bevTagsList.Add(new
            {
                id = kvp.Key,
                name = kvp.Value,
            });
        }


        var data = new
        {
            recipes = recipesList,
            foods = foodsList,
            ingredients = ingredientsList,
            beverages = beverageList,
            foodTags = foodTagsList,
            beverageTags = bevTagsList
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = JsonSerializer.Serialize(data, options);

        if (!string.IsNullOrEmpty(exportDir))
        {
            if (!Directory.Exists(exportDir))
            {
                Directory.CreateDirectory(exportDir);
            }
            string filePath = Path.Combine(exportDir, "database.json");
            File.WriteAllText(filePath, json);
            Log.LogInfo($"Database dumped to {filePath}");
        }

        Log.LogInfo("Dumped database.");
        return json;
    }

    public static void ExportAllSelfClothesSprite()
    {
        string exportDir = Path.Combine(ExportRoot, "SelfClothes");
        if (!Directory.Exists(exportDir))
            Directory.CreateDirectory(exportDir);



        DumpClothesSprite(DataBaseCharacter.SelfSpriteSet.defaultSkin, exportDir);

        foreach (var clothes in DataBaseCharacter.SelfSpriteSet.explicits)
        {
            DumpClothesSprite(clothes, exportDir);
        }
    }

    public static void ExportBaseSprite()
    {
        Il2CppSystem.Collections.Generic.IReadOnlyList<Sprite> baseSprite = GameData.Core.Collections.CharacterUtility.CharacterSpriteSetFull.BaseSprite; // LENGTH = 12
        for (int i = 0; i < 12; i++)
        {
            var sprite = baseSprite[i];
            if (sprite != null)
            {
                var filename = $"Base_{i / 3}, {i % 3}.png";
                var filepath = Path.Combine(ExportRoot, filename);
                Log.Warning($"Exporting base sprite: {filepath}");
                TrySaveSprite(sprite, filepath);
            }
        }
    }
    public static void DumpClothesSprite(CharacterSpriteSetCompact clothes, string exportDir)
    {
        Sprite[] mainSprites = clothes.MainSprite;
        Sprite[] eyeSprites = clothes.EyeSprite;
        Sprite[] hairSprites = clothes.HairSprite;
        Sprite[] backSprites = clothes.BackSprite;
        string clothesName = clothes.name;
        for (int i = 0; i < mainSprites.Length; i++)
        {
            var main = mainSprites[i];
            if (main != null)
            {
                var filename = $"{clothesName}/Main_{i / 3}, {i % 3}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting self clothes main sprite: {filepath}");
                TrySaveSprite(main, filepath);
            }
        }
        for (int i = 0; i < eyeSprites.Length; i++)
        {
            var eye = eyeSprites[i];
            if (eye != null)
            {
                var filename = $"{clothesName}/Eyes_{i / 4}, {i % 4}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting self clothes eye sprite: {filepath}");
                TrySaveSprite(eye, filepath);
            }
        }
        for (int i = 0; i < hairSprites.Length; i++)
        {
            var hair = hairSprites[i];
            if (hair != null)
            {
                var filename = $"{clothesName}/Hair_{i / 3}, {i % 3}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting self clothes hair sprite: {filepath}");
                TrySaveSprite(hair, filepath);
            }
        }
        for (int i = 0; i < backSprites.Length; i++)
        {
            var back = backSprites[i];
            if (back != null)
            {
                var filename = $"{clothesName}/Back_{i / 3}, {i % 3}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting self clothes back sprite: {filepath}");
                TrySaveSprite(back, filepath);
            }
        }
    }

    // 错误的使用
    public static void ExportAllClothesPortrait()
    {
        string exportDir = Path.Combine(ExportRoot, "ClothesPortraits");
        if (!Directory.Exists(exportDir))
            Directory.CreateDirectory(exportDir);

        foreach (var clothes in DataBaseCharacter.SelfPortrayalSet.explicitPortrayals)
        {
            var sprite = clothes.m_VisualAssetAtlasReference[0].Asset.TryCast<Sprite>();
            if (sprite != null)
            {
                var filename = $"{clothes.name}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting self clothes portrait sprite: {filepath}");
                TrySaveSprite(sprite, filepath);
            }
        }
    }
    public static void ExportAllClothesItemIcon()
    {
        string exportDir = Path.Combine(ExportRoot, "ClothesItemIcons");
        if (!Directory.Exists(exportDir))
            Directory.CreateDirectory(exportDir);

        GameData.Core.Collections.DataBaseCore.Items.ToList().Where(x => x.Value.IsClothes).ToList().ForEach(x =>
        {
            var item = x.Value;
            var sprite = item.Text.Visual;
            if (sprite != null)
            {
                var filename = $"ClothItem_{x.Key}.png";
                var filepath = Path.Combine(exportDir, filename);
                Log.Warning($"Exporting cloth item icon: {filepath}");
                TrySaveSprite(sprite, filepath);
            }
        });
    }
}

using System.Collections.Generic;
using System.Linq;

using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage.Collections;

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

using MetaMystia.ResourceEx.Models;


namespace MetaMystia;


public static partial class ResourceExManager
{
    /// <summary>
    /// 判断一个服装ID是否由 ResourceEx 注册
    /// </summary>
    public static bool IsResourceExCloth(int clothId) => ClothConfigs.ContainsKey(clothId);

    /// <summary>
    /// 获取 ResourceEx 注册的服装立绘 Sprite（用于 SetupPortrayalVisual 中动态替换）
    /// </summary>
    public static bool TryGetClothPortrait(int clothId, out Sprite portrait)
    {
        if (_clothPortraitCache.TryGetValue(clothId, out portrait))
            return portrait != null;

        if (!ClothConfigs.TryGetValue(clothId, out var config) || string.IsNullOrEmpty(config.portraitPath))
        {
            portrait = null;
            return false;
        }

        portrait = GetSprite(config.portraitPath, config.PackageRoot, useCache: false);
        _clothPortraitCache[clothId] = portrait;
        return portrait != null;
    }


    // ========== Part 1: Item 注册 (DataBaseCore 初始化后) ==========

    private static void RegisterAllClothItems()
    {
        Log.Info("Registering all cloth Items from ResourceEx...");
        foreach (var config in ClothConfigs.Values)
        {
            RegisterClothItem(config);
        }
    }

    private static void RegisterClothItem(ClothConfig config)
    {
        var item = new Item(config.id);
        DataBaseCore.Items[config.id] = item;
        Log.Info($"Registered cloth Item ID {config.id} ({config.name})");
    }


    // ========== Part 2: ClothesProfile 注册 (DataBaseCore 初始化后) ==========

    private static void RegisterAllClothProfiles()
    {
        Log.Info("Registering all cloth profiles from ResourceEx...");

        // 按 ID 排序分配 skinIndex，因为 dlcs[] 是空的，索引从 0 开始依次分配
        var sortedConfigs = ClothConfigs.Values.OrderBy(c => c.id).ToList();

        for (int i = 0; i < sortedConfigs.Count; i++)
        {
            RegisterClothProfile(sortedConfigs[i], skinDlcIndex: i);
        }
    }

    private static void RegisterClothProfile(ClothConfig config, int skinDlcIndex)
    {
        // 使用已有服装作为模板获取必需的 OverrideVisualAsset 引用
        var templateClothProfile = DataBaseCore.Clothes[-1];

        var clothProfile = new GameData.Profile.ClothesProfile.Clothes()
        {
            index = config.id,
            frameTime = 0f,
            izakayaSkinIndex = -1,
            izkayaHorizontalOffset = 0f,
            m_OverrideDynamicVisualAsset = null,
            m_OverrideVisualAsset = templateClothProfile.m_OverrideVisualAsset,
            notebookHorizontalOffset = 0f,
            notebookVerticalOffset = 0f,
            skinIndex = new CharacterSkinSets.SkinSelectionInfo()
            {
                index = skinDlcIndex,
                selectedType = CharacterSkinSets.SelectedType.DLC
            },
        };

        DataBaseCore.Clothes[config.id] = clothProfile;
        Log.Info($"Registered cloth profile ID {config.id} ({config.name}), skinDlcIndex={skinDlcIndex}");
    }


    // ========== Part 3: Language 注册 (DataBaseLanguage 初始化后) ==========

    private static void RegisterAllClothLanguages()
    {
        Log.Info("Registering all cloth languages from ResourceEx...");
        foreach (var config in ClothConfigs.Values)
        {
            RegisterClothLanguage(config);
        }
    }

    private static void RegisterClothLanguage(ClothConfig config)
    {
        Sprite sprite = null;
        if (!string.IsNullOrEmpty(config.spritePath))
        {
            sprite = GetSprite(config.spritePath, config.PackageRoot, new Vector2(0.5f, 0.5f), 26, 26);
        }

        var lang = new GameData.CoreLanguage.ObjectLanguageBase(
            name: config.name,
            Description: config.description ?? "",
            visual: sprite);

        DataBaseLanguage.Items[config.id] = lang;
        Log.Info($"Registered cloth language ID {config.id} ({config.name})");
    }


    // ========== Part 4: 像素精灵注册 (DataBaseCharacter 初始化后) ==========

    private static void RegisterAllClothPixelSprites()
    {
        Log.Info("Registering all cloth pixel sprites to SelfSpriteSet.dlcs...");

        if (ClothConfigs.Count == 0)
        {
            Log.Info("No cloth configs to register.");
            return;
        }

        // 按 ID 排序，与 RegisterAllClothProfiles 中的顺序一致，保证 skinIndex 对应
        var sortedConfigs = ClothConfigs.Values.OrderBy(c => c.id).ToList();

        // 构建 dlcs 数组
        var dlcsArray = new Il2CppReferenceArray<CharacterSpriteSetCompact>(sortedConfigs.Count);

        for (int i = 0; i < sortedConfigs.Count; i++)
        {
            var config = sortedConfigs[i];
            if (config.pixelFullConfig != null)
            {
                var pixelFull = MakePixelFull(config.pixelFullConfig, config.PackageRoot);
                _clothPixelFullCache[i] = pixelFull;
                dlcsArray[i] = pixelFull; // CharacterSpriteSetFull 继承自 CharacterSpriteSetCompact
                Log.Info($"Built cloth pixel full for ID {config.id} ({config.name}), dlcIndex={i}");
            }
            else
            {
                Log.LogWarning($"Cloth ID {config.id} ({config.name}) has no pixelFullConfig, using fallback.");
                dlcsArray[i] = DataBaseCharacter.FallbackFullPixel;
            }
        }

        DataBaseCharacter.SelfSpriteSet.dlcs = dlcsArray;
        Log.Info($"Registered {sortedConfigs.Count} cloth pixel sprites to SelfSpriteSet.dlcs");
    }


    // ========== Pixel 工具方法 ==========

    public static CharacterSpriteSetCompact GetCharacterSpriteSetCompact(string name)
    {
        return _characterSpriteSets.TryGetValue(name, out var spriteSet) ? spriteSet : null;
    }

    public static CharacterSpriteSetCompact MakePixel(CharacterSpriteSetCompactConfig pixelConfig, string packageRoot)
    {
        var template = DataBaseCharacter.FallbackCompactPixel;

        var pixel = ScriptableObject.CreateInstance<CharacterSpriteSetCompact>();

        var mainSprites = CopySpriteArray(template.MainSprite);
        var eyeSprites = CopySpriteArray(template.EyeSprite);

        ApplySprites(mainSprites, pixelConfig.mainSprite, packageRoot);
        ApplySprites(eyeSprites, pixelConfig.eyeSprite, packageRoot);

        pixel.Initialize(
            mainSprites,
            template.DoNotUseEyeSprite,
            eyeSprites,
            template.HasPrebakedShadow,
            template.AnimationSpeedMultiplier,
            template.ExtraYOffset,
            template.IsHina,
            template.RotatePerTime,
            template.DoNotHaveStepVFX,
            template.MoveSpeedMultiplier,
            template.RemovableTrims,
            template.TrimSpritesDisplayFront,
            template.TrimSpritesDisplayBack,
            template.TrimFrontSpriteFrameSpeed,
            template.TrimBackSpriteFrameSpeed
        );

        _characterSpriteSets[pixelConfig.name] = pixel;
        return pixel;
    }

    public static CharacterSpriteSetFull MakePixelFull(CharacterSpriteSetFullConfig pixelConfig, string packageRoot)
    {
        var template = DataBaseCharacter.FallbackFullPixel;

        var mainSprites = CopySpriteArray(template.MainSprite);
        var eyeSprites = CopySpriteArray(template.EyeSprite);
        var hairSprites = CopySpriteArray(template.HairSprite);
        var backSprites = CopySpriteArray(template.BackSprite);

        ApplySprites(mainSprites, pixelConfig.mainSprite, packageRoot);
        ApplySprites(eyeSprites, pixelConfig.eyeSprite, packageRoot);
        ApplySprites(hairSprites, pixelConfig.hairSprite, packageRoot);
        ApplySprites(backSprites, pixelConfig.backSprite, packageRoot);

        var pixelFull = ScriptableObject.CreateInstance<CharacterSpriteSetFull>();
        pixelFull.Initialize(
            mainSprites,
            template.DoNotUseEyeSprite,
            eyeSprites,
            hairSprites,
            backSprites,
            template.HasPrebakedShadow,
            template.AnimationSpeedMultiplier,
            template.ExtraYOffset,
            template.IsHina,
            template.RotatePerTime,
            template.DoNotHaveStepVFX,
            template.MoveSpeedMultiplier,
            template.RemovableTrims,
            template.TrimSpritesDisplayFront,
            template.TrimSpritesDisplayBack,
            0f,
            0f
        );
        return pixelFull;
    }


    private static Il2CppReferenceArray<Sprite> CopySpriteArray(Il2CppReferenceArray<Sprite> source)
    {
        if (source == null) return null;
        var newArray = new Il2CppReferenceArray<Sprite>(source.Length);
        for (int i = 0; i < source.Length; i++)
        {
            newArray[i] = source[i];
        }

        return newArray;
    }

    private static void ApplySprites(Il2CppReferenceArray<Sprite> targetArray, List<string> spritePaths, string packageRoot,
        int pixelOffsetX = 0, int pixelOffsetY = 0)
    {
        if (spritePaths == null) return;

        if (targetArray == null)
        {
            Log.LogError($"Target array is null but sprite paths were provided. Cannot apply sprites.");
            return;
        }

        if (spritePaths.Count != targetArray.Length)
        {
            Log.LogError(
                $"Sprite count mismatch! Expected {targetArray.Length}, got {spritePaths.Count}. Refusing to load sprites.");
            return;
        }

        for (int i = 0; i < spritePaths.Count; i++)
        {
            string path = spritePaths[i];
            if (string.IsNullOrEmpty(path)) continue;

            var sprite = ResourceExManager.GetSprite(path, packageRoot, new Vector2(0.5f, 0.0f), 64, 64, pixelOffsetX, pixelOffsetY);

            if (sprite != null)
            {
                targetArray[i] = sprite;
            }
        }
    }
}

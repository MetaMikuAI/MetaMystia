using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using GameData.Core.Collections.CharacterUtility;
using MetaMystia.ResourceEx.Models;
using System.Linq;
using HarmonyLib;

namespace MetaMystia;
public static partial class ResourceExManager
{
    public static Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();
    private static Dictionary<int, CharacterSpriteSetCompact> _spriteSetCompacts = new Dictionary<int, CharacterSpriteSetCompact>();

    public static Sprite GetSprite(string relativePath, string modRoot = null, Vector2? pivot = null, int width = 0, int height = 0, int pixelOffsetX = 0, int pixelOffsetY = 0, bool useCache = true)
    {
        if (string.IsNullOrEmpty(relativePath)) 
        {
            Log.LogWarning($"GetSprite called with empty relativePath.");
            return null;
        }

        string fullPath = string.IsNullOrEmpty(modRoot) 
            ? Path.Combine(ResourceRoot, relativePath) 
            : Path.Combine(modRoot, relativePath);

        Vector2 actualPivot = pivot ?? new Vector2(0.5f, 0.5f);
        string cacheKey = $"{fullPath}_{actualPivot.x}_{actualPivot.y}_{width}_{height}_{pixelOffsetX}_{pixelOffsetY}";

        if (useCache && _spriteCache.TryGetValue(cacheKey, out var sprite))
        {
            if (sprite != null && sprite.texture != null)
            {
                return sprite;
            }
            _spriteCache.Remove(cacheKey);
        }

        Log.LogInfo($"Loading sprite at {fullPath}");
        sprite = Utils.GetArtWork(fullPath, actualPivot, width, height, pixelOffsetX, pixelOffsetY);
        if (sprite != null)
        {
            sprite.hideFlags = HideFlags.HideAndDontSave;
            if (sprite.texture != null)
            {
                sprite.texture.hideFlags = HideFlags.HideAndDontSave;
            }
            _spriteCache[cacheKey] = sprite;
        }
        else
        {
            Log.LogWarning($"Failed to load sprite at {fullPath}");
        }
        return sprite;
    }

    public static void PreloadAllImages()
    {
        Log.LogInfo($"Preloading all images...");
        foreach (var charConfig in GetAllCharacterConfigs())
        {
            // Preload Portraits
            if (charConfig.portraits != null)
            {
                foreach (var portrait in charConfig.portraits)
                {
                    if (!string.IsNullOrEmpty(portrait.path))
                    {
                        // Default params for portraits: pivot (0.5, 0.5), no resize
                        GetSprite(portrait.path, charConfig.ModRoot); 
                    }
                }
            }

            // Preload SpriteSetCompact
            if (charConfig.characterSpriteSetCompact != null)
            {
                var config = charConfig.characterSpriteSetCompact;
                if (config.mainSprite != null)
                {
                    foreach (var path in config.mainSprite)
                    {
                        if (!string.IsNullOrEmpty(path))
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.ModRoot, new Vector2(0.5f, 0.0f), 64, 64);
                    }
                }
                if (config.eyeSprite != null)
                {
                    foreach (var path in config.eyeSprite)
                    {
                        if (!string.IsNullOrEmpty(path))
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.ModRoot, new Vector2(0.5f, 0.0f), 64, 64);
                    }
                }
            }
        }
        Log.LogInfo($"Preloading complete. Cache size: {_spriteCache.Count}");
    }

    public static void TryInjectAllSpriteSetCompact()
    {
        CharacterSpriteSetCompact template = DataBaseCharacter.SpecialGuest[0].CharacterPixel;

        if (template == null)
        {
            Log.LogWarning($"Failed to find any CharacterSpriteSetCompact template! This is expected if called before any character assets are loaded.");
            return;
        }

        GetAllCharacterConfigs()
            .Where(c => c.characterSpriteSetCompact != null)
            .ToList()
            .ForEach(c => CreateAndRegisterSpriteSet(c, template));

    }

    private static void CreateAndRegisterSpriteSet(CharacterConfig charConfig, CharacterSpriteSetCompact template)
    {
        var newSpriteSet = ScriptableObject.CreateInstance<CharacterSpriteSetCompact>();
        newSpriteSet.name = charConfig.characterSpriteSetCompact.name;

        // Prepare arrays
        var mainSprites = CopySpriteArray(template.MainSprite);
        var eyeSprites = CopySpriteArray(template.EyeSprite);

        var config = charConfig.characterSpriteSetCompact;
        
        ApplySprites(mainSprites, config.mainSprite, charConfig.ModRoot);
        ApplySprites(eyeSprites, config.eyeSprite, charConfig.ModRoot);

        newSpriteSet.Initialize(
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
        
        _spriteSetCompacts[charConfig.id] = newSpriteSet;
        Log.LogInfo($"Loaded CharacterSpriteSetCompact for {charConfig.name} ({charConfig.id})");
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

    private static void ApplySprites(Il2CppReferenceArray<Sprite> targetArray, List<string> spritePaths, string modRoot, int pixelOffsetX = 0, int pixelOffsetY = 0)
    {
        if (spritePaths == null) return;

        if (targetArray == null)
        {
            Log.LogError($"Target array is null but sprite paths were provided. Cannot apply sprites.");
            return;
        }

        if (spritePaths.Count != targetArray.Length)
        {
            Log.LogError($"Sprite count mismatch! Expected {targetArray.Length}, got {spritePaths.Count}. Refusing to load sprites.");
            return;
        }

        for (int i = 0; i < spritePaths.Count; i++)
        {
            string path = spritePaths[i];
            if (string.IsNullOrEmpty(path)) continue;

            // Use GetSprite with caching, matching the parameters used for SpriteSetCompact
            var sprite = GetSprite(path, modRoot, new Vector2(0.5f, 0.0f), 64, 64, pixelOffsetX, pixelOffsetY);
            
            if (sprite != null)
            {
                targetArray[i] = sprite;
            }
        }
    }

    public static CharacterSpriteSetCompact TryGetSpriteSetCompact(int id)
    {
        if (_spriteSetCompacts.TryGetValue(id, out var set))
        {
            return set;
        }
        return null;
    }

    public static Sprite GetPortraitSprite(int characterId, int pid = 0)
    {
        var config = GetCharacterConfig(characterId, "Special");
        var portrait = config?.portraits?.Find(p => p.pid == pid) ?? config?.portraits?[0];
        if (portrait != null && !string.IsNullOrEmpty(portrait.path))
        {
            Log.LogInfo($"Getting portrait sprite for characterId {characterId}, pid {pid} from path {portrait.path}");
            return GetSprite(portrait.path, config.ModRoot, useCache: false);
        }
        return null;
    }
}
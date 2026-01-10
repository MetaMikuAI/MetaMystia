using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MetaMystia;
public static partial class ResourceExManager
{
    public static Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

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
}
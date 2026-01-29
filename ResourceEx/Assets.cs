using UnityEngine;

namespace MetaMystia;

public static partial class ResourceExManager
{
    // Note: Sprite caching removed - different use cases require different sprite specs
    // Images are loaded from memory-cached ZIP packages via AssetProvider

    public static Sprite GetSprite(string relativePath, string packageRoot = null, Vector2? pivot = null, int width = 0, int height = 0, int pixelOffsetX = 0, int pixelOffsetY = 0, bool useCache = true)
    {
        Vector2 actualPivot = pivot ?? new Vector2(0.5f, 0.5f);
        return _assetProvider.GetSprite(relativePath, packageRoot, actualPivot, width, height, pixelOffsetX, pixelOffsetY);
    }

    public static void PreloadAllImages()
    {
        Log.LogInfo($"Preloading all images...");
        int imageCount = 0;

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
                        GetSprite(portrait.path, charConfig.PackageRoot);
                        imageCount++;
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
                        {
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.PackageRoot, new Vector2(0.5f, 0.0f), 64, 64);
                            imageCount++;
                        }
                    }
                }
                if (config.eyeSprite != null)
                {
                    foreach (var path in config.eyeSprite)
                    {
                        if (!string.IsNullOrEmpty(path))
                        {
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.PackageRoot, new Vector2(0.5f, 0.0f), 64, 64);
                            imageCount++;
                        }
                    }
                }
            }
        }
        Log.LogInfo($"Preloading complete. Loaded {imageCount} images from memory-cached packages.");
    }
}

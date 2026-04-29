using UnityEngine;
using MetaMystia.ResourceEx.AssetManagement;

namespace MetaMystia;

public static partial class ResourceExManager
{
    public static string ResolveAssetUri(string path, string packageRoot = null)
    {
        return RexAssetRegistry.TryResolveUri(path, packageRoot, out var uri) ? uri : null;
    }

    public static Sprite GetSprite(string relativePath, string packageRoot = null, Vector2? pivot = null, int width = 0, int height = 0, int pixelOffsetX = 0, int pixelOffsetY = 0, bool useCache = true)
    {
        if (!RexAssetRegistry.TryResolveUri(relativePath, packageRoot, out var uri))
        {
            Log.LogWarning($"Failed to resolve ResourceEx asset URI: path={relativePath}, packageRoot={packageRoot}");
            return null;
        }

        if (RexAssetRegistry.TryGetSprite(uri, out var sprite))
            return sprite;

        Log.LogWarning($"ResourceEx sprite not found or not an image: {uri}");
        return null;
    }

    public static bool TryGetText(string path, out string text, string packageRoot = null)
    {
        text = null;
        return RexAssetRegistry.TryResolveUri(path, packageRoot, out var uri)
            && RexAssetRegistry.TryGetText(uri, out text);
    }

    public static bool TryGetBytes(string path, out byte[] bytes, string packageRoot = null)
    {
        bytes = null;
        return RexAssetRegistry.TryResolveUri(path, packageRoot, out var uri)
            && RexAssetRegistry.TryGetBytes(uri, out bytes);
    }

    public static void PreloadAllImages()
    {
        Log.LogInfo($"Verifying declared ResourceEx images...");
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

        // Preload cloth images
        foreach (var clothConfig in ClothConfigs.Values)
        {
            // Preload cloth item sprite
            if (!string.IsNullOrEmpty(clothConfig.spritePath))
            {
                GetSprite(clothConfig.spritePath, clothConfig.PackageRoot);
                imageCount++;
            }

            // Preload cloth portrait
            if (!string.IsNullOrEmpty(clothConfig.portraitPath))
            {
                GetSprite(clothConfig.portraitPath, clothConfig.PackageRoot);
                imageCount++;
            }

            // Preload cloth pixel sprites
            if (clothConfig.pixelFullConfig != null)
            {
                var pixelConfig = clothConfig.pixelFullConfig;
                foreach (var paths in new[] { pixelConfig.mainSprite, pixelConfig.eyeSprite, pixelConfig.hairSprite, pixelConfig.backSprite })
                {
                    if (paths == null) continue;
                    foreach (var path in paths)
                    {
                        if (!string.IsNullOrEmpty(path))
                        {
                            GetSprite(path, clothConfig.PackageRoot, new Vector2(0.5f, 0.0f), 64, 64);
                            imageCount++;
                        }
                    }
                }
            }
        }

        Log.LogInfo($"ResourceEx image verification complete. Checked {imageCount} declared image reference(s).");
    }
}

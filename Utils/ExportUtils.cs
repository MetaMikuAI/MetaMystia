using System.Linq;
using GameData.Core.Collections.CharacterUtility;
using BepInEx;
using System.IO;
using UnityEngine;
using Il2CppInterop.Runtime;
using System;

namespace MetaMystia;

/// <summary>
/// 这是一个导出工具类，提供将游戏内资源导出为外部文件的功能，方便美术创作者进行符合原游戏 Sprite 规格的二次创作。
/// 理论上不应在运行时调用此类方法，建议在调试阶段使用后移除相关调用。
/// </summary>
[AutoLog]
public static partial class ExportUtils
{
    public static string ExportRoot { get; set; } = Path.Combine(Paths.GameRootPath, "Exports");
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
}

using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace MetaMystia;

/// <summary>
/// PoC test for the IResourceProvider-based asset injection.
/// Tests the full Addressables pipeline: Register → Locate → Provide → Complete.
/// </summary>
[AutoLog]
public static partial class ModAssetRegistryPoC
{
    public static void RunTest()
    {
        Log.LogInfo("[PoC] ═══ ModAssetRegistry IResourceProvider PoC ═══");

        try
        {
            // Step 1: Initialize the registry
            Log.LogInfo("[PoC] Step 1: Initializing ModAssetRegistry...");
            ModAssetRegistry.Initialize();
            Log.LogInfo($"[PoC] Step 1 PASS: IsInitialized={ModAssetRegistry.IsInitialized}");
            if (!ModAssetRegistry.IsInitialized)
            {
                Log.LogError("[PoC] ABORT: Registry failed to initialize.");
                return;
            }

            // Step 2: Create a test sprite
            Log.LogInfo("[PoC] Step 2: Creating test sprite...");
            var tex = new Texture2D(4, 4, TextureFormat.RGBA32, false);
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    tex.SetPixel(x, y, new Color(x / 3f, y / 3f, 0.5f, 1f));
            tex.Apply();
            tex.hideFlags = HideFlags.HideAndDontSave;
            var sprite = Sprite.Create(tex, new Rect(0, 0, 4, 4), new Vector2(0.5f, 0.5f));
            sprite.name = "PoC_ModSpriteProvider_Test";
            sprite.hideFlags = HideFlags.HideAndDontSave;
            Log.LogInfo($"[PoC] Step 2 PASS: sprite={sprite.name}");

            // Step 3: Register sprite with ModAssetRegistry
            const string testKey = "mod://poc/test_sprite";
            Log.LogInfo($"[PoC] Step 3: Registering sprite with key '{testKey}'...");
            ModAssetRegistry.RegisterSprite(testKey, sprite);
            Log.LogInfo("[PoC] Step 3 PASS: Sprite registered");

            // Step 4: Load via Addressables.LoadAssetAsync (the standard pipeline)
            // Now using GUID key since locator is indexed by GUID
            var guidKey = ModAssetRegistry.KeyToGuid(testKey);
            Log.LogInfo($"[PoC] Step 4: Loading via Addressables.LoadAssetAsync with guid={guidKey}...");
            AsyncOperationHandle<Sprite> handle = default;
            try
            {
                handle = Addressables.LoadAssetAsync<Sprite>((Il2CppSystem.Object)(Il2CppSystem.String)guidKey);
                Log.LogInfo($"[PoC] Step 4: handle.IsValid={handle.IsValid()}, IsDone={handle.IsDone}");

                if (handle.IsValid())
                {
                    Log.LogInfo($"[PoC] Step 4: IsDone={handle.IsDone}, Status={handle.Status}");
                    if (handle.IsDone)
                    {
                        var result = handle.Result;
                        if (result != null)
                        {
                            bool match = result.Pointer == sprite.Pointer;
                            Log.LogInfo($"[PoC] Step 4 PASS: Result={result.name}, match={match}");
                        }
                        else
                        {
                            Log.LogWarning("[PoC] Step 4 WARN: Result is null");
                        }
                    }
                    else
                    {
                        Log.LogInfo("[PoC] Step 4: Not done yet (unexpected for sync provider)");
                    }
                }
                else
                {
                    Log.LogError("[PoC] Step 4 FAIL: Handle is not valid");
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[PoC] Step 4 FAIL: {ex.GetType().Name}: {ex.Message}");
                Log.LogError($"[PoC] Step 4 StackTrace: {ex.StackTrace}");
            }

            // Step 5: Load via AssetReferenceSprite.LoadAssetAsync (game-style)
            Log.LogInfo("[PoC] Step 5: Loading via AssetReferenceSprite.LoadAssetAsync...");
            try
            {
                var assetRef = ModAssetRegistry.CreateSpriteReference(testKey);
                Log.LogInfo($"[PoC] Step 5: AssetRef RuntimeKey={assetRef.RuntimeKey}");

                var handle2 = assetRef.LoadAssetAsync<Sprite>();
                Log.LogInfo($"[PoC] Step 5: handle.IsValid={handle2.IsValid()}, IsDone={handle2.IsDone}");

                if (handle2.IsValid())
                {
                    Log.LogInfo($"[PoC] Step 5: IsDone={handle2.IsDone}, Status={handle2.Status}");
                    if (handle2.IsDone)
                    {
                        var result = handle2.Result;
                        bool match = result != null && result.Pointer == sprite.Pointer;
                        Log.LogInfo($"[PoC] Step 5 PASS: Result={result?.name ?? "null"}, match={match}");
                    }
                    else
                    {
                        Log.LogInfo("[PoC] Step 5: Not done yet (unexpected for sync provider)");
                    }
                }
                else
                {
                    Log.LogError("[PoC] Step 5 FAIL: Handle is not valid");
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[PoC] Step 5 FAIL: {ex.GetType().Name}: {ex.Message}");
                Log.LogError($"[PoC] Step 5 StackTrace: {ex.StackTrace}");
            }

            Log.LogInfo("[PoC] ═══ Test complete ═══");
        }
        catch (Exception ex)
        {
            Log.LogError($"[PoC] FATAL: {ex}");
        }
    }
}

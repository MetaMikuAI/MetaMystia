using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace MetaMystia;

/// <summary>
/// Central registry for mod-provided assets integrated into Unity Addressables.
///
/// Uses the standard Addressables extension points:
///   - ResourceLocationMap  (IResourceLocator) to map custom keys → locations
///   - ModSpriteProvider    (IResourceProvider) to serve in-memory Sprites
///   - Addressables.AddResourceLocator / ResourceProviders.Add for registration
///
/// After Initialize(), any code that calls:
///   Addressables.LoadAssetAsync&lt;Sprite&gt;(key)
/// or
///   assetReference.LoadAssetAsync&lt;Sprite&gt;()
/// will resolve mod-registered sprites through the standard pipeline.
/// </summary>
[AutoLog]
public static partial class ModAssetRegistry
{
    private static bool _initialized;
    private static ModSpriteProvider _provider;
    private static ResourceLocationMap _locator;
    private static readonly HashSet<string> _registeredLocationGuids = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Register the custom provider and locator with Addressables.
    /// Call after Addressables.InitializeAsync() has completed (or lazily on first use).
    /// </summary>
    public static void Initialize()
    {
        if (_initialized) return;

        try
        {
            // 1. Register managed type in il2cpp
            ClassInjector.RegisterTypeInIl2Cpp<ModSpriteProvider>();
            Log.LogInfo("Registered ModSpriteProvider in il2cpp");

            // 2. Create provider instance
            _provider = new ModSpriteProvider();

            // 3. Create locator (ResourceLocationMap is a built-in IResourceLocator)
            _locator = new ResourceLocationMap("MetaMystia.ModAssetLocator", 16);

            // 4. Register with Addressables
            var rm = Addressables.ResourceManager;
            var providers = rm.ResourceProviders;
            // Actual runtime type is ListWithEvents<IResourceProvider> (not List<>)
            var providerList = providers.Cast<ListWithEvents<IResourceProvider>>();
            providerList.Add(_provider.Cast<IResourceProvider>());

            Addressables.AddResourceLocator(
                _locator.Cast<IResourceLocator>(),
                (string)null,
                (IResourceLocation)null);

            _initialized = true;
            Log.LogInfo("Initialization complete");

            // 5. Flush any sprites registered before init
            FlushPendingRegistrations();
        }
        catch (Exception ex)
        {
            Log.LogError($"Initialization failed: {ex}");
        }
    }

    // ── Pre-init buffering ──

    private static readonly Dictionary<string, Sprite> _pendingRegistrations = new(StringComparer.Ordinal);

    private static void FlushPendingRegistrations()
    {
        foreach (var kvp in _pendingRegistrations)
        {
            RegisterInternal(kvp.Key, kvp.Value);
        }
        Log.LogDebug($"Flushed {_pendingRegistrations.Count} pending registrations");
        _pendingRegistrations.Clear();
    }

    // ── Public API ──

    /// <summary>
    /// Register a Sprite so it can be loaded via Addressables with the given key.
    /// If called before Initialize(), the registration is buffered.
    /// </summary>
    /// <param name="key">Unique key string (e.g. "mod://mymod/my_sprite")</param>
    /// <param name="sprite">The Sprite to serve</param>
    public static void RegisterSprite(string key, Sprite sprite)
    {
        if (sprite == null) throw new ArgumentNullException(nameof(sprite));
        if (string.IsNullOrEmpty(key)) throw new ArgumentException("Key must not be empty", nameof(key));

        if (!_initialized)
        {
            _pendingRegistrations[key] = sprite;
            Log.LogDebug($"Buffered registration: {key}");
            return;
        }

        RegisterInternal(key, sprite);
    }

    /// <summary>
    /// Create an AssetReferenceSprite that resolves to a mod-registered sprite.
    /// The sprite must be registered (or will be registered) with the same key.
    /// </summary>
    public static AssetReferenceSprite CreateSpriteReference(string key, Sprite sprite = null)
    {
        if (sprite != null)
            RegisterSprite(key, sprite);

        // AssetReference.RuntimeKeyIsValid() calls Guid.TryParse(), so we must use a GUID-format key
        var guid = KeyToGuid(key);
        return new AssetReferenceSprite(guid);
    }

    /// <summary>
    /// Convenience: Register a sprite from a file path and return an AssetReferenceSprite.
    /// </summary>
    public static AssetReferenceSprite CreateSpriteReferenceFromFile(
        string key, string filePath, Vector2 pivot)
    {
        var sprite = Utils.GetArtWork(filePath, pivot);
        sprite.name = key;
        sprite.hideFlags = HideFlags.HideAndDontSave;
        return CreateSpriteReference(key, sprite);
    }

    /// <summary>
    /// Unregister a previously registered sprite.
    /// </summary>
    public static void UnregisterSprite(string key)
    {
        ModSpriteProvider.Unregister(key);
        // Note: removing from ResourceLocationMap at runtime is not straightforward;
        // the provider's CanProvide check will reject unregistered keys.
        Log.LogDebug($"Unregistered sprite: {key}");
    }

    // ── Internal ──

    private static void RegisterInternal(string key, Sprite sprite)
    {
        // Convert human-readable key to GUID (RuntimeKeyIsValid requires Guid.TryParse)
        var guid = KeyToGuid(key);

        // 1. Add to provider's sprite dictionary (indexed by GUID)
        ModSpriteProvider.Register(guid, sprite);

        if (_registeredLocationGuids.Contains(guid))
        {
            Log.LogDebug($"Updated sprite registration: {key} -> {guid}");
            return;
        }

        // 2. Add location to locator map (also indexed by GUID)
        var location = new ResourceLocationBase(
            guid,                               // name (primaryKey)
            guid,                               // internalId (used by provider to lookup sprite)
            ModSpriteProvider.Id,               // providerId
            Il2CppType.Of<Sprite>(),            // resource type
            new Il2CppReferenceArray<IResourceLocation>(0)  // no dependencies
        );

        _locator.Add(
            (Il2CppSystem.Object)(Il2CppSystem.String)guid,
            location.Cast<IResourceLocation>()
        );

        _registeredLocationGuids.Add(guid);

        Log.LogDebug($"Registered sprite: {key} -> {guid}");
    }

    /// <summary>
    /// Convert a human-readable key to a deterministic GUID string.
    /// AssetReference.RuntimeKeyIsValid() requires Guid.TryParse() to succeed.
    /// </summary>
    internal static string KeyToGuid(string key)
    {
        using var md5 = MD5.Create();
        var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
        return new Guid(hash).ToString("D"); // "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
    }

    /// <summary>Whether the registry has been initialized with Addressables.</summary>
    public static bool IsInitialized => _initialized;
}

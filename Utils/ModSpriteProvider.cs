using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace MetaMystia;

/// <summary>
/// Custom IResourceProvider injected into Addressables via ClassInjector.
/// Serves in-memory Sprites (and potentially other UnityEngine.Objects) by key.
///
/// Flow: Addressables pipeline → locator finds key → GetResourceProvider matches ProviderId
///       → Provide(ProvideHandle) → lookup sprite → provideHandle.Complete(sprite, ...)
/// </summary>
[AutoLog]
public partial class ModSpriteProvider : ResourceProviderBase
{
    public static readonly string Id = "MetaMystia.ModSpriteProvider";

    /// <summary>Managed-side registry: InternalId → Sprite.</summary>
    private static readonly Dictionary<string, Sprite> _sprites = new();

    // ── il2cpp constructors ──
    public ModSpriteProvider(IntPtr ptr) : base(ptr) { }

    public ModSpriteProvider()
        : base(ClassInjector.DerivedConstructorPointer<ModSpriteProvider>())
    {
        ClassInjector.DerivedConstructorBody(this);
        m_ProviderId = Id;
    }

    // ── IResourceProvider overrides ──

    public override string ProviderId => Id;

    public override Il2CppSystem.Type GetDefaultType(IResourceLocation location)
    {
        return Il2CppType.Of<Sprite>();
    }

    public override bool CanProvide(Il2CppSystem.Type type, IResourceLocation location)
    {
        return location != null
            && location.ProviderId == Id
            && _sprites.ContainsKey(location.InternalId);
    }

    public override void Provide(ProvideHandle provideHandle)
    {
        var key = provideHandle.Location.InternalId;
        if (_sprites.TryGetValue(key, out var sprite))
        {
            Log.LogDebug($"Providing sprite for key: {key}");
            provideHandle.Complete(sprite, true, (Il2CppSystem.Exception)null);
        }
        else
        {
            Log.LogWarning($"Sprite not found for key: {key}");
            provideHandle.Complete<Sprite>(null, false,
                new Il2CppSystem.Exception($"ModSpriteProvider: sprite not found for key '{key}'"));
        }
    }

    public override void Release(IResourceLocation location, Il2CppSystem.Object asset)
    {
        // In-memory sprites are managed by the mod; no unload needed.
    }

    // ── Static API for the managed side ──

    internal static void Register(string key, Sprite sprite)
    {
        _sprites[key] = sprite;
    }

    internal static void Unregister(string key)
    {
        _sprites.Remove(key);
    }

    internal static bool Has(string key) => _sprites.ContainsKey(key);

    internal static bool TryGet(string key, out Sprite sprite)
        => _sprites.TryGetValue(key, out sprite);
}

using DEYU.AssetHandleUtility;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace MetaMystia.AssetHandles;

public static class CompletedAssetHandle
{
    public static IAssetHandle<T> From<T>(T asset) where T : class
    {
        return new CompletedAssetHandle<T>(asset);
    }

    public static IAssetHandleArray<T> FromArray<T>(T[] assets) where T : Il2CppObjectBase
    {
        return new CompletedAssetHandleArray<T>(assets);
    }
}

public class CompletedAssetHandle<T>(T asset)
    : IAssetHandle<T>(ClassInjector.DerivedConstructorPointer<CompletedAssetHandle<T>>())
    where T : class
{
    static CompletedAssetHandle()
    {
        ClassInjector.RegisterTypeInIl2Cpp<CompletedAssetHandle<T>>(new RegisterTypeOptions
        {
            Interfaces = new[]{typeof(IAssetHandle<T>)}
        });
    }

    public override bool IsPersistentAsset => true;
    public override T Asset => asset;
}

public class CompletedAssetHandleArray<T>(T[] assets)
    : IAssetHandleArray<T>(ClassInjector.DerivedConstructorPointer<CompletedAssetHandleArray<T>>())
    where T : Il2CppObjectBase
{
    static CompletedAssetHandleArray()
    {
        ClassInjector.RegisterTypeInIl2Cpp<CompletedAssetHandleArray<T>>(new RegisterTypeOptions
        {
            Interfaces = new[]{typeof(IAssetHandleArray<T>)}
        });
    }

    public override int Count => assets.Length;
    public override T this[int index] => assets[index];
    public override Il2CppArrayBase<T> ToAssetArray()
    {
        var array = new Il2CppReferenceArray<T>(assets.Length);
        for (var i = 0; i < assets.Length; i++) array[i] = assets[i];
        return array;
    }
}
using DEYU.AssetHandleUtility;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace MetaMystia.AssetHandles;

public class SpriteAssetHandle(Sprite asset) : 
    Il2CppSystem.Object(ClassInjector.DerivedConstructorPointer<SpriteAssetHandle>())
{
    static SpriteAssetHandle()
    {
        ClassInjector.RegisterTypeInIl2Cpp<SpriteAssetHandle>(new()
        {
            Interfaces = new[]{typeof(IAssetHandle<Sprite>)}
        });
    }

    public static implicit operator IAssetHandle<Sprite>(SpriteAssetHandle handle) => new(handle.Pointer);
    public bool IsPersistentAsset => true;
    public Sprite Asset => asset!;
}

public class SpriteAssetHandleArray(Sprite[] assets) : 
    Il2CppSystem.Object(ClassInjector.DerivedConstructorPointer<SpriteAssetHandleArray>())
{
    static SpriteAssetHandleArray()
    {
        ClassInjector.RegisterTypeInIl2Cpp<SpriteAssetHandleArray>(new()
        {
            Interfaces = new[]{typeof(IAssetHandleArray<Sprite>)}
        });
    }

    public static implicit operator IAssetHandleArray<Sprite>(SpriteAssetHandleArray handleArray) => new(handleArray.Pointer);
    public int Count => assets!.Length;
    public Sprite this[int index] => assets![index];
    public Il2CppArrayBase<Sprite> ToAssetArray()
    {
        var array = new Il2CppReferenceArray<Sprite>(assets!.Length);
        for (var i = 0; i < assets.Length; i++) array[i] = assets[i];
        return array;
    }
}
using DEYU.AssetHandleUtility;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace MetaMystia.AssetHandles;

public class SpriteAssetHandle(Sprite asset) : 
    IAssetHandle<Sprite>(ClassInjector.DerivedConstructorPointer<SpriteAssetHandle>())
{
    static SpriteAssetHandle()
    {
        ClassInjector.RegisterTypeInIl2Cpp<SpriteAssetHandle>(new()
        {
            Interfaces = new[]{typeof(IAssetHandle<Sprite>)}
        });
    }

    public override bool IsPersistentAsset => true;
    public override Sprite Asset => asset!;
}

public class SpriteAssetHandleArray(Sprite[] assets)
    : IAssetHandleArray<Sprite>(ClassInjector.DerivedConstructorPointer<SpriteAssetHandleArray>())
{
    static SpriteAssetHandleArray()
    {
        ClassInjector.RegisterTypeInIl2Cpp<SpriteAssetHandleArray>(new()
        {
            Interfaces = new[]{typeof(IAssetHandleArray<Sprite>)}
        });
    }

    public override int Count => assets!.Length;
    public override Sprite this[int index] => assets![index];
    public override Il2CppArrayBase<Sprite> ToAssetArray()
    {
        var array = new Il2CppReferenceArray<Sprite>(assets!.Length);
        for (var i = 0; i < assets.Length; i++) array[i] = assets[i];
        return array;
    }
}
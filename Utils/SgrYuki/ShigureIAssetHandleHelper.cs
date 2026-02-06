using System;
using System.Collections.Concurrent;

namespace SgrYuki.Utils;

[MetaMystia.AutoLog]
public partial class ShigureIAssetHandleHelper<T>(IntPtr pointer, T asset) : DEYU.AssetHandleUtility.IAssetHandle<T>(pointer) where T : UnityEngine.Object
{
    public override T Asset { get; } = asset;
    public static ShigureIAssetHandleHelper<T> CreateAssetHandle(T asset)
    {
        var i = DEYU.AssetHandleUtility.AssetHandleHelper.CreateNullHandleTask<T>().GetAwaiter().GetResult();
        var ret = new ShigureIAssetHandleHelper<T>(i.Pointer, asset);
        return ret;
    }
    public void InvalidateAsset()
    {
        // To do: Implement
    }
}

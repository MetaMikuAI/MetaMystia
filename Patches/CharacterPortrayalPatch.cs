using HarmonyLib;
// using GameData.Profile;
// using DEYU.AssetHandleUtility;
// using UnityEngine.AddressableAssets;
// using UnityEngine;
// using Cysharp.Threading.Tasks;
// using Il2CppSystem.Threading;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Profile.CharacterPortrayal))]
public partial class CharacterPortrayalPatch
{
    // public static bool _skipPatch = true;
    // // [HarmonyPatch(nameof(CharacterPortrayal.LoadVisualHandle))]
    // // [HarmonyPrefix]
    // // public static bool LoadVisualHandle_Prefix(int index, AssetLifetime assetLifetime, Il2CppSystem.Nullable<CancellationToken> cancellationToken = null, UniTask<IAssetHandle<Sprite>> __result = null)
    // // {
    // //     if (_skipPatch)
    // //     {
    // //         return true;
    // //     }
    // //     Log.LogWarning($"LoadVisualHandle_Prefix called for index: {index}");
    // //     var testPath = "E:/Desktop/Touhou Mystia Izakaya/ResourceEx/MetaMystia/assets/Daiyousei_0.png";
    // //     var assetRef = new AssetReferenceT<Sprite>(testPath);
    // //     __result = AssetHandleHelper.LoadAssetHandleAsync(assetRef, AssetLifetime.Persistent);
    // //     return false;
    // // }
    // [HarmonyPatch(nameof(CharacterPortrayal.LoadNotebookVisual))]
    // [HarmonyPrefix]
    // // public static void LoadNotebookVisual_Postfix()
    // public static bool LoadNotebookVisual_Prefix(CharacterPortrayal __instance, AssetLifetime assetLifetime, ref Il2CppSystem.Nullable<CancellationToken> cancellationToken, ref UniTask<IAssetHandle<Sprite>> __result)
    // {
    //     Log.LogWarning($"LoadNotebookVisual_Prefix called");
    //     // return true;
    //     if (!PluginManager.test)
    //     {
    //         cancellationToken ??= new Il2CppSystem.Nullable<CancellationToken>(CancellationToken.None);
    //         return true;
    //     }
    //     cancellationToken ??= new Il2CppSystem.Nullable<CancellationToken>(CancellationToken.None.);
    //     Log.LogWarning($"LoadNotebookVisual_Prefix called");
    //     var testPath = "E:/Desktop/Touhou Mystia Izakaya/ResourceEx/MetaMystia/assets/Daiyousei_0.png";
    //     var assetRef = new AssetReferenceT<Sprite>(testPath);
    //     __result = AssetHandleHelper.LoadAssetHandleAsync(assetRef, AssetLifetime.Persistent);
    //     return false;
    // }
}
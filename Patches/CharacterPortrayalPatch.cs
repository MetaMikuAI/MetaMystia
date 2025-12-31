using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using HarmonyLib;
using Il2CppSystem.Threading;
using MetaMystia.AssetHandles;
using UnityEngine;

namespace MetaMystia;

[AutoLog]
[HarmonyPatch(typeof(GameData.Profile.CharacterPortrayal))]
public partial class CharacterPortrayalPatch
{
    [HarmonyPatch(nameof(CharacterPortrayal.LoadVisualHandle))]
    [HarmonyPostfix]
    public static void LoadVisualHandle_Prefix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandle<Sprite>> __result, int index, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested) 
            return;
        if (!ResourceExManager.TryGetCustomPortrayl(__instance, out var portraits))
            return;
        if (index < 0 || index >= portraits.Length)
            return;

        __result = UniTask.FromResult(CompletedAssetHandle.From(portraits[index]));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadAllVisualHandles))]
    [HarmonyPostfix]
    public static void LoadAllVisualHandles_Prefix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandleArray<Sprite>> __result, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested) 
            return;
        if (!ResourceExManager.TryGetCustomPortrayl(__instance, out var portraits))
            return;

        __result = UniTask.FromResult(CompletedAssetHandle.FromArray(portraits));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadNotebookVisual))]
    [HarmonyPostfix]
    public static void LoadNotebookVisual_Prefix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandle<Sprite>> __result, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested)
            return;

        if (!ResourceExManager.TryGetCustomPortrayl(__instance, out var portraits))
            return;

        var faceInNoteBook = __instance.faceInNoteBook;
        if (faceInNoteBook < 0 || faceInNoteBook >= portraits.Length)
            return;

        __result = UniTask.FromResult(CompletedAssetHandle.From(portraits[faceInNoteBook]));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadSpellPortrayal))]
    [HarmonyPostfix]
    public static void LoadSpellPortrayal_Prefix(CharacterPortrayal __instance,
        ref Il2CppSystem.ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>> __result)
    {
        if (!ResourceExManager.TryGetCustomPortrayl(__instance, out var portraits))
            return;
        var positiveSpellCardFace = __instance.positiveSpellCardFace;
        if (positiveSpellCardFace < 0 || positiveSpellCardFace >= portraits.Length)
            return;

        var negativeSpellCardFace = __instance.negativeSpellCardFace;
        if (negativeSpellCardFace < 0 || negativeSpellCardFace >= portraits.Length)
            return;
        
        var positiveTask = UniTask.FromResult(CompletedAssetHandle.From(portraits[positiveSpellCardFace]));
        var negativeTask = UniTask.FromResult(CompletedAssetHandle.From(portraits[negativeSpellCardFace]));

        __result = Il2CppSystem.ValueTuple.Create(positiveTask, negativeTask);
    }
}
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
    public static void LoadVisualHandle_PostFix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandle<Sprite>> __result, int index, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested) 
            return;
        if (!ResourceExManager.TryGetCustomPortrayal(__instance, out var portraits))
            return;
        if (index < 0 || index >= portraits.Length)
            return;

        __result = UniTask.FromResult<IAssetHandle<Sprite>>(new SpriteAssetHandle(portraits[index]));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadAllVisualHandles))]
    [HarmonyPostfix]
    public static void LoadAllVisualHandles_PostFix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandleArray<Sprite>> __result, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested) 
            return;
        if (!ResourceExManager.TryGetCustomPortrayal(__instance, out var portraits))
            return;

        __result = UniTask.FromResult<IAssetHandleArray<Sprite>>(new SpriteAssetHandleArray(portraits));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadNotebookVisual))]
    [HarmonyPostfix]
    public static void LoadNotebookVisual_PostFix(CharacterPortrayal __instance,
        ref UniTask<IAssetHandle<Sprite>> __result, AssetLifetime assetLifetime,
        ref Il2CppSystem.Nullable<CancellationToken> cancellationToken)
    {
        if (cancellationToken?.HasValue == true && cancellationToken.Value.IsCancellationRequested)
            return;

        if (!ResourceExManager.TryGetCustomPortrayal(__instance, out var portraits))
            return;

        var faceInNoteBook = __instance.faceInNoteBook;
        if (faceInNoteBook < 0 || faceInNoteBook >= portraits.Length)
            return;

        __result = UniTask.FromResult<IAssetHandle<Sprite>>(new SpriteAssetHandle(portraits[faceInNoteBook]));
    }

    [HarmonyPatch(nameof(CharacterPortrayal.LoadSpellPortrayal))]
    [HarmonyPostfix]
    public static void LoadSpellPortrayal_PostFix(CharacterPortrayal __instance,
        ref Il2CppSystem.ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>> __result)
    {
        if (!ResourceExManager.TryGetCustomPortrayal(__instance, out var portraits))
            return;
        var positiveSpellCardFace = __instance.positiveSpellCardFace;
        if (positiveSpellCardFace < 0 || positiveSpellCardFace >= portraits.Length)
            return;

        var negativeSpellCardFace = __instance.negativeSpellCardFace;
        if (negativeSpellCardFace < 0 || negativeSpellCardFace >= portraits.Length)
            return;

        var positiveSprite = portraits[positiveSpellCardFace];
        if (positiveSprite == null)
            return;

        var negativeSprite = portraits[negativeSpellCardFace];
        if (negativeSprite == null)
            return;
        
        var positiveTask = UniTask.FromResult<IAssetHandle<Sprite>>(new SpriteAssetHandle(positiveSprite));
        var negativeTask = UniTask.FromResult<IAssetHandle<Sprite>>(new SpriteAssetHandle(negativeSprite));

        __result = Il2CppSystem.ValueTuple.Create(positiveTask, negativeTask);
    }
}
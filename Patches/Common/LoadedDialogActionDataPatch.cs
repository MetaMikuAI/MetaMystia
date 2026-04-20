using System;
using HarmonyLib;

using Common.DialogUtility;
using UnityEngine;

using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(LoadedDialogActionData))]
[AutoLog]
public partial class LoadedDialogActionDataPatch
{
    [HarmonyPatch(nameof(LoadedDialogActionData.Run))]
    [HarmonyPrefix]
    public static bool Run_Prefix(LoadedDialogActionData __instance, DialogPannel dialogModuleUI)
    {
        var actionData = __instance.m_DialogActionData;
        if (actionData == null) return RunOriginal;
        if (actionData.actionType != ActionType.CG) return RunOriginal;

        // Check if this DialogAction has a registered custom CG sprite
        if (!AssetReferenceHelper.TryGetCGSprite(actionData.Pointer, out var sprite)) return RunOriginal;

        // Handle CG directly, bypassing the Addressables loading pipeline
        // (game's LoadAssetAsync rejects pre-injected m_Operation)
        if (actionData.shouldSet && sprite != null)
        {
            Log.LogDebug($"[DialogCG] Setting custom CG sprite: {sprite.name}");
            dialogModuleUI.CG = sprite;
        }
        else
        {
            dialogModuleUI.CG = null;
        }

        return SkipOriginal;
    }
}

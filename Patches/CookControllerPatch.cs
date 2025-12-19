using HarmonyLib;
using NightScene.CookingUtility;
using GameData.Core.Collections;
using System;

namespace MetaMystia;

[HarmonyPatch(typeof(NightScene.CookingUtility.CookController))]
public class CookControllerPatch : PatchBase<CookControllerPatch>
{

    [HarmonyPatch(nameof(CookController.SetCook))]
    [HarmonyReversePatch]
    public static void SetCook_Original(CookController __instance, Sellable thisResult, Recipe recipe, bool thisCouldReturnIngredients)
    {
        throw new NotImplementedException("It's a stub");
    }

    [HarmonyPatch(nameof(CookController.SetCook))]
    [HarmonyPostfix]
    public static void SetCook_Postfix(CookController __instance, Sellable thisResult, Recipe recipe, bool thisCouldReturnIngredients)
    {
        // Log.LogDebug($"{LOG_TAG} SetCook_Postfix called for food:\n {thisResult.ToString()}\n\nrecipe:\n {recipe.ToString()}\n\nthisCouldReturnIngredients: {thisCouldReturnIngredients}"); 
        var gridIndex = __instance.GridIndex;
        var foodId = thisResult.Id;
        var recipeId = recipe.Id;
        var modifier = thisResult.Modifier;
        MpManager.SendCook(gridIndex, foodId, recipeId, modifier);
    }

    [HarmonyPatch(nameof(CookController.Extract))]
    [HarmonyReversePatch]
    public static void Extract_Original(CookController __instance, Il2CppSystem.Action<Sellable> targetAssignmentCallBack)
    {
        throw new NotImplementedException("It's a stub");
    }

    [HarmonyPatch(nameof(CookController.Extract))]
    [HarmonyPrefix]
    public static void Extract_Prefix(CookController __instance)
    {
        var gridIndex = __instance.GridIndex;
        MpManager.SendExtract(gridIndex);
    }


    [HarmonyPatch(nameof(CookController.StartCookCountDown))]
    [HarmonyReversePatch]
    public static void StartCookCountDown_Original(CookController __instance, float qteScore, bool allowInterrupt = false)
    {
        throw new NotImplementedException("It's a stub");
    }

    [HarmonyPatch(nameof(CookController.StartCookCountDown))]
    [HarmonyPrefix]
    public static void StartCookCountDown_Prefix(CookController __instance, float qteScore)
    {
        var gridIndex = __instance.GridIndex;
        MpManager.SendQTE(gridIndex, qteScore);
    }

}

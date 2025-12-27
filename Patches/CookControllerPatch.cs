using System;
using GameData.Core.Collections;
using HarmonyLib;
using NightScene.CookingUtility;

namespace MetaMystia;

[HarmonyPatch(typeof(NightScene.CookingUtility.CookController))]
[AutoLog]
public partial class CookControllerPatch
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
        // Log.LogDebug($"SetCook_Postfix called for food:\n {thisResult.ToString()}\n\nrecipe:\n {recipe.ToString()}\n\nthisCouldReturnIngredients: {thisCouldReturnIngredients}"); 
        var gridIndex = __instance.GridIndex;
        var recipeId = recipe.Id;
        SellableFood food = SellableFood.FromSellable(thisResult);
        CookAction.Send(gridIndex, food, recipeId);
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
        ExtractAction.Send(gridIndex);
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
        QTEAction.Send(gridIndex, qteScore);
    }

}

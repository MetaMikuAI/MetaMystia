using GameData.RunTime.DaySceneUtility;
using HarmonyLib;
using UnityEngine.InputSystem.Utilities;

using GameData.Core.Collections.DaySceneUtility.Collections;
using static GameData.Core.Collections.DaySceneUtility.Collections.Merchant;
using static GameData.Core.Collections.DaySceneUtility.Collections.Product;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Net.Http.Headers;
using SgrYuki.Utils;
using System.Linq;
using GameData.RunTime.Common;
namespace MetaMystia;

[HarmonyPatch(typeof(GameData.RunTime.DaySceneUtility.RunTimeDayScene))]
[AutoLog]
public partial class RunTimeDayScenePatch
{

    [HarmonyPatch(nameof(RunTimeDayScene.GetMerchantData))]
    [HarmonyPostfix]
    public static void GetMerchantData_Postfix(ref GameData.RunTime.DaySceneUtility.Collection.TrackedMerchant __result, string characterKey)
    {
        Log.Info($"DataBaseDay.GetMerchantData Postfix called with key: {characterKey}");
        if (!ResourceExManager.TryGetExMerchantData(characterKey, out Merchant merchant))
        {
            return;
        }
        // 对 Ex 商人的已有「食谱」进行过滤
        __result.products = __result.products
            .Where(m => m.productType != ProductType.Recipe
                   || !RunTimeStorage.Recipes.Contains(m.productId))
            .ToIl2CppReferenceArray();
    }
}

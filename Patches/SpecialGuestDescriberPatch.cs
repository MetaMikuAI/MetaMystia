using HarmonyLib;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppSystem.Threading;
using UnityEngine.Playables;
using UnityEngine;
namespace MetaMystia;

// Hearts to ShigureYuki!
[HarmonyPatch(typeof(Common.UI.SpecialGuestDescriber))]
[AutoLog]
public partial class SpecialGuestDescriberPatch
{
    [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    [HarmonyPrefix]
    public static void Describe_Prefix(SpecialGuest detail, ref CancellationToken cancellationToken)
    {
        var src = new CancellationTokenSource();
        cancellationToken = src.Token;
        src.Cancel();
        Log.Info($"cancelled token for special guest ID {detail.Id}");
    }

    [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    [HarmonyPostfix]
    public static void Describe_Postfix(SpecialGuestDescriber __instance, SpecialGuest detail, CancellationToken cancellationToken)
    {
        var sprite = ResourceExManager.GetPortraitSprite(detail.Id, 0);
        var cts = new CancellationTokenSource();
        if (ResourceExManager.ExistsCharacterConfig(detail.Id) && sprite != null)
        {
            var nullTask = DEYU.AssetHandleUtility.AssetHandleHelper.CreateNullHandleTask<UnityEngine.Sprite>();
            __instance.portrayal.AssignImageSpriteAsync(nullTask, cts.Token);
            __instance.portrayal.sprite = sprite;
            Log.Warning($"Updated portrayal sprite for special guest ID {detail.Id}");
        }
        else
        {
            var nullableToken = new Il2CppSystem.Nullable<CancellationToken>(cts.Token);
            __instance.portrayal.AssignImageSpriteAsync(detail.CharacterDefaultPortrayal.LoadNotebookVisual(UniversalGameManager.PlatformAssetLifetime, nullableToken), cts.Token);
            Log.Info($"default portrayal sprite for special guest ID {detail.Id}");
        }
    }
}
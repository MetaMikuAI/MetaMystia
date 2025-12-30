using HarmonyLib;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppSystem.Threading;
using UnityEngine.Playables;
namespace MetaMystia;


[HarmonyPatch(typeof(Common.UI.SpecialGuestDescriber))]
[AutoLog]
public partial class SpecialGuestDescriberPatch
{
    // [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    // [HarmonyPrefix]
    // public static void Describe_Prefix(ref CancellationToken cancellationToken)
    // {
    //     var src = new CancellationTokenSource();
    //     cancellationToken = src.Token;
    //     src.Cancel();
    // }

    [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    [HarmonyPostfix]
    public static void Describe_Postfix(SpecialGuestDescriber __instance, SpecialGuest detail, CancellationToken cancellationToken)
    {
        Log.LogWarning($"Describe method called. with special guest ID {detail.Id}");
        if (ResourceExManager.ExistsCharacterConfig(detail.Id))
        {
            var newToken = new CancellationToken();
            var nullableToken = new Il2CppSystem.Nullable<CancellationToken>(newToken);
            // __instance.portrayal.AssignImageSpriteAsync(detail.CharacterDefaultPortrayal.LoadNotebookVisual(UniversalGameManager.PlatformAssetLifetime, nullableToken), cancellationToken);
            __instance.portrayal.sprite = ResourceExManager.GetPortraitSprite(detail.Id, 0);
            // cancellationToken = new CancellationToken();
            Log.LogWarning($"Updated portrayal sprite for special guest ID {detail.Id}");
        }
    }
}
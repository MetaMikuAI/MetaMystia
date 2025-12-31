using HarmonyLib;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppSystem.Threading;

namespace MetaMystia;

// Hearts to ShigureYuki!
[HarmonyPatch(typeof(Common.UI.SpecialGuestDescriber))]
[AutoLog]
public partial class SpecialGuestDescriberPatch
{
    [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    [HarmonyPrefix]
    public static void Describe_Prefix(SpecialGuestDescriber __instance, SpecialGuest detail, ref CancellationToken cancellationToken)
    {
        if (!ResourceExManager.TryGetSpecialGuestCustomPortrayal(detail.CharacterDefaultPortrayal, out var customPortrayal))
            return;
        
        __instance.portrayal.sprite = customPortrayal[detail.CharacterDefaultPortrayal.faceInNoteBook];
        var source = new CancellationTokenSource();
        cancellationToken = source.Token;
        source.Cancel();
    }
    
    [HarmonyPatch(nameof(SpecialGuestDescriber.Describe))]
    [HarmonyPostfix]
    public static void Describe_Postfix(SpecialGuestDescriber __instance, SpecialGuest detail)
    {      
        if (!ResourceExManager.TryGetSpecialGuestCustomPortrayal(detail.CharacterDefaultPortrayal, out _))
            return;
        __instance.portrayal.enabled = true;
    }
}
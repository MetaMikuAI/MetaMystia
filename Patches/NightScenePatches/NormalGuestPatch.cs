using HarmonyLib;
using GameData.Core.Collections.NightSceneUtility;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.Core.Collections.NightSceneUtility.NormalGuest))]
[AutoLog]
public partial class NormalGuestPatch
{
    [HarmonyPatch(nameof(NormalGuest.OnGetVisual))]
    [HarmonyPrefix]
    public static bool OnGetVisual_Prefix(NormalGuest __instance, ref GameData.Profile.GuestProfilePair __result, int id)
    {
        Log.LogDebug($"OnGetVisual_Prefix called");

        if (MpManager.IsConnectedClient)
        {
            if(NightGuestManager.normalGuestProfile.TryGetValue(__instance.Pointer, out var profile))
            {
                Log.LogDebug($"get stored color {profile.bgColor}, {profile.textColor}");
                __result = profile;
                return false;
            }
        }
        return true;
    }
}
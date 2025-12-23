using HarmonyLib;
using GameData.Core.Collections.NightSceneUtility;

using MetaMystia;

[HarmonyPatch(typeof(GameData.Core.Collections.NightSceneUtility.NormalGuest))]
public class NormalGuestPatch : PatchBase<NormalGuestPatch>
{
    [HarmonyPatch(nameof(NormalGuest.OnGetVisual))]
    [HarmonyPrefix]
    public static bool OnGetVisual_Prefix(NormalGuest __instance, ref GameData.Profile.GuestProfilePair __result, int id)
    {
        Log.LogInfo($"{LOG_TAG} OnGetVisual_Prefix called");

        if (MpManager.IsConnectedClient)
        {
            if(NightGuestManager.normalGuestProfile.TryGetValue(__instance.Pointer, out var profile))
            {
                Log.LogMessage($"{LOG_TAG} get stored color {profile.bgColor}, {profile.textColor}");
                __result = profile;
                return false;
            }
        }
        return true;
    }
}
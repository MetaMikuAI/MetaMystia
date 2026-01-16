using GameData.CoreLanguage.Collections;
using GameData.RunTime.Common;
using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.RunTime.Common.StatusTracker))]
[AutoLog]
public static partial class StatusTrackerPatch
{
    public static StatusTracker InstanceRef => StatusTracker.Instance;

    [HarmonyPatch(nameof(StatusTracker.RecordInvitedGuest))]
    [HarmonyPostfix]
    public static void RecordInvitedGuest_Postfix(int guestId)
    {
        Log.Info($"RecordInvitedGuest_Postfix called, guestId {guestId}, invited {guestId.GetSpecialGuestLang().BriefName}");
    }
    
    [HarmonyPatch(nameof(StatusTracker.RecordInvitedGuest))]
    [HarmonyReversePatch]
    public static void RecordInvitedGuest_Original(StatusTracker __instance, int guestId)
    {
        throw new System.NotImplementedException();
    }
}

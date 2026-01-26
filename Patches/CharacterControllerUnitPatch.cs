using System.Collections.Generic;
using System.Linq;
using Common.CharacterUtility;
using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(CharacterControllerUnit))]
[AutoLog]
public partial class CharacterControllerUnitPatch
{
    public static readonly List<string> PeerPlayerNames = [
            "幽谷响子", // CHS
            "幽谷響子", // CHT, JPN
            "Kyouko Kasodani",  // ENG
            "카소다니 쿄코", // KOR
            PeerManager.KYOUKO_ID
        ];

    [HarmonyPatch(nameof(CharacterControllerUnit.Initialize))]
    [HarmonyPrefix]
    public static void Initialize_Prefix(CharacterControllerUnit __instance, ref bool shouldTurnOnCollider)
    {
        if (PeerPlayerNames.Any(name => __instance.name.Equals(name)))
        {
            shouldTurnOnCollider = true;
            Log.LogMessage($"found {__instance.name}, forcing shouldTurnOnCollider to true");
        }
    }

    [HarmonyPatch(nameof(CharacterControllerUnit.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix(CharacterControllerUnit __instance)
    {
        if (PeerPlayerNames.Any(name => __instance.name.Equals(name)))
        {
            PeerManager.EnableCollision(__instance, false);
            Log.LogMessage($"found {__instance.name}, disable collision");
        }
    }
}

using HarmonyLib;
using Common.CharacterUtility;
using System.Collections.Generic;
using System.Linq;

namespace MetaMystia;


[HarmonyPatch(typeof(CharacterControllerUnit))]
public class CharacterControllerUnitPatch : PatchBase<CharacterControllerUnitPatch>
{
    [HarmonyPatch(nameof(CharacterControllerUnit.Initialize))]
    [HarmonyPrefix]
    public static void Initialize_Prefix(CharacterControllerUnit __instance, ref bool shouldTurnOnCollider)
    {
        // TODO: 使用新 API 方案来替换 KyoukoNames 方案，并设置 IgnoreCollision
        var kyoukoNames = new List<string>
        {
            "幽谷响子", // CHS
            "幽谷響子", // CHT, JPN
            "Kyouko Kasodani",  // ENG
            "카소다니 쿄코", // KOR
            KyoukoManager.KYOUKO_ID
        };
        if (kyoukoNames.Any(name => __instance.name.Equals(name)))
        {
            shouldTurnOnCollider = true;
            Log.LogMessage($"{LOG_TAG} found {__instance.name}, forcing shouldTurnOnCollider to true");
        } 
    }
}
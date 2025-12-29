using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using UnityEngine;
using HarmonyLib;
using Mono.Cecil;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Core.Collections.CharacterUtility.DataBaseCharacter))]
[AutoLog]
public partial class DataBaseCharacterPatch
{
    [HarmonyPatch(nameof(DataBaseCharacter.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseCharacter.Initialize Postfix called.");
        ResourceExManager.TryInjectAllSpecialGuests();
        ResourceExManager.TryInjectAllSpawnConfigs();
    }

    [HarmonyPatch(nameof(DataBaseCharacter.GetNPCLabel))]
    [HarmonyPrefix]
    public static bool GetNPCLabel_Prefix(ref string __result, SchedulerNode.Character identity)
    {
        // Log.LogWarning($"GetNPCLabel_Prefix called for identity: {identity} result: {__result}");
        
        var config = ResourceExManager.GetCharacterConfig(identity.characterId, identity.characterIdentity.ToString());
        if (config != null)
        {
            __result = config.label;
            return false;
        }
        
        return true;
    }

    [HarmonyPatch(nameof(DataBaseCharacter.RefNormalGuestVisual))]
    [HarmonyPrefix]
    public static bool RefNormalGuestVisual_Prefix(ref GuestProfilePair  __result, ref int id)
    {
        if(MpManager.IsConnectedClient && NightGuestManager.normalGuestProfilePairIndexQueue.TryDequeue(out int index))
        {
            var compacts = DataBaseCharacter.NormalGuestVisual.Get(id, new[] {DataBaseCharacter.FallbackCompactPixel});
            var compact = compacts[index];
            Log.LogMessage($"RefNormalGuestVisual_Prefix called, get index {index} => {compact.ToString()}");
            var guestProfilePair = new GuestProfilePair(id, DataBaseCharacter.UnifiedNormalGuestBGColor, DataBaseCharacter.UnifiedNormalGuestTextColor, null, ScriptableObject.CreateInstance<CharacterSkinSets>());
            guestProfilePair.CharacterPixel.Initialize(compact, null, null);
            __result = guestProfilePair;
            return false;
        }
        return true;
    }

    [HarmonyPatch(nameof(DataBaseCharacter.RefSpecialGuestVisual))]
    [HarmonyPostfix]
    public static void RefSpecialGuestVisual_Prefix(ref GuestProfilePair __result, ref int id)
    {
        Log.Debug($"RefSpecialGuestVisual_Prefix called.");
        Log.Debug($"{__result.bgColor}, {__result.textColor}");
        if (__result.bgColor == new Color(1f, 0f, 1f, 1f) && __result.textColor == new Color(0f, 1f, 1f, 1f))
        {
            // RGBA(1.000, 0.710, 0.655, 1.000), RGBA(0.321, 0.041, 0.041, 1.000)
            Log.Debug("Detected placeholder colors, replacing with unified special guest colors.");
            __result.bgColor = DataBaseCharacter.UnifiedNormalGuestBGColor;
            __result.textColor = DataBaseCharacter.UnifiedNormalGuestTextColor;
        }
    }
}
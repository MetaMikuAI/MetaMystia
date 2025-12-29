using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using UnityEngine;
using HarmonyLib;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Core.Collections.CharacterUtility.DataBaseCharacter))]
[AutoLog]
public partial class DataBaseCharacterPatch
{
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

}
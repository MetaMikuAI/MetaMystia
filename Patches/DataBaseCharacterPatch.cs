using HarmonyLib;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Core.Collections.CharacterUtility.DataBaseCharacter))]
public class DataBaseCharacterPatch : PatchBase<DataBaseCharacterPatch>
{
    [HarmonyPatch(nameof(DataBaseCharacter.GetNPCLabel))]
    [HarmonyPrefix]
    public static bool GetNPCLabel_Prefix(ref string __result, SchedulerNode.Character identity)
    {
        // Log.LogWarning($"{LOG_TAG} GetNPCLabel_Prefix called for identity: {identity} result: {__result}");
        
        var config = ResourceExManager.GetCharacterConfig(identity.characterId, identity.characterIdentity.ToString());
        if (config != null)
        {
            __result = config.label;
            return false;
        }
        
        return true;
    }
}
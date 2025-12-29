using GameData.RunTime.Common;
using HarmonyLib;
using GameData.Core.Collections.CharacterUtility;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.RunTime.Common.RunTimeAlbum))]
[AutoLog]
public partial class RunTimeAlbumPatch
{
    [HarmonyPatch(nameof(RunTimeAlbum.RefSpecialPixel))]
    [HarmonyPrefix]
    public static bool RefSpecialPixel_Prefix(ref CharacterSpriteSetCompact __result, int id, bool useDefaultSkin = false)
    {

        if (!ResourceExManager.ExistsCharacterConfig(id))
        {
            Log.LogInfo($"RefSpecialPixel_Prefix: No custom CharacterConfig for id {id}, falling back to original.");
            return true;
        }

        __result = ResourceExManager.TryGetSpriteSetCompact(id);
        if (__result != null)
        {
            Log.LogInfo($"RefSpecialPixel_Prefix: Found custom CharacterSpriteSetCompact for id {id}.");
            return false;
        }

        ResourceExManager.TryInjectAllSpriteSetCompact();

        __result = ResourceExManager.TryGetSpriteSetCompact(id);
        if (__result != null)
        {
            Log.LogInfo($"RefSpecialPixel_Prefix: Found custom CharacterSpriteSetCompact for id {id}.");
            return false;
        }
        
        Log.LogInfo($"RefSpecialPixel_Prefix: Custom CharacterSpriteSetCompact for id {id} not found, falling back to original.");
        return true;
    }
}
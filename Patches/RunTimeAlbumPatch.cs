using GameData.RunTime.Common;
using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(RunTimeAlbum))]
[AutoLog]
public partial class RunTimeAlbumPatch
{
    // [HarmonyPatch(nameof(RunTimeAlbum.RefSpecialPixel))]
    // [HarmonyPrefix] // public unsafe static CharacterSpriteSetCompact RefSpecialPixel(this int id, bool useDefaultSkin = false)
    // public static bool RefSpecialPixel_Prefix(ref CharacterSpriteSetCompact __result)
    // {
    //     CharacterSpriteSetCompact DaiyouseiPixel = null;
    //     Action<CharacterSpriteSetCompact> process = (spriteSet) =>
    //     {
    //         if (spriteSet != null && spriteSet.name == "Daiyousei")
    //         {
    //             DaiyouseiPixel = spriteSet;
    //         }
    //     }; 

    //     Utils.FindAndProcessResources<CharacterSpriteSetCompact>(process);

    //     __result = DaiyouseiPixel;
    //     return false;
    // }
}
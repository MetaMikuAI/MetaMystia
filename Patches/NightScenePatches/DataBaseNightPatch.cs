using System.Linq;
using GameData.Core.Collections.NightSceneUtility;
using HarmonyLib;
using SgrYuki.Utils;
using UnityEngine;

namespace MetaMystia;

[HarmonyPatch(typeof(DataBaseNight))]
[AutoLog]
public partial class DataBaseNightPatch
{
    public static Il2CppSystem.Collections.Generic.Dictionary<string, DataBaseNight.DataBaseNightData> nightDataRef;

    [HarmonyPatch(nameof(DataBaseNight.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix(Il2CppSystem.Collections.Generic.Dictionary<string, DataBaseNight.DataBaseNightData> nightData,
        Il2CppSystem.Collections.Generic.Dictionary<int,
            Il2CppSystem.ValueTuple<DEYU.AssetHandleUtility.IAssetHandle<Sprite>, DEYU.AssetHandleUtility.IAssetHandle<Sprite>>> characterPortrayalDictionary)
    {
        Log.InfoCaller("called");
        nightDataRef = nightData;

        foreach (var charConfig in ResourceExManager.GetAllCharacterConfigs().Where(c => c.portraits != null && c.portraits.Count > 0 && c.id == 9000))
        {
            Spell_Daiyousei.Register(charConfig);
        }

        foreach (var charConfig in ResourceExManager.GetAllCharacterConfigs().Where(c => c.portraits != null && c.portraits.Count > 0 && c.id == 9001))
        {
            Spell_Koakuma.Register(charConfig);
        }
    }

    [HarmonyPatch(nameof(DataBaseNight.UnloadWorkSceneData))]
    [HarmonyPostfix]
    public static void UnloadWorkSceneData_Postfix()
    {
        Spell_Daiyousei.DeRegister();
        Spell_Koakuma.DeRegister();
    }

    [HarmonyPatch(nameof(DataBaseNight.WorkSceneGetSpellPortrayal))]
    [HarmonyPrefix]
    public static bool WorkSceneGetSpellPortrayal_Prefix(int specialGuestId, bool isPositiveSpellCard, ref Sprite __result)
    {
        if (specialGuestId == 9000)
        {
            Log.InfoCaller($"Spell_Daiyousei");
            __result = isPositiveSpellCard ? Spell_Daiyousei.PositiveSpellPortrayal.Asset : Spell_Daiyousei.NegativeSpellPortrayal.Asset;
            return false;
        }
        if (specialGuestId == 9001)
        {
            Log.InfoCaller($"Spell_Koakuma");
            __result = isPositiveSpellCard ? Spell_Koakuma.PositiveSpellPortrayal.Asset : Spell_Koakuma.NegativeSpellPortrayal.Asset;
            return false;
        }
        return true;
    }

}




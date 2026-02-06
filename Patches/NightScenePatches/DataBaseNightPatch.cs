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
}




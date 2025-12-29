using HarmonyLib;
using GameData.Core.Collections.DaySceneUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using System.Collections.Generic;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Core.Collections.DaySceneUtility.DataBaseDay))]
[AutoLog]
public partial class DataBaseDayPatch
{
    public static Dictionary<string, NPC> NPCsToRegister = new Dictionary<string, NPC>();

    [HarmonyPatch(nameof(DataBaseDay.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseDay.Initialize Postfix called.");
        foreach (var kvp in NPCsToRegister)
        {
            var label = kvp.Key;
            var npc = kvp.Value;
            var success = DataBaseDay.allNPCs.TryAdd(label, npc);
            Log.LogInfo($"Registered NPC for Special Guest: {label} {success}");
        }
    }
}




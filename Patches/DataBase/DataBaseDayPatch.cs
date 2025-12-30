using HarmonyLib;
using GameData.Core.Collections.DaySceneUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using System.Collections.Generic;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.Core.Collections.DaySceneUtility.DataBaseDay))]
[AutoLog]
public partial class DataBaseDayPatch
{

    [HarmonyPatch(nameof(DataBaseDay.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseDay.Initialize Postfix called.");
        ResourceExManager.RegisterNPCs();
    }
}




using GameData.Core.Collections.DaySceneUtility;
using HarmonyLib;

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
        ResourceExManager.OnDataBaseDayInitialized();
    }
}




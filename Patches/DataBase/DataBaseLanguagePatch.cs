
using HarmonyLib;
using System.Collections.Generic;
using GameData.CoreLanguage.Collections;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.CoreLanguage.Collections.DataBaseLanguage))]
[AutoLog]
public partial class DataBaseLanguagePatch
{
    public static Dictionary<int, Dictionary<int, string>> FoodRequestsToRegister = new Dictionary<int, Dictionary<int, string>>();
    
    [HarmonyPatch(nameof(DataBaseLanguage.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseLanguage.Initialize Postfix called.");
        ResourceExManager.RegisterAllFoodRequests();
    }
}
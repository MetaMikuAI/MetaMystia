
using HarmonyLib;
using System.Collections.Generic;
using GameData.CoreLanguage.Collections;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.CoreLanguage.Collections.DataBaseLanguage))]
[AutoLog]
public partial class DataBaseLanguagePatch
{    
    [HarmonyPatch(nameof(DataBaseLanguage.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseLanguage.Initialize Postfix called.");
        ResourceExManager.OnDataBaseLanguageInitialized();
    }
}
using HarmonyLib;
using GameData.CoreLanguage.Collections;

namespace MetaMystia;


[HarmonyPatch(typeof(GameData.CoreLanguage.Collections.DaySceneLanguage))]
[AutoLog]
public partial class DaySceneLanguagePatch
{
    [HarmonyPatch(nameof(DaySceneLanguage.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DaySceneLanguage.Initialize Postfix called.");
        ResourceExManager.OnDaySceneLanguageInitialized();
    }
}


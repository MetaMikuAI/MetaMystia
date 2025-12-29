using Common.UI;
using HarmonyLib;
using PrepNightScene;

namespace MetaMystia;


[HarmonyPatch(typeof(PrepNightScene.SceneManager))]
[AutoLog]
public partial class PrepNightSceneManagerPatch
{
    
    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void PrepNightScene_Start_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.IzakayaPrepScene;
        PrepSceneManager.init();
        Log.LogInfo($"CurrentGameStage switched to IzakayaPrepScene");
        SceneTransitAction.Send(MpManager.LocalScene);
        ResourceExManager.TryInjectAllSpecialGuests();
        ResourceExManager.TryInjectAllSpecialGuestEvaluations();
    }
}
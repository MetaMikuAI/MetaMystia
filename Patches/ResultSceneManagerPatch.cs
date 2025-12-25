using HarmonyLib;
using Common.UI;
using NightScene;

namespace MetaMystia;

[HarmonyPatch(typeof(ResultScene.SceneManager))]
[AutoLog]
public partial class ResultSceneManagerPatch
{

    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void SceneManager_Start_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.ResultScene;
        Log.LogInfo($"CurrentGameStage switched to ResultScene");
    }
}
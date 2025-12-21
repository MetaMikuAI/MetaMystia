using HarmonyLib;
using Common.UI;
using MainScene;

namespace MetaMystia;


[HarmonyPatch(typeof(MainScene.SceneManager))]
[HarmonyPatch]
public class MainSceneManagerPatch : PatchBase<MainSceneManagerPatch>
{
    [HarmonyPatch(nameof(SceneManager.Awake))]
    [HarmonyPostfix]
    public static void MainScene_Awake_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.MainScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to MainScene");
        Plugin.EnterMainScene();
    }
}
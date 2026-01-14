using Common.UI;
using HarmonyLib;
using MainScene;

namespace MetaMystia;


[HarmonyPatch(typeof(MainScene.SceneManager))]
[HarmonyPatch]
[AutoLog]
public partial class MainSceneManagerPatch
{
    [HarmonyPatch(nameof(SceneManager.Awake))]
    [HarmonyPostfix]
    public static void MainScene_Awake_Postfix()
    {
        MpManager.OnSceneTransit(Scene.MainScene);
        Plugin.OnEnterMainScene();
    }
}
using Common.UI;
using HarmonyLib;
using StaffScene;

namespace MetaMystia;

[HarmonyPatch(typeof(StaffScene.SceneManager))]
[HarmonyPatch]
[AutoLog]
public partial class StaffSceneManagerPatch
{
    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void StaffScene_Start_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.StaffScene;
        Log.LogInfo($"CurrentGameStage switched to StaffScene");
    }
}
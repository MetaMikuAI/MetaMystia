using HarmonyLib;
using Common.UI;
using NightScene;

namespace MetaMystia;


[HarmonyPatch(typeof(NightScene.SceneManager))]
public class NightSceneManagerPatch : PatchBase<NightSceneManagerPatch>
{

    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void NightScene_Start_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.WorkScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to WorkScene");
        if (!MpManager.IsConnected)
        {
            return;
        }

        MystiaManager.Instance.Initialize();
        KyoukoManager.Initialize();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            var position = MystiaManager.Instance.GetPosition();
            KyoukoManager.SpawnNightKyouko(position, true, true);
        }, () => Common.SceneDirector.instance.characterCollection.ContainsKey("Self"));
    }
}
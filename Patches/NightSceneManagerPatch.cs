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
        NightGuestManager.Clear();
        MystiaManager.Instance.Initialize();
        KyoukoManager.Initialize();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            var position = MystiaManager.Instance.GetPosition();
            KyoukoManager.SpawnNightKyouko(position, true, true);
            NightScene.EventUtility.EventManager.Instance.totalCountDown = NightScene.SceneManager.NIGHT_WHOLE_TIME * 2;
        }, () => Common.SceneDirector.instance.characterCollection.ContainsKey("Self"));
    }
}
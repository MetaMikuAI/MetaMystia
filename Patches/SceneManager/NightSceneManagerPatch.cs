using HarmonyLib;
using Common.UI;
using NightScene;
using SgrYuki.Utils;

namespace MetaMystia;


[HarmonyPatch(typeof(NightScene.SceneManager))]
[AutoLog]
public partial class NightSceneManagerPatch
{

    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void NightScene_Start_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.WorkScene;
        Log.LogInfo($"CurrentGameStage switched to WorkScene");

        if (!MpManager.IsConnected)
        {
            return;
        }
        NightGuestManager.Clear();
        MpManager.Initialize();

        CommandScheduler.Enqueue(
            executeWhen: () => Common.SceneDirector.instance.characterCollection.ContainsKey("Self"),
            execute: () =>
            {
                var position = MystiaManager.Instance.GetPosition();
                KyoukoManager.SpawnNightKyouko(position, true, true);
                NightScene.EventUtility.EventManager.Instance.totalCountDown = SceneManager.NIGHT_WHOLE_TIME * 2;
            },
            timeoutSeconds: 120
        );
    }
}
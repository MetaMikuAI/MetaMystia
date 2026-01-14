using Common.UI;
using HarmonyLib;
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
        SceneTransitAction.Send(MpManager.LocalScene);

        if (!MpManager.IsConnected)
        {
            return;
        }
        NightGuestManager.Clear();
        MpManager.Initialize();

        CommandScheduler.Enqueue(
            executeWhen: () => MystiaManager.CharacterSpawnedAndInitialized,
            executeInfo: $"spawn night kyouko and add night time",
            execute: () =>
            {
                var position = MystiaManager.GetPosition();
                KyoukoManager.SpawnNightKyouko(position, true, true);
                NightGuestManager.ModifyWorkTimeLeft(SceneManager.NIGHT_WHOLE_TIME * 2);
            },
            timeoutSeconds: 120
        );
    }
}
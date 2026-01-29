using Common.UI;
using HarmonyLib;
using NightScene;
using SgrYuki;

namespace MetaMystia;


[HarmonyPatch(typeof(NightScene.SceneManager))]
[AutoLog]
public static partial class NightSceneManagerPatch
{

    [HarmonyPatch(nameof(SceneManager.Start))]
    [HarmonyPostfix]
    public static void NightScene_Start_Postfix()
    {
        MpManager.OnSceneTransit(Scene.WorkScene);

        if (!MpManager.IsConnected)
        {
            return;
        }
        PrepSceneManager.ClearPrepTable();
        WorkSceneManager.Clear();
        MpManager.Initialize();

        CommandScheduler.Enqueue(
            executeWhen: () => MystiaManager.CharacterSpawnedAndInitialized,
            executeInfo: $"spawn night kyouko and add night time",
            execute: () =>
            {
                var position = MystiaManager.Position;
                PeerManager.SpawnNightKyouko(position, true, true);
                CommandScheduler.Enqueue(
                    executeWhen: () => WorkSceneManager.WorkTimeLeft > 0,
                    execute: () =>
                    {
                        Notify.ShowExtern($"你今晚的营业时间为 {WorkSceneManager.WorkTimeLeft / 60} 分钟");
                    },
                    timeoutSeconds: 120
                );
            },
            timeoutSeconds: 120
        );
        CommandScheduler.EnqueueKey(
            key: MpManager.PeerGetCharacterUnitNotNullCommand,
            executeWhen: () => PeerManager.GetCharacterUnit() != null,
            execute: () =>
            {
                if (!MpManager.InStory)
                {
                    PeerManager.EnableCollision(true);
                }
            },
            timeoutSeconds: 120
        );
    }
}

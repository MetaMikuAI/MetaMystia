using HarmonyLib;

using Common.UI;
using NightScene;

using MetaMystia.UI;
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
        PlayerManager.Local.ResetState();

        if (!MpManager.IsConnected)
        {
            return;
        }

        PrepSceneManager.ClearPrepTable();
        WorkSceneManager.Clear();

        PlayerManager.ResetState();
        PlayerManager.SpawnPeers();

        CommandScheduler.Enqueue(
            executeWhen: () => WorkSceneManager.WorkTimeLeft > 0,
            execute: () =>
            {
                Notify.ShowExtern(TextId.TodayBusinessHours.Get(WorkSceneManager.WorkTimeLeft / 60));
            },
            timeoutSeconds: 120
        );
        CommandScheduler.EnqueueKey(
            key: MpManager.PeerGetCharacterUnitNotNullCommand,
            executeWhen: () => PlayerManager.Peer?.GetCharacterUnit() != null,
            execute: () =>
            {
                PlayerManager.EnablePeerCollision(true);
            },
            timeoutSeconds: 120
        );
    }
}

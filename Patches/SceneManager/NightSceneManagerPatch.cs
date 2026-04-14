using HarmonyLib;

using Common.UI;
using MetaMystia.Network;
using MetaMystia.Patch;
using NightScene;

using MetaMystia.UI;
using NightScene.GuestManagementUtility;
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
        // REFACTORING
        // GuestsManagerPatch.ReimuSpellCard = false;

        MpManager.OnSceneTransit(Scene.WorkScene);
        PlayerManager.Local.ResetState();
        PlayerManager.InitLocalSkin();

        if (!MpManager.IsConnected)
        {
            return;
        }
        SkinChangeAction.Send(PlayerManager.Local.Skin);

        PrepSceneManager.ClearPrepTable();
        WorkSceneManager.Clear();

        PlayerManager.ResetState();
        PlayerManager.SpawnPeers();

        CommandScheduler.Enqueue(
            executeWhen: () => WorkSceneManager.WorkTimeLeft > 0,
            execute: () =>
            {
                InGameConsole.ShowPassive(TextId.TodayBusinessHours.Get(WorkSceneManager.WorkTimeLeft / 60));
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

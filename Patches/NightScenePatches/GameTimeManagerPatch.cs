using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(Common.TimelineExtestion.GameTimeManager))]
[AutoLog]
public partial class GameTimeManagerPatch
{
    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.SetGameTimeMode))]
    [HarmonyPrefix]
    public static void SetGameTimeMode_Prefix(Common.TimelineExtestion.GameTimeManager __instance, ref Common.TimelineExtestion.GameTimeManager.TimeMode mode)
    {
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            mode = Common.TimelineExtestion.GameTimeManager.TimeMode.Resume;
        }
    }

    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.OnPlayableDirectorPlayed))]
    [HarmonyPrefix]
    public static void OnPlayableDirectorPlayed_Prefix(Common.TimelineExtestion.GameTimeManager __instance, ref UnityEngine.Playables.PlayableDirector playableDirector)
    {
        var prevCollisionSetting = KyoukoManager.GetIgnoreCollision();
        var onStopped = (UnityEngine.Playables.PlayableDirector _) =>
        {
            SgrYuki.Utils.CommandScheduler.Enqueue(
                executeWhen: () => MystiaManager.CharacterSpawnedAndInitialized,
                executeInfo: $"set ignore collision to {prevCollisionSetting}",
                execute: () => KyoukoManager.IgnoreCollisionWithSelf(prevCollisionSetting)
            );
        };
        playableDirector.add_stopped(onStopped);
        SgrYuki.Utils.CommandScheduler.Enqueue(
            executeWhen: () => MystiaManager.CharacterSpawnedAndInitialized,
            executeInfo: $"set ignore collision to true",
            execute: () => KyoukoManager.IgnoreCollisionWithSelf(true)
        );
    }
}
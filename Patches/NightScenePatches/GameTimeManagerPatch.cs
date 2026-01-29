using HarmonyLib;
using SgrYuki;

namespace MetaMystia;

[HarmonyPatch(typeof(Common.TimelineExtestion.GameTimeManager))]
[AutoLog]
public partial class GameTimeManagerPatch
{
    public const string StoryStartActionKey = "story_start_disable_collision";
    public const string StoryStopActionKey = "story_over_enable_collision";

    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.SetGameTimeMode))]
    [HarmonyPrefix]
    public static void SetGameTimeMode_Prefix(Common.TimelineExtestion.GameTimeManager __instance, ref Common.TimelineExtestion.GameTimeManager.TimeMode mode)
    {
        if (MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.ShouldSkipAction)
        {
            mode = Common.TimelineExtestion.GameTimeManager.TimeMode.Resume;
        }
        Log.DebugCaller($"time mode changed to {mode}");
    }

    public static void FreezeTime() => Common.TimelineExtestion.GameTimeManager.Instance?.SetGameTimeMode(Common.TimelineExtestion.GameTimeManager.TimeMode.Freeze);
    public static void ResumeTime() => Common.TimelineExtestion.GameTimeManager.Instance?.SetGameTimeMode(Common.TimelineExtestion.GameTimeManager.TimeMode.Resume);

    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.OnPlayableDirectorPlayed))]
    [HarmonyPrefix]
    public static void OnPlayableDirectorPlayed_Prefix(Common.TimelineExtestion.GameTimeManager __instance, UnityEngine.Playables.PlayableDirector playableDirector)
    {
        var onStopped = (UnityEngine.Playables.PlayableDirector _) =>
        {
            CommandScheduler.RemoveKeyFromKeyQueue(StoryStartActionKey);

            CommandScheduler.EnqueueKey(
                key: StoryStartActionKey,
                executeWhen: () => PeerManager.GetCharacterUnit() != null,
                execute: () =>
                {
                    Log.Info($"story over, enabled collision for {PeerManager.GetCharacterUnit()?.name}");
                    PeerManager.EnableCollision(true);
                }
            );
            playableDirector.remove_stopped(_onPlayableDirectorStoppedCallback);
            Log.Info($"removed callback for {playableDirector.name}");
        };
        _onPlayableDirectorStoppedCallback = onStopped;
        playableDirector.add_stopped(_onPlayableDirectorStoppedCallback);

        CommandScheduler.RemoveKeyFromKeyQueue(StoryStopActionKey);
        CommandScheduler.EnqueueKey(
            key: StoryStartActionKey,
            executeWhen: () => PeerManager.GetCharacterUnit() != null,
            execute: () =>
            {
                Log.Info($"story start, disabled collision for {PeerManager.GetCharacterUnit()?.name}");
                PeerManager.EnableCollision(false);
            }
        );
    }

    private static Il2CppSystem.Action<UnityEngine.Playables.PlayableDirector> _onPlayableDirectorStoppedCallback;
}

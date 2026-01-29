using Common.UI;
using DayScene;
using HarmonyLib;
using MetaMystia.Network;
using SgrYuki;
using SgrYuki.Utils;

namespace MetaMystia;


[HarmonyPatch(typeof(DayScene.SceneManager))]
[AutoLog]
public partial class DaySceneManagerPatch
{
    [HarmonyPatch(nameof(SceneManager.Awake))]
    [HarmonyPostfix]
    public static void Awake_Postfix()
    {
        MpManager.OnSceneTransit(Scene.DayScene);
        MpManager.Initialize();
        ResourceExManager.OnDaySceneAwake();
        PrepSceneManager.ClearPrepTable();

        if (MpManager.IsConnected)
        {
            CommandScheduler.EnqueueKey(
                key: MpManager.PeerGetCharacterUnitNotNullCommand,
                executeWhen: () => PeerManager.GetCharacterUnit() != null,
                execute: () =>
                {
                    if (!MpManager.InStory)
                    {
                        PeerManager.EnableCollision(true);
                    }
                    PeerManager.GetCharacterComponent()?.UpdateIcon(false);
                },
                timeoutSeconds: 120
            );
        }
    }


    public static void OnDayOver()
    {
        if (MpManager.IsConnectedClient)
        {
            GuestInviteAction.Send(GameData.RunTime.Common.StatusTracker.Instance?.InvitedGuests.ToManagedList());
        }
        Panel.CloseActivePanelsBeforeSceneTransit();
        OnDayOver_Original(SceneManager.Instance);
    }

    [HarmonyPatch(nameof(SceneManager.OnDayOver))]
    [HarmonyPrefix]
    public static bool OnDayOver_Prefix()
    {
        Log.InfoCaller($"called");

        MystiaManager.IsDayOver = true;

        if (!MpManager.IsConnected)
        {
            return true;
        }

        Notify.ShowOnMainThread(TextId.MystiaReadyForWork.Get());
        ReadyAction.Send(ReadyType.DayOver);
        MpManager.DayOver(MpManager.SERVER_ID);
        return false;
    }

    [HarmonyPatch(nameof(SceneManager.OnDayOver))]
    [HarmonyReversePatch]
    private static void OnDayOver_Original(SceneManager __instance)
    {
        throw new System.NotImplementedException();
    }

    public static volatile bool SwappingMap = false;
    [HarmonyPatch(nameof(SceneManager.SwapMap))]
    [HarmonyPrefix]
    public static bool SwapMap_Prefix(SceneManager __instance, string targetMapLabel, string targetMarkerName, int travelCount, ref Il2CppSystem.Action onSwapFinish)
    {
        Log.InfoCaller($"targetMapLabel {targetMapLabel}, targetMarkerName {targetMarkerName}");
        if (!MpManager.ShouldSkipAction && MystiaManager.IsDayOver) return false;
        var added = () =>
        {
            Log.Info($"SwapMap Finished");
            SwappingMap = false;
            CommandScheduler.EnqueueWithNoCondition(() => PeerManager.TryAddHeightProcessor());
            SyncAction.Send();
        };
        onSwapFinish += added;
        SwappingMap = true;
        return true;
    }

    [HarmonyPatch(nameof(SceneManager.SwapMap))]
    [HarmonyPostfix]
    public static void SwapMap_Postfix(SceneManager __instance, string targetMapLabel, string targetMarkerName, int travelCount)
    {
        Log.DebugCaller($"targetMapLabel {targetMapLabel}, targetMarkerName {targetMarkerName}");
        MystiaManager.MapLabel = targetMapLabel;
    }
}

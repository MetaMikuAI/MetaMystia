using GameData.RunTime.Common;
using HarmonyLib;
namespace MetaMystia;

[HarmonyPatch(typeof(RunTimeScheduler))]
[AutoLog]
public partial class RunTimeSchedulerPatch
{
    [HarmonyPatch(nameof(RunTimeScheduler.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.Warning("RunTimeScheduler.Initialize Postfix called.");    
    }

    [HarmonyPatch(nameof(RunTimeScheduler.OnEnterDaySceneMap))]
    [HarmonyPostfix]
    public static void OnEnterDaySceneMap_Postfix(string mapLabel)
    {
        MystiaManager.MapLabel = mapLabel;
        if (MpManager.IsConnected && !MpManager.InStory)
        {
            SyncAction.Send();
            KyoukoManager.TryAddHeightProcessor();
        }
    }
}
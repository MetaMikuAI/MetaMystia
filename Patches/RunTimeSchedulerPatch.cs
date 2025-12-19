using HarmonyLib;
using GameData.RunTime.Common;
namespace MetaMystia;

[HarmonyPatch(typeof(RunTimeScheduler))]
public class RunTimeSchedulerPatch : PatchBase<RunTimeSchedulerPatch>
{
    [HarmonyPatch(nameof(RunTimeScheduler.OnEnterDaySceneMap))]
    [HarmonyPostfix]
    public static void OnEnterDaySceneMap_Postfix(string mapLabel)
    {
        MystiaManager.MapLabel = mapLabel;
        MpManager.SendSync();
    }
}
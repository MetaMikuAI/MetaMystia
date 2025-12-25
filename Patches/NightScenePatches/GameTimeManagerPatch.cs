using HarmonyLib;

namespace MetaMystia;

[HarmonyPatch(typeof(Common.TimelineExtestion.GameTimeManager))]
[AutoLog]
public partial class GameTimeManagerPatch
{
    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.SetGameTimeMode))]
    [HarmonyPrefix]
    public static void SetGameTimeModePatch(Common.TimelineExtestion.GameTimeManager __instance, ref Common.TimelineExtestion.GameTimeManager.TimeMode mode)
    {
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            mode = Common.TimelineExtestion.GameTimeManager.TimeMode.Resume;
        }
    }
}
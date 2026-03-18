using HarmonyLib;

using DayScene.Input;

using MetaMystia.Network;
using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(DayScene.Input.DayScenePlayerInputGenerator))]
[AutoLog]
public partial class DayScenePlayerInputPatch
{
    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintPerformed))]
    [HarmonyPrefix]
    public static bool OnSprintPerformed_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen)
        {
            return SkipOriginal;
        }
        PlayerManager.LocalIsSprinting = true;
        SyncAction.Send();
        return RunOriginal;
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintCanceled))]
    [HarmonyPrefix]
    public static void OnSprintCanceled_Prefix()
    {
        PlayerManager.LocalIsSprinting = false;
        SyncAction.Send();
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.TryInteract))]
    [HarmonyPrefix]
    public static bool TryInteract_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen)
        {
            Log.Warning($"Console is open, skipping interaction");
            return SkipOriginal;
        }
        if (!MpManager.IsConnected)
        {
            return RunOriginal;
        }
        if (PlayerManager.LocalIsDayOver)
        {
            Log.Warning($"Day is over, skipping interaction");
            return SkipOriginal;
        }
        return RunOriginal;
    }
}

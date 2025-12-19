using HarmonyLib;
using DayScene.Input;

namespace MetaMystia;

[HarmonyPatch(typeof(DayScene.Input.DayScenePlayerInputGenerator))]
public class DayScenePlayerInputPatch : PatchBase<DayScenePlayerInputPatch>
{
    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintPerformed))]
    [HarmonyPrefix]
    public static bool OnSprintPerformed_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen) 
        {
            return false;
        }
        MystiaManager.IsSprinting = true;
        MpManager.SendSync();
        return true;
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintCanceled))]
    [HarmonyPrefix]
    public static void OnSprintCanceled_Prefix()
    {
        MystiaManager.IsSprinting = false;
        MpManager.SendSync();
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.TryInteract))]
    [HarmonyPrefix]
    public static bool TryInteract_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen)
        {
            return false;
        }
        if (MystiaManager.IsReady) 
        {
            return false;
        }
        return true;
    }
}
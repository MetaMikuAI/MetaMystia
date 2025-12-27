using DayScene.Input;
using HarmonyLib;

namespace MetaMystia;

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
            return false;
        }
        MystiaManager.IsSprinting = true;
        SyncAction.Send();
        return true;
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintCanceled))]
    [HarmonyPrefix]
    public static void OnSprintCanceled_Prefix()
    {
        MystiaManager.IsSprinting = false;
        SyncAction.Send();
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
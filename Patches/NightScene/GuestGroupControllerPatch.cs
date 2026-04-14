using HarmonyLib;

using NightScene.GuestManagementUtility;

using static MetaMystia.Patch.HarmonyPrefixFlow;


namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestGroupController))]
[TracePatch(nameof(GuestGroupController.MoveToQueue))]
[TracePatch(nameof(GuestGroupController.MoveToDesk))]
[TracePatch(nameof(GuestGroupController.GenerateOrder))]
[TracePatch(nameof(GuestGroupController.RemoveFromQueue))]
[TracePatch(nameof(GuestGroupController.MoveToSpawn))]
[AutoLog]
public partial class GuestGroupControllerPatch
{
    // === FSM: Constructed → Queued ===
    [HarmonyPatch(nameof(GuestGroupController.MoveToQueue))]
    [HarmonyPrefix]
    public static void MoveToQueue_FSM_Prefix(GuestGroupController __instance)
    {
        var fsm = __instance.GetGuestFSM();
        if (fsm == null) return;
        fsm.OnQueueEntered();
    }

    // === FSM: Queued → Leaving (排队耐心耗尽) ===
    [HarmonyPatch(nameof(GuestGroupController.MoveToSpawn))]
    [HarmonyPrefix]
    public static void MoveToSpawn_FSM_Prefix(GuestGroupController __instance)
    {
        var fsm = __instance.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.Queued)
            fsm.OnQueueTimedOut();
    }
}

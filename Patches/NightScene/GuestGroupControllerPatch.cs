using HarmonyLib;

using NightScene.GuestManagementUtility;

using MetaMystia.Network;

using static MetaMystia.Patch.HarmonyPrefixFlow;


namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestGroupController))]
[TracePatch(nameof(GuestGroupController.MoveToQueue))]
[TracePatch(nameof(GuestGroupController.MoveToDesk))]
[TracePatch(nameof(GuestGroupController.GenerateOrder))]
[TracePatch(nameof(GuestGroupController.RemoveFromQueue))]
[TracePatch(nameof(GuestGroupController.MoveToSpawn))]
[TracePatch(nameof(GuestGroupController.FlyToSpawn))]
[TracePatch(nameof(GuestGroupController.RefreshCurrentFundAndOrder))]
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

    // === FSM: Queued → Leaving (排队耐心耗尽) + Network ===
    [HarmonyPatch(nameof(GuestGroupController.MoveToSpawn))]
    [HarmonyPrefix]
    public static void MoveToSpawn_FSM_Prefix(GuestGroupController __instance)
    {
        var fsm = __instance.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.Queued)
        {
            fsm.OnQueueTimedOut();
            if (MpManager.IsConnectedHost)
            {
                var uuid = WorkSceneManager.GetGuestUUID(__instance);
                if (uuid != null)
                    GuestFSMEventAction.SendQueueTimedOut(uuid);
            }
        }
    }

    // === FSM: SeatMoving → SeatedDelay (到达座位) ===
    // RefreshCurrentFundAndOrder 在 _TrySendToSeat_b__0 (OnArrive 回调) 中被调用，
    // 此时角色刚到达桌位，随后进入 10s/speed 的首单延时。
    [HarmonyPatch(nameof(GuestGroupController.RefreshCurrentFundAndOrder))]
    [HarmonyPrefix]
    public static void RefreshCurrentFundAndOrder_FSM_Prefix(GuestGroupController __instance)
    {
        var fsm = __instance.GetGuestFSM();
        if (fsm == null) return;
        if (fsm.CurrentState == GuestFSM.State.SeatMoving)
            fsm.OnSeated(__instance.DeskCode);
    }

    // === Network: GenerateOrder 后捕获订单并发送 ===
    [HarmonyPatch(nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPostfix]
    public static void GenerateOrder_Postfix(
        GuestGroupController __instance,
        ref string orderGenerationMessage,
        ref GuestsManager.OrderBase generatedOrder)
    {
        if (__instance == null || generatedOrder == null) return;
        if (!MpManager.IsConnectedHost) return;

        var uuid = WorkSceneManager.GetGuestUUID(__instance);
        if (uuid == null) return;

        var order = new GuestOrder(
            generatedOrder.foodRequest,
            generatedOrder.beverageRequest,
            generatedOrder.DeskCode,
            generatedOrder.NotShowInUI,
            generatedOrder.FreeOrder);

        bool isContinue = __instance.GetGuestFSM()?.CurrentState == GuestFSM.State.ContinueDecision;
        GuestFSMEventAction.SendOrder(uuid, order, orderGenerationMessage, isContinue);
    }
}

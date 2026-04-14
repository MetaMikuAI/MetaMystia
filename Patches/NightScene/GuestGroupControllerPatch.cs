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
}

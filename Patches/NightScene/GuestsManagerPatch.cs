using System;
using HarmonyLib;

using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;


using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))]
// === 生成与初始化 ===
[TracePatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
[TracePatch(nameof(GuestsManager.SpawnNormalGuestGroup), new[] {
    typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
    typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
    typeof(GuestGroupController.LeaveType),
    typeof(int),
    typeof(bool),
}, DisplayName = "GuestsManager.SpawnNormalGuestGroup_WithArgs")]
[TracePatch(nameof(GuestsManager.SpawnNormalGuestGroup), new Type[0], DisplayName = "GuestsManager.SpawnNormalGuestGroup")]
[TracePatch(nameof(GuestsManager.SpawnManualControlledSpecialGuestGroup))]
[TracePatch("SpawnGuest")]
[TracePatch(nameof(GuestsManager.PostInitializeGuestGroup))]
// === 排队与入座 ===
[TracePatch(nameof(GuestsManager.TrySendToSeat))]
[TracePatch(nameof(GuestsManager.CheckAndSendFromQueue))]
// === 点单与待上菜 ===
[TracePatch("FirstOrder")]
[TracePatch("GenerateOrderSession")]
[TracePatch(nameof(GuestsManager.ExcuteEventAtCorodinate))]
[TracePatch("ShowOrder")]
// === 评价与续单 ===
[TracePatch(nameof(GuestsManager.EvaluateOrder))]
[TracePatch("EvaulateManualOrder")]
[TracePatch("MainOrderCycle")]
[TracePatch("LackMoneyEvaluate")]
// === 耐心与强制离场 ===
[TracePatch("AddToPatientCountdown")]
[TracePatch("RemoveFromPatientCountdown")]
[TracePatch("PatientDepletedLeave")]
[TracePatch("RepellInternal")]
[TracePatch(nameof(GuestsManager.PlayerRepell))]
[TracePatch(nameof(GuestsManager.TryRepellAllQueuedGuestControllers))]
// === 结账与离场 ===
[TracePatch(nameof(GuestsManager.PayAndLeave))]
[TracePatch(nameof(GuestsManager.GuestPay))]
[TracePatch(nameof(GuestsManager.PayByMood))]
[TracePatch("LeaveFromDesk")]
[AutoLog]
public partial class GuestsManagerPatch
{
}

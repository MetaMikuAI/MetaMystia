using System.Linq;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using HarmonyLib;
using Il2CppSystem.IO;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[HarmonyPatch]
[AutoLog]
public partial class NightScene_SceneManager__c__DisplayClass62_0_Patch
{
    [HarmonyPatch(typeof(NightScene.SceneManager.__c__DisplayClass62_0), nameof(NightScene.SceneManager.__c__DisplayClass62_0._InitializeAsGeneralWorkScene_b__0))]
    [HarmonyPrefix]
    public static void InitializeAsGeneralWorkScene_Prefix()
    {
        // This patch is for Reimu Protection spell card
        Log.Info("_InitializeAsGeneralWorkScene_b__0 called");
    }
}

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))]
[AutoLog]
public partial class GuestsManagerPatch
{
    // public static readonly System.Threading.AsyncLocal<bool> PassGuestSpawn = new();
    public static volatile bool SpawnNormalGuestGroup_WithArg_Manual_Call = false;

    public static int IndexAt(string uuid, Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<CharacterSpriteSetCompact> arr, CharacterSpriteSetCompact item)
    {
        int result = 0;
        var itemString = item.ToString();
        for (int i = 0; i < arr.Length; i++)
        {
            if (itemString.Equals(arr[i].ToString()))
            {
                result = i;
                Log.LogMessage($"{uuid} found at {i} => {itemString}");
                break;
            }
        }
        return result;
    }
    [HarmonyPatch(nameof(GuestsManager.PostInitializeGuestGroup))]
    [HarmonyPrefix]
    public static void PostInitializeGuestGroup_Prefix(GuestGroupController initializedController)
    {
        if (MpManager.IsConnectedHost && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            _ = WorkSceneManager.StoreGuest(initializedController);
        }
    }


    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [])]
    [HarmonyPrefix]
    public static bool SpawnNormalGuestGroup_Prefix()
    {
        // Log.LogInfo($"SpawnNormalGuestGroup_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if (MpManager.IsClient)
            {
                return false;
            }
            else
            {
                var cook = NightScene.CookingUtility.CookSystemManager.Instance;
                while (true)
                {
                    var guestGroups = cook?.GetRandomNormalGuestGroups();
                    if (guestGroups == null)
                    {
                        Log.LogError($"CookSystemManager failed to GetRandomNormalGuestGroups!");
                        return true;
                    }
                    var arr = guestGroups.ToArray();
                    if (arr.All((guest) => DLCManager.PeerNormalGuestAvailable(guest.id)))
                    {
                        _ = SpawnNormalGuestGroup_Original_MinHook(
                                    GuestsManager.instance, guestGroups, new Il2CppSystem.Nullable<UnityEngine.Vector3>(), GuestGroupController.LeaveType.Move, -1, true); 
                        return false;
                    }
                }
            }
        }
        return true;
    }

    public static NormalGuestsController SpawnNormalGuestGroup_Original_MinHook(
        GuestsManager __instance,
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = null,
        GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
        int targetDeskCode = -1,
        bool shouldFade = true)
    {
        SpawnNormalGuestGroup_WithArg_Manual_Call = true;
        // calling MinHook_SpawnNormalGuestGroup.Hook_SpawnNormalGuestGroup
        var res = __instance.SpawnNormalGuestGroup(normalGuests, overrideSpawnPosition, leaveType, targetDeskCode, shouldFade);
        SpawnNormalGuestGroup_WithArg_Manual_Call = false;
        return res;
    }


    [HarmonyPatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
    [HarmonyReversePatch]
    public static SpecialGuestsController SpawnSpecialGuestGroup_Original(GuestsManager __instance,
        int id,
        SpecialGuestsController.GuestSpawnType guestSpawnType,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = null,
        Il2CppSystem.Action<GuestGroupController> onGuestLeave = null,
        GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
        bool recordIzakaya = true,
        int targetDeskCode = -1,
        bool tryToJumpQueue = false,
        Il2CppSystem.Action<Common.CharacterUtility.AStarInputGeneratorComponent> postProcessCharacterCallback = null,
        bool shouldFade = true)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnSpecialGuestGroup))]
    [HarmonyPrefix]
    public static bool SpawnSpecialGuestGroup_Prefix(GuestsManager __instance, ref SpecialGuestsController __result,
        int id,
        SpecialGuestsController.GuestSpawnType guestSpawnType,
        ref Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
        Il2CppSystem.Action<GuestGroupController> onGuestLeave,
        GuestGroupController.LeaveType leaveType,
        bool recordIzakaya,
        int targetDeskCode,
        bool tryToJumpQueue,
        Il2CppSystem.Action<Common.CharacterUtility.AStarInputGeneratorComponent> postProcessCharacterCallback,
        bool shouldFade)
    {
        overrideSpawnPosition ??= new Il2CppSystem.Nullable<UnityEngine.Vector3>();

        if (!MpManager.IsConnected || MpManager.InStory)
        {
            return true;
        }

        bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
        if (IsReimuSpellCardTriggered)
        {
            return true;
        }
        if (MpManager.IsClient && MpManager.LocalScene == Common.UI.Scene.WorkScene)
        {
            return false;
        }

        if (!DLCManager.PeerSpecialGuestAvailable(id))
        {
            var newId = DLCManager.CoreSpecialGuests.GetRandomOne();
            Log.LogWarning($"id {id} is not available for peer, use new {newId}");
            id = newId;
        }
        __result = SpawnSpecialGuestGroup_Original(__instance, id, guestSpawnType, overrideSpawnPosition, onGuestLeave, leaveType, recordIzakaya, targetDeskCode, tryToJumpQueue, postProcessCharacterCallback, shouldFade);
        var info = new WorkSceneManager.GuestInfo
        {
            Id = id,
            IsSpecial = true,
            LeaveType = leaveType,
            OverrideSpawnPosition = overrideSpawnPosition.GetValueOrDefault()
        };
        // should be stored in PostInitializeGuestGroup_Prefix, which will be called by SpawnSpecialGuestGroup_Original
        var uuid = WorkSceneManager.GetGuestUUID(__result);
        if (uuid == null) return false;
        GuestSpawnAction.Send(uuid, info);
        WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Generated);
        return false;
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyReversePatch]
    public static bool TrySendToSeat_Original(object __instance, GuestGroupController toTry, bool firstSpawn, int targetDeskCode, bool shouldOrder)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyPrefix]
    public static bool TrySendToSeat_Prefix(GuestsManager __instance, GuestGroupController toTry, bool firstSpawn, ref int targetDeskCode, bool shouldOrder)
    {
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if (MpManager.IsClient)
            {
                Log.LogDebug($"TrySendToSeat prevented");
                return false;
            }
            else
            {
                var seatableDeskCodes = __instance.TrueAvailableDesks.FilterKey(value => value >= toTry.GuestCount);
                if (seatableDeskCodes.Count == 0) return false;
                targetDeskCode = seatableDeskCodes.GetRandomOne();

                var seatRand = UnityEngine.Random.Range(0, 2);
                var guuid = WorkSceneManager.GetGuestUUID(toTry);

                int copiedTargetDeskCode = targetDeskCode;

                WorkSceneManager.SetGuestDeskcodeSeat(guuid, seatRand);
                WorkSceneManager.SetGuestDeskcode(guuid, copiedTargetDeskCode);
                // Delay send seated action because SpawnNormalGuestGroup may execute TrySendToSeat first then return
                CommandScheduler.Enqueue(
                    executeWhen: () => WorkSceneManager.CheckStatus(guuid, WorkSceneManager.Status.Generated),
                    executeInfo: $"waiting {guuid} generated",
                    execute: () =>
                    {
                        WorkSceneManager.SetGuestStatus(guuid, WorkSceneManager.Status.Seated);
                        GuestSeatedAction.Send(guuid, copiedTargetDeskCode, firstSpawn, seatRand);
                    },
                    timeoutSeconds: 10);
                Log.LogDebug($"TrySendToSeat_Prefix called, desk code {targetDeskCode}, seat {seatRand}");
            
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.LeaveFromDesk))]
    [HarmonyReversePatch]
    public static void LeaveFromDesk_Original(GuestsManager __instance, GuestGroupController toLeave, GuestGroupController.LeaveType leaveType, Il2CppSystem.Action leaveAction, bool triggerLeaveBuff)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.LeaveFromDesk))]
    [HarmonyPrefix]
    public static bool LeaveFromDesk_Prefix(GuestsManager __instance, GuestGroupController toLeave)
    {
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = WorkSceneManager.GetGuestUUID(toLeave);
            if (uuid == null) return true;
            Log.LogInfo($"LeaveFromDesk_Prefix called, {uuid} leaving");

            if (MpManager.IsClient)
            {
                if (WorkSceneManager.IsGuestNull(toLeave))
                {
                    Log.LogError($"{uuid} toLeave or its component is null, will stop executing LeaveFromDesk");
                    return false;
                }
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                if (WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left))
                {
                    return true;
                }
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.Other);
            }
        }

        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PayAndLeave))]
    [HarmonyReversePatch]
    public static void PayAndLeave_Original(GuestsManager __instance, GuestGroupController toPayAndLeave, bool includeTip)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.PayAndLeave))]
    [HarmonyPrefix]
    public static bool PayAndLeave_Prefix(GuestsManager __instance, GuestGroupController toPayAndLeave, bool includeTip)
    {
        Log.LogInfo($"PayAndLeave_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toPayAndLeave.GetGuestUUID();
            if (uuid == null) return true;
            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(WorkSceneManager.GetGuestUUID(toPayAndLeave), WorkSceneManager.Status.Left);
            }
            else
            {
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PayAndLeave);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.ExBadLeave))]
    [HarmonyReversePatch]
    public static void ExBadLeave_Original(GuestsManager __instance, GuestGroupController toExBadLeave)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.ExBadLeave))]
    [HarmonyPrefix]
    public static bool ExBadLeave_Prefix(GuestsManager __instance, GuestGroupController toExBadLeave)
    {
        Log.LogInfo($"ExBadLeave_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toExBadLeave.GetGuestUUID();
            if (uuid == null) return true;
            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.ExBadLeave);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeavePay))]
    [HarmonyReversePatch]
    public static void RepellAndLeavePay_Original(GuestsManager __instance, GuestGroupController toRepell, GuestGroupController.LeaveType leaveType, bool triggerBuff)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeavePay))]
    [HarmonyPrefix]
    public static bool RepellAndLeavePay_Prefix(GuestsManager __instance, GuestGroupController toRepell)
    {
        Log.LogInfo($"RepellAndLeavePay_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;
            WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.RepelAndLeavePay);
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeaveNoPay))]
    [HarmonyReversePatch]
    public static void RepellAndLeaveNoPay_Original(GuestsManager __instance, GuestGroupController toRepell, GuestGroupController.LeaveType leaveType, bool triggerBuff)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeaveNoPay))]
    [HarmonyPrefix]
    public static bool RepellAndLeaveNoPay_Prefix(GuestsManager __instance, GuestGroupController toRepell)
    {
        Log.LogInfo($"RepellAndLeaveNoPay_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;
            WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.RepelAndLeaveNoPay);
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PlayerRepell))]
    [HarmonyReversePatch]
    public static void PlayerRepell_Original(GuestsManager __instance, int deskCode)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.PlayerRepell))]
    [HarmonyPrefix]
    public static bool PlayerRepell_Prefix(GuestsManager __instance, int deskCode)
    {
        Log.LogInfo($"PlayerRepell_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var toRepell = __instance.GetInDeskGuest(deskCode);
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;
            WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PlayerRepel);

            if (WorkSceneManager.IsGuestNull(toRepell))
            {
                Log.LogError($"toRepell is null, will stop executing PlayerRepell");
                WorkSceneManager.RemoveOccupiedDesk(deskCode);
                return false;
            }
        }
        return true;
    }


    [HarmonyPatch(nameof(GuestsManager.PatientDepletedLeave))]
    [HarmonyReversePatch]
    public static void PatientDepletedLeave_Original(GuestsManager __instance, GuestGroupController toPatientDepletedLeave)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.PatientDepletedLeave))]
    [HarmonyPrefix]
    public static bool PatientDepletedLeave_Prefix(GuestsManager __instance, GuestGroupController toPatientDepletedLeave)
    {
        Log.LogDebug($"PatientDepletedLeave_Prefix called");
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toPatientDepletedLeave.GetGuestUUID();
            if (uuid == null) return true;
            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PatientDepletedLeave);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PayByMood))]
    [HarmonyPrefix]
    public static bool PayByMood_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"PayByMood_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.GuestPay))]
    [HarmonyPrefix]
    public static bool GuestPay_Prefix(GuestsManager __instance, GuestGroupController toPayAndLeave, bool includeTip)
    {
        Log.LogInfo($"GuestPay_Prefix called");
        if (MpManager.IsConnectedHost && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = toPayAndLeave.GetGuestUUID();
            if (uuid == null) return true;
            // NightScene_GuestManagementUtility_GuestsManager__GenerateOrderSession
            if (Functional.CheckStacktraceContains("GenerateOrderSession"))
            {
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.Left);
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PayAndLeave);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.Eval))]
    [HarmonyPrefix]
    public static bool Eval_Prefix(GuestsManager __instance, int firstMood, int moon, float delay, int amount, bool shouldAddCombo)
    {
        Log.LogInfo($"Eval_Prefix called firstMood {firstMood}, moon {moon}, delay {delay}, amount {amount}, shouldAddCombo {shouldAddCombo}\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.EvaluateOrder))]
    [HarmonyPostfix]
    public static void EvaluateOrder_Postfix(GuestsManager __instance, GuestGroupController toEvaluate, bool isTriggerByPartner)
    {
        Log.Info($"EvaluateOrder_Postfix called");
        if (MpManager.IsConnected && !MpManager.InStory)
        {
            var uuid = WorkSceneManager.GetGuestUUID(toEvaluate);
            WorkSceneManager.ResetGuestOrderServed(uuid);
            WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.OrderEvaluated);
        }
    }

    [HarmonyPatch(nameof(GuestsManager.RemoveFromOrder))]
    [HarmonyPrefix]
    public static void RemoveFromOrder_Prefix(GuestsManager __instance, GuestsManager.OrderBase order)
    {
        Log.Info($"RemoveFromOrder_Prefix called, order food {order.foodRequest}, bev {order.beverageRequest}");
    }

    [HarmonyPatch(nameof(GuestsManager.GenerateOrderSession))]
    [HarmonyReversePatch]
    public static void GenerateOrderSession_Original(GuestsManager __instance, GuestGroupController guestGroup, bool doContinue)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.GenerateOrderSession))]
    [HarmonyPrefix]
    public static bool GenerateOrderSession_Prefix(GuestsManager __instance, GuestGroupController guestGroup, bool doContinue)
    {
        if (MpManager.IsConnectedClient && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var uuid = WorkSceneManager.GetGuestUUID(guestGroup);
            if (uuid == null) return true;
            Log.LogInfo($"GenerateOrderSession prevented for {uuid}");
            if (WorkSceneManager.CheckStatusIn(uuid, [WorkSceneManager.Status.Seated, WorkSceneManager.Status.OrderEvaluated]))
            {
                WorkSceneManager.SetGuestStatus(uuid, WorkSceneManager.Status.PendingOrder);
            }
            else
            {
                if (!WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.OrderGenerated))
                {
                    Log.Warning($"GenerateOrderSession, failed to set status for {uuid}, status now {WorkSceneManager.GetGuestStatusForLog(uuid)}");
                }
            }
            return false;
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.GenerateOrderSession))]
    [HarmonyPostfix]
    public static void GenerateOrderSession_Postfix(GuestsManager __instance, GuestGroupController guestGroup)
    {
        if (MpManager.IsConnectedHost && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            Log.LogInfo($"GenerateOrderSession postfix for {WorkSceneManager.GetGuestUUID(guestGroup)}");
            WorkSceneManager.DelayedSafeAddMaxPatient(guestGroup);
        }
    }

    [HarmonyPatch(nameof(GuestsManager.SetNormalManualControlledOrder))]
    [HarmonyPostfix]
    public static void SetNormalManualControlledOrder_Postfix(
        GuestsManager __instance, GuestGroupController manualControlled, int foodId, int bevId, 
        Il2CppSystem.Action<GuestGroupController.EvaluationResult> onEvaluate, UnityEngine.Sprite hiddenPic)
    {
        Log.LogInfo($"SetNormalManualControlledOrder_Postfix postfix called {manualControlled.GetGuestUUID()}, food {foodId}, bev {bevId}");
    }

    [HarmonyPatch(nameof(GuestsManager.SetSpecialManualControlledOrder))]
    [HarmonyPostfix]
    public static void SetSpecialManualControlledOrder_Postfix(
        GuestsManager __instance, GuestGroupController manualControlled, int foodTag, int bevTag, 
        Il2CppSystem.Action<GuestGroupController.EvaluationResult> onEvaluate, UnityEngine.Sprite hiddenPic)
    {
        Log.LogInfo($"SetSpecialManualControlledOrder_Postfix postfix called {manualControlled.GetGuestUUID()}, food {foodTag}, bev {bevTag}");
    }

    [HarmonyPatch(nameof(GuestsManager.TryCloseIzakaya))]
    [HarmonyPostfix]
    public static void TryCloseIzakaya_Postfix(GuestsManager __instance)
    {
        Log.LogWarning("TryCloseIzakaya called!");
        IzakayaCloseAction.Send();
    }

    [HarmonyPatch(nameof(GuestsManager.TryCloseIzakaya))]
    [HarmonyReversePatch]
    public static void TryCloseIzakaya_Original(GuestsManager __instance)
    {
        throw new System.NotImplementedException();
    }
}

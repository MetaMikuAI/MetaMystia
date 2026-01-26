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
        Log.InfoCaller("called");
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
        if (MpManager.IsConnectedHost)
        {
            bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
            if (IsReimuSpellCardTriggered)
            {
                return;
            }
            _ = WorkSceneManager.StoreGuest(initializedController);
        }
    }


    // [HarmonyPatch(nameof(GuestsManager.PostInitializeGuestGroup))]
    // [HarmonyPrefix]
    // public static bool PostInitializeGuestGroup_Prefix(GuestGroupController initializedController)
    // {
    //     // Log.LogInfo($"PostInitializeGuestGroup_Prefix called");
    //     bool isNormalGuest = !Functional.CheckStacktraceContains("NightScene.GuestManagementUtility.GuestsManager::SpawnSpecialGuestGroup");

    //     // Sync host's guest spawn here because GuestsManager::SpawnNormalGuestGroup/0 does not return guest controller
    //     if (MpManager.IsConnected && !MpManager.InStory)
    //     {
    //         if (MpManager.IsHost)
    //         {
    //             string uuid = WorkSceneManager.StoreGuest(initializedController);
    //             var array = initializedController.GetAllGuests().ToIl2CppReferenceArray();

    //             if (array != null)
    //             {
    //                 if (isNormalGuest)
    //                 {
    //                     var normalGuestVArrayS = DataBaseCharacter.NormalGuestVisual.Get(array[0].id).SortByToString();
    //                     int normalGuestVisual = indexAt(normalGuestVArrayS, array[0].CharacterPixel, 1);
    //                     if (array.Length > 1)
    //                     {
    //                         var normalGuest2VArrayS = DataBaseCharacter.NormalGuestVisual.Get(array[1].id).SortByToString();
    //                         int normalGuest2Visual = indexAt(normalGuest2VArrayS, array[1].CharacterPixel, 2);
    //                         GuestSpawnAction.Send(array[0].id, false, uuid, normalGuestVisual, array[1].id, normalGuest2Visual);
    //                     }
    //                     else
    //                     {
    //                         GuestSpawnAction.Send(array[0].id, false, uuid, normalGuestVisual);
    //                     }
    //                 }
    //                 else
    //                 {
    //                     GuestSpawnAction.Send(array[0].id, true, uuid);
    //                 }
    //             }
    //         }
    //     }
    //     return true;
    // }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [])]
    [HarmonyPrefix]
    public static bool SpawnNormalGuestGroup_Prefix()
    {
        // Log.LogInfo($"SpawnNormalGuestGroup_Prefix called");
        if (!MpManager.ShouldSkipAction)
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

    // [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
    //     typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
    //     typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
    //     typeof(GuestGroupController.LeaveType),
    //     typeof(int),
    //     typeof(bool),
    // ])]
    // [HarmonyReversePatch]
    // public static NormalGuestsController SpawnNormalGuestGroup_WithArg_Original(GuestsManager __instance, Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests, Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition, GuestGroupController.LeaveType leaveType, int targetDeskCode, bool shouldFade)
    // {
    //     throw new System.NotImplementedException();
    // }

    // public unsafe NormalGuestsController SpawnNormalGuestGroup(
    // IEnumerable<NormalGuest> normalGuests,
    // Il2CppSystem.Nullable<Vector3> overrideSpawnPosition = null,
    // GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
    // int targetDeskCode = -1,
    // bool shouldFade = true)

    // [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
    //     typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
    //     typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
    //     typeof(GuestGroupController.LeaveType),
    //     typeof(int),
    //     typeof(bool),
    // ])]
    // [HarmonyPrefix]
    // public static bool SpawnNormalGuestGroup_WithArg_Prefix(
    //     GuestsManager __instance,
    //     Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
    //     ref Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
    //     GuestGroupController.LeaveType leaveType,
    //     int targetDeskCode,
    //     bool shouldFade,
    //     ref NormalGuestsController __result)
    // {
    //     Log.LogInfo($"SpawnNormalGuestGroup_WithArg_Prefix called, overrideSpawnPosition {(overrideSpawnPosition.hasValue? overrideSpawnPosition.Value.ToString() : "null")}");
    //     overrideSpawnPosition ??= new Il2CppSystem.Nullable<UnityEngine.Vector3>();
    //     if (MpManager.IsConnected)
    //     {
    //         if (MpManager.IsClient && !MpManager.InStory)
    //         {
    //             return false;
    //         }
    //         else if (MpManager.IsHost)
    //         {
    //             __result = SpawnNormalGuestGroup_WithArg_Original(__instance, normalGuests, overrideSpawnPosition, leaveType, targetDeskCode, shouldFade);
    //             return false;
    //         }
    //     }
    //     return true;
    // }

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

        if (MpManager.ShouldSkipAction)
        {
            return true;
        }

        bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
        if (IsReimuSpellCardTriggered)
        {
            return true;
        }
        if (MpManager.IsClient)
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

        // 通过FSM转移状态
        var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
        fsm.ChangeState(WorkSceneManager.Status.Generated);

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
        if (!MpManager.ShouldSkipAction)
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

                bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
                if (IsReimuSpellCardTriggered)
                {
                    return true;
                }

                var guuid = WorkSceneManager.GetGuestUUID(toTry);
                int copiedTargetDeskCode = targetDeskCode;

                WorkSceneManager.SetGuestDeskcodeSeat(guuid, seatRand);
                WorkSceneManager.SetGuestDeskcode(guuid, copiedTargetDeskCode);
                // Delay send seated action because SpawnNormalGuestGroup may execute TrySendToSeat first then return
                CommandScheduler.Enqueue(
                    executeWhen: () => WorkSceneManager.CheckStatus(guuid, WorkSceneManager.Status.Generated),
                    executeInfo: $"TrySendToSeat: waiting {guuid} generated",
                    execute: () =>
                    {
                        // 通过FSM转移到Seated状态
                        var fsm = WorkSceneManager.GetGuestFSM(guuid);
                        fsm.TrySeated();
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
        if (!MpManager.ShouldSkipAction)
        {
            bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
            if (IsReimuSpellCardTriggered)
            {
                return true;
            }

            var uuid = WorkSceneManager.GetGuestUUID(toLeave);
            if (uuid == null) return true;

            var fsm = WorkSceneManager.GetGuestFSM(uuid);
            Log.InfoCaller($"{fsm.Identifier} leaving");

            if (WorkSceneManager.IsGuestNull(toLeave))
            {
                Log.ErrorCaller($"{fsm.Identifier} toLeave or its component is null, will stop executing LeaveFromDesk");
                return false;
            }

            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                if (WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left))
                {
                    return true;
                }
                WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.LeaveFromDesk);
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
        if (!MpManager.ShouldSkipAction)
        {
            var uuid = toPayAndLeave.GetGuestUUID();
            if (uuid == null) return true;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
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
        if (!MpManager.ShouldSkipAction)
        {
            var uuid = toExBadLeave.GetGuestUUID();
            if (uuid == null) return true;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            if (MpManager.IsClient)
            {
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
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
        if (!MpManager.ShouldSkipAction)
        {
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
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
        if (!MpManager.ShouldSkipAction)
        {
            bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
            if (IsReimuSpellCardTriggered)
            {
                return true;
            }
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
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
        if (!MpManager.ShouldSkipAction)
        {
            var toRepell = __instance.GetInDeskGuest(deskCode);
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return true;

            var fsm = uuid.GetGuestFSM();
            Log.InfoCaller($"{fsm?.Identifier}");
            fsm?.TryLeave();
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PlayerRepel);

            if (WorkSceneManager.IsGuestNull(toRepell))
            {
                Log.ErrorCaller($"{fsm?.Identifier} is null, will stop executing PlayerRepell");
                fsm?.RemoveInvalidGuest(deskCode);
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
        if (!MpManager.ShouldSkipAction)
        {
            var uuid = toPatientDepletedLeave.GetGuestUUID();
            if (uuid == null) return true;

            if (MpManager.IsClient)
            {
                Log.DebugCaller($"{uuid.GetGuestFSM()?.Identifier}");
                return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
            }
            else
            {
                Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
                WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PatientDepletedLeave);
            }
        }
        return true;
    }


    [HarmonyPatch(nameof(GuestsManager.PayByMood))]
    [HarmonyPrefix]
    public static void PayByMood_Prefix(GuestsManager __instance, GuestGroupController toPayAndLeave)
    {
        if (MpManager.IsConnected && !MpManager.InStory)
        {
            Log.InfoCaller($"{toPayAndLeave?.GetGuestFSM()?.Identifier}");
        }
    }

    [HarmonyPatch(nameof(GuestsManager.GuestPay))]
    [HarmonyPrefix]
    public static bool GuestPay_Prefix(GuestsManager __instance, GuestGroupController toPayAndLeave, bool includeTip)
    {
        Log.InfoCaller($"called for {toPayAndLeave.GetGuestFSM(LogError: false)?.Identifier}");
        if (MpManager.IsConnectedHost && !MpManager.InStory)
        {
            var uuid = toPayAndLeave.GetGuestUUID();
            if (uuid == null) return true;
            // NightScene_GuestManagementUtility_GuestsManager__GenerateOrderSession
            // Stacktrace: GenerateOrderSession -> GuestPay(here) -> LeaveFromDesk
            if (Functional.CheckStacktraceContains("GenerateOrderSession"))
            {
                WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PayAndLeave);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.Eval))]
    [HarmonyPrefix]
    public static bool Eval_Prefix(GuestsManager __instance, int firstMood, int moon, float delay, int amount, bool shouldAddCombo, GuestGroupController toEvaluate)
    {
        Log.InfoCaller($"for {toEvaluate.GetGuestFSM(LogError: false)?.Identifier}, firstMood {firstMood}, moon {moon}, delay {delay}, amount {amount}, shouldAddCombo {shouldAddCombo}");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.EvaluateOrder))]
    [HarmonyPostfix]
    public static void EvaluateOrder_Postfix(GuestsManager __instance, GuestGroupController toEvaluate, bool isTriggerByPartner)
    {
        Log.InfoCaller($"for {toEvaluate.GetGuestFSM(LogError: false)?.Identifier}");
        if (!MpManager.ShouldSkipAction)
        {
            var fsm = toEvaluate.GetGuestFSM();
            fsm?.ResetOrderServed();
            fsm?.TryServeOrder();
        }
    }

    [HarmonyPatch(nameof(GuestsManager.RemoveFromOrder))]
    [HarmonyPrefix]
    public static void RemoveFromOrder_Prefix(GuestsManager __instance, GuestsManager.OrderBase order)
    {
        Log.InfoCaller($"guest {WorkSceneManager.GetInDeskGuest(order.DeskCode)?.GetGuestFSM(LogError: false).Identifier} food {order.foodRequest}, bev {order.beverageRequest}");
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
        if (MpManager.IsConnected && !MpManager.InStory)
        {
            var uuid = WorkSceneManager.GetGuestUUID(guestGroup);
            if (uuid == null) return true;
            WorkSceneManager.GetGuestFSM(uuid)?.TryPendingOrder();

            if (MpManager.IsClient)
            {
                Log.LogInfo($"GenerateOrderSession prevented for {uuid.GetGuestFSM()?.Identifier}");
                return false;
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.GenerateOrderSession))]
    [HarmonyPostfix]
    public static void GenerateOrderSession_Postfix(GuestsManager __instance, GuestGroupController guestGroup)
    {
        if (MpManager.IsConnectedHost && !MpManager.InStory)
        {
            Log.InfoCaller($"for {guestGroup.GetGuestFSM()?.Identifier}");
            WorkSceneManager.DelayedSafeAddMaxPatient(guestGroup);
        }
    }

    [HarmonyPatch(nameof(GuestsManager.SetNormalManualControlledOrder))]
    [HarmonyPostfix]
    public static void SetNormalManualControlledOrder_Postfix(
        GuestsManager __instance, GuestGroupController manualControlled, int foodId, int bevId,
        Il2CppSystem.Action<GuestGroupController.EvaluationResult> onEvaluate, UnityEngine.Sprite hiddenPic)
    {
        Log.InfoCaller($"{manualControlled.GetConnectedGuestUUID()}, food {foodId}, bev {bevId}");
    }

    [HarmonyPatch(nameof(GuestsManager.SetSpecialManualControlledOrder))]
    [HarmonyPostfix]
    public static void SetSpecialManualControlledOrder_Postfix(
        GuestsManager __instance, GuestGroupController manualControlled, int foodTag, int bevTag,
        Il2CppSystem.Action<GuestGroupController.EvaluationResult> onEvaluate, UnityEngine.Sprite hiddenPic)
    {
        Log.InfoCaller($"{manualControlled.GetConnectedGuestUUID()}, food {foodTag}, bev {bevTag}");
    }

    [HarmonyPatch(nameof(GuestsManager.TryCloseIzakaya))]
    [HarmonyPostfix]
    public static void TryCloseIzakaya_Postfix(GuestsManager __instance)
    {
        Log.Message("TryCloseIzakaya called!");
        IzakayaCloseAction.Send();
    }

    [HarmonyPatch(nameof(GuestsManager.TryCloseIzakaya))]
    [HarmonyReversePatch]
    public static void TryCloseIzakaya_Original(GuestsManager __instance)
    {
        throw new System.NotImplementedException();
    }
}

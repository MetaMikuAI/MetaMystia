using HarmonyLib;
using Il2CppSystem.IO;
using System.Linq;

using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;

using DEYU.Utils;
using MetaMystia.Network;
using SgrYuki;
using SgrYuki.Utils;

using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))]
[AutoLog]
public partial class GuestsManagerPatch
{
    public static volatile bool SpawnNormalGuestGroup_WithArg_Manual_Call = false;

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
        if (MpManager.ShouldSkipAction) { if (MpManager.IsConnectedClient) return SkipOriginal; return RunOriginal; }
        if (MpManager.IsClient) return SkipOriginal;

        var cook = NightScene.CookingUtility.CookSystemManager.Instance;
        while (true)
        {
            var guestGroups = cook?.GetRandomNormalGuestGroups();
            if (guestGroups == null)
            {
                Log.LogError($"CookSystemManager failed to GetRandomNormalGuestGroups!");
                return RunOriginal;
            }
            var arr = guestGroups.ToArray();
            if (arr.All((guest) => PlayerManager.NormalGuestAvailable(guest.id)))
            {
                _ = SpawnNormalGuestGroup_WithArg_Original(
                            GuestsManager.instance, guestGroups, new Il2CppSystem.Nullable<UnityEngine.Vector3>(), GuestGroupController.LeaveType.Move, -1, true);
                return SkipOriginal;
            }
        }
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyReversePatch]
    public static NormalGuestsController SpawnNormalGuestGroup_WithArg_Original(
        GuestsManager __instance,
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
        GuestGroupController.LeaveType leaveType,
        int targetDeskCode,
        bool shouldFade)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyPrefix]
    public static bool SpawnNormalGuestGroup_WithArg_Prefix(
        ref Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition)
    {
        overrideSpawnPosition ??= new Il2CppSystem.Nullable<UnityEngine.Vector3>();
        Log.DebugCaller($"called");
        if (!SpawnNormalGuestGroup_WithArg_Manual_Call
            && MpManager.IsConnectedClient && !MpManager.InStory)
        {
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyPostfix]
    public static void SpawnNormalGuestGroup_WithArg_Postfix(
        NormalGuestsController __result,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition,
        GuestGroupController.LeaveType leaveType)
    {
        if (__result == null)
        {
            Log.WarningCaller($"failed to SpawnNormalGuestGroup, skip");
            return;
        }

        if (MpManager.ShouldSkipAction || !MpManager.IsConnectedHost) return;

        var guestGroupControllerCvt = __result;
        // uuid stored in PostInitializeGuestGroup_Prefix
        string uuid = WorkSceneManager.GetGuestUUID(guestGroupControllerCvt);
        var array = guestGroupControllerCvt.GetAllGuests().ToIl2CppReferenceArray();

        var guestVisualArray = DataBaseCharacter.NormalGuestVisual.Get(array[0].id).SortByToString();
        int visualId1 = guestVisualArray.IndexAtByToString(array[0].CharacterPixel);
        Log.InfoCaller($"{uuid} visualId1 found at {visualId1} => {guestVisualArray[visualId1].ToString()}");

        var info = new WorkSceneManager.GuestInfo
        {
            Id = array[0].id,
            VisualId = visualId1,
            IsSpecial = false,
            LeaveType = leaveType
        };
        if (overrideSpawnPosition.HasValue && overrideSpawnPosition.Value.sqrMagnitude > 0.25f * 0.25f * 3 && overrideSpawnPosition.Value.sqrMagnitude < 15 * 15 * 3)
        {
            info.OverrideSpawnPosition = overrideSpawnPosition.Value;
            Log.InfoCaller($"overrideSpawnPositionCvt, {overrideSpawnPosition.Value}");
        }
        if (array.Length > 1)
        {
            var guestVisualArray2 = DataBaseCharacter.NormalGuestVisual.Get(array[1].id).SortByToString();
            int visualId2 = guestVisualArray2.IndexAtByToString(array[1].CharacterPixel);
            Log.InfoCaller($"{uuid} visualId2 found at {visualId2} => {guestVisualArray2[visualId2].ToString()}");

            info.Id2 = array[1].id;
            info.VisualId2 = visualId2;
        }
        GuestSpawnAction.Send(uuid, info);

        var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
        fsm.ChangeState(WorkSceneManager.Status.Generated);
    }

    public static NormalGuestsController SpawnNormalGuestGroup_Original(
        GuestsManager __instance,
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests,
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = null,
        GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move,
        int targetDeskCode = -1,
        bool shouldFade = true)
    {
        SpawnNormalGuestGroup_WithArg_Manual_Call = true;
        var res = SpawnNormalGuestGroup_WithArg_Original(__instance, normalGuests, overrideSpawnPosition ?? new Il2CppSystem.Nullable<UnityEngine.Vector3>(), leaveType, targetDeskCode, shouldFade);
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
        ref int id,
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

        if (MpManager.ShouldSkipAction) { if (MpManager.IsConnectedClient) return SkipOriginal; return RunOriginal; }

        bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
        if (IsReimuSpellCardTriggered) return RunOriginal;

        if (!MpManager.IsConnectedHost) return SkipOriginal;

        if (!PlayerManager.SpecialGuestAvailable(id))
        {
            var newId = WorkSceneManager.GetRandomSpecialGuestIdFromThisIzakaya();
            if (newId == -1)
            {
                Log.WarningCaller($"id {id} is not available for peer, and no more available guests tonight, will not generate");
                return SkipOriginal;
            }
            Log.WarningCaller($"id {id} is not available for peer, use new {newId}");
            id = newId;
        }
        __result = SpawnSpecialGuestGroup_Original(__instance, id, guestSpawnType, overrideSpawnPosition, onGuestLeave, leaveType, recordIzakaya, targetDeskCode, tryToJumpQueue, postProcessCharacterCallback, shouldFade);
        if (__result != null)
        {
            NightScene.EventUtility.EventManager.Instance?.SetTargetGuestHasSpawnedHandle?.Invoke(id);
        }
        var info = new WorkSceneManager.GuestInfo
        {
            Id = id,
            IsSpecial = true,
            LeaveType = leaveType,
            OverrideSpawnPosition = overrideSpawnPosition.GetValueOrDefault()
        };
        // should be stored in PostInitializeGuestGroup_Prefix, which will be called by SpawnSpecialGuestGroup_Original
        var uuid = WorkSceneManager.GetGuestUUID(__result);
        if (uuid == null) return SkipOriginal;
        GuestSpawnAction.Send(uuid, info);

        var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
        fsm.ChangeState(WorkSceneManager.Status.Generated);

        return SkipOriginal;
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
                return SkipOriginal;
            }
            else
            {
                var seatableDeskCodes = __instance.TrueAvailableDesks.FilterKey(value => value >= toTry.GuestCount);
                if (seatableDeskCodes.Count == 0) return SkipOriginal;
                targetDeskCode = seatableDeskCodes.GetRandomOne();

                var seatRand = UnityEngine.Random.Range(0, 2);

                bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
                if (IsReimuSpellCardTriggered)
                {
                    return RunOriginal;
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
                Log.DebugCaller($"desk code {targetDeskCode}, seat {seatRand}");

            }
        }
        return RunOriginal;
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
        if (MpManager.ShouldSkipAction) { if (MpManager.IsConnectedClient) return SkipOriginal; return RunOriginal; }

        bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
        if (IsReimuSpellCardTriggered) return RunOriginal;

        var uuid = WorkSceneManager.GetGuestUUID(toLeave);
        if (uuid == null) return RunOriginal;

        var fsm = WorkSceneManager.GetGuestFSM(uuid);
        Log.InfoCaller($"{fsm.Identifier} try leaving");

        if (WorkSceneManager.IsGuestNull(toLeave))
        {
            Log.ErrorCaller($"{fsm.Identifier} toLeave or its component is null, will stop executing LeaveFromDesk");
            return SkipOriginal;
        }

        if (MpManager.IsClient)
        {
            return WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left);
        }
        else
        {
            if (WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left))
            {
                return RunOriginal;
            }
            WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.LeaveFromDesk);
        }

        return RunOriginal;
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
            if (uuid == null) return RunOriginal;

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
        return RunOriginal;
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
            if (uuid == null) return RunOriginal;

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
        return RunOriginal;
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
            if (MpManager.IsConnectedClient && GuestsManager.instance?.isIzakayaClosing == true)
            {
                Log.DebugCaller("Client in close sequence, skipping network action");
                return RunOriginal;
            }
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return RunOriginal;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.RepelAndLeavePay);
        }
        return RunOriginal;
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
            if (MpManager.IsConnectedClient && GuestsManager.instance?.isIzakayaClosing == true)
            {
                Log.DebugCaller("Client in close sequence, skipping network action");
                return RunOriginal;
            }
            bool IsReimuSpellCardTriggered = Functional.CheckStacktraceContains("InitializeAsGeneralWorkScene");
            if (IsReimuSpellCardTriggered)
            {
                return RunOriginal;
            }
            var uuid = toRepell.GetGuestUUID();
            if (uuid == null) return RunOriginal;

            Log.InfoCaller($"{uuid.GetGuestFSM()?.Identifier}");
            WorkSceneManager.GetGuestFSM(uuid)?.TryLeave();
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.RepelAndLeaveNoPay);
        }
        return RunOriginal;
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
            if (uuid == null) return RunOriginal;

            var fsm = uuid.GetGuestFSM();
            Log.InfoCaller($"{fsm?.Identifier}");
            fsm?.TryLeave();
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PlayerRepel);

            if (WorkSceneManager.IsGuestNull(toRepell))
            {
                Log.ErrorCaller($"{fsm?.Identifier} is null, will stop executing PlayerRepell");
                fsm?.RemoveInvalidGuest(deskCode);
                WorkSceneManager.RemoveOccupiedDesk(deskCode);
                return SkipOriginal;
            }
        }
        return RunOriginal;
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
            if (uuid == null) return RunOriginal;

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
        return RunOriginal;
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
        if (MpManager.ShouldSkipAction) { if (MpManager.IsConnectedClient) return SkipOriginal; return RunOriginal; }
        var uuid = toPayAndLeave.GetGuestUUID();
        if (uuid == null) return RunOriginal;
        var fsm = WorkSceneManager.GetGuestFSM(uuid);

        if (MpManager.IsHost)
        {
            // NightScene_GuestManagementUtility_GuestsManager__GenerateOrderSession
            // Stacktrace: GenerateOrderSession -> GuestPay(here) -> LeaveFromDesk
            if (Functional.CheckStacktraceContains("GenerateOrderSession"))
            {
                fsm?.TryLeave();
                GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.PayAndLeave);
            }
            return RunOriginal;
        }
        else
        {
            if (WorkSceneManager.CheckStatus(uuid, WorkSceneManager.Status.Left))
            {
                Log.InfoCaller($"{fsm?.Identifier} allow to pay");
                return RunOriginal;
            }
            else
            {
                Log.InfoCaller($"{fsm?.Identifier} not allow to pay now");
                return SkipOriginal;
            }
        }
    }

    [HarmonyPatch(nameof(GuestsManager.Eval))]
    [HarmonyPrefix]
    public static bool Eval_Prefix(GuestsManager __instance, int firstMood, int moon, float delay, int amount, bool shouldAddCombo, GuestGroupController toEvaluate)
    {
        Log.InfoCaller($"for {toEvaluate.GetGuestFSM(LogError: false)?.Identifier}, firstMood {firstMood}, moon {moon}, delay {delay}, amount {amount}, shouldAddCombo {shouldAddCombo}");
        return RunOriginal;
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
        if (MpManager.ShouldSkipAction) { if (MpManager.IsConnectedClient) return SkipOriginal; return RunOriginal; }

        var uuid = WorkSceneManager.GetGuestUUID(guestGroup);
        if (uuid == null) return RunOriginal;
        var fsm = uuid.GetGuestFSM();
        fsm?.TryPendingOrder();

        if (MpManager.IsClient)
        {
            Log.InfoCaller($"prevented for {fsm?.Identifier}");
            return SkipOriginal;
        }
        return RunOriginal;
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
    [HarmonyPrefix]
    public static bool TryCloseIzakaya_Prefix()
    {
        if (!MpManager.IsConnected) return RunOriginal;

        if (MpManager.IsConnectedClient)
        {
            if (WorkSceneManager.AllowClientClose)
            {
                Log.Message("Client close allowed by host command");
                return RunOriginal;
            }
            Log.Message("Client attempted to close izakaya, blocked");
            return SkipOriginal;
        }

        if (MpManager.IsConnectedHost)
        {
            IzakayaCloseAction.Broadcast();
            Log.Message("TryCloseIzakaya called, Host broadcast.");
        }

        // 主机：正常执行打烊
        return RunOriginal;
    }

    [HarmonyPatch(nameof(GuestsManager.TryCloseIzakaya))]
    [HarmonyReversePatch]
    public static void TryCloseIzakaya_Original(GuestsManager __instance)
    {
        throw new System.NotImplementedException();
    }
}

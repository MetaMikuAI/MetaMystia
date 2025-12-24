using HarmonyLib;
using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;

namespace MetaMystia;
using SgrYuki.Utils;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))] 
[AutoLog]
public partial class GuestsManagerPatch
{
    // public static readonly System.Threading.AsyncLocal<bool> PassGuestSpawn = new();

    [HarmonyPatch(nameof(GuestsManager.PostInitializeGuestGroup))]
    [HarmonyPrefix]    
    public static bool PostInitializeGuestGroup_Prefix(GuestGroupController initializedController)
    {
        const int PatientSecs = 60;
        // Log.LogInfo($"PostInitializeGuestGroup_Prefix called");
        bool isNormalGuest = FunctionUtil.CheckStacktraceContains("NightScene.GuestManagementUtility.GuestsManager::SpawnNormalGuestGroup");

        // Sync host's guest spawn here because GuestsManager::SpawnNormalGuestGroup/0 does not return guest controller
        if (MpManager.IsConnected)
        {
            if (MpManager.Role == MpManager.ROLE.Host){
                string uuid = NightGuestManager.StoreGuest(initializedController);

                var array = initializedController.GetAllGuests().ToIl2CppReferenceArray();
                if (array != null)
                {
                    if (isNormalGuest)
                    {
                        var profile0 = array[0].OnGetVisual(array[0].id);
                        if (array.Length > 1)
                        {
                            MpManager.SendGuestSpawn(array[0].id, false, uuid, profile0.bgColor, profile0.textColor, array[1].id);
                        }
                        else
                        {
                            MpManager.SendGuestSpawn(array[0].id, false, uuid, profile0.bgColor, profile0.textColor);
                        }
                    }
                    else
                    {
                        MpManager.SendGuestSpawn(array[0].id, true, uuid);
                    }
                }
            }
            initializedController.AddPatient(PatientSecs);
            // initializedController.MaxPatient *= 2;
            // initializedController.CurrentPatient *= 2;
            // Log.LogWarning($"MaxPatient {initializedController.MaxPatient/2} -> {initializedController.MaxPatient}, CurrentPatient {initializedController.CurrentPatient/2} -> {initializedController.CurrentPatient}");
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [])]
    [HarmonyPrefix]    
    public static bool SpawnNormalGuestGroup_Prefix()
    {
        // Log.LogInfo($"SpawnNormalGuestGroup_Prefix called");
        return !MpManager.IsConnectedClient;
    }


    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [
        typeof(Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>),
        typeof(Il2CppSystem.Nullable<UnityEngine.Vector3>),
        typeof(GuestGroupController.LeaveType),
        typeof(int),
        typeof(bool),
    ])]
    [HarmonyReversePatch]    
    public static NormalGuestsController SpawnNormalGuestGroup_WithArg_Original(GuestsManager __instance, Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests, Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition, GuestGroupController.LeaveType leaveType, int targetDeskCode, bool shouldFade)
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
    public static bool SpawnNormalGuestGroup_WithArg_Prefix(GuestsManager __instance, 
        Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests, 
        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition, 
        GuestGroupController.LeaveType leaveType, 
        int targetDeskCode, 
        bool shouldFade, 
        ref NormalGuestsController __result)
    {   
        Log.LogInfo($"SpawnNormalGuestGroup_WithArg_Prefix called");
        overrideSpawnPosition ??= new Il2CppSystem.Nullable<UnityEngine.Vector3>();
        if (MpManager.IsConnectedClient)
        {
            return false;
        }
        __result = SpawnNormalGuestGroup_WithArg_Original(__instance, normalGuests, overrideSpawnPosition, leaveType, targetDeskCode, shouldFade);
        return false;
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
        if (MpManager.IsConnectedClient)
        {
            return false;
        }
        __result = SpawnSpecialGuestGroup_Original(__instance, id, guestSpawnType, overrideSpawnPosition, onGuestLeave, leaveType, recordIzakaya, targetDeskCode, tryToJumpQueue, postProcessCharacterCallback, shouldFade);
        return false;
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyReversePatch]    
    public static NormalGuestsController TrySendToSeat_Original(object __instance, GuestGroupController toTry, bool firstSpawn, int targetDeskCode, bool shouldOrder)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(GuestsManager.TrySendToSeat))]
    [HarmonyPrefix]    
    public static bool TrySendToSeat_Prefix(GuestsManager __instance, GuestGroupController toTry, bool firstSpawn, ref int targetDeskCode, bool shouldOrder)
    {
        if (MpManager.IsConnected)
        {
            if(MpManager.Role == MpManager.ROLE.Client)
            {
                Log.LogDebug($"TrySendToSeat prevented");
                return false;
            }
            else
            {
                var seatableDeskCodes = __instance.TrueAvailableDesks.FilterKey(value => value >= toTry.GuestCount);
                if (seatableDeskCodes.Count == 0) return false;
                targetDeskCode = seatableDeskCodes.GetRandomOne();
                Log.LogDebug($"TrySendToSeat_Prefix called, desk code modified to = {targetDeskCode}");

                var guuid = NightGuestManager.GetGuestUUID(toTry);
                NightGuestManager.SetGuestStatus(guuid, NightGuestManager.Status.Seated);
                NightGuestManager.SetGuestDeskcode(guuid, targetDeskCode);
                MpManager.SendGuestSeated(NightGuestManager.GetGuestUUID(toTry), targetDeskCode, firstSpawn);
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
        Log.LogInfo($"LeaveFromDesk_Prefix called");
        if (MpManager.IsConnectedClient)
        {
            return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toLeave), NightGuestManager.Status.Left);
        }
        else if (MpManager.IsConnectedHost)
        {
            var uuid = NightGuestManager.GetGuestUUID(toLeave);
            if (NightGuestManager.CheckStatus(uuid, NightGuestManager.Status.Left))
            {
                return true;
            }
            NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(uuid, GuestLeaveAction.LeaveType.Other);
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
        if (MpManager.IsConnectedClient)
        {
            return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
        }
        else if (MpManager.IsConnectedHost)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toPayAndLeave), GuestLeaveAction.LeaveType.PayAndLeave);
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
        if (MpManager.IsConnectedClient)
        {
            return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toExBadLeave), NightGuestManager.Status.Left);
        }
        else if (MpManager.IsConnectedHost)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toExBadLeave), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toExBadLeave), GuestLeaveAction.LeaveType.ExBadLeave);
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
        if (MpManager.IsConnected)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toRepell), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toRepell), GuestLeaveAction.LeaveType.RepellAndLeavePay);
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
        if (MpManager.IsConnected)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toRepell), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toRepell), GuestLeaveAction.LeaveType.RepellAndLeaveNoPay);
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
    public static bool PlayerRepelly_Prefix(GuestsManager __instance, int deskCode)
    {
        Log.LogInfo($"PlayerRepelly_Prefix called");
        if (MpManager.IsConnected)
        {
            var toRepell = GuestsManager.instance.GetInDeskGuest(deskCode);
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toRepell), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toRepell), GuestLeaveAction.LeaveType.PlayerRepell);
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
        if (MpManager.IsConnectedClient)
        {
            return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), NightGuestManager.Status.Left);
        }
        else if (MpManager.IsConnectedHost)
        {
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), NightGuestManager.Status.Left);
            MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), GuestLeaveAction.LeaveType.PatientDepletedLeave);
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
        if (MpManager.IsConnectedHost)
        {
            // NightScene_GuestManagementUtility_GuestsManager__GenerateOrderSession
            if (FunctionUtil.CheckStacktraceContains("GenerateOrderSession"))
            {
                NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
                MpManager.SendGuestLeave(NightGuestManager.GetGuestUUID(toPayAndLeave), GuestLeaveAction.LeaveType.PayAndLeave);
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
        Log.LogInfo($"EvaluateOrder_Postfix called");
        var uuid = NightGuestManager.GetGuestUUID(toEvaluate);
        NightGuestManager.ResetGuestOrderServed(uuid);
        NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.OrderEvaluated);
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
        
        // Log.LogInfo($"GenerateOrderSession called");
        if (MpManager.IsConnectedClient)
        {
            Log.LogInfo($"GenerateOrderSession prevented");
            var uuid = NightGuestManager.GetGuestUUID(guestGroup);
            if (NightGuestManager.CheckStatusIn(uuid, [NightGuestManager.Status.Seated, NightGuestManager.Status.OrderEvaluated]))
            {
                NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.PendingOrder);
            }
            return false;
        }
        return true;
    }
}

[HarmonyPatch(typeof(Common.TimelineExtestion.GameTimeManager))]
[AutoLog]
public partial class GameTimeManagerPatch
{
    [HarmonyPatch(nameof(Common.TimelineExtestion.GameTimeManager.SetGameTimeMode))]
    [HarmonyPrefix]
    public static void SetGameTimeModePatch(Common.TimelineExtestion.GameTimeManager __instance, ref Common.TimelineExtestion.GameTimeManager.TimeMode mode)
    {
        mode = Common.TimelineExtestion.GameTimeManager.TimeMode.Resume;
    }
}
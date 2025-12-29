using System.Linq;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using HarmonyLib;
using Il2CppSystem.IO;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))] 
[AutoLog]
public partial class GuestsManagerPatch
{
    // public static readonly System.Threading.AsyncLocal<bool> PassGuestSpawn = new();

    [HarmonyPatch(nameof(GuestsManager.PostInitializeGuestGroup))]
    [HarmonyPrefix]    
    public static bool PostInitializeGuestGroup_Prefix(GuestGroupController initializedController)
    {
        // Log.LogInfo($"PostInitializeGuestGroup_Prefix called");
        bool isNormalGuest = FunctionUtil.CheckStacktraceContains("NightScene.GuestManagementUtility.GuestsManager::SpawnNormalGuestGroup");

        // Sync host's guest spawn here because GuestsManager::SpawnNormalGuestGroup/0 does not return guest controller
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if (MpManager.IsHost){
                string uuid = NightGuestManager.StoreGuest(initializedController);

                var array = initializedController.GetAllGuests().ToIl2CppReferenceArray();
                if (array != null)
                {
                    if (isNormalGuest)
                    {
                        // var profile0 = array[0].OnGetVisual(array[0].id);
                        int normalGuestVisual = 0;
                        var normalGuestVArrayS = DataBaseCharacter.NormalGuestVisual.Get(array[0].id);
                        // Log.LogMessage(normalGuestVArrayS.DumpElements("\n"));
                        var normalGuestVisualString = array[0].CharacterPixel.ToString();
                        for (int i = 0;i<normalGuestVArrayS.Length;i++)
                        {
                            if(normalGuestVisualString.Equals(normalGuestVArrayS[i].ToString()))
                            {
                                normalGuestVisual = i;
                                Log.LogMessage($"{uuid} found 1 at {i}, {normalGuestVisualString} => {normalGuestVArrayS[i].ToString()}");
                                break;
                            }
                        }
                        
                        if (array.Length > 1)
                        {
                            int normalGuest2Visual = 0;
                            var normalGuest2VArrayS = DataBaseCharacter.NormalGuestVisual.Get(array[1].id);
                            var normalGuest2VisualString = array[1].CharacterPixel.ToString();
                            for (int i = 0;i<normalGuest2VArrayS.Length;i++)
                            {
                                if(normalGuest2VisualString.Equals(normalGuest2VArrayS[i].ToString()))
                                {
                                    normalGuest2Visual = i; 
                                    Log.LogMessage($"{uuid} found 2 at {i} {normalGuest2VisualString} => {normalGuest2VArrayS[i].ToString()}");
                                    break;
                                }
                            }
                            GuestSpawnAction.Send(array[0].id, false, uuid, normalGuestVisual, array[1].id, normalGuest2Visual);
                        }
                        else
                        {
                            GuestSpawnAction.Send(array[0].id, false, uuid, normalGuestVisual);
                        }
                    }
                    else
                    {
                        GuestSpawnAction.Send(array[0].id, true, uuid);
                    }
                }
            } 
        }
        return true;
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
                        _ = SpawnNormalGuestGroup_WithArg_Original(
                                    GuestsManager.instance, guestGroups, new Il2CppSystem.Nullable<UnityEngine.Vector3>(), GuestGroupController.LeaveType.Move, -1, true);
                        return false;
                    }
                }
            }
        }
        return true;
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
        if (MpManager.IsConnectedClient && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
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

        if (!MpManager.IsConnected || MpManager.InStory)
        {
            return true;
        }

        if (MpManager.IsClient && MpManager.LocalScene == Common.UI.Scene.WorkScene )
        {
            if (FunctionUtil.CheckStacktraceContains("InitializeAsGeneralWorkScene"))
            {
                return true;
            }
            return false;
        }

        if (!DLCManager.PeerSpecialGuestAvailable(id))
        {
            var newId = DLCManager.CoreSpecialGuests.GetRandomOne();
            Log.LogWarning($"id {id} is not available for peer, use new {newId}");
            id = newId;
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
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if(MpManager.IsClient)
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
                var guuid = NightGuestManager.GetGuestUUID(toTry);

                NightGuestManager.SetGuestDeskcodeSeat(guuid, seatRand);
                NightGuestManager.SetGuestDeskcode(guuid, targetDeskCode);
                NightGuestManager.SetGuestStatus(guuid, NightGuestManager.Status.Seated);

                Log.LogDebug($"TrySendToSeat_Prefix called, desk code {targetDeskCode}, seat {seatRand}");

                GuestSeatedAction.Send(NightGuestManager.GetGuestUUID(toTry), targetDeskCode, firstSpawn, seatRand);
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
        if (MpManager.IsConnected && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            if (MpManager.IsClient)
            {
                if (toLeave == null || toLeave.guestInstances == null)
                {
                    Log.LogError($"toleave null {toLeave != null}, toLeave.guestInstances {toLeave?.guestInstances != null}, will stop executing LeaveFromDesk");
                    return false;
                }
                return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toLeave), NightGuestManager.Status.Left);
            }
            else
            {
                var uuid = NightGuestManager.GetGuestUUID(toLeave);
                if (NightGuestManager.CheckStatus(uuid, NightGuestManager.Status.Left))
                {
                    return true;
                }
                NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.Left);
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
            if (MpManager.IsClient)
            {
                return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
            }
            else
            {
                NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
                GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toPayAndLeave), GuestLeaveAction.LeaveType.PayAndLeave);
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
            if (MpManager.IsClient)
            {
                return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toExBadLeave), NightGuestManager.Status.Left);
            }
            else
            {
                NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toExBadLeave), NightGuestManager.Status.Left);
                GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toExBadLeave), GuestLeaveAction.LeaveType.ExBadLeave);
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
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toRepell), NightGuestManager.Status.Left);
            GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toRepell), GuestLeaveAction.LeaveType.RepellAndLeavePay);
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
            var uuid = NightGuestManager.GetGuestUUID(toRepell);
            if (uuid == null)
            {
                return true;
            }
            NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.Left);
            GuestLeaveAction.Send(uuid, GuestLeaveAction.LeaveType.RepellAndLeaveNoPay);
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
            var toRepell = GuestsManager.instance.GetInDeskGuest(deskCode);
            NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toRepell), NightGuestManager.Status.Left);
            GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toRepell), GuestLeaveAction.LeaveType.PlayerRepell);

            if (__instance == null || __instance?.GetInDeskGuest(deskCode) == null)
            {
                Log.LogError($"__instance null {__instance != null}, GetInDeskGuest null {__instance?.GetInDeskGuest(deskCode) != null}, will stop executing PlayerRepell");
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
            if (MpManager.IsClient)
            {
                return NightGuestManager.CheckStatus(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), NightGuestManager.Status.Left);
            }
            else
            {
                NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), NightGuestManager.Status.Left);
                GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toPatientDepletedLeave), GuestLeaveAction.LeaveType.PatientDepletedLeave);
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
            // NightScene_GuestManagementUtility_GuestsManager__GenerateOrderSession
            if (FunctionUtil.CheckStacktraceContains("GenerateOrderSession"))
            {
                NightGuestManager.SetGuestStatus(NightGuestManager.GetGuestUUID(toPayAndLeave), NightGuestManager.Status.Left);
                GuestLeaveAction.Send(NightGuestManager.GetGuestUUID(toPayAndLeave), GuestLeaveAction.LeaveType.PayAndLeave);
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
        Log.LogDebug($"EvaluateOrder_Postfix called");
        if (MpManager.IsConnected && !MpManager.InStory)
        {
            var uuid = NightGuestManager.GetGuestUUID(toEvaluate);
            NightGuestManager.ResetGuestOrderServed(uuid);
            NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.OrderEvaluated);
        }
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
        if (MpManager.IsConnectedClient && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            Log.LogDebug($"GenerateOrderSession prevented");
            var uuid = NightGuestManager.GetGuestUUID(guestGroup);
            if (NightGuestManager.CheckStatusIn(uuid, [NightGuestManager.Status.Seated, NightGuestManager.Status.OrderEvaluated]))
            {
                NightGuestManager.SetGuestStatus(uuid, NightGuestManager.Status.PendingOrder);
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
            const int PatientSecs = 30;
            guestGroup.SetPatient(System.Math.Min(guestGroup.CurrentPatient + PatientSecs, guestGroup.MaxPatient));

        }
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

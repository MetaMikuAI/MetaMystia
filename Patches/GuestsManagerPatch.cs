using HarmonyLib;
using GameData.Core.Collections.NightSceneUtility;
using NightScene.GuestManagementUtility;

using MetaMystia;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))] 
public class GuestsManagerPatch : PatchBase<GuestsManagerPatch>
{
    public static readonly System.Threading.AsyncLocal<string> GuestSpawnUUID = new();


    [HarmonyPatch(nameof(GuestsManager.PostInitializeGuestGroup))]
    [HarmonyPrefix]    
    public static bool PostInitializeGuestGroup_Prefix(object __instance, GuestGroupController initializedController)
    {
        bool isNormalGuest = Utils.CheckStacktraceContains("NightScene.GuestManagementUtility.GuestsManager::SpawnNormalGuestGroup");

        if(MpManager.IsConnected)
        {
            if(MpManager.Role == MpManager.ROLE.Client)
            {
                if (string.IsNullOrEmpty(GuestSpawnUUID.Value))
                {
                    //Log.LogInfo($"{LOG_TAG} PostInitializeGuestGroup_Prefix prevented");  
                    return false;
                } 
                else
                {
                    GuestManager.StoreGuest(initializedController, GuestSpawnUUID.Value);
                    Log.LogInfo($"{LOG_TAG} PostInitializeGuestGroup_Prefix passed");   
                    return true;
                }
            } 
            else
            {
                string uuid = GuestManager.StoreGuest(initializedController);
                var array = initializedController.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
                if (array != null)
                {
                    // discard the second guest(if any)
                    if (isNormalGuest)
                    {
                        MpManager.SendGuestSpawn(array[0].id, false, uuid);
                    }
                    else
                    {
                        MpManager.SendGuestSpawn(array[0].id, true, uuid);
                    }
                    // foreach (var guest in array)
                    // {
                    //     if (isNormalGuest)
                    //     {
                    //         MpManager.SendGuestSpawn(guest.id, false, uuid);
                    //     } 
                    //     else
                    //     {
                    //         MpManager.SendGuestSpawn(guest.id, true, uuid);
                    //     }
                    // }
                }
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.SpawnNormalGuestGroup), [])]
    [HarmonyPrefix]    
    public static bool SpawnNormalGuestGroup_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} SpawnNormalGuestGroup_Prefix called\n");
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
    public static bool SpawnNormalGuestGroup_WithArg_Prefix(GuestsManager __instance, Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest> normalGuests, Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition, GuestGroupController.LeaveType leaveType, int targetDeskCode, bool shouldFade, ref NormalGuestsController __result)
    {   
        if(overrideSpawnPosition == null)
        {
            Log.LogInfo($"{LOG_TAG} SpawnNormalGuestGroup_WithArg_Prefix overrideSpawnPosition is null");
            overrideSpawnPosition = new Il2CppSystem.Nullable<UnityEngine.Vector3>();
        }
        __result = SpawnNormalGuestGroup_WithArg_Original(__instance, normalGuests, overrideSpawnPosition, leaveType, targetDeskCode, shouldFade);
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
        Log.LogInfo($"{LOG_TAG} TrySendToSeat_Prefix called, desk code = {toTry.DeskCode}, targetDeskCode = {targetDeskCode}");

        if(MpManager.IsConnected)
        {
            if(MpManager.Role == MpManager.ROLE.Client)
            {
                //Log.LogInfo($"{LOG_TAG} TrySendToSeat_Prefix prevented");  
                return false;
            }
            else
            {
                var seatableDeskCodes = new System.Collections.Generic.List<int>();
                var e = __instance.TrueAvailableDesks.GetEnumerator();
                while (e.MoveNext())
                {
                    var kv = e.Current;
                    if (kv.Value >= toTry.GuestCount)
                        seatableDeskCodes.Add(kv.Key);
                }
                if (seatableDeskCodes.Count == 0) return false;
                targetDeskCode = seatableDeskCodes[UnityEngine.Random.Range(0, seatableDeskCodes.Count)];
                Log.LogInfo($"{LOG_TAG} TrySendToSeat_Prefix called, desk code modified to = {targetDeskCode}");

                MpManager.SendGuestSeated(GuestManager.GetGuestUUID(toTry), targetDeskCode, firstSpawn);
            }
        }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.LeaveFromDesk))]
    [HarmonyPrefix]    
    public static bool LeaveFromDesk_Prefix(GuestsManager __instance, GuestGroupController toLeave)
    {
        Log.LogInfo($"{LOG_TAG} LeaveFromDesk_Prefix called");

        // if(MpManager.IsConnected)
        // {
        //     if(MpManager.Role == MpManager.ROLE.Host)
        //     {
        //         MpManager.SendGuestSeated(GuestManager.GetGuestUUID(toTry), targetDeskCode, firstSpawn);
        //     }
        // }
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PayAndLeave))]
    [HarmonyPrefix]    
    public static bool PayAndLeave_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} PayAndLeave_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.ExBadLeave))]
    [HarmonyPrefix]    
    public static bool ExBadLeave_Prefix(GuestsManager __instance)
    {   
        Log.LogInfo($"{LOG_TAG} ExBadLeave_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeavePay))]
    [HarmonyPrefix]    
    public static bool RepellAndLeavePay_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} RepellAndLeavePay_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.RepellAndLeaveNoPay))]
    [HarmonyPrefix]    
    public static bool RepellAndLeaveNoPay_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} RepellAndLeaveNoPay_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PatientDepletedLeave))]
    [HarmonyPrefix]    
    public static bool PatientDepletedLeave_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} PatientDepletedLeave_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.PayByMood))]
    [HarmonyPrefix]    
    public static bool PayByMood_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} PayByMood_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.GuestPay))]
    [HarmonyPrefix]    
    public static bool GuestPay_Prefix(GuestsManager __instance)
    {
        Log.LogInfo($"{LOG_TAG} GuestPay_Prefix called\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.Eval))]
    [HarmonyPrefix]    
    public static bool Eval_Prefix(GuestsManager __instance, int firstMood, int moon, float delay, int amount, bool shouldAddCombo)
    {
        Log.LogInfo($"{LOG_TAG} Eval_Prefix called firstMood {firstMood}, moon {moon}, delay {delay}, amount {amount}, shouldAddCombo {shouldAddCombo}\n");
        return true;
    }

    [HarmonyPatch(nameof(GuestsManager.EvaluateOrder))]
    [HarmonyPrefix]    
    public static bool EvaluateOrder_Prefix(GuestsManager __instance, GuestGroupController toEvaluate, bool isTriggerByPartner)
    {
        Log.LogInfo(System.Environment.StackTrace);
        return true;
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
        
        Log.LogInfo($"{LOG_TAG} GenerateOrderSession called\n");
        if (MpManager.IsConnected)
        {
            if (MpManager.Role == MpManager.ROLE.Client)
            {
                Log.LogInfo($"{LOG_TAG} GenerateOrderSession prevented\n");
                return false;
            }
        }
        return true;
    }



    // [HarmonyPatch(nameof(GuestsManager.Register))]
    // [HarmonyReversePatch]    
    // public static void Register_Original(object __instance, Il2CppSystem.Collections.Generic.Dictionary<int, GuestGroupController> collection, GuestGroupController data)
    // {
    //     throw new System.NotImplementedException();
    // }

    // static Il2CppSystem.Collections.Generic.Dictionary<int, GuestGroupController> collection = new();
    // public static void Register_Original_Wrapper(GuestGroupController data)
    // {
    //     Log.LogInfo($"{LOG_TAG} Register_Original called, desk code = {data.DeskCode}");
    //     Register_Original(GuestsManager.instance, collection, data);
    // }

    // [HarmonyPatch(nameof(GuestsManager.Register))]
    // [HarmonyPrefix]    
    // public static bool Register_Prefix(object __instance, Il2CppSystem.Collections.Generic.Dictionary<int, GuestGroupController> collection, ref GuestGroupController data)
    // {
    //     Log.LogInfo($"{LOG_TAG} Register_Prefix called, desk code = {data.DeskCode}");

    //     if(MpManager.IsConnected)
    //     {
    //         if(MpManager.Role == MpManager.ROLE.Host)
    //         {
    //             MpManager.SendGuestSeated(GuestManager.GetGuestUUID(data), data.DeskCode, true);
    //         } 
    //         else
    //         {
    //             return false;
    //         }
    //     }
        
    //     // foreach(var i in collection)
    //     // {
    //     //     ShigureYuki.DiagnosticUtils.LogAllProperties(i);
    //     // }
    //     return true;
    // }

    // [HarmonyPatch(nameof(GuestsManager.SpawnGuest))]
    // [HarmonyPrefix]    
    // public static bool SpawnGuest_Prefix(object __instance, ref GuestGroupController toTry)
    // {
    //     Log.LogInfo($"{LOG_TAG} SpawnGuest_Prefix called, desk code = {toTry.DeskCode}");
        
    //     // foreach(var i in collection)
    //     // {
    //     //     ShigureYuki.DiagnosticUtils.LogAllProperties(i);
    //     // }
    //     return true;
    // }
}


[HarmonyPatch]
public class GuestGroupControllerPatch : PatchBase<GuestGroupControllerPatch>
{
    [HarmonyPatch(typeof(GuestsManager.__c__DisplayClass171_0), nameof(GuestsManager.__c__DisplayClass171_0.Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0))]
    [HarmonyPrefix]
    public static void GenerateOrderInternalPrefix(GuestGroupController toGenerate, GuestsManager.OrderBase orderData)
    {
        Log.LogInfo($"{LOG_TAG} GenerateOrderInternalPrefix called, orderData {orderData} \n");
    }


    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPrefix]
    public static bool GenerateOrderPrefix(GuestGroupController __instance, bool isFreeOrder, ref string orderGenerationMessage, ref GuestsManager.OrderBase generatedOrder)
    {
        Log.LogInfo($"{LOG_TAG} GenerateOrderPrefix called");
        if(MpManager.IsConnected)
        {
            if (MpManager.Role == MpManager.ROLE.Client)
            {
                if (GuestManager.orders.TryDequeue(out var item))
                {
                    (generatedOrder, orderGenerationMessage) = item;
                } 
                else
                {
                    Log.LogError($"{LOG_TAG} dequeue failed! ");
                }
                
                return false;
            }
        }
        return true;
    }

    [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.GenerateOrder))]
    [HarmonyPostfix]
    public static void GenerateOrderPostfix(GuestGroupController __instance, bool isFreeOrder, ref string orderGenerationMessage, ref GuestsManager.OrderBase generatedOrder)
    {
        Log.LogInfo($"{LOG_TAG} GenerateOrderPostfix called, isFreeOrder {isFreeOrder}, orderGenerationMessage {orderGenerationMessage}\n");
        if(MpManager.IsConnected)
        {
            if(MpManager.Role == MpManager.ROLE.Host)
            {
                if (generatedOrder.Type == GuestsManager.OrderBase.OrderType.Normal)
                {
                    Log.LogWarning($"{LOG_TAG} orderData NormalOrder");
                    MpManager.SendGuestGenNormalOrder(GuestManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                    
                } 
                else if (generatedOrder.Type == GuestsManager.OrderBase.OrderType.Special)
                {
                    Log.LogWarning($"{LOG_TAG} orderData SpecialOrder");
                    MpManager.SendGuestGenSPOrder(GuestManager.GetGuestUUID(__instance), generatedOrder.foodRequest, generatedOrder.beverageRequest, generatedOrder.DeskCode, generatedOrder.NotShowInUI, generatedOrder.FreeOrder, orderGenerationMessage);
                } 
                else
                {
                    Log.LogError($"{LOG_TAG} orderData wrong type!");
                }
            } 
        }
    }

    // [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.PushToOrder))]
    // [HarmonyReversePatch]    
    // public static void PushToOrder_Original(GuestGroupController __instance, GuestsManager.OrderBase orderData)
    // {
    //     throw new System.NotImplementedException();
    // }

    // [HarmonyPatch(typeof(GuestGroupController), nameof(GuestGroupController.PushToOrder))]
    // [HarmonyPrefix]
    // public static bool PushToOrderPrefix(GuestGroupController __instance, ref GuestsManager.OrderBase orderData)
    // {
    //     Log.LogInfo($"{LOG_TAG} PushToOrderPrefix called \n");
    //     if(MpManager.IsConnected)
    //     {
    //         if(MpManager.Role == MpManager.ROLE.Host)
    //         {
    //             if (orderData is GuestsManager.NormalOrder no)
    //             {
    //                 Log.LogWarning($"{LOG_TAG} orderData NormalOrder");
    //                 MpManager.SendGuestGenNormalOrder(GuestManager.GetGuestUUID(__instance), no.foodRequest, no.beverageRequest, no.DeskCode, no.NotShowInUI, no.FreeOrder);

    //             } 
    //             else if (orderData is GuestsManager.SpecialOrder so)
    //             {
    //                 Log.LogWarning($"{LOG_TAG} orderData SpecialOrder");
    //                 MpManager.SendGuestGenSPOrder(GuestManager.GetGuestUUID(__instance), so.RequestFoodTag, so.RequestBeverageTag, so.DeskCode, so.NotShowInUI, so.FreeOrder);
    //             } 
    //             else
    //             {
    //                 Log.LogError($"{LOG_TAG} orderData wrong type!");
    //             }
    //         } 
    //         else
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
    // }
}
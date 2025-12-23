using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Serialization;
using BepInEx.Logging;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using LibCpp2IL;
using MetaMystia;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;
using static NightScene.GuestManagementUtility.GuestsManager;

public static class NightGuestManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[NightGuestManager.cs]";

    /// <summary>
    /// 1. Host generated a guest, send SendGuestSpawn to client
    ///    Host: Generated
    ///    Client: PendingGenerate -> Generated
    /// 
    /// 2. Client guest trying to seat, prevent (client still in PendingGenerate)
    ///    Client: PendingGenerate
    /// 
    /// 3. Host guest trying to seat, send SendGuestSeated to client
    ///    Both: Generated -> Seated
    /// 
    /// 4. Client guest trying to order, prevent
    ///    Client: Seated(OrderEvaluated) -> PendingOrder
    /// 
    /// 5. Host guest trying to order, send SendGuestGenOrder to client
    ///    Host: Seated -> OrderGenerated
    ///    Client: PendingOrder -> OrderGenerated
    /// 
    /// 6. Any peer trying to serve, send SendGuestServe to peer
    ///    Both: OrderGenerated -> OrderEvaluated
    ///    if more order generated, go back to 4~5
    /// 
    /// 7. Client guest trying to leave, prevent
    /// 
    /// 8. Host guest trying to leave, send SendGuestLeave to client
    ///    Both: Any after Generated -> Left
    ///    
    /// </summary>
    public enum Status
    {
        Null,
        Left,
        PendingGenerate,
        Generated,
        Seated,
        PendingOrder,
        OrderGenerated,
        OrderEvaluated,
    }
    private static ConcurrentDictionary<string, GuestGroupController> guests = new(); 
    private static ConcurrentDictionary<string, Status> guestStatus = new(); 
    private static ConcurrentDictionary<string, int> guestDesks = new(); 

    private static ConcurrentDictionary<IntPtr, string> guestIds = new();
    public static ConcurrentQueue<(OrderBase, string)> orders = new();

    private static ConcurrentHashSet<int> specialGuestsAppeared = new();
    public static ConcurrentDictionary<IntPtr, GuestProfilePair> normalGuestProfile = new(); 

    private static ConcurrentDictionary<string, (bool, bool)> guestOrderFullfilled = new(); 

    
    //private static int getGuestControllerHashCode(GuestGroupController controller) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(controller);

    public static void Clear()
    {
        guests.Clear();
        guestStatus.Clear();
        guestIds.Clear();
        orders.Clear();
        guestDesks.Clear();
        specialGuestsAppeared.Clear();
        normalGuestProfile.Clear();
        guestOrderFullfilled.Clear();
    }

    public static string StoreGuest(GuestGroupController guest)
    {
        string uuid = Guid.NewGuid().ToString();
        guests[uuid] = guest;
        guestIds[guest.Pointer] = uuid;
        Log.LogMessage($"{LOG_TAG} stored pointer {guest.Pointer} => {uuid}");
        return uuid;

    }

    public static void StoreGuest(GuestGroupController guest, string uuid)
    {
        guests[uuid] = guest;
        guestIds[guest.Pointer] = uuid;
        Log.LogMessage($"{LOG_TAG} stored pointer {guest.Pointer} => {uuid}");
    }

    public static string GetGuestUUID(GuestGroupController guest)
    {
        if (guest == null)
        {
            Log.LogError($"{LOG_TAG} guest is null!");
            return "";
        }
        if (guestIds.TryGetValue(guest.Pointer, out var value))
        {
            return value;
        }
        else
        {
            Log.LogError($"{LOG_TAG} pointer {guest.Pointer} not found");
            // ShigureYuki.DiagnosticUtils.LogAllProperties(guest);
            FunctionUtil.LogStacktrace(Log);
            return null;
        }
    }

    public static GuestGroupController GetGuest(string uuid) {
        if (guests.TryGetValue(uuid, out GuestGroupController result))
        {
            return result;
        }
        SetGuestStatus(uuid, Status.Null);
        return null;
    }
    private static Status GetGuestStatus(string uuid) => guestStatus.GetOrDefault(uuid, Status.Null);

    public static void SetGuestStatus(string uuid, Status value) {
        Log.LogMessage($"{LOG_TAG} {uuid} Desk [{GetGuestDeskcode(uuid)}] status {GetGuestStatus(uuid)} -> {value}");
        guestStatus[uuid] = value;
    }

    private static int GetGuestDeskcode(string uuid) {
        return guestDesks.GetOrDefault(uuid, -1);
    }

    public static void SetGuestDeskcode(string uuid, int desk) {
        guestDesks[uuid] = desk + 1;
    }

    public static void SetGuestOrderServedFood(string uuid)
    {
        if (guestOrderFullfilled.TryGetValue(uuid, out var item))
        {
            var (_, beverage) = item;
            guestOrderFullfilled[uuid] = (true, beverage);
        }
        else
        {
            guestOrderFullfilled[uuid] = (true, false);
        }
    }

    public static void SetGuestOrderServedBeverage(string uuid)
    {
        if (guestOrderFullfilled.TryGetValue(uuid, out var item))
        {
            var (food, _) = item;
            guestOrderFullfilled[uuid] = (food, true);
        }
        else
        {
            guestOrderFullfilled[uuid] = (false, true);
        }
    }

    public static void SetGuestOrderFullfilled(string uuid)
    {
        guestOrderFullfilled[uuid] = (true, true);
    }

    public static void ResetGuestOrderServed(string uuid)
    {
        _ = guestOrderFullfilled.TryRemove(uuid, out _);
    }

    public static bool GetGuestOrderServedFood(string uuid)
    {
        return guestOrderFullfilled.GetOrDefault(uuid, (false, false)).Item1;
    }

    public static bool GetGuestOrderServedBeverage(string uuid)
    {
        return guestOrderFullfilled.GetOrDefault(uuid, (false, false)).Item2;
    }

    public static bool GetGuestOrderFullfilled(string uuid)
    {
        if (guestOrderFullfilled.TryGetValue(uuid, out var item))
        {
            var (food, beverage) = item;
            return food && beverage;
        }
        return false;
    }



    public static NormalGuestsController SpawnNormalGuestGroup(int id, string UUID, UnityEngine.Color bgColor, UnityEngine.Color textColor, int? id2 = null)
    {
        var guests = new Il2CppSystem.Collections.Generic.List<NormalGuest>();
        var guest1 = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.RefNGuest(id);

        GuestProfilePair p = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.RefNormalGuestVisual(guest1.id);
        p.bgColor = bgColor;
        p.textColor = textColor;
        normalGuestProfile[guest1.Pointer] = p;

        Log.LogMessage($"{LOG_TAG} {UUID} stored color {p.bgColor}, {p.textColor}");

        guests.Add(guest1);
        if (id2 != null)
        {
            var guest2 = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.RefNGuest(id2.Value);
            guests.Add(guest2);
        }

        var controller = GuestsManagerPatch.SpawnNormalGuestGroup_WithArg_Original(
                GuestsManager.instance, guests.ToIEnumerable(), new Il2CppSystem.Nullable<UnityEngine.Vector3>(), GuestGroupController.LeaveType.Move, -1, true);

        StoreGuest(controller, UUID);
        SetGuestStatus(UUID, Status.Generated);
        return controller;
    }

    public static SpecialGuestsController SpawnSpecialGuestGroup(int id, string UUID)
    {
        var controller = GuestsManagerPatch.SpawnSpecialGuestGroup_Original(
                GuestsManager.instance, id, SpecialGuestsController.GuestSpawnType.Normal, new Il2CppSystem.Nullable<UnityEngine.Vector3>());

        StoreGuest(controller, UUID);
        SetGuestStatus(UUID, Status.Generated);
        return controller;
    }

    public static bool CheckStatus(string uuid, Status targetStatus) => GetGuestStatus(uuid) == targetStatus;

    public static bool CheckStatusIn(string uuid, Status[] targetStatus) => targetStatus.Contains(GetGuestStatus(uuid));

    public static bool CheckStatusOrThrow(string uuid, Status targetStatus)
    {
        return GetGuestStatus(uuid) == Status.Null ? throw new GuestInvalidatedException($"{uuid} invalidated") : CheckStatus(uuid, targetStatus);
    }

    public static bool CheckStatusInOrThrow(string uuid, Status[] targetStatus)
    {
        return GetGuestStatus(uuid) == Status.Null ? throw new GuestInvalidatedException($"{uuid} invalidated") : CheckStatusIn(uuid, targetStatus);
    }

    public static bool CheckStatusGreaterOrThrow(string uuid, Status targetStatus)
    {
        return GetGuestStatus(uuid) == Status.Null ? throw new GuestInvalidatedException($"{uuid} invalidated") : GetGuestStatus(uuid) >= targetStatus;
    }

    public class GuestInvalidatedException : Exception
    {
        public GuestInvalidatedException()
        {
        }

        public GuestInvalidatedException(string message) : base(message)
        {
        }

        public GuestInvalidatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GuestInvalidatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
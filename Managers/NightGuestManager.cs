using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Serialization;
using GameData.Core.Collections.NightSceneUtility;
using LibCpp2IL;
using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;
using static NightScene.GuestManagementUtility.GuestsManager;   // OrderBase
namespace MetaMystia;

[AutoLog]
public static partial class NightGuestManager
{
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

    [MemoryPackable]
    public partial class GuestInfo
    {
        public int Id { get; set; }
        public int? VisualId { get; set; }
        public int? Id2 { get; set; }
        public int? VisualId2 { get; set; }
        public bool IsSpecial { get; set; } = false;
    }
    
    private static ConcurrentDictionary<string, GuestGroupController> guests = new(); 
    private static ConcurrentDictionary<string, Status> guestStatus = new(); 
    private static ConcurrentDictionary<string, int> guestDesks = new(); 
    private static ConcurrentDictionary<string, int> guestDeskSeats = new(); 
    private static ConcurrentDictionary<string, GuestInfo> guestInfos = new(); 
    private static ConcurrentDictionary<IntPtr, string> guestIds = new();
    private static ConcurrentDictionary<string, (bool, bool)> guestOrderFullfilled = new(); 


    public static ConcurrentQueue<(OrderBase, string)> orders = new();
    public static ConcurrentQueue<int> normalGuestProfilePairIndexQueue = new(); 

    public static int WorkTimeLeft => NightScene.EventUtility.EventManager.Instance.totalCountDown;
    public static void ModifyWorkTimeLeft(int time) => NightScene.EventUtility.EventManager.Instance.totalCountDown = time;


    //private static int getGuestControllerHashCode(GuestGroupController controller) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(controller);

    public static void Clear()
    {
        guests.Clear();
        guestStatus.Clear();
        guestDesks.Clear();
        guestDeskSeats.Clear();
        guestInfos.Clear();
        guestIds.Clear();
        orders.Clear();
        normalGuestProfilePairIndexQueue.Clear();
        guestOrderFullfilled.Clear();
    }

    public static string StoreGuest(GuestGroupController guest)
    {
        string uuid = Guid.NewGuid().ToString();
        guests[uuid] = guest;
        guestIds[guest.Pointer] = uuid;
        Log.Message($"stored guest pointer {guest.Pointer} => {uuid}");
        return uuid;

    }

    public static void StoreGuest(GuestGroupController guest, string uuid)
    {
        guests[uuid] = guest;
        guestIds[guest.Pointer] = uuid;
        Log.Message($"stored guest pointer {guest.Pointer} => {uuid}");
    }

    public static string GetGuestUUID(GuestGroupController guest)
    {
        if (guest == null)
        {
            Log.Error($"guest is null!");
            return "";
        }
        if (guestIds.TryGetValue(guest.Pointer, out var value))
        {
            return value;
        }
        else
        {
            Log.Error($"pointer {guest.Pointer} not found");
            // ShigureYuki.DiagnosticUtils.LogAllProperties(guest);
            Log.LogStacktrace();
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
    public static Status GetGuestStatusForLog(string uuid) => GetGuestStatus(uuid);

    public static void SetGuestStatus(string uuid, Status value) {
        Log.Message($"{uuid} Desk [{GetGuestDeskcode(uuid)}] status {GetGuestStatus(uuid)} -> {value}");
        guestStatus[uuid] = value;
    }

    // Returns the real desk + 1
    public static int GetGuestDeskcode(string uuid) => guestDesks.GetOrDefault(uuid, -1);

    public static void SetGuestDeskcode(string uuid, int desk) => guestDesks[uuid] = desk + 1;

    public static int GetGuestDeskcodeSeat(string uuid) => guestDeskSeats.GetOrDefault(uuid, -1);

    public static void SetGuestDeskcodeSeat(string uuid, int seat) => guestDeskSeats[uuid] = seat;

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

    public static void SetGuestOrderFullfilled(string uuid) => guestOrderFullfilled[uuid] = (true, true);

    public static void ResetGuestOrderServed(string uuid) => _ = guestOrderFullfilled.TryRemove(uuid, out _);

    public static bool GetGuestOrderServedFood(string uuid) => guestOrderFullfilled.GetOrDefault(uuid, (false, false)).Item1;

    public static bool GetGuestOrderServedBeverage(string uuid) => guestOrderFullfilled.GetOrDefault(uuid, (false, false)).Item2;

    public static bool GetGuestOrderFullfilled(string uuid)
    {
        if (guestOrderFullfilled.TryGetValue(uuid, out var item))
        {
            var (food, beverage) = item;
            return food && beverage;
        }
        return false;
    }

    public static void StoreGuestInfo(GuestInfo guest, string uuid) => guestInfos[uuid] = guest;
    public static GuestInfo GetGuestInfo(string uuid) => guestInfos.GetOrDefault(uuid, null);

    public static GuestGroupController SpawnGuestGroup(GuestInfo guestInfo, string UUID)
    {
        return guestInfo.IsSpecial ? SpawnSpecialGuestGroup(guestInfo.Id, UUID) : SpawnNormalGuestGroup(guestInfo, UUID);
    }

    private static NormalGuestsController SpawnNormalGuestGroup(GuestInfo guestInfo, string UUID)
    {
        var guests = new Il2CppSystem.Collections.Generic.List<NormalGuest>();
        var guest1 = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.RefNGuest(guestInfo.Id);
        normalGuestProfilePairIndexQueue.Enqueue(guestInfo.VisualId.Value);
        guests.Add(guest1);

        if (guestInfo.Id2 != null)
        {
            var guest2 = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.RefNGuest(guestInfo.Id2.Value);
            normalGuestProfilePairIndexQueue.Enqueue(guestInfo.VisualId2.Value);
            guests.Add(guest2);
        }

        var controller = GuestsManagerPatch.SpawnNormalGuestGroup_WithArg_Original(
                GuestsManager.instance, guests.ToIEnumerable(), new Il2CppSystem.Nullable<UnityEngine.Vector3>(), GuestGroupController.LeaveType.Move, -1, true);
        if (IsGuestNull(controller))
        {
            Log.Error($"{UUID} is null after executing SpawnNormalGuestGroup_WithArg_Original!");
        }
        StoreGuestInfo(guestInfo, UUID);
        StoreGuest(controller, UUID);
        SetGuestStatus(UUID, Status.Generated);
        return controller;
    }

    private static SpecialGuestsController SpawnSpecialGuestGroup(int id, string UUID)
    {
        var controller = GuestsManagerPatch.SpawnSpecialGuestGroup_Original(
                GuestsManager.instance, id, SpecialGuestsController.GuestSpawnType.Normal, new Il2CppSystem.Nullable<UnityEngine.Vector3>());

        StoreGuestInfo(new GuestInfo { Id = id, IsSpecial = true }, UUID);
        StoreGuest(controller, UUID);
        SetGuestStatus(UUID, Status.Generated);
        return controller;
    }

    public static void MoveToDesk(GuestGroupController __instance, int deskCode, Il2CppSystem.Action onMovementFinishCallback, int deskSeat = -1)
    {
        if (__instance.queued) __instance.RemoveFromQueue();
        var desk = NightScene.Tiles.TileManager.Instance.GuestTables[deskCode];
        var seatDir = desk.seatPositions.ToList();
        __instance.DeskCode = deskCode;
        var characterInMotion = __instance.guestInstances.Length;
        __instance.OnMoveToSeatCallback?.Invoke(desk.tablePosition, __instance);

        var uuid = GetGuestUUID(__instance);

        if (IsGuestNull(__instance))
        {
            Log.Error($"MoveToDesk {uuid}, guest or its component is null! will skip set path");
            if (deskSeat != -1) seatDir.RemoveAt(deskSeat);
            return;
        }
        for (var i = 0; i < __instance.guestInstances.Length; i++)
        {
            var item = __instance.guestInstances[i];

            if (deskSeat == -1 || deskSeat >= seatDir.Count)
            {
                deskSeat = UnityEngine.Random.Range(0, seatDir.Count);
            }
            var onArrive = () =>
            {
                var current = --characterInMotion;
                if (current == 0) onMovementFinishCallback.Invoke();
            };
            
            var colliderCollections = __instance.tileManager.GetCollider(seatDir[deskSeat], new Il2CppSystem.Collections.Generic.IReadOnlyList<UnityEngine.Vector3Int>(__instance.tileManager.PasserBorder.Pointer));

            Log.Info($"setting path for {uuid}, desk {deskCode}, seat {deskSeat}");
            
            item?.SetPath(
                seatDir[deskSeat], 
                colliderCollections,
                i * 0.2f,
                onArrive,
                NightScene.Tiles.TileManager.FindDirection(seatDir[deskSeat], desk.tablePosition),
                new Il2CppSystem.Nullable<UnityEngine.Vector3>() 
            );
            seatDir.RemoveAt(deskSeat);
        }
    }

    public static bool RemoveOccupiedDesk(int deskcode) => GuestsManager.instance.occupiedDesks.Remove(deskcode);
    public static bool RemoveGuestAndOrder(int deskId)
    {
        var guest = GuestsManager.instance.GetInDeskGuest(deskId);
        if (IsGuestNull(guest))
        {
            Log.LogWarning($"deskId {deskId} guest is null");
            return false;
        }
        else
        {
            Log.LogWarning($"removing {GetGuestUUID(guest)} out: DeskId {deskId}");
            RemoveOrder(guest);
            GuestsManagerPatch.LeaveFromDesk_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, null, true);
            GuestsManager.instance.SetGuestOutDesk(guest);
            return RemoveOccupiedDesk(deskId);
        }
    }

    public static void RemoveOrder(GuestGroupController guest)
    {
        if (IsGuestNotNull(guest))
        {
            if (guest.AllOrdersData.Count > 0)
            {
                var prevOrder = guest.PeekOrders();
                if (prevOrder != null && !prevOrder.IsFullfilled)
                {
                    Log.Message($"removed guest {GetGuestUUID(guest)} order");
                    GuestsManager.instance.RemoveFromOrder(prevOrder);
                }
            }
        }
    }

    public static bool IsGuestNotNull(string uuid) => IsGuestNotNull(GetGuest(uuid));
    public static bool IsGuestNotNull(GuestGroupController guest)
    {
        if (guest == null) return false;
        if (guest.guestInstances == null) return false;
        if (guest.guestInstances.Any((component) => component == null)) return false;
        return true;
    }
    public static bool IsGuestNull(string uuid) => !IsGuestNotNull(uuid);
    public static bool IsGuestNull(GuestGroupController guest) => !IsGuestNotNull(guest);

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

    public static void CloseIzakayaIfPossible()
    {
        GuestsManager.Instance?.TryRepellAllQueuedGuestControllers();
        GuestsManagerPatch.TryCloseIzakaya_Original(GuestsManager.Instance);
        GuestsManager.Instance?.occupiedDesks.Clear();
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
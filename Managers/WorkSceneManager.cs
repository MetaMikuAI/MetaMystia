using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using GameData.Core.Collections.NightSceneUtility;
using LibCpp2IL;
using MemoryPack;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;
using static NightScene.GuestManagementUtility.GuestsManager;   // OrderBase
namespace MetaMystia;

[AutoLog]
public static partial class WorkSceneManager
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

        [JsonIgnore]
        public UnityEngine.Vector3? OverrideSpawnPosition { get; set; } = null;
        public GuestGroupController.LeaveType LeaveType { get; set; } = GuestGroupController.LeaveType.Move;
    }
    
    private static ConcurrentDictionary<string, GuestGroupController> guests = new(); 
    private static ConcurrentDictionary<string, Status> guestStatus = new(); 
    private static ConcurrentDictionary<string, int> guestDesks = new(); 
    private static ConcurrentDictionary<string, int> guestDeskSeats = new(); 
    private static ConcurrentDictionary<string, GuestInfo> guestInfos = new(); 
    private static ConcurrentDictionary<IntPtr, string> guestIds = new();
    private static ConcurrentDictionary<string, (bool, bool)> guestOrderFulfilled = new(); 
    private static ConcurrentDictionary<string, ConcurrentQueue<(OrderBase, string)>> guestOrders = new();

    public static ConcurrentQueue<int> normalGuestProfilePairIndexQueue = new(); 


    public static Il2CppSystem.Func<int> GetWholeNightTimeOriginal;
    public static Func<int> GetWholeNightTimeReplaced = () => GetWholeNightTimeOriginal.Invoke() * 2;   // 240*2 = 480s = 8min

    public static bool InHakugyokurouChallenge => NightScene.NightSceneDirector.ChallengeMode == NightScene.NightSceneDirector.ChallengeType.Story_Basic 
        || NightScene.NightSceneDirector.ChallengeMode == NightScene.NightSceneDirector.ChallengeType.Story_Advanced 
        || NightScene.NightSceneDirector.ChallengeMode == NightScene.NightSceneDirector.ChallengeType.Story_Yuyuko;
    public static bool InChallenge => NightScene.NightSceneDirector.ChallengeMode != NightScene.NightSceneDirector.ChallengeType.NotChallenge;

    public static readonly ConcurrentDictionary<string, ConcurrentQueue<CommandScheduler.Command>> GuestCommandQueue = new();
    public static void ClearGuestCommandSchedulerQueue() => CommandScheduler.ClearKeyQueue(GuestCommandQueue);
    public static void EnqueueGuestCommand(
        string key,
        Func<bool> executeWhen,
        Action execute,
        string executeInfo = "",
        Action beforeExecute = null,
        float timeoutSeconds = 30f,
        Action onTimeout = null) => CommandScheduler.EnqueueKey(GuestCommandQueue, key, executeWhen, execute, executeInfo, beforeExecute, timeoutSeconds, onTimeout);

    public static int WorkTimeLeft => NightScene.EventUtility.EventManager.Instance.TotalCountDown;
    public static void ModifyWorkTimeLeft(int time)
    {
        NightScene.EventUtility.EventManager.Instance.totalCountDown = time;
        Log.Message($"modified work time to {time}");
    } 

    public const int PatientAddedSecs = 15;
    private static void AddPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs) => guest?.SetPatient(Math.Min(guest.CurrentPatient + patientSecs, guest.MaxPatient));
    private static void AddMaxPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs) => guest?.MaxPatient += patientSecs;
    private static void SetToMaxPatient(GuestGroupController guest) => guest?.SetPatient(guest.MaxPatient);
    private static void SafeAddPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs)
    {
        if (IsGuestNull(guest)) return;
        var uuid = GetGuestUUID(guest);
        if (uuid == null) return;
        if (CheckStatus(uuid, Status.OrderGenerated))
        {
            Log.LogInfo($"added patient {patientSecs}s to {uuid}");
            AddPatient(guest, patientSecs);
        }
    }
    private static void SafeAddMaxPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs)
    {
        if (IsGuestNull(guest)) return;
        var uuid = GetGuestUUID(guest);
        if (uuid == null) return;
        if (CheckStatus(uuid, Status.OrderGenerated))
        {
            Log.LogInfo($"added max patient {patientSecs}s to {uuid}");
            AddMaxPatient(guest, patientSecs);
            SetToMaxPatient(guest);
        }
    }

    public static void DelayedSafeAddPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs) 
        => CommandScheduler.DelayExecute(1, () => SafeAddPatient(guest, patientSecs));
    public static void DelayedSafeAddMaxPatient(GuestGroupController guest, int patientSecs = PatientAddedSecs) 
        => CommandScheduler.DelayExecute(1, () => SafeAddMaxPatient(guest, patientSecs));



    //private static int getGuestControllerHashCode(GuestGroupController controller) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(controller);

    static WorkSceneManager()
    {
        CommandScheduler.RegisterKeyQueue(GuestCommandQueue);
    }

    public static void Clear()
    {
        guests.Clear();
        guestStatus.Clear();
        guestDesks.Clear();
        guestDeskSeats.Clear();
        guestInfos.Clear();
        guestIds.Clear();
        guestOrderFulfilled.Clear();

        guestOrders.Clear();
        normalGuestProfilePairIndexQueue.Clear();
        ClearGuestCommandSchedulerQueue();
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

    public static string GetGuestUUID(this GuestGroupController guest)
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

    public static GuestGroupController GetGuest(this string uuid) {
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
        Log.Message($"{uuid} Desk [{GetGuestDeskcodeForLog(uuid)}] status {GetGuestStatus(uuid)} -> {value}");
        guestStatus[uuid] = value;
    }

    /// <summary>
    /// Returns the real desk - 1
    /// </summary>
    /// <param name="uuid"></param>
    /// <returns></returns>
    public static int GetGuestDeskcode(string uuid) => guestDesks.GetOrDefault(uuid, -1);
    public static int GetGuestDeskcodeForLog(string uuid) => guestDesks.GetOrDefault(uuid, -1) + 1;

    public static void SetGuestDeskcode(string uuid, int desk) => guestDesks[uuid] = desk;

    public static int GetGuestDeskcodeSeat(string uuid) => guestDeskSeats.GetOrDefault(uuid, -1);

    public static void SetGuestDeskcodeSeat(string uuid, int seat) => guestDeskSeats[uuid] = seat;

    public static void EnqueueGuestOrder(string uuid, OrderBase order, string orderMessage)
    {
        guestOrders.GetOrAdd(uuid, new ConcurrentQueue<(OrderBase, string)>()).Enqueue((order, orderMessage));
    }

    public static bool DequeueGuestOrder(string uuid, out (OrderBase, string) orderTuple)
    {
        return guestOrders.GetOrDefault(uuid, new ConcurrentQueue<(OrderBase, string)>()).TryDequeue(out orderTuple);
    }


    public static void SetGuestOrderServedFood(string uuid)
    {
        if (guestOrderFulfilled.TryGetValue(uuid, out var item))
        {
            var (_, beverage) = item;
            guestOrderFulfilled[uuid] = (true, beverage);
        }
        else
        {
            guestOrderFulfilled[uuid] = (true, false);
        }
    }

    public static void SetGuestOrderServedBeverage(string uuid)
    {
        if (guestOrderFulfilled.TryGetValue(uuid, out var item))
        {
            var (food, _) = item;
            guestOrderFulfilled[uuid] = (food, true);
        }
        else
        {
            guestOrderFulfilled[uuid] = (false, true);
        }
    }

    public static void SetGuestOrderFullfilled(string uuid) => guestOrderFulfilled[uuid] = (true, true);

    public static void ResetGuestOrderServed(string uuid) => _ = guestOrderFulfilled.TryRemove(uuid, out _);

    public static bool GetGuestOrderServedFood(string uuid) => guestOrderFulfilled.GetOrDefault(uuid, (false, false)).Item1;

    public static bool GetGuestOrderServedBeverage(string uuid) => guestOrderFulfilled.GetOrDefault(uuid, (false, false)).Item2;

    public static bool GetGuestOrderFullfilled(string uuid)
    {
        if (guestOrderFulfilled.TryGetValue(uuid, out var item))
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
        return guestInfo.IsSpecial ? SpawnSpecialGuestGroup(guestInfo, UUID) : SpawnNormalGuestGroup(guestInfo, UUID);
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

        Il2CppSystem.Nullable<UnityEngine.Vector3> overrideSpawnPosition = guestInfo.OverrideSpawnPosition.HasValue
            ? new Il2CppSystem.Nullable<UnityEngine.Vector3>(guestInfo.OverrideSpawnPosition.Value)
            : new Il2CppSystem.Nullable<UnityEngine.Vector3>();

        var controller = GuestsManagerPatch.SpawnNormalGuestGroup_Original_MinHook(
                GuestsManager.instance, guests.ToIEnumerable(), overrideSpawnPosition, guestInfo.LeaveType);
        if (IsGuestNull(controller))
        {
            Log.Error($"{UUID} is null after executing SpawnNormalGuestGroup_WithArg_Original!");
        }
        StoreGuestInfo(guestInfo, UUID);
        StoreGuest(controller, UUID);
        SetGuestStatus(UUID, Status.Generated);
        return controller;
    }

    private static SpecialGuestsController SpawnSpecialGuestGroup(GuestInfo guestInfo, string UUID)
    {
        var controller = GuestsManagerPatch.SpawnSpecialGuestGroup_Original(
                GuestsManager.instance, guestInfo.Id, SpecialGuestsController.GuestSpawnType.Normal, 
                new Il2CppSystem.Nullable<UnityEngine.Vector3>(), leaveType: guestInfo.LeaveType);

        StoreGuestInfo(guestInfo, UUID);
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
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene) return;
        GuestsManager.Instance?.TryRepellAllQueuedGuestControllers();
        GuestsManagerPatch.TryCloseIzakaya_Original(GuestsManager.Instance);
        GuestsManager.Instance?.occupiedDesks.Clear();
    }

    public static void CloseTrayPanel(NightScene.UI.GuestManagementUtility.WorkSceneServePannel servePanel)
    {
        if (servePanel == null) return;
        var trayPanel = servePanel.m_CurrentTray;
        if (trayPanel == null) return;
        if (!trayPanel.IsPanelOpened) return;
        trayPanel.ClosePanel();
        var director = NightScene.NightSceneDirector.Instance;
        if (director != null && director.CanGotoNextPhase())
        {
            director.OnInteractableExit();
        }
        Log.Info($"tray panel closed");
    }

    public static void CloseServePanel(NightScene.UI.GuestManagementUtility.WorkSceneServePannel servePanel)
    {
        if (servePanel == null) return;
        if (!servePanel.isActiveAndEnabled) return;
        if (!servePanel.IsPanelOpened) return;
        WorkSceneServePannelPatch.ManuallyClosePanel = true;
        servePanel.ClosePanel();
        WorkSceneServePannelPatch.ManuallyClosePanel = false;
        Log.Info($"serve panel closed");
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
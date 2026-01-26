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
using NightScene.Tiles;
using SgrYuki.Utils;
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

    private static ConcurrentDictionary<IntPtr, string> guestIds = new();
    private static ConcurrentDictionary<string, GuestFSM> guestFSMs = new();

    public static ConcurrentQueue<int> normalGuestProfilePairIndexQueue = new();

    public static Il2CppSystem.Func<int> GetWholeNightTimeOriginal;

    public static Func<int> GetWholeNightTimeReplaced = () => MpManager.WorkTimeModifier;

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
            Log.LogInfo($"added patient {patientSecs}s to {uuid.GetGuestFSM()?.Identifier}");
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
            Log.LogInfo($"added max patient {patientSecs}s to {uuid.GetGuestFSM()?.Identifier}");
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
        guestIds.Clear();
        guestFSMs.Clear();
        normalGuestProfilePairIndexQueue.Clear();
        ClearGuestCommandSchedulerQueue();
    }

    public static string StoreGuest(GuestGroupController guest)
    {
        string uuid = Guid.NewGuid().ToString();
        StoreGuest(guest, uuid);
        return uuid;
    }

    public static void StoreGuest(GuestGroupController guest, string uuid)
    {
        var fsm = GetOrCreateGuestFSM(uuid);
        fsm.StoreGuest(guest);
        guestIds[guest.Pointer] = uuid;
        Log.Message($"stored guest pointer {guest.Pointer} => {uuid}");
    }

    public static string GetConnectedGuestUUID(this GuestGroupController guest)
    {
        if (MpManager.IsConnected) return GetGuestUUID(guest);
        return "not_connected";
    }

    public static string GetGuestUUID(this GuestGroupController guest, bool LogError = true)
    {
        if (guest == null)
        {
            if (LogError) Log.Error($"guest is null!");
            return "";
        }
        if (guestIds.TryGetValue(guest.Pointer, out var value))
        {
            return value;
        }
        else
        {
            if (LogError)
            {
                Log.Error($"pointer {guest.Pointer} not found");
                Log.LogStacktrace();
            }
        }
        return "";
    }

    private static Status GetGuestStatus(string uuid) => GetGuestFSM(uuid)?.CurrentState ?? Status.Null;
    public static Status GetGuestStatusForLog(string uuid) => GetGuestStatus(uuid);

    /// <summary>
    /// 获取或创建客人的FSM状态机
    /// </summary>
    public static GuestFSM GetOrCreateGuestFSM(string uuid) => guestFSMs.GetOrAdd(uuid, _ => new GuestFSM(uuid));

    /// <summary>
    /// 获取客人的FSM状态机
    /// </summary>
    public static GuestFSM GetGuestFSM(this string uuid) => guestFSMs.GetOrDefault(uuid, null);
    public static GuestFSM GetGuestFSM(this GuestGroupController guest, bool LogError = true) => guestFSMs.GetOrDefault(guest.GetGuestUUID(LogError), null);

    public static int GetGuestDeskcode(string uuid) => GetGuestFSM(uuid)?.DeskCode ?? -1;
    public static void SetGuestDeskcode(string uuid, int desk) => GetGuestFSM(uuid)?.SetDeskCode(desk);

    public static int GetGuestDeskcodeSeat(string uuid) => GetGuestFSM(uuid)?.DeskSeatCode ?? -1;
    public static void SetGuestDeskcodeSeat(string uuid, int seat) => GetGuestFSM(uuid)?.SetDeskSeatCode(seat);


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

        StoreGuest(controller, UUID);

        // 通过FSM转移状态
        var fsm = GetOrCreateGuestFSM(UUID);
        fsm.ChangeState(Status.Generated);
        fsm.StoreGuestInfo(guestInfo);

        return controller;
    }

    private static SpecialGuestsController SpawnSpecialGuestGroup(GuestInfo guestInfo, string UUID)
    {
        var controller = GuestsManagerPatch.SpawnSpecialGuestGroup_Original(
                GuestsManager.instance, guestInfo.Id, SpecialGuestsController.GuestSpawnType.Normal,
                new Il2CppSystem.Nullable<UnityEngine.Vector3>(), leaveType: guestInfo.LeaveType);

        StoreGuest(controller, UUID);

        // 通过FSM转移状态
        var fsm = GetOrCreateGuestFSM(UUID);
        fsm.ChangeState(Status.Generated);
        fsm.StoreGuestInfo(guestInfo);

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

            Log.Debug($"setting path for {uuid}, desk {deskCode}, seat {deskSeat}");

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

    public static GuestGroupController GetInDeskGuest(int deskCode) => GuestsManager.Instance.GetInDeskGuest(deskCode);
    public static bool RemoveOccupiedDesk(int deskcode)
    {
        Log.InfoCaller($"desk {deskcode}, guest {GetInDeskGuest(deskcode)?.GetGuestFSM()?.Identifier}");
        return GuestsManager.Instance.occupiedDesks.Remove(deskcode);
    }

    private static void RemoveOrder(GuestGroupController guest)
    {
        if (IsGuestNotNull(guest))
        {
            if (guest.AllOrdersData.Count > 0)
            {
                var prevOrder = guest.PeekOrders();
                if (prevOrder != null && !prevOrder.IsFullfilled)
                {
                    Log.MessageCaller($"guest {guest.GetGuestFSM()?.Identifier}");
                    GuestsManager.Instance.RemoveFromOrder(prevOrder);
                }
            }
        }
    }

    public static bool RemoveGuestAndOrder(int deskId)
    {
        var guest = GetInDeskGuest(deskId);
        if (IsGuestNull(guest))
        {
            Log.LogWarning($"deskId {deskId} guest is null");
            return false;
        }
        else
        {
            Log.WarningCaller($"{guest.GetGuestFSM()?.Identifier}: DeskId {deskId}");
            RemoveOrder(guest);
            GuestsManagerPatch.LeaveFromDesk_Original(GuestsManager.instance, guest, GuestGroupController.LeaveType.Move, null, true);
            GuestsManager.Instance.SetGuestOutDesk(guest);
            GuestsManager.Instance.guestIconManager?.Remove(guest);
            GuestsManager.Instance.ManualDesksDic?.Remove(deskId);
            return RemoveOccupiedDesk(deskId);
        }
    }

    public static bool RemoveInvalidGuest(this GuestFSM fSM, int overrideDeskCode = -1)
    {
        var targetDeskCode = overrideDeskCode == -1 ? fSM.DeskCode : overrideDeskCode;
        if (targetDeskCode == -1)
        {
            Log.WarningCaller($"{fSM.Identifier} target desk is -1, skip");
            return false;
        }
        Log.WarningCaller($"{fSM.Identifier}: DeskId {targetDeskCode}");
        if (fSM.GuestController != null)
        {
            GuestsManager.Instance.SetGuestOutDesk(fSM.GuestController);
            GuestsManager.Instance.guestIconManager?.Remove(fSM.GuestController);
            GuestsManager.Instance.ManualDesksDic?.Remove(targetDeskCode);
        }
        return RemoveOccupiedDesk(targetDeskCode);
    }

    public static void SafeLeaveFromDesk(this GuestFSM fSM)
    {
        var controller = fSM.GuestController;
        if (controller == null) return;

        controller.Left = true;
        controller.guestInstances?.Where(x => x != null).ToList().ForEach(x => x.ExternalStop());

        GuestsManager.Instance.guestIconManager?.Remove(controller);

        Action ConfirmLeave = () =>
        {
            GuestsManager.Instance.occupiedDesks?.Remove(controller.DeskCode);
            GuestsManager.Instance.ManualDesksDic?.Remove(controller.DeskCode);
            TileManager.Instance.GuestTables[controller.DeskCode]?.tableDisplayer?.ResetValue();
            NightScene.UI.UIManager.Instance.guestBuffMarkModule?.ClearBuffMarkWhenTargetDeskGuestLeave(controller.DeskCode);
            GuestsManager.Instance.SetGuestOutDesk(controller);
            GuestsManager.Instance.SetPlayerCanNotRepelGuest(controller);
            controller.OnLeaveDeskCallback?.Invoke(controller);
            controller.TryReleaseAllServedFood();
            controller.MoveToSpawn();
            GuestsManager.Instance.CheckAndSendFromQueue();
        };
        if (controller.ControllType == GuestsManager.GuestType.Special && controller is SpecialGuestsController sgc)
        {
            sgc.TriggerLeaveBuff(ConfirmLeave);
        }
        else
        {
            ConfirmLeave();
        }
    }

    public static bool IsGuestNull(GuestGroupController guest) => !IsGuestNotNull(guest);
    public static bool IsGuestNotNull(GuestGroupController guest)
    {
        if (guest == null) return false;
        if (guest.guestInstances == null) return false;
        if (guest.guestInstances.Any((component) => component == null)) return false;
        return true;
    }

    public static bool IsGuestNull(string uuid) => !IsGuestNotNull(uuid);
    public static bool IsGuestNotNull(string uuid) => GetGuestFSM(uuid)?.IsGuestValid() ?? false;

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

    public static void ShowNoMoneyDialog(GuestGroupController guest)
    {
        if (guest == null) return;
        var evalRes = (GuestGroupController.EvaluationResult)(1 + (guest.ControllType == GuestsManager.GuestType.Special ? 1 : 0));
        GuestsManager.instance.PlayEvaluateSFX(evalRes);
        GuestsManager.instance.TryCloseCurrentDialogBox(guest);
        var evalStr = guest.GetEvaluationDialog(guest.GetNoMoneyDialogIndex(), out var speaker);
        var dialog = GuestsManager.instance.ShowEvaluationDialog(guest, evalStr, evalRes, speaker);
        GuestsManager.instance.StartCoroutine_Auto(dialog);
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

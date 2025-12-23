using MemoryPack;

namespace MetaMystia;

public enum ActionType : ushort
{
    PING,
    PONG,
    HELLO,
    SYNC,
    READY,
    MESSAGE,
    SELECT,
    CONFIRM,
    PREP,
    NIGHTSYNC,
    COOK,
    EXTRACT,
    QTE,
    STOREFOOD,
    EXTRACTFOOD,
    GUEST_SPAWN,
    GUEST_SEATED,
    GUEST_GEN_NORMAL_ORDER,
    GUEST_GEN_SPECIAL_ORDER,
    GUEST_SERVE,
    GUEST_LEAVE,
}

[MemoryPackable]
[MemoryPackUnion((ushort)ActionType.PING, typeof(PingAction))]
[MemoryPackUnion((ushort)ActionType.PONG, typeof(PongAction))]
[MemoryPackUnion((ushort)ActionType.HELLO, typeof(HelloAction))]
[MemoryPackUnion((ushort)ActionType.SYNC, typeof(SyncAction))]
[MemoryPackUnion((ushort)ActionType.READY, typeof(ReadyAction))]
[MemoryPackUnion((ushort)ActionType.MESSAGE, typeof(MessageAction))]
[MemoryPackUnion((ushort)ActionType.SELECT, typeof(SelectAction))]
[MemoryPackUnion((ushort)ActionType.CONFIRM, typeof(ConfirmAction))]
[MemoryPackUnion((ushort)ActionType.PREP, typeof(PrepAction))]
[MemoryPackUnion((ushort)ActionType.NIGHTSYNC, typeof(NightSyncAction))]
[MemoryPackUnion((ushort)ActionType.COOK, typeof(CookAction))]
[MemoryPackUnion((ushort)ActionType.EXTRACT, typeof(ExtractAction))]
[MemoryPackUnion((ushort)ActionType.QTE, typeof(QTEAction))]
[MemoryPackUnion((ushort)ActionType.STOREFOOD, typeof(StoreFoodAction))]
[MemoryPackUnion((ushort)ActionType.EXTRACTFOOD, typeof(ExtractFoodAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SPAWN, typeof(GuestSpawnAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SEATED, typeof(GuestSeatedAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_GEN_NORMAL_ORDER, typeof(GuestGenNormalOrderAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_GEN_SPECIAL_ORDER, typeof(GuestGenSPOrderAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SERVE, typeof(GuestServeAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_LEAVE, typeof(GuestLeaveAction))]

public abstract partial class NetAction
{
    public abstract ActionType Type { get; }
    public abstract void OnReceived();
    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize((object)this,
            new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = false,
                IncludeFields = true
            });
    }

    private static void LogAction(BepInEx.Logging.LogLevel logLevel, bool OnlyAction, string logStr)
    {
        switch (logLevel)
        {
            case BepInEx.Logging.LogLevel.Debug:
                Log.LogDebug(logStr);
                break;
            case BepInEx.Logging.LogLevel.Warning:
                Log.LogWarning(logStr);
                break;
            case BepInEx.Logging.LogLevel.Error:
                Log.LogError(logStr);
                break;
            case BepInEx.Logging.LogLevel.Message:
                Log.LogMessage(logStr);
                break;
            default:
                Log.LogInfo(logStr);
                break;
        }
    }

    protected void LogActionReceived(BepInEx.Logging.LogLevel logLevel, bool onlyAction = false, string prefix = "")
    {
        string logStr = $"{prefix}Received {Type}{(onlyAction ? "" : $": {ToString()}")}";
        LogAction(logLevel, onlyAction, logStr);
    }

    protected void LogActionSend(BepInEx.Logging.LogLevel logLevel, bool onlyAction = false, string prefix = "")
    {
        string logStr = $"{prefix}Send {Type}{(onlyAction ? "" : $": {ToString()}")}";
        LogAction(logLevel, onlyAction, logStr);
    }

    public virtual void LogActionReceived(bool onlyAction = false, string prefix = "")
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Info, onlyAction, prefix);
    }

    public virtual void LogActionSend(bool onlyAction = false, string prefix = "")
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, onlyAction, prefix);
    }

    [MemoryPackIgnore]
    protected static BepInEx.Logging.ManualLogSource Log => Plugin.Instance.Log;

    public static void RegisterAllFormatter()
    {
        NetAction.RegisterFormatter();
        GuestServeAction.RegisterFormatter();
        GuestLeaveAction.RegisterFormatter();
    }
}

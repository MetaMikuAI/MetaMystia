using MemoryPack;

namespace MetaMystia;

public enum ActionType : ushort
{
    PING,
    PONG,
    HELLO,
    SCENE_TRANSIT,
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
    STORE_FOOD, // 这是往保温箱中存储，仅可以存储 food
    STORE_SELLABLE, // 这是往空位存储，可以存储 sellable（food / beverage）
    EXTRACT_FOOD,
    GUEST_INVITE,
    GUEST_SPAWN,
    GUEST_SEATED,
    GUEST_GEN_NORMAL_ORDER,
    GUEST_GEN_SPECIAL_ORDER,
    GUEST_SERVE,
    GUEST_LEAVE,
    BUFF,
    IZAKAYA_CLOSE
}

[MemoryPackable]
[MemoryPackUnion((ushort)ActionType.PING, typeof(PingAction))]
[MemoryPackUnion((ushort)ActionType.PONG, typeof(PongAction))]
[MemoryPackUnion((ushort)ActionType.HELLO, typeof(HelloAction))]
[MemoryPackUnion((ushort)ActionType.SCENE_TRANSIT, typeof(SceneTransitAction))]
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
[MemoryPackUnion((ushort)ActionType.STORE_FOOD, typeof(StoreFoodAction))]
[MemoryPackUnion((ushort)ActionType.STORE_SELLABLE, typeof(StoreSellableAction))]
[MemoryPackUnion((ushort)ActionType.EXTRACT_FOOD, typeof(ExtractFoodAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_INVITE, typeof(GuestInviteAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SPAWN, typeof(GuestSpawnAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SEATED, typeof(GuestSeatedAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_GEN_NORMAL_ORDER, typeof(GuestGenNormalOrderAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_GEN_SPECIAL_ORDER, typeof(GuestGenSPOrderAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_SERVE, typeof(GuestServeAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_LEAVE, typeof(GuestLeaveAction))]
[MemoryPackUnion((ushort)ActionType.BUFF, typeof(BuffAction))]
[MemoryPackUnion((ushort)ActionType.IZAKAYA_CLOSE, typeof(IzakayaCloseAction))]
[AutoLog]

public abstract partial class NetAction
{
    public abstract ActionType Type { get; }
    public long TimestampMs { get; protected set; }

    protected NetAction() => TimestampMs = MpManager.TimestampNow;
    
    public abstract void OnReceived();
    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize((object)this,
            new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = false,
                IncludeFields = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
            });
    }

    private static void LogAction(BepInEx.Logging.LogLevel logLevel, string logStr)
    {
        switch (logLevel)
        {
            case BepInEx.Logging.LogLevel.Debug:
                Log.LogDebug(logStr, false);
                break;
            case BepInEx.Logging.LogLevel.Warning:
                Log.LogWarning(logStr, false);
                break;
            case BepInEx.Logging.LogLevel.Error:
                Log.LogError(logStr, false);
                break;
            case BepInEx.Logging.LogLevel.Message:
                Log.LogMessage(logStr, false);
                break;
            default:
                Log.LogInfo(logStr, false);
                break;
        }
    }

    protected void LogActionReceived(BepInEx.Logging.LogLevel logLevel, bool onlyAction = false, string prefix = "")
    {
        string logStr = $"{MpManager.RoleTag} {prefix}Received {Type}{(onlyAction ? "" : $": {ToString()}")}";
        LogAction(logLevel, logStr);
    }

    protected void LogActionSend(BepInEx.Logging.LogLevel logLevel, bool onlyAction = false, string prefix = "")
    {
        string logStr = $"{MpManager.RoleTag} {prefix}Send {Type}{(onlyAction ? "" : $": {ToString()}")}";
        LogAction(logLevel, logStr);
    }

    public virtual void LogActionReceived(bool onlyAction = false, string prefix = "")
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Info, onlyAction, prefix);
    }

    public virtual void LogActionSend(bool onlyAction = false, string prefix = "")
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, onlyAction, prefix);
    }

    protected static void SendToPeer(NetPacket packet) => MpManager.SendToPeer(packet);
    protected static void SendToHostOrBroadcast(NetPacket packet) => MpManager.SendToPeer(packet);


    public static void RegisterAllFormatter()
    {
        if (!MemoryPackFormatterProvider.IsRegistered<NetAction>()) MemoryPackFormatterProvider.Register(new NetActionFormatter());
        if (!MemoryPackFormatterProvider.IsRegistered<NetAction[]>()) MemoryPackFormatterProvider.Register(new MemoryPack.Formatters.ArrayFormatter<NetAction>());
    }
}

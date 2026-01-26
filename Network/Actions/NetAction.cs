using System;
using System.Reflection;
using BepInEx.Logging;
using MemoryPack;
using SgrYuki.Utils;

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
    GUEST_PAY,
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
[MemoryPackUnion((ushort)ActionType.GUEST_PAY, typeof(GuestPayAction))]
[MemoryPackUnion((ushort)ActionType.GUEST_LEAVE, typeof(GuestLeaveAction))]
[MemoryPackUnion((ushort)ActionType.BUFF, typeof(BuffAction))]
[MemoryPackUnion((ushort)ActionType.IZAKAYA_CLOSE, typeof(IzakayaCloseAction))]
[AutoLog]

public abstract partial class NetAction
{
    public abstract ActionType Type { get; }
    public long TimestampMs { get; protected set; }
    public long SenderId { get; protected set; }

    [MemoryPackIgnore]
    protected virtual bool SkipReceiveOnStory { get; } = false;

    [MemoryPackIgnore]
    protected virtual bool SkipSendOnStory { get; } = false;

    [MemoryPackIgnore]
    protected virtual LogLevel OnReceiveLogLevel { get; } = LogLevel.Info;

    [MemoryPackIgnore]
    protected virtual LogLevel OnSendLogLevel { get; } = LogLevel.Info;

    [MemoryPackIgnore]
    protected virtual bool OnReceiveLogOnlyAction { get; } = false;

    [MemoryPackIgnore]
    protected virtual bool OnSendLogOnlyAction { get; } = false;

    [MemoryPackIgnore]
    private const string OnReceivedDerivedAfterStoryOverCommand = "OnReceivedDerivedAfterStoryOver";

    protected NetAction()
    {
        TimestampMs = MpManager.TimestampNow;
    }


    public abstract void OnReceivedDerived();
    public void OnReceived()
    {
        LogActionReceived();
        if (SkipReceiveOnStory && MpManager.ShouldSkipAction)
        {
            Log.Info($"{MpManager.RoleTag} Received Skip {Type}: {ToString()}");
            return;
        }
        var targetScene = GetReceivedScene();
        if (targetScene != null && MpManager.LocalScene != targetScene.Value)
        {
            Log.Info($"{MpManager.RoleTag} Received in invalid scene: {Type}: {ToString()}");
            return;
        }
        if (GetOnReceivedDerivedExecuteAfterStoryOver())
        {
            ExecuteAfterStoryOver(OnReceivedDerived);
        }
        else
        {
            OnReceivedDerived();
        }
    }

    private Common.UI.Scene? GetReceivedScene()
    {
        var method = this.GetType().GetMethod(nameof(OnReceivedDerived));
        var attr = method.GetCustomAttribute<CheckSceneAttribute>();
        return attr?.Scene;
    }

    private bool GetOnReceivedDerivedExecuteAfterStoryOver()
    {
        var method = this.GetType().GetMethod(nameof(OnReceivedDerived));
        var attr = method.GetCustomAttribute<ExecuteAfterStoryAttribute>();
        return attr != null;
    }


    private void ExecuteAfterStoryOver(Action action)
    {
        CommandScheduler.EnqueueKey(
            key: OnReceivedDerivedAfterStoryOverCommand,
            executeWhen: () => !MpManager.ShouldSkipAction,
            executeInfo: $"OnReceivedDerivedAfterStoryOver {Type}: {ToString()}",
            execute: action,
            timeoutSeconds: 300
        );
    }
    public static void RemoveExecuteAfterStoryOver()
    {
        CommandScheduler.RemoveKeyFromKeyQueue(OnReceivedDerivedAfterStoryOverCommand);
    }

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

    private static void LogAction(LogLevel logLevel, string logStr)
    {
        switch (logLevel)
        {
            case LogLevel.Debug:
                Log.Debug(logStr, false);
                break;
            case LogLevel.Warning:
                Log.Warning(logStr, false);
                break;
            case LogLevel.Error:
                Log.Error(logStr, false);
                break;
            case LogLevel.Fatal:
                Log.Fatal(logStr, false);
                break;
            case LogLevel.Message:
                Log.Message(logStr, false);
                break;
            default:
                Log.Info(logStr, false);
                break;
        }
    }

    protected void LogActionReceived()
    {
        string logStr = $"{MpManager.RoleTag} Received {Type}{(OnReceiveLogOnlyAction ? "" : $": {ToString()}")}";
        LogAction(OnReceiveLogLevel, logStr);
    }

    protected void LogActionSend()
    {
        string logStr = $"{MpManager.RoleTag} Send {Type}{(OnSendLogOnlyAction ? "" : $": {ToString()}")}";
        LogAction(OnSendLogLevel, logStr);
    }

    protected void SendToHostOrBroadcast()
    {
        if (SkipSendOnStory && MpManager.ShouldSkipAction)
        {
            Log.Info($"{MpManager.RoleTag} Will not send Skip {Type}: {ToString()}");
            return;
        }
        if (!MpManager.IsConnected) return;

        LogActionSend();

        var packet = NetPacket.FromSingleAction(this);
        MpManager.SendToHostOrBroadcast(packet);
    }

    protected void SendToPeer(long peerId)
    {
        if (SkipSendOnStory && MpManager.ShouldSkipAction)
        {
            Log.Info($"{MpManager.RoleTag} Will not send Skip {Type}: {ToString()}");
            return;
        }
        if (!MpManager.IsConnected) return;

        LogActionSend();

        var packet = NetPacket.FromSingleAction(this);
        MpManager.SendToPeer(packet);
    }

    public void ChangeSender(long newSender) => SenderId = newSender;

    public static void RegisterAllFormatter()
    {
        if (!MemoryPackFormatterProvider.IsRegistered<NetAction>()) MemoryPackFormatterProvider.Register(new NetActionFormatter());
        if (!MemoryPackFormatterProvider.IsRegistered<NetAction[]>()) MemoryPackFormatterProvider.Register(new MemoryPack.Formatters.ArrayFormatter<NetAction>());
    }

    [AttributeUsage(AttributeTargets.Method)]
    protected class CheckSceneAttribute(Common.UI.Scene scene) : Attribute
    {
        public Common.UI.Scene Scene { get; } = scene;
    }

    [AttributeUsage(AttributeTargets.Method)]
    protected class ExecuteAfterStoryAttribute : Attribute { }
}



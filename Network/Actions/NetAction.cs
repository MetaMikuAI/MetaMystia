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
}

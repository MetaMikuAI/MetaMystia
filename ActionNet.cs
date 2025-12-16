using MemoryPack;
using System.Collections.Generic;

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
    NIGHTSYNC
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


[MemoryPackable]
public partial class PingAction : NetAction
{
    public override ActionType Type => ActionType.PING;
    public int Id { get; set; }
    public long Timestamp { get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received PING: {Id}");
        MpManager.TimeOffset = (MpManager.GetTimestampNow - Timestamp) / 2;
        MpManager.Instance.SendPong(Id);
    }
    public static NetPacket CreatePingPacket(int id)
    {
        return NetPacket.Create(new PingAction
        {
            Id = id,
            Timestamp = MpManager.GetTimestampNow
        });
    }
}

[MemoryPackable]
public partial class PongAction : NetAction
{
    public override ActionType Type => ActionType.PONG;
    public int Id { get; set; }

    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received PONG: {Id}");
        MpManager.Instance.UpdateLatency(Id);
    }
    public static NetPacket CreatePongPacket(int id)
    {
        return NetPacket.Create(new PongAction { Id = id });
    }
}


[MemoryPackable]
public partial class HelloAction : NetAction
{
    public override ActionType Type => ActionType.HELLO;
    public string PeerId { get; set; } = "";
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received HELLO: {PeerId}");
        MpManager.Instance.PeerId = PeerId;
    }
}


[MemoryPackable]
public partial class SyncAction : NetAction
{
    public override ActionType Type => ActionType.SYNC;
    public float Vx {get; set; }
    public float Vy {get; set; }
    public float Px {get; set; }
    public float Py {get; set; }
    public bool IsSprinting{get; set;}
    public string MapLabel {get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received SYNC: {this.ToString()}");
        PluginManager.Instance.RunOnMainThread(() =>
            KyoukoManager.SyncFromPeer(MapLabel, IsSprinting,
                new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }
}


[MemoryPackable]
public partial class ReadyAction : NetAction
{
    public override ActionType Type => ActionType.READY;
    public bool IsReady {get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received READY: {IsReady}");
        if (PluginManager.CurrentGameScene != Common.UI.Scene.DayScene)
        {
            Plugin.Instance.Log.LogWarning("READY action received outside DayScene, ignoring.");
            return;
        }
        KyoukoManager.IsReady = true;
        if (MystiaManager.IsReady)
        {
            PluginManager.Instance.RunOnMainThread(DaySceneManagerPatch.OnDayOver_DirectInvoke);
        }
        // else: 00->01: Nope
        Plugin.Instance.Log.LogInfo("Kyouko is ready");
    }
}

[MemoryPackable]
public partial class MessageAction : NetAction
{
    public override ActionType Type => ActionType.MESSAGE;
    private const int maxMessageLen = 1024;
    public string Message {get; private set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received MESSAGE: {Message}");
        PluginManager.Console.AddPeerMessage(Message);
        FloatingTextHelper.ShowFloatingTextOnMainThread(KyoukoManager.GetCharacterComponent(), Message);
    }
    private static MessageAction CreateMsgAction(string msg)
    {
        if (msg.Length <= maxMessageLen)
        {
            return new MessageAction{Message = msg};
        } 
        else
        {
            return new MessageAction{Message = msg[..maxMessageLen] };
        }
    }
    public static NetPacket CreateMsgPacket(string msg)
    {
        return NetPacket.Create(CreateMsgAction(msg));
    }
}

[MemoryPackable]
public partial class SelectAction : NetAction
{
    public override ActionType Type => ActionType.SELECT;
    public string MapLabel { get; set; } = "";
    public int Level { get; set; } = 0;
    public override void OnReceived()
    {
        // 接收 SELECT 包，缓存并展示「提示」对话
        Plugin.Instance.Log.LogInfo($"Received SELECT: {MapLabel}, {Level}");
        PluginManager.Instance.RunOnMainThread(() =>
        {
            KyoukoManager.IzakayaMapLabel = MapLabel;
            KyoukoManager.IzakayaLevel = Level;

            DialogManager.ShowInformDialog(KyoukoManager.IzakayaMapLabel, null);
        });
    }
}

[MemoryPackable]
public partial class ConfirmAction : NetAction
{
    public override ActionType Type => ActionType.CONFIRM;
    public string MapLabel { get; set; } = "";
    public int Level { get; set; } = 0;
    public override void OnReceived()
    {
        // 接收 CONFIRM 包 
        // -> 检查已有选择，不匹配则应强制修改
        // -> 展示「确认」对话
        // -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束
        Plugin.Instance.Log.LogInfo($"Received CONFIRM: {MapLabel}, {Level}");

        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (IzakayaSelectorPanelPatch.cachedSpots.TryGetValue(MapLabel, out var spot))
            {
                IzakayaSelectorPanelPatch.instanceRef.OnGuideMapSpotSelected(spot);
            }
            var targetLevel = (Common.UI.IzakayaLevel)Level;
            var currentLevel = IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedIzakayaLevel;
            IzakayaSelectorPanelPatch.instanceRef.TryChangeIzakayaLevel(ref currentLevel, targetLevel);
            IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedIzakayaLevel = currentLevel;

            static void closePanelCallback()
            {
                IzakayaSelectorPanelPatch._skipPatchIzakayaSelectionConfirmation = true;
                IzakayaSelectorPanelPatch.instanceRef._OnGuideMapInitialize_b__21_0();
                IzakayaSelectorPanelPatch._skipPatchIzakayaSelectionConfirmation = false;
            }
            KyoukoManager.IzakayaLevel = Level;
            KyoukoManager.IzakayaMapLabel = MapLabel;
            DialogManager.ShowConfirmDialog(MapLabel, closePanelCallback);
        });
    }
}

[MemoryPackable]
public partial class CookerSlot
{
    public const int SlotsLength = 8;

    public int Id { get; set; } = -1;
    public long Timestamp { get; set; } = 0;

    public CookerSlot Clone()
    {
        return new CookerSlot
        {
            Id = Id,
            Timestamp = Timestamp,
        };
    }

    public static CookerSlot[] CreateDefaultArray()
    {
        var slots = new CookerSlot[SlotsLength];
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = new CookerSlot();
        }
        return slots;
    }
}

[MemoryPackable]
public partial class PrepAction : NetAction
{
    public override ActionType Type => ActionType.PREP;

    [MemoryPackable]
    public partial class Table
    {
        public Dictionary<int, long> RecipeAdditions { get; set; } = [];
        public Dictionary<int, long> RecipeDeletions { get; set; } = [];

        public Dictionary<int, long> BeverageAdditions { get; set; } = [];
        public Dictionary<int, long> BeverageDeletions { get; set; } = [];

        public CookerSlot[] Cookers { get; set; } = CookerSlot.CreateDefaultArray();
    }

    public Table PrepTable { get; set; } = new Table();
    public bool Ready { get; set; } = false;

    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received PREP action");
        
        PrepSceneManager.MergeFromPeer(PrepTable);

        if (!Ready)
        {
            return;
        }
        PrepSceneManager.remotePlayerReady = true;
        Plugin.Instance.Log.LogInfo("Remote player is ready in prep scene");
        if (!PrepSceneManager.localPlayerReady)
        {
            // 如果 Mystia 未准备好，则应通知对方已经 Ready，然后自己直接 Ready
            PrepSceneManager.localPlayerReady = true;
            MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable, true);
        }
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigPannelPatch.instanceRef._SolveDailyCompletion_b__61_7();
        });
    }
}

[MemoryPackable]
public partial class NightSyncAction : NetAction
{
    public override ActionType Type => ActionType.NIGHTSYNC;
    public float Vx {get; set; }
    public float Vy {get; set; }
    public float Px {get; set; }
    public float Py {get; set; }
    public override void OnReceived()
    {
        Plugin.Instance.Log.LogInfo($"Received NIGHTSYNC: {this.ToString()}");
        PluginManager.Instance.RunOnMainThread(() =>
            KyoukoManager.NightSyncFromPeer(new UnityEngine.Vector2(Vx, Vy), new UnityEngine.Vector2(Px, Py)));
    }
}
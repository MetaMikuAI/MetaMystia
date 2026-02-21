using System.Collections.Generic;
using Common.UI;
using MemoryPack;

namespace MetaMystia.Network;

[MemoryPackable]
[AutoLog]
public partial class HelloAction : Action
{
    public override ActionType Type => ActionType.HELLO;
    public string PeerId { get; set; } = "";
    public string Version { get; set; } = "";
    public string GameVersion { get; set; } = "";
    public Scene CurrentGameScene { get; set; }

    public List<string> PeerActiveDLCLabel { get; set; }
    public HashSet<int> PeerDLCRecipes { get; set; } = null;
    public HashSet<int> PeerDLCCookers { get; set; } = null;
    public HashSet<int> PeerDLCFoods { get; set; } = null;
    public HashSet<int> PeerDLCBeverages { get; set; } = null;
    public HashSet<int> PeerDLCNormalGuests { get; set; } = null;
    public HashSet<int> PeerDLCSpecialGuests { get; set; } = null;

    // ResourceEx (rEx) resource sets
    public HashSet<int> PeerRExRecipes { get; set; } = null;
    public HashSet<int> PeerRExFoods { get; set; } = null;
    public HashSet<int> PeerRExBeverages { get; set; } = null;
    public HashSet<int> PeerRExSpecialGuests { get; set; } = null;

    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;
    public new void LogActionSend() => base.LogActionSend();

    public override void OnReceivedDerived()
    {
        MpManager.PeerId = PeerId;

        if (Version != MpManager.ModVersion)
        {
            Log.LogError($"Mod version mismatch! Local: {MpManager.ModVersion}, Remote: {Version}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread("Mod 版本不匹配，连接已断开！");
            return;
        }

        if (GameVersion != MpManager.GameVersion)
        {
            Log.LogError($"Game version mismatch! Local: {MpManager.GameVersion}, Remote: {GameVersion}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread("游戏版本不匹配，连接已断开！");
            return;
        }

        var bothInDay = CurrentGameScene == Scene.DayScene && MpManager.LocalScene == Scene.DayScene;
        var bothInMain = CurrentGameScene == Scene.MainScene && MpManager.LocalScene == Scene.MainScene;
        if (!bothInDay && !bothInMain)
        {
            Log.LogError($"Scene mismatch! Local: {MpManager.LocalScene}, Remote: {CurrentGameScene}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread("有玩家不处于白天或主界面，连接已断开");
            return;
        }

        if (MystiaManager.IsDayOver || PeerManager.IsDayOver)
        {
            Log.LogError($"Already dayOver! Local: {MystiaManager.IsDayOver}, Remote: {PeerManager.IsDayOver}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread("有玩家不处于白天或主界面，连接已断开");
            return;
        }

        DLCManager.PeerActiveDLCLabel = PeerActiveDLCLabel ?? [];
        DLCManager.PeerRecipes = PeerDLCRecipes ?? [];
        DLCManager.PeerCookers = PeerDLCCookers ?? [];
        DLCManager.PeerFoods = PeerDLCFoods ?? [];
        DLCManager.PeerBeverages = PeerDLCBeverages ?? [];
        DLCManager.PeerNormalGuests = PeerDLCNormalGuests ?? [];
        DLCManager.PeerSpecialGuests = PeerDLCSpecialGuests ?? [];

        DLCManager.PeerRExRecipes = PeerRExRecipes ?? [];
        DLCManager.PeerRExFoods = PeerRExFoods ?? [];
        DLCManager.PeerRExBeverages = PeerRExBeverages ?? [];
        DLCManager.PeerRExSpecialGuests = PeerRExSpecialGuests ?? [];
    }

    public static void Send()
    {
        new HelloAction
        {
            PeerId = MpManager.PlayerId,
            PeerActiveDLCLabel = MpManager.ActiveDLCLabel,
            Version = MyPluginInfo.PLUGIN_VERSION,
            CurrentGameScene = MpManager.LocalScene,
            GameVersion = MpManager.GameVersion,

            PeerDLCBeverages = DLCManager.Beverages,
            PeerDLCCookers = DLCManager.Cookers,
            PeerDLCFoods = DLCManager.Foods,
            PeerDLCNormalGuests = DLCManager.NormalGuests,
            PeerDLCRecipes = DLCManager.Recipes,
            PeerDLCSpecialGuests = DLCManager.SpecialGuests,

            PeerRExRecipes = DLCManager.RExRecipes,
            PeerRExFoods = DLCManager.RExFoods,
            PeerRExBeverages = DLCManager.RExBeverages,
            PeerRExSpecialGuests = DLCManager.RExSpecialGuests,
        }.SendToHostOrBroadcast();
    }
}

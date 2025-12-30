using System.Collections.Generic;
using Common.UI;
using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class HelloAction : NetAction
{
    public override ActionType Type => ActionType.HELLO;
    public string PeerId { get; set; } = "";
    public string Version { get; set; } = "";
    public string GameVersion { get; set; } = "";
    public Scene CurrentGameScene { get; set; }

    public List<string> PeerActiveDLCLabel { get; set; } 
    public HashSet<int> PeerDLCRecipes {get; set;} = null;
    public HashSet<int> PeerDLCCookers {get; set;} = null;
    public HashSet<int> PeerDLCFoods {get; set;} = null;
    public HashSet<int> PeerDLCBeverages {get; set;} = null;
    public HashSet<int> PeerDLCNormalGuests {get; set;} = null;
    public HashSet<int> PeerDLCSpecialGuests {get; set;} = null;

    public override void OnReceived()
    {
        LogActionReceived();
        MpManager.PeerId = PeerId;
        MpManager.PeerGameVersion = GameVersion;

        if (Version != MyPluginInfo.PLUGIN_VERSION)
        {
            Log.LogError($"Mod version mismatch! Local: {MyPluginInfo.PLUGIN_VERSION}, Remote: {Version}");
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
        
        DLCManager.PeerActiveDLCLabel = PeerActiveDLCLabel ?? [];
        DLCManager.PeerRecipes = PeerDLCRecipes ?? [];
        DLCManager.PeerCookers = PeerDLCCookers ?? [];
        DLCManager.PeerFoods = PeerDLCFoods ?? [];
        DLCManager.PeerBeverages = PeerDLCBeverages ?? [];
        DLCManager.PeerNormalGuests = PeerDLCNormalGuests ?? [];
        DLCManager.PeerSpecialGuests = PeerDLCSpecialGuests ?? [];
    }

    public static void Send()
    {
        SendToPeer(new NetPacket([new HelloAction { 
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
        }]));
    }
}

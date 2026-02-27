using MemoryPack;

using Common.UI;

using MetaMystia.UI;

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
    public ResourceDataBase PeerDataBase { get; set; }

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
            Notify.ShowOnMainThread(TextId.ModVersionMismatch.Get());
            return;
        }

        if (GameVersion != MpManager.GameVersion)
        {
            Log.LogError($"Game version mismatch! Local: {MpManager.GameVersion}, Remote: {GameVersion}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread(TextId.GameVersionMismatch.Get());
            return;
        }

        var bothInDay = CurrentGameScene == Scene.DayScene && MpManager.LocalScene == Scene.DayScene;
        var bothInMain = CurrentGameScene == Scene.MainScene && MpManager.LocalScene == Scene.MainScene;
        if (!bothInDay && !bothInMain)
        {
            Log.LogError($"Scene mismatch! Local: {MpManager.LocalScene}, Remote: {CurrentGameScene}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread(TextId.SceneMismatchDisconnected.Get());
            return;
        }

        if (MystiaManager.IsDayOver || PeerManager.IsDayOver)
        {
            Log.LogError($"Already dayOver! Local: {MystiaManager.IsDayOver}, Remote: {PeerManager.IsDayOver}");
            MpManager.DisconnectPeer();
            Notify.ShowOnMainThread(TextId.SceneMismatchDisconnected.Get());
            return;
        }

        DLCManager.UpdateRemoteDataBase(PeerDataBase);
    }

    public static void Send()
    {
        new HelloAction
        {
            PeerId = MpManager.PlayerId,
            Version = MyPluginInfo.PLUGIN_VERSION,
            CurrentGameScene = MpManager.LocalScene,
            GameVersion = MpManager.GameVersion,

            PeerDataBase = DLCManager.localDataBase

        }.SendToHostOrBroadcast();
    }
}

using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class ReadyAction : NetAction
{
    public override ActionType Type => ActionType.READY;
    public bool IsReady {get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.DayScene)
        {
            Log.LogWarning("READY action received outside DayScene, ignoring.");
            return;
        }
        KyoukoManager.IsReady = true;
        if (MystiaManager.IsReady)
        {
            PluginManager.Instance.RunOnMainThread(DaySceneManagerPatch.OnDayOver_Original);
        }
        // else: 00->01: Nope
        Log.LogInfo("Kyouko is ready");
    }
}

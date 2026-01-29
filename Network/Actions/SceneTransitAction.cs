using MemoryPack;

namespace MetaMystia.Network;

// public enum Scene
// {
//     DayScene,
//     MainScene,
//     LoadScene,
//     IzakayaPrepScene,
//     WorkScene,
//     ResultScene,
//     StaffScene,
//     EmptyScene
// }


[MemoryPackable]
[AutoLog]
public partial class SceneTransitAction : Action
{
    public override ActionType Type => ActionType.SCENE_TRANSIT;

    [MemoryPackAllowSerialize]
    public Common.UI.Scene Scene { get; set; }
    public override void OnReceivedDerived()
    {
        MpManager.PeerScene = Scene;
        return;
    }

    public static void Send(Common.UI.Scene scene)
    {
        var action = new SceneTransitAction
        {
            Scene = scene,
        };
        action.SendToHostOrBroadcast();
    }
}

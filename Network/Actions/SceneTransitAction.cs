using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class SceneTransitAction : NetAction
{
    public override ActionType Type => ActionType.SCENE_TRANSIT;
    public Common.UI.Scene Scene {get; set; }
    public override void OnReceived()
    {
        LogActionReceived();
        MpManager.PeerScene = Scene;
    }

    public static void Send(Common.UI.Scene scene)
    {
        NetPacket packet = new([new SceneTransitAction
        {
            Scene = scene
        }]);
        SendToPeer(packet);
    }
}

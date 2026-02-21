using MemoryPack;
using SgrYuki;

namespace MetaMystia.Network;

[MemoryPackable]
public partial class MessageAction : Action
{
    public override ActionType Type => ActionType.MESSAGE;

    [MemoryPackIgnore]
    private const int maxMessageLen = 1024;
    public string Message { get; private set; }
    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;

    public override void OnReceivedDerived()
    {
        PluginManager.Console.AddPeerMessage(Message);
        if (MystiaManager.MapLabel == PeerManager.MapLabel)
        {
            FloatingTextHelper.ShowFloatingTextOnMainThread(PeerManager.GetCharacterUnit(), Message);
        }
        Notify.ShowExternOnMainThread(TextId.ChatMessagePeer.Get(MpManager.PeerId, Message));
    }
    private static MessageAction CreateMsgAction(string msg)
    {
        if (msg.Length <= maxMessageLen)
        {
            return new MessageAction { Message = msg };
        }
        else
        {
            return new MessageAction { Message = msg[..maxMessageLen] };
        }
    }

    public static void Send(string message)
    {
        FloatingTextHelper.ShowFloatingTextSelfOnMainThread(message);
        Notify.ShowExternOnMainThread(TextId.ChatMessageSelf.Get(message));
        CreateMsgAction(message).SendToHostOrBroadcast();
    }
}

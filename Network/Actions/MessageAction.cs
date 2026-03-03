using MemoryPack;

using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

[MemoryPackable]
[Action.HostRelay]
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
        if (PlayerManager.LocalMapLabel == PlayerManager.Peer?.MapLabel)
        {
            FloatingTextHelper.ShowFloatingTextOnMainThread(PlayerManager.Peer?.GetCharacterUnit(), Message);
        }
        var senderName = PlayerManager.GetPeerName(SenderUid);
        Notify.ShowExternOnMainThread(TextId.ChatMessagePeer.Get(senderName, Message));
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

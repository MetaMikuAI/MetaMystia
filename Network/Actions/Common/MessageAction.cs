using System.Data.Common;
using MemoryPack;

using MetaMystia.UI;
using SgrYuki;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 所有玩家：发送聊天消息
/// </summary>
[MemoryPackable]
[HostRelay]
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
        var senderName = PlayerManager.GetPeerName(SenderUid);
        PluginManager.Console.AddPeerMessage(senderName, Message);
        if (PlayerManager.Peers.TryGetValue(SenderUid, out var senderPeer)
            && PlayerManager.LocalMapLabel == senderPeer.MapLabel)
        {
            FloatingTextHelper.ShowFloatingTextOnMainThread(senderPeer.GetCharacterUnit(), Message);
        }
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

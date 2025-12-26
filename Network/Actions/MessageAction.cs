using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class MessageAction : NetAction
{
    public override ActionType Type => ActionType.MESSAGE;
    
    [MemoryPackIgnore]
    private const int maxMessageLen = 1024;
    public string Message {get; private set; }
    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Message, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived(BepInEx.Logging.LogLevel.Message);
        PluginManager.Console.AddPeerMessage(Message);
        FloatingTextHelper.ShowFloatingTextOnMainThread(KyoukoManager.GetCharacterUnit(), Message);
        Notify.ShowOnMainThread($"响子: {Message}");
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

    public static void Send(string message)
    {
        FloatingTextHelper.ShowFloatingTextSelfOnMainThread(message);
        Notify.ShowOnMainThread($"你: {message}");
        SendToPeer(new NetPacket([CreateMsgAction(message)]));
    }
}

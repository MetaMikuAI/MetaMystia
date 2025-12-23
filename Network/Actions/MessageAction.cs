using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class MessageAction : NetAction
{
    public override ActionType Type => ActionType.MESSAGE;
    
    [MemoryPackIgnore]
    private const int maxMessageLen = 1024;
    public string Message {get; private set; }
    public override void OnReceived()
    {
        LogActionReceived();
        PluginManager.Console.AddPeerMessage(Message);
        FloatingTextHelper.ShowFloatingTextOnMainThread(KyoukoManager.GetCharacterUnit(), Message);
        PluginManager.Instance.RunOnMainThread(() => Notify.Show($"响子: {Message}"));
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
    public static NetPacket CreateMsgPacket(string msg)
    {
        return new NetPacket([CreateMsgAction(msg)]);
    }
}

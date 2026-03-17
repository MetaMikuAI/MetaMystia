using MemoryPack;

namespace MetaMystia.Network;

/// <summary>
/// HelloAck 中携带的已有 peer 信息
/// </summary>
[MemoryPackable]
public partial class PlayerInfo
{
    public int Uid { get; set; }
    public string PeerId { get; set; } = "";
    public ResourceDataBase DataBase { get; set; }
    public PlayerSkin Skin { get; set; }
}

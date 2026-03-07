using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 所有玩家：通告 PrepScene 的食谱/酒水/厨具变更，使用 Last-Write-Wins 策略合并数据，所有玩家对等
/// </summary>
[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class PrepAction : Action
{
    public override ActionType Type => ActionType.PREP;

    [MemoryPackable]
    public partial class Table
    {
        public Dictionary<int, long> RecipeAdditions { get; set; } = [];
        public Dictionary<int, long> RecipeDeletions { get; set; } = [];

        public Dictionary<int, long> BeverageAdditions { get; set; } = [];
        public Dictionary<int, long> BeverageDeletions { get; set; } = [];

        public CookerSlot[] Cookers { get; set; } = CookerSlot.CreateDefaultArray();
    }

    public Table PrepTable { get; set; } = new Table();

    protected override bool OnSendLogOnlyAction => true;
    protected override bool OnReceiveLogOnlyAction => true;

    public override void OnReceivedDerived()
    {
        PrepSceneManager.MergeFromPeer(PrepTable);
    }

    public static void Send(Table prepTable)
    {
        var action = new PrepAction
        {
            PrepTable = prepTable
        };
        action.SendToHostOrBroadcast();
    }
}

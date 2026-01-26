using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class PrepAction : NetAction
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

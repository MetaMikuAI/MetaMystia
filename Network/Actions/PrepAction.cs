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
    public bool Ready { get; set; } = false;

    public override void OnReceived()
    {
        LogActionReceived(true);
        PrepSceneManager.MergeFromPeer(PrepTable);
        
        if (!Ready)
        {
            return;
        }

        PrepSceneManager.remotePlayerReady = true;

        Log.LogInfo("Remote player is ready in prep scene");
        if (!PrepSceneManager.localPlayerReady)
        {
            // 如果 Mystia 未准备好，则应通知对方已经 Ready，然后自己直接 Ready
            PrepSceneManager.localPlayerReady = true;
            Send(PrepSceneManager.localPrepTable, true);
        }
        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaConfigPannelPatch.instanceRef._SolveDailyCompletion_b__61_7();
        });
    }

    public static void Send(Table prepTable, bool ready = false)
    {
        NetPacket packet = new([new PrepAction
        {
            PrepTable = prepTable,
            Ready = ready
        }]);
        SendToPeer(packet);
    }
}

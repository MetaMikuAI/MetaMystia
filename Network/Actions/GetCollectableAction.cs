using DayScene.Interactables.Collections.ConditionComponents;
using MemoryPack;
using SgrYuki.Utils;
namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GetCollectableAction : NetAction
{
    public override ActionType Type => ActionType.GET_COLLECTABLE;
    public string Collectable;

    [CheckScene(Common.UI.Scene.DayScene)]
    public override void OnReceivedDerived()
    {
        CommandScheduler.EnqueueWithNoCondition(() =>
        {
            if (!DLCManager.CollectableAvailable(Collectable))
            {
                Log.Message($"{Collectable} is not available, skip");
                return;
            }
            var item = GameData.RunTime.DaySceneUtility.RunTimeDayScene.GetTrackedCollectable(Collectable);
            if (item == null)
            {
                Log.Warning($"{Collectable} is null, skip");
                return;
            }
            DaySceneUtilityPatch.Collect_Original(item);
            EntityConditionComponent.TryUpdateConditionComponent<CollectableConditionComponent>();
            Log.Message($"collected {Collectable}");
        });
    }

    public static void Send(string collectable)
    {
        var action = new GetCollectableAction{
            Collectable = collectable
        };
        action.SendToHostOrBroadcast();
    }
}

using DayScene.Interactables.Collections.ConditionComponents;
using MemoryPack;
using SgrYuki;
namespace MetaMystia.Network;

/// <summary>
/// 任何玩家 → 所有玩家：采集同步，暂时弃用
/// 弃用理由：采集同步导致全体资源数 * n，且无法保证采集的游戏时间一致
/// 反对理由：玩家不方便协同收集资源
/// </summary>
[MemoryPackable]
[AutoLog]
[HostRelay]
public partial class GetCollectableAction : Action
{
    public override ActionType Type => ActionType.GET_COLLECTABLE;
    public string Collectable;

    [CheckScene(Common.UI.Scene.DayScene)]
    public override void OnReceivedDerived()
    {
        // CommandScheduler.EnqueueWithNoCondition(() =>
        // {
        //     if (!PlayerManager.CollectableAvailable(Collectable))
        //     {
        //         Log.Message($"{Collectable} is not available, skip");
        //         return;
        //     }
        //     var item = GameData.RunTime.DaySceneUtility.RunTimeDayScene.GetTrackedCollectable(Collectable);
        //     if (item == null)
        //     {
        //         Log.Warning($"{Collectable} is null, skip");
        //         return;
        //     }
        //     DaySceneUtilityPatch.Collect_Original(item);
        //     EntityConditionComponent.TryUpdateConditionComponent<CollectableConditionComponent>();
        //     Log.Message($"collected {Collectable}");
        // });
    }

    public static void Send(string collectable)
    {
        var action = new GetCollectableAction
        {
            Collectable = collectable
        };
        action.SendToHostOrBroadcast();
    }
}

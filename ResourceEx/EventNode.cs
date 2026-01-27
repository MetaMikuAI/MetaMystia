using UnityEngine;
using System.Linq;

using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using GameData.Core.Collections;

using static GameData.Profile.SchedulerNode.Trigger;

using MetaMystia.ResourceEx.Models;

namespace MetaMystia;


public static partial class ResourceExManager
{
    private static void ActivateAllKizunaEventNodes()
    {
        _characterConfigs.Values
            .Where(c => c.kizuna != null)
            .ToList()
            .ForEach(CheckAndActivateKizunaEventNode);
        Log.Info("Kizuna event nodes activation completed.");
    }

    private static void CheckAndActivateKizunaEventNode(CharacterConfig config)
    {
        var scheduledEvents = GameData.RunTime.Common.RunTimeScheduler.scheduledEvents;
        if (scheduledEvents[-1].Contains(config.kizuna.lv1UpgradePrerequisiteEvent) ||
            scheduledEvents[-1].Contains(config.kizuna.lv2UpgradePrerequisiteEvent) ||
            scheduledEvents[-1].Contains(config.kizuna.lv3UpgradePrerequisiteEvent) ||
            scheduledEvents[-1].Contains(config.kizuna.lv4UpgradePrerequisiteEvent))
        {
            return;
        }

        var currentBondLevel = GameData.RunTime.Common.RunTimeAlbum.RefOrGenerateSpecialRunTimeData(config.id).CurrentBondLevel;
        switch (currentBondLevel)
        {
            case 1:
                if (GameData.RunTime.Common.RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv1UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 1 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv1UpgradePrerequisiteEvent);
                break;
            case 2:
                if (GameData.RunTime.Common.RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv2UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 2 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv2UpgradePrerequisiteEvent);
                break;
            case 3:
                if (GameData.RunTime.Common.RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv3UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 3 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv3UpgradePrerequisiteEvent);
                break;
            case 4:
                if (GameData.RunTime.Common.RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv4UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 4 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv4UpgradePrerequisiteEvent);
                break;
            case 5:
                break;
            default:
                Log.Error($"Invalid bond level {currentBondLevel} for character {config.name}({config.id})");
                break;
        }
        Log.Info($"Activated kizuna event node for character {config.name}({config.id}) at bond level {currentBondLevel}");
    }
    private static void RegisterAllEventNodes() => EventNodeConfigs.ToList().ForEach(RegisterEventNode);
    private static void RegisterEventNode(EventNodeConfig config)
    {
        var eventNode = ScriptableObject.CreateInstance<EventNode>();
        eventNode.name = config.label;
        eventNode.label = config.label;
        eventNode.debugLabel = config.debugLabel;

        eventNode.scheduledEvent = BuildScheduledEvent(config.scheduledEvent, config.debugLabel);

        if (config.rewards != null)
        {
            eventNode.rewards = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<MissionNode.Reward>(config.rewards.Count);
            for (int i = 0; i < config.rewards.Count; i++)
            {
                eventNode.rewards[i] = BuildMissionReward(config.rewards[i]);
            }
        }
        if (config.postRewards != null)
        {
            eventNode.postRewards = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<MissionNode.Reward>(config.postRewards.Count);
            for (int i = 0; i < config.postRewards.Count; i++)
            {
                eventNode.postRewards[i] = BuildMissionReward(config.postRewards[i]);
            }
        }

        eventNode.postMissionsAfterPerformance = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(config.postMissionsAfterPerformance.Count);
        for (int i = 0; i < config.postMissionsAfterPerformance.Count; i++)
        {
            eventNode.postMissionsAfterPerformance[i] = config.postMissionsAfterPerformance[i];
        }

        eventNode.postEvents = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(config.postEvents.Count);
        for (int i = 0; i < config.postEvents.Count; i++)
        {
            eventNode.postEvents[i] = config.postEvents[i];
        }

        var _ = DataBaseScheduler.allNodes.TryAdd(config.label, eventNode);
        Log.Info($"Registering EventNode {config.debugLabel}({config.label}), success: {_}");
    }

    private static SchedulerNode.Trigger BuildEventTrigger(TriggerConfig config, string debugLabel)
    {
        if (config == null) return new SchedulerNode.Trigger();

        var trigger = new SchedulerNode.Trigger();

        trigger.triggerType = config.triggerType;
        switch (config.triggerType)
        {
            case TriggerType.KizunaCheckPoint:
                trigger.triggerId = config.triggerId; // TODO: make sure triggerId in allCharacters
                Log.Warning($"EventNode {debugLabel} using KizunaCheckPoint trigger with id {config.triggerId}, make sure it's correct.");
                break;
            default:
                Log.Error($"Unsupported event trigger type {config.triggerType} for event {debugLabel}");
                break;
        }
        Log.Warning($"Built trigger for EventNode {debugLabel}: Type {trigger.triggerType}, Id {trigger.triggerId}");
        return trigger;
    }

    private static SchedulerNode.ScheduledEvent BuildScheduledEvent(ScheduledEventConfig config, string debugLabel = "")
    {
        if (config == null) return new SchedulerNode.ScheduledEvent();

        var scheduledEvent = new SchedulerNode.ScheduledEvent()
        {
            trigger = BuildEventTrigger(config.trigger, debugLabel),
            eventData = BuildEventData(config.eventData, debugLabel),
        };
        return scheduledEvent;
    }

    private static SchedulerNode.Event BuildEventData(EventDataConfig config, string debugLabel = "")
    {
        if (config == null) return new SchedulerNode.Event();

        switch (config.eventType)
        {
            case SchedulerNode.Event.EventType.Dialog:
                if (!_builtDialogPackages.ContainsKey(config.dialogPackageName))
                {
                    Log.Error($"Dialog package {config.dialogPackageName} not found for event {debugLabel}");
                    return null;
                }
                return new SchedulerNode.Event()
                {
                    eventType = config.eventType,
                    runtimeDialogPackage = _builtDialogPackages[config.dialogPackageName]
                };
            default:
                Log.Error($"Unsupported event type {config.eventType} for event {debugLabel}");
                return null;
        }
    }
}

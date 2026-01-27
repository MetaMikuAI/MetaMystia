using System.Linq;

using GameData.Core.Collections;
using GameData.RunTime.Common;

using MetaMystia.ResourceEx.Models;
using MetaMystia.ResourceEx.Mappers;

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

        var currentBondLevel = RunTimeAlbum.RefOrGenerateSpecialRunTimeData(config.id).CurrentBondLevel;
        switch (currentBondLevel)
        {
            case 1:
                if (RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv1UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 1 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv1UpgradePrerequisiteEvent);
                break;
            case 2:
                if (RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv2UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 2 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv2UpgradePrerequisiteEvent);
                break;
            case 3:
                if (RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv3UpgradePrerequisiteEvent))
                {
                    Log.Info($"Kizuna event node for character {config.name}({config.id}) at bond level 3 already finished.");
                    return;
                }
                scheduledEvents[-1].Add(config.kizuna.lv3UpgradePrerequisiteEvent);
                break;
            case 4:
                if (RunTimeScheduler.finishedEvents.Contains(config.kizuna.lv4UpgradePrerequisiteEvent))
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
        var eventNode = config.ToRuntimeEventNode();
        var success = DataBaseScheduler.allNodes.TryAdd(config.label, eventNode);
        Log.Info($"Registering EventNode {config.debugLabel}({config.label}), success: {success}");
    }
}

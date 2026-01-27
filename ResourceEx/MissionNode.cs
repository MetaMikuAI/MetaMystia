using System.Linq;

using GameData.Core.Collections;
using GameData.CoreLanguage.Collections;

using MetaMystia.ResourceEx.Models;
using MetaMystia.ResourceEx.Mappers;

namespace MetaMystia;


public static partial class ResourceExManager
{
    private static void RegisterAllMissionNodeLanguages() => MissionNodeConfigs.ToList().ForEach(RegisterMissionNodeLanguage);
    private static void RegisterMissionNodeLanguage(MissionNodeConfig config)
    {
        var lang = config.ToMissionLanguage();
        DataBaseLanguage.Missions.TryAdd(config.label, lang);
    }


    private static void RegisterAllMissionNodes() => MissionNodeConfigs.ToList().ForEach(RegisterMissionNode);
    private static void RegisterMissionNode(MissionNodeConfig config)
    {
        Log.Info($"Registering MissionNode {config.title}({config.debugLabel})");
        var missionNode = config.ToRuntimeMissionNode();
        var success = DataBaseScheduler.allNodes.TryAdd(missionNode.label, missionNode);
        Log.Info($"Registered MissionNode {config.title}({config.label}): Success: {success}");
    }
}

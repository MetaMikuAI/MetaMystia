using UnityEngine;
using System.Linq;

using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;

using static GameData.Core.Collections.Sellable;
using static GameData.Profile.SchedulerNodeCollection.MissionNode;
using static GameData.Core.Collections.DaySceneUtility.Collections.Product;

using MetaMystia.ResourceEx.Models;

namespace MetaMystia;


public static partial class ResourceExManager
{
    private static void RegisterAllMissionNodeLanguages() => MissionNodeConfigs.ToList().ForEach(RegisterMissionNodeLanguage);
    private static void RegisterMissionNodeLanguage(MissionNodeConfig config)
    {
        DataBaseLanguage.Missions.TryAdd(
            config.label,
            new LanguageBase(config.title, config.description)
        );
    }


    private static void RegisterAllMissionNodes() => MissionNodeConfigs.ToList().ForEach(RegisterMissionNode);
    private static void RegisterMissionNode(MissionNodeConfig config)
    {
        Log.Info($"Registering MissionNode {config.title}({config.debugLabel})");
        var missionNode = ScriptableObject.CreateInstance<MissionNode>();
        missionNode.name = config.label;
        missionNode.label = config.label;

        missionNode.missionFailedAction = MissionFailedAction.None;

        missionNode.missionType = config.missionType;
        switch (config.missionType)
        {
            case SchedulerNode.SchedulerType.Kitsuna: // ignore typo
                missionNode.rewards = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<MissionNode.Reward>(config.rewards.Count);
                for (int i = 0; i < config.rewards.Count; i++)
                {
                    missionNode.rewards[i] = BuildMissionReward(config.rewards[i]);
                }
                missionNode.finishCondition = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<FinishCondition>(config.finishConditions.Count);
                for (int i = 0; i < config.finishConditions.Count; i++)
                {
                    missionNode.finishCondition[i] = BuildMissionFinishCondition(config.finishConditions[i]);
                }
                break;
            default:
                Log.Error($"Unsupported mission type {config.missionType} for mission {config.title}");
                break;
        }

        missionNode.sender = config.sender;
        missionNode.hasSender = !string.IsNullOrEmpty(config.sender);
        missionNode.reciever = config.reciever; // ignore typo
        missionNode.hasReciever = !string.IsNullOrEmpty(config.reciever); // ignore typo

        missionNode.missionFinishEvent = BuildEventData(config.missionFinishEvent, config.debugLabel);

        missionNode.postMissionsAfterPerformance = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(config.postMissionsAfterPerformance.Count);
        for (int i = 0; i < config.postMissionsAfterPerformance.Count; i++)
        {
            missionNode.postMissionsAfterPerformance[i] = config.postMissionsAfterPerformance[i];
        }

        missionNode.postEvents = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(config.postEvents.Count);
        for (int i = 0; i < config.postEvents.Count; i++)
        {
            missionNode.postEvents[i] = config.postEvents[i];
        }

        var success = DataBaseScheduler.allNodes.TryAdd(missionNode.label, missionNode);
        Log.Info($"Registered MissionNode {config.title}({config.label}): Success: {success}");
    }

    private static MissionNode.Reward BuildMissionReward(MissionRewardConfig config)
    {
        var reward = new MissionNode.Reward();
        reward.rewardType = config.rewardType;
        switch (config.rewardType)
        {
            case SchedulerNode.Reward.RewardType.UpgradeKizunaLevel:
                reward.rewardId = config.rewardId;
                break;
            case SchedulerNode.Reward.RewardType.GiveItem:
                if (!config.objectType.HasValue)
                {
                    Log.Error($"Missing objectType for GiveItem reward in mission reward {config.rewardId}");
                    break;
                }
                reward.objectType = config.objectType.Value;
                reward.rewardIntArray = config.rewardIntArray.ToArray();
                break;
            default:
                break;
        }
        return reward;
    }
    private static FinishCondition BuildMissionFinishCondition(MissionFinishConditionConfig config)
    {
        var condition = new FinishCondition();
        condition.conditionType = config.conditionType;
        switch (config.conditionType)
        {
            case FinishCondition.ConditionType.ServeInWork:
                condition.amount = config.amount.HasValue ? config.amount.Value : 0;
                condition.sellableType = config.sellableType.HasValue ? config.sellableType.Value : SellableType.Food;
                condition.label = config.label != null ? config.label : "";
                break;
            case FinishCondition.ConditionType.SubmitItem:
                var product = condition.product;
                product.productType = config.productType ?? ProductType.Food;
                product.productId = config.productId ?? 0;
                product.productAmount = config.productAmount ?? 0;
                condition.product = product;
                Log.Warning($"SubmitItem finish condition: productType={condition.product.productType}, productId={condition.product.productId}, productAmount={condition.product.productAmount}");
                break;
            default:
                break;
        }

        return condition;
    }
}

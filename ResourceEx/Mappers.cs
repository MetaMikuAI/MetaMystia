using UnityEngine;
using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;

using MetaMystia.ResourceEx.Models;

using static GameData.Core.Collections.Sellable;
using static GameData.Profile.SchedulerNode;
using static GameData.Profile.SchedulerNode.Trigger;
using static GameData.Profile.SchedulerNodeCollection.MissionNode;
using static GameData.Core.Collections.DaySceneUtility.Collections.Product;

namespace MetaMystia.ResourceEx.Mappers;

/// <summary>
/// Mapper layer for converting config DTOs to runtime game objects
/// </summary>
[AutoLog]
public static partial class Mappers
{
    #region Ingredient Mappers

    public static Ingredient ToRuntimeIngredient(this IngredientConfig config)
    {
        return new Ingredient(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            prefix: config.prefix,
            tags: config.tags.ToArray()
        );
    }

    public static ObjectLanguageBase ToIngredientLanguage(this IngredientConfig config, Sprite sprite)
    {
        return new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            visual: sprite
        );
    }

    #endregion

    #region Food Mappers

    public static Sellable ToRuntimeFood(this FoodConfig config)
    {
        return new Sellable(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            tags: config.tags.ToArray(),
            banTags: config.banTags.ToArray(),
            type: SellableType.Food,
            additiveTags: new Il2CppSystem.Collections.Generic.List<int>(),
            isCollab: false
        );
    }

    public static ObjectLanguageBase ToFoodLanguage(this FoodConfig config, Sprite sprite)
    {
        return new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            visual: sprite
        );
    }

    #endregion

    #region Beverage Mappers

    public static Sellable ToRuntimeBeverage(this BeverageConfig config)
    {
        return new Sellable(
            id: config.id,
            baseValue: config.baseValue,
            level: config.level,
            tags: config.tags.ToArray(),
            banTags: new int[0],
            type: SellableType.Beverage,
            additiveTags: new Il2CppSystem.Collections.Generic.List<int>(),
            isCollab: false
        );
    }

    public static ObjectLanguageBase ToBeverageLanguage(this BeverageConfig config, Sprite sprite)
    {
        return new ObjectLanguageBase(
            name: config.name,
            Description: config.description,
            visual: sprite
        );
    }

    #endregion

    #region Recipe Mappers

    public static Recipe ToRuntimeRecipe(this RecipeConfig config)
    {
        return new Recipe(
            id: config.id,
            foodID: config.foodId,
            cookerType: config.cookerType,
            cookTime: config.cookTime,
            ingredients: config.ingredients.ToArray()
        );
    }

    #endregion

    #region MissionNode Mappers

    public static LanguageBase ToMissionLanguage(this MissionNodeConfig config)
    {
        return new LanguageBase(config.title, config.description);
    }

    public static MissionNode ToRuntimeMissionNode(this MissionNodeConfig config)
    {
        var missionNode = ScriptableObject.CreateInstance<MissionNode>();
        missionNode.name = config.label;
        missionNode.label = config.label;
        missionNode.missionFailedAction = MissionFailedAction.None;
        missionNode.missionType = config.missionType;

        switch (config.missionType)
        {
            case SchedulerType.Kitsuna: // ignore typo
                missionNode.rewards = new Il2CppReferenceArray<Reward>(config.rewards.Count);
                for (int i = 0; i < config.rewards.Count; i++)
                {
                    missionNode.rewards[i] = config.rewards[i].ToRuntimeReward();
                }
                missionNode.finishCondition = new Il2CppReferenceArray<FinishCondition>(config.finishConditions.Count);
                for (int i = 0; i < config.finishConditions.Count; i++)
                {
                    missionNode.finishCondition[i] = config.finishConditions[i].ToRuntimeFinishCondition();
                }
                break;
            default:
                Log.Error($"Unsupported mission type {config.missionType} in MissionNode {config.label}");
                break;
        }

        missionNode.sender = config.sender;
        missionNode.hasSender = !string.IsNullOrEmpty(config.sender);
        missionNode.reciever = config.reciever; // ignore typo
        missionNode.hasReciever = !string.IsNullOrEmpty(config.reciever); // ignore typo

        missionNode.missionFinishEvent = config.missionFinishEvent.ToRuntimeEventData(config.debugLabel);

        missionNode.postMissionsAfterPerformance = new Il2CppStringArray(config.postMissionsAfterPerformance.Count);
        for (int i = 0; i < config.postMissionsAfterPerformance.Count; i++)
        {
            missionNode.postMissionsAfterPerformance[i] = config.postMissionsAfterPerformance[i];
        }

        missionNode.postEvents = new Il2CppStringArray(config.postEvents.Count);
        for (int i = 0; i < config.postEvents.Count; i++)
        {
            missionNode.postEvents[i] = config.postEvents[i];
        }

        return missionNode;
    }

    public static Reward ToRuntimeReward(this MissionRewardConfig config)
    {
        var reward = new Reward();
        reward.rewardType = config.rewardType;

        switch (config.rewardType)
        {
            case SchedulerNode.Reward.RewardType.UpgradeKizunaLevel:
                reward.rewardId = config.rewardId;
                break;
            case SchedulerNode.Reward.RewardType.GiveItem:
                if (!config.objectType.HasValue)
                {
                    Log.Error($"Missing objectType for GiveItem reward in MissionRewardConfig");
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

    public static FinishCondition ToRuntimeFinishCondition(this MissionFinishConditionConfig config)
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
                break;
            default:
                break;
        }

        return condition;
    }

    #endregion

    #region EventNode Mappers

    public static EventNode ToRuntimeEventNode(this EventNodeConfig config)
    {
        var eventNode = ScriptableObject.CreateInstance<EventNode>();
        eventNode.name = config.label;
        eventNode.label = config.label;
        eventNode.debugLabel = config.debugLabel;

        eventNode.scheduledEvent = config.scheduledEvent.ToRuntimeScheduledEvent(config.debugLabel);

        if (config.rewards != null)
        {
            eventNode.rewards = new Il2CppReferenceArray<Reward>(config.rewards.Count);
            for (int i = 0; i < config.rewards.Count; i++)
            {
                eventNode.rewards[i] = config.rewards[i].ToRuntimeReward();
            }
        }

        if (config.postRewards != null)
        {
            eventNode.postRewards = new Il2CppReferenceArray<Reward>(config.postRewards.Count);
            for (int i = 0; i < config.postRewards.Count; i++)
            {
                eventNode.postRewards[i] = config.postRewards[i].ToRuntimeReward();
            }
        }

        eventNode.postMissionsAfterPerformance = new Il2CppStringArray(config.postMissionsAfterPerformance.Count);
        for (int i = 0; i < config.postMissionsAfterPerformance.Count; i++)
        {
            eventNode.postMissionsAfterPerformance[i] = config.postMissionsAfterPerformance[i];
        }

        eventNode.postEvents = new Il2CppStringArray(config.postEvents.Count);
        for (int i = 0; i < config.postEvents.Count; i++)
        {
            eventNode.postEvents[i] = config.postEvents[i];
        }

        return eventNode;
    }

    public static SchedulerNode.ScheduledEvent ToRuntimeScheduledEvent(this ScheduledEventConfig config, string debugLabel = "")
    {
        if (config == null) return new SchedulerNode.ScheduledEvent();

        return new SchedulerNode.ScheduledEvent()
        {
            trigger = config.trigger.ToRuntimeTrigger(debugLabel),
            eventData = config.eventData.ToRuntimeEventData(debugLabel),
        };
    }

    public static SchedulerNode.Trigger ToRuntimeTrigger(this TriggerConfig config, string debugLabel)
    {
        if (config == null) return new SchedulerNode.Trigger();

        var trigger = new SchedulerNode.Trigger();
        trigger.triggerType = config.triggerType;

        switch (config.triggerType)
        {
            case TriggerType.KizunaCheckPoint:
                trigger.triggerId = config.triggerId;
                break;
            default:
                Log.Error($"Unsupported event trigger type {config.triggerType} in EventNode {debugLabel}");
                break;
        }
        return trigger;
    }

    public static SchedulerNode.Event ToRuntimeEventData(this EventDataConfig config, string debugLabel = "")
    {
        if (config == null) return new SchedulerNode.Event();

        switch (config.eventType)
        {
            case SchedulerNode.Event.EventType.Null:
                return new SchedulerNode.Event()
                {
                    eventType = config.eventType
                };
            case SchedulerNode.Event.EventType.Dialog:
                if (!ResourceExManager.ExistsDialogPackage(config.dialogPackageName))
                {
                    Log.Error($"Dialog package {config.dialogPackageName} not found in EventNode {debugLabel}");
                    return null;
                }

                var builtPackage = ResourceExManager.GetBuiltDialogPackage(config.dialogPackageName);
                return new SchedulerNode.Event()
                {
                    eventType = config.eventType,
                    runtimeDialogPackage = builtPackage
                };
            default:
                Log.Error($"Unsupported event type {config.eventType} in EventNode {debugLabel}");
                return null;
        }
    }

    #endregion

    #region SpecialGuest Mappers

    public static SpecialGuest ToRuntimeSpecialGuest(this CharacterConfig config, SpecialGuest template)
    {
        if (config.guest == null) return null;

        var likeFoodTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            config.guest.likeFoodTag.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray());

        var likeBevTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            config.guest.likeBevTag.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray());

        var hateTags = config.guest.hateFoodTag.ToArray();

        var specialGuest = new SpecialGuest(
            config.id,
            config.label,
            new Vector2Int(config.guest.fundRangeLower, config.guest.fundRangeUpper),
            hateTags,
            likeFoodTag,
            likeBevTag,
            template.Reaction, template.destination, template.CommisionAreaLabel,
            template.characterKizunaLevel1Welcome, template.characterKizunaLevel2Welcome, template.characterKizunaLevel3Welcome, template.characterKizunaLevel4Welcome, template.characterKizunaLevel5Welcome,
            template.characterKizunaLevel1ChatData, template.characterKizunaLevel2ChatData, template.characterKizunaLevel3ChatData, template.characterKizunaLevel4ChatData, template.characterKizunaLevel5ChatData,
            template.characterKizunaLevel2InviteSucceed, template.characterKizunaLevel2InviteFailed, template.characterKizunaLevel3InviteSucceed, template.characterKizunaLevel3InviteFailed, template.characterKizunaLevel4InviteSucceed, template.characterKizunaLevel4InviteFailed, template.characterKizunaLevel5InviteSucceed,
            template.characterKizunaLevel3RequestIngerdient, template.characterKizunaLevel4RequestIngerdient, template.characterKizunaLevel5RequestIngerdient,
            template.characterKizunaLevel4RequestBeverage, template.characterKizunaLevel5RequestBeverage,
            template.characterKizunaLevel5Commision, template.characterKizunaLevel5CommisionFinish,
            template.hideInAlbum, template.IsParticular, template.IsCollabCharacter, template.SpawnType, template.unifiedSpawnExclusion, template.unifiedSpawnWhereAfterEventOrMission, template.unifiedSpawnProb, template.m_SpecialGuestExtraDialogDataAsset, template.doNotShowInNightByDefault, template.doNotShowInChallenge, template.guestFoodEasterEggData
        );

        specialGuest.stringId = config.label;
        return specialGuest;
    }

    #endregion
}

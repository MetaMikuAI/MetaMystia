using System.Collections.Generic;
using System.Linq;
using Common.DialogUtility;
using GameData.CoreLanguage.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using GameData.Core.Collections.DaySceneUtility.Collections;
using UnityEngine;

using DEYU.Utils;
using MetaMiku;
using MetaMystia.ResourceEx.Models;

namespace MetaMystia;

/*
Register of Injection:

Before MainScene:
    SpecialGuestGroup(SpawnInfo) -> GameData.Core.Collections.DataBaseCore
    SpecialGuest -> GameData.Core.Collections.CharacterUtility.DataBaseCharacter
    FoodRequest -> GameData.Core.Collections.DaySceneUtility.DataBaseLanguage
    NPC -> GameData.Core.Collections.DaySceneUtility.DataBaseDay

Before NightScene:
    evaluation -> GameData.CoreLanguage.Collections.NightSceneLanguage
    conversation -> GameData.CoreLanguage.Collections.NightSceneLanguage

Hook:

    GetPortraitSprite <- DialogPannel.GetSpeakerVisual
    GetPortraitSprite <- SpecialGuestDescriber.Describe
*/

public static partial class ResourceExManager
{
    public static void RegisterSpecialPortraits()
    {
        Log.LogInfo($"Injecting Special Portraits from ResourceEx...");
        
        foreach (var charConfig in GetAllCharacterConfigs().Where(c => c.portraits != null && c.portraits.Count > 0))
        {
            string desc1 = charConfig.descriptions.Count > 0 ? charConfig.descriptions[0] : "";
            string desc2 = charConfig.descriptions.Count > 1 ? charConfig.descriptions[1] : "";
            string desc3 = charConfig.descriptions.Count > 2 ? charConfig.descriptions[2] : "";

            var val = new Il2CppSystem.ValueTuple<string, string, string, string>(
                charConfig.name,
                desc1,
                desc2,
                desc3);

            var identity = SpeakerIdentity.Identity.Unknown;
            if (!string.IsNullOrEmpty(charConfig.type) && System.Enum.TryParse<SpeakerIdentity.Identity>(charConfig.type, true, out var idt))
            {
                identity = idt;
            }

            if (identity == SpeakerIdentity.Identity.Special)
            {
                DataBaseLanguage.SpecialGuest.ForceAddOrUpdateValueTuple(charConfig.id, val);
                Log.LogInfo($"Injected Special character: {charConfig.name} ({charConfig.id})");
            }
            else if (identity == SpeakerIdentity.Identity.Normal)
            {
                Log.LogInfo($"Normal character detected but injection not yet implemented: {charConfig.name} ({charConfig.id})");
            }
            else if (identity == SpeakerIdentity.Identity.Self)
            {
                Log.LogInfo($"Self character detected: {charConfig.name} ({charConfig.id})");
            }
            else
            {
                Log.LogWarning($"Unknown character type for {charConfig.name} ({charConfig.id}): {charConfig.type}");
            }
        }
    }

    public static void RegisterAllSpecialGuests()
    {
        Log.LogInfo($"Injecting Special Guests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterSpecialGuest);
    }

    private static void RegisterSpecialGuest(CharacterConfig config)
    {
        if (config.guest == null) return;

        var specialGuests = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.SpecialGuest;
        if (specialGuests == null || specialGuests.Count == 0)
        {
            Log.LogError($"DataBaseCharacter.SpecialGuest is null or empty!");
            return;
        }

        var likeFoodTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            config.guest.likeFoodTag.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray());

        var likeBevTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            config.guest.likeBevTag.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray());

        var hateTags = config.guest.hateFoodTag.ToArray();

        var template = specialGuests[0];

        var specialGuest = new SpecialGuest(
            config.id,
            config.label,
            new Vector2Int(config.guest.fundRangeLower, config.guest.fundRangeUpper),
            hateTags,
            likeFoodTag,
            likeBevTag,
            template.Reaction, template.Destination, template.CommisionAreaLabel,
            template.characterKizunaLevel1Welcome, template.characterKizunaLevel2Welcome, template.characterKizunaLevel3Welcome, template.characterKizunaLevel4Welcome, template.characterKizunaLevel5Welcome,
            template.characterKizunaLevel1ChatData, template.characterKizunaLevel2ChatData, template.characterKizunaLevel3ChatData, template.characterKizunaLevel4ChatData, template.characterKizunaLevel5ChatData,
            template.characterKizunaLevel2InviteSucceed, template.characterKizunaLevel2InviteFailed, template.characterKizunaLevel3InviteSucceed, template.characterKizunaLevel3InviteFailed, template.characterKizunaLevel4InviteSucceed, template.characterKizunaLevel4InviteFailed, template.characterKizunaLevel5InviteSucceed,
            template.characterKizunaLevel3RequestIngerdient, template.characterKizunaLevel4RequestIngerdient, template.characterKizunaLevel5RequestIngerdient,
            template.characterKizunaLevel4RequestBeverage, template.characterKizunaLevel5RequestBeverage,
            template.characterKizunaLevel5Commision, template.characterKizunaLevel5CommisionFinish,
            template.hideInAlbum, template.IsParticular, template.IsCollabCharacter, template.SpawnType, template.unifiedSpawnExclusion, template.unifiedSpawnWhereAfterEventOrMission, template.unifiedSpawnProb, template.m_SpecialGuestExtraDialogDataAsset, template.doNotShowInNightByDefault, template.doNotShowInChallenge, template.guestFoodEasterEggData
        );

        specialGuest.stringId = config.label;
        specialGuests[config.id] = specialGuest;
        Log.LogInfo($"Injected Special Guest: {config.name} ({config.id})");

        DataBaseDayPatch.NPCsToRegister.TryAdd(config.label, new NPC(specialGuest)); // TODO
        Log.LogInfo($"Prepared Delay Load NPC for Special Guest: {config.name} ({config.id})");
    }

    public static void RegisterAllEvaluations()
    {
        Log.LogInfo($"Injecting Special Guest Evaluations and Conversations from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.evaluation != null)
            .ToList()
            .ForEach(RegisterEvaluation);
    }

    private static void RegisterEvaluation(CharacterConfig config)
    {
        NightSceneLanguage.SpecialEvaluation[config.id] = new Il2CppStringArray(config.guest.evaluation.ToArray());
        Log.LogInfo($"Registered Special Guest Evaluation: {config.name} ({config.id})");
    }

    public static void RegisterAllConversations()
    {
        Log.LogInfo($"Injecting Special Guest Evaluations and Conversations from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.conversation != null)
            .ToList()
            .ForEach(RegisterConversation);
    }

    public static void RegisterConversation(CharacterConfig config)
    {
        if (config.guest == null || config.guest.conversation == null) return;
        NightSceneLanguage.SpecialConversation[config.id] = config.guest.conversation
            .Select(c => new UnityEngineExtensionStatic.StructPtr<string>(c))
            .ToArray();
        Log.LogInfo($"Injected Special Guest Conversation: {config.name} ({config.id})");
    }


    public static void RegisterAllFoodRequests()
    {
        Log.LogInfo($"Injecting Food Requests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.foodRequests != null)
            .ToList()
            .ForEach(RegisterFoodRequests);
    }

    private static void RegisterFoodRequests(CharacterConfig config)
    {
        DataBaseLanguagePatch.FoodRequestsToRegister[config.id] = config.guest.foodRequests.ToDictionary(req => req.tagId, req => req.request);
        Log.LogInfo($"Injected Food Requests for Special Guest: {config.name} ({config.id})");
    }



    public static void RegisterNPCs()
    {
        Log.LogInfo($"Registering NPCs from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterNPC);
    }

    private static void RegisterNPC(CharacterConfig config)
    {
        var specialGuests = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.SpecialGuest;
        var specialGuest = specialGuests[config.id];
        var npc = new NPC(specialGuest);
        DataBaseDayPatch.NPCsToRegister[config.label] = npc;
        Log.LogInfo($"Prepared Delay Load NPC for Special Guest: {config.name} ({config.id})");
    }

    public static void RegisterAllSpawnConfigs()
    {
        Log.LogInfo($"Injecting Spawn Configs from ResourceEx...");

        var spawnGroups = GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.spawn != null)
            .SelectMany(c => c.guest.spawn.Select(s => new { Character = c, Spawn = s }))
            .GroupBy(x => x.Spawn.izakayaId);

        foreach (var group in spawnGroups)
        {
            int izakayaId = group.Key;
            if (!GameData.Core.Collections.DataBaseCore.Izakayas.TryGetValue(izakayaId, out var izakaya) || izakaya == null)
            {
                Log.LogError($"Izakaya with ID {izakayaId} not found or null.");
                continue;
            }

            var newGroups = group
                .Where(x => izakaya.SpecialGuestPool == null || !izakaya.SpecialGuestPool.Any(p => p.GroupId == x.Character.id))
                .Select(x => new GameData.Core.Collections.Izakaya.SpecialGuestGroup(
                    x.Character.id,
                    x.Spawn.relativeProb,
                    x.Spawn.onlySpawnAfterUnlocking,
                    x.Spawn.onlySpawnWhenPlaceBeRecorded
                ))
                .ToList();

            if (newGroups.Count == 0) continue;

            izakaya.SpecialGuestPool = (izakaya.SpecialGuestPool ?? new GameData.Core.Collections.Izakaya.SpecialGuestGroup[0])
                .Concat(newGroups)
                .ToArray();

            newGroups.ForEach(g => Log.LogInfo($"Injected Spawn Config for GroupId {g.GroupId} in Izakaya {izakayaId}"));
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Common.DialogUtility;
using GameData.CoreLanguage.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using GameData.Core.Collections.DaySceneUtility.Collections;
using UnityEngine;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility;

using DEYU.Utils;
using GameData.Profile;
using MetaMiku;
using SgrYuki.Utils;
using MetaMystia.ResourceEx.Models;

namespace MetaMystia;

/*
Register of Injection:

Before MainScene:
    SpecialGuestGroup(SpawnInfo) -> GameData.Core.Collections.DataBaseCore
    SpecialGuest -> GameData.Core.Collections.CharacterUtility.DataBaseCharacter
    GuestProfilePair -> GameData.Core.Collections.CharacterUtility.DataBaseCharacter
    FoodRequest -> GameData.Core.Collections.DaySceneUtility.DataBaseLanguage
    NPC -> GameData.Core.Collections.DaySceneUtility.DataBaseDay

Before NightScene:
    evaluation -> GameData.CoreLanguage.Collections.NightSceneLanguage
    conversation -> GameData.CoreLanguage.Collections.NightSceneLanguage

Hook:
    GetPortraitSprite <- DialogPannel.GetSpeakerVisual
    GetPortraitSprite <- SpecialGuestDescriber.Describe

TODO: 
    implement GuestProfilePair totally from ResourceEx, currently only partial implementation.
*/

public static partial class ResourceExManager
{
    public static void RegisterSpecialPortraits()
    {
        Log.Info($"Injecting Special Portraits from ResourceEx...");
        
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
                Log.Info($"Injected Special character: {charConfig.name} ({charConfig.id})");
            }
            else if (identity == SpeakerIdentity.Identity.Normal)
            {
                Log.Info($"Normal character detected but injection not yet implemented: {charConfig.name} ({charConfig.id})");
            }
            else if (identity == SpeakerIdentity.Identity.Self)
            {
                Log.Info($"Self character detected: {charConfig.name} ({charConfig.id})");
            }
            else
            {
                Log.Warning($"Unknown character type for {charConfig.name} ({charConfig.id}): {charConfig.type}");
            }
        }
    }

    public static void RegisterAllSpecialGuests()
    {
        Log.Info($"Injecting Special Guests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterSpecialGuest);
    }

    private static void RegisterSpecialGuest(CharacterConfig config)
    {
        if (config.guest == null) return;

        var specialGuests = DataBaseCharacter.SpecialGuest;
        if (specialGuests == null || specialGuests.Count == 0)
        {
            Log.Error($"DataBaseCharacter.SpecialGuest is null or empty!");
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
        Log.Info($"Injected Special Guest: {config.name} ({config.id})");
    }

    public static void RegisterAllEvaluations()
    {
        Log.Info($"Injecting Special Guest Evaluations and Conversations from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.evaluation != null)
            .ToList()
            .ForEach(RegisterEvaluation);
    }

    private static void RegisterEvaluation(CharacterConfig config)
    {
        NightSceneLanguage.SpecialEvaluation[config.id] = new Il2CppStringArray(config.guest.evaluation.ToArray());
        Log.Info($"Registered Special Guest Evaluation: {config.name} ({config.id})");
    }

    public static void RegisterAllConversations()
    {
        Log.Info($"Injecting Special Guest Evaluations and Conversations from ResourceEx...");
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
        Log.Info($"Injected Special Guest Conversation: {config.name} ({config.id})");
    }


    public static void RegisterAllFoodRequests()
    {
        Log.Info($"Injecting Food Requests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.foodRequests != null)
            .ToList()
            .ForEach(RegisterFoodRequests);
    }

    private static void RegisterFoodRequests(CharacterConfig config)
    {
        DataBaseLanguage.SpecialGuestFoodRequest.TryAdd(config.id,
            config.guest.foodRequests.ToDictionary(req => req.tagId, req => req.request).ToIl2CppDictionary());
        Log.Info($"Injected Food Requests for Special Guest: {config.name} ({config.id})");
    }
    
    public static void RegisterAllBevRequests()
    {
        Log.Info($"Injecting Food Requests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.bevRequests != null)
            .ToList()
            .ForEach(RegisterBevRequests);
    }

    private static void RegisterBevRequests(CharacterConfig config)
    {
        DataBaseLanguage.SpecialGuestBevRequest.TryAdd(config.id,
            config.guest.bevRequests.ToDictionary(req => req.tagId, req => req.request).ToIl2CppDictionary());
        Log.Info($"Injected Beverage Requests for Special Guest: {config.name} ({config.id})");
    }

    public static void RegisterAllSpecialGuestPairs()
    {
        Log.Info($"Registering Special Guest Pairs from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterSpecialGuestPair);
    }

    private static void RegisterSpecialGuestPair(CharacterConfig config)
    {
        var dummyPortrayalSet = ScriptableObject.CreateInstance<CharacterProtrayalSet>();
        var dummyPortrayal = ScriptableObject.CreateInstance<CharacterPortrayal>();
        dummyPortrayalSet.defaultPortrayal = dummyPortrayal;
        RegisterSpecialGuestPortrayal(dummyPortrayal, config);

        var pixelSet = ScriptableObject.CreateInstance<CharacterSkinSets>();
        pixelSet.defaultSkin = MakePixel(config.characterSpriteSetCompact, config.ModRoot);

        dummyPortrayal.name = $"{config.name}_DummyPortrayal";
        var pair = new GuestProfilePair(
            id: config.id,
            bgColor: DataBaseCharacter.UnifiedNormalGuestBGColor,
            textColor: DataBaseCharacter.UnifiedNormalGuestTextColor,
            characterPortrayal: dummyPortrayalSet,
            characterPixel: pixelSet
        );
        if (DataBaseCharacter.SpecialGuestVisual.TryAdd(config.id, pair))
        {
            Log.Info($"Registered SpecialGuestPair for Special Guest: {config.name} ({config.id})");
        }
        else
        {
            Log.Warning($"SpecialGuestPair for Special Guest: {config.name} ({config.id}) already exists");
        }

        return;

        static CharacterSpriteSetCompact MakePixel(CharacterSpriteSetCompactConfig pixelConfig, string modRoot)
        {
            var template = DataBaseCharacter.FallbackCompactPixel;

            var pixel = ScriptableObject.CreateInstance<CharacterSpriteSetCompact>();

            var mainSprites = CopySpriteArray(template.MainSprite);
            var eyeSprites = CopySpriteArray(template.EyeSprite);

            ApplySprites(mainSprites, pixelConfig.mainSprite, modRoot);
            ApplySprites(eyeSprites, pixelConfig.eyeSprite, modRoot);

            pixel.Initialize(
                mainSprites,
                template.DoNotUseEyeSprite,
                eyeSprites,
                template.HasPrebakedShadow,
                template.AnimationSpeedMultiplier,
                template.ExtraYOffset,
                template.IsHina,
                template.RotatePerTime,
                template.DoNotHaveStepVFX,
                template.MoveSpeedMultiplier,
                template.RemovableTrims,
                template.TrimSpritesDisplayFront,
                template.TrimSpritesDisplayBack,
                template.TrimFrontSpriteFrameSpeed,
                template.TrimBackSpriteFrameSpeed
            );

            return pixel;


            static Il2CppReferenceArray<Sprite> CopySpriteArray(Il2CppReferenceArray<Sprite> source)
            {
                if (source == null) return null;
                var newArray = new Il2CppReferenceArray<Sprite>(source.Length);
                for (int i = 0; i < source.Length; i++)
                {
                    newArray[i] = source[i];
                }

                return newArray;
            }

            static void ApplySprites(Il2CppReferenceArray<Sprite> targetArray, List<string> spritePaths, string modRoot,
                int pixelOffsetX = 0, int pixelOffsetY = 0)
            {
                if (spritePaths == null) return;

                if (targetArray == null)
                {
                    Log.LogError($"Target array is null but sprite paths were provided. Cannot apply sprites.");
                    return;
                }

                if (spritePaths.Count != targetArray.Length)
                {
                    Log.LogError(
                        $"Sprite count mismatch! Expected {targetArray.Length}, got {spritePaths.Count}. Refusing to load sprites.");
                    return;
                }

                for (int i = 0; i < spritePaths.Count; i++)
                {
                    string path = spritePaths[i];
                    if (string.IsNullOrEmpty(path)) continue;

                    // Use GetSprite with caching, matching the parameters used for SpriteSetCompact
                    var sprite = GetSprite(path, modRoot, new Vector2(0.5f, 0.0f), 64, 64, pixelOffsetX, pixelOffsetY);

                    if (sprite != null)
                    {
                        targetArray[i] = sprite;
                    }
                }
            }

        }
    }

    public static void RegisterNPCs()
    {
        Log.Info($"Registering NPCs from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterNPC);
    }

    private static void RegisterNPC(CharacterConfig config)
    {
        var specialGuests = DataBaseCharacter.SpecialGuest;
        var specialGuest = specialGuests[config.id];
        var npc = new NPC(specialGuest);
        if (DataBaseDay.allNPCs.TryAdd(config.label, npc))
        {
            Log.Info($"Registered NPC for Special Guest: {config.name} ({config.id})");
        }
        else
        {
            Log.Warning($"NPC with label {config.label} already exists in DataBaseDay.allNPCs");
        }
    }

    public static void RegisterAllSpawnConfigs()
    {
        Log.Info($"Injecting Spawn Configs from ResourceEx...");

        var spawnGroups = GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.spawn != null)
            .SelectMany(c => c.guest.spawn.Select(s => new { Character = c, Spawn = s }))
            .GroupBy(x => x.Spawn.izakayaId);

        foreach (var group in spawnGroups)
        {
            int izakayaId = group.Key;
            if (!GameData.Core.Collections.DataBaseCore.Izakayas.TryGetValue(izakayaId, out var izakaya) || izakaya == null)
            {
                Log.Error($"Izakaya with ID {izakayaId} not found or null.");
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

            newGroups.ForEach(g => Log.Info($"Injected Spawn Config for GroupId {g.GroupId} in Izakaya {izakayaId}"));
        }
    }
}
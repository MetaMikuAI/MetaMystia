using System.Collections.Generic;
using System.Linq;
using Common.DialogUtility;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage.Collections;
using GameData.Profile;
using GameData.Core.Collections.DaySceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MetaMiku;
using MetaMystia.ResourceEx.Mappers;
using DayScene.Interactables;
using MetaMystia.ResourceEx.Models;
using SgrYuki.Utils;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

namespace MetaMystia;

/*
Register or Injection:

Before MainScene:
    SpecialGuestGroup(SpawnInfo) -> GameData.Core.Collections.DataBaseCore
    SpecialGuest -> GameData.Core.Collections.CharacterUtility.DataBaseCharacter
    GuestProfilePair -> GameData.Core.Collections.CharacterUtility.DataBaseCharacter
    FoodRequest -> GameData.Core.Collections.DaySceneUtility.DataBaseLanguage
    NPC -> GameData.Core.Collections.DaySceneUtility.DataBaseDay

Before NightScene:
    evaluation -> GameData.CoreLanguage.Collections.NightSceneLanguage
    conversation -> GameData.CoreLanguage.Collections.NightSceneLanguage

After DayScene Awake:
    MoveCharacter

Hook:
    GetPortraitSprite <- DialogPannel.GetSpeakerVisual
    GetPortraitSprite <- SpecialGuestDescriber.Describe

TODO:
    implement GuestProfilePair totally from ResourceEx, currently only partial implementation.
*/

public static partial class ResourceExManager
{
    public static IEnumerable<CharacterConfig> GetAllCharacterConfigs()
    {
        return _characterConfigs.Values;
    }
    public static bool IsResourceExSpecialGuest(this int id, string type = "Special") => _characterConfigs.ContainsKey((id, type));
    public static bool IsResourceExSpecialGuest(this string stringId, string type = "Special") => _characterConfigs.Values.Any(c => c.label == stringId && c.type == type);

    public static CharacterConfig GetCharacterConfig(int id, string type = "Special")
    {
        if (_characterConfigs.TryGetValue((id, type), out var config))
        {
            return config;
        }
        return null;
    }

    private static void RegisterSpecialPortraits()
    {
        Log.Info($"Registering Special Portraits from ResourceEx...");

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
                Log.Info($"Registered Special character: {charConfig.name} ({charConfig.id})");
            }
            else if (identity == SpeakerIdentity.Identity.Normal)
            {
                Log.Info($"Normal character detected but registration not yet implemented: {charConfig.name} ({charConfig.id})");
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

    private static void RegisterAllSpecialGuests()
    {
        Log.Info($"Registering Special Guests from ResourceEx...");
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

        var template = specialGuests[0];
        var specialGuest = config.ToSpecialGuest(template);

        if (specialGuest != null)
        {
            specialGuests[config.id] = specialGuest;
            Log.Info($"Registered Special Guest: {config.name} ({config.id})");
        }
    }

    private static void RegisterAllEvaluations()
    {
        Log.Info($"Registering Special Guest Evaluations from ResourceEx...");
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

    private static void RegisterAllConversations()
    {
        Log.Info($"Registering Special Guest Evaluations and Conversations from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.conversation != null)
            .ToList()
            .ForEach(RegisterConversation);
    }

    private static void RegisterConversation(CharacterConfig config)
    {
        if (config.guest == null || config.guest.conversation == null) return;
        NightSceneLanguage.SpecialConversation[config.id] = config.guest.conversation
            .Select(c => new UnityEngineExtensionStatic.StructPtr<string>(c))
            .ToArray();
        Log.Info($"Registered Special Guest Conversation: {config.name} ({config.id})");
    }


    private static void RegisterAllFoodRequests()
    {
        Log.Info($"Registering Food Requests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.foodRequests != null)
            .ToList()
            .ForEach(RegisterFoodRequests);
    }

    private static void RegisterFoodRequests(CharacterConfig config)
    {
        DataBaseLanguage.SpecialGuestFoodRequest.TryAdd(config.id,
            config.guest.foodRequests.ToDictionary(req => req.tagId, req => req.request).ToIl2CppDictionary());
        Log.Info($"Registered Food Requests for Special Guest: {config.name} ({config.id})");
    }

    private static void RegisterAllBevRequests()
    {
        Log.Info($"Registering Beverage Requests from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null && c.guest.bevRequests != null)
            .ToList()
            .ForEach(RegisterBevRequests);
    }

    private static void RegisterBevRequests(CharacterConfig config)
    {
        DataBaseLanguage.SpecialGuestBevRequest.TryAdd(config.id,
            config.guest.bevRequests.ToDictionary(req => req.tagId, req => req.request).ToIl2CppDictionary());
        Log.Info($"Registering Beverage Requests for Special Guest: {config.name} ({config.id})");
    }

    private static void RegisterAllSpecialGuestPairs()
    {
        Log.Info($"Registering Special Guest Pairs from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.characterSpriteSetCompact != null)
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
        pixelSet.defaultSkin = MakePixel(config.characterSpriteSetCompact, config.PackageRoot);

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

        static CharacterSpriteSetCompact MakePixel(CharacterSpriteSetCompactConfig pixelConfig, string packageRoot)
        {
            var template = DataBaseCharacter.FallbackCompactPixel;

            var pixel = ScriptableObject.CreateInstance<CharacterSpriteSetCompact>();

            var mainSprites = CopySpriteArray(template.MainSprite);
            var eyeSprites = CopySpriteArray(template.EyeSprite);

            ApplySprites(mainSprites, pixelConfig.mainSprite, packageRoot);
            ApplySprites(eyeSprites, pixelConfig.eyeSprite, packageRoot);

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

            static void ApplySprites(Il2CppReferenceArray<Sprite> targetArray, List<string> spritePaths, string packageRoot,
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
                    var sprite = ResourceExManager.GetSprite(path, packageRoot, new Vector2(0.5f, 0.0f), 64, 64, pixelOffsetX, pixelOffsetY);

                    if (sprite != null)
                    {
                        targetArray[i] = sprite;
                    }
                }
            }

        }
    }

    private static void RegisterNPCs()
    {
        Log.Info($"Registering NPCs from ResourceEx...");
        GetAllCharacterConfigs()
            .Where(c => c.guest != null)
            .ToList()
            .ForEach(RegisterNPC);
    }

    private static void RegisterNPC(CharacterConfig config)
    {
        // TODO: 值类型 NPC 由于 il2cppInterop 缺陷无法成功插入

        // var specialGuests = DataBaseCharacter.SpecialGuest;
        // var specialGuest = specialGuests[config.id];
        // var npc = new NPC(specialGuest);

        // Important: some loading-time code paths rely on DataBaseCharacter string<->identity mappings.
        // If we only add to DataBaseDay.allNPCs but do not register the mapping, the game may crash
        // during early initialization when resolving NPC visuals/identity.
        // EnsureNpcStringIdentityMapping(config.label, new SchedulerNode.Character(SceneDirector.Identity.Special, config.id));

        // var dict = typeof(DataBaseDay).GetProperty("allNPCs").GetValue(null);
        // dict.GetType().GetProperty("Item").SetValue(dict, npc, new object[] { config.label });
        // DataBaseDay.AllMappedNPCsMapping[config.label] = "ResourceEx";
        // Log.Warning($"Registered NPC for Special Guest: {config.name} ({config.id})");
        // var npc_ = DataBaseDay.allNPCs[config.label];
        // Log.Warning($"NPC expected: {npc.identity.characterIdentity} - {npc.identity.characterId}");
        // Log.Warning($"NPC actual: {npc_.identity.characterIdentity} - {npc_.identity.characterId}");

        // if (DataBaseDay.allNPCs.TryAdd(config.label, npc))
        // {
        //     Log.Info($"Registered NPC for Special Guest: {config.name} ({config.id})");
        // }
        // else
        // {
        //     Log.Warning($"NPC with label {config.label} already exists in DataBaseDay.allNPCs");
        // }
    }


    private static void RegisterAllSpawnMarkers()
    {
        Log.Info($"Registering Spawn Markers from ResourceEx...");
        GetAllCharacterConfigs()
            .Select(c => c.spawnMarker ?? new SpawnMarkerConfig() { mapLabel = "BeastForest", x = 0f, y = 0f, rotation = DayScene.Input.DayScenePlayerInputGenerator.CharacterRotation.Down })
            .ToList()
            .ForEach(RegisterSpawnMarker);
    }

    private static void RegisterSpawnMarker(SpawnMarkerConfig config)
    {
        var mapLabel = DataBaseDay.allSpawnMarkerLabels.ContainsKey(config.mapLabel) ? config.mapLabel : "BeastForest";
        DataBaseDay.allSpawnMarkerLabels[mapLabel].Add(config.mapLabel);
        Log.Info($"Registered Spawn Marker for map: {config.mapLabel}");
    }

    public static SpawnMarkerConfig GetSpawnMarkerConfig(this string stringId) =>
        GetAllCharacterConfigs()
            .FirstOrDefault(c => c.label == stringId)
            ?.spawnMarker
            ?? new SpawnMarkerConfig()
            {
                mapLabel = "BeastForest",
                x = 0f,
                y = 0f,
                rotation = DayScene.Input.DayScenePlayerInputGenerator.CharacterRotation.Down
            };




    private static void InitializeAllDaySpawnConfigs()
    {
        GetAllCharacterConfigs()
            .Where(c => c.spawnMarker != null)
            .ToList()
            .ForEach(InitializeDaySpawnConfig);
    }

    private static void InitializeDaySpawnConfig(CharacterConfig config)
    {
        // TODO: 实现更合适的白天生成配置
        if (config.spawnMarker == null) return;
        GameData.RunTime.DaySceneUtility.RunTimeDayScene.MoveCharacter(config.label, config.spawnMarker.mapLabel, new Vector2(config.spawnMarker.x, config.spawnMarker.y), (int)config.spawnMarker.rotation, out var oldNPCData);
        GameData.RunTime.DaySceneUtility.RunTimeDayScene.ReturnCharacter(config.label);
        Log.Info($"Initialized Day Scene Spawn Config for Special Guest: {config.name} ({config.id})");
    }


    private static void RegisterAllSpawnConfigs()
    {
        Log.Info($"Registering Spawn Configs from ResourceEx...");

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

            newGroups.ForEach(g => Log.Info($"Registered Spawn Config for GroupId {g.GroupId} in Izakaya {izakayaId}"));
        }
    }
}

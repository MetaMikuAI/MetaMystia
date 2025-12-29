using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BepInEx;
using Common.DialogUtility;
using GameData.CoreLanguage.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using GameData.Core.Collections.CharacterUtility;
using UnityEngine;
using HarmonyLib;
using System.Linq;
using GameData.Core.Collections.DaySceneUtility.Collections;

using MetaMiku;

namespace MetaMystia;


// TODO: 切分文件
// Optimize & TODO: use Linq
// IMPORTANT & TODO: 将各个主动注入改为各个 DataBaseXXX Initialize 的 Postfix 注册


public class CharacterConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string label { get; set; }
    public List<string> descriptions { get; set; }
    public string type { get; set; }
    public List<PortraitConfig> portraits { get; set; }
    public GuestConfig guest { get; set; }
    public CharacterSpriteSetCompactConfig characterSpriteSetCompact { get; set; }
    public string ModRoot { get; set; }
}

public class GuestConfig
{
    public int fundRangeLower { get; set; }
    public int fundRangeUpper { get; set; }
    public List<string> evaluation { get; set; }
    public List<string> conversation { get; set; }
    public List<FoodRequestConfig> foodRequests { get; set; }
    public List<int> hateFoodTag { get; set; }
    public List<WeightedTagConfig> likeFoodTag { get; set; }
    public List<WeightedTagConfig> likeBevTag { get; set; }
    public List<SpawnConfig> spawn { get; set; }
}

public class SpawnConfig
{
    public int izakayaId { get; set; }
    public float relativeProb { get; set; }
    public bool onlySpawnAfterUnlocking { get; set; }
    public bool onlySpawnWhenPlaceBeRecorded { get; set; }
}

public class FoodRequestConfig
{
    public int tagId { get; set; }
    public string request { get; set; }
}

public class WeightedTagConfig
{
    public int tagId { get; set; }
    public int weight { get; set; }
}

public class CharacterSpriteSetCompactConfig
{
    public string name { get; set; }
    public List<string> mainSprite { get; set; }
    public List<string> eyeSprite { get; set; }
}

public class PortraitConfig
{
    public int pid { get; set; }
    public string path { get; set; }
}

public class ResourceConfig
{
    public List<CharacterConfig> characters { get; set; }
    public List<DialogPackageConfig> dialogPackages { get; set; }
}

public class DialogConfig
{
    public int characterId { get; set; }
    public string characterType { get; set; }
    public int pid { get; set; }
    public string position { get; set; }
    public string text { get; set; }
}

public class DialogPackageConfig
{
    public string name { get; set; }
    public List<DialogConfig> dialogList { get; set; }
}

[AutoLog]
public static partial class ResourceExManager
{
    // Abstracted resource root path
    public static string ResourceRoot { get; set; } = Path.Combine(Paths.GameRootPath, "ResourceEx");
    
    public static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
    public static Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();
    private static Dictionary<string, CustomDialogList> _dialogPackages = new Dictionary<string, CustomDialogList>();
    public static readonly string DialogPackageNamePrefix = "_";

    public static void Initialize()
    {
        LoadConfigs();
    }

    private static void LoadConfigs()
    {
        if (!Directory.Exists(ResourceRoot))
        {
            Directory.CreateDirectory(ResourceRoot);
            Log.LogInfo($"Created ResourceEx directory at {ResourceRoot}");
            return;
        }

        var modDirs = Directory.GetDirectories(ResourceRoot);
        foreach (var modDir in modDirs)
        {
            string modName = Path.GetFileName(modDir);
            string jsonPath = Path.Combine(modDir, "ResourceEx.json");

            if (!File.Exists(jsonPath))
            {
                continue;
            }

            Log.LogInfo($"Loading mod: {modName} from {jsonPath}");
            try
            {
                string jsonString = File.ReadAllText(jsonPath);
                var config = JsonSerializer.Deserialize<ResourceConfig>(jsonString);
                
                if (config?.characters != null)
                {
                    foreach (var charConfig in config.characters)
                    {
                        charConfig.ModRoot = modDir;
                        _characterConfigs[(charConfig.id, charConfig.type)] = charConfig;
                        Log.LogInfo($"[{modName}] Loaded config for character {charConfig.name} ({charConfig.id}, {charConfig.type})");
                    }
                }

                if (config?.dialogPackages != null)
                {
                    foreach (var pkgConfig in config.dialogPackages)
                    {
                        var dialogList = new CustomDialogList();
                        dialogList.packageName = DialogPackageNamePrefix + pkgConfig.name;
                        foreach (var d in pkgConfig.dialogList)
                        {
                            var speakerType = SpeakerIdentity.Identity.Unknown;
                            if (!string.IsNullOrEmpty(d.characterType) && System.Enum.TryParse<SpeakerIdentity.Identity>(d.characterType, true, out var st))
                            {
                                speakerType = st;
                            }

                            var position = Position.Left;
                            if (System.Enum.TryParse<Position>(d.position, out var pos))
                            {
                                position = pos;
                            }

                            dialogList.AddDialog(d.characterId, speakerType, d.pid, position, d.text);
                        }
                        _dialogPackages[pkgConfig.name] = dialogList;
                        Log.LogInfo($"[{modName}] Loaded dialog package: {pkgConfig.name}");
                    }
                }
            }
            catch (System.Exception e)
            {
                Log.LogError($"Failed to load mod {modName}: {e.Message}");
            }
        }
    }

    public static CustomDialogList GetDialogPackage(string name)
    {
        if (_dialogPackages.TryGetValue(name, out var pkg))
        {
            return pkg;
        }
        return null;
    }

    public static Sprite GetSprite(string relativePath, string modRoot = null, Vector2? pivot = null, int width = 0, int height = 0, int pixelOffsetX = 0, int pixelOffsetY = 0)
    {
        if (string.IsNullOrEmpty(relativePath)) 
        {
            Log.LogWarning($"GetSprite called with empty relativePath.");
            return null;
        }

        string fullPath = string.IsNullOrEmpty(modRoot) 
            ? Path.Combine(ResourceRoot, relativePath) 
            : Path.Combine(modRoot, relativePath);

        Vector2 actualPivot = pivot ?? new Vector2(0.5f, 0.5f);
        string cacheKey = $"{fullPath}_{actualPivot.x}_{actualPivot.y}_{width}_{height}_{pixelOffsetX}_{pixelOffsetY}";

        if (_spriteCache.TryGetValue(cacheKey, out var sprite))
        {
            return sprite;
        }

        Log.LogInfo($"Loading sprite at {fullPath}");
        sprite = Utils.GetArtWork(fullPath, actualPivot, width, height, pixelOffsetX, pixelOffsetY);
        if (sprite != null)
        {
            sprite.hideFlags = HideFlags.HideAndDontSave;
            if (sprite.texture != null)
            {
                sprite.texture.hideFlags = HideFlags.HideAndDontSave;
            }
            _spriteCache[cacheKey] = sprite;
        }
        else
        {
            Log.LogWarning($"Failed to load sprite at {fullPath}");
        }
        return sprite;
    }
    
    public static IEnumerable<CharacterConfig> GetAllCharacters()
    {
        return _characterConfigs.Values;
    }
    
    public static CharacterConfig GetCharacterConfig(int id, string type)
    {
        if (_characterConfigs.TryGetValue((id, type), out var config))
        {
            return config;
        }
        return null;
    }

    public static bool ExistsCharacterConfig(int id, string type = "Special")
    {
        return _characterConfigs.ContainsKey((id, type));
    }

    public static void TryInjectSpecialPortraits()
    {
        Log.LogInfo($"Injecting Special Portraits from ResourceEx...");
        
        foreach (var charConfig in GetAllCharacters())
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

    public static void TryInjectAllSpecialGuests()
    {
        Log.LogInfo($"Injecting Special Guests from ResourceEx...");
        foreach (var charConfig in GetAllCharacters())
        {
            if (charConfig.guest != null)
            {
                Log.LogInfo($"Injecting Special Guest for character: {charConfig.id} ({charConfig.name})");
                TryInjectSpecialGuest(charConfig);
            }
        }
    }

    public static void TryInjectAllSpecialGuestEvaluations()
    {
        Log.LogInfo($"Injecting Special Guest Evaluations and Conversations from ResourceEx...");
        foreach (var charConfig in GetAllCharacters())
        {
            if (charConfig.guest != null)
            {
                Log.LogInfo($"Injecting Special Guest Evaluation for character: {charConfig.id} ({charConfig.name})");
                TryInjectSpecialGuestEvaluation(charConfig);
                TryInjectSpecialGuestConversation(charConfig);
            }
        }
    }

    public static SpecialGuest specialGuest;
    public static void TryInjectSpecialGuest(CharacterConfig config)
    {
        if (config.guest == null) return;

        var specialGuests = GameData.Core.Collections.CharacterUtility.DataBaseCharacter.SpecialGuest;
        if (specialGuests == null || specialGuests.Count == 0)
        {
            Log.LogError($"DataBaseCharacter.SpecialGuest is null or empty!");
            return;
        }

        // Prepare tags
        var likeFoodTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(config.guest.likeFoodTag.Count);
        for (int i = 0; i < config.guest.likeFoodTag.Count; i++)
        {
            likeFoodTag[i] = new SpecialGuest.WeightedTag(config.guest.likeFoodTag[i].tagId, config.guest.likeFoodTag[i].weight);
        }

        var likeBevTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(config.guest.likeBevTag.Count);
        for (int i = 0; i < config.guest.likeBevTag.Count; i++)
        {
            likeBevTag[i] = new SpecialGuest.WeightedTag(config.guest.likeBevTag[i].tagId, config.guest.likeBevTag[i].weight);
        }

        var hateTags = new int[config.guest.hateFoodTag.Count];
        for (int i = 0; i < config.guest.hateFoodTag.Count; i++)
        {
            hateTags[i] = config.guest.hateFoodTag[i];
        }

        // Template from ID 0 or first available
        var template = specialGuests[0];

        // var specialGuest = new SpecialGuest(
        specialGuest = new SpecialGuest(
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

        DataBaseDayPatch.NPCsToRegister.TryAdd(config.label, new NPC(specialGuest));
        Log.LogInfo($"Prepared Delay Load NPC for Special Guest: {config.name} ({config.id})");

        // Food Requests
        if (config.guest.foodRequests != null)
        {
            var foodRequests = new Dictionary<int, string>();
            foreach (var req in config.guest.foodRequests)
            {
                foodRequests.Add(req.tagId, req.request);
            }
            DataBaseLanguagePatch.FoodRequestsToRegister[config.id] = foodRequests;
        }
    }

    public static void TryInjectSpecialGuestEvaluation(CharacterConfig config)
    {
        if (config.guest == null || config.guest.evaluation == null) return;

        if (NightSceneLanguage.SpecialEvaluation == null)
        {
            Log.LogWarning($"NightSceneLanguage.SpecialEvaluation is null. Skipping evaluation injection for {config.name}.");
            return;
        }

        var evaluationLines = new Il2CppStringArray(config.guest.evaluation.Count);
        for (int i = 0; i < config.guest.evaluation.Count; i++)
        {
            evaluationLines[i] = config.guest.evaluation[i];
        }

        NightSceneLanguage.SpecialEvaluation[config.id] = evaluationLines;
        Log.LogInfo($"Injected Special Guest Evaluation: {config.name} ({config.id})");
    }

    public static void TryInjectSpecialGuestConversation(CharacterConfig config)
    {
        if (config.guest == null || config.guest.conversation == null) return;

        if (NightSceneLanguage.SpecialConversation == null)
        {
            Log.LogWarning($"NightSceneLanguage.SpecialConversation is null. Skipping conversation injection for {config.name}.");
            return;
        }

        var conversationList = config.guest.conversation;
        var arr = new DEYU.Utils.UnityEngineExtensionStatic.StructPtr<string>[conversationList.Count];
        for (int i = 0; i < conversationList.Count; i++)
        {
            arr[i] = new DEYU.Utils.UnityEngineExtensionStatic.StructPtr<string>(conversationList[i]);
        }

        NightSceneLanguage.SpecialConversation[config.id] = arr;
        Log.LogInfo($"Injected Special Guest Conversation: {config.name} ({config.id})");
    }

    public static void TryInjectAllSpawnConfigs()
    {
        Log.LogInfo($"Injecting Spawn Configs from ResourceEx...");
        foreach (var charConfig in GetAllCharacters())
        {
            if (charConfig.guest != null)
            {
                TryInjectSpawnConfigs(charConfig);
            }
        }
    }

    public static void TryInjectSpawnConfigs(CharacterConfig config)
    {
        if (config.guest == null || config.guest.spawn == null) return;

        foreach (var spawn in config.guest.spawn)
        {
            try
            {
                if (!GameData.Core.Collections.DataBaseCore.Izakayas.ContainsKey(spawn.izakayaId))
                {
                    Log.LogError($"Izakaya with ID {spawn.izakayaId} not found for character {config.id}");
                    continue;
                }
                var izakaya = GameData.Core.Collections.DataBaseCore.Izakayas[spawn.izakayaId];
                if (izakaya == null)
                {
                    Log.LogError($"Izakaya with ID {spawn.izakayaId} is null for character {config.id}");
                    continue;
                }

                bool exists = izakaya.SpecialGuestPool != null && izakaya.SpecialGuestPool.Any(group => group.GroupId == config.id);

                if (exists)
                {
                    Log.LogInfo($"Spawn config for {config.name} in Izakaya {spawn.izakayaId} already exists. Skipping.");
                    continue;
                }

                var newGroup = new GameData.Core.Collections.Izakaya.SpecialGuestGroup(
                    config.id,
                    spawn.relativeProb,
                    spawn.onlySpawnAfterUnlocking,
                    spawn.onlySpawnWhenPlaceBeRecorded
                );

                var oldPool = izakaya.SpecialGuestPool;
                var newPool = new GameData.Core.Collections.Izakaya.SpecialGuestGroup[oldPool.Length + 1];
                oldPool.CopyTo(newPool, 0);
                newPool[oldPool.Length] = newGroup;
                izakaya.SpecialGuestPool = newPool;

                Log.LogInfo($"Injected Spawn Config for {config.name} in Izakaya {spawn.izakayaId}");
            }
            catch (System.Exception e)
            {
                Log.LogError($"Failed to inject spawn config for {config.name}: {e.Message}");
            }
        }
    }

    private static Dictionary<int, CharacterSpriteSetCompact> _spriteSetCompacts = new Dictionary<int, CharacterSpriteSetCompact>();

    public static void PreloadAllImages()
    {
        Log.LogInfo($"Preloading all images...");
        foreach (var charConfig in GetAllCharacters())
        {
            // Preload Portraits
            if (charConfig.portraits != null)
            {
                foreach (var portrait in charConfig.portraits)
                {
                    if (!string.IsNullOrEmpty(portrait.path))
                    {
                        // Default params for portraits: pivot (0.5, 0.5), no resize
                        GetSprite(portrait.path, charConfig.ModRoot); 
                    }
                }
            }

            // Preload SpriteSetCompact
            if (charConfig.characterSpriteSetCompact != null)
            {
                var config = charConfig.characterSpriteSetCompact;
                if (config.mainSprite != null)
                {
                    foreach (var path in config.mainSprite)
                    {
                        if (!string.IsNullOrEmpty(path))
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.ModRoot, new Vector2(0.5f, 0.0f), 64, 64);
                    }
                }
                if (config.eyeSprite != null)
                {
                    foreach (var path in config.eyeSprite)
                    {
                        if (!string.IsNullOrEmpty(path))
                            // Params for SpriteSetCompact: pivot (0.5, 0.0), 64x64 resize
                            GetSprite(path, charConfig.ModRoot, new Vector2(0.5f, 0.0f), 64, 64);
                    }
                }
            }
        }
        Log.LogInfo($"Preloading complete. Cache size: {_spriteCache.Count}");
    }

    public static void TryInjectAllSpriteSetCompact()
    {
        CharacterSpriteSetCompact template = DataBaseCharacter.SpecialGuest[0].CharacterPixel;

        if (template == null)
        {
            Log.LogWarning($"Failed to find any CharacterSpriteSetCompact template! This is expected if called before any character assets are loaded.");
            return;
        }

        foreach (var charConfig in GetAllCharacters())
        {
            if (charConfig.characterSpriteSetCompact == null) continue;

            try 
            {
                CreateAndRegisterSpriteSet(charConfig, template);
            }
            catch (System.Exception e)
            {
                Log.LogError($"Failed to load CharacterSpriteSetCompact for {charConfig.name}: {e.Message}");
            }
        }
    }

    private static void CreateAndRegisterSpriteSet(CharacterConfig charConfig, CharacterSpriteSetCompact template)
    {
        var newSpriteSet = ScriptableObject.CreateInstance<CharacterSpriteSetCompact>();
        newSpriteSet.name = charConfig.characterSpriteSetCompact.name;

        // Prepare arrays
        Il2CppReferenceArray<Sprite> mainSprites = null;
        if (template.MainSprite != null)
        {
            mainSprites = new Il2CppReferenceArray<Sprite>(template.MainSprite.Length);
            for (int i = 0; i < template.MainSprite.Length; i++)
            {
                mainSprites[i] = template.MainSprite[i];
            }
        }

        Il2CppReferenceArray<Sprite> eyeSprites = null;
        if (template.EyeSprite != null)
        {
            eyeSprites = new Il2CppReferenceArray<Sprite>(template.EyeSprite.Length);
            for (int i = 0; i < template.EyeSprite.Length; i++)
            {
                eyeSprites[i] = template.EyeSprite[i];
            }
        }

        var config = charConfig.characterSpriteSetCompact;
        
        ApplySprites(mainSprites, config.mainSprite, charConfig.ModRoot);
        ApplySprites(eyeSprites, config.eyeSprite, charConfig.ModRoot);

        newSpriteSet.Initialize(
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
        
        _spriteSetCompacts[charConfig.id] = newSpriteSet;
        Log.LogInfo($"Loaded CharacterSpriteSetCompact for {charConfig.name} ({charConfig.id})");
    }

    private static void ApplySprites(Il2CppReferenceArray<Sprite> targetArray, List<string> spritePaths, string modRoot, int pixelOffsetX = 0, int pixelOffsetY = 0)
    {
        if (spritePaths == null) return;

        if (spritePaths.Count != targetArray.Count)
        {
            Log.LogError($"Sprite count mismatch! Expected {targetArray.Count}, got {spritePaths.Count}. Refusing to load sprites.");
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

    public static CharacterSpriteSetCompact TryGetSpriteSetCompact(int id)
    {
        if (_spriteSetCompacts.TryGetValue(id, out var set))
        {
            return set;
        }
        return null;
    }

    public static Sprite GetPortraitSprite(int characterId, int pid = 0)
    {
        var config = GetCharacterConfig(characterId, "Special");
        if (config != null && config.portraits != null && config.portraits.Count > 0)
        {
            var portrait = config.portraits.Find(p => p.pid == pid) ?? config.portraits[0];

            if (portrait != null && !string.IsNullOrEmpty(portrait.path))
            {
                return GetSprite(portrait.path, config.ModRoot);
            }
        }
        return null;
    }
}
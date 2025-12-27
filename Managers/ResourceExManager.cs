using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BepInEx;
using Common.DialogUtility;
using GameData.CoreLanguage.Collections;
using MetaMiku;
using UnityEngine;

namespace MetaMystia;
public class CharacterConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string label { get; set; }
    public List<string> descriptions { get; set; }
    public string type { get; set; }
    public List<PortraitConfig> portraits { get; set; }
    public string ModRoot { get; set; }
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
    
    private static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
    private static Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();
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

    public static Sprite GetSprite(string relativePath, string modRoot = null)
    {
        if (string.IsNullOrEmpty(relativePath)) return null;

        string fullPath = string.IsNullOrEmpty(modRoot) 
            ? Path.Combine(ResourceRoot, relativePath) 
            : Path.Combine(modRoot, relativePath);

        if (_spriteCache.TryGetValue(fullPath, out var sprite))
        {
            return sprite;
        }

        sprite = Utils.GetArtWork(fullPath);
        if (sprite != null)
        {
            _spriteCache[fullPath] = sprite;
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

    public static void InjectCharacters()
    {
        Log.LogInfo($"Injecting characters from ResourceEx...");
        
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
}
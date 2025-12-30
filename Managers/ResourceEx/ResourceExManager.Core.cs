using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BepInEx;
using Common.DialogUtility;
using UnityEngine;
using MetaMiku;
using MetaMystia.ResourceEx.Models;

namespace MetaMystia;

[AutoLog]
public static partial class ResourceExManager
{
    // Abstracted resource root path
    public static string ResourceRoot { get; set; } = Path.Combine(Paths.GameRootPath, "ResourceEx");
    
    public static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
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
    
    public static IEnumerable<CharacterConfig> GetAllCharacterConfigs()
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

    public static CustomDialogList GetDialogPackage(string name)
    {
        if (_dialogPackages.TryGetValue(name, out var pkg))
        {
            return pkg;
        }
        return null;
    }
}
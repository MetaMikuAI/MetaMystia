using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using UnityEngine;
using BepInEx;
using BepInEx.Logging;
using MetaMiku;
using GameData.CoreLanguage.Collections;

namespace MetaMystia;
public class CharacterConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string label { get; set; }
    public List<string> descriptions { get; set; }
    public string type { get; set; }
    public List<PortraitConfig> portraits { get; set; }
}

public class PortraitConfig
{
    public int pid { get; set; }
    public string path { get; set; }
}

public class ResourceConfig
{
    public List<CharacterConfig> characters { get; set; }
}

public static class ResourceExManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[ResourceExManager]";
    
    // Abstracted resource root path
    public static string ResourceRoot { get; set; } = Path.Combine(Paths.GameRootPath, "ResourceEx");
    
    private static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
    private static Dictionary<string, Sprite> _spriteCache = new Dictionary<string, Sprite>();

    public static void Initialize()
    {
        LoadConfigs();
    }

    private static void LoadConfigs()
    {
        string jsonPath = Path.Combine(ResourceRoot, "Characters.json");
        if (!File.Exists(jsonPath))
        {
            Log.LogError($"{LOG_TAG} Resource config not found at {jsonPath}");
            return;
        }

        try
        {
            string jsonString = File.ReadAllText(jsonPath);
            var config = JsonSerializer.Deserialize<ResourceConfig>(jsonString);
            
            if (config?.characters != null)
            {
                foreach (var charConfig in config.characters)
                {
                    _characterConfigs[(charConfig.id, charConfig.type)] = charConfig;
                    Log.LogInfo($"{LOG_TAG} Loaded config for character {charConfig.name} ({charConfig.id}, {charConfig.type})");
                }
            }
        }
        catch (System.Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to load resource config: {e.Message}");
        }
    }

    public static CharacterConfig GetCharacterConfig(int id, string type)
    {
        if (_characterConfigs.TryGetValue((id, type), out var config))
        {
            return config;
        }
        return null;
    }

    public static Sprite GetSprite(string relativePath)
    {
        if (string.IsNullOrEmpty(relativePath)) return null;

        if (_spriteCache.TryGetValue(relativePath, out var sprite))
        {
            return sprite;
        }

        string fullPath = Path.Combine(ResourceRoot, relativePath);
        sprite = Utils.GetArtWork(fullPath);
        if (sprite != null)
        {
            _spriteCache[relativePath] = sprite;
        }
        else
        {
            Log.LogWarning($"{LOG_TAG} Failed to load sprite at {fullPath}");
        }
        return sprite;
    }
    
    public static IEnumerable<CharacterConfig> GetAllCharacters()
    {
        return _characterConfigs.Values;
    }
    public static void InjectCharacters()
    {
        Log.LogInfo($"{LOG_TAG} Injecting characters from ResourceEx...");
        
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

            if (charConfig.type == "Special")
            {
                DataBaseLanguage.SpecialGuest.ForceAddOrUpdateValueTuple(charConfig.id, val);
                Log.LogInfo($"{LOG_TAG} Injected Special character: {charConfig.name} ({charConfig.id})");
            }
            else if (charConfig.type == "Normal")
            {
                Log.LogInfo($"{LOG_TAG} Normal character detected but injection not yet implemented: {charConfig.name} ({charConfig.id})");
            }
            else
            {
                Log.LogWarning($"{LOG_TAG} Unknown character detected but injection not yet implemented: {charConfig.name} ({charConfig.id})");
            }
        }
    }
}
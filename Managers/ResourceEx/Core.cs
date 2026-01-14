using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using BepInEx;
using Common.DialogUtility;
using GameData.Profile;

using MetaMystia.ResourceEx.Models;

namespace MetaMystia;


[AutoLog]
public static partial class ResourceExManager
{
    // Abstracted resource root path
    public static string ResourceRoot { get; set; } = Path.Combine(Paths.GameRootPath, "ResourceEx");

    private static readonly Dictionary<(int id, string type), CharacterConfig> _characterConfigs = [];
    private static readonly Dictionary<string, CustomDialogList> _dialogPackageConfigs = [];
    private static readonly Dictionary<string, DialogPackage> _builtDialogPackages = [];

    private static readonly Dictionary<int, IngredientConfig> IngredientConfigs = [];
    private static readonly Dictionary<int, FoodConfig> FoodConfigs = [];
    private static readonly Dictionary<int, RecipeConfig> RecipeConfigs = [];
    private static readonly List<MissionNodeConfig> MissionNodeConfigs = [];

    private static readonly string DialogPackageNamePrefix = "";

    private class ModPackInfo
    {
        public string FullPath { get; set; }
        public string Prefix { get; set; }
        public Version Version { get; set; }
        public string FileName { get; set; }
        public bool IsCopyFormat { get; set; } // True if format is <prefix> (n).zip
        public int CopyNumber { get; set; } // The n in <prefix> (n).zip
    }

    private static ModPackInfo ParseModPackFileName(string filePath)
    {
        string fileName = Path.GetFileNameWithoutExtension(filePath);

        // Try Pattern 1: <prefix>-v<major>.<minor>.<patch>
        var versionMatch = Regex.Match(fileName, @"^(.+?)-v(\d+)\.(\d+)\.(\d+)$", RegexOptions.IgnoreCase);

        if (versionMatch.Success)
        {
            try
            {
                string prefix = versionMatch.Groups[1].Value;
                int major = int.Parse(versionMatch.Groups[2].Value);
                int minor = int.Parse(versionMatch.Groups[3].Value);
                int patch = int.Parse(versionMatch.Groups[4].Value);

                return new ModPackInfo
                {
                    FullPath = filePath,
                    Prefix = prefix,
                    Version = new Version(major, minor, patch),
                    FileName = fileName,
                    IsCopyFormat = false,
                    CopyNumber = 0
                };
            }
            catch
            {
                return null;
            }
        }

        // Try Pattern 2: <prefix> (n)
        var copyMatch = Regex.Match(fileName, @"^(.+?)\s*\((\d+)\)$");

        if (copyMatch.Success)
        {
            try
            {
                string prefix = copyMatch.Groups[1].Value.TrimEnd();
                int copyNumber = int.Parse(copyMatch.Groups[2].Value);

                return new ModPackInfo
                {
                    FullPath = filePath,
                    Prefix = prefix,
                    Version = new Version(0, 0, copyNumber), // Use copy number as patch version
                    FileName = fileName,
                    IsCopyFormat = true,
                    CopyNumber = copyNumber
                };
            }
            catch
            {
                return null;
            }
        }

        // Try Pattern 3: <prefix> (no version or copy number)
        // Treat as version 0.0.0
        return new ModPackInfo
        {
            FullPath = filePath,
            Prefix = fileName,
            Version = new Version(0, 0, 0),
            FileName = fileName,
            IsCopyFormat = false,
            CopyNumber = 0
        };
    }

    private static List<string> GetLatestModPacks(string[] zipFiles)
    {
        var modPacks = new List<ModPackInfo>();

        foreach (var zipPath in zipFiles)
        {
            var info = ParseModPackFileName(zipPath);
            if (info != null)
            {
                modPacks.Add(info);
            }
        }

        // Group by prefix and select the latest version for each prefix
        var latestPacks = modPacks
            .GroupBy(m => m.Prefix, StringComparer.OrdinalIgnoreCase)
            .Select(g => g.OrderByDescending(m => m.Version).First())
            .ToList();

        return [.. latestPacks.Select(m => m.FullPath)];
    }

    public static void Initialize()
    {
        LoadConfigs();
        PreloadAllImages();
    }

    public static void OnDataBaseCoreInitialized()
    {
        RegisterAllSpawnConfigs();
        RegisterAllIngredients();
        RegisterAllRecipes();
        RegisterAllFoods();
    }
    public static void OnDataBaseDayInitialized()
    {
        RegisterNPCs();
    }
    public static void OnDataBaseLanguageInitialized()
    {
        RegisterAllFoodRequests();
        RegisterAllBevRequests();
        RegisterSpecialPortraits();
        RegisterAllIngredientLanguages();
        RegisterAllFoodLanguages();
        RegisterAllMissionNodeLanguages();
    }

    public static void OnDataBaseCharacterInitialized()
    {
        BuildAllDialogPackages();
        RegisterAllSpecialGuestPairs();
        RegisterAllSpecialGuests();
    }

    public static void OnDataBaseAchievementInitialized()
    {
        // Currently no actions needed here
    }
    public static void OnDataBaseSchedulerInitialized()
    {
        RegisterAllMissionNodes();
    }
    public static void OnNightSceneLanguageInitialized()
    {
        RegisterAllConversations();
        RegisterAllEvaluations();
    }

    public static void OnDaySceneLanguageInitialized()
    {
        // Currently no actions needed here
    }

    public static void OnDaySceneAwake()
    {
        InitializeAllDaySpawnConfigs();
    }

    private static void LoadConfigs()
    {
        if (!Directory.Exists(ResourceRoot))
        {
            Directory.CreateDirectory(ResourceRoot);
            Log.LogInfo($"Created ResourceEx directory at {ResourceRoot}");
            return;
        }

        var allZipFiles = Directory.GetFiles(ResourceRoot, "*.zip");
        var zipFilesToLoad = GetLatestModPacks(allZipFiles);

        foreach (var zipPath in zipFilesToLoad)
        {
            string modName = Path.GetFileNameWithoutExtension(zipPath);
            Log.LogInfo($"Loading mod pack: {modName} from {zipPath}");

            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    ZipArchiveEntry configEntry = null;
                    string internalPrefix = "";

                    // Find ResourceEx.json
                    foreach (var entry in archive.Entries)
                    {
                        if (entry.FullName.EndsWith("ResourceEx.json", StringComparison.OrdinalIgnoreCase))
                        {
                            // Prefer shorter path (root level)
                            if (configEntry == null || entry.FullName.Length < configEntry.FullName.Length)
                            {
                                configEntry = entry;
                            }
                        }
                    }

                    if (configEntry == null)
                    {
                        Log.LogWarning($"[{modName}] ResourceEx.json not found in zip.");
                        continue;
                    }

                    string entryName = configEntry.FullName;
                    if (entryName.EndsWith("ResourceEx.json", StringComparison.OrdinalIgnoreCase))
                    {
                        internalPrefix = entryName[..^"ResourceEx.json".Length];
                    }

                    Log.LogInfo($"[{modName}] Found config at {configEntry.FullName}, Prefix: '{internalPrefix}'");

                    string jsonString;
                    using (var stream = configEntry.Open())
                    using (var reader = new StreamReader(stream))
                    {
                        jsonString = reader.ReadToEnd();
                    }

                    var options = new JsonSerializerOptions
                    {
                        ReadCommentHandling = JsonCommentHandling.Skip,
                        AllowTrailingCommas = true,
                        PropertyNameCaseInsensitive = true
                    };
                    options.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());

                    var config = JsonSerializer.Deserialize<ResourceConfig>(jsonString, options);

                    string modRootInfo = $"{zipPath}|{internalPrefix}";

                    if (config?.characters != null)
                    {
                        foreach (var charConfig in config.characters)
                        {
                            charConfig.ModRoot = modRootInfo;
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
                                if (!string.IsNullOrEmpty(d.characterType) && Enum.TryParse<SpeakerIdentity.Identity>(d.characterType, true, out var st))
                                {
                                    speakerType = st;
                                }

                                var position = Position.Left;
                                if (Enum.TryParse<Position>(d.position, out var pos))
                                {
                                    position = pos;
                                }

                                dialogList.AddDialog(d.characterId, speakerType, d.pid, position, d.text);
                            }
                            _dialogPackageConfigs[pkgConfig.name] = dialogList;
                            Log.LogInfo($"[{modName}] Loaded dialog package: {pkgConfig.name}");
                        }
                    }

                    if (config?.ingredients != null)
                    {
                        foreach (var ingredientConfig in config.ingredients)
                        {
                            ingredientConfig.ModRoot = modRootInfo;
                            IngredientConfigs[ingredientConfig.id] = ingredientConfig;
                            Log.LogInfo($"[{modName}] Loaded config for ingredient {ingredientConfig.id}");
                        }
                    }

                    if (config?.foods != null)
                    {
                        foreach (var foodConfig in config.foods)
                        {
                            foodConfig.ModRoot = modRootInfo;
                            FoodConfigs[foodConfig.id] = foodConfig;
                            Log.LogInfo($"[{modName}] Loaded config for food {foodConfig.name} ({foodConfig.id})");
                        }
                    }

                    if (config?.recipes != null)
                    {
                        foreach (var recipeConfig in config.recipes)
                        {
                            RecipeConfigs[recipeConfig.id] = recipeConfig;
                            Log.LogInfo($"[{modName}] Loaded config for recipe {recipeConfig.id}");
                        }
                    }

                    if (config?.missionNodes != null)
                    {
                        foreach (var missionNodeConfig in config.missionNodes)
                        {
                            // missionNodeConfig.ModRoot = modRootInfo;
                            MissionNodeConfigs.Add(missionNodeConfig);
                            Log.LogInfo($"[{modName}] Loaded config for mission node {missionNodeConfig.title}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.LogError($"Failed to load mod {modName}: {e.Message}");
            }
        }
    }
}

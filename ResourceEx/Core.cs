using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Text.Json;
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

    private static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
    private static Dictionary<string, CustomDialogList> _dialogPackageConfigs = new Dictionary<string, CustomDialogList>();
    private static Dictionary<string, DialogPackage> _builtDialogPackages = new Dictionary<string, DialogPackage>();

    private static Dictionary<int, IngredientConfig> IngredientConfigs = new Dictionary<int, IngredientConfig>();
    private static Dictionary<int, FoodConfig> FoodConfigs = new Dictionary<int, FoodConfig>();
    private static Dictionary<int, BeverageConfig> BeverageConfigs = new Dictionary<int, BeverageConfig>();
    private static Dictionary<int, RecipeConfig> RecipeConfigs = new Dictionary<int, RecipeConfig>();
    private static List<MissionNodeConfig> MissionNodeConfigs = new List<MissionNodeConfig>();
    private static List<EventNodeConfig> EventNodeConfigs = new List<EventNodeConfig>();

    private static readonly string DialogPackageNamePrefix = "";

    public static void Initialize()
    {
        LoadConfigs();
        PreloadAllImages();
    }

    // 加载逻辑
    // DataBaseCore -> DataBaseScheduler -> DataBaseCharacter -> DataBaseLanguage -> DataBaseDay

    public static void OnDataBaseCoreInitialized()
    {
        RegisterAllSpawnConfigs();
        RegisterAllIngredients();
        RegisterAllBeverages();
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
        RegisterAllBeverageLanguages();
        RegisterAllFoodLanguages();
        RegisterAllMissionNodeLanguages();
    }

    public static void OnDataBaseCharacterInitialized()
    {
        BuildAllDialogPackages();
        RegisterAllSpecialGuestPairs();
        RegisterAllSpecialGuests();

        RegisterAllMissionNodes(); // 依赖 Dialog
        RegisterAllEventNodes(); // 依赖 Dialog
    }

    public static void OnDataBaseAchievementInitialized()
    {
        // Currently no actions needed here
    }
    public static void OnDataBaseSchedulerInitialized()
    {
        // RegisterAllMissionNodes(); // 依赖 Dialog
        // RegisterAllEventNodes(); // 依赖 Dialog
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
        ActivateAllKizunaEventNodes();
    }

    private class PackCandidate
    {
        public string ZipPath;
        public string ModName;
        public ResourceConfig Config;
        public string InternalPrefix;
    }

    private static System.Version GetVersion(string v)
    {
        if (string.IsNullOrWhiteSpace(v)) return new System.Version(0, 0, 0);
        if (System.Version.TryParse(v, out var result)) return result;
        return new System.Version(0, 0, 0);
    }

    private static void LoadConfigs()
    {
        if (!Directory.Exists(ResourceRoot))
        {
            Directory.CreateDirectory(ResourceRoot);
            Log.LogInfo($"Created ResourceEx directory at {ResourceRoot}");
            return;
        }

        var zipFiles = Directory.GetFiles(ResourceRoot, "*.zip");
        var candidates = new List<PackCandidate>();

        foreach (var zipPath in zipFiles)
        {
            string modName = Path.GetFileNameWithoutExtension(zipPath);
            Log.LogInfo($"Scanning mod pack: {modName} from {zipPath}");

            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    ZipArchiveEntry configEntry = null;
                    string internalPrefix = "";

                    // Find ResourceEx.json
                    foreach (var entry in archive.Entries)
                    {
                        if (entry.FullName.EndsWith("ResourceEx.json", System.StringComparison.OrdinalIgnoreCase))
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
                    if (entryName.EndsWith("ResourceEx.json", System.StringComparison.OrdinalIgnoreCase))
                    {
                        internalPrefix = entryName.Substring(0, entryName.Length - "ResourceEx.json".Length);
                    }

                    // Log.LogInfo($"[{modName}] Found config at {configEntry.FullName}, Prefix: '{internalPrefix}'");

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

                    candidates.Add(new PackCandidate
                    {
                        ZipPath = zipPath,
                        ModName = modName,
                        Config = config,
                        InternalPrefix = internalPrefix
                    });
                }
            }
            catch (System.Exception e)
            {
                Log.LogError($"Failed to load mod {modName}: {e.Message}");
            }
        }

        var finalPacks = candidates
            .Where(c => string.IsNullOrEmpty(c.Config?.packInfo?.label))
            .ToList();

        var resolvedPacks = candidates
            .Where(c => !string.IsNullOrEmpty(c.Config?.packInfo?.label))
            .GroupBy(c => c.Config.packInfo.label)
            .Select(group =>
            {
                var sorted = group
                    .Select(c => new { Candidate = c, Version = GetVersion(c.Config.packInfo.version) })
                    .OrderByDescending(x => x.Version)
                    .ToList();

                var winner = sorted.First();

                if (sorted.Count > 1)
                {
                    Log.LogWarning($"[ResourceEx] Label Conflict: '{group.Key}'. Selected '{winner.Candidate.ModName}' (v{winner.Version}) over others: {string.Join(", ", sorted.Skip(1).Select(s => s.Candidate.ModName))}");
                }

                return winner.Candidate;
            });

        finalPacks.AddRange(resolvedPacks);

        foreach (var pack in finalPacks)
        {
            if (pack.Config?.packInfo != null)
            {
                var info = pack.Config.packInfo;
                string authors = info.authors != null ? string.Join(", ", info.authors) : "Unknown";
                Log.LogMessage($"Loaded Resource Pack: {info.name} [{info.label}] v{info.version} by {authors}");
            }
            else
            {
                Log.LogInfo($"Loading mod pack: {pack.ModName} from {pack.ZipPath}");
            }

            ApplyConfig(pack);
        }
    }

    private static void ApplyConfig(PackCandidate pack)
    {
        var config = pack.Config;
        string modName = pack.ModName;
        string modRootInfo = $"{pack.ZipPath}|{pack.InternalPrefix}";

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

        if (config?.beverages != null)
        {
            foreach (var beverageConfig in config.beverages)
            {
                beverageConfig.ModRoot = modRootInfo;
                BeverageConfigs[beverageConfig.id] = beverageConfig;
                Log.LogInfo($"[{modName}] Loaded config for beverage {beverageConfig.name} ({beverageConfig.id})");
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

        if (config?.eventNodes != null)
        {
            foreach (var eventNodeConfig in config.eventNodes)
            {
                // eventNodeConfig.ModRoot = modRootInfo;
                EventNodeConfigs.Add(eventNodeConfig);
                Log.LogInfo($"[{modName}] Loaded config for event node {eventNodeConfig.debugLabel}");
            }
        }
    }
}

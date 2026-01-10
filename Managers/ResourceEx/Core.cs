using System.Collections.Generic;
using System.IO;
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
    private static Dictionary<int, RecipeConfig> RecipeConfigs = new Dictionary<int, RecipeConfig>();
    private static readonly string DialogPackageNamePrefix = "";

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
        // Currently no actions needed here
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
                var options = new JsonSerializerOptions
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());

                var config = JsonSerializer.Deserialize<ResourceConfig>(jsonString, options);
                
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
                        _dialogPackageConfigs[pkgConfig.name] = dialogList;
                        Log.LogInfo($"[{modName}] Loaded dialog package: {pkgConfig.name}");
                    }
                }
                
                if (config?.ingredients != null)
                {
                    foreach (var ingredientConfig in config.ingredients)
                    {
                        ingredientConfig.ModRoot = modDir;
                        IngredientConfigs[ingredientConfig.id] = ingredientConfig;
                        Log.LogInfo($"[{modName}] Loaded config for ingredient {ingredientConfig.id}");
                    }
                }

                if (config?.foods != null)
                {
                    foreach (var foodConfig in config.foods)
                    {
                        foodConfig.ModRoot = modDir;
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
            }
            catch (System.Exception e)
            {
                Log.LogError($"Failed to load mod {modName}: {e.Message}");
            }
        }
    }
    
    


}
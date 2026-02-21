using System.Collections.Generic;
using System.IO;
using BepInEx;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.Core.Collections.CharacterUtility;
using UnityEngine;
using System.Linq;
using MetaMystia.ResourceEx.AssetManagement;
using MetaMystia.ResourceEx.Models;
namespace MetaMystia;


[AutoLog]
public static partial class ResourceExManager
{
    // Abstracted resource root path
    public static string ResourceRoot { get; set; } = Path.Combine(Paths.GameRootPath, "ResourceEx");

    // Asset provider for efficient resource package access
    private static readonly AssetProvider _assetProvider = new AssetProvider();

    private static Dictionary<(int id, string type), CharacterConfig> _characterConfigs = new Dictionary<(int id, string type), CharacterConfig>();
    private static Dictionary<string, CharacterSpriteSetCompact> _characterSpriteSets = new Dictionary<string, CharacterSpriteSetCompact>();
    private static Dictionary<string, CustomDialogList> _dialogPackageConfigs = new Dictionary<string, CustomDialogList>();
    private static Dictionary<string, DialogPackage> _builtDialogPackages = new Dictionary<string, DialogPackage>();
    private static Dictionary<string, Merchant> _builtMerchants = new Dictionary<string, Merchant>();

    private static Dictionary<int, IngredientConfig> IngredientConfigs = new Dictionary<int, IngredientConfig>();
    private static Dictionary<int, FoodConfig> FoodConfigs = new Dictionary<int, FoodConfig>();
    private static Dictionary<int, BeverageConfig> BeverageConfigs = new Dictionary<int, BeverageConfig>();
    private static Dictionary<int, RecipeConfig> RecipeConfigs = new Dictionary<int, RecipeConfig>();
    private static List<MissionNodeConfig> MissionNodeConfigs = new List<MissionNodeConfig>();
    private static List<EventNodeConfig> EventNodeConfigs = new List<EventNodeConfig>();
    private static Dictionary<string, MerchantConfig> MerchantConfigs = new Dictionary<string, MerchantConfig>();
    private static Dictionary<int, ClothConfig> ClothConfigs = new Dictionary<int, ClothConfig>();

    // Public ID set accessors for DLCManager rEx integration
    public static HashSet<int> LoadedRecipeIds => [.. RecipeConfigs.Keys];
    public static HashSet<int> LoadedFoodIds => [.. FoodConfigs.Keys];
    public static HashSet<int> LoadedBeverageIds => [.. BeverageConfigs.Keys];
    public static HashSet<int> LoadedIngredientIds => [.. IngredientConfigs.Keys];
    public static HashSet<int> LoadedSpecialGuestIds => [.. _characterConfigs.Where(kv => kv.Key.type == "Special").Select(kv => kv.Key.id)];

    // Cloth portrait cache: clothId -> Sprite (loaded lazily or during preload)
    private static Dictionary<int, Sprite> _clothPortraitCache = new Dictionary<int, Sprite>();
    // Cloth pixel full cache: skinIndex -> CharacterSpriteSetFull (built during character init)
    private static Dictionary<int, CharacterSpriteSetFull> _clothPixelFullCache = new Dictionary<int, CharacterSpriteSetFull>();

    public static void Initialize()
    {
        LoadAllResourcePackages();
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
        RegisterAllClothItems();
        RegisterAllClothProfiles();
    }
    public static void OnDataBaseDayInitialized()
    {
        RegisterAllDialogPackages();

        RegisterNPCs();
        // RegisterAllSpawnMarkers(); // DO NOT DELETE
        BuildAllMerchants();
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
        RegisterAllClothLanguages();
    }

    public static void OnDataBaseCharacterInitialized()
    {
        BuildAllDialogPackages();
        RegisterAllSpecialGuestPairs();
        RegisterAllSpecialGuests(); // 依赖 Dialog

        RegisterAllMissionNodes(); // 依赖 Dialog
        RegisterAllEventNodes(); // 依赖 Dialog

        RegisterAllClothPixelSprites(); // 依赖 DataBaseCharacter
    }

    public static void OnDataBaseAchievementInitialized()
    {
        // Currently no actions needed here
    }
    public static void OnDataBaseSchedulerInitialized()
    {
        // RegisterAllMissionNodes(); // 依赖 Dialog
        // RegisterAllEventNodes(); // 依赖 Dialog
        RegisterAllMissionNodesMapping();
        RegisterAllEventNodesMapping();
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
        RefreshAllDayNpcs();
        CheckAndReloadSchedulerData();
        ActivateAllKizunaEventNodes(); // 依赖 CheckAndReloadSchedulerData
        ResetTrackedNpcDialog();
        RegisterAllTrackedMerchant();
    }

    /// <summary>
    /// Loads all resource packages from the ResourceEx directory
    /// </summary>
    private static void LoadAllResourcePackages()
    {
        var packages = ResourcePackageLoader.LoadAllPackages(ResourceRoot);

        foreach (var package in packages)
        {
            MergeResourcePackage(package);
        }

        Log.LogInfo($"Loaded {packages.Count} resource package(s) successfully.");
    }

    /// <summary>
    /// Merges a loaded resource package into the manager's internal data structures
    /// </summary>
    private static void MergeResourcePackage(LoadedResourcePackage package)
    {
        var config = package.Config;
        string packageName = package.PackageName;
        string packageRoot = package.PackageRoot;

        // Register asset package to provider
        _assetProvider.RegisterPackage(package.AssetPackage);

        if (config?.characters != null)
        {
            foreach (var charConfig in config.characters)
            {
                charConfig.PackageRoot = packageRoot;
                _characterConfigs[(charConfig.id, charConfig.type)] = charConfig;
                Log.LogInfo($"[{packageName}] Loaded config for character {charConfig.name} ({charConfig.id}, {charConfig.type})");
            }
        }

        if (config?.dialogPackages != null)
        {
            foreach (var pkgConfig in config.dialogPackages)
            {
                var dialogList = new CustomDialogList();
                dialogList.packageName = pkgConfig.name;
                foreach (var d in pkgConfig.dialogList)
                {
                    dialogList.AddDialog(d.characterId, d.characterType, d.pid, d.position, d.text);
                }
                _dialogPackageConfigs[pkgConfig.name] = dialogList;
                Log.LogInfo($"[{packageName}] Loaded dialog package: {pkgConfig.name}");
            }
        }

        if (config?.ingredients != null)
        {
            foreach (var ingredientConfig in config.ingredients)
            {
                ingredientConfig.PackageRoot = packageRoot;
                IngredientConfigs[ingredientConfig.id] = ingredientConfig;
                Log.LogInfo($"[{packageName}] Loaded config for ingredient {ingredientConfig.id}");
            }
        }

        if (config?.foods != null)
        {
            foreach (var foodConfig in config.foods)
            {
                foodConfig.PackageRoot = packageRoot;
                FoodConfigs[foodConfig.id] = foodConfig;
                Log.LogInfo($"[{packageName}] Loaded config for food {foodConfig.name} ({foodConfig.id})");
            }
        }

        if (config?.beverages != null)
        {
            foreach (var beverageConfig in config.beverages)
            {
                beverageConfig.PackageRoot = packageRoot;
                BeverageConfigs[beverageConfig.id] = beverageConfig;
                Log.LogInfo($"[{packageName}] Loaded config for beverage {beverageConfig.name} ({beverageConfig.id})");
            }
        }
        if (config?.recipes != null)
        {
            foreach (var recipeConfig in config.recipes)
            {
                RecipeConfigs[recipeConfig.id] = recipeConfig;
                Log.LogInfo($"[{packageName}] Loaded config for recipe {recipeConfig.id}");
            }
        }

        if (config?.missionNodes != null)
        {
            foreach (var missionNodeConfig in config.missionNodes)
            {
                // missionNodeConfig.PackageRoot = packageRootInfo;
                MissionNodeConfigs.Add(missionNodeConfig);
                Log.LogInfo($"[{packageName}] Loaded config for mission node {missionNodeConfig.title}");
            }
        }

        if (config?.eventNodes != null)
        {
            foreach (var eventNodeConfig in config.eventNodes)
            {
                // eventNodeConfig.PackageRoot = packageRootInfo;
                EventNodeConfigs.Add(eventNodeConfig);
                Log.LogInfo($"[{packageName}] Loaded config for event node {eventNodeConfig.debugLabel}");
            }
        }

        if (config?.merchants != null)
        {
            foreach (var merchantConfig in config.merchants)
            {
                MerchantConfigs[merchantConfig.key] = merchantConfig;
                Log.LogInfo($"[{packageName}] Loaded config for merchant {merchantConfig.key}");
            }
        }

        if (config?.clothes != null)
        {
            foreach (var clothConfig in config.clothes)
            {
                clothConfig.PackageRoot = packageRoot;
                ClothConfigs[clothConfig.id] = clothConfig;
                Log.LogInfo($"[{packageName}] Loaded config for cloth {clothConfig.name} ({clothConfig.id})");
            }
        }
    }
}

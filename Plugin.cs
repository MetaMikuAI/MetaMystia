using System;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using SgrYuki;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MetaMystia;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance;
    public Action<Scene, LoadSceneMode> LoadAction;

    public static ConfigEntry<bool> ConfigDebug;
    public static ConfigEntry<bool> ConfigSignatureCheck;
    public static ConfigEntry<RequestEnableMode> ConfigFoodRequestMode;
    public static ConfigEntry<RequestEnableMode> ConfigBevRequestMode;

    public static Type[] ToBePatched = [
        // SceneManager Patches
        typeof(MainSceneManagerPatch),
        typeof(DaySceneManagerPatch),
        typeof(NightSceneManagerPatch),
        typeof(PrepNightSceneManagerPatch),
        typeof(ResultSceneManagerPatch),
        typeof(StaffSceneManagerPatch),
        typeof(UniversalGameManagerPatch),
        typeof(ReceivedObjectDisplayerControllerPatch),

        // DayScene Patches
        typeof(DaySceneUtilityPatch),
        typeof(StatusTrackerPatch),
        typeof(CharacterControllerUnitPatch),
        typeof(CharacterInputPatch),
        typeof(DayScenePlayerInputPatch),
        typeof(DaySceneMapPatch),
        // typeof(RunTimeSchedulerPatch),

        // PrepScene Patches
        typeof(IzakayaConfigPannelPatch),
        typeof(IzakayaConfigurePatch),
        typeof(IzakayaSelectorPanelPatch),

        // WorkScene Patches
        typeof(CookControllerPatch),
        typeof(SellablePatch),
        // typeof(CookerPatch),
        // typeof(CookSystemManagerGetCookerPatch),
        typeof(GuestsManagerPatch),
        typeof(GuestGroupControllerPatch),
        typeof(WorkSceneServePannelPatch),
        typeof(WorkSceneStoragePannelPatch),
        typeof(QTERewardManagerPatch),
        typeof(NightSceneEventManagerPatch),
        typeof(MystiaQTEBuffRewardPatch),
        typeof(GameTimeManagerPatch),
        typeof(NightScene_SceneManager__c__DisplayClass62_0_Patch),

        // ResourceEx Patches
        typeof(DataBaseCharacterPatch),
        typeof(DataBaseDayPatch),
        typeof(DataBaseCorePatch),
        typeof(DataBaseLanguagePatch),
        typeof(NightSceneLanguagePatch),
        typeof(SpecialGuestDescriberPatch),
        typeof(DaySceneMapProfilePatch),
        typeof(DialogPannelPatch),
        typeof(DataBaseSchedulerPatch),
        typeof(RunTimeDayScenePatch)

    ];

    public static bool AllPatched => PatchedException == null;
    public static Exception PatchedException = null;

    public Plugin()
    {
        Instance = this;
    }

    public void InitConfigs()
    {
        ConfigDebug = Config.Bind("General", "Debug", false, "Enable debug features and hotkeys\n启用调试功能和热键");

        ConfigSignatureCheck = Config.Bind("General", "SignatureCheck", true,
            "Enable RSA signature verification for resource pack ID ranges\n启用资源包 ID 段 RSA 签名校验");

        ConfigFoodRequestMode = Config.Bind("General", "FoodRequestMode", RequestEnableMode.FollowPackage,
            "Food request enable mode (FollowPackage by default)\n料理点单启用模式(默认跟随资源包)\n" +
            "ForceDisable: 强制关闭 | FollowPackage: 跟随资源包 | ForceEnable: 强制启用");

        ConfigBevRequestMode = Config.Bind("General", "BevRequestMode", RequestEnableMode.ForceDisable,
            "Beverage request enable mode (ForceDisable by default)\n酒水点单启用模式(默认关闭)\n" +
            "ForceDisable: 强制关闭 | FollowPackage: 跟随资源包 | ForceEnable: 强制启用");
    }

    public override void Load()
    {
        InitConfigs();

        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
        catch { }
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        try
        {
            ClassInjector.RegisterTypeInIl2Cpp<PluginManager>();
            Log.LogInfo("Registered C# Types in Il2Cpp");
        }
        catch (Exception ex)
        {
            Log.LogError($"FAILED to Register Il2Cpp Type! {ex.Message}");
        }

        try
        {
            var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

            var originalHandle = AccessTools.Method(typeof(CanvasScaler), "Handle");
            var postHandle = AccessTools.Method(typeof(BootstrapPatch), "Handle");
            harmony.Patch(originalHandle, postfix: new HarmonyMethod(postHandle));

            foreach (var patch in ToBePatched)
            {
                harmony.PatchAll(patch);
                Log.LogInfo($"Applied {patch.Name}");
            }

            NativeDllExtractor.Extract("MetaMystia.Patches.Native.Runtime.MinHook.x64.dll", MinHook.DLLFilename);
            MinHook_SpawnNormalGuestGroup.InstallHook();

            // ShigureYuki.DebugClassPatcher.PatchAllInnerClass(ref harmony, typeof(ShigureYuki.DebugConsolePatch));
            Network.Action.RegisterAllFormatter();

            ResourceExManager.Initialize();
        }
        catch (Exception ex)
        {
            Log.LogFatal($"FAILED to Apply Hooks! {ex.Message}");
            PatchedException = ex;
        }
    }

    public static void OnEnterMainScene()
    {
        DLCManager.Initialize();
        MetricsReporter.OnEnterMainScene();
    }

    class BootstrapPatch
    {
        [HarmonyPostfix]
        static void Handle()
        {
            if (PluginManager.Instance == null)
            {
                Instance.Log.LogMessage("Bootstrapping Trainer...");
                try
                {
                    PluginManager.Create("PluginManager");
                    if (PluginManager.Instance != null)
                    {
                        Instance.Log.LogMessage("Trainer Bootstrapped!");
                    }
                }
                catch (Exception e)
                {
                    Instance.Log.LogMessage($"ERROR Bootstrapping Trainer: {e.Message}");
                }
            }
        }
    }
}

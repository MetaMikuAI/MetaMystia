using System;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using SgrYuki.Utils;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MetaMystia;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance;
    public Action<Scene, LoadSceneMode> LoadAction;
    public static bool FirstEnterMain = true;

    public static Type[] ToBePatched = [
        // SceneManager Patches
        typeof(MainSceneManagerPatch),
        typeof(DaySceneManagerPatch),
        typeof(NightSceneManagerPatch),
        typeof(PrepNightSceneManagerPatch),
        typeof(ResultSceneManagerPatch),
        typeof(StaffSceneManagerPatch),
        typeof(UniversalGameManagerPatch),

        // DayScene Patches
        typeof(StatusTrackerPatch),
        typeof(RunTimeSchedulerPatch),
        typeof(CharacterControllerUnitPatch),
        typeof(CharacterInputPatch),
        typeof(DayScenePlayerInputPatch),

        // PrepScene Patches
        typeof(IzakayaConfigPannelPatch),
        typeof(IzakayaConfigurePatch),
        typeof(IzakayaSelectorPanelPatch),

        // WorkScene Patches
        typeof(CookControllerPatch),
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
        typeof(DataBaseSchedulerPatch)

    ];

    public static bool AllPatched => PatchedException == null;
    public static Exception PatchedException = null;

    public Plugin()
    {
        Instance = this;
    }

    public override void Load()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            NetAction.RegisterAllFormatter();

            ResourceExManager.Initialize();

            MetricsReporter.OnPluginInitialized();

        }
        catch (Exception ex)
        {
            Log.LogFatal($"FAILED to Apply Hooks! {ex.Message}");
            PatchedException = ex;
        }
    }

    public static void OnEnterMainScene()
    {
        if (!FirstEnterMain)
        {
            return;
        }

        FirstEnterMain = false;
        Instance.Log.LogInfo("First time entering Main Scene.");

        DLCManager.Initialize();
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

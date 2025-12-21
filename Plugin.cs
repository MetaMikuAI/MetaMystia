using BepInEx;
using BepInEx.Unity.IL2CPP;
using UnityEngine.UI;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using UnityEngine.SceneManagement;
using System;
using System.Diagnostics;
using MetaMystia.Debugger;
using System.Threading.Tasks;

namespace MetaMystia;
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance;
    public static WebDebugger Debugger = null;

    public Action<Scene, LoadSceneMode> LoadAction;

    public Plugin()
    {
        Instance = this;
    }

    public override void Load()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        try {
            ClassInjector.RegisterTypeInIl2Cpp<PluginManager>();
            Log.LogInfo("Registered C# Types in Il2Cpp");
        }
        catch {
            Log.LogError("FAILED to Register Il2Cpp Type!");
        }

        try {
            var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

            var originalHandle = AccessTools.Method(typeof(CanvasScaler), "Handle");
            var postHandle = AccessTools.Method(typeof(BootstrapPatch), "Handle");
            harmony.Patch(originalHandle, postfix: new HarmonyMethod(postHandle));

            var patchList = new Type[]
            {
                typeof(CharacterControllerUnitPatch),
                typeof(CharacterInputPatch),
                typeof(CookControllerPatch),
                typeof(DaySceneManagerPatch),
                typeof(DaySceneMapProfilePatch),
                typeof(DayScenePlayerInputPatch),
                typeof(IzakayaConfigPannelPatch),
                typeof(IzakayaConfigurePatch),
                typeof(IzakayaSelectorPanelPatch),
                typeof(MainSceneManagerPatch),
                typeof(NightSceneManagerPatch),
                typeof(PrepNightSceneManagerPatch),
                typeof(RunTimeSchedulerPatch),
                typeof(StaffSceneManagerPatch),
                typeof(UniversalGameManagerPatch),
                typeof(WorkSceneStoragePannelPatch),
                typeof(GuestsManagerPatch),
                typeof(GuestGroupControllerPatch),
            };
            foreach (var patch in patchList)
            {
                harmony.PatchAll(patch);
                Log.LogInfo($"Applied {patch.Name}");
            }
            
            // ShigureYuki.DebugClassPatcher.PatchAllInnerClass(ref harmony, typeof(ShigureYuki.DebugConsolePatch));
            
            // ShigureYuki.DiagnosticUtils.SafeAutoPatch.PatchMethod(harmony, 
            //     typeof(NightScene.GuestManagementUtility.GuestsManager), 
            //     nameof(NightScene.GuestManagementUtility.GuestsManager.SpawnNormalGuestGroup), 
            //     ShigureYuki.DiagnosticUtils.SafeAutoPatch.LogType.None);
            // ShigureYuki.DiagnosticUtils.SafeAutoPatch.PatchAllMethods(harmony, typeof(GameData.Core.Collections.NightSceneUtility.NormalGuest));
            // ShigureYuki.DiagnosticUtils.SafeAutoPatch.PatchAllMethods(harmony, typeof(GuestsManager));
            // ShigureYuki.DiagnosticUtils.SafeAutoPatch.PatchAllMethods(harmony, typeof(NightScene.GuestManagementUtility.GuestGroupController));
        }
        catch (Exception ex) {
            Log.LogError($"FAILED to Apply Hooks! {ex.Message}");
        }
    }

    public static void StartWebDebuggerIfNotStarted()
    {
        if (Debugger == null)
        {
            Instance.Log.LogInfo("Starting Web Debugger...");
            Debugger = new WebDebugger();
            Debugger.Start();
        }
    }

    class BootstrapPatch
    {
        [HarmonyPostfix]
        static void Handle()
        {
            if (PluginManager.Instance == null) {
                Plugin.Instance.Log.LogMessage("Bootstrapping Trainer...");
                try {
                    PluginManager.Create("PluginManager");
                    if (PluginManager.Instance != null) {
                        Plugin.Instance.Log.LogMessage("Trainer Bootstrapped!");
                    }
                }
                catch (Exception e) {
                    Plugin.Instance.Log.LogMessage($"ERROR Bootstrapping Trainer: {e.Message}");
                }
            }
        }
    }
}

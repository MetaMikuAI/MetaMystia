using System;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using MetaMystia.Debugger;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MetaMystia;
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance;
    public static WebDebugger Debugger = null;

    public Action<Scene, LoadSceneMode> LoadAction;
    public static bool FirstEnterMain = true;
    public const bool EnableWebConsole = false;

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
                typeof(DataBaseCharacterPatch),
                typeof(DaySceneManagerPatch),
                typeof(DaySceneMapProfilePatch),
                typeof(DayScenePlayerInputPatch),
                typeof(DialogPannelPatch),
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
                typeof(WorkSceneServePannelPatch),
                typeof(GameTimeManagerPatch),
                typeof(RunTimeAlbumPatch),
                typeof(ResultSceneManagerPatch)
            };
            foreach (var patch in patchList)
            {
                harmony.PatchAll(patch);
                Log.LogInfo($"Applied {patch.Name}");
            }
            
            // ShigureYuki.DebugClassPatcher.PatchAllInnerClass(ref harmony, typeof(ShigureYuki.DebugConsolePatch));
            NetAction.RegisterAllFormatter();

        }
        catch (Exception ex) {
            Log.LogError($"FAILED to Apply Hooks! {ex.Message}");
        }
    }

    public static void EnterMainScene()
    {
        if (!FirstEnterMain)
        {
            return;
        }
        
        FirstEnterMain = false;
        Instance.Log.LogInfo("First time entering Main Scene.");
        
        if (Debugger == null && EnableWebConsole)
        {
            Debugger = new WebDebugger();
            Debugger.Start();
        }
        
        ResourceExManager.Initialize();
        ResourceExManager.InjectCharacters();

        DLCManager.Initialize();
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

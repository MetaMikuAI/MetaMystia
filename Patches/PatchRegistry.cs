using System;
using HarmonyLib;

using MetaMystia.Patch;
using SgrYuki;

namespace MetaMystia.Patch;

[AutoLog]
public static partial class PatchRegistry
{
    public static readonly Type[] Patches = [
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
        typeof(CharacterControllerInputGeneratorComponentPatch),
        typeof(DayScenePlayerInputPatch),
        typeof(DaySceneMapPatch),
        typeof(NoteBookProfilePannelPatch),

        // PrepScene Patches
        typeof(IzakayaConfigPannelPatch),
        typeof(IzakayaConfigurePatch),
        typeof(IzakayaSelectorPanelPatch),

        // WorkScene Patches
        typeof(CookControllerPatch),
        typeof(SellablePatch),
        typeof(GuestsManagerPatch),
        typeof(GuestGroupControllerPatch),
        typeof(WorkSceneServePannelPatch),
        typeof(WorkSceneStoragePannelPatch),
        typeof(QTERewardManagerPatch),
        typeof(NightSceneEventManagerPatch),
        typeof(MystiaQTEBuffRewardPatch),
        typeof(GameTimeManagerPatch),

        typeof(RunTimeAlbumPatch),

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

    public static readonly Type[] NativeHooks = [
        typeof(SpawnNormalGuestGroupHook)
    ];

    public static bool AllPatched => PatchedException == null;
    public static Exception PatchedException { get; set; }

    public static void ApplyAll(Harmony harmony)
    {
        try
        {
            Log.LogInfo($"Patching {Patches.Length} modules...");
            for (int i = 0; i < Patches.Length; i++)
            {
                var patch = Patches[i];
                try
                {
                    harmony.PatchAll(patch);
                    Log.LogInfo($"  [{i + 1}/{Patches.Length}] {patch.Name} OK");
                }
                catch (Exception ex)
                {
                    Log.LogError($"  [{i + 1}/{Patches.Length}] {patch.Name} FAILED: {ex.Message}");
                    throw;
                }
            }

            NativeDllExtractor.Extract("MetaMystia.Patches.Native.Runtime.MinHook.x64.dll", MinHook.DLLFilename);

            Log.LogInfo($"Installing {NativeHooks.Length} native hooks...");
            for (int i = 0; i < NativeHooks.Length; i++)
            {
                var hook = NativeHooks[i];
                try
                {
                    hook.GetMethod("InstallHook").Invoke(null, null);
                    Log.LogInfo($"  [{i + 1}/{NativeHooks.Length}] {hook.Name} OK");
                }
                catch (Exception ex)
                {
                    Log.LogError($"  [{i + 1}/{NativeHooks.Length}] {hook.Name} FAILED: {ex.Message}");
                    throw;
                }
            }
        }
        catch (Exception ex)
        {
            Log.LogFatal($"FAILED to apply patches: {ex.Message}");
            PatchedException = ex;
        }
    }
}

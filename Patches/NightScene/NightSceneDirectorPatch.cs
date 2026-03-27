// This Patch is disabled temporarily

// using HarmonyLib;

// using NightScene;

// using MetaMystia.Network;
// using static MetaMystia.Patch.HarmonyPrefixFlow;

// namespace MetaMystia.Patch;

// [HarmonyPatch(typeof(NightSceneDirector))]
// [AutoLog]
// public static partial class NightSceneDirectorPatch
// {
//     [HarmonyPatch(nameof(NightSceneDirector.StartTutorial))]
//     [HarmonyPrefix]
//     public static bool StartTutorial_Prefix()
//     {
//         if (!MpManager.IsConnected) return RunOriginal;
//         Log.Debug("Skipping StartTutorial (multiplayer)");
//         return SkipOriginal;
//     }

//     [HarmonyPatch(nameof(NightSceneDirector.StartTutorial2))]
//     [HarmonyPrefix]
//     public static bool StartTutorial2_Prefix()
//     {
//         if (!MpManager.IsConnected) return RunOriginal;
//         Log.Debug("Skipping StartTutorial2 (multiplayer)");
//         return SkipOriginal;
//     }

//     [HarmonyPatch(nameof(NightSceneDirector.StartTutorial3))]
//     [HarmonyPrefix]
//     public static bool StartTutorial3_Prefix()
//     {
//         if (!MpManager.IsConnected) return RunOriginal;
//         Log.Debug("Skipping StartTutorial3 (multiplayer)");
//         return SkipOriginal;
//     }
// }

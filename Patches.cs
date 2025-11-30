using HarmonyLib;
using UnityEngine;
using Common.CharacterUtility;
using BepInEx.Logging;
using DayScene.Input;
using GameData.RunTime.Common;
using DayScene;
using System.Collections.Generic;
using System.Linq;

namespace MetaMystia;

[HarmonyPatch(typeof(CharacterControllerInputGeneratorComponent))]
public class CharacterInputPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[CharacterInputPatch]";

    [HarmonyPatch(nameof(CharacterControllerInputGeneratorComponent.UpdateInputDirection))]
    [HarmonyPrefix]
    public static void UpdateInputDirection_Prefix(CharacterControllerInputGeneratorComponent __instance, ref Vector2 inputDirection)
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen)
        {
            inputDirection = Vector2.zero;
        }

        try
        {
            var playerInputGenerator = MystiaManager.Instance.GetInputGenerator();
            if (playerInputGenerator != null && __instance == playerInputGenerator)
            {
                MystiaManager.InputDirection = inputDirection;
                MpManager.Instance.SendSync();
            }
        }
        catch (System.Exception e)
        {
            Log.LogError($"{LOG_TAG} Error in UpdateInputDirection_Prefix: {e.Message}");
        }
    }
}

[HarmonyPatch(typeof(DayScenePlayerInputGenerator))]
public class DayScenePlayerInputPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintPerformed))]
    [HarmonyPrefix]
    public static bool OnSprintPerformed_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen) return false;
        MystiaManager.IsSprinting = true;
        MpManager.Instance.SendSync();
        return true;
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintCanceled))]
    [HarmonyPrefix]
    public static void OnSprintCanceled_Prefix()
    {
        MystiaManager.IsSprinting = false;
        MpManager.Instance.SendSync();
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.TryInteract))]
    [HarmonyPrefix]
    public static bool TryInteract_Prefix()
    {
        if (PluginManager.Console != null && PluginManager.Console.IsOpen) return false;
        if (MystiaManager.isReady) return false;
        return true;
    }
}

[HarmonyPatch(typeof(RunTimeScheduler))]
public class RunTimeSchedulerPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(RunTimeScheduler.OnEnterDaySceneMap))]
    [HarmonyPostfix]
    public static void OnEnterDaySceneMap_Postfix(string mapLabel)
    {
        MystiaManager.MapLabel = mapLabel;
        MpManager.Instance.SendSync();
    }
}


// For debug
[HarmonyPatch(typeof(Common.CharacterUtility.CharacterControllerUnit))]
public class CharacterControllerUnitPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[CharacterControllerUnitPatch]";
    
    // 供后续调试用
    [HarmonyPatch("GetTargetMovePosition")]
    [HarmonyPrefix]
    public static void GetTargetMovePosition_Prefix(Vector3 inputDirection)
    {
        try
        {
            Log.LogDebug($"{LOG_TAG} GetTargetMovePosition called with inputDirection: {inputDirection}");
        }
        catch (System.Exception e)
        {
            Log.LogError($"{LOG_TAG} Error in GetTargetMovePosition_Prefix: {e.Message}");
        }
    }

    [HarmonyPatch("GetTargetMovePosition")]
    [HarmonyPostfix]
    public static void GetTargetMovePosition_Postfix(Vector3 inputDirection, ref Vector2 __result)
    {
        try
        {
            Log.LogDebug($"{LOG_TAG} GetTargetMovePosition returned: {__result}");
        }
        catch (System.Exception e)
        {
            Log.LogError($"{LOG_TAG} Error in GetTargetMovePosition_Postfix: {e.Message}");
        }
    }
}

// NOTE IMPORTANT: Don't patch this! Patching this will lead to game crash
[HarmonyPatch(typeof(SplashScene.SceneManager))]
public class SceneManagerPatch
{
    [HarmonyPatch("EnableDebugCosole", MethodType.Getter)]
    [HarmonyPostfix]
    public static void EnableDebugCosole_Postfix(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPatch("CurrentConsoleMode", MethodType.Getter)]
    [HarmonyPostfix]
    public static void CurrentConsoleMode_Postfix(ref GamePlatform.Systems.ConsoleMode __result)
    {
        __result = GamePlatform.Systems.ConsoleMode.Full;
    }
}


[HarmonyPatch(typeof(CharacterControllerUnit))]
public class CharacterControllerUnitInitializePatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[CharacterControllerUnitInitializePatch]";

    [HarmonyPatch("Initialize")]
    [HarmonyPrefix]
    public static void Initialize_Prefix(CharacterControllerUnit __instance, ref bool shouldTurnOnCollider)
    {
        var kyoukoNames = new List<string>
        {
            "幽谷响子", // CHS
            "幽谷響子", // CHT, JPN
            "Kyouko Kasodani",  // ENG
            "카소다니 쿄코", // KOR
        };
        if (kyoukoNames.Any(name => __instance.name.Equals(name)))
        {
            shouldTurnOnCollider = true;
            Log.LogMessage($"{LOG_TAG} found {__instance.name}, forcing shouldTurnOnCollider to true");
        } 
    }
}

[HarmonyPatch(typeof(DayScene.SceneManager))]
public class DaySceneSceneManagerPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[DaySceneSceneManagerPatch]";

    [HarmonyPatch(nameof(DayScene.SceneManager.OnDayOver))]
    [HarmonyPrefix]
    public static bool OnDayOver_Prefix()
    {
        if (!MpManager.Instance.IsConnected)
        {
            Log.LogDebug($"{LOG_TAG} Not in multiplayer session, skipping prefix");
            return true; // Not in multiplayer session, proceed as normal
        }
        /*
            [MetaMiku 注]
            状态机: 
                由 01 表示 Mystia 未准备好，而 Kyouko 已准备好
                
                                  00
                               ↙    ↘
                             10        01
                               ↘    ↙
                                  11
    
                00->10, 01->11 为游戏原生触发
                    00->10: 需要跳过 OnDayOver 而显示「准备未完成」对话框
                    01->11: 需要先跳过 OnDayOver 后在显示「准备完成」对话框的回调中执行 OnDayOver
                00->01, 10->11 为 MpManager 触发
                    00->01: 正常更新状态，不触发 OnDayOver_Prefix 也不执行 OnDayOver
                    10->11: 需要先显示「准备完成」对话框再在其回调中执行 OnDayOver
        */

        Log.LogDebug($"{LOG_TAG} Day over detected");

        // 00 -> 10
        if (!MystiaManager.isReady && !KyoukoManager.isReady)
        {
            Log.LogInfo($"{LOG_TAG} Both Mystia and Kyouko are not ready -> Mystia is ready => show **not ready** dialog");
            MpManager.Instance.SendReady();
            Utils.ShowReadyDialog(false, () => MystiaManager.isReady = true);
            return false;
        }

        // 01 -> 11
        if (!MystiaManager.isReady && KyoukoManager.isReady) 
        {
            Log.LogInfo($"{LOG_TAG} Mystia is not ready but Kyouko is ready -> both are ready => show **ready** dialog");
            MpManager.Instance.SendReady();
            Utils.ShowReadyDialog(true, () => 
            {
                MystiaManager.isReady = true;
                DayScene.SceneManager.Instance.OnDayOver();
            });
            return false;
        }

        // 00 -> 01: Not here -> MultiplayerManager handles it

        // 10 -> 11: Not here -> MultiplayerManager handles it

        // 11: 回调中直接执行 OnDayOver
        return true;
    }
}


// 分析中，临时用
[HarmonyPatch(typeof(Common.UI.IzakayaSelectorPanel_New))]
public class IzakayaSelectorPanelPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[IzakayaSelectorPanel]";

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapInitialize))]
    [HarmonyPrefix]
    public static void OnGuideMapInitialize_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapInitialize called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnSecondarySwitchUpdate))]
    [HarmonyPrefix]
    public static void OnSecondarySwitchUpdate_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnSecondarySwitchUpdate called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OpenDescriptionMenu))]
    [HarmonyPrefix]
    public static void OpenDescriptionMenu_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OpenDescriptionMenu called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapPanelPreOpen))]
    [HarmonyPrefix]
    public static void OnGuideMapPanelPreOpen_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapPanelPreOpen called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapPanelPostOpen))]
    [HarmonyPrefix]
    public static void OnGuideMapPanelPostOpen_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapPanelPostOpen called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapPanelEndOpen))]
    [HarmonyPrefix]
    public static void OnGuideMapPanelEndOpen_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapPanelEndOpen called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapClose))]
    [HarmonyPrefix]
    public static void OnGuideMapClose_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapClose called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.GetSpotOpenStatus))]
    [HarmonyPrefix]
    public static void GetSpotOpenStatus_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} GetSpotOpenStatus called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.IsGuideMapSpotCanBeSelected))]
    [HarmonyPrefix]
    public static void IsGuideMapSpotCanBeSelected_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} IsGuideMapSpotCanBeSelected called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapSpotSelected))]
    [HarmonyPrefix]
    public static void OnGuideMapSpotSelected_Prefix(ref Common.UI.GlobalMap.IGuideMapSpot guideMapSpot)
    {
        Log.LogMessage($"{LOG_TAG} OnGuideMapSpotSelected called, guideMapSpot.PrimaryName: {guideMapSpot.PrimaryName}");
        if (guideMapSpot.PrimaryName == "DLC2_FormerHell") {
            Utils.ShowReadyDialog(false, null);
        }
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.UpdateCurrentIzakaya))]
    [HarmonyPrefix]
    public static void UpdateCurrentIzakaya_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} UpdateCurrentIzakaya called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.CalculateIzakayaId))]
    [HarmonyPrefix]
    public static void CalculateIzakayaId_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} CalculateIzakayaId called");
    }

    // // CANNOT BE PATCHED
    // [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.TryChangeIzakayaLevel))]
    // [HarmonyPrefix]
    // public static void TryChangeIzakayaLevel_Bool_Prefix(ref bool isIncrease)
    // {
    //     Log.LogMessage($"{LOG_TAG} TryChangeIzakayaLevel(bool) called");
    // }

    // // CANNOT BE PATCHED
    // [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.TryChangeIzakayaLevel))]
    // [HarmonyPrefix]
    // public static void TryChangeIzakayaLevel_Level_Prefix()
    // {
    //     Log.LogMessage($"{LOG_TAG} TryChangeIzakayaLevel(IzakayaLevel) called");
    // }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.UpdateToggleStatus))]
    [HarmonyPrefix]
    public static void UpdateToggleStatus_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} UpdateToggleStatus called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.PostInitializeGuideMapSpot))]
    [HarmonyPrefix]
    public static void PostInitializeGuideMapSpot_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} PostInitializeGuideMapSpot called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.PrintPartnerData))]
    [HarmonyPrefix]
    public static void PrintPartnerData_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} PrintPartnerData called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.LoadSelectionToIzakayaConfig))]
    [HarmonyPrefix]
    public static void LoadSelectionToIzakayaConfig_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} LoadSelectionToIzakayaConfig called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.Cleanup_Generated))]
    [HarmonyPrefix]
    public static void Cleanup_Generated_Prefix()
    {
        Log.LogMessage($"{LOG_TAG} Cleanup_Generated called");
    }
}
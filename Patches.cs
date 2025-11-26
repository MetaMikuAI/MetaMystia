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
            Log.LogWarning($"{LOG_TAG} found {__instance.name}, forcing shouldTurnOnCollider to true");
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
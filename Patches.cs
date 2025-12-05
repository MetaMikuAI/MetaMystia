using HarmonyLib;
using UnityEngine;
using Common.CharacterUtility;
using BepInEx.Logging;
using DayScene.Input;
using GameData.RunTime.Common;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MetaMystia;

public class PatchBase<TChild>
{
    protected static ManualLogSource Log => Plugin.Instance.Log;
    protected static readonly string LOG_TAG = $"[{typeof(TChild).Name}]";
}


[HarmonyPatch(typeof(CharacterControllerInputGeneratorComponent))]
public class CharacterInputPatch : PatchBase<CharacterInputPatch>
{
    [HarmonyPatch(nameof(CharacterControllerInputGeneratorComponent.UpdateInputDirection))]
    [HarmonyPrefix]
    public static void UpdateInputDirection_Prefix(CharacterControllerInputGeneratorComponent __instance, ref Vector2 inputDirection)
    {
        if (!MpManager.Instance.IsConnected || PluginManager.Instance.CurrentGameStage == PluginManager.GameStage.PrepScene)
        {
            return;
        }

        // TODO: sync for night scene
        if (PluginManager.Instance.CurrentGameStage == PluginManager.GameStage.NightScene)
        {
            return;
        }

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
public class DayScenePlayerInputPatch : PatchBase<DayScenePlayerInputPatch>
{
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
public class RunTimeSchedulerPatch : PatchBase<RunTimeSchedulerPatch>
{
    [HarmonyPatch(nameof(RunTimeScheduler.OnEnterDaySceneMap))]
    [HarmonyPostfix]
    public static void OnEnterDaySceneMap_Postfix(string mapLabel)
    {
        MystiaManager.MapLabel = mapLabel;
        MpManager.Instance.SendSync();
    }
}


[HarmonyPatch(typeof(CharacterControllerUnit))]
public class CharacterControllerUnitInitializePatch : PatchBase<CharacterControllerUnitInitializePatch>
{
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
public class DaySceneSceneManagerPatch : PatchBase<DaySceneSceneManagerPatch>
{
    [HarmonyPatch(nameof(DayScene.SceneManager.Awake))]
    [HarmonyPostfix]
    public static void Awake_Postfix()
    {
        PluginManager.Instance.CurrentGameStage = PluginManager.GameStage.DayScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to DayScene");
    }

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
            DialogManager.ShowReadyDialog(false, () => MystiaManager.isReady = true);
            return false;
        }

        // 01 -> 11
        if (!MystiaManager.isReady && KyoukoManager.isReady) 
        {
            Log.LogInfo($"{LOG_TAG} Mystia is not ready but Kyouko is ready -> both are ready => show **ready** dialog");
            MpManager.Instance.SendReady();
            DialogManager.ShowReadyDialog(true, () => 
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


// 分析中,临时用
[HarmonyPatch(typeof(Common.UI.IzakayaSelectorPanel_New))]
public class IzakayaSelectorPanelPatch : PatchBase<IzakayaSelectorPanelPatch>
{
    public static bool skipPatchIzakayaSelectionConfirmation = false;
    public static Common.UI.IzakayaSelectorPanel_New instanceRef = null;
    public static Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot> cachedSpots = new Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot>();
    public static Common.UI.IzakayaLevel cachedLevel;

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapInitialize))]
    [HarmonyPrefix]
    public static void OnGuideMapInitialize_Prefix(Common.UI.IzakayaSelectorPanel_New __instance)
    {   
        instanceRef = __instance;
        Log.LogInfo($"{LOG_TAG} OnGuideMapInitialize called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New._OnGuideMapInitialize_b__21_0))]
    [HarmonyPrefix]
    public static bool _OnGuideMapInitialize_b__21_0_Prefix(ref Common.UI.IzakayaSelectorPanel_New __instance)
    {
        // MetaMiku 注:
        //     这里原本实际上是选择 Izakaya 的逻辑
        //     同样采用对称的设计，下面以 A 首先做出选择，B 之后进行确认来描述流程
        //     一共是四种事件，两件来自玩家，两件来自网络
        //     
        //     Peer A -> 「前往营业」 
        //            -> 检查对端是否已经选择地图 
        //                 -> 否 -> 发送 SELECT 包并跳过 _OnGuideMapInitialize_b__21_0，展示对话
        //                 -> 是 -> 对称，略
        //     
        //     Peer A -> 接收 CONFIRM 包 
        //            -> 检查已有选择，不匹配则应强制修改
        //            -> 展示「确认」对话
        //            -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束
        //     
        //     Peer B -> 接收 SELECT 包，缓存并展示「提示」对话
        //     
        //     Peer B -> 「前往营业」
        //            -> 检查对端是否已经选择地图 
        //                -> 否 -> 对称，略
        //                -> 是 -> 检查 地图/level 是否匹配
        //                          -> 否 -> 展示「拒绝」对话
        //                          -> 是 -> 发送 CONFIRM 包
        //                                -> 展示「确认」对话
        //                                -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束
        
        Log.LogInfo($"{LOG_TAG} _OnGuideMapInitialize_b__21_0 called");

        if (!MpManager.Instance.IsConnected)
        {
            Log.LogWarning($"{LOG_TAG} Not in multiplayer session, skipping patch");
            return true;
        }
        if (skipPatchIzakayaSelectionConfirmation)
        {
            Log.LogWarning($"{LOG_TAG} skipPatchIzakayaSelectionConfirmation is true, skipping patch");
            return true;
        }

        // 参考 Common.UI.IzakayaLevel
        // public enum IzakayaLevel
        // {
        //     Level1 = 1,
        //     Level2 = 2,
        //     Level3 = 3,
        //     Null = 0
        // }
        
        var izakayaMapLabel = __instance.m_CurrentSelectedSpot.PrimaryName;
        var izakayaLevel = (int)__instance.m_CurrentSelectedIzakayaLevel;
        Log.LogWarning($"Selected Spot: {izakayaMapLabel}, Level: {izakayaLevel}");

        if (KyoukoManager.IzakayaMapLabel == "" || KyoukoManager.IzakayaLevel == 0)
        {
            Log.LogWarning($"{LOG_TAG} Kyouko has not selected an Izakaya yet -> send SELECT and skip");
            MpManager.Instance.SendSelectedIzakaya(izakayaMapLabel, izakayaLevel);
            DialogManager.ShowSelectedDialog(izakayaMapLabel, null);
            return false;
        }

        if (izakayaMapLabel != KyoukoManager.IzakayaMapLabel || izakayaLevel != KyoukoManager.IzakayaLevel)
        {
            Log.LogWarning($"{LOG_TAG} Selected Izakaya does not match Kyouko's selection -> show rejection dialog");
            DialogManager.ShowRejectDialog(izakayaMapLabel, KyoukoManager.IzakayaMapLabel, null);
            return false;
        }

        Log.LogWarning($"{LOG_TAG} Selected Izakaya matches Kyouko's selection -> send CONFIRM and show confirmation dialog");
        MpManager.Instance.SendConfirmedIzakaya(izakayaMapLabel, izakayaLevel);
        
        System.Action closePanelCallback = () => {
            skipPatchIzakayaSelectionConfirmation = true;
            instanceRef._OnGuideMapInitialize_b__21_0();
            skipPatchIzakayaSelectionConfirmation = false;
        };

        DialogManager.ShowConfirmDialog(izakayaMapLabel, closePanelCallback);
        return false;
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.TryChangeIzakayaLevel), new[] { typeof(Common.UI.IzakayaLevel), typeof(Common.UI.IzakayaLevel) }, new[] { ArgumentType.Ref, ArgumentType.Normal })]
    [HarmonyPrefix]
    public static void TryChangeIzakayaLevel_Prefix(ref Common.UI.IzakayaLevel izakayaLevel, Common.UI.IzakayaLevel targetLevel)
    {
        cachedLevel = izakayaLevel;
        Log.LogInfo($"{LOG_TAG} TryChangeIzakayaLevel called with izakayaLevel: {izakayaLevel}, targetLevel: {targetLevel}");
    }


    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapSpotSelected))]
    [HarmonyPrefix]
    public static void OnGuideMapSpotSelected_Prefix(ref Common.UI.GlobalMap.IGuideMapSpot guideMapSpot)
    {
        if (guideMapSpot != null && !string.IsNullOrEmpty(guideMapSpot.PrimaryName))
        {
            cachedSpots[guideMapSpot.PrimaryName] = guideMapSpot;
        }

        Log.LogInfo($"{LOG_TAG} OnGuideMapSpotSelected called, guideMapSpot.PrimaryName: {guideMapSpot.PrimaryName}");

    }
}

[HarmonyPatch(typeof(Common.UI.UniversalGameManager))]
public class UniversalGameManagerPatch : PatchBase<UniversalGameManagerPatch>
{
    [HarmonyPatch(nameof(Common.UI.UniversalGameManager.OpenDialogMenu))]
    [HarmonyPrefix]
    public static bool OnGuideMapInitialize_Prefix(ref GameData.Profile.DialogPackage dialogPackage, ref System.Action onFinishCallback)
    {
        // 该 hook 用于在 多人模式 中跳过原有 单人模式 下结束白天时的 OnTransitionToNight 对话
        Log.LogWarning($"{LOG_TAG} OpenDialogMenu called with dialogPackage: {dialogPackage.name}");
        if (MpManager.Instance.IsConnected && dialogPackage.name == "OnTransitionToNight")
        {
            Log.LogWarning($"{LOG_TAG} Skipping OnTransitionToNight dialog in multiplayer session");
            onFinishCallback?.Invoke();
            return false;
        }
        return true;
    }
}



[HarmonyPatch(typeof(GameData.Profile.DaySceneMapProfile))]
public class DaySceneMapProfilePatch : PatchBase<DaySceneMapProfilePatch>
{
    public static GameData.Profile.DaySceneMapProfile instanceRef = null;

    // DaySceneMapProfile()
    [HarmonyPatch(MethodType.Constructor)]
    public static void DaySceneMapProfile_Constructor_Postfix(GameData.Profile.DaySceneMapProfile __instance)
    {
        Log.LogWarning($"DaySceneMapProfile created: {__instance.name}");
        instanceRef = __instance;
    }

    // [HarmonyPatch("allMapNodes", MethodType.Getter)]
    // [HarmonyPostfix]
    // public static void EnableDebugCosole_Postfix(ref Il2CppReferenceArray<GameData.Profile.DaySceneMapProfile.MapNode> __result)
    // {
        
    //     foreach (var node in __result)
    //     {
    //         Log.LogWarning($"MapNode: {node.mapName}");
    //     }
    // }
}

[HarmonyPatch]
public class SceneManagerPatch : PatchBase<SceneManagerPatch>
{
    [HarmonyPatch(typeof(NightScene.SceneManager), nameof(NightScene.SceneManager.Start))]
    [HarmonyPostfix]
    public static void NightScene_Start_Postfix()
    {
        PluginManager.Instance.CurrentGameStage = PluginManager.GameStage.NightScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to NightScene");
    }

    [HarmonyPatch(typeof(MainScene.SceneManager), nameof(MainScene.SceneManager.Awake))]
    [HarmonyPostfix]
    public static void MainScene_Awake_Postfix()
    {
        PluginManager.Instance.CurrentGameStage = PluginManager.GameStage.MainScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to MainScene");
    }

    [HarmonyPatch(typeof(StaffScene.SceneManager), nameof(StaffScene.SceneManager.Start))]
    [HarmonyPostfix]
    public static void StaffScene_Start_Postfix()
    {
        PluginManager.Instance.CurrentGameStage = PluginManager.GameStage.StaffScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to StaffScene");
    }

    [HarmonyPatch(typeof(PrepNightScene.SceneManager), nameof(PrepNightScene.SceneManager.Start))]
    [HarmonyPostfix]
    public static void PrepNightScene_Start_Postfix()
    {
        PluginManager.Instance.CurrentGameStage = PluginManager.GameStage.PrepScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to PrepScene");
    }
}

[HarmonyPatch(typeof(GameData.RunTime.NightSceneUtility.IzakayaConfigure))]
public class IzakayaConfigurePatch : PatchBase<IzakayaConfigurePatch>
{
    // MetaMiku 注:
    //     下面分别是 IzakayaConfigure 中 菜单/酒水/厨具 注册与注销 的 hook
    //     但是其中对于 厨具，厨具无论是注册还是注销，都会触发 RegisterToCookers，而只有在注销时才会触发 LogOffFromCookers
    
    private static int _lastLogoffCookerId = -1;
    private static long _lastLogoffCookerTime = 0;

    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.RegisterToDailyRecipes))]
    [HarmonyPrefix]
    public static void RegisterToDailyRecipes_Prefix(int id)
    {
        Log.LogInfo($"{LOG_TAG} RegisterToDailyRecipes: {id}");
        PrepSceneManager.localPrepTable.RecipeAdditions[id] = MpManager.GetSynchronizedTimestampNow;
        MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable);
    }
    
    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.RegisterToDailyBeverages))]
    [HarmonyPrefix]
    public static void RegisterToDailyBeverages_Prefix(int id)
    {
        Log.LogInfo($"{LOG_TAG} RegisterToDailyBeverages: {id}");
        PrepSceneManager.localPrepTable.BeverageAdditions[id] = MpManager.GetSynchronizedTimestampNow;
        MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable);
    }

    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.RegisterToCookers))]
    [HarmonyPrefix]
    public static void RegisterToCookers_Prefix(int id)
    {
        // long now = MpManager.GetSynchronizedTimestampNow;
        
        // // Workaround: If this register is triggered by logoff, ignore it
        // if (id == _lastLogoffCookerId && Math.Abs(now - _lastLogoffCookerTime) < 100)
        // {
        //      Log.LogInfo($"{LOG_TAG} RegisterToCookers: {id} (Ignored due to recent logoff)");
        //      return;
        // }

        Log.LogInfo($"{LOG_TAG} RegisterToCookers: {id}");
        // PrepSceneManager.localPrepTable.CookersAdditions[id] = now;
    }

    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.LogoffFromDailyRecipes))]
    [HarmonyPrefix]
    public static void LogoffFromDailyRecipes_Prefix(int id)
    {
        Log.LogInfo($"{LOG_TAG} LogoffFromDailyRecipes: {id}");
        PrepSceneManager.localPrepTable.RecipeDeletions[id] = MpManager.GetSynchronizedTimestampNow;
        MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable);
    }

    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.LogoffFromDailyBeverages))]
    [HarmonyPrefix]
    public static void LogoffFromDailyBeverages_Prefix(int id)
    {
        Log.LogInfo($"{LOG_TAG} LogoffFromDailyBeverages: {id}");
        PrepSceneManager.localPrepTable.BeverageDeletions[id] = MpManager.GetSynchronizedTimestampNow;
        MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable);
    }

    [HarmonyPatch(nameof(GameData.RunTime.NightSceneUtility.IzakayaConfigure.LogOffFromCookers))]
    [HarmonyPrefix]
    public static void LogOffFromCookers_Prefix(int index)
    {
        // long now = MpManager.GetSynchronizedTimestampNow;
        Log.LogInfo($"{LOG_TAG} LogOffFromCookers: {index}");
        
        // PrepSceneManager.localPrepTable.CookersDeletions[id] = now;
        
        // _lastLogoffCookerId = id;
        // _lastLogoffCookerTime = now;
    }
}


[HarmonyPatch(typeof(PrepNightScene.UI.IzakayaConfigPannel))]
public class IzakayaConfigPannelPatch : PatchBase<IzakayaConfigPannelPatch>
{
    public static PrepNightScene.UI.IzakayaConfigPannel instanceRef = null;

    [HarmonyPatch(MethodType.Constructor)]
    public static void IzakayaConfigPannel_Constructor_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel instance created");
    }

    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.OnEnable))]
    public static void IzakayaConfigPannel_OnEnable_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel fully initialized and ready");
    }

    // OnPanelOpen
    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.OnPanelOpen))]
    public static void IzakayaConfigPannel_OnPanelOpen_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
    }

    // GoToSpecific
    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.GoToSpecific))]
    public static void IzakayaConfigPannel_GoToSpecific_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance, int index)
    {
        instanceRef = __instance;
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel GoToSpecific called with index: {index}");
    }

    // GotoWork
    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.GotoWork))]
    public static void IzakayaConfigPannel_GotoWork_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogWarning($"{LOG_TAG} IzakayaConfigPannel GotoWork called");
    }

    // 

}
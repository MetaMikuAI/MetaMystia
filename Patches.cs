using HarmonyLib;
using UnityEngine;
using Common.CharacterUtility;
using BepInEx.Logging;
using DayScene.Input;
using GameData.RunTime.Common;
using System.Collections.Generic;
using System.Linq;
using Common.UI;
using Il2CppSystem;

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
        if (!MpManager.Instance.IsConnected || PluginManager.Instance.CurrentGameScene == Scene.IzakayaPrepScene)
        {
            return;
        }

        // TODO: sync for night scene
        if (PluginManager.Instance.CurrentGameScene == Scene.WorkScene)
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
        if (MystiaManager.IsReady) return false;
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
        PluginManager.Instance.CurrentGameScene = Scene.DayScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to DayScene");
    }

    public static bool _skipPatchOnDayOver = false;

    [HarmonyPatch(nameof(DayScene.SceneManager.OnDayOver))]
    [HarmonyPrefix]
    public static bool OnDayOver_Prefix()
    {
        if (_skipPatchOnDayOver)
        {
            Log.LogDebug($"{LOG_TAG} skipPatch is true, skipping prefix");
            return true;
        }
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
        if (!MystiaManager.IsReady && !KyoukoManager.IsReady)
        {
            Log.LogInfo($"{LOG_TAG} Both Mystia and Kyouko are not ready -> Mystia is ready => show **not ready** dialog");
            MpManager.Instance.SendReady();
            MystiaManager.IsReady = true;
            DialogManager.ShowReadyDialog(false);
            return false;
        }

        // 01 -> 11
        if (!MystiaManager.IsReady && KyoukoManager.IsReady) 
        {
            Log.LogInfo($"{LOG_TAG} Mystia is not ready but Kyouko is ready -> both are ready => show **ready** dialog");
            MpManager.Instance.SendReady();
            MystiaManager.IsReady = true;
            DialogManager.ShowReadyDialog(true, () => 
            {
                _skipPatchOnDayOver = true;
                DayScene.SceneManager.Instance.OnDayOver();
                _skipPatchOnDayOver = false;
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
    public static bool _skipPatchIzakayaSelectionConfirmation = false;
    public static Common.UI.IzakayaSelectorPanel_New instanceRef = null;
    public static Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot> cachedSpots = new Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot>();

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
        if (_skipPatchIzakayaSelectionConfirmation)
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
            _skipPatchIzakayaSelectionConfirmation = true;
            instanceRef._OnGuideMapInitialize_b__21_0();
            _skipPatchIzakayaSelectionConfirmation = false;
        };

        DialogManager.ShowConfirmDialog(izakayaMapLabel, closePanelCallback);
        return false;
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.TryChangeIzakayaLevel), new[] { typeof(Common.UI.IzakayaLevel), typeof(Common.UI.IzakayaLevel) }, new[] { ArgumentType.Ref, ArgumentType.Normal })]
    [HarmonyPrefix]
    public static void TryChangeIzakayaLevel_Prefix(ref Common.UI.IzakayaLevel izakayaLevel, Common.UI.IzakayaLevel targetLevel)
    {
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
    public static bool OpenDialogMenu_Prefix(ref GameData.Profile.DialogPackage dialogPackage, Il2CppSystem.Action onFinishCallback, Il2CppSystem.Action<Dictionary<int, string>> overrideReplaceTextCallback = null, DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode.HideVisual)
    {
        // MetaMiku 注:
        //     该 hook 用于在 多人模式 中跳过原有 单人模式 下结束白天时的 OnTransitionToNight 对话
        //     直接执行 onFinishCallback?.Invoke() 会有异步问题，导致挂起
        //     使用携带原有 onFinishCallback 回调的空对话包替代原有对话包实现

        // Log.LogInfo($"{LOG_TAG} OpenDialogMenu called with dialogPackage: {dialogPackage?.name}");
        if (!MpManager.Instance.IsConnected || dialogPackage?.name != "OnTransitionToNight") // dialogPackage 可能为空
        {
            return true;
        }
        
        Log.LogInfo($"{LOG_TAG} In multiplayer session and dialogPackage is OnTransitionToNight -> show empty dialog instead");
        UniversalGameManager.OpenDialogMenu(
            null,
            onFinishCallback: onFinishCallback,
            overrideReplaceTextCallback: null,
            previousPanelVisualMode: previousPanelVisualMode
        );
        return false;
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
        PluginManager.Instance.CurrentGameScene = Scene.WorkScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to WorkScene");
    }

    [HarmonyPatch(typeof(MainScene.SceneManager), nameof(MainScene.SceneManager.Awake))]
    [HarmonyPostfix]
    public static void MainScene_Awake_Postfix()
    {
        PluginManager.Instance.CurrentGameScene = Scene.MainScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to MainScene");
    }

    [HarmonyPatch(typeof(StaffScene.SceneManager), nameof(StaffScene.SceneManager.Start))]
    [HarmonyPostfix]
    public static void StaffScene_Start_Postfix()
    {
        PluginManager.Instance.CurrentGameScene = Scene.StaffScene;
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to StaffScene");
    }
}

[HarmonyPatch(typeof(GameData.RunTime.NightSceneUtility.IzakayaConfigure))]
public class IzakayaConfigurePatch : PatchBase<IzakayaConfigurePatch>
{
    // MetaMiku 注:
    //     下面分别是 IzakayaConfigure 中 菜单/酒水/厨具 注册与注销 的 hook
    //     但是其中对于 厨具，厨具无论是注册还是注销，都会触发 RegisterToCookers，而只有在注销时才会触发 LogOffFromCookers
    

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
    public static void RegisterToCookers_Prefix(int id, int index, bool checkPlayerHaveCooker)
    {
        var slots = PrepSceneManager.GetLocalCookerSlots();
        if (index < 0 || index >= slots.Length)
        {
            Log.LogWarning($"{LOG_TAG} RegisterToCookers out of range: id={id}, index={index}, checkPlayerHaveCooker={checkPlayerHaveCooker}");
            return;
        }

        long timestamp = MpManager.GetSynchronizedTimestampNow;
        slots[index].Id = id;
        slots[index].Timestamp = timestamp;

        Log.LogInfo($"{LOG_TAG} RegisterToCookers: id={id}, index={index}, ts={timestamp}, checkPlayerHaveCooker={checkPlayerHaveCooker}");

        MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable);
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
        Log.LogInfo($"{LOG_TAG} LogOffFromCookers: {index}");
    }
}


[HarmonyPatch(typeof(PrepNightScene.UI.IzakayaConfigPannel))]
public class IzakayaConfigPannelPatch : PatchBase<IzakayaConfigPannelPatch>
{
    public static PrepNightScene.UI.IzakayaConfigPannel instanceRef = null;

    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.OnPanelOpen))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_OnPanelOpen_Postfix(PrepNightScene.UI.IzakayaConfigPannel __instance)
    {
        instanceRef = __instance;
        Log.LogInfo($"{LOG_TAG} IzakayaConfigPannel OnPanelOpen called");
    }

    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel.GoToSpecific))]
    [HarmonyPostfix]
    public static void IzakayaConfigPannel_GoToSpecific_Postfix()
    {
        if (MpManager.Instance.IsConnected == false)
        {
            Log.LogInfo($"{LOG_TAG} Not in multiplayer session, skipping patch");
            return;
        }

        // MetaMiku 注:
        //     游戏原生的 GoToSpecific 会变更玩家的活跃选项面板，即 菜谱/酒水/厨具 三选一
        //     但是还会附带检查除去不合法的 厨具 选项
        //     如果在联机中直接调用该方法，可能会导致 厨具 选项出现不同步的问题
        //     因此这里做了一个补丁，强制在调用 GoToSpecific 之后再重新更新厨具选项
        PluginManager.Instance.RunOnMainThread(() => 
        {
            PrepSceneManager.UpdateCookers();
            PrepSceneManager.UpdateUI();
        });
        
    }
    
    [HarmonyPatch(nameof(PrepNightScene.UI.IzakayaConfigPannel._SolveDailyCompletion_b__61_7))]
    [HarmonyPrefix]
    public static bool _SolveDailyCompletion_b__61_7_Prefix()
    {
        if (!MpManager.Instance.IsConnected)
        {
            Log.LogInfo($"{LOG_TAG} Not in multiplayer session, skipping patch");
            return true;
        }

        // MetaMiku 注:
        //     当 Mystia 确认营业后，Prep 面板关闭，触发但跳过 _SolveDailyCompletion_b__61_7 Ready 信号
        //     等待 Kyouko 也准备好后合并 菜单/酒水/厨具 数据并真正进入工作场景
        //     当收到 Kyouko 的 Ready 信号后，立即返回 Ready 信号并直接调用 _SolveDailyCompletion_b__61_7 以真正进入工作场景
        //     即使双方同时确认营业，也不会导致数据分歧或死锁
        //     Mystia 必须等待对方也 Ready 才能继续的目的是确保数据的一致性
        //     _SolveDailyCompletion_b__61_7 负责关闭 PrepScene 并进入 WorkScene （大概）

        Log.LogInfo($"{LOG_TAG} _SolveDailyCompletion_b__61_7 called");
        var remotePlayerReady = PrepSceneManager.remotePlayerReady;
        if (!PrepSceneManager.localPlayerReady)
        {
            PrepSceneManager.localPlayerReady = true;
            MpManager.Instance.SendPrep(PrepSceneManager.localPrepTable, true);
        }
        Log.LogInfo($"{LOG_TAG} remotePlayerReady: {remotePlayerReady}");
        return remotePlayerReady;
    }
}


[HarmonyPatch(typeof(PrepNightScene.SceneManager))]
public class PrepNightSceneSceneManagerPatch : PatchBase<PrepNightSceneSceneManagerPatch>
{
    
    [HarmonyPatch(nameof(PrepNightScene.SceneManager.Start))]
    [HarmonyPostfix]
    public static void PrepNightScene_Start_Postfix()
    {
        PluginManager.Instance.CurrentGameScene = Scene.IzakayaPrepScene;
        PrepSceneManager.init();
        Log.LogInfo($"{LOG_TAG} CurrentGameStage switched to IzakayaPrepScene");
        
    }
    
    [HarmonyPatch(nameof(PrepNightScene.SceneManager.ToWork))]
    [HarmonyPrefix]
    public static bool ToWork_Prefix()
    {
        return true;
    }
}
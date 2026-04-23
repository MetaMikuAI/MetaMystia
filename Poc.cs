using System;
using System.Linq;
using Common;
using Common.UI;
using Cysharp.Threading.Tasks;
using DayScene;
using DayScene.Interactables;
using GameData.Core.Collections.DaySceneUtility;
using GameData.CoreLanguage;
using GameData.CoreLanguage.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MetaMystia.UI;
using UnityEngine;

using SceneManagerDS = DayScene.SceneManager;
using SceneDirectorCommon = Common.SceneDirector;

namespace MetaMystia;

// PoC: 复制当前 DaySceneMap 并以新 mapLabel 注册，最终通过模拟 SwapMap 链路加载之。
// F3 = Phase1 (注册)，F4 = Phase2 (切换)
[AutoLog]
public static partial class DaySceneMapPoc
{
    public const string TestLabel = "MetaTestMap";
    public const string TestMarker = "MetaTestSpawn";

    private static DaySceneMap _template;
    private static bool _registered;

    public static void RunPhase1_Register()
    {
        var sm = SceneManagerDS.Instance;
        if (sm == null || sm.CurrentActiveMap == null)
        {
            Log.LogWarning("[Poc] 需要先进入 DayScene 再按 F3");
            return;
        }
        if (_template != null)
        {
            Log.LogInfo($"[Poc] 模板已存在: {_template.name}");
            return;
        }

        var src = sm.CurrentActiveMap;
        Log.LogInfo($"[Poc] 克隆当前地图 {sm.CurrentActiveMapLabel} 作为模板");

        // ── 1. 克隆 GameObject 作为持久模板 ──
        _template = UnityEngine.Object.Instantiate(src.gameObject).GetComponent<DaySceneMap>();
        _template.gameObject.name = $"_PocTemplate_{TestLabel}";
        _template.gameObject.SetActive(false);
        UnityEngine.Object.DontDestroyOnLoad(_template.gameObject);

        // 重命名第一个 SpawnMarker 为已知 key（玩家落点）
        var firstMarker = _template.spawnMarkerField.GetComponentInChildren<SpawnMarker>(true);
        if (firstMarker == null)
        {
            Log.LogError("[Poc] 模板里没有 SpawnMarker，无法继续");
            return;
        }
        firstMarker.spawnMarkerName = TestMarker;
        // 清掉缓存：DaySceneMap.PreInitialize 会按需重建
        _template.allSpawnMarkers = null;
        _template.allCollectables = null;
        _template.initialized = false;
        _template.mapLabel = null;
        _template._Handle = null;

        // ── 视觉差异化：让 PoC 地图一眼可辨 ──
        // (a) 移除除目标 marker 外的所有 SpawnMarker
        foreach (var m in _template.spawnMarkerField.GetComponentsInChildren<SpawnMarker>(true))
        {
            if (m != firstMarker) UnityEngine.Object.Destroy(m.gameObject);
        }
        // (b) 清空 collectableField 子物体（地上道具消失）
        if (_template.collectableField != null)
        {
            for (int i = _template.collectableField.childCount - 1; i >= 0; i--)
                UnityEngine.Object.Destroy(_template.collectableField.GetChild(i).gameObject);
        }
        // (c) 所有 Tilemap 染色 → 紫色调
        var tint = new Color(0.7f, 0.5f, 1.0f, 1f);
        foreach (var tm in _template.GetComponentsInChildren<UnityEngine.Tilemaps.Tilemap>(true))
        {
            tm.color = tint;
        }
        Log.LogInfo("[Poc] 模板已差异化（清 marker / 清 collectable / Tilemap 染紫）");

        // ── 2. 写入 DataBaseDay 私有字典（il2cppInterop 已暴露为可访问） ──
        var node = new DaySceneMapProfile.MapNode
        {
            mapName = TestLabel,
            parent = string.Empty,
            mapAssetReference = null, // 我们自己接管加载，跳过 SpawnMapReferenceAsync
            mapCollectableLabels = new Il2CppStringArray(0),
            mapSpawnMarkerLabels = new Il2CppStringArray(new[] { TestMarker }),
            level1IzakayaId = new Il2CppStructArray<int>(0),
            level2IzakayaId = new Il2CppStructArray<int>(0),
            level3IzakayaId = new Il2CppStructArray<int>(0),
        };

        if (DataBaseDay.mapData != null) DataBaseDay.mapData[TestLabel] = node;
        else Log.LogWarning("[Poc] DataBaseDay.mapData 为 null");
        if (DataBaseDay.mapReference != null) DataBaseDay.mapReference[TestLabel] = null;
        else Log.LogWarning("[Poc] DataBaseDay.mapReference 为 null");

        if (DataBaseDay.allCollectablesLabels != null)
            DataBaseDay.allCollectablesLabels[TestLabel] = new Il2CppSystem.Collections.Generic.HashSet<string>();

        if (DataBaseDay.allSpawnMarkerLabels != null)
        {
            var hs = new Il2CppSystem.Collections.Generic.HashSet<string>();
            hs.Add(TestMarker);
            DataBaseDay.allSpawnMarkerLabels[TestLabel] = hs;
        }

        // ── 3. 语言 ──
        try
        {
            var langField = typeof(DaySceneLanguage).GetField(
                "s_MapLanguageData",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            var langDict = langField?.GetValue(null)
                as Il2CppSystem.Collections.Generic.Dictionary<string, LanguageBase>;
            if (langDict == null)
            {
                Log.LogWarning($"[Poc] 反射 s_MapLanguageData 失败 (field={langField}, value={langField?.GetValue(null)?.GetType().FullName})");
            }
            else
            {
                langDict[TestLabel] = new LanguageBase("测试地图", "克隆自当前地图");
                Log.LogInfo($"[Poc] 写入 MapLanguageData[{TestLabel}] OK，回读: {DaySceneLanguage.GetMapLanguageData(TestLabel).Name}");
            }
        }
        catch (Exception e)
        {
            Log.LogWarning($"[Poc] 写语言失败 (非致命): {e.Message}");
        }

        // ── 4. 解锁地图（地图选择/快速旅行可见） ──
        RunTimeDayScene.UnlockMap(TestLabel);

        _registered = true;
        Log.LogInfo($"[Poc] 已注册新地图 {TestLabel} (marker={TestMarker})");
        InGameConsole.LogToConsole($"<color=#88FF88>[Poc] 注册新地图 {TestLabel} OK，按 F4 切换</color>");
    }

    public static void RunPhase2_Swap()
    {
        var sm = SceneManagerDS.Instance;
        if (sm == null) { Log.LogWarning("[Poc] 不在 DayScene"); return; }
        if (!_registered || _template == null) { Log.LogWarning("[Poc] 请先按 F3"); return; }
        SwapAsyncVoid(sm);
    }

    private static async void SwapAsyncVoid(SceneManagerDS sm)
    {
        try { await SwapAsync(sm); }
        catch (Exception e) { Log.LogError($"[Poc] Swap 异常: {e}"); }
    }

    private static async System.Threading.Tasks.Task SwapAsync(SceneManagerDS sm)
    {
        Log.LogInfo($"[Poc] 切换到 {TestLabel} (绕过 SpawnMapReferenceAsync)");

        await UniversalGameManager.FadeInAsync();
        SceneDirectorCommon.Instance.StopAllMovingProcess();

        if (sm.CurrentActiveMap != null)
        {
            sm.CurrentActiveMap.OnPostLeaveScene();
            UnityEngine.Object.Destroy(sm.CurrentActiveMap.gameObject);
        }

        // 由模板 Instantiate 出真正的工作实例
        var spawned = UnityEngine.Object.Instantiate(_template);
        spawned.gameObject.name = $"_PocMap_{TestLabel}";
        spawned.gameObject.SetActive(true);
        spawned.PreInitialize(TestLabel, null);

        sm.CurrentActiveMap = spawned;
        sm.CurrentActiveMapLabel = TestLabel;
        sm.TargetMapLabel = TestLabel;

        await spawned.EnterSceneAsync(TestLabel);

        if (sm.Character != null && spawned.AllSpawnMarkers != null
            && spawned.AllSpawnMarkers.ContainsKey(TestMarker))
        {
            sm.Character.UpdateCharacter(spawned, spawned.AllSpawnMarkers[TestMarker]);
        }
        else
        {
            Log.LogWarning($"[Poc] 玩家或 SpawnMarker 缺失，跳过 UpdateCharacter");
        }

        SceneDirectorCommon.Instance.SetMainScene(TestLabel, spawned.gameObject);
        SceneDirectorCommon.Instance.UpdateCachedScenes();
        DayScene.Music.AudioManager.Instance.PlayLoopedBGM(spawned.mapBGM);

        // 顶部地图名 UI 文本
        var ui = DayScene.UI.UIManager.Instance;
        if (ui != null && ui.currentMapName != null)
        {
            var lang = DaySceneLanguage.GetMapLanguageData(TestLabel);
            ui.currentMapName.text = lang.Name;
            Log.LogInfo($"[Poc] currentMapName.text = '{lang.Name}'");
        }

        UniversalGameManager.FadeOut(null);
        Log.LogInfo($"[Poc] 切换完成");
        InGameConsole.LogToConsole($"<color=#88FF88>[Poc] 已切换到 {TestLabel}</color>");
    }

}

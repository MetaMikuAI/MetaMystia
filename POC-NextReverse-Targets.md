# 下一阶段逆向目标清单

> 范围：在当前 PoC（`Poc.cs` / `POC-DaySceneMap-Methodology.md`）之上，要进一步实现
> **(A) 修改 SpawnMarker 贴图**
> **(B) 在快捷传送面板中加点位**
> 所需的逆向缺口与文件清单。
>
> 当前 `MystiaReverse/` 已恢复的相关文件**仅** `MystiaReverse/DayScene/SceneManager.cs`（含 `SwapMapAsync`）。其余全是 `Assembly-CSharp/` 的字段 stub。

---

## A. SpawnMarker 贴图方向

### A.1 已可用（无需逆向）

| 文件 | 提供的信息 |
|---|---|
| [Assembly-CSharp/DayScene/Interactables/SpawnMarker.cs](Assembly-CSharp/DayScene/Interactables/SpawnMarker.cs) | 字段：`spawnMarkerName / targetRotation / shouldOverrideRadius / overrideRadius`。**无任何贴图字段** |
| [Assembly-CSharp/DayScene/DaySceneMap.cs](Assembly-CSharp/DayScene/DaySceneMap.cs) | `spawnMarkerField`、`GenerateSpawnMarkerData()`、`GetSpawnMarker(name)` |
| [Assembly-CSharp/DayScene/Input/DayScenePlayerInputGenerator.cs](Assembly-CSharp/DayScene/Input/DayScenePlayerInputGenerator.cs) | `UpdateCharacter(map, marker)` 签名 |

**结论**：`SpawnMarker` 的"贴图"是 Unity 预制体上挂的 `SpriteRenderer / Image`，**不是** C# 字段。改贴图 = `marker.GetComponentInChildren<SpriteRenderer>().sprite = ...`，无需逆向。

### A.2 需逆向（`MystiaReverse/` 缺失）

| 优先级 | 文件 | 需要确认的关键问题 |
|---|---|---|
| 高 | `MystiaReverse/DayScene/DaySceneMap.cs` | `GenerateSpawnMarkerData()` 真实实现 → 验证 PoC "克隆模板时清缓存" 的必要性 |
| 中 | `MystiaReverse/DayScene/Input/DayScenePlayerInputGenerator.cs` | `UpdateCharacter` 是否会反向写 marker，是否会造成贴图状态丢失 |
| 低 | `MystiaReverse/DayScene/Interactables/SpawnMarker.cs` | `OnDestroy` 是否触发某种全局注销 |
| 低 | `MystiaReverse/DayScene/PartyStageMap.cs` | `override GenerateSpawnMarkerData()` 作交叉参考 |

---

## B. 快捷传送面板（FastTravelPanel）点位方向

### B.1 调用链全景

```
DaySceneSustainedPannel.OpenFastTravelPannel(isYukari, ...)
  └─ Addressables 加载 DaySceneFastTravelPannel (AssetReferenceT<GameObject>)
        └─ FastTravelPanel_New : GuideMapPanel<FastTravelPanelOpenContext, VoidType>
              ├─ MapTransitionNode[]              ← 点击点位（含 key=mapLabel / cost / connections[]）
              ├─ GuideMapSpot (IGuideMapSpot)     ← 抽象点位（含 MapName / RectTransform / UIButton）
              ├─ DaySceneMapDescriber             ← 选中后右侧介绍
              ├─ DaySceneFastTravelSubPannel      ← 二级（楼层等）
              └─ FloatMenuModifier[]              ← 设计期 (GuideMapSpot, Vector2) 配对
```

### B.2 已可用（仅字段/签名，逻辑空）

| 文件 |
|---|
| [Assembly-CSharp/DayScene/UI/FastTravelPanel_New.cs](Assembly-CSharp/DayScene/UI/FastTravelPanel_New.cs) |
| [Assembly-CSharp/DayScene/UI/MapTransitionNode.cs](Assembly-CSharp/DayScene/UI/MapTransitionNode.cs) |
| [Assembly-CSharp/Common/UI/GlobalMap/GuideMapSpot.cs](Assembly-CSharp/Common/UI/GlobalMap/GuideMapSpot.cs) |
| [Assembly-CSharp/Common/UI/GlobalMap/GuideMapPanel.cs](Assembly-CSharp/Common/UI/GlobalMap/GuideMapPanel.cs) |
| [Assembly-CSharp/Common/UI/GlobalMap/IGuideMapSpot.cs](Assembly-CSharp/Common/UI/GlobalMap/IGuideMapSpot.cs) |
| [Assembly-CSharp/DayScene/UI/DaySceneFastTravelSubPannel.cs](Assembly-CSharp/DayScene/UI/DaySceneFastTravelSubPannel.cs) |
| [Assembly-CSharp/DayScene/UI/DaySceneMapDescriber.cs](Assembly-CSharp/DayScene/UI/DaySceneMapDescriber.cs) |
| [Assembly-CSharp/DayScene/UI/DaySceneSustainedPannel.cs](Assembly-CSharp/DayScene/UI/DaySceneSustainedPannel.cs) |

### B.3 待逆向缺口（按 ROI 优先级）

#### 第一波（必做，决定整条路是否走得通）

| 文件 | 必须解开的谜团 |
|---|---|
| `MystiaReverse/Common/UI/GlobalMap/GuideMapPanel.cs` | 抽象基类 → 点位是**预制体硬编码**还是**运行时动态注入**；`OnGuideMapInitialize / GetSpotOpenStatus / OnGuideMapSpotSelected / OnGuideMapSpotSubmit` 联动 |
| `MystiaReverse/DayScene/UI/FastTravelPanel_New.cs` | `OnGuideMapSpotSubmitAsync` 内**一定**调用 `SceneManager.Instance.SwapMapAsync(spot.MapName)` —— 是新地图能否被快捷选中的核心证据点；`GetSpotOpenStatus` 决定锁/解锁判定 |
| `MystiaReverse/Common/UI/IzakayaSelectorPanel_New.cs` | 内部类 `GuideMapSpotRuntimeData` 是**唯一现成的"运行时点位"范例**；若 FastTravel 也用类似机制，加点路线可行 |

#### 第二波（动手前必看）

| 文件 | 用途 |
|---|---|
| `MystiaReverse/Common/UI/GlobalMap/GuideMapSpot.cs` | `MatchesMapNameOrSubset / IsActivated / UIButton` 联动；`MapName` setter 在哪被调（决定 mod 方式） |
| `MystiaReverse/DayScene/UI/MapTransitionNode.cs` | `Initialize(Action, Action)` 实际逻辑；`connections[]` 是显示连线还是解锁判定 |
| `MystiaReverse/DayScene/UI/DaySceneSustainedPannel.cs` | `OpenFastTravelPannel` 全流程 + `m_LoadedFastTravelPanel` 缓存策略（决定 mod 时机） |

#### 第三波（完善）

| 文件 | 用途 |
|---|---|
| `MystiaReverse/DayScene/UI/DaySceneFastTravelSubPannel.cs` | 二级面板（神社三层、酒馆楼层）；与 `MapNode.level1IzakayaId / level2IzakayaId` 的绑定 |
| `MystiaReverse/DayScene/UI/DaySceneMapDescriber.cs` | 右侧介绍文字源（推测 = `DaySceneLanguage.GetMapLanguageData(label).Description`） |
| `MystiaReverse/DayScene/DaySceneMap.cs` | `GenerateSpawnMarkerData / GetSpawnMarker` 与 PoC 缓存清理的互动 |
| `MystiaReverse/DayScene/Interactables/Collections/BehaviourComponents/MapTransitionBehaviourComponent.cs` | `ExecuteMapTransition()` —— 交互物（门/楼梯）触发切图，独立于快捷传送 |
| `MystiaReverse/DayScene/Interactables/Collections/BehaviourComponents/DaySceneOpenMapTransitionPanelBehaviourComponent.cs` | 触发打开传送面板的入口 |
| `MystiaReverse/DayScene/Interactables/MapTransitionData.cs` | 单条"目标地图+目标marker"载体 |
| `MystiaReverse/Common/UI/GuideMapSpotIzakayaExtension.cs` | 酒馆扩展，多酒馆才需要 |

### B.4 当前可形成的强烈推测（待逆向证实/证伪）

1. **FastTravelPanel_New 的点位是预制体里硬编码的 `GuideMapSpot` 子物体**（非运行时生成）
   - 证据：基类无 "AddSpot" API；`m_FloatMenuModifiers` 是 `[GuideMapSpot, Vector2]` 配对数组，呈设计期固定特征
2. 若推测 1 成立，自定义点位只能走两条路：
   - **预制体 mod**：替换/扩展 `DaySceneFastTravelPannel` 的 Addressable 预制体
   - **运行时 Instantiate**：把面板里某个现有 `GuideMapSpot` 克隆到根节点下，仿照 PoC 改 `MapName` —— 是否可行取决于 GuideMapPanel 是否在 Awake/Initialize 时一次性枚举 spots 并缓存
3. **`DaySceneMapDescriber` 文本来自 `DaySceneLanguage.GetMapLanguageData(MapName).Description`**
   - 若证实 → PoC 阶段 `MapNode` 加 description 字段就**自动**让快捷传送介绍生效

三条都需 **第一波三个文件同时到位** 才能落槌。

---

## C. 行动建议

1. 下一轮逆向直接攻 **B.3 第一波**三份文件
2. 拿到后回填本文档"待证实"段
3. 视结论选 mod 路线（预制体替换 vs 运行时注入），再启动实现 PoC
4. SpawnMarker 贴图修改可以**当下立刻动手**，不等任何逆向（A.1 已足够）

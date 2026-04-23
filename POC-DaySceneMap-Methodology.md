# PoC：在不走 Addressables 的前提下"凭空"加一张 DaySceneMap

> 适用范围：BepInEx + Il2CppInterop 环境下，对 il2cpp Unity 游戏「东方夜雀食堂」的白天场景地图系统做扩展性验证。
> 对应代码：`Poc.cs`，热键 `F3 = 注册`，`F4 = 切换`。

---

## 1. 问题定义

游戏的白天场景地图（`DaySceneMap`）原生加载链路是：

```
SwapMapAsync(label)
  └─ DataBaseDay.mapReference[label]            // AssetReferenceGameObject
        └─ SpawnMapReferenceAsync(...)          // Addressables.InstantiateAsync
              └─ DaySceneMap.PreInitialize()
              └─ EnterSceneAsync()
              └─ UIManager.Instance.currentMapName.text = DaySceneLanguage.GetMapLanguageData(label).Name
```

要"加一张全新地图"理论上必须：

1. 在 Addressables 资源系统里塞一份新的 `GameObject` 资源
2. 让 `mapReference[新label]` 指向这份 `AssetReferenceGameObject`
3. 在 `DataBaseDay.mapData / allCollectablesLabels / allSpawnMarkerLabels` 里登记
4. 在 `DaySceneLanguage.s_MapLanguageData` 里登记 UI 名

第 1、2 步是最重的（涉及 `IResourceProvider` / `ResourceLocationMap` 注入，本仓库 `Utils/ModAssetRegistry.cs` 已有实现，但目前只用于 Sprite）。

**PoC 的取舍**：先**绕过 Addressables**，证明数据库/语言/场景对象层都可被 mod 化；ModGameObjectProvider 留给后续阶段。

---

## 2. 方法论

### 2.1 "克隆 + 改名" 而不是 "从零构造"

`DaySceneMap` 的预制体内部结构非常重（Tilemap、SpawnMarker、collectableField、camera bounds、若干 Manager 引用…）。从零造一份几乎不可行。

PoC 的做法：

```
F3：在当前已加载的 CurrentActiveMap 上 Instantiate 一份 → 作为模板 _template
     - SetActive(false) 防止它出现在当前画面里
     - 立即重命名首个 SpawnMarker = MetaTestSpawn
     - 把所有运行时缓存字段清空：allSpawnMarkers / allCollectables / initialized / mapLabel / _Handle
       原因：DaySceneMap.PreInitialize() 会在切入时按需重建；保留旧缓存会带着原图的 mapLabel 进入新图，污染数据库查表
```

这相当于：**"从已知好用的活体里克隆出一具壳，再把它注册成新身份"**。

### 2.2 绕过 SpawnMapReferenceAsync，手动复刻"切图"流程

标准 `SwapMapAsync` 的核心是 `SpawnMapReferenceAsync`：用 Addressables.InstantiateAsync 加载新地图、销毁旧地图、调 `PreInitialize`、`EnterSceneAsync`、刷新角色与缓存场景、播 BGM。

PoC 的 `SwapAsync` **不走 Addressables**，而是手工把这些步骤复刻一遍：

```
SceneDirector.Instance.FadeIn(0.6, OnComplete)
└─ 销毁当前 sm.currentActiveMap
└─ Instantiate(_template) → 设为 sm.currentActiveMap
   设 transform.parent = sm.transform；mapLabel = TestLabel
└─ map.PreInitialize()
└─ await map.EnterSceneAsync(...) (UniTask → 用 async Task 包一层 async void 调用)
└─ sm.UpdateCharacter()
└─ SceneDirector.Instance.SetMainScene / UpdateCachedScenes
└─ AudioManager.Instance.PlayLoopedBGM(map.bgm) (若非空)
└─ UIManager.Instance.currentMapName.text = DaySceneLanguage.GetMapLanguageData(TestLabel).Name
└─ FadeOut(0.6)
```

**为什么要复刻而不是 patch `SwapMapAsync`?**

PoC 阶段的核心目标是"**在不依赖 Harmony 的情况下证明可行性**"。Patch 的优势是无侵入，但代价是把所有副作用绑死在原方法的实现细节上；PoC 先把"切图"拆成可观察、可断言的纯调用链，便于定位失败点。等机制确定后，再决定哪些步骤值得放回 Patch 路径（可能根本不需要 Patch）。

### 2.3 数据库注入：四张字典 + 一张语言字典

经审计 `MystiaReverse/`，新地图要被系统视为"合法存在"必须在以下五个键里登记：

| 字典 | 写入内容 | 用途 |
|------|----------|------|
| `DataBaseDay.mapData[label]` | `MapNode { mapLabel, mapAssetReference=null, ... }` | 主索引，决定地图是否"存在" |
| `DataBaseDay.mapReference[label]` | `null`（PoC 不接 Addressables） | 标准 SwapMap 路径用，PoC 路径不用 |
| `DataBaseDay.allCollectablesLabels[label]` | 空 HashSet | 进图时收集物快照查表，不能 KNF |
| `DataBaseDay.allSpawnMarkerLabels[label]` | `{TestMarker}` | 玩家落点系统查表，不能 KNF |
| `DaySceneLanguage.s_MapLanguageData[label]` | `new LanguageBase(name, desc)` | UI 顶部地图名 |

`s_MapLanguageData` 是私有 static 字段，需要反射拿出来再以 `dict[key] = value` 写入。

### 2.4 视觉差异化（让 PoC 一眼可辨）

仅改"标题文字"无法证明这是一张独立的地图——它甚至可能只是 UI 改字。PoC 在 Phase1 末尾对模板做三件事：

1. **删除非目标 SpawnMarker**：证明 marker 集合是新的；玩家从落点出生的位置一目了然
2. **清空 collectableField 子节点**：地上的可拾取物全部消失，证明对象层独立
3. **整图 Tilemap 染紫**：最直观，从画面看就是"换了一张图"

这三件事都是对 `_template` 这棵 GameObject 树做的本地修改，不影响原图。

### 2.5 KISS：先证可行，再证完备

PoC 刻意**没做**以下事情：

- **没接** Addressables `IResourceProvider` / `ResourceLocationMap`（标准 `SwapMapAsync` 仍然走不通这张图）
- **没填** `MapNode` 的 description / parent / level1IzakayaId / dlcContent
- **没改** UnlockMap 之外的解锁条件
- **没处理** 反向切换（再走 `SwapMapAsync("BeastForest")` 即可）

这些都是已知 TODO，但与"证明数据库/语言/对象三层可注入"无关，留给后续阶段。

---

## 3. 经验沉淀

> 都是这次 PoC 实际踩过的坑。

### 3.1 il2cpp Dictionary 不要用 `Add` / `TryAdd`

`Il2CppSystem.Collections.Generic.Dictionary<TKey,TValue>.Add` 在某些边界条件下行为与托管 `Dictionary` 不一致（包括"明明 ContainsKey 返回 false 但 Add 仍抛"等历史问题）。

**统一改用 indexer 赋值：**

```csharp
// ❌
if (!dict.ContainsKey(k)) dict.Add(k, v);
// ❌
dict.TryAdd(k, v);

// ✅
dict[k] = v;
```

本规则是仓库级强约束，已记入仓库内存，新增 il2cpp 字典写入时一律遵循。

### 3.2 `async UniTask` 在本项目无法编译

本项目编译环境缺少 `Cysharp.Threading.Tasks.UniTaskAsyncMethodBuilder` 的可见性，导致 `async UniTask Foo() { ... }` 报 CS1983。

**workaround：**

```csharp
// 入口必须是 void 或 Task
private static async void SwapAsyncVoid(SceneManagerDS sm)
{
    try { await SwapAsync(sm); }
    catch (Exception e) { Log.LogError($"[Poc] {e}"); }
}

// 内部 await UniTask 没问题，因为 awaiter 是另一回事
private static async System.Threading.Tasks.Task SwapAsync(SceneManagerDS sm)
{
    await someUniTask; // OK
}
```

经验：**入口用 `async void` 包 `async Task`，里面随便 await UniTask**。

### 3.3 il2cpp 私有 static 字段必须反射 + 强转

```csharp
var fi = typeof(DaySceneLanguage).GetField("s_MapLanguageData",
    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
var langDict = fi?.GetValue(null)
    as Il2CppSystem.Collections.Generic.Dictionary<string, LanguageBase>;
```

注意 il2cppInterop 反编译出的字段名可能是 `s_MapLanguageData`、`<MapLanguageData>k__BackingField`、`_MapLanguageData_k__BackingField` 之一，第一次试要回读校验：

```csharp
Log.LogInfo($"回读: {DaySceneLanguage.GetMapLanguageData(TestLabel).Name}");
```

如果 fi 为 null，换名字再试。本 PoC 走的是 `s_MapLanguageData`，验证通过。

### 3.4 PoC 阶段尽量不上 Harmony

Patch 是"对原方法行为打补丁"，PoC 是"证明这条路走得通"。在没确定哪些行为需要保留、哪些需要替换前，强行 Patch 会把副作用绑死在原方法的实现版本上。

**PoC 偏好：**

1. 用 F-key 显式触发，而不是事件钩子
2. 直接调原方法（`PreInitialize`、`EnterSceneAsync`、`PlayLoopedBGM`）而不是替换它们
3. 用反射写私有字段，而不是 transpile 修改读字段的代码

等行为锁定，再决定哪些步骤值得 Harmony 化。

### 3.5 克隆完必须清运行时缓存

`DaySceneMap` 内部很多字段（`allSpawnMarkers / allCollectables / initialized / mapLabel / _Handle`）是 `PreInitialize`/`EnterScene` 阶段填的运行时缓存。从一个**已经初始化过**的实例 Instantiate 出来，这些字段会被一并克隆。

进新图前必须把它们置空，否则：

- `mapLabel` 还是原图 → 数据库查表全错
- `allSpawnMarkers` 是旧引用 → 新 SpawnMarker 找不到
- `_Handle` 残留 → 后续 ReleaseInstance 行为未定义

**克隆即清缓存**是这套机制的硬约束。

### 3.6 视觉验证 > 日志验证

切图涉及画面、UI、音乐、相机、角色五条独立链路。任何一条挂了，日志可能仍报"成功"。

**最小验证集：**

- 画面：地面颜色变化（Tilemap 染色）
- 对象：地上道具消失（清 collectableField）
- 落点：角色出生在新 marker 位置（删其它 marker）
- UI：标题文字变化（`currentMapName.text`）

任意一项缺失都说明对应链路没接通。

---

## 4. 后续阶段路线（PoC 未做）

按"价值/难度"排序：

1. **接 ModGameObjectProvider**：让 `mapReference[label]` 真正指向自有 `AssetReferenceGameObject`，使标准 `SwapMapAsync` / `MapTransition` 交互物可用。模式参照 `Utils/ModAssetRegistry.cs` 现有 Sprite Provider 实现（同样的 GUID-MD5 + ListWithEvents 注入路径）
2. **MapNode 完整化**：parent / level1IzakayaId / level2IzakayaId / dlcContent / description，使新地图能挂在地图选择树上
3. **反向切回**：F5 调 `SceneManager.Instance.SwapMapAsync("BeastForest")` 验证退场
4. **持久化**：把"已注册自定义地图"写入存档，重新加载游戏后仍然存在
5. **多地图**：把 `RunPhase1_Register` 抽出 `RegisterMap(label, sourceLabel, tint)` API

---

## 5. 文件索引

| 文件 | 角色 |
|------|------|
| `Poc.cs` | PoC 主体，F3 注册 / F4 切图 |
| `Managers/PluginManager.cs` | F3/F4 热键绑定（`if (DEBUG)` 块内） |
| `Utils/ModAssetRegistry.cs` | Addressables 注入参考实现（Sprite Provider）|
| `MystiaReverse/DayScene/SceneManager.cs` | 原 `SwapMapAsync` 参考实现 |
| `MystiaReverse/DayScene/DaySceneMap.cs` | 地图对象结构 |
| `MystiaReverse/GameData/Profile/DataBaseDay.cs` | 四张字典定义 |
| `MystiaReverse/GameData/CoreLanguage/Collections/DaySceneLanguage.cs` | `s_MapLanguageData` 字段 |

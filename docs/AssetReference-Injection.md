# AssetReference 自定义 Sprite 注入方案

## 概述

本文档记录了 MetaMystia 中将自定义 Sprite 注入 Unity Addressables `AssetReference` 体系的完整研究过程、技术原理和最终实现方案。

游戏 「东方夜雀食堂」 基于 Unity IL2CPP，资源加载完全依赖 Unity Addressables 系统。Mod 侧需要将自定义的 Sprite（如 CG 图片）注入到游戏原有的资源加载管线中，但无法真正注册到 Addressables catalog。

## 技术背景

### 资源加载链路（通过 IDA 逆向确认）

游戏的 CG 加载完整调用链（5 层深度）：

```
DialogAction.LoadDialogActionData (async MoveNext, VA: 0x180801590)
  → LoadAssetAllowNull<T>(assetRef)              (VA: 0x180d34ac0)
    → AssetHandleHelper.LoadAssetHandleAsync<T>  (VA: 0x180d119a0)
      → AssetHandleHelper.LoadAssetRuntime<T>    (VA: 0x180d11cc0, MoveNext: 0x1814dd930)
        → AssetReference.LoadAssetAsync<T>()     (VA: 0x180d12150)
```

### 关键发现：游戏魔改的 LoadAssetAsync

**游戏的 `AssetReference.LoadAssetAsync<T>()` 与 Unity Addressables 开源实现完全相反：**

```csharp
// 游戏实际行为 (IDA 反编译确认)
if (m_Operation.IsValid()) {
    Debug.LogError("Attempting to load AssetReference that has already been loaded...");
    return default;  // 返回空 handle！
} else {
    m_Operation = Addressables.LoadAssetAsync<T>(RuntimeKey);
    return m_Operation;
}
```

```csharp
// Unity Addressables 开源实现
if (m_Operation.IsValid()) {
    return m_Operation;  // 正常复用已有 handle
}
m_Operation = Addressables.LoadAssetAsync<T>(RuntimeKey);
return m_Operation;
```

**影响**：直接往 `m_Operation` 注入 `CreateCompletedOperation` 产生的 handle 后，如果资源经过完整加载管线（`LoadAssetAsync`），反而会被视为错误并返回空 handle。

### LoadDialogActionData MoveNext — CG 分支

CG (actionType == 2) 的 MoveNext 行为：

1. **语言选择**：根据 `CurrentLanguage` 选择 `m_SpriteAsset` / `m_SpriteENAsset` / `m_SpriteJPAsset` / `m_SpriteKOAsset` / `m_SpriteCNTAsset`
2. **Null 检查**：选出的 AssetRef **不能为 null**，否则直接 NullRef 崩溃
3. **RuntimeKeyIsValid 检查**：如果选出的 AssetRef 的 key 无效，回退到 `m_SpriteAsset`
4. **加载 Sprite**：`LoadAssetAllowNull(spriteRef)` — 如果 `RuntimeKeyIsValid()` 为 false，返回 NullHandle
5. **加载 Material**：`LoadAssetAllowNull(m_MaterialAsset)` — **无 null 检查！** 直接调用
6. **构造结果**：`new LoadedDialogActionData(action, spriteHandle, materialHandle)`

### LoadAssetAllowNull 行为

```
if (assetRef == null) → NullRef crash
if (!assetRef.RuntimeKeyIsValid()) → return CreateNullHandleTask()  // 安全！
else → LoadAssetHandleAsync(assetRef) → ... → LoadAssetAsync<T>()
```

## 方案设计

### 双层绕过策略

由于游戏的 `LoadAssetAsync` 拒绝已注入的 `m_Operation`，采用两层机制：

#### 第一层：安全通过 MoveNext 加载流程

为 `DialogAction` 的所有 AssetReference 字段设置**空 GUID** 的壳对象：

```csharp
action.m_SpriteAsset = new AssetReferenceSprite("");        // 空壳
action.m_MaterialAsset = new AssetReferenceT<Material>(""); // 防 NullRef
```

空 GUID → `RuntimeKeyIsValid()` 返回 false → `LoadAssetAllowNull` 走 `CreateNullHandleTask()` 路径 → 安全返回 NullHandle → 整个 async state machine 正常完成。

#### 第二层：Run() Harmony Prefix 注入真正的 Sprite

在 `LoadedDialogActionData.Run()` 执行前，Harmony Prefix 拦截：

```csharp
[HarmonyPatch(typeof(LoadedDialogActionData), nameof(LoadedDialogActionData.Run))]
[HarmonyPrefix]
public static bool Run_Prefix(LoadedDialogActionData __instance, DialogPannel dialogModuleUI)
{
    var actionData = __instance.m_DialogActionData;
    if (actionData.actionType != ActionType.CG) return RunOriginal;
    if (!AssetReferenceHelper.TryGetCGSprite(actionData.Pointer, out var sprite)) return RunOriginal;

    dialogModuleUI.CG = actionData.shouldSet ? sprite : null;
    return SkipOriginal;
}
```

### 通用 API：CreateForSprite

`AssetReferenceHelper.CreateForSprite()` 仍然是通用的 AssetReference 创建 API：

```csharp
public static AssetReferenceSprite CreateForSprite(Sprite sprite, string customKey = null)
```

- 注册到 `SpriteRegistry`（按 GUID 查找）
- 注入 `m_Operation`（支持直接 `.Asset` 访问）
- **注意**：如果消费者走完整 `LoadAssetAsync` 管线，m_Operation 注入无效，需要使用 Run() patch 机制

### m_Operation 注入原理

```csharp
// 1. 创建已完成的异步操作
var typedHandle = ResourceManager.CreateCompletedOperation<Sprite>(sprite, null);

// 2. 获取 IL2CPP 字段指针
var fieldPtr = typeof(AssetReference).GetField("NativeFieldInfoPtr_m_Operation", ...);

// 3. 解箱获取 struct 原始字节
IntPtr unboxed = IL2CPP.il2cpp_object_unbox(typedHandle.Pointer);

// 4. 直接写入 AssetReference 对象的 m_Operation 字段
IL2CPP.il2cpp_field_set_value(assetRef.Pointer, fieldPtr, unboxed);
```

## 数据流图

```
BuildDialogPackage (mod 侧)
  ├─ action.m_SpriteAsset = AssetReferenceSprite("")    ← 空壳
  ├─ action.m_MaterialAsset = AssetReferenceT<Material>("") ← 防 NullRef
  └─ CGSpriteRegistry[action.Pointer] = 真实 Sprite    ← mod 侧注册表

LoadDialogActionData.MoveNext (游戏代码, async state machine)
  ├─ LoadAssetAllowNull<Sprite>(m_SpriteAsset)
  │     └─ RuntimeKeyIsValid() = false → CreateNullHandleTask() → NullHandle ✓
  ├─ LoadAssetAllowNull<Material>(m_MaterialAsset)
  │     └─ RuntimeKeyIsValid() = false → CreateNullHandleTask() → NullHandle ✓
  └─ 构造 LoadedDialogActionData(action, nullSprite, nullMaterial) ✓

LoadedDialogActionData.Run() → Harmony Prefix 拦截
  ├─ 识别 actionType == CG
  ├─ 查 CGSpriteRegistry → 找到真实 Sprite
  └─ dialogModuleUI.CG = sprite → CG 显示成功 ✓
```

## 文件清单

| 文件 | 职责 |
|------|------|
| `Utils/AssetReferenceHelper.cs` | 通用 AssetReference 创建/注入 API、PoC 测试、双注册表 |
| `Patches/Common/LoadedDialogActionDataPatch.cs` | Run() Harmony Prefix，拦截 CG 并注入自定义 Sprite |
| `UI/Dialog.cs` | 对话系统：BuildDialogPackage 中初始化空壳 AssetRef + 注册 CG |

## 踩坑记录

### 1. m_Operation 注入后 LoadAssetAsync 返回空 handle

**现象**：PoC 6 步全 PASS（直接 `.Asset` 访问成功），但 CG 不显示、无报错。
**原因**：游戏魔改了 `LoadAssetAsync`，将已有效的 `m_Operation` 视为错误。
**解决**：改用空 GUID + Run() Prefix 双层策略。

### 2. NullReferenceException（无堆栈）

**现象**：设置了 `m_SpriteAsset` 但未设 `m_MaterialAsset` → NullRef。
**原因**：MoveNext CG 分支在加载完 sprite 后，**不检查 null** 直接调用 `LoadAssetAllowNull(m_MaterialAsset)`。
**解决**：初始化 `action.m_MaterialAsset = new AssetReferenceT<Material>("")`。

### 3. Harmony 不能 patch IL2CPP 泛型方法

**现象**：尝试 patch `LoadAssetAllowNull<Sprite>` 等泛型方法会失败。
**原因**：IL2CPP 的共享泛型方法体 + MethodInfo 参数机制，Harmony 无法正确定位。
**解决**：patch 非泛型的 `LoadedDialogActionData.Run()` 代替。

### 4. 语言相关的 Sprite 字段

**现象**：如果游戏不是中文，可能访问 `m_SpriteENAsset` / `m_SpriteJPAsset` 等字段。
**注意**：当前实现中只初始化了 `m_SpriteAsset`，如果需要支持其他语言，也要初始化对应字段。CG 分支在 `RuntimeKeyIsValid()` 检查失败后会回退到 `m_SpriteAsset`，所以中文环境下只设 `m_SpriteAsset` 即可。

## IDA 逆向关键地址

| 函数 | 虚拟地址 | 大小 |
|------|----------|------|
| LoadDialogActionData.MoveNext | 0x180801590 | 0xE10 |
| LoadedDialogActionData.Run() | 0x1807FEA00 | - |
| LoadAssetAllowNull<T> | 0x180d34ac0 | - |
| LoadAssetHandleAsync<T> | 0x180d119a0 | - |
| LoadAssetRuntime<T> | 0x180d11cc0 | - |
| LoadAssetRuntime.MoveNext | 0x1814dd930 | 0x730 |
| AssetReference.LoadAssetAsync<T> | 0x180d12150 | 0x150 |

## PoC 验证

`AssetReferenceHelper.TestPoC()` 提供 6 步验证链：

1. 创建测试 Sprite
2. 获取 ResourceManager
3. `CreateCompletedOperation<Sprite>(sprite, null)`
4. 解箱获取 `IAsyncOperation` + version
5. 构建非泛型 `AsyncOperationHandle`，验证 `IsValid/IsDone/Result`
6. 创建 `AssetReferenceSprite`，注入 `m_Operation`，验证 `.Asset` 返回正确 Sprite

6 步全部 PASS 证明 m_Operation 注入技术本身可行（限直接 `.Asset` 访问路径）。

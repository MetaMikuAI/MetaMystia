# ModAssetRegistry / ModSpriteProvider 设计复盘

## 需求背景

MetaMystia 需要在 ResourceEx（资源扩展包）系统中支持自定义 CG/BG 图片。游戏的对话系统（`DialogAction`）使用 `AssetReferenceSprite` 引用 CG 精灵图，而 `AssetReferenceSprite` 走的是 Unity Addressables 管线。

核心问题：**如何让 mod 自定义的 Sprite 能够通过标准 Addressables 加载管线被游戏系统消费？**

## 方案选型历程

### 失败方案（按时间顺序）

1. **Harmony patch il2cpp 泛型方法**（LoadAsset/LoadAssetAsync）→ il2cpp 下泛型方法无法被 Harmony patch，不可行
2. **CustomSpriteHandle + LoadedDialogActionData.Run() patch** → NullReferenceException，游戏内部调用链太深
3. **直接在 Run_Prefix 写入 CG** → 游戏内部状态管理不允许绕过标准管线
4. **m_Operation 注入方案**（AssetReferenceHelper.cs）→ 直接注入 AsyncOperationHandle 到 AssetReference.m_Operation 字段，PoC 通过，但属于 hack 手段，绕过了 Addressables 标准管线，长期维护风险大

### 最终方案：IResourceProvider 注入（推荐 ✅）

使用 Unity Addressables 的**标准扩展点**注入自定义资源：

- `IResourceProvider`：告诉 Addressables "我能提供这个资源"
- `IResourceLocator`：告诉 Addressables "这个 key 对应的资源在哪"

## 架构设计

```
┌──────────────────────────────────────────────────────┐
│                   Game Code                          │
│   assetRef.LoadAssetAsync<Sprite>()                  │
└──────────────┬───────────────────────────────────────┘
               │
               ▼
┌──────────────────────────────────────────────────────┐
│              Unity Addressables                      │
│  1. RuntimeKeyIsValid(guid) → true                   │
│  2. Locator.Locate(guid) → ResourceLocation          │
│  3. GetProvider(location.ProviderId) → Provider      │
│  4. Provider.Provide(handle)                         │
└──────┬───────────────┬───────────────────────────────┘
       │               │
       ▼               ▼
┌──────────────┐ ┌─────────────────────┐
│ ResourceLoca │ │  ModSpriteProvider  │
│ tionMap      │ │  (IResourceProvider)│
│              │ │                     │
│ GUID → {     │ │  GUID → Sprite     │
│   providerId │ │  (内存字典)          │
│   internalId │ │                     │
│ }            │ │  Provide(handle) →  │
│              │ │  handle.Complete()  │
└──────────────┘ └─────────────────────┘
       ▲               ▲
       │               │
┌──────────────────────────────────────────────────────┐
│              ModAssetRegistry (公共 API)              │
│                                                      │
│  Initialize()          → 注册 Provider + Locator     │
│  RegisterSprite(key)   → 写入字典 + Locator 映射      │
│  CreateSpriteReference(key) → new AssetReferenceSprite│
│  KeyToGuid(key)        → MD5 → GUID 格式字符串        │
└──────────────────────────────────────────────────────┘
```

## 关键技术发现

### 1. ListWithEvents 而非 List

`ResourceManager.ResourceProviders` 的运行时类型是 `ListWithEvents<IResourceProvider>`（全局命名空间，il2cpp interop DLL），不是 `List<>`。必须 `Cast<ListWithEvents<IResourceProvider>>()` 后才能 `Add()`。

### 2. RuntimeKeyIsValid 要求 GUID 格式

`AssetReference.RuntimeKeyIsValid()` 内部调用 `Guid.TryParse()`。如果 key 不是合法 GUID（如 `"mod://test/cg"`），游戏的 `LoadAssetAllowNull` 会直接跳过加载。

**解决方案**：`KeyToGuid()` 使用 MD5 哈希将可读 key 转为确定性 GUID：

```csharp
internal static string KeyToGuid(string key)
{
    using var md5 = MD5.Create();
    var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
    return new Guid(hash).ToString("D");
}
```

### 3. m_MaterialAsset 不能为 null

DialogAction 的 CG/BG 操作中，`m_MaterialAsset` 字段不能为 null（即使不需要 Material），否则 `LoadAssetAllowNull` 会抛 NullReferenceException。必须设为空引用：

```csharp
action.m_MaterialAsset = new AssetReferenceT<Material>("");
```

### 4. 初始化时序问题

最初将 `ModAssetRegistry.Initialize()` 放在 `OnFirstEnterMainScene()`（进入主场景回调），而 ResourceEx 在 `Plugin.Load()` 中加载。这导致 sprite 注册被 buffer 到 `_pendingRegistrations`，虽然设计上有 flush 机制，但实际测试发现 CG 不显示。

**最终方案**：将 `Initialize()` 移到 `Plugin.Load()` 中 `ResourceExManager.Initialize()` 之前。实测 Addressables 在 BepInEx `Load()` 时已就绪，sprites 在 ResourceEx 加载时直接注册到 locator，无需 buffer。

## 文件清单

| 文件 | 职责 |
|------|------|
| `Utils/ModSpriteProvider.cs` | IResourceProvider 实现，il2cpp 注入，内存字典存储 Sprite |
| `Utils/ModAssetRegistry.cs` | 公共 API：Initialize / RegisterSprite / CreateSpriteReference / KeyToGuid |
| `UI/Dialog.cs` | CustomAction 扩展：`sprite` 路径字段 + `spriteAsset` 运行时引用 + BuildDialogPackage CG/BG 支持 |
| `ResourceEx/Core.cs` | 加载 JSON 配置时自动注册 sprite 到 ModAssetRegistry |
| `Plugin.cs` | 初始化调用点 |

## 设计原则

1. **走标准管线**：不 hack 游戏内部状态，通过 Addressables 官方扩展点注入，与游戏原有代码完全兼容
2. **对 ResourceEx 作者透明**：JSON 中只需写 `"sprite": "assets/CG/xxx.png"`，框架自动处理注册和引用创建
3. **防御性初始化**：支持 pre-init buffer + 幂等 Initialize()，即使时序不理想也不会崩溃
4. **GUID 确定性**：同一 key 始终映射到同一 GUID，AssetReferenceSprite 可安全序列化/反序列化

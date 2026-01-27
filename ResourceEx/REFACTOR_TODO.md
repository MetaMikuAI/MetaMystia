# ResourceEx 重构建议与待办列表

## 一、 架构与设计模式重构 (Architecture & Design)

目前 `ResourceExManager` 是一个巨大的 `static partial` 类，承担了过多职责。

- [ ] **拆分职责 (解耦 God Object)**
    - [ ] `ModLoader` / `ResourceScanner`: 负责文件 I/O，扫描、解压 ZIP、校验版本、读取 JSON，返回数据对象。
    - [ ] `AssetProvider` (或 `SpriteLoader`): 负责资源提取 (原 `Assets.cs` 中的 `GetSprite`)、ZIP 读取逻辑及缓存管理。
    - [ ] `GameDataRegistrar` (系列): 将注册逻辑按领域拆分。
        - `ItemRegistrar`: 负责 Ingredient, Food, Beverage, Recipe。
        - `CharacterRegistrar`: 负责 Character, SpecialGuest, GuestProfilePair。
        - `NarrativeRegistrar`: 负责 Dialog, MissionNode, EventNode。

- [ ] **引入 Mapper 层 (DTO 转换)**
    - [ ] 创建 `Extensions` 或 `Mappers`，分离 Config 对象到 Runtime 对象的转换逻辑。
    - [ ] 示例: `config.ToIngredient()`, `config.ToMissionNode()`。

## 二、 代码质量与可维护性 (Code Quality)

- [ ] **消除代码重复**
    - [ ] `Ingredient.cs`, `Food.cs`, `Beverage.cs` 中的注册逻辑高度雷同，提取泛型 `RegisterHelper` 或公共构建流程。
    - [ ] 合并 `Sellable` 类型物品 (Food/Beverage) 的构建逻辑。

- [ ] **优化日志 (Logging)**
    - [ ] 减少 `Log.Info` 的频率，避免加载大量物品时刷屏。
    - [ ] 仅在模块完成或出错时记录，详细信息降级为 Debug 级别。

- [ ] **去除静态依赖与 Partial Class**
    - [ ] 减少 `partial` 类的滥用，将部分逻辑拆分为独立类。
    - [ ] 显式传递依赖项，而非依赖类内部的静态字段。

## 三、 性能与资源 (Performance)

- [ ] **资源加载优化**
    - [ ] 实现 **按需加载 (Lazy Loading)**: 非必须常驻资源 (如大立绘) 推迟到使用时加载。
    - [ ] **异步加载**: 探索使用异步任务处理 ZIP 解压和 Texture 创建。

- [ ] **ZIP 读取优化**
    - [ ] 优化 `GetSprite` 逻辑，避免频繁 Open/Close ZIP 文件。考虑保持 Archive 引用或批量读取。

## 四、 重构路线图 (Roadmap)

1.  **Step 1: 提取 Asset 管理**
    - 将 `_spriteCache` 和 `GetSprite` 移至独立的 `SpriteLoader` 类。
2.  **Step 2: 提取模型转换逻辑**
    - 为 `IngredientConfig` 等 DTO 添加 `ToRuntimeInstance` 扩展方法。
3.  **Step 3: 拆分注册器**
    - 创建 `IngredientRegistrar`, `CharacterRegistrar` 等类，接管具体的注册流程。
4.  **Step 4: 清理 ResourceExManager**
    - `ResourceExManager` 只保留流程协调功能 (Load -> Preload -> Register Batch)。

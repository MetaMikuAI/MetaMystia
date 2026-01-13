# MetaMystia

**MetaMystia** 是一个为游戏《[东方夜雀食堂](https://store.steampowered.com/app/1584090/)》开发的**联机 Mod**。它的目标很简单：

> 让原本只能单人游玩的夜雀食堂，真正“热闹”起来。

通过 MetaMystia，您可以与朋友一同经营食堂、同步行动与操作，共同应对顾客需求，将原本的单机体验扩展为协作式的联机玩法。

📖 **完整说明文档**
[https://doc.meta-mystia.izakaya.cc/index.html](https://doc.meta-mystia.izakaya.cc/index.html)

## 安装与使用

请参考用户文档中的安装与使用说明：

👉 [https://doc.meta-mystia.izakaya.cc/user_guide/how_to_install.html](https://doc.meta-mystia.izakaya.cc/user_guide/how_to_install.html)

## 参与开发

如果您希望了解如何搭建开发环境或参与贡献，请阅读开发者文档：

👉 [https://doc.meta-mystia.izakaya.cc/developer_guide/getting_started.html](https://doc.meta-mystia.izakaya.cc/developer_guide/getting_started.html)

## 功能进度（TODO）

以下为当前功能实现与规划情况，按游戏流程划分。

### DayScene（白天场景）

-   [x] 实现基础联机
-   [x] 实现跨地图同步
-   [x] 实现较稳定的运动同步
-   [x] 游戏内 Console
-   [x] 解决 Kyouko 无物理问题
-   [x] 提前加载 Kyouko
-   [x] 同步“结束”
-   [x] 同步对话（由**余烬特调**提供）
-   [x] Ping 显示
-   [x] 连接后立即同步位置
-   [x] 禁用 OnDayOver 时 Mystia 的个人 Dialog
-   [x] 解决 Kyouko 无法上下坡的问题
-   [x] 禁用等待 Kyouko 状态下的交互
-   [ ] ~~禁用 Kyouko 交互~~
-   [x] 切换到兽道时 Kyouko 会被原逻辑重置（已通过修改 NPC 数据中的 `overrideposition` 实现）
-   [ ] 解决剧情冲突问题
-   [ ] 禁用等待 Kyouko 状态下切换地图

### 营业准备阶段

-   [x] 研究相关 API
-   [ ] ~~限制仅 Kyouko 伙伴选择（暂不考虑实现）~~
-   [x] 限制必须选择相同场景与模式
-   [x] 同步菜单
-   [x] 同步酒水
-   [x] 同步厨具
-   [x] 优化厨具同步逻辑
-   [x] 同步加载预设（无需额外实现）
-   [ ] ~~优化同步代码~~
-   [x] 同步“开始营业”

### NightScene（夜晚营业）

-   [x] 同步普通顾客生成
-   [x] 同步稀有顾客生成
-   [x] 同步顾客落座
-   [x] 同步顾客点单
-   [x] 同步上菜
-   [ ] ~~同步顾客评价~~
-   [ ] ~~同步顾客结账~~（结账与评价在两端独立进行，但由于上菜一致，结果基本一致）
-   [x] 同步顾客离开
-   [ ] ~~同步符卡奖励、惩罚~~（基于订单评估，逻辑同上）
-   [x] 同步做菜、取菜
-   [x] 同步保温箱
-   [ ] 同步保温箱（白天）
-   [x] 同步运动状态
-   [x] 移除原有伙伴
-   [ ] 同步 Buff
-   [x] 同步 Sellable 暂存
-   [ ] ~~同步时钟~~（已将夜晚时间由 240s 延长至 480s，并取消时停）

### 其他功能

-   [x] 自定义对话
-   [x] 自定义角色立绘扩展
-   [ ] 自定义角色小人

## 已知问题与缺陷

### 通用问题

-   [x] InGameConsole 与原有面板 UI 冲突
-   [x] 对话 UI 与面板 UI 冲突
-   [x] InGameConsole 与场景切换冲突
-   [x] DayScene 中 Kyouko 移动缺少高度变化
-   [ ] A 在 Loading 时，B 选择厨具会导致 A 进入 Prep 后显示错误的厨具列表
-   [x] 地图选择界面中缺少店铺等级提示
-   [ ] 不同 DLC 的适配问题

### NightScene 已知问题

-   [x] 两名玩家同时为同一桌顾客上菜可能出现异常
-   [ ] 仍需大量测试
        提交 Bug 时请附带日志文件：
        `Touhou Mystia Izakaya/BepInEx/LogOutput.log`

## 鸣谢

-   第一原作：**ZUN@上海アリス幻樂団**
-   第二原作：**东方夜雀食堂 / Touhou Mystia’s Izakaya**

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=MetaMikuAI/MetaMystia&type=date&legend=top-left)](https://www.star-history.com/#MetaMikuAI/MetaMystia&type=date&legend=top-left)

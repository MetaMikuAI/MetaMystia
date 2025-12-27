# MetaMystia

一次对「东方夜雀食堂」联机 Mod 的制作尝试

## 安装

1. 下载 [BepInEx il2cpp](https://builds.bepinex.dev/projects/bepinex_be) 并将其解压到游戏根目录
2. 下载 [MetaMystia.dll](https://github.com/MetaMikuAI/MetaMystia/releases) 并将其放入 `BepInEx/plugins` 目录
3. 运行游戏

## 使用

游戏内快捷键：

1. 按 `\` 显示左下角控制信息

游戏内控制台：

游戏内用 `/` 键打开游戏内控制台，按 `Enter` 提交命令，`ESC` 关闭控制台

在 InGameConsole 中，你可以使用一些命令，如联机(Multiplayer)相关

```
mp start
mp stop
mp connect 1.2.3.4
mp status
```

更多命令请 `help` 查看(或者来啃源码)

## TODO


DayScene 篇

- [x] 实现基础联机 
- [x] 实现跨地图同步
- [x] 实现较好的运动同步
- [x] 游戏内 Console
- [x] 解决 Kyouko 无物理问题
- [x] 提前加载 Kyouko
- [x] 同步"结束"
- [x] 同步对话(由 余烬特调 提供)
- [x] ping 显示
- [x] 连接后立即同步位置
- [x] 禁用 OnDayOver 时 Mystia 的个人 Dialog
- [x] 解决 Kyouko 无法上下坡的问题
- [x] 禁用等待 Kyouko 状态下交互
- [ ] ~~禁用 Kyouko 交互~~
- [x] 切换到兽道时，Kyouko 会被游戏原逻辑重置，~~需要 hook 掉~~(通过修改 NPC 数据中的 overrideposition 实现) 
- [ ] 解决剧情冲突问题
- [ ] 禁用等待 Kyouko 状态下切换地图

营业准备篇

- [x] 研究相关 API
- [ ] ~~限制仅 Kyouko 伙伴选择（暂时考虑不实现）~~
- [x] 限制必须选择相同场景和模式
- [x] 同步菜单
- [x] 同步酒水
- [x] 同步厨具
- [x] 优化厨具同步逻辑
- [x] 同步加载预设（无需额外实现） 
- [ ] ~~优化同步代码~~
- [x] 同步"开始营业"


NightScene 篇
- [x] 同步普客生成
- [x] 同步稀客生成
- [x] 同步顾客落座
- [x] 同步顾客点单
- [x] 同步上菜
- [ ] ~~同步顾客评价~~
- [ ] ~~同步顾客结账~~ (顾客结账和评价将在两端独立进行，但由于两端上的菜一致，结果将大致相同)
- [x] 同步顾客离开
- [ ] ~~同步符卡奖励/惩罚~~ (符卡奖励/惩罚来源于订单评估，由于两端上的菜一致，结果将大致相同)
- [x] 同步做菜取菜
- [x] 同步保温箱
- [ ] 同步保温箱(白天)
- [x] 同步运动状态
- [x] 移除原有伙伴
- [ ] 同步 buff
- [x] 同步 Sellable 暂存
- [ ] ~~同步时钟~~ (已延长夜晚时间240s -> 480s，同时取消时停)

其他
- [x] 自定义二人对话
- [x] 自定义角色立绘扩展
- [ ] 自定义角色小人

已知 bug 或缺陷
- [x] InGameConsole 与原有面板 UI 冲突
- [x] 对话 UI 与面板 UI 冲突
- [x] InGameConsole 与场景切换冲突
- [x] DayScene Kyouko 移动缺少 *高度* 变化
- [ ] A 在 loading 时 B 选择厨具会使 A 进入 Prep 后显示错误的厨具列表
- [x] 地图选择界面中不会缺少店铺等级的提示
- [ ] 不同 DLC 适配

NightScene 篇已知 bug 或缺陷
- [x] 两人同时给同一桌顾客上菜，可能会有问题
- [ ] 还请多多测试，bug 提交请附带上 (Touhou Mystia Izakaya\BepInEx\LogOutput.log)


## ResouceEx 

参见 ResourceEx 下的 [README.md](https://github.com/MetaMikuAI/MetaMystia/tree/main/ResourceEx) 文件，添加自定义角色立绘和对话包

## 鸣谢

- 第一原作：ZUN@上海アリス幻樂団
- 第二原作：东方夜雀食堂 - Touhou Mystia's Izakaya

特别感谢 DEYU 和 kk 等的支持和帮助


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=MetaMikuAI/MetaMystia&type=date&legend=top-left)](https://www.star-history.com/#MetaMikuAI/MetaMystia&type=date&legend=top-left)

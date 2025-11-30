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
- [ ] 解决剧情冲突问题
- [ ] 切换到兽道时，Kyouko 会被游戏原逻辑重置，需要 hook 掉
- [x] 同步"结束"
- [x] 同步对话(由 余烬特调 提供)
- [x] ping 显示
- [x] 连接后立即同步位置
- [ ] 禁用 Kyouko 交互
- [ ] 禁用 OnDayOver 时 Mystia 的个人 Dialog
- [ ] 解决兽道中交互导致 Kyouko 位置重置的问题
- [ ] 解决 Kyouko 无法上下坡的问题
- [x] 禁用等待 Kyouko 状态下交互
- [ ] 禁用等待 Kyouko 状态下切换地图

营业准备篇

- [ ] 研究相关 API
- [ ] 限制仅 Kyouko 伙伴选择
- [ ] 限制必须选择相同场景和模式
- [ ] 实现菜单完全同步
- [ ] 同步"开始营业"


NightScene 篇
- [ ] 完成这个 TODO List


## 鸣谢

- 第一原作：ZUN@上海アリス幻樂団
- 第二原作：东方夜雀食堂 - Touhou Mystia's Izakaya

特别感谢 DEYU 和 kk 的支持和帮助

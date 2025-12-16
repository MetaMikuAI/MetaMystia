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
- [ ] 禁用 Kyouko 交互
- [ ] 切换到兽道时，Kyouko 会被游戏原逻辑重置，需要 hook 掉
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
- [ ] 同步普客生成
- [ ] 同步稀客生成
- [ ] 同步符卡奖励/惩罚
- [ ] 同步厨具状态
- [ ] 同步保温箱
- [x] 同步运动状态
- [x] 移除原有伙伴
- [ ] 同步 buff
- [ ] 同步时钟

其他
- [x] 自定义二人对话

已知 bug 或缺陷
- [ ] InGameConsole 与原有面板 UI 冲突
- [ ] 对话 UI 与面板 UI 冲突
- [ ] InGameConsole 与场景切换冲突
- [x] DayScene Kyouko 移动缺少 *高度* 变化
- [ ] A 在 loading 时 B 选择厨具会使 A 进入 Prep 后显示错误的厨具列表
- [ ] 地图选择界面中不会缺少店铺等级的提示

## 鸣谢

- 第一原作：ZUN@上海アリス幻樂団
- 第二原作：东方夜雀食堂 - Touhou Mystia's Izakaya

特别感谢 DEYU 和 kk 的支持和帮助


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=MetaMikuAI/MetaMystia&type=date&legend=top-left)](https://www.star-history.com/#MetaMikuAI/MetaMystia&type=date&legend=top-left)

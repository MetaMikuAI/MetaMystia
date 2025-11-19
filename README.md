# MetaMystia

一次对「东方夜雀食堂」联机 Mod 的制作尝试

## 安装

1. 下载 [BepInEx il2cpp](https://builds.bepinex.dev/projects/bepinex_be) 并将其解压到游戏根目录
2. 下载 [MetaMystia.dll](https://github.com/MetaMikuAI/MetaMystia/releases) 并将其放入 `BepInEx/plugins` 目录
3. 运行游戏

## 使用

游戏内快捷键：

1. 按 `\` 显示左下角控制信息
2. 按 `Ctrl + /` 打开/关闭联机模式

控制台：

在前期开发阶段，提供一种通过 TCP 连接访问的控制台，方便调试和测试。

你可以使用 `telnet` 或类似工具连接到 `127.0.0.1:40814` 来访问控制台，下面的三种都是可能的

```shell
telnet 127.0.0.1 40814
ncat 127.0.0.1 40814
nc 127.0.0.1 40814
```

P.S. Windows 用户可能需要先启用 Telnet 客户端功能，或使用 [ncat](https://nmap.org/ncat/)，又或者手搓一个(x)

在 NetConsole 中，你可以使用一些命令，如联机(Multiplayer)相关

```
mp start
mp stop
mp connect 1.2.3.4
mp status
```

更多命令请 `help` 查看(或者来啃源码)

目前进行联机必须有一方进入 NetConsole 进行，如果实在不想通过 `telnet` 或 `nc` 指定连接，可以用下面 python 脚本

```python
import socket
import sys
import threading

ip_a, port_a = '127.0.0.1', 40815
ip_b, port_b = '1.2.3.4', 40815

def forward(src, dst):
    try:
        while True:
            data = src.recv(1024)
            if not data:
                break
            dst.sendall(data)
    except Exception as e:
        print(f"Forward error: {e}")
    finally:
        src.close()
        dst.close()

if __name__ == "__main__":
    sock_a = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock_b = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    try:
        sock_a.connect((ip_a, port_a))
        sock_b.connect((ip_b, port_b))
        print("Connected to both IPs")
    except Exception as e:
        print(f"Connection failed: {e}")
        sock_a.close()
        sock_b.close()
        sys.exit(1)

    t1 = threading.Thread(target=forward, args=(sock_a, sock_b))
    t2 = threading.Thread(target=forward, args=(sock_b, sock_a))

    t1.start()
    t2.start()

    t1.join()
    t2.join()

    print("Proxy closed")

```

## TODO


DayScene 篇

- [x] 实现基础联机 
- [x] 实现跨地图同步
- [x] 实现较好的运动同步
- [ ] 解决 Kyouko 无物理问题
- [ ] 研究并改变原有 Kyouko 对象生命周期
- [ ] 解决剧情冲突问题
- [ ] 切换到兽道时，Kyouko 会被游戏原逻辑重置，需要 hook 掉
- [ ] 同步"结束"

营业准备篇

- [ ] 限制仅 Kyouko 伙伴选择
- [ ] 限制必须选择相同场景和模式
- [ ] 实现菜单完全同步
- [ ] 同步"开始营业"


NightScene 篇
- [ ] 完成这个 TODO List


## 鸣谢

- 原作：**上海アリス幻樂団 ZUN**
- 二创：东方夜雀食堂 Touhou Mystia Izakaya 二色幽紫蝶
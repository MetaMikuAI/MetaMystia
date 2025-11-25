# -*- coding: utf-8 -*-
from pwn import remote, context # pip install pwntools
import threading
import sys

context.log_level = 'debug'
HOST = "127.0.0.1"
PORT = 40815

# 创建全局连接（线程共享）
r = remote(HOST, PORT)

def recv_thread():
    """后台线程：实时接收服务器数据并打印"""
    while True:
        try:
            data = r.recv(timeout=0.1)  # 不阻塞
            if data:
                decoded = data.decode(errors='ignore')
                sys.stdout.write("R: " + decoded)
                sys.stdout.flush()
        except EOFError:
            print("\n[!] 连接已关闭")
            break

# 启动后台线程
t = threading.Thread(target=recv_thread, daemon=True)
t.start()

# 主线程：持续读用户输入并发送
print("[+] 已连接，输入内容并回车发送：")

try:
    while True:
        line = sys.stdin.readline()
        if not line:
            break
        r.send(line.encode())
except KeyboardInterrupt:
    pass
finally:
    r.close()
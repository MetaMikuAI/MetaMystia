import queue
import threading
from pwn import remote, context # pip install pwntools
from time import sleep
from random import random

context.log_level = 'debug'
r = remote('127.0.0.1', 40815)
data_q = queue.Queue()

def recv_thread():
    while True:
        try:
            data = r.recv()
            if data:
                print(f"receving {data}")
                data_q.put(data)
        except EOFError:
            print("\n[!] connection closed")
            break

def heartbeat():
    while True:
        try:
            #r.send()
            sleep(3)
        except EOFError:
            print("\n[!] connection closed")
            break

t = threading.Thread(target=recv_thread, daemon=True)
t.start()

while True:
    while data_q.empty():
        sleep(0.1)
    delayMillis = random() * 200
    # delayMillis = 3200
    print(f"Delaying for {delayMillis:.2f} ms")
    sleep(delayMillis / 1000)
    while data_q.empty() == False:
        r.send(data_q.get())

# 该脚本模拟 Kyouko 连接本机 Mystia，并在每次接收到 Mystia 的数据后，随机一定延迟再发送回去
# 以此可以测试 Mystia/Kyouko 运动数据在面对网络延迟时的表现
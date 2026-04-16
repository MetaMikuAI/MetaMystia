#!/usr/bin/env python3
"""
MetaMystia 压力测试客户端
模拟 N 个 fake client 完成握手并持续发送 SyncAction，
测试主机在 O(n^2) 网络转发下的计算/网络/GC 表现。

使用 pwntools 进行网络通信。

MemoryPack wire format (v1.21.4, netstandard2.0, UTF8 mode):
  - Union:      (byte tag, value)  for tag 0-249
  - Object:     (byte memberCount, [fields in declaration order...])
  - String:     UTF8: (int32 ~byteCount, int32 utf16Length, utf8Bytes)
                null: (int32 -1)
  - Collection: (int32 count, [elements...])  null: (int32 -1)
  - int/long/float/bool: raw LE bytes
  - Enum:       as underlying type
"""

import struct
import time
import threading
import argparse
import sys
import random
import string

from pwn import *


def format_bytes(n: float) -> str:
    """将字节数格式化为人类可读的单位。"""
    for unit in ('B', 'KB', 'MB', 'GB'):
        if abs(n) < 1024:
            return f"{n:.1f} {unit}"
        n /= 1024
    return f"{n:.1f} TB"

# ═══════════════════════════════════════════════════════════════
# MemoryPack 编码工具
# ═══════════════════════════════════════════════════════════════

def mp_int32(v: int) -> bytes:
    return struct.pack("<i", v)

def mp_uint16(v: int) -> bytes:
    return struct.pack("<H", v)

def mp_int64(v: int) -> bytes:
    return struct.pack("<q", v)

def mp_float(v: float) -> bytes:
    return struct.pack("<f", v)

def mp_bool(v: bool) -> bytes:
    return struct.pack("B", 1 if v else 0)

def mp_byte(v: int) -> bytes:
    return struct.pack("B", v)

def mp_string(s: str | None) -> bytes:
    """MemoryPack UTF8 string encoding."""
    if s is None:
        return mp_int32(-1)
    if s == "":
        return mp_int32(0)
    utf8 = s.encode("utf-8")
    byte_count = len(utf8)
    utf16_length = len(s)
    # UTF8 形式: (~byteCount as int32, utf16Length as int32, utf8 bytes)
    return mp_int32(~byte_count) + mp_int32(utf16_length) + utf8

def mp_int_list(items: list[int] | None) -> bytes:
    """MemoryPack List<int> / int[] encoding."""
    if items is None:
        return mp_int32(-1)
    result = mp_int32(len(items))
    for item in items:
        result += mp_int32(item)
    return result

def mp_object_header(member_count: int) -> bytes:
    """Object header: 1 byte member count. 255 = null."""
    return mp_byte(member_count)

def mp_null_object() -> bytes:
    return mp_byte(255)

def mp_union_tag(tag: int) -> bytes:
    """Union tag: 0-249 as single byte, 250+ as (250, ushort)."""
    if tag <= 249:
        return mp_byte(tag)
    else:
        return mp_byte(250) + mp_uint16(tag)

def mp_union_null() -> bytes:
    return mp_byte(255)

def timestamp_now_ms() -> int:
    return int(time.time() * 1000)


# ═══════════════════════════════════════════════════════════════
# ActionType 枚举 (C# ushort)
# ═══════════════════════════════════════════════════════════════

class ActionType:
    PING            = 0
    PONG            = 1
    HELLO           = 2
    HELLO_ACK       = 3
    REJECT          = 4
    PEER_JOIN       = 5
    PEER_LEAVE      = 6
    SCENE_TRANSIT   = 7
    SYNC            = 8
    READY           = 9
    MESSAGE         = 10
    SELECT          = 11
    CONFIRM_SELECT  = 12
    PREP            = 13
    NIGHTSYNC       = 14

class Scene:
    DayScene         = 0
    MainScene        = 1
    LoadScene        = 2
    IzakayaPrepScene = 3
    WorkScene        = 4

class SkinSelectedType:
    Default  = 0
    Explicit = 1
    DLC      = 2


# ═══════════════════════════════════════════════════════════════
# 构建 Action 二进制
# ═══════════════════════════════════════════════════════════════

def build_player_skin(character_id: int = -1, selected_type: int = 0, skin_index: int = 0) -> bytes:
    """
    PlayerSkin 字段（按声明顺序）：
      1. CharacterId    (int)          - field
      2. SelectedType   (enum -> int)  - field
      3. SkinIndex      (int)          - field
    PlayerSkin 是 unmanaged struct? No, it has enum but that's still unmanaged...
    Wait: PlayerSkin is a class (partial class), not struct. So it's Object format.
    """
    return (
        mp_object_header(3) +
        mp_int32(character_id) +
        mp_int32(selected_type) +
        mp_int32(skin_index)
    )


def build_resource_database_empty() -> bytes:
    """
    ResourceDataBase 字段（按声明顺序）：
      1. Foods         (List<int>)
      2. Recipes       (List<int>)
      3. Beverages     (List<int>)
      4. Ingredients   (List<int>)
      5. Cookers       (List<int>)
      6. Items         (List<int>)
      7. Izakayas      (List<int>)
      8. SpecialGuests (List<int>)
      9. NormalGuests  (List<int>)
    """
    return (
        mp_object_header(9) +
        mp_int_list([]) +  # Foods
        mp_int_list([]) +  # Recipes
        mp_int_list([]) +  # Beverages
        mp_int_list([]) +  # Ingredients
        mp_int_list([]) +  # Cookers
        mp_int_list([]) +  # Items
        mp_int_list([]) +  # Izakayas
        mp_int_list([]) +  # SpecialGuests
        mp_int_list([])    # NormalGuests
    )


def build_hello_action(peer_id: str, mod_version: str, game_version: str,
                       current_scene: int = Scene.DayScene) -> bytes:
    """
    HelloAction (ActionType.HELLO = 2) 字段：
    MemoryPack 序列化 (含 abstract Type property):
      1. Type              (ushort)  ← MemoryPack 自动序列化 override property
      2. TimestampMs       (long)
      3. SenderUid         (int)
      4. PeerId            (string)
      5. Version           (string)
      6. GameVersion       (string)
      7. CurrentGameScene  (enum Scene -> int32)
      8. PeerDataBase      (ResourceDataBase)
      9. PeerSkin          (PlayerSkin)

    总字段数 = 9
    """
    body = (
        mp_object_header(9) +

        # Type property (ushort ActionType)
        mp_uint16(ActionType.HELLO) +

        # base fields
        mp_int64(timestamp_now_ms()) +
        mp_int32(-1) +   # SenderUid (server overrides this)

        # HelloAction fields
        mp_string(peer_id) +
        mp_string(mod_version) +
        mp_string(game_version) +
        mp_int32(current_scene) +
        build_resource_database_empty() +
        build_player_skin()
    )

    # Wrap in Union: tag = ActionType.HELLO = 2
    return mp_union_tag(ActionType.HELLO) + body


def build_scene_transit_action(scene: int, sender_uid: int = 0) -> bytes:
    """
    SceneTransitAction (ActionType.SCENE_TRANSIT = 7) 字段：
      1. Type         (ushort)
      2. TimestampMs  (long)
      3. SenderUid    (int)
      4. Scene        (enum -> int32)

    总字段数 = 4
    """
    body = (
        mp_object_header(4) +
        mp_uint16(ActionType.SCENE_TRANSIT) +
        mp_int64(timestamp_now_ms()) +
        mp_int32(sender_uid) +
        mp_int32(scene)
    )
    return mp_union_tag(ActionType.SCENE_TRANSIT) + body


def build_sync_action(px: float, py: float, vx: float = 0.0, vy: float = 0.0,
                      is_sprinting: bool = False, speed: float = 1.0,
                      map_label: str = "HumanVillage",
                      sender_uid: int = 0) -> bytes:
    """
    SyncAction (ActionType.SYNC = 8) 字段：
      1. Type         (ushort)
      2. TimestampMs  (long)
      3. SenderUid    (int)
      4. Vx           (float)
      5. Vy           (float)
      6. Px           (float)
      7. Py           (float)
      8. IsSprinting  (bool)
      9. Speed        (float)
     10. MapLabel     (string)

    总字段数 = 10
    """
    body = (
        mp_object_header(10) +
        mp_uint16(ActionType.SYNC) +
        mp_int64(timestamp_now_ms()) +
        mp_int32(sender_uid) +
        mp_float(vx) +
        mp_float(vy) +
        mp_float(px) +
        mp_float(py) +
        mp_bool(is_sprinting) +
        mp_float(speed) +
        mp_string(map_label)
    )
    return mp_union_tag(ActionType.SYNC) + body


# ═══════════════════════════════════════════════════════════════
# NetPacket 封装
# ═══════════════════════════════════════════════════════════════

def build_net_packet(actions: list[bytes]) -> bytes:
    """
    NetPacket (MemoryPackable class) 字段：
      1. Actions (Action[])

    Object header: member count = 1
    Then: Array of union-encoded actions
    """
    # Array header: int32 count
    array_data = mp_int32(len(actions))
    for action_bytes in actions:
        array_data += action_bytes

    return mp_object_header(1) + array_data


def frame_packet(packet_bytes: bytes) -> bytes:
    """添加 4 字节长度前缀。"""
    return mp_int32(len(packet_bytes)) + packet_bytes


def send_action(tube, action_bytes: bytes, client=None):
    """将单个 action 封成 NetPacket 并发送。"""
    pkt = build_net_packet([action_bytes])
    data = frame_packet(pkt)
    tube.send(data)
    if client is not None:
        client.bytes_sent += len(data)


# ═══════════════════════════════════════════════════════════════
# 接收 & 解析
# ═══════════════════════════════════════════════════════════════

def recv_packet_raw(tube, timeout: float = 10.0, client=None) -> bytes:
    """接收一个完整的 NetPacket（带长度前缀）。"""
    len_bytes = tube.recvn(4, timeout=timeout)
    if client is not None:
        client.bytes_recv += 4
    body_len = struct.unpack("<i", len_bytes)[0]
    if body_len <= 0 or body_len > 1024 * 1024:
        raise ValueError(f"Invalid packet length: {body_len}")
    body = tube.recvn(body_len, timeout=timeout)
    if client is not None:
        client.bytes_recv += body_len
    return body


def peek_action_type(packet_body: bytes) -> int:
    """
    从 NetPacket body 中快速提取第一个 Action 的 ActionType tag。

    格式: ObjectHeader(1) + ArrayLen(4) + UnionTag(1 or 3) + ...
    """
    if len(packet_body) < 6:
        return -1

    # Skip: object header (1 byte) + array length (4 bytes)
    offset = 5
    tag_byte = packet_body[offset]
    if tag_byte == 250:
        # Extended tag: next 2 bytes
        return struct.unpack_from("<H", packet_body, offset + 1)[0]
    elif tag_byte == 255:
        return -1  # null union
    else:
        return tag_byte


# ═══════════════════════════════════════════════════════════════
# FakeClient
# ═══════════════════════════════════════════════════════════════

class FakeClient:
    def __init__(self, host: str, port: int, peer_id: str,
                 mod_version: str, game_version: str, client_index: int):
        self.host = host
        self.port = port
        self.peer_id = peer_id
        self.mod_version = mod_version
        self.game_version = game_version
        self.client_index = client_index
        self.assigned_uid = -1
        self.tube = None
        self.running = False
        self.sync_count = 0
        self.bytes_sent = 0
        self.bytes_recv = 0
        self.error = None

    def connect_and_handshake(self) -> bool:
        """连接到主机并完成 Hello/HelloAck 握手。"""
        try:
            self.tube = remote(self.host, self.port, level="error")
            log.info(f"[Client {self.client_index}] Connected to {self.host}:{self.port}")
        except Exception as e:
            self.error = f"Connection failed: {e}"
            log.error(f"[Client {self.client_index}] {self.error}")
            return False

        # 发送 HelloAction
        hello = build_hello_action(
            peer_id=self.peer_id,
            mod_version=self.mod_version,
            game_version=self.game_version,
            current_scene=Scene.DayScene
        )
        send_action(self.tube, hello, client=self)
        log.info(f"[Client {self.client_index}] Sent HELLO as '{self.peer_id}'")

        # 等待 HelloAck 或 Reject（跳过其他客户端的 broadcast 包）
        try:
            deadline = time.time() + 10
            while time.time() < deadline:
                body = recv_packet_raw(self.tube, timeout=max(0.5, deadline - time.time()), client=self)
                action_type = peek_action_type(body)

                if action_type == ActionType.HELLO_ACK:
                    # 解析 AssignedUid: 跳过 NetPacket 头部和 HelloAckAction 字段
                    # ObjectHeader(1) + ArrayLen(4) + UnionTag(1) + ObjectHeader(1)
                    #   + Type(2) + TimestampMs(8) + SenderUid(4) + AssignedUid(4)
                    offset = 5 + 1 + 1 + 2 + 8 + 4
                    self.assigned_uid = struct.unpack_from("<i", body, offset)[0]
                    log.success(f"[Client {self.client_index}] Got HELLO_ACK, UID={self.assigned_uid}")
                    return True

                elif action_type == ActionType.REJECT:
                    log.error(f"[Client {self.client_index}] Rejected by host!")
                    self.tube.close()
                    return False
                else:
                    # 跳过非握手包（如其他客户端的 Sync/PeerJoin broadcast）
                    log.debug(f"[Client {self.client_index}] Skipping broadcast action type: {action_type}")
                    continue

            log.error(f"[Client {self.client_index}] Handshake timeout: no HELLO_ACK received")
            self.tube.close()
            return False

        except Exception as e:
            self.error = f"Handshake failed: {e}"
            log.error(f"[Client {self.client_index}] {self.error}")
            return False

    def send_scene_transit(self, scene: int = Scene.DayScene):
        """发送场景切换 Action。"""
        action = build_scene_transit_action(scene, sender_uid=self.assigned_uid)
        send_action(self.tube, action, client=self)
        log.info(f"[Client {self.client_index}] Sent SCENE_TRANSIT -> scene={scene}")

    def start_sync_loop(self, interval: float = 0.5, duration: float = 0.0):
        """
        开始持续发送 SyncAction。
        interval: 发送间隔（秒）
        duration: 持续时间（秒），0 = 无限
        """
        self.running = True
        start_time = time.time()

        # 随机起始位置
        px = random.uniform(-5.0, 5.0)
        py = random.uniform(-3.0, 3.0)

        while self.running:
            if duration > 0 and (time.time() - start_time) > duration:
                break

            # 模拟小幅度移动
            vx = random.uniform(-1.0, 1.0)
            vy = random.uniform(-1.0, 1.0)
            px += vx * interval * 0.5
            py += vy * interval * 0.5

            try:
                action = build_sync_action(
                    px=px, py=py, vx=vx, vy=vy,
                    is_sprinting=random.random() > 0.8,
                    speed=1.0,
                    map_label="HumanVillage",
                    sender_uid=self.assigned_uid
                )
                send_action(self.tube, action, client=self)
                self.sync_count += 1
            except Exception as e:
                log.error(f"[Client {self.client_index}] Sync send failed: {e}")
                self.running = False
                break

            time.sleep(interval)

    def stop(self):
        self.running = False
        if self.tube:
            try:
                self.tube.close()
            except:
                pass

    def drain_recv(self):
        """后台线程：持续读取服务器发来的包（避免 TCP 缓冲区满导致零窗口）。"""
        while self.running:
            try:
                data = self.tube.recv(65536, timeout=0.5)
                if not data:
                    break
                self.bytes_recv += len(data)
            except:
                if not self.running:
                    break
                continue


# ═══════════════════════════════════════════════════════════════
# 主入口
# ═══════════════════════════════════════════════════════════════

def main():
    parser = argparse.ArgumentParser(description="MetaMystia Sync Stress Test")
    parser.add_argument("-H", "--host", default="127.0.0.1", help="Host IP (default: 127.0.0.1)")
    parser.add_argument("-p", "--port", type=int, default=40815, help="Port (default: 40815)")
    parser.add_argument("-n", "--clients", type=int, default=10, help="Number of fake clients (default: 10)")
    parser.add_argument("-i", "--interval", type=float, default=0.5, help="Sync interval in seconds (default: 0.5)")
    parser.add_argument("-d", "--duration", type=float, default=60.0, help="Test duration in seconds (default: 60)")
    parser.add_argument("--mod-version", default="0.21.1", help="Mod version to send in Hello")
    parser.add_argument("--game-version", default="RELEASE 4.3.1", help="Game version to send in Hello")
    parser.add_argument("--stagger", type=float, default=0.2, help="Delay between client connections (default: 0.2s)")
    args = parser.parse_args()

    context.log_level = "info"

    log.info(f"╔══════════════════════════════════════════════════╗")
    log.info(f"║  MetaMystia Sync Stress Test                    ║")
    log.info(f"║  Target: {args.host}:{args.port:<30}║")
    log.info(f"║  Clients: {args.clients:<5}  Interval: {args.interval}s              ║")
    log.info(f"║  Duration: {args.duration}s                              ║")
    log.info(f"╚══════════════════════════════════════════════════╝")

    clients: list[FakeClient] = []
    threads: list[threading.Thread] = []

    # ── 阶段 1: 连接 & 握手 ──
    log.info("Phase 1: Connecting clients...")
    for i in range(args.clients):
        peer_id = f"StressBot_{i:03d}"
        client = FakeClient(
            host=args.host, port=args.port,
            peer_id=peer_id,
            mod_version=args.mod_version,
            game_version=args.game_version,
            client_index=i
        )

        if client.connect_and_handshake():
            clients.append(client)
            # 握手成功后立即启动 drain 线程，避免后续广播包填满 TCP 缓冲区
            client.running = True
            drain_thread = threading.Thread(target=client.drain_recv, daemon=True)
            drain_thread.start()
        else:
            log.warning(f"[Client {i}] Failed to connect, skipping")

        time.sleep(args.stagger)

    if not clients:
        log.error("No clients connected successfully. Exiting.")
        return

    log.success(f"Phase 1 complete: {len(clients)}/{args.clients} clients connected")

    # ── 阶段 2: 发送 SceneTransit → DayScene ──
    log.info("Phase 2: Sending SceneTransit to DayScene...")
    for client in clients:
        client.send_scene_transit(Scene.DayScene)
        time.sleep(0.05)

    time.sleep(1.0)  # 让主机处理场景切换

    # ── 阶段 3: 启动 Sync 洪泛 ──
    log.info(f"Phase 3: Starting Sync flood ({args.duration}s)...")

    for client in clients:
        # drain 线程已在握手后启动，这里只启动 Sync 发送线程
        sync_thread = threading.Thread(
            target=client.start_sync_loop,
            args=(args.interval, args.duration),
            daemon=True
        )
        sync_thread.start()
        threads.append(sync_thread)

    # ── 等待测试完成 ──
    start_time = time.time()
    try:
        while time.time() - start_time < args.duration + 5:
            time.sleep(5)
            elapsed = time.time() - start_time
            total_syncs = sum(c.sync_count for c in clients)
            alive = sum(1 for c in clients if c.running)
            total_sent = sum(c.bytes_sent for c in clients)
            total_recv = sum(c.bytes_recv for c in clients)
            log.info(
                f"[{elapsed:.0f}s] Alive: {alive}/{len(clients)}, "
                f"Syncs: {total_syncs}, "
                f"Rate: {total_syncs / max(elapsed, 1):.1f} sync/s, "
                f"TX: {format_bytes(total_sent)}, RX: {format_bytes(total_recv)}"
            )
    except KeyboardInterrupt:
        log.warning("Interrupted by user")

    # ── 阶段 4: 清理 ──
    log.info("Phase 4: Stopping clients...")
    for client in clients:
        client.stop()

    for t in threads:
        t.join(timeout=3)

    # ── 汇总 ──
    total_syncs = sum(c.sync_count for c in clients)
    alive = sum(1 for c in clients if c.running)
    total_sent = sum(c.bytes_sent for c in clients)
    total_recv = sum(c.bytes_recv for c in clients)
    elapsed = time.time() - start_time
    n = len(clients)
    relay_writes = total_syncs * max(n - 1, 1)

    log.info(f"╔═══════════════════════════════════════════════════════╗")
    log.info(f"║  Test Complete                                       ║")
    log.info(f"╠═══════════════════════════════════════════════════════╣")
    log.info(f"║  Duration:    {elapsed:.1f}s")
    log.info(f"║  Clients:     {n} connected")
    log.info(f"║  Total Syncs: {total_syncs}")
    log.info(f"║  Sync Rate:   {total_syncs / max(elapsed, 1):.1f} sync/s  ({total_syncs / max(n, 1) / max(elapsed, 1):.2f}/client)")
    log.info(f"║  Relay Work:  {total_syncs} × {max(n-1, 1)} = ~{relay_writes} writes")
    log.info(f"╠═══════════════════════════════════════════════════════╣")
    log.info(f"║  Network Traffic (all clients combined)              ║")
    log.info(f"║  TX (client→server): {format_bytes(total_sent):>10} ({format_bytes(total_sent / max(elapsed, 1))}/s)")
    log.info(f"║  RX (server→client): {format_bytes(total_recv):>10} ({format_bytes(total_recv / max(elapsed, 1))}/s)")
    log.info(f"║  Total:              {format_bytes(total_sent + total_recv):>10}")
    log.info(f"║  Per-client TX:      {format_bytes(total_sent / max(n, 1)):>10}")
    log.info(f"║  Per-client RX:      {format_bytes(total_recv / max(n, 1)):>10}")
    log.info(f"╚═══════════════════════════════════════════════════════╝")


if __name__ == "__main__":
    main()

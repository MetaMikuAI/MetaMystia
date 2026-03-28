using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace MetaMystia.UI;

public enum Language
{
    ChineseSimplified,
    ChineseTraditional,
    English,
    Japanese,
    Korean
}

public enum TextId
{
    // Multiplayer Connection & Commands
    ConnectCommand,
    ConnectCommandConnected,
    ConnectCommandFail,

    // Multiplayer Usage & Help
    MpUsageHelp,
    MpUsageRoot,
    MpSubcommandHelp,
    MpUsageSetId,

    // Multiplayer Status & Responses
    MpAlreadyStarted,
    MpStartedAsHost,
    MpStartedAsClient,
    MpStopped,
    MpRestarted,
    MpPlayerIdSet,
    PeerPlayerIdChanged,
    MpNoActiveConnection,
    MpConnecting,
    MpDisconnected,
    MpUnknownSubcommand,

    // Network Error Messages
    ModVersionMismatch,
    GameVersionMismatch,
    SceneMismatchDisconnected,

    // Connection Status Notifications
    MultiplayerConnected,
    MultiplayerDisconnected,
    MpConnected,
    PeerJoined,
    PeerLeft,
    ChallengeWarning,

    // Peer Disconnect & Continue
    PeerDisconnectedAllReady,
    PeerDisconnectedWaiting,
    MpContinueHostOnly,
    MpKickHostOnly,
    MpKickNoTarget,
    MpKickSelf,
    MpKickNotFound,
    MpKickSuccess,
    MpContinueUsage,
    MpContinueSuccess,
    MpContinueFailed,
    PrepWorkReconnectBlocked,

    // Business/Shop Related
    TodayBusinessHours,
    PeerAlreadyInScene,
    SelectedIzakaya,
    SelectedIzakayaMismatch,
    WaitingForHostConfirm,
    PeerSelectedIzakaya,
    MystiaReadyForWork,
    ReadyForWork,
    AllReadyTransition,
    PeerClosedIzakaya,

    // Chat System
    ChatMessagePeer,
    ChatMessageSelf,

    // Version & Update Info
    ModVersionUnavailable,
    ModVersionLatest,
    ModVersionOutdated,

    // Resource Management
    SignatureVerificationDisabled,
    ResourcePackageValidationFailed,
    ResourcePackageLoaded,

    // DLC Availability Checks
    DLCPeerRecipeNotAvailable,
    DLCPeerBeverageNotAvailable,
    DLCPeerFoodNotAvailable,
    DLCPeerCookerNotAvailable,

    // System Messages
    ModPatchFailure,

    // Console UI & Formatting
    PeerMessagePrefix,
    CommandPrompt,
    BepInExConsoleEnabled,

    // Console Command Help & Usage
    AvailableCommands,
    GetUsage,
    AvailableFields,
    CallUsage,
    AvailableMethods,
    MoveCharacterUsage,
    SceneMoveUsage,
    WebDebuggerUsage,

    // Console Status & Queries
    NotInDayScene,
    NotInWorkScene,
    MapInfoDisplay,
    CurrentMapLabel,
    MystiaPosition,
    UnknownField,

    // Console Error Messages
    UnknownCommand,
    UnknownMethod,
    ErrorGetMapsnpcs,
    ErrorMovecharacter,
    ErrorSceneMove,
    InvalidWebDebuggerKey,

    // Console Results & Feedback
    MessageSent,
    NPCListItem,
    TotalNPCsFound,
    CharacterMoved,
    CharacterMovedScene,
    CalledTryCloseIzakaya,
    WebDebuggerStarted,

    // Skin Commands
    SkinUsage,
    SkinEnabled,
    SkinDisabled,
    SkinAlreadyDisabled,
    SkinSetMystia,
    SkinSetNpc,
    SkinInvalidType,
    SkinInvalidIndex,
    SkinNpcNotFound,
    SkinListHeader,
    SkinListItem,
    SkinListNpcHint,
    SkinStatus,
    SkinStatusDisabled,

    // Help & Command Descriptions (L10N)
    HelpHeader,
    CmdDescHelp,
    CmdDescClear,
    CmdDescGet,
    CmdDescMp,
    CmdDescCall,
    CmdDescSkin,
    CmdDescDebug,
    CmdDescWebdebug,
    CmdDescWhereami,
    CmdDescEnableBepinConsole,

    // Subcommand help headers
    MpHelpHeader,
    CallHelpHeader,
    SkinHelpHeader,

    // Subcommand descriptions (short)
    MpDescStart,
    MpDescStop,
    MpDescRestart,
    MpDescStatus,
    MpDescId,
    MpDescConnect,
    MpDescDisconnect,
    MpDescKick,
    MpDescKickId,
    MpDescKickUid,
    MpDescContinue,
    CallDescGetmapsnpcs,
    CallDescMovecharacter,
    CallDescSceneMove,
    CallDescTryCloseIzakaya,
    SkinDescSet,
    SkinDescOff,
    SkinDescList,

    // Console startup & link
    ConsoleStarPrompt,
    ConsoleHelpHint,
    CmdDescLink,
    LinkDescMetaMystia,
    LinkDescIzakaya,

    // ResourceEx Console Messages & Commands
    ResourceExConsoleLoaded,
    ResourceExConsoleLoadedNoInfo,
    ResourceExConsoleRejected,
    CmdDescResourceEx,
    ResourceExHelpHeader,
    ResourceExDescList,
    ResourceExDescInfo,
    ResourceExListHeader,
    ResourceExListItem,
    ResourceExListEmpty,
    ResourceExInfoHeader,
    ResourceExInfoName,
    ResourceExInfoLabel,
    ResourceExInfoVersion,
    ResourceExInfoAuthors,
    ResourceExInfoDescription,
    ResourceExInfoLicense,
    ResourceExInfoIdRange,
    ResourceExInfoContents,
    ResourceExInfoNotFound,
    ResourceExRejectedHeader,
    ResourceExRejectedItem,
}

public static class L10n
{
    private static readonly Dictionary<TextId, Dictionary<Language, string>> Table = new()
    {
        // Multiplayer Connection & Commands
        [TextId.ConnectCommand] = new()
        {
            [Language.English] = "Usage: /mp connect <IP:Port>",
            [Language.ChineseSimplified] = "用法：/mp connect <IP:端口>",
            [Language.ChineseTraditional] = "用法：/mp connect <IP:端口>",
            [Language.Japanese] = "使用方法: /mp connect <IPアドレス:ポート>",
            [Language.Korean] = "사용법: /mp connect <IP:포트>",
        },

        [TextId.ConnectCommandConnected] = new()
        {
            [Language.English] = "Successfully connected to {0}",
            [Language.ChineseSimplified] = "成功连接到 {0}",
            [Language.ChineseTraditional] = "成功連接到 {0}",
            [Language.Japanese] = "{0} に接続しました",
            [Language.Korean] = "{0}에 성공적으로 연결됨",
        },

        [TextId.ConnectCommandFail] = new()
        {
            [Language.English] = "Failed to connect to {0}",
            [Language.ChineseSimplified] = "连接到 {0} 失败！",
            [Language.ChineseTraditional] = "連接到 {0} 失敗！",
            [Language.Japanese] = "{0} への接続に失敗しました！",
            [Language.Korean] = "{0}에 연결 실패!",
        },

        [TextId.MpUsageHelp] = new()
        {
            [Language.English] = "Usage: /mp start server  |  /mp start client",
            [Language.ChineseSimplified] = "用法：/mp start server（主机）或 /mp start client（客户端）",
            [Language.ChineseTraditional] = "用法：/mp start server（主機）或 /mp start client（客戶端）",
            [Language.Japanese] = "使用方法: /mp start server（ホスト）または /mp start client（クライアント）",
            [Language.Korean] = "사용법: /mp start server(호스트) 또는 /mp start client(클라이언트)",
        },

        [TextId.MpAlreadyStarted] = new()
        {
            [Language.English] = "Multiplayer is already running as {0}",
            [Language.ChineseSimplified] = "联机系统已在运行（角色：{0}）",
            [Language.ChineseTraditional] = "聯機系統已在運行（角色：{0}）",
            [Language.Japanese] = "マルチプレイはすでに {0} として起動しています",
            [Language.Korean] = "멀티플레이가 이미 {0}(으)로 실행 중입니다",
        },

        [TextId.MpStartedAsHost] = new()
        {
            [Language.English] = "Multiplayer started as Host ✓",
            [Language.ChineseSimplified] = "已启动为主机 ✓",
            [Language.ChineseTraditional] = "已啟動為主機 ✓",
            [Language.Japanese] = "ホストとして起動しました ✓",
            [Language.Korean] = "호스트로 시작되었습니다 ✓",
        },

        [TextId.MpStartedAsClient] = new()
        {
            [Language.English] = "Multiplayer started as Client ✓",
            [Language.ChineseSimplified] = "已启动为客户端 ✓",
            [Language.ChineseTraditional] = "已啟動為客戶端 ✓",
            [Language.Japanese] = "クライアントとして起動しました ✓",
            [Language.Korean] = "클라이언트로 시작되었습니다 ✓",
        },

        [TextId.MpStopped] = new()
        {
            [Language.English] = "Multiplayer stopped ✕",
            [Language.ChineseSimplified] = "已停止联机 ✕",
            [Language.ChineseTraditional] = "已停止聯機 ✕",
            [Language.Japanese] = "マルチプレイを停止しました ✕",
            [Language.Korean] = "멀티플레이가 중단되었습니다 ✕",
        },

        [TextId.MpRestarted] = new()
        {
            [Language.English] = "Multiplayer restarted ↻",
            [Language.ChineseSimplified] = "已重启联机 ↻",
            [Language.ChineseTraditional] = "已重啟聯機 ↻",
            [Language.Japanese] = "マルチプレイを再起動しました ↻",
            [Language.Korean] = "멀티플레이를 다시 시작했습니다 ↻",
        },

        [TextId.MpSubcommandHelp] = new()
        {
            [Language.English] = "Subcommands: start, stop, restart, status, id, connect, disconnect",
            [Language.ChineseSimplified] = "子命令：start、stop、restart、status、id、connect、disconnect",
            [Language.ChineseTraditional] = "子命令：start、stop、restart、status、id、connect、disconnect",
            [Language.Japanese] = "サブコマンド：start、stop、restart、status、id、connect、disconnect",
            [Language.Korean] = "부강령: start, stop, restart, status, id, connect, disconnect",
        },

        [TextId.MpUsageRoot] = new()
        {
            [Language.English] = "Usage: /mp <subcommand> [args]",
            [Language.ChineseSimplified] = "用法：/mp <子命令> [参数] （不要尖括号和方括号哦）",
            [Language.ChineseTraditional] = "用法：/mp <子命令> [参數] （不每尖括號和方括號哦）",
            [Language.Japanese] = "使用方法: /mp <サブコマンド> [引数]",
            [Language.Korean] = "사용법: /mp <부강령> [인른제]",
        },

        [TextId.MpUsageSetId] = new()
        {
            [Language.English] = "Usage: /mp id <new_id>",
            [Language.ChineseSimplified] = "用法：/mp id <新ID> （不要尖括号哦）",
            [Language.ChineseTraditional] = "用法：/mp id <新ID> （不每尖括號哦）",
            [Language.Japanese] = "使用方法: /mp id <新しいID>",
            [Language.Korean] = "사용법: /mp id <새ID>",
        },
        [TextId.MpPlayerIdSet] = new()
        {
            [Language.English] = "Player ID set to {0}",
            [Language.ChineseSimplified] = "玩家 ID 已设置为 {0}",
            [Language.ChineseTraditional] = "玩家 ID 已設置為 {0}",
            [Language.Japanese] = "プレイヤーIDを {0} に設定しました",
            [Language.Korean] = "플레이어 ID가 {0}으로 설정되었습니다",
        },
        [TextId.PeerPlayerIdChanged] = new()
        {
            [Language.English] = "Player changed their ID: {0} -> {1}",
            [Language.ChineseSimplified] = "玩家已更改 ID：{0} -> {1}",
            [Language.ChineseTraditional] = "玩家已更改 ID：{0} -> {1}",
            [Language.Japanese] = "プレイヤーがIDを変更しました：{0} -> {1}",
            [Language.Korean] = "플레이어가 ID를 변경했습니다: {0} -> {1}",
        },

        [TextId.MpNoActiveConnection] = new()
        {
            [Language.English] = "No active multiplayer connection",
            [Language.ChineseSimplified] = "当前没有活动的网络连接",
            [Language.ChineseTraditional] = "當前沒有活動的網路連接",
            [Language.Japanese] = "アクティブなマルチプレイ接続がありません",
            [Language.Korean] = "활성 멀티플레이 연결이 없습니다",
        },

        [TextId.MpConnecting] = new()
        {
            [Language.English] = "Connecting to {0}:{1}...",
            [Language.ChineseSimplified] = "正在连接到 {0}:{1}...",
            [Language.ChineseTraditional] = "正在連接到 {0}:{1}...",
            [Language.Japanese] = "{0}:{1} に接続中...",
            [Language.Korean] = "{0}:{1}에 연결 중...",
        },

        [TextId.MpDisconnected] = new()
        {
            [Language.English] = "Disconnected",
            [Language.ChineseSimplified] = "已断开连接",
            [Language.ChineseTraditional] = "已斷開連接",
            [Language.Japanese] = "接続を切断しました",
            [Language.Korean] = "연결 끊김",
        },

        [TextId.MpUnknownSubcommand] = new()
        {
            [Language.English] = "Unknown subcommand: {0}",
            [Language.ChineseSimplified] = "未知的子命令：{0}",
            [Language.ChineseTraditional] = "未知的子命令：{0}",
            [Language.Japanese] = "不明なサブコマンド：{0}",
            [Language.Korean] = "알 수 없는 부강령: {0}",
        },

        [TextId.DLCPeerFoodNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the food item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食物 {0} 的 DLC 或资源包",
            [Language.ChineseTraditional] = "有玩家未裝載有此食物 {0} 的 DLC 或資源包",
            [Language.Japanese] = "食材 {0} を含む DLC またはリソースパック がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "식재료 {0}를 포함한 DLC 또는 리소스 팩을 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.DLCPeerBeverageNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the beverage item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此酒水 {0} 的 DLC 或资源包",
            [Language.ChineseTraditional] = "有玩家未裝載有此酒水 {0} 的 DLC 或資源包",
            [Language.Japanese] = "飲料 {0} を含む DLC またはリソースパック がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "음료 {0}를 포함한 DLC 또는 리소스 팩을 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.DLCPeerRecipeNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the recipe item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食谱 {0} 的 DLC 或资源包",
            [Language.ChineseTraditional] = "有玩家未裝載有此食譜 {0} 的 DLC 或資源包",
            [Language.Japanese] = "レシピ {0} を含む DLC またはリソースパック がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "레시피 {0}를 포함한 DLC 또는 리소스 팩을 설치하지 않은 플레이어가 있습니다.",
        },
        [TextId.DLCPeerCookerNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the cooker item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此厨具 {0} 的 DLC 或资源包",
            [Language.ChineseTraditional] = "有玩家未裝載有此廚具 {0} 的 DLC 或資源包",
            [Language.Japanese] = "調理器具 {0} を含む DLC またはリソースパック がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "조리기구 {0}를 포함한 DLC 또는 리소스 팩을 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.ReadyForWork] = new()
        {
            [Language.English] = "{0} are ready to open for business.",
            [Language.ChineseSimplified] = "{0} 已经准备好营业啦",
            [Language.ChineseTraditional] = "{0} 已經準備好營業啦",
            [Language.Japanese] = "{0} は営業を開始する準備ができました。",
            [Language.Korean] = "{0}이(ga) 영업을 시작할 준비가 되었습니다.",
        },

        [TextId.MystiaReadyForWork] = new()
        {
            [Language.English] = "You are ready to open for business.",
            [Language.ChineseSimplified] = "你已经准备好营业啦",
            [Language.ChineseTraditional] = "你已經準備好營業啦",
            [Language.Japanese] = "あなたは営業を開始する準備ができました。",
            [Language.Korean] = "당신이 영업을 시작할 준비가 되었습니다.",
        },

        [TextId.AllReadyTransition] = new()
        {
            [Language.English] = "All players are ready, transitioning...",
            [Language.ChineseSimplified] = "全员就绪，即将切换场景…",
            [Language.ChineseTraditional] = "全員就緒，即將切換場景…",
            [Language.Japanese] = "全員準備完了、シーン切り替え中…",
            [Language.Korean] = "전원 준비 완료, 장면 전환 중…",
        },

        [TextId.ModPatchFailure] = new()
        {
            [Language.English] = "Patch failure! The Mod will not function normally! Maybe your game version is not supported, please consider removing the mod!",
            [Language.ChineseSimplified] = "补丁注入失败！此Mod将不会正常运行！可能是你的游戏版本不受支持？请考虑移除此Mod进行游玩！",
            [Language.ChineseTraditional] = "補丁注入失敗！此Mod將不會正常運行！可能是你的遊戲版本不受支持？請考慮移除此Mod進行遊玩！",
            [Language.Japanese] = "パッチ注入失敗！この Mod は正常に機能しません。ゲームのバージョンがサポートされていない可能性があります。Mod を削除することをお勧めします！",
            [Language.Korean] = "㊏슢 주입 실패！이 Mod는 정상적으로 작동하지 않습니다！ 게임 버전이 지원되지 않을 수 있으니 Mod 제거를 고려하세요！",
        },

        [TextId.ModVersionMismatch] = new()
        {
            [Language.English] = "Mod version mismatch, connection disconnected!",
            [Language.ChineseSimplified] = "Mod 版本不匹配，连接已断开！",
            [Language.ChineseTraditional] = "Mod 版本不匹配，連接已斷開！",
            [Language.Japanese] = "Mod バージョンが一致しません。接続を切断しました！",
            [Language.Korean] = "Mod 버전 불일치, 연결 끊김!",
        },

        [TextId.GameVersionMismatch] = new()
        {
            [Language.English] = "Game version mismatch, connection disconnected!",
            [Language.ChineseSimplified] = "游戏版本不匹配，连接已断开！",
            [Language.ChineseTraditional] = "遊戲版本不匹配，連接已斷開！",
            [Language.Japanese] = "ゲームバージョンが一致しません。接続を切断しました！",
            [Language.Korean] = "게임 버전 불일치, 연결 끊김!",
        },

        [TextId.SceneMismatchDisconnected] = new()
        {
            [Language.English] = "One or more players are not in the DayScene or MainScene at the same time, connection disconnected!",
            [Language.ChineseSimplified] = "有玩家不同处于白天或主界面，连接已断开",
            [Language.ChineseTraditional] = "有玩家不同處於白天或主界面，連接已斷開",
            [Language.Japanese] = "同時に白昼シーンまたはメインシーンにいないプレイヤーがいます。接続を切断しました！",
            [Language.Korean] = "동시에 낮 장면 또는 메인 장면에 있지 않은 플레이어가 있습니다. 연결 끊김!",
        },

        [TextId.MultiplayerConnected] = new()
        {
            [Language.English] = "Multiplayer system: Connected!",
            [Language.ChineseSimplified] = "联机系统：已连接！",
            [Language.ChineseTraditional] = "聯機系統：已連接！",
            [Language.Japanese] = "マルチプレイシステム：接続しました！",
            [Language.Korean] = "멀티플레이 시스템: 연결됨!",
        },

        [TextId.MultiplayerDisconnected] = new()
        {
            [Language.English] = "Multiplayer system: Connection disconnected!",
            [Language.ChineseSimplified] = "联机系统：连接已断开！",
            [Language.ChineseTraditional] = "聯機系統：連接已斷開！",
            [Language.Japanese] = "マルチプレイシステム：接続が切断されました！",
            [Language.Korean] = "멀티플레이 시스템: 연결 끊김!",
        },

        [TextId.MpConnected] = new()
        {
            [Language.English] = "Connected to {0}",
            [Language.ChineseSimplified] = "已连接到 {0}",
            [Language.ChineseTraditional] = "已連接到 {0}",
            [Language.Japanese] = "{0} に接続しました",
            [Language.Korean] = "{0}에 연결됨",
        },

        [TextId.PeerJoined] = new()
        {
            [Language.English] = "{0} joined the session",
            [Language.ChineseSimplified] = "{0} 加入了联机",
            [Language.ChineseTraditional] = "{0} 加入了聯機",
            [Language.Japanese] = "{0} がセッションに参加しました",
            [Language.Korean] = "{0}이(가) 세션에 참여했습니다",
        },

        [TextId.PeerLeft] = new()
        {
            [Language.English] = "{0} left the session",
            [Language.ChineseSimplified] = "{0} 离开了联机",
            [Language.ChineseTraditional] = "{0} 離開了聯機",
            [Language.Japanese] = "{0} がセッションを退出しました",
            [Language.Korean] = "{0}이(가) 세션에서 나갔습니다",
        },

        [TextId.ChallengeWarning] = new()
        {
            [Language.English] = "Possibly in a challenge, recommend disconnecting for better game experience!",
            [Language.ChineseSimplified] = "检测到可能在进行挑战，建议断开连接确保游戏体验!",
            [Language.ChineseTraditional] = "檢測到可能在進行挑戰，建議斷開連接確保遊戲體驗!",
            [Language.Japanese] = "チャレンジ中の可能性があります。より良いゲーム体験のため、接続を切断することをお勧めします！",
            [Language.Korean] = "도전 중일 가능성, 더 나은 게임 체험을 위해 연결 끊김 권장!",
        },

        [TextId.PeerDisconnectedAllReady] = new()
        {
            [Language.English] = "{0} disconnected. All remaining players are ready. Use {1} to continue, or wait for reconnection.",
            [Language.ChineseSimplified] = "{0} 已掉线。剩余玩家均已就绪，可使用 {1} 继续流程，或等待其重连。",
            [Language.ChineseTraditional] = "{0} 已掉線。剩餘玩家均已就緒，可使用 {1} 繼續流程，或等待其重連。",
            [Language.Japanese] = "{0} が切断されました。残りのプレイヤーは全員準備完了です。{1} で続行するか、再接続を待ってください。",
            [Language.Korean] = "{0}의 연결이 끊겼습니다. 나머지 플레이어 모두 준비 완료. {1}로 계속하거나 재연결을 기다리세요.",
        },

        [TextId.PeerDisconnectedWaiting] = new()
        {
            [Language.English] = "{0} disconnected. Some players are still not ready. Wait for others or reconnection.",
            [Language.ChineseSimplified] = "{0} 已掉线。仍有玩家未就绪，请等待其他玩家或重连。",
            [Language.ChineseTraditional] = "{0} 已掉線。仍有玩家未就緒，請等待其他玩家或重連。",
            [Language.Japanese] = "{0} が切断されました。まだ準備ができていないプレイヤーがいます。他のプレイヤーか再接続を待ってください。",
            [Language.Korean] = "{0}의 연결이 끊겼습니다. 아직 준비되지 않은 플레이어가 있습니다. 다른 플레이어나 재연결을 기다리세요.",
        },

        [TextId.MpContinueHostOnly] = new()
        {
            [Language.English] = "Only the host can use /mp continue",
            [Language.ChineseSimplified] = "只有主机可以使用 /mp continue",
            [Language.ChineseTraditional] = "只有主機可以使用 /mp continue",
            [Language.Japanese] = "/mp continue はホストのみ使用できます",
            [Language.Korean] = "/mp continue는 호스트만 사용할 수 있습니다",
        },
        [TextId.MpKickHostOnly] = new()
        {
            [Language.English] = "Only the host can use /mp kick",
            [Language.ChineseSimplified] = "只有主机可以使用 /mp kick",
            [Language.ChineseTraditional] = "只有主機可以使用 /mp kick",
            [Language.Japanese] = "/mp kick はホストのみ使用できます",
            [Language.Korean] = "/mp kick은 호스트만 사용할 수 있습니다",
        },
        [TextId.MpKickNoTarget] = new()
        {
            [Language.English] = "No connected players to kick",
            [Language.ChineseSimplified] = "没有已连接的玩家可踢出",
            [Language.ChineseTraditional] = "沒有已連接的玩家可踢出",
            [Language.Japanese] = "キックできる接続中のプレイヤーがいません",
            [Language.Korean] = "추방할 연결된 플레이어가 없습니다",
        },
        [TextId.MpKickSelf] = new()
        {
            [Language.English] = "Cannot kick yourself",
            [Language.ChineseSimplified] = "不能踢出自己",
            [Language.ChineseTraditional] = "不能踢出自己",
            [Language.Japanese] = "自分をキックできません",
            [Language.Korean] = "자기 자신을 추방할 수 없습니다",
        },
        [TextId.MpKickNotFound] = new()
        {
            [Language.English] = "Player not found: {0}",
            [Language.ChineseSimplified] = "未找到玩家：{0}",
            [Language.ChineseTraditional] = "未找到玩家：{0}",
            [Language.Japanese] = "プレイヤーが見つかりません：{0}",
            [Language.Korean] = "플레이어를 찾을 수 없음: {0}",
        },
        [TextId.MpKickSuccess] = new()
        {
            [Language.English] = "Kicked player: {0} (uid={1})",
            [Language.ChineseSimplified] = "已踢出玩家：{0} (uid={1})",
            [Language.ChineseTraditional] = "已踢出玩家：{0} (uid={1})",
            [Language.Japanese] = "プレイヤーをキックしました：{0} (uid={1})",
            [Language.Korean] = "플레이어를 추방했습니다: {0} (uid={1})",
        },

        [TextId.MpContinueUsage] = new()
        {
            [Language.English] = "Usage: /mp continue <day|prep>",
            [Language.ChineseSimplified] = "用法：/mp continue <day|prep>",
            [Language.ChineseTraditional] = "用法：/mp continue <day|prep>",
            [Language.Japanese] = "使い方：/mp continue <day|prep>",
            [Language.Korean] = "사용법: /mp continue <day|prep>",
        },

        [TextId.MpContinueSuccess] = new()
        {
            [Language.English] = "Forced continue {0} successful",
            [Language.ChineseSimplified] = "已强制继续 {0} 流程",
            [Language.ChineseTraditional] = "已強制繼續 {0} 流程",
            [Language.Japanese] = "{0} を強制続行しました",
            [Language.Korean] = "{0} 강제 계속 성공",
        },

        [TextId.MpContinueFailed] = new()
        {
            [Language.English] = "Cannot continue {0} — check scene and ready state",
            [Language.ChineseSimplified] = "无法继续 {0} — 请检查当前场景和就绪状态",
            [Language.ChineseTraditional] = "無法繼續 {0} — 請檢查當前場景和就緒狀態",
            [Language.Japanese] = "{0} を続行できません — シーンと準備状態を確認してください",
            [Language.Korean] = "{0} 계속할 수 없음 — 장면과 준비 상태를 확인하세요",
        },

        [TextId.PrepWorkReconnectBlocked] = new()
        {
            [Language.English] = "Connection rejected: {0} cannot reconnect during prep/work phase",
            [Language.ChineseSimplified] = "连接被拒绝: 备菜/营业阶段不允许 {0} 重连",
            [Language.ChineseTraditional] = "連接被拒絕: 備菜/營業階段不允許 {0} 重連",
            [Language.Japanese] = "接続拒否: 準備/営業中は {0} の再接続不可",
            [Language.Korean] = "연결 거부: 준비/영업 중 {0} 재접속 불가",
        },

        [TextId.TodayBusinessHours] = new()
        {
            [Language.English] = "Your business hours tonight: {0} minutes",
            [Language.ChineseSimplified] = "你今晚的营业时间为 {0} 分钟",
            [Language.ChineseTraditional] = "你今晚的營業時間為 {0} 分鐘",
            [Language.Japanese] = "今夜の営業時間：{0} 分",
            [Language.Korean] = "오늘 밤 영업 시간: {0} 분",
        },

        [TextId.PeerAlreadyInScene] = new()
        {
            [Language.English] = "Some players are already in the business or preparation scene, cannot sync business establishment info. Please reconnect during daytime.",
            [Language.ChineseSimplified] = "有玩家已经处于营业或营业准备场景，无法同步营业场馆信息。请在白天重新联机。",
            [Language.ChineseTraditional] = "有玩家已經處於營業或營業準備場景，無法同步營業場館信息。請在白天重新聯機。",
            [Language.Japanese] = "一部のプレイヤーがすでに営業シーンまたは準備シーンにいます。営業施設情報を同期できません。昼間に再度接続してください。",
            [Language.Korean] = "일부 플레이어가 이미 영업 또는 준비 장면에 있습니다. 영업 시설 정보를 동기화할 수 없습니다. 낮에 다시 연결하세요.",
        },

        [TextId.SelectedIzakaya] = new()
        {
            [Language.English] = "You selected {0} as the business location",
            [Language.ChineseSimplified] = "你选择了 {0} 作为开店地点",
            [Language.ChineseTraditional] = "你選擇了 {0} 作為開店地點",
            [Language.Japanese] = "営業場所として {0} を選択しました",
            [Language.Korean] = "업소 위치로 {0}를 선택했습니다",
        },

        [TextId.SelectedIzakayaMismatch] = new()
        {
            [Language.English] = "You selected {0}, but not all players agree: {1}",
            [Language.ChineseSimplified] = "你选择了 {0}，但未全员一致：{1}",
            [Language.ChineseTraditional] = "你選擇了 {0}，但未全員一致：{1}",
            [Language.Japanese] = "{0} を選択しましたが、全員一致していません：{1}",
            [Language.Korean] = "{0}을 선택했지만 전원 일치하지 않습니다: {1}",
        },

        [TextId.WaitingForHostConfirm] = new()
        {
            [Language.English] = "Selected {0}, waiting for host to confirm...",
            [Language.ChineseSimplified] = "已选择 {0}，等待主机确认……",
            [Language.ChineseTraditional] = "已選擇 {0}，等待主機確認……",
            [Language.Japanese] = "{0} を選択しました。ホストの確認を待っています…",
            [Language.Korean] = "{0}을 선택했습니다. 호스트 확인 대기 중...",
        },

        [TextId.PeerSelectedIzakaya] = new()
        {
            [Language.English] = "{0} selected a business location: {1}",
            [Language.ChineseSimplified] = "{0} 选择了开店地点：{1}",
            [Language.ChineseTraditional] = "{0} 選擇了開店地點：{1}",
            [Language.Japanese] = "{0} が営業場所を選択しました：{1}",
            [Language.Korean] = "{0} 업소 위치를 선택했습니다: {1}",
        },

        [TextId.ChatMessagePeer] = new()
        {
            [Language.English] = "{0}: {1}",
            [Language.ChineseSimplified] = "{0}: {1}",
            [Language.ChineseTraditional] = "{0}: {1}",
            [Language.Japanese] = "{0}: {1}",
            [Language.Korean] = "{0}: {1}",
        },

        [TextId.ChatMessageSelf] = new()
        {
            [Language.English] = "You: {0}",
            [Language.ChineseSimplified] = "你: {0}",
            [Language.ChineseTraditional] = "你: {0}",
            [Language.Japanese] = "あなた: {0}",
            [Language.Korean] = "당신: {0}",
        },

        [TextId.PeerClosedIzakaya] = new()
        {
            [Language.English] = "{0} has closed their business!",
            [Language.ChineseSimplified] = "{0} 已经打烊啦！",
            [Language.ChineseTraditional] = "{0} 已經打烊啦！",
            [Language.Japanese] = "{0} は営業を終了しました！",
            [Language.Korean] = "{0}가 영업을 닫았습니다!",
        },

        [TextId.ModVersionUnavailable] = new()
        {
            [Language.English] = "Your Mod version is {0}, unable to fetch latest version information",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，无法获取最新版本信息",
            [Language.ChineseTraditional] = "您的 Mod 版本為 {0}，無法獲取最新版本信息",
            [Language.Japanese] = "Mod バージョンは {0} です。最新バージョン情報を取得できません",
            [Language.Korean] = "Mod 버전 {0}. 최신 버전 정보를 가져올 수 없습니다",
        },

        [TextId.ModVersionLatest] = new()
        {
            [Language.English] = "Your Mod version is {0}, you are using the latest version",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，您正在使用最新版",
            [Language.ChineseTraditional] = "您的 Mod 版本為 {0}，您正在使用最新版",
            [Language.Japanese] = "Mod バージョンは {0} です。最新バージョンを使用しています",
            [Language.Korean] = "Mod 버전 {0}. 최신 버전을 사용 중입니다",
        },

        [TextId.ModVersionOutdated] = new()
        {
            [Language.English] = "Your Mod version is {0}, latest version is {1}, recommend updating to the latest version!",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，最新版为 {1}，建议更新到最新版！",
            [Language.ChineseTraditional] = "您的 Mod 版本為 {0}，最新版為 {1}，建議更新到最新版！",
            [Language.Japanese] = "Mod バージョンは {0} です。最新バージョンは {1} です。最新バージョンに更新することをお勧めします！",
            [Language.Korean] = "Mod 버전 {0}. 최신 버전은 {1}입니다. 최신 버전으로 업데이트를 권장합니다!",
        },

        [TextId.SignatureVerificationDisabled] = new()
        {
            [Language.English] = "<color=yellow>Resource package signature verification disabled, ID range signatures will not be verified.</color>",
            [Language.ChineseSimplified] = "<color=yellow>资源包签名校验已关闭，ID 段签名将不会被验证。</color>",
            [Language.ChineseTraditional] = "<color=yellow>資源包簽名校驗已關閉，ID 段簽名將不會被驗證。</color>",
            [Language.Japanese] = "<color=yellow>リソースパッケージの署名検証が無効です。ID 範囲の署名は検証されません。</color>",
            [Language.Korean] = "<color=yellow>리소스 패키지 서명 검증이 비활성화됨. ID 범위 서명이 검증되지 않습니다.</color>",
        },

        [TextId.ResourcePackageValidationFailed] = new()
        {
            [Language.English] = "<color=red>Resource package {0} failed ID range validation, loading rejected.</color>",
            [Language.ChineseSimplified] = "<color=red>资源包 {0} 未通过 ID 范围验证，已拒绝加载。</color>",
            [Language.ChineseTraditional] = "<color=red>資源包 {0} 未通過 ID 範圍驗證，已拒絕加載。</color>",
            [Language.Japanese] = "<color=red>リソースパッケージ {0} は ID 範囲検証に失敗し、読み込みが拒否されました。</color>",
            [Language.Korean] = "<color=red>리소스 패키지 {0}가 ID 범위 검증에 실패하여 로드가 거부됨.</color>",
        },

        [TextId.ResourcePackageLoaded] = new()
        {
            [Language.English] = "Loaded resource package {0} [{1}] v{2}",
            [Language.ChineseSimplified] = "已加载资源包 {0} [{1}] v{2}",
            [Language.ChineseTraditional] = "已加載資源包 {0} [{1}] v{2}",
            [Language.Japanese] = "リソースパッケージ {0} [{1}] v{2} を読み込みました",
            [Language.Korean] = "리소스 패키지 {0} [{1}] v{2} 로드됨",
        },

        [TextId.PeerMessagePrefix] = new()
        {
            [Language.English] = "[{0}] {1}",
            [Language.ChineseSimplified] = "[{0}] {1}",
            [Language.ChineseTraditional] = "[{0}] {1}",
            [Language.Japanese] = "[{0}] {1}",
            [Language.Korean] = "[{0}] {1}",
        },

        [TextId.CommandPrompt] = new()
        {
            [Language.English] = "> {0}",
            [Language.ChineseSimplified] = "> {0}",
            [Language.ChineseTraditional] = "> {0}",
            [Language.Japanese] = "> {0}",
            [Language.Korean] = "> {0}",
        },

        [TextId.BepInExConsoleEnabled] = new()
        {
            [Language.English] = "BepinEX console enabled",
            [Language.ChineseSimplified] = "BepinEX 控制台已启用",
            [Language.ChineseTraditional] = "BepinEX 控制臺已啟用",
            [Language.Japanese] = "BepinEx コンソールを有効にしました",
            [Language.Korean] = "BepinEx 콘솔이 활성화되었습니다",
        },

        [TextId.NotInDayScene] = new()
        {
            [Language.English] = "⚠ Not in Day Scene. This command only works during daytime.",
            [Language.ChineseSimplified] = "⚠ 不在白天场景中。此命令仅在白天使用。",
            [Language.ChineseTraditional] = "⚠ 不在白天場景中。此命令仅在白天使用。",
            [Language.Japanese] = "⚠ 昻間シーンにいません。このコマンドは昻間中にのみ使用できます。",
            [Language.Korean] = "⚠ 뤱뾐의 쏱스에 없습니다. 이 명령은 뤱뾐 단진에만 사용 가능합니다.",
        },

        [TextId.MapInfoDisplay] = new()
        {
            [Language.English] = "label = {0}, position = {1}",
            [Language.ChineseSimplified] = "标签 = {0}，位置 = {1}",
            [Language.ChineseTraditional] = "標籤 = {0}，位置 = {1}",
            [Language.Japanese] = "ラベル = {0}、位置 = {1}",
            [Language.Korean] = "레이블 = {0}, 위치 = {1}",
        },

        [TextId.UnknownCommand] = new()
        {
            [Language.English] = "Unknown command: {0}. Type '/help' for available commands.",
            [Language.ChineseSimplified] = "未知命令：{0}。输入 '/help' 查看所有可用命令。",
            [Language.ChineseTraditional] = "未知命令：{0}。輸入 '/help' 查看所有可用命令。",
            [Language.Japanese] = "不明なコマンド: {0}。'/help' で利用可能なコマンドを表示します。",
            [Language.Korean] = "알 수 없는 명령: {0}. '/help'로 사용 가능한 명령을 보세요.",
        },

        [TextId.AvailableCommands] = new()
        {
            [Language.English] = "Available commands: /help, /clear, /get, /mp, /call, /skin, /debug, /webdebug, /enable_bepin_console, /whereami",
            [Language.ChineseSimplified] = "可用命令：/help、/clear、/get、/mp、/call、/skin、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.ChineseTraditional] = "可用命令：/help、/clear、/get、/mp、/call、/skin、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.Japanese] = "利用可能なコマンド：/help、/clear、/get、/mp、/call、/skin、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.Korean] = "사용 가능한 명령: /help, /clear, /get, /mp, /call, /skin, /debug, /webdebug, /enable_bepin_console, /whereami",
        },

        [TextId.GetUsage] = new()
        {
            [Language.English] = "Usage: get <field>",
            [Language.ChineseSimplified] = "用法：get <字段>",
            [Language.ChineseTraditional] = "用法：get <欄位>",
            [Language.Japanese] = "使用方法: get <フィールド>",
            [Language.Korean] = "사용법: get <필드>",
        },

        [TextId.AvailableFields] = new()
        {
            [Language.English] = "Available fields: {0}",
            [Language.ChineseSimplified] = "可用字段：{0}",
            [Language.ChineseTraditional] = "可用欄位：{0}",
            [Language.Japanese] = "利用可能なフィールド：{0}",
            [Language.Korean] = "사용 가능한 필드: {0}",
        },

        [TextId.CurrentMapLabel] = new()
        {
            [Language.English] = "Current Active Map Label: {0}",
            [Language.ChineseSimplified] = "当前活跃地图标签：{0}",
            [Language.ChineseTraditional] = "當前活躍地圖標籤：{0}",
            [Language.Japanese] = "現在のアクティブなマップラベル：{0}",
            [Language.Korean] = "현재 활성 맵 레이블: {0}",
        },

        [TextId.MystiaPosition] = new()
        {
            [Language.English] = "Mystia position: {0}",
            [Language.ChineseSimplified] = "Mystia的位置：{0}",
            [Language.ChineseTraditional] = "Mystia的位置：{0}",
            [Language.Japanese] = "Mystiaの位置：{0}",
            [Language.Korean] = "Mystia 위치: {0}",
        },

        [TextId.UnknownField] = new()
        {
            [Language.English] = "Unknown field: {0}",
            [Language.ChineseSimplified] = "未知字段：{0}",
            [Language.ChineseTraditional] = "未知欄位：{0}",
            [Language.Japanese] = "不明なフィールド：{0}",
            [Language.Korean] = "알 수 없는 필드: {0}",
        },

        [TextId.MessageSent] = new()
        {
            [Language.English] = "Sent {0}",
            [Language.ChineseSimplified] = "已发送 {0}",
            [Language.ChineseTraditional] = "已發送 {0}",
            [Language.Japanese] = "{0} を送信しました",
            [Language.Korean] = "{0}를 보냈습니다",
        },

        [TextId.CallUsage] = new()
        {
            [Language.English] = "Usage: /call <method> [args]",
            [Language.ChineseSimplified] = "用法：/call <方法> [参数]",
            [Language.ChineseTraditional] = "用法：/call <方法> [參數]",
            [Language.Japanese] = "使用方法: /call <メソッド> [引数]",
            [Language.Korean] = "사용법: /call <메소드> [인수]",
        },

        [TextId.AvailableMethods] = new()
        {
            [Language.English] = "Available methods: {0}",
            [Language.ChineseSimplified] = "可用方法：{0}",
            [Language.ChineseTraditional] = "可用方法：{0}",
            [Language.Japanese] = "利用可能なメソッド：{0}",
            [Language.Korean] = "사용 가능한 메소드: {0}",
        },

        [TextId.NPCListItem] = new()
        {
            [Language.English] = "- {0}",
            [Language.ChineseSimplified] = "- {0}",
            [Language.ChineseTraditional] = "- {0}",
            [Language.Japanese] = "- {0}",
            [Language.Korean] = "- {0}",
        },

        [TextId.TotalNPCsFound] = new()
        {
            [Language.English] = "Total NPCs found: {0}",
            [Language.ChineseSimplified] = "找到的NPC总数：{0}",
            [Language.ChineseTraditional] = "找到的NPC總數：{0}",
            [Language.Japanese] = "見つかったNPCの総数：{0}",
            [Language.Korean] = "발견된 NPC 총 개수: {0}",
        },

        [TextId.ErrorGetMapsnpcs] = new()
        {
            [Language.English] = "Error calling getmapsnpcs: {0}",
            [Language.ChineseSimplified] = "调用getmapsnpcs出错：{0}",
            [Language.ChineseTraditional] = "調用getmapsnpcs出錯：{0}",
            [Language.Japanese] = "getmapsnpcs呼び出しエラー：{0}",
            [Language.Korean] = "getmapsnpcs 호출 오류: {0}",
        },

        [TextId.MoveCharacterUsage] = new()
        {
            [Language.English] = "Usage: call movecharacter <characterKey> <mapLabel> <x> <y> <rot>",
            [Language.ChineseSimplified] = "用法：call movecharacter <角色键> <地图标签> <x> <y> <旋转>",
            [Language.ChineseTraditional] = "用法：call movecharacter <角色鍵> <地圖標籤> <x> <y> <旋轉>",
            [Language.Japanese] = "使用方法: call movecharacter <キャラクターキー> <マップラベル> <x> <y> <回転>",
            [Language.Korean] = "사용법: call movecharacter <캐릭터키> <맵레이블> <x> <y> <회전>",
        },

        [TextId.CharacterMoved] = new()
        {
            [Language.English] = "Moved character '{0}' to position ({1}, {2}) rotation {3} on map '{4}'.",
            [Language.ChineseSimplified] = "已将角色'{0}'移动到地图'{4}'上的位置({1}, {2})，旋转{3}。",
            [Language.ChineseTraditional] = "已將角色'{0}'移動到地圖'{4}'上的位置({1}, {2})，旋轉{3}。",
            [Language.Japanese] = "キャラクター '{0}' をマップ '{4}' の位置 ({1}, {2}) に移動し、回転 {3} に設定しました。",
            [Language.Korean] = "캐릭터 '{0}'를 맵 '{4}'의 위치 ({1}, {2})로 이동했으며, 회전은 {3}입니다.",
        },

        [TextId.ErrorMovecharacter] = new()
        {
            [Language.English] = "Error calling movecharacter: {0}",
            [Language.ChineseSimplified] = "调用movecharacter出错：{0}",
            [Language.ChineseTraditional] = "調用movecharacter出錯：{0}",
            [Language.Japanese] = "movecharacter呼び出しエラー：{0}",
            [Language.Korean] = "movecharacter 호출 오류: {0}",
        },

        [TextId.SceneMoveUsage] = new()
        {
            [Language.English] = "Usage: call scene_move <characterKey> <x> <y>",
            [Language.ChineseSimplified] = "用法：call scene_move <角色键> <x> <y>",
            [Language.ChineseTraditional] = "用法：call scene_move <角色鍵> <x> <y>",
            [Language.Japanese] = "使用方法: call scene_move <キャラクターキー> <x> <y>",
            [Language.Korean] = "사용법: call scene_move <캐릭터키> <x> <y>",
        },

        [TextId.CharacterMovedScene] = new()
        {
            [Language.English] = "Moved character '{0}' to position ({1}, {2}).",
            [Language.ChineseSimplified] = "已将角色'{0}'移动到位置({1}, {2})。",
            [Language.ChineseTraditional] = "已將角色'{0}'移動到位置({1}, {2})。",
            [Language.Japanese] = "キャラクター '{0}' を位置 ({1}, {2}) に移動しました。",
            [Language.Korean] = "캐릭터 '{0}'를 위치 ({1}, {2})로 이동했습니다.",
        },

        [TextId.ErrorSceneMove] = new()
        {
            [Language.English] = "Error calling scene_move: {0}",
            [Language.ChineseSimplified] = "调用scene_move出错：{0}",
            [Language.ChineseTraditional] = "調用scene_move出錯：{0}",
            [Language.Japanese] = "scene_move呼び出しエラー：{0}",
            [Language.Korean] = "scene_move 호출 오류: {0}",
        },

        [TextId.NotInWorkScene] = new()
        {
            [Language.English] = "⚠ Not in Work Scene. This command only works during business hours.",
            [Language.ChineseSimplified] = "⚠ 不在营业场景中。此命令仅在营业時間使用。",
            [Language.ChineseTraditional] = "⚠ 不在營業場景中。此命令仅在營業時間使用。",
            [Language.Japanese] = "⚠ 起業シーンにいません。このコマンドは起業時間中にのみ使用できます。",
            [Language.Korean] = "⚠ 업소 센에 없습니다. 이 명령은 업소 시간중에만 사용 가능합니다.",
        },

        [TextId.CalledTryCloseIzakaya] = new()
        {
            [Language.English] = "called try_close_izakaya",
            [Language.ChineseSimplified] = "已调用 try_close_izakaya",
            [Language.ChineseTraditional] = "已調用 try_close_izakaya",
            [Language.Japanese] = "try_close_izakaya を呼び出しました",
            [Language.Korean] = "try_close_izakaya를 호출했습니다",
        },

        [TextId.UnknownMethod] = new()
        {
            [Language.English] = "Unknown method: {0}",
            [Language.ChineseSimplified] = "未知方法：{0}",
            [Language.ChineseTraditional] = "未知方法：{0}",
            [Language.Japanese] = "不明なメソッド：{0}",
            [Language.Korean] = "알 수 없는 메소드: {0}",
        },

        [TextId.WebDebuggerUsage] = new()
        {
            [Language.English] = "Usage: /webdebug start <key>",
            [Language.ChineseSimplified] = "用法：/webdebug start <密钥>",
            [Language.ChineseTraditional] = "用法：/webdebug start <密鑰>",
            [Language.Japanese] = "使用方法: /webdebug start <キー>",
            [Language.Korean] = "사용법: /webdebug start <키>",
        },

        [TextId.InvalidWebDebuggerKey] = new()
        {
            [Language.English] = "Invalid key.",
            [Language.ChineseSimplified] = "无效的密钥。",
            [Language.ChineseTraditional] = "無效的密鑰。",
            [Language.Japanese] = "無効なキーです。",
            [Language.Korean] = "잘못된 키입니다.",
        },

        [TextId.WebDebuggerStarted] = new()
        {
            [Language.English] = "WebDebugger started.",
            [Language.ChineseSimplified] = "Web调试器已启动。",
            [Language.ChineseTraditional] = "Web調試器已啟動。",
            [Language.Japanese] = "Web デバッガーが起動しました。",
            [Language.Korean] = "웹 디버거가 시작되었습니다.",
        },

        [TextId.SkinUsage] = new()
        {
            [Language.English] = "Usage: /skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [index]\n  /skin set <npcName>\n  /skin list\n  /skin off",
            [Language.ChineseSimplified] = "用法：/skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [索引]\n  /skin set <NPC名>\n  /skin list\n  /skin off",
            [Language.ChineseTraditional] = "用法：/skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [索引]\n  /skin set <NPC名>\n  /skin list\n  /skin off",
            [Language.Japanese] = "使用方法: /skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [index]\n  /skin set <NPC名>\n  /skin list\n  /skin off",
            [Language.Korean] = "사용법: /skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [index]\n  /skin set <NPC名>\n  /skin list\n  /skin off",
        },

        [TextId.SkinEnabled] = new()
        {
            [Language.English] = "Skin override enabled: {0}",
            [Language.ChineseSimplified] = "皮肤覆盖已启用：{0}",
            [Language.ChineseTraditional] = "皮膚覆蓋已啟用：{0}",
            [Language.Japanese] = "スキンオーバーライド有効: {0}",
            [Language.Korean] = "스킨 오버라이드 활성화: {0}",
        },

        [TextId.SkinDisabled] = new()
        {
            [Language.English] = "Skin override disabled, restored to game default.",
            [Language.ChineseSimplified] = "皮肤覆盖已关闭，已恢复为游戏存档中的皮肤。",
            [Language.ChineseTraditional] = "皮膚覆蓋已關閉，已恢復為遊戲存檔中的皮膚。",
            [Language.Japanese] = "スキンオーバーライド無効化、ゲームデフォルトに復元。",
            [Language.Korean] = "스킨 오버라이드 비활성화, 게임 기본값으로 복원.",
        },

        [TextId.SkinAlreadyDisabled] = new()
        {
            [Language.English] = "Skin override is not enabled.",
            [Language.ChineseSimplified] = "皮肤覆盖当前未启用。",
            [Language.ChineseTraditional] = "皮膚覆蓋當前未啟用。",
            [Language.Japanese] = "スキンオーバーライドは有効ではありません。",
            [Language.Korean] = "스킨 오버라이드가 활성화되지 않았습니다.",
        },

        [TextId.SkinSetMystia] = new()
        {
            [Language.English] = "Set skin to Mystia {0} {1}",
            [Language.ChineseSimplified] = "已设置皮肤为 Mystia {0} {1}",
            [Language.ChineseTraditional] = "已設置皮膚為 Mystia {0} {1}",
            [Language.Japanese] = "スキンを Mystia {0} {1} に設定",
            [Language.Korean] = "스킨을 Mystia {0} {1}로 설정",
        },

        [TextId.SkinSetNpc] = new()
        {
            [Language.English] = "Set skin to NPC: {0}",
            [Language.ChineseSimplified] = "已设置皮肤为 NPC：{0}",
            [Language.ChineseTraditional] = "已設置皮膚為 NPC：{0}",
            [Language.Japanese] = "スキンを NPC: {0} に設定",
            [Language.Korean] = "스킨을 NPC: {0}로 설정",
        },

        [TextId.SkinInvalidType] = new()
        {
            [Language.English] = "Invalid skin type '{0}'. Use: Default, Explicit, DLC",
            [Language.ChineseSimplified] = "无效的皮肤类型 '{0}'。可选：Default、Explicit、DLC",
            [Language.ChineseTraditional] = "無效的皮膚類型 '{0}'。可選：Default、Explicit、DLC",
            [Language.Japanese] = "無効なスキンタイプ '{0}'。使用可能: Default, Explicit, DLC",
            [Language.Korean] = "잘못된 스킨 유형 '{0}'. 사용: Default, Explicit, DLC",
        },

        [TextId.SkinInvalidIndex] = new()
        {
            [Language.English] = "Invalid index '{0}' for type {1}.",
            [Language.ChineseSimplified] = "类型 {1} 的索引 '{0}' 无效。",
            [Language.ChineseTraditional] = "類型 {1} 的索引 '{0}' 無效。",
            [Language.Japanese] = "タイプ {1} のインデックス '{0}' が無効です。",
            [Language.Korean] = "유형 {1}의 인덱스 '{0}'이 유효하지 않습니다.",
        },

        [TextId.SkinNpcNotFound] = new()
        {
            [Language.English] = "NPC '{0}' not found in allNPCs.",
            [Language.ChineseSimplified] = "NPC '{0}' 在 allNPCs 中未找到。",
            [Language.ChineseTraditional] = "NPC '{0}' 在 allNPCs 中未找到。",
            [Language.Japanese] = "NPC '{0}' が allNPCs に見つかりません。",
            [Language.Korean] = "NPC '{0}'을 allNPCs에서 찾을 수 없습니다.",
        },

        [TextId.SkinListHeader] = new()
        {
            [Language.English] = "=== Mystia Skins ===",
            [Language.ChineseSimplified] = "=== Mystia 皮肤列表 ===",
            [Language.ChineseTraditional] = "=== Mystia 皮膚列表 ===",
            [Language.Japanese] = "=== Mystia スキン一覧 ===",
            [Language.Korean] = "=== Mystia 스킨 목록 ===",
        },

        [TextId.SkinListItem] = new()
        {
            [Language.English] = "  [{0}] {1} #{2}: {3}",
            [Language.ChineseSimplified] = "  [{0}] {1} #{2}：{3}",
            [Language.ChineseTraditional] = "  [{0}] {1} #{2}：{3}",
            [Language.Japanese] = "  [{0}] {1} #{2}: {3}",
            [Language.Korean] = "  [{0}] {1} #{2}: {3}",
        },

        [TextId.SkinListNpcHint] = new()
        {
            [Language.English] = "To use NPC skin: /skin set <npcName> (e.g. Kosuzu, Aunn, etc.)",
            [Language.ChineseSimplified] = "使用 NPC 皮肤：/skin set <NPC名>（如 Kosuzu、Aunn 等）",
            [Language.ChineseTraditional] = "使用 NPC 皮膚：/skin set <NPC名>（如 Kosuzu、Aunn 等）",
            [Language.Japanese] = "NPCスキンを使用: /skin set <NPC名>（例: Kosuzu, Aunn など）",
            [Language.Korean] = "NPC 스킨 사용: /skin set <NPC名> (예: Kosuzu, Aunn 등)",
        },

        [TextId.SkinStatus] = new()
        {
            [Language.English] = "Skin override: ON — {0}",
            [Language.ChineseSimplified] = "皮肤覆盖：已开启 — {0}",
            [Language.ChineseTraditional] = "皮膚覆蓋：已開啟 — {0}",
            [Language.Japanese] = "スキンオーバーライド: ON — {0}",
            [Language.Korean] = "스킨 오버라이드: 켜짐 — {0}",
        },

        [TextId.SkinStatusDisabled] = new()
        {
            [Language.English] = "Skin override: OFF",
            [Language.ChineseSimplified] = "皮肤覆盖：已关闭",
            [Language.ChineseTraditional] = "皮膚覆蓋：已關閉",
            [Language.Japanese] = "スキンオーバーライド: OFF",
            [Language.Korean] = "스킨 오버라이드: 꺼짐",
        },

        // Help & Command Descriptions
        [TextId.HelpHeader] = new()
        {
            [Language.English] = "Commands",
            [Language.ChineseSimplified] = "命令列表",
            [Language.ChineseTraditional] = "命令列表",
            [Language.Japanese] = "コマンド一覧",
            [Language.Korean] = "명령 목록",
        },
        [TextId.CmdDescHelp] = new()
        {
            [Language.English] = "Show this help",
            [Language.ChineseSimplified] = "显示帮助",
            [Language.ChineseTraditional] = "顯示幫助",
            [Language.Japanese] = "ヘルプを表示",
            [Language.Korean] = "도움말 표시",
        },
        [TextId.CmdDescClear] = new()
        {
            [Language.English] = "Clear console",
            [Language.ChineseSimplified] = "清空控制台",
            [Language.ChineseTraditional] = "清空控制台",
            [Language.Japanese] = "コンソールをクリア",
            [Language.Korean] = "콘솔 지우기",
        },
        [TextId.CmdDescGet] = new()
        {
            [Language.English] = "Query game state",
            [Language.ChineseSimplified] = "查询游戏状态",
            [Language.ChineseTraditional] = "查詢遊戲狀態",
            [Language.Japanese] = "ゲーム状態を照会",
            [Language.Korean] = "게임 상태 조회",
        },
        [TextId.CmdDescMp] = new()
        {
            [Language.English] = "Multiplayer commands",
            [Language.ChineseSimplified] = "联机命令",
            [Language.ChineseTraditional] = "聯機命令",
            [Language.Japanese] = "マルチプレイコマンド",
            [Language.Korean] = "멀티플레이 명령",
        },
        [TextId.CmdDescCall] = new()
        {
            [Language.English] = "Call game methods",
            [Language.ChineseSimplified] = "调用游戏方法",
            [Language.ChineseTraditional] = "調用遊戲方法",
            [Language.Japanese] = "ゲームメソッドを呼び出し",
            [Language.Korean] = "게임 메소드 호출",
        },
        [TextId.CmdDescSkin] = new()
        {
            [Language.English] = "Skin management",
            [Language.ChineseSimplified] = "皮肤管理",
            [Language.ChineseTraditional] = "皮膚管理",
            [Language.Japanese] = "スキン管理",
            [Language.Korean] = "스킨 관리",
        },
        [TextId.CmdDescDebug] = new()
        {
            [Language.English] = "Show MP debug info",
            [Language.ChineseSimplified] = "显示联机调试信息",
            [Language.ChineseTraditional] = "顯示聯機調試信息",
            [Language.Japanese] = "MP デバッグ情報を表示",
            [Language.Korean] = "MP 디버그 정보 표시",
        },
        [TextId.CmdDescWebdebug] = new()
        {
            [Language.English] = "Web debugger",
            [Language.ChineseSimplified] = "Web 调试器",
            [Language.ChineseTraditional] = "Web 調試器",
            [Language.Japanese] = "Web デバッガー",
            [Language.Korean] = "웹 디버거",
        },
        [TextId.CmdDescWhereami] = new()
        {
            [Language.English] = "Show map & position",
            [Language.ChineseSimplified] = "显示地图和位置",
            [Language.ChineseTraditional] = "顯示地圖和位置",
            [Language.Japanese] = "マップと位置を表示",
            [Language.Korean] = "맵과 위치 표시",
        },
        [TextId.CmdDescEnableBepinConsole] = new()
        {
            [Language.English] = "Enable BepInEx console",
            [Language.ChineseSimplified] = "启用 BepInEx 控制台",
            [Language.ChineseTraditional] = "啟用 BepInEx 控制台",
            [Language.Japanese] = "BepInEx コンソールを有効化",
            [Language.Korean] = "BepInEx 콘솔 활성화",
        },
        [TextId.MpHelpHeader] = new()
        {
            [Language.English] = "Multiplayer",
            [Language.ChineseSimplified] = "联机",
            [Language.ChineseTraditional] = "聯機",
            [Language.Japanese] = "マルチプレイ",
            [Language.Korean] = "멀티플레이",
        },
        [TextId.CallHelpHeader] = new()
        {
            [Language.English] = "Game Methods",
            [Language.ChineseSimplified] = "游戏方法",
            [Language.ChineseTraditional] = "遊戲方法",
            [Language.Japanese] = "ゲームメソッド",
            [Language.Korean] = "게임 메소드",
        },
        [TextId.SkinHelpHeader] = new()
        {
            [Language.English] = "Skin Management",
            [Language.ChineseSimplified] = "皮肤管理",
            [Language.ChineseTraditional] = "皮膚管理",
            [Language.Japanese] = "スキン管理",
            [Language.Korean] = "스킨 관리",
        },

        // ── mp subcommand descriptions ──
        [TextId.MpDescStart] = new()
        {
            [Language.English] = "Start multiplayer",
            [Language.ChineseSimplified] = "启动联机",
            [Language.ChineseTraditional] = "啟動聯機",
            [Language.Japanese] = "マルチプレイを開始",
            [Language.Korean] = "멀티플레이 시작",
        },
        [TextId.MpDescStop] = new()
        {
            [Language.English] = "Stop multiplayer",
            [Language.ChineseSimplified] = "停止联机",
            [Language.ChineseTraditional] = "停止聯機",
            [Language.Japanese] = "マルチプレイを停止",
            [Language.Korean] = "멀티플레이 중지",
        },
        [TextId.MpDescRestart] = new()
        {
            [Language.English] = "Restart multiplayer",
            [Language.ChineseSimplified] = "重启联机",
            [Language.ChineseTraditional] = "重啟聯機",
            [Language.Japanese] = "マルチプレイを再起動",
            [Language.Korean] = "멀티플레이 재시작",
        },
        [TextId.MpDescStatus] = new()
        {
            [Language.English] = "Show connection status",
            [Language.ChineseSimplified] = "查看连接状态",
            [Language.ChineseTraditional] = "查看連接狀態",
            [Language.Japanese] = "接続状態を表示",
            [Language.Korean] = "연결 상태 확인",
        },
        [TextId.MpDescId] = new()
        {
            [Language.English] = "Set player ID",
            [Language.ChineseSimplified] = "设置玩家 ID",
            [Language.ChineseTraditional] = "設置玩家 ID",
            [Language.Japanese] = "プレイヤーIDを設定",
            [Language.Korean] = "플레이어 ID 설정",
        },
        [TextId.MpDescConnect] = new()
        {
            [Language.English] = "Connect to host",
            [Language.ChineseSimplified] = "连接到主机",
            [Language.ChineseTraditional] = "連接到主機",
            [Language.Japanese] = "ホストに接続",
            [Language.Korean] = "호스트에 연결",
        },
        [TextId.MpDescDisconnect] = new()
        {
            [Language.English] = "Disconnect",
            [Language.ChineseSimplified] = "断开连接",
            [Language.ChineseTraditional] = "斷開連接",
            [Language.Japanese] = "切断",
            [Language.Korean] = "연결 해제",
        },
        [TextId.MpDescKick] = new()
        {
            [Language.English] = "Kick a player (host)",
            [Language.ChineseSimplified] = "踢出玩家 (主机)",
            [Language.ChineseTraditional] = "踢出玩家 (主機)",
            [Language.Japanese] = "プレイヤーをキック (ホスト)",
            [Language.Korean] = "플레이어 추방 (호스트)",
        },
        [TextId.MpDescKickId] = new()
        {
            [Language.English] = "Kick by player name",
            [Language.ChineseSimplified] = "按玩家名踢出",
            [Language.ChineseTraditional] = "按玩家名踢出",
            [Language.Japanese] = "プレイヤー名でキック",
            [Language.Korean] = "플레이어 이름으로 추방",
        },
        [TextId.MpDescKickUid] = new()
        {
            [Language.English] = "Kick by UID",
            [Language.ChineseSimplified] = "按 UID 踢出",
            [Language.ChineseTraditional] = "按 UID 踢出",
            [Language.Japanese] = "UIDでキック",
            [Language.Korean] = "UID로 추방",
        },
        [TextId.MpDescContinue] = new()
        {
            [Language.English] = "Force continue (host)",
            [Language.ChineseSimplified] = "强制继续 (主机)",
            [Language.ChineseTraditional] = "強制繼續 (主機)",
            [Language.Japanese] = "強制続行 (ホスト)",
            [Language.Korean] = "강제 계속 (호스트)",
        },

        // ── call subcommand descriptions ──
        [TextId.CallDescGetmapsnpcs] = new()
        {
            [Language.English] = "List NPCs on map",
            [Language.ChineseSimplified] = "列出地图上的 NPC",
            [Language.ChineseTraditional] = "列出地圖上的 NPC",
            [Language.Japanese] = "マップ上のNPCを一覧表示",
            [Language.Korean] = "맵의 NPC 목록",
        },
        [TextId.CallDescMovecharacter] = new()
        {
            [Language.English] = "Move character",
            [Language.ChineseSimplified] = "移动角色",
            [Language.ChineseTraditional] = "移動角色",
            [Language.Japanese] = "キャラクターを移動",
            [Language.Korean] = "캐릭터 이동",
        },
        [TextId.CallDescSceneMove] = new()
        {
            [Language.English] = "Move to scene",
            [Language.ChineseSimplified] = "移动到场景",
            [Language.ChineseTraditional] = "移動到場景",
            [Language.Japanese] = "シーンに移動",
            [Language.Korean] = "씬으로 이동",
        },
        [TextId.CallDescTryCloseIzakaya] = new()
        {
            [Language.English] = "Try close izakaya",
            [Language.ChineseSimplified] = "尝试关闭居酒屋",
            [Language.ChineseTraditional] = "嘗試關閉居酒屋",
            [Language.Japanese] = "居酒屋を閉店する",
            [Language.Korean] = "이자카야 닫기 시도",
        },

        // ── skin subcommand descriptions ──
        [TextId.SkinDescSet] = new()
        {
            [Language.English] = "Set character skin",
            [Language.ChineseSimplified] = "设置角色皮肤",
            [Language.ChineseTraditional] = "設置角色皮膚",
            [Language.Japanese] = "キャラスキンを設定",
            [Language.Korean] = "캐릭터 스킨 설정",
        },
        [TextId.SkinDescOff] = new()
        {
            [Language.English] = "Reset skin to default",
            [Language.ChineseSimplified] = "恢复默认皮肤",
            [Language.ChineseTraditional] = "恢復默認皮膚",
            [Language.Japanese] = "スキンをデフォルトに",
            [Language.Korean] = "스킨 초기화",
        },
        [TextId.SkinDescList] = new()
        {
            [Language.English] = "List available skins",
            [Language.ChineseSimplified] = "列出可用皮肤",
            [Language.ChineseTraditional] = "列出可用皮膚",
            [Language.Japanese] = "利用可能なスキンを一覧",
            [Language.Korean] = "사용 가능한 스킨 목록",
        },

        // ── Console startup & link ──
        [TextId.ConsoleStarPrompt] = new()
        {
            [Language.English] = "Welcome to MetaMystia! If you enjoy it, please star us: /link MetaMystia",
            [Language.ChineseSimplified] = "欢迎使用 MetaMystia mod！如果喜欢，请给项目点个 Star：/link MetaMystia",
            [Language.ChineseTraditional] = "歡迎使用 MetaMystia mod！如果喜歡，請給專案點個 Star：/link MetaMystia",
            [Language.Japanese] = "MetaMystia mod へようこそ！気に入ったらStarをお願いします：/link MetaMystia",
            [Language.Korean] = "MetaMystia mod에 오신 것을 환영합니다! 마음에 드시면 Star를 눌러주세요: /link MetaMystia",
        },
        [TextId.ConsoleHelpHint] = new()
        {
            [Language.English] = "Type /help for commands. Tab to auto-complete.",
            [Language.ChineseSimplified] = "输入 /help 查看命令列表，Tab 自动补全。",
            [Language.ChineseTraditional] = "輸入 /help 查看命令列表，Tab 自動補全。",
            [Language.Japanese] = "/help でコマンド一覧、Tab で自動補完。",
            [Language.Korean] = "/help 로 명령어 목록, Tab 으로 자동완성.",
        },
        [TextId.CmdDescLink] = new()
        {
            [Language.English] = "Open project links",
            [Language.ChineseSimplified] = "打开项目链接",
            [Language.ChineseTraditional] = "打開專案連結",
            [Language.Japanese] = "プロジェクトリンクを開く",
            [Language.Korean] = "프로젝트 링크 열기",
        },
        [TextId.LinkDescMetaMystia] = new()
        {
            [Language.English] = "MetaMystia GitHub",
            [Language.ChineseSimplified] = "MetaMystia GitHub 仓库",
            [Language.ChineseTraditional] = "MetaMystia GitHub 倉庫",
            [Language.Japanese] = "MetaMystia GitHub リポジトリ",
            [Language.Korean] = "MetaMystia GitHub 저장소",
        },
        [TextId.LinkDescIzakaya] = new()
        {
            [Language.English] = "touhou mystia izakaya assistant",
            [Language.ChineseSimplified] = "东方夜雀食堂小助手",
            [Language.ChineseTraditional] = "東方夜雀食堂小助手",
            [Language.Japanese] = "touhou mystia izakaya assistant",
            [Language.Korean] = "touhou mystia izakaya assistant",
        },

        // ── ResourceEx Console Messages ──

        [TextId.ResourceExConsoleLoaded] = new()
        {
            [Language.English] = "✓ ResourceEx: {0} v{1} by {2}",
            [Language.ChineseSimplified] = "✓ 资源包: {0} v{1} 作者: {2}",
            [Language.ChineseTraditional] = "✓ 資源包: {0} v{1} 作者: {2}",
            [Language.Japanese] = "✓ リソースパック: {0} v{1} 作者: {2}",
            [Language.Korean] = "✓ 리소스 팩: {0} v{1} 저자: {2}",
        },
        [TextId.ResourceExConsoleLoadedNoInfo] = new()
        {
            [Language.English] = "✓ ResourceEx: {0} (no pack info)",
            [Language.ChineseSimplified] = "✓ 资源包: {0}（无包信息）",
            [Language.ChineseTraditional] = "✓ 資源包: {0}（無包信息）",
            [Language.Japanese] = "✓ リソースパック: {0}（パック情報なし）",
            [Language.Korean] = "✓ 리소스 팩: {0} (팩 정보 없음)",
        },
        [TextId.ResourceExConsoleRejected] = new()
        {
            [Language.English] = "✗ ResourceEx: {0} rejected — {1}",
            [Language.ChineseSimplified] = "✗ 资源包: {0} 已拒绝 — {1}",
            [Language.ChineseTraditional] = "✗ 資源包: {0} 已拒絕 — {1}",
            [Language.Japanese] = "✗ リソースパック: {0} 拒否 — {1}",
            [Language.Korean] = "✗ 리소스 팩: {0} 거부됨 — {1}",
        },
        [TextId.CmdDescResourceEx] = new()
        {
            [Language.English] = "Resource pack management",
            [Language.ChineseSimplified] = "资源包管理",
            [Language.ChineseTraditional] = "資源包管理",
            [Language.Japanese] = "リソースパック管理",
            [Language.Korean] = "리소스 팩 관리",
        },
        [TextId.ResourceExHelpHeader] = new()
        {
            [Language.English] = "ResourceEx Commands",
            [Language.ChineseSimplified] = "ResourceEx 命令",
            [Language.ChineseTraditional] = "ResourceEx 命令",
            [Language.Japanese] = "ResourceEx コマンド",
            [Language.Korean] = "ResourceEx 명령",
        },
        [TextId.ResourceExDescList] = new()
        {
            [Language.English] = "List all loaded resource packs",
            [Language.ChineseSimplified] = "列出所有已加载的资源包",
            [Language.ChineseTraditional] = "列出所有已加載的資源包",
            [Language.Japanese] = "すべてのリソースパックを一覧表示",
            [Language.Korean] = "로드된 모든 리소스 팩 목록",
        },
        [TextId.ResourceExDescInfo] = new()
        {
            [Language.English] = "Show details of a resource pack",
            [Language.ChineseSimplified] = "显示资源包详细信息",
            [Language.ChineseTraditional] = "顯示資源包詳細信息",
            [Language.Japanese] = "リソースパックの詳細を表示",
            [Language.Korean] = "리소스 팩 세부 정보 표시",
        },
        [TextId.ResourceExListHeader] = new()
        {
            [Language.English] = "Loaded Resource Packs ({0})",
            [Language.ChineseSimplified] = "已加载资源包 ({0})",
            [Language.ChineseTraditional] = "已加載資源包 ({0})",
            [Language.Japanese] = "読み込み済みリソースパック ({0})",
            [Language.Korean] = "로드된 리소스 팩 ({0})",
        },
        [TextId.ResourceExListItem] = new()
        {
            [Language.English] = "{0} v{1} by {2}",
            [Language.ChineseSimplified] = "{0} v{1} 作者: {2}",
            [Language.ChineseTraditional] = "{0} v{1} 作者: {2}",
            [Language.Japanese] = "{0} v{1} 作者: {2}",
            [Language.Korean] = "{0} v{1} 저자: {2}",
        },
        [TextId.ResourceExListEmpty] = new()
        {
            [Language.English] = "No resource packs loaded.",
            [Language.ChineseSimplified] = "未加载任何资源包。",
            [Language.ChineseTraditional] = "未加載任何資源包。",
            [Language.Japanese] = "リソースパックが読み込まれていません。",
            [Language.Korean] = "로드된 리소스 팩이 없습니다.",
        },
        [TextId.ResourceExInfoHeader] = new()
        {
            [Language.English] = "Resource Pack Info",
            [Language.ChineseSimplified] = "资源包信息",
            [Language.ChineseTraditional] = "資源包信息",
            [Language.Japanese] = "リソースパック情報",
            [Language.Korean] = "리소스 팩 정보",
        },
        [TextId.ResourceExInfoName] = new()
        {
            [Language.English] = "Name: {0}",
            [Language.ChineseSimplified] = "名称: {0}",
            [Language.ChineseTraditional] = "名稱: {0}",
            [Language.Japanese] = "名前: {0}",
            [Language.Korean] = "이름: {0}",
        },
        [TextId.ResourceExInfoLabel] = new()
        {
            [Language.English] = "Label: {0}",
            [Language.ChineseSimplified] = "标签: {0}",
            [Language.ChineseTraditional] = "標籤: {0}",
            [Language.Japanese] = "ラベル: {0}",
            [Language.Korean] = "라벨: {0}",
        },
        [TextId.ResourceExInfoVersion] = new()
        {
            [Language.English] = "Version: {0}",
            [Language.ChineseSimplified] = "版本: {0}",
            [Language.ChineseTraditional] = "版本: {0}",
            [Language.Japanese] = "バージョン: {0}",
            [Language.Korean] = "버전: {0}",
        },
        [TextId.ResourceExInfoAuthors] = new()
        {
            [Language.English] = "Authors: {0}",
            [Language.ChineseSimplified] = "作者: {0}",
            [Language.ChineseTraditional] = "作者: {0}",
            [Language.Japanese] = "作者: {0}",
            [Language.Korean] = "저자: {0}",
        },
        [TextId.ResourceExInfoDescription] = new()
        {
            [Language.English] = "Description: {0}",
            [Language.ChineseSimplified] = "描述: {0}",
            [Language.ChineseTraditional] = "描述: {0}",
            [Language.Japanese] = "説明: {0}",
            [Language.Korean] = "설명: {0}",
        },
        [TextId.ResourceExInfoLicense] = new()
        {
            [Language.English] = "License: {0}",
            [Language.ChineseSimplified] = "许可证: {0}",
            [Language.ChineseTraditional] = "許可證: {0}",
            [Language.Japanese] = "ライセンス: {0}",
            [Language.Korean] = "라이선스: {0}",
        },
        [TextId.ResourceExInfoIdRange] = new()
        {
            [Language.English] = "ID Range: {0} – {1}",
            [Language.ChineseSimplified] = "ID 范围: {0} – {1}",
            [Language.ChineseTraditional] = "ID 範圍: {0} – {1}",
            [Language.Japanese] = "ID 範囲: {0} – {1}",
            [Language.Korean] = "ID 범위: {0} – {1}",
        },
        [TextId.ResourceExInfoContents] = new()
        {
            [Language.English] = "Contents: {0}",
            [Language.ChineseSimplified] = "内容: {0}",
            [Language.ChineseTraditional] = "內容: {0}",
            [Language.Japanese] = "内容: {0}",
            [Language.Korean] = "내용: {0}",
        },
        [TextId.ResourceExInfoNotFound] = new()
        {
            [Language.English] = "Resource pack '{0}' not found.",
            [Language.ChineseSimplified] = "未找到资源包 '{0}'。",
            [Language.ChineseTraditional] = "未找到資源包 '{0}'。",
            [Language.Japanese] = "リソースパック '{0}' が見つかりません。",
            [Language.Korean] = "리소스 팩 '{0}'을(를) 찾을 수 없습니다.",
        },
        [TextId.ResourceExRejectedHeader] = new()
        {
            [Language.English] = "Rejected Resource Packs ({0})",
            [Language.ChineseSimplified] = "被拒绝的资源包 ({0})",
            [Language.ChineseTraditional] = "被拒絕的資源包 ({0})",
            [Language.Japanese] = "拒否されたリソースパック ({0})",
            [Language.Korean] = "거부된 리소스 팩 ({0})",
        },
        [TextId.ResourceExRejectedItem] = new()
        {
            [Language.English] = "{0} — {1}",
            [Language.ChineseSimplified] = "{0} — {1}",
            [Language.ChineseTraditional] = "{0} — {1}",
            [Language.Japanese] = "{0} — {1}",
            [Language.Korean] = "{0} — {1}",
        },
    };


    public static void PostInitializeTable()
    {
        // Table[TextId.MystiaReadyForWork] = new()
        // {
        //     [Language.English] = TextId.ReadyForWork.Get("You"),
        //     [Language.ChineseSimplified] = TextId.ReadyForWork.Get("你"),
        // };
        PostInitialized = true;
    }

    public static string Get(this TextId key, params object[] args)
    {
        if (!Table.TryGetValue(key, out var langMap))
            return $"[L10N_MISSING:{key}]";

        if (!langMap.TryGetValue(Language, out var text))
            text = langMap.GetValueOrDefault(Language.English);

        return args.Length > 0
            ? string.Format(text, args)
            : text;
    }

    public static Language GetLanguage(this GameData.MultiLanguageTextMesh.LoadLanguageType loadLanguageType) => loadLanguageType switch
    {
        GameData.MultiLanguageTextMesh.LoadLanguageType.Chinese => Language.ChineseSimplified,
        GameData.MultiLanguageTextMesh.LoadLanguageType.English => Language.English,
        GameData.MultiLanguageTextMesh.LoadLanguageType.Japanese => Language.Japanese,
        GameData.MultiLanguageTextMesh.LoadLanguageType.Korean => Language.Korean,
        GameData.MultiLanguageTextMesh.LoadLanguageType.CNT => Language.ChineseTraditional,
        _ => throw new NotImplementedException(),
    };

    public static Language Language
    {
        get
        {
            return PostInitialized ? Common.UI.EscapeUtility.EscConfigPannel.CurrentSettings.CurrentLanguage.GetLanguage() : Language.English;
        }
    }
    private static bool PostInitialized = false;
}


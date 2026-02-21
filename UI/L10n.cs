using System;
using System.Collections.Generic;

namespace MetaMystia;

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
    ChallengeWarning,

    // Business/Shop Related
    TodayBusinessHours,
    PeerAlreadyInScene,
    SelectedIzakaya,
    SelectedIzakayaMismatch,
    PeerSelectedIzakaya,
    MystiaReadyForWork,
    ReadyForWork,
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
            [Language.English] = "One or more players have not installed the DLC that contains the food item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食物 {0} 的 DLC",
            [Language.ChineseTraditional] = "有玩家未裝載有此食物 {0} 的 DLC",
            [Language.Japanese] = "食材 {0} を含む DLC がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "식재료 {0}를 포함한 DLC를 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.DLCPeerBeverageNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC that contains the beverage item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此酒水 {0} 的 DLC",
            [Language.ChineseTraditional] = "有玩家未裝載有此酒水 {0} 的 DLC",
            [Language.Japanese] = "饮率 {0} を含む DLC がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "음료 {0}를 포함한 DLC를 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.DLCPeerRecipeNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC that contains the recipe item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食谱 {0} 的 DLC",
            [Language.ChineseTraditional] = "有玩家未裝載有此食譜 {0} 的 DLC",
            [Language.Japanese] = "レシピ {0} を含む DLC がインストールされていないプレイヤーがいます。",
            [Language.Korean] = "레시피 {0}를 포함한 DLC를 설치하지 않은 플레이어가 있습니다.",
        },

        [TextId.ReadyForWork] = new()
        {
            [Language.English] = "{0} are ready to open for business.",
            [Language.ChineseSimplified] = "{0} 已经准备好营业啦",
            [Language.ChineseTraditional] = "{0} 已經準備好營業啦",
            [Language.Japanese] = "{0} は営業を開始する準備ができました。",
            [Language.Korean] = "{0}이(ga) 영업을 시작할 준비가 되었습니다.",
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
            [Language.English] = "One or more players not in daytime or main menu, connection disconnected",
            [Language.ChineseSimplified] = "有玩家不处于白天或主界面，连接已断开",
            [Language.ChineseTraditional] = "有玩家不處於白天或主界面，連接已斷開",
            [Language.Japanese] = "1人以上のプレイヤーが昼間またはメインメニューにいません。接続を切断しました",
            [Language.Korean] = "하나 이상의 플레이어가 낮 또는 메인 메뉴에 없음, 연결 끊김",
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

        [TextId.ChallengeWarning] = new()
        {
            [Language.English] = "Possibly in a challenge, recommend disconnecting for better game experience!",
            [Language.ChineseSimplified] = "检测到可能在进行挑战，建议断开连接确保游戏体验!",
            [Language.ChineseTraditional] = "檢測到可能在進行挑戰，建議斷開連接確保遊戲體驗!",
            [Language.Japanese] = "チャレンジ中の可能性があります。より良いゲーム体験のため、接続を切断することをお勧めします！",
            [Language.Korean] = "도전 중일 가능성, 더 나은 게임 체험을 위해 연결 끊김 권장!",
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
            [Language.English] = "The other player is already in the business or preparation scene, cannot sync business establishment info. Please reconnect during daytime.",
            [Language.ChineseSimplified] = "对方已经处于营业或营业准备场景，无法同步营业场馆信息。请在白天重新联机。",
            [Language.ChineseTraditional] = "對方已經處於營業或營業準備場景，無法同步營業場館信息。請在白天重新聯機。",
            [Language.Japanese] = "相手プレイヤーがすでに営業シーンまたは準備シーンにいます。営業施設情報を同期できません。昼間に再度接続してください。",
            [Language.Korean] = "다른 플레이어가 이미 영업 또는 준비 장면에 있음. 영업 시설 정보를 동기화할 수 없습니다. 낮에 다시 연결하세요.",
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
            [Language.English] = "You selected {0} as the business location, but the other player selected {1}, you must choose the same one",
            [Language.ChineseSimplified] = "你选择了 {0} 作为开店地点，对方选择了 {1}，你俩得选一样的",
            [Language.ChineseTraditional] = "你選擇了 {0} 作為開店地點，對方選擇了 {1}，你倆得選一樣的",
            [Language.Japanese] = "営業場所として {0} を選択しましたが、相手プレイヤーは {1} を選択しました。同じ場所を選ぶ必要があります",
            [Language.Korean] = "업소 위치로 {0}를 선택했지만 다른 플레이어는 {1}를 선택했습니다. 같은 위치를 선택해야 합니다",
        },

        [TextId.PeerSelectedIzakaya] = new()
        {
            [Language.English] = "The other player selected {0} as the business location",
            [Language.ChineseSimplified] = "对方选择了 {0} 作为开店地点",
            [Language.ChineseTraditional] = "對方選擇了 {0} 作為開店地點",
            [Language.Japanese] = "相手プレイヤーが営業場所として {0} を選択しました",
            [Language.Korean] = "다른 플레이어가 업소 위치로 {0}를 선택했습니다",
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
            [Language.English] = "[Peer] {0}",
            [Language.ChineseSimplified] = "[对方] {0}",
            [Language.ChineseTraditional] = "[對方] {0}",
            [Language.Japanese] = "[ピア] {0}",
            [Language.Korean] = "[상대방] {0}",
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
            [Language.English] = "Available commands: /help, /clear, /get, /mp, /call, /debug, /webdebug, /enable_bepin_console, /whereami",
            [Language.ChineseSimplified] = "可用命令：/help、/clear、/get、/mp、/call、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.ChineseTraditional] = "可用命令：/help、/clear、/get、/mp、/call、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.Japanese] = "利用可能なコマンド：/help、/clear、/get、/mp、/call、/debug、/webdebug、/enable_bepin_console、/whereami",
            [Language.Korean] = "사용 가능한 명령: /help, /clear, /get, /mp, /call, /debug, /webdebug, /enable_bepin_console, /whereami",
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
            [Language.ChineseSimplified] = "魔理沙的位置：{0}",
            [Language.ChineseTraditional] = "魔理沙的位置：{0}",
            [Language.Japanese] = "ミスティアの位置：{0}",
            [Language.Korean] = "미스티아 위치: {0}",
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
        }
    };


    public static void PostInitializeTable()
    {
        Table[TextId.MystiaReadyForWork] = new()
        {
            [Language.English] = TextId.ReadyForWork.Get("You"),
            [Language.ChineseSimplified] = TextId.ReadyForWork.Get("你"),
        };
    }

    public static string Get(this TextId key, params object[] args)
    {
        if (!Table.TryGetValue(key, out var langMap))
            return $"[L10N_MISSING:{key}]";

        if (!langMap.TryGetValue(MpManager.Language, out var text))
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
}


using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace MetaMystia.UI;

public enum Language
{
    ChineseSimplified,
    English,
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

    // Max Players / Reject
    RoomFull,
    RoomFullHostNotify,
    MpMaxPlayersCurrent,
    MpMaxPlayersSet,
    MpMaxPlayersHostOnly,
    MpMaxPlayersRange,
    MpDescMaxPlayers,
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
        },

        [TextId.ConnectCommandConnected] = new()
        {
            [Language.English] = "Successfully connected to {0}",
            [Language.ChineseSimplified] = "成功连接到 {0}",
        },

        [TextId.ConnectCommandFail] = new()
        {
            [Language.English] = "Failed to connect to {0}",
            [Language.ChineseSimplified] = "连接到 {0} 失败！",
        },

        [TextId.MpUsageHelp] = new()
        {
            [Language.English] = "Usage: /mp start server  |  /mp start client",
            [Language.ChineseSimplified] = "用法：/mp start server（主机）或 /mp start client（客户端）",
        },

        [TextId.MpAlreadyStarted] = new()
        {
            [Language.English] = "Multiplayer is already running as {0}",
            [Language.ChineseSimplified] = "联机系统已在运行（角色：{0}）",
        },

        [TextId.MpStartedAsHost] = new()
        {
            [Language.English] = "Multiplayer started as Host ✓",
            [Language.ChineseSimplified] = "已启动为主机 ✓",
        },

        [TextId.MpStartedAsClient] = new()
        {
            [Language.English] = "Multiplayer started as Client ✓",
            [Language.ChineseSimplified] = "已启动为客户端 ✓",
        },

        [TextId.MpStopped] = new()
        {
            [Language.English] = "Multiplayer stopped ✕",
            [Language.ChineseSimplified] = "已停止联机 ✕",
        },

        [TextId.MpRestarted] = new()
        {
            [Language.English] = "Multiplayer restarted ↻",
            [Language.ChineseSimplified] = "已重启联机 ↻",
        },

        [TextId.MpSubcommandHelp] = new()
        {
            [Language.English] = "Subcommands: start, stop, restart, status, id, connect, disconnect",
            [Language.ChineseSimplified] = "子命令：start、stop、restart、status、id、connect、disconnect",
        },

        [TextId.MpUsageRoot] = new()
        {
            [Language.English] = "Usage: /mp <subcommand> [args]",
            [Language.ChineseSimplified] = "用法：/mp <子命令> [参数] （不要尖括号和方括号哦）",
        },

        [TextId.MpUsageSetId] = new()
        {
            [Language.English] = "Usage: /mp id <new_id>",
            [Language.ChineseSimplified] = "用法：/mp id <新ID> （不要尖括号哦）",
        },
        [TextId.MpPlayerIdSet] = new()
        {
            [Language.English] = "Player ID set to {0}",
            [Language.ChineseSimplified] = "玩家 ID 已设置为 {0}",
        },
        [TextId.PeerPlayerIdChanged] = new()
        {
            [Language.English] = "Player changed their ID: {0} -> {1}",
            [Language.ChineseSimplified] = "玩家已更改 ID：{0} -> {1}",
        },

        [TextId.MpNoActiveConnection] = new()
        {
            [Language.English] = "No active multiplayer connection",
            [Language.ChineseSimplified] = "当前没有活动的网络连接",
        },

        [TextId.MpConnecting] = new()
        {
            [Language.English] = "Connecting to {0}:{1}...",
            [Language.ChineseSimplified] = "正在连接到 {0}:{1}...",
        },

        [TextId.MpDisconnected] = new()
        {
            [Language.English] = "Disconnected",
            [Language.ChineseSimplified] = "已断开连接",
        },

        [TextId.MpUnknownSubcommand] = new()
        {
            [Language.English] = "Unknown subcommand: {0}",
            [Language.ChineseSimplified] = "未知的子命令：{0}",
        },

        [TextId.DLCPeerFoodNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the food item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食物 {0} 的 DLC 或资源包",
        },

        [TextId.DLCPeerBeverageNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the beverage item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此酒水 {0} 的 DLC 或资源包",
        },

        [TextId.DLCPeerRecipeNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the recipe item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食谱 {0} 的 DLC 或资源包",
        },
        [TextId.DLCPeerCookerNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC or resource pack that contains the cooker item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此厨具 {0} 的 DLC 或资源包",
        },

        [TextId.ReadyForWork] = new()
        {
            [Language.English] = "{0} are ready to open for business.",
            [Language.ChineseSimplified] = "{0} 已经准备好营业啦",
        },

        [TextId.MystiaReadyForWork] = new()
        {
            [Language.English] = "You are ready to open for business.",
            [Language.ChineseSimplified] = "你已经准备好营业啦",
        },

        [TextId.AllReadyTransition] = new()
        {
            [Language.English] = "All players are ready, transitioning...",
            [Language.ChineseSimplified] = "全员就绪，即将切换场景…",
        },

        [TextId.ModPatchFailure] = new()
        {
            [Language.English] = "Patch failure! The Mod will not function normally! Maybe your game version is not supported, please consider removing the mod!",
            [Language.ChineseSimplified] = "补丁注入失败！此Mod将不会正常运行！可能是你的游戏版本不受支持？请考虑移除此Mod进行游玩！",
        },

        [TextId.ModVersionMismatch] = new()
        {
            [Language.English] = "Mod version mismatch, connection disconnected!",
            [Language.ChineseSimplified] = "Mod 版本不匹配，连接已断开！",
        },

        [TextId.GameVersionMismatch] = new()
        {
            [Language.English] = "Game version mismatch, connection disconnected!",
            [Language.ChineseSimplified] = "游戏版本不匹配，连接已断开！",
        },

        [TextId.SceneMismatchDisconnected] = new()
        {
            [Language.English] = "One or more players are not in the DayScene or MainScene at the same time, connection disconnected!",
            [Language.ChineseSimplified] = "有玩家不同处于白天或主界面，连接已断开",
        },

        [TextId.MultiplayerConnected] = new()
        {
            [Language.English] = "Multiplayer system: Connected!",
            [Language.ChineseSimplified] = "联机系统：已连接！",
        },

        [TextId.MultiplayerDisconnected] = new()
        {
            [Language.English] = "Multiplayer system: Connection disconnected!",
            [Language.ChineseSimplified] = "联机系统：连接已断开！",
        },

        [TextId.MpConnected] = new()
        {
            [Language.English] = "Connected to {0}",
            [Language.ChineseSimplified] = "已连接到 {0}",
        },

        [TextId.PeerJoined] = new()
        {
            [Language.English] = "{0} joined the session",
            [Language.ChineseSimplified] = "{0} 加入了联机",
        },

        [TextId.PeerLeft] = new()
        {
            [Language.English] = "{0} left the session",
            [Language.ChineseSimplified] = "{0} 离开了联机",
        },

        [TextId.ChallengeWarning] = new()
        {
            [Language.English] = "Possibly in a challenge, recommend disconnecting for better game experience!",
            [Language.ChineseSimplified] = "检测到可能在进行挑战，建议断开连接确保游戏体验!",
        },

        [TextId.PeerDisconnectedAllReady] = new()
        {
            [Language.English] = "{0} disconnected. All remaining players are ready. Use {1} to continue, or wait for reconnection.",
            [Language.ChineseSimplified] = "{0} 已掉线。剩余玩家均已就绪，可使用 {1} 继续流程，或等待其重连。",
        },

        [TextId.PeerDisconnectedWaiting] = new()
        {
            [Language.English] = "{0} disconnected. Some players are still not ready. Wait for others or reconnection.",
            [Language.ChineseSimplified] = "{0} 已掉线。仍有玩家未就绪，请等待其他玩家或重连。",
        },

        [TextId.MpContinueHostOnly] = new()
        {
            [Language.English] = "Only the host can use /mp continue",
            [Language.ChineseSimplified] = "只有主机可以使用 /mp continue",
        },
        [TextId.MpKickHostOnly] = new()
        {
            [Language.English] = "Only the host can use /mp kick",
            [Language.ChineseSimplified] = "只有主机可以使用 /mp kick",
        },
        [TextId.MpKickNoTarget] = new()
        {
            [Language.English] = "No connected players to kick",
            [Language.ChineseSimplified] = "没有已连接的玩家可踢出",
        },
        [TextId.MpKickSelf] = new()
        {
            [Language.English] = "Cannot kick yourself",
            [Language.ChineseSimplified] = "不能踢出自己",
        },
        [TextId.MpKickNotFound] = new()
        {
            [Language.English] = "Player not found: {0}",
            [Language.ChineseSimplified] = "未找到玩家：{0}",
        },
        [TextId.MpKickSuccess] = new()
        {
            [Language.English] = "Kicked player: {0} (uid={1})",
            [Language.ChineseSimplified] = "已踢出玩家：{0} (uid={1})",
        },

        [TextId.MpContinueUsage] = new()
        {
            [Language.English] = "Usage: /mp continue <day|prep>",
            [Language.ChineseSimplified] = "用法：/mp continue <day|prep>",
        },

        [TextId.MpContinueSuccess] = new()
        {
            [Language.English] = "Forced continue {0} successful",
            [Language.ChineseSimplified] = "已强制继续 {0} 流程",
        },

        [TextId.MpContinueFailed] = new()
        {
            [Language.English] = "Cannot continue {0} — check scene and ready state",
            [Language.ChineseSimplified] = "无法继续 {0} — 请检查当前场景和就绪状态",
        },

        [TextId.PrepWorkReconnectBlocked] = new()
        {
            [Language.English] = "Connection rejected: {0} cannot reconnect during prep/work phase",
            [Language.ChineseSimplified] = "连接被拒绝: 备菜/营业阶段不允许 {0} 重连",
        },

        [TextId.TodayBusinessHours] = new()
        {
            [Language.English] = "Your business hours tonight: {0} minutes",
            [Language.ChineseSimplified] = "你今晚的营业时间为 {0} 分钟",
        },

        [TextId.PeerAlreadyInScene] = new()
        {
            [Language.English] = "Some players are already in the business or preparation scene, cannot sync business establishment info. Please reconnect during daytime.",
            [Language.ChineseSimplified] = "有玩家已经处于营业或营业准备场景，无法同步营业场馆信息。请在白天重新联机。",
        },

        [TextId.SelectedIzakaya] = new()
        {
            [Language.English] = "You selected {0} as the business location",
            [Language.ChineseSimplified] = "你选择了 {0} 作为开店地点",
        },

        [TextId.SelectedIzakayaMismatch] = new()
        {
            [Language.English] = "You selected {0}, but not all players agree: {1}",
            [Language.ChineseSimplified] = "你选择了 {0}，但未全员一致：{1}",
        },

        [TextId.WaitingForHostConfirm] = new()
        {
            [Language.English] = "Selected {0}, waiting for host to confirm...",
            [Language.ChineseSimplified] = "已选择 {0}，等待主机确认……",
        },

        [TextId.PeerSelectedIzakaya] = new()
        {
            [Language.English] = "{0} selected a business location: {1}",
            [Language.ChineseSimplified] = "{0} 选择了开店地点：{1}",
        },

        [TextId.ChatMessagePeer] = new()
        {
            [Language.English] = "{0}: {1}",
            [Language.ChineseSimplified] = "{0}: {1}",
        },

        [TextId.ChatMessageSelf] = new()
        {
            [Language.English] = "You: {0}",
            [Language.ChineseSimplified] = "你: {0}",
        },

        [TextId.PeerClosedIzakaya] = new()
        {
            [Language.English] = "{0} has closed their business!",
            [Language.ChineseSimplified] = "{0} 已经打烊啦！",
        },

        [TextId.ModVersionUnavailable] = new()
        {
            [Language.English] = "Your Mod version is {0}, unable to fetch latest version information",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，无法获取最新版本信息",
        },

        [TextId.ModVersionLatest] = new()
        {
            [Language.English] = "Your Mod version is {0}, you are using the latest version",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，您正在使用最新版",
        },

        [TextId.ModVersionOutdated] = new()
        {
            [Language.English] = "Your Mod version is {0}, latest version is {1}, recommend updating to the latest version!",
            [Language.ChineseSimplified] = "您的 Mod 版本为 {0}，最新版为 {1}，建议更新到最新版！",
        },

        [TextId.SignatureVerificationDisabled] = new()
        {
            [Language.English] = "<color=yellow>Resource package signature verification disabled, ID range signatures will not be verified.</color>",
            [Language.ChineseSimplified] = "<color=yellow>资源包签名校验已关闭，ID 段签名将不会被验证。</color>",
        },

        [TextId.ResourcePackageValidationFailed] = new()
        {
            [Language.English] = "<color=red>Resource package {0} failed ID range validation, loading rejected.</color>",
            [Language.ChineseSimplified] = "<color=red>资源包 {0} 未通过 ID 范围验证，已拒绝加载。</color>",
        },

        [TextId.ResourcePackageLoaded] = new()
        {
            [Language.English] = "Loaded resource package {0} [{1}] v{2}",
            [Language.ChineseSimplified] = "已加载资源包 {0} [{1}] v{2}",
        },

        [TextId.PeerMessagePrefix] = new()
        {
            [Language.English] = "[{0}] {1}",
            [Language.ChineseSimplified] = "[{0}] {1}",
        },

        [TextId.CommandPrompt] = new()
        {
            [Language.English] = "> {0}",
            [Language.ChineseSimplified] = "> {0}",
        },

        [TextId.BepInExConsoleEnabled] = new()
        {
            [Language.English] = "BepinEX console enabled",
            [Language.ChineseSimplified] = "BepinEX 控制台已启用",
        },

        [TextId.NotInDayScene] = new()
        {
            [Language.English] = "⚠ Not in Day Scene. This command only works during daytime.",
            [Language.ChineseSimplified] = "⚠ 不在白天场景中。此命令仅在白天使用。",
        },

        [TextId.MapInfoDisplay] = new()
        {
            [Language.English] = "label = {0}, position = {1}",
            [Language.ChineseSimplified] = "标签 = {0}，位置 = {1}",
        },

        [TextId.UnknownCommand] = new()
        {
            [Language.English] = "Unknown command: {0}. Type '/help' for available commands.",
            [Language.ChineseSimplified] = "未知命令：{0}。输入 '/help' 查看所有可用命令。",
        },

        [TextId.AvailableCommands] = new()
        {
            [Language.English] = "Available commands: /help, /clear, /get, /mp, /call, /skin, /debug, /webdebug, /enable_bepin_console, /whereami",
            [Language.ChineseSimplified] = "可用命令：/help、/clear、/get、/mp、/call、/skin、/debug、/webdebug、/enable_bepin_console、/whereami",
        },

        [TextId.GetUsage] = new()
        {
            [Language.English] = "Usage: get <field>",
            [Language.ChineseSimplified] = "用法：get <字段>",
        },

        [TextId.AvailableFields] = new()
        {
            [Language.English] = "Available fields: {0}",
            [Language.ChineseSimplified] = "可用字段：{0}",
        },

        [TextId.CurrentMapLabel] = new()
        {
            [Language.English] = "Current Active Map Label: {0}",
            [Language.ChineseSimplified] = "当前活跃地图标签：{0}",
        },

        [TextId.MystiaPosition] = new()
        {
            [Language.English] = "Mystia position: {0}",
            [Language.ChineseSimplified] = "Mystia的位置：{0}",
        },

        [TextId.UnknownField] = new()
        {
            [Language.English] = "Unknown field: {0}",
            [Language.ChineseSimplified] = "未知字段：{0}",
        },

        [TextId.MessageSent] = new()
        {
            [Language.English] = "Sent {0}",
            [Language.ChineseSimplified] = "已发送 {0}",
        },

        [TextId.CallUsage] = new()
        {
            [Language.English] = "Usage: /call <method> [args]",
            [Language.ChineseSimplified] = "用法：/call <方法> [参数]",
        },

        [TextId.AvailableMethods] = new()
        {
            [Language.English] = "Available methods: {0}",
            [Language.ChineseSimplified] = "可用方法：{0}",
        },

        [TextId.NPCListItem] = new()
        {
            [Language.English] = "- {0}",
            [Language.ChineseSimplified] = "- {0}",
        },

        [TextId.TotalNPCsFound] = new()
        {
            [Language.English] = "Total NPCs found: {0}",
            [Language.ChineseSimplified] = "找到的NPC总数：{0}",
        },

        [TextId.ErrorGetMapsnpcs] = new()
        {
            [Language.English] = "Error calling getmapsnpcs: {0}",
            [Language.ChineseSimplified] = "调用getmapsnpcs出错：{0}",
        },

        [TextId.MoveCharacterUsage] = new()
        {
            [Language.English] = "Usage: call movecharacter <characterKey> <mapLabel> <x> <y> <rot>",
            [Language.ChineseSimplified] = "用法：call movecharacter <角色键> <地图标签> <x> <y> <旋转>",
        },

        [TextId.CharacterMoved] = new()
        {
            [Language.English] = "Moved character '{0}' to position ({1}, {2}) rotation {3} on map '{4}'.",
            [Language.ChineseSimplified] = "已将角色'{0}'移动到地图'{4}'上的位置({1}, {2})，旋转{3}。",
        },

        [TextId.ErrorMovecharacter] = new()
        {
            [Language.English] = "Error calling movecharacter: {0}",
            [Language.ChineseSimplified] = "调用movecharacter出错：{0}",
        },

        [TextId.SceneMoveUsage] = new()
        {
            [Language.English] = "Usage: call scene_move <characterKey> <x> <y>",
            [Language.ChineseSimplified] = "用法：call scene_move <角色键> <x> <y>",
        },

        [TextId.CharacterMovedScene] = new()
        {
            [Language.English] = "Moved character '{0}' to position ({1}, {2}).",
            [Language.ChineseSimplified] = "已将角色'{0}'移动到位置({1}, {2})。",
        },

        [TextId.ErrorSceneMove] = new()
        {
            [Language.English] = "Error calling scene_move: {0}",
            [Language.ChineseSimplified] = "调用scene_move出错：{0}",
        },

        [TextId.NotInWorkScene] = new()
        {
            [Language.English] = "⚠ Not in Work Scene. This command only works during business hours.",
            [Language.ChineseSimplified] = "⚠ 不在营业场景中。此命令仅在营业時間使用。",
        },

        [TextId.CalledTryCloseIzakaya] = new()
        {
            [Language.English] = "called try_close_izakaya",
            [Language.ChineseSimplified] = "已调用 try_close_izakaya",
        },

        [TextId.UnknownMethod] = new()
        {
            [Language.English] = "Unknown method: {0}",
            [Language.ChineseSimplified] = "未知方法：{0}",
        },

        [TextId.WebDebuggerUsage] = new()
        {
            [Language.English] = "Usage: /webdebug start <key>",
            [Language.ChineseSimplified] = "用法：/webdebug start <密钥>",
        },

        [TextId.InvalidWebDebuggerKey] = new()
        {
            [Language.English] = "Invalid key.",
            [Language.ChineseSimplified] = "无效的密钥。",
        },

        [TextId.WebDebuggerStarted] = new()
        {
            [Language.English] = "WebDebugger started.",
            [Language.ChineseSimplified] = "Web调试器已启动。",
        },

        [TextId.SkinUsage] = new()
        {
            [Language.English] = "Usage: /skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [index]\n  /skin set <npcName>\n  /skin list\n  /skin off",
            [Language.ChineseSimplified] = "用法：/skin [on|off|set|list]\n  /skin set Mystia [Default|Explicit|DLC] [索引]\n  /skin set <NPC名>\n  /skin list\n  /skin off",
        },

        [TextId.SkinEnabled] = new()
        {
            [Language.English] = "Skin override enabled: {0}",
            [Language.ChineseSimplified] = "皮肤覆盖已启用：{0}",
        },

        [TextId.SkinDisabled] = new()
        {
            [Language.English] = "Skin override disabled, restored to game default.",
            [Language.ChineseSimplified] = "皮肤覆盖已关闭，已恢复为游戏存档中的皮肤。",
        },

        [TextId.SkinAlreadyDisabled] = new()
        {
            [Language.English] = "Skin override is not enabled.",
            [Language.ChineseSimplified] = "皮肤覆盖当前未启用。",
        },

        [TextId.SkinSetMystia] = new()
        {
            [Language.English] = "Set skin to Mystia {0} {1}",
            [Language.ChineseSimplified] = "已设置皮肤为 Mystia {0} {1}",
        },

        [TextId.SkinSetNpc] = new()
        {
            [Language.English] = "Set skin to NPC: {0}",
            [Language.ChineseSimplified] = "已设置皮肤为 NPC：{0}",
        },

        [TextId.SkinInvalidType] = new()
        {
            [Language.English] = "Invalid skin type '{0}'. Use: Default, Explicit, DLC",
            [Language.ChineseSimplified] = "无效的皮肤类型 '{0}'。可选：Default、Explicit、DLC",
        },

        [TextId.SkinInvalidIndex] = new()
        {
            [Language.English] = "Invalid index '{0}' for type {1}.",
            [Language.ChineseSimplified] = "类型 {1} 的索引 '{0}' 无效。",
        },

        [TextId.SkinNpcNotFound] = new()
        {
            [Language.English] = "NPC '{0}' not found in allNPCs.",
            [Language.ChineseSimplified] = "NPC '{0}' 在 allNPCs 中未找到。",
        },

        [TextId.SkinListHeader] = new()
        {
            [Language.English] = "=== Mystia Skins ===",
            [Language.ChineseSimplified] = "=== Mystia 皮肤列表 ===",
        },

        [TextId.SkinListItem] = new()
        {
            [Language.English] = "  [{0}] {1} #{2}: {3}",
            [Language.ChineseSimplified] = "  [{0}] {1} #{2}：{3}",
        },

        [TextId.SkinListNpcHint] = new()
        {
            [Language.English] = "To use NPC skin: /skin set <npcName> (e.g. Kosuzu, Aunn, etc.)",
            [Language.ChineseSimplified] = "使用 NPC 皮肤：/skin set <NPC名>（如 Kosuzu、Aunn 等）",
        },

        [TextId.SkinStatus] = new()
        {
            [Language.English] = "Skin override: ON — {0}",
            [Language.ChineseSimplified] = "皮肤覆盖：已开启 — {0}",
        },

        [TextId.SkinStatusDisabled] = new()
        {
            [Language.English] = "Skin override: OFF",
            [Language.ChineseSimplified] = "皮肤覆盖：已关闭",
        },

        // Help & Command Descriptions
        [TextId.HelpHeader] = new()
        {
            [Language.English] = "Commands",
            [Language.ChineseSimplified] = "命令列表",
        },
        [TextId.CmdDescHelp] = new()
        {
            [Language.English] = "Show this help",
            [Language.ChineseSimplified] = "显示帮助",
        },
        [TextId.CmdDescClear] = new()
        {
            [Language.English] = "Clear console",
            [Language.ChineseSimplified] = "清空控制台",
        },
        [TextId.CmdDescGet] = new()
        {
            [Language.English] = "Query game state",
            [Language.ChineseSimplified] = "查询游戏状态",
        },
        [TextId.CmdDescMp] = new()
        {
            [Language.English] = "Multiplayer commands",
            [Language.ChineseSimplified] = "联机命令",
        },
        [TextId.CmdDescCall] = new()
        {
            [Language.English] = "Call game methods",
            [Language.ChineseSimplified] = "调用游戏方法",
        },
        [TextId.CmdDescSkin] = new()
        {
            [Language.English] = "Skin management",
            [Language.ChineseSimplified] = "皮肤管理",
        },
        [TextId.CmdDescDebug] = new()
        {
            [Language.English] = "Show MP debug info",
            [Language.ChineseSimplified] = "显示联机调试信息",
        },
        [TextId.CmdDescWebdebug] = new()
        {
            [Language.English] = "Web debugger",
            [Language.ChineseSimplified] = "Web 调试器",
        },
        [TextId.CmdDescWhereami] = new()
        {
            [Language.English] = "Show map & position",
            [Language.ChineseSimplified] = "显示地图和位置",
        },
        [TextId.CmdDescEnableBepinConsole] = new()
        {
            [Language.English] = "Enable BepInEx console",
            [Language.ChineseSimplified] = "启用 BepInEx 控制台",
        },
        [TextId.MpHelpHeader] = new()
        {
            [Language.English] = "Multiplayer",
            [Language.ChineseSimplified] = "联机",
        },
        [TextId.CallHelpHeader] = new()
        {
            [Language.English] = "Game Methods",
            [Language.ChineseSimplified] = "游戏方法",
        },
        [TextId.SkinHelpHeader] = new()
        {
            [Language.English] = "Skin Management",
            [Language.ChineseSimplified] = "皮肤管理",
        },

        // ── mp subcommand descriptions ──
        [TextId.MpDescStart] = new()
        {
            [Language.English] = "Start multiplayer",
            [Language.ChineseSimplified] = "启动联机",
        },
        [TextId.MpDescStop] = new()
        {
            [Language.English] = "Stop multiplayer",
            [Language.ChineseSimplified] = "停止联机",
        },
        [TextId.MpDescRestart] = new()
        {
            [Language.English] = "Restart multiplayer",
            [Language.ChineseSimplified] = "重启联机",
        },
        [TextId.MpDescStatus] = new()
        {
            [Language.English] = "Show connection status",
            [Language.ChineseSimplified] = "查看连接状态",
        },
        [TextId.MpDescId] = new()
        {
            [Language.English] = "Set player ID",
            [Language.ChineseSimplified] = "设置玩家 ID",
        },
        [TextId.MpDescConnect] = new()
        {
            [Language.English] = "Connect to host",
            [Language.ChineseSimplified] = "连接到主机",
        },
        [TextId.MpDescDisconnect] = new()
        {
            [Language.English] = "Disconnect",
            [Language.ChineseSimplified] = "断开连接",
        },
        [TextId.MpDescKick] = new()
        {
            [Language.English] = "Kick a player (host)",
            [Language.ChineseSimplified] = "踢出玩家 (主机)",
        },
        [TextId.MpDescKickId] = new()
        {
            [Language.English] = "Kick by player name",
            [Language.ChineseSimplified] = "按玩家名踢出",
        },
        [TextId.MpDescKickUid] = new()
        {
            [Language.English] = "Kick by UID",
            [Language.ChineseSimplified] = "按 UID 踢出",
        },
        [TextId.MpDescContinue] = new()
        {
            [Language.English] = "Force continue (host)",
            [Language.ChineseSimplified] = "强制继续 (主机)",
        },

        // ── call subcommand descriptions ──
        [TextId.CallDescGetmapsnpcs] = new()
        {
            [Language.English] = "List NPCs on map",
            [Language.ChineseSimplified] = "列出地图上的 NPC",
        },
        [TextId.CallDescMovecharacter] = new()
        {
            [Language.English] = "Move character",
            [Language.ChineseSimplified] = "移动角色",
        },
        [TextId.CallDescSceneMove] = new()
        {
            [Language.English] = "Move to scene",
            [Language.ChineseSimplified] = "移动到场景",
        },
        [TextId.CallDescTryCloseIzakaya] = new()
        {
            [Language.English] = "Try close izakaya",
            [Language.ChineseSimplified] = "尝试关闭居酒屋",
        },

        // ── skin subcommand descriptions ──
        [TextId.SkinDescSet] = new()
        {
            [Language.English] = "Set character skin",
            [Language.ChineseSimplified] = "设置角色皮肤",
        },
        [TextId.SkinDescOff] = new()
        {
            [Language.English] = "Reset skin to default",
            [Language.ChineseSimplified] = "恢复默认皮肤",
        },
        [TextId.SkinDescList] = new()
        {
            [Language.English] = "List available skins",
            [Language.ChineseSimplified] = "列出可用皮肤",
        },

        // ── Console startup & link ──
        [TextId.ConsoleStarPrompt] = new()
        {
            [Language.English] = "Welcome to MetaMystia! If you enjoy it, please star us: /link MetaMystia",
            [Language.ChineseSimplified] = "欢迎使用 MetaMystia mod！如果喜欢，请给项目点个 Star：/link MetaMystia",
        },
        [TextId.ConsoleHelpHint] = new()
        {
            [Language.English] = "Type /help for commands. Tab to auto-complete.",
            [Language.ChineseSimplified] = "输入 /help 查看命令列表，Tab 自动补全。",
        },
        [TextId.CmdDescLink] = new()
        {
            [Language.English] = "Open project links",
            [Language.ChineseSimplified] = "打开项目链接",
        },
        [TextId.LinkDescMetaMystia] = new()
        {
            [Language.English] = "MetaMystia GitHub",
            [Language.ChineseSimplified] = "MetaMystia GitHub 仓库",
        },
        [TextId.LinkDescIzakaya] = new()
        {
            [Language.English] = "touhou mystia izakaya assistant",
            [Language.ChineseSimplified] = "东方夜雀食堂小助手",
        },

        // ── ResourceEx Console Messages ──

        [TextId.ResourceExConsoleLoaded] = new()
        {
            [Language.English] = "✓ ResourceEx: {0} v{1} by {2}",
            [Language.ChineseSimplified] = "✓ 资源包: {0} v{1} 作者: {2}",
        },
        [TextId.ResourceExConsoleLoadedNoInfo] = new()
        {
            [Language.English] = "✓ ResourceEx: {0} (no pack info)",
            [Language.ChineseSimplified] = "✓ 资源包: {0}（无包信息）",
        },
        [TextId.ResourceExConsoleRejected] = new()
        {
            [Language.English] = "✗ ResourceEx: {0} rejected — {1}",
            [Language.ChineseSimplified] = "✗ 资源包: {0} 已拒绝 — {1}",
        },
        [TextId.CmdDescResourceEx] = new()
        {
            [Language.English] = "Resource pack management",
            [Language.ChineseSimplified] = "资源包管理",
        },
        [TextId.ResourceExHelpHeader] = new()
        {
            [Language.English] = "ResourceEx Commands",
            [Language.ChineseSimplified] = "ResourceEx 命令",
        },
        [TextId.ResourceExDescList] = new()
        {
            [Language.English] = "List all loaded resource packs",
            [Language.ChineseSimplified] = "列出所有已加载的资源包",
        },
        [TextId.ResourceExDescInfo] = new()
        {
            [Language.English] = "Show details of a resource pack",
            [Language.ChineseSimplified] = "显示资源包详细信息",
        },
        [TextId.ResourceExListHeader] = new()
        {
            [Language.English] = "Loaded Resource Packs ({0})",
            [Language.ChineseSimplified] = "已加载资源包 ({0})",
        },
        [TextId.ResourceExListItem] = new()
        {
            [Language.English] = "{0} v{1} by {2}",
            [Language.ChineseSimplified] = "{0} v{1} 作者: {2}",
        },
        [TextId.ResourceExListEmpty] = new()
        {
            [Language.English] = "No resource packs loaded.",
            [Language.ChineseSimplified] = "未加载任何资源包。",
        },
        [TextId.ResourceExInfoHeader] = new()
        {
            [Language.English] = "Resource Pack Info",
            [Language.ChineseSimplified] = "资源包信息",
        },
        [TextId.ResourceExInfoName] = new()
        {
            [Language.English] = "Name: {0}",
            [Language.ChineseSimplified] = "名称: {0}",
        },
        [TextId.ResourceExInfoLabel] = new()
        {
            [Language.English] = "Label: {0}",
            [Language.ChineseSimplified] = "标签: {0}",
        },
        [TextId.ResourceExInfoVersion] = new()
        {
            [Language.English] = "Version: {0}",
            [Language.ChineseSimplified] = "版本: {0}",
        },
        [TextId.ResourceExInfoAuthors] = new()
        {
            [Language.English] = "Authors: {0}",
            [Language.ChineseSimplified] = "作者: {0}",
        },
        [TextId.ResourceExInfoDescription] = new()
        {
            [Language.English] = "Description: {0}",
            [Language.ChineseSimplified] = "描述: {0}",
        },
        [TextId.ResourceExInfoLicense] = new()
        {
            [Language.English] = "License: {0}",
            [Language.ChineseSimplified] = "许可证: {0}",
        },
        [TextId.ResourceExInfoIdRange] = new()
        {
            [Language.English] = "ID Range: {0} – {1}",
            [Language.ChineseSimplified] = "ID 范围: {0} – {1}",
        },
        [TextId.ResourceExInfoContents] = new()
        {
            [Language.English] = "Contents: {0}",
            [Language.ChineseSimplified] = "内容: {0}",
        },
        [TextId.ResourceExInfoNotFound] = new()
        {
            [Language.English] = "Resource pack '{0}' not found.",
            [Language.ChineseSimplified] = "未找到资源包 '{0}'。",
        },
        [TextId.ResourceExRejectedHeader] = new()
        {
            [Language.English] = "Rejected Resource Packs ({0})",
            [Language.ChineseSimplified] = "被拒绝的资源包 ({0})",
        },
        [TextId.ResourceExRejectedItem] = new()
        {
            [Language.English] = "{0} — {1}",
            [Language.ChineseSimplified] = "{0} — {1}",
        },
        [TextId.RoomFull] = new()
        {
            [Language.English] = "Room is full ({0}/{1})",
            [Language.ChineseSimplified] = "房间已满 ({0}/{1})",
        },
        [TextId.RoomFullHostNotify] = new()
        {
            [Language.English] = "{0} tried to join, but room is full ({1}/{2})",
            [Language.ChineseSimplified] = "{0} 尝试加入，但房间已满 ({1}/{2})",
        },
        [TextId.MpMaxPlayersCurrent] = new()
        {
            [Language.English] = "Max players: {0}",
            [Language.ChineseSimplified] = "最大玩家数: {0}",
        },
        [TextId.MpMaxPlayersSet] = new()
        {
            [Language.English] = "Max players set to {0}",
            [Language.ChineseSimplified] = "最大玩家数已设为 {0}",
        },
        [TextId.MpMaxPlayersHostOnly] = new()
        {
            [Language.English] = "Only the host can change max players",
            [Language.ChineseSimplified] = "仅主机可修改最大玩家数",
        },
        [TextId.MpMaxPlayersRange] = new()
        {
            [Language.English] = "Max players must be at least 2",
            [Language.ChineseSimplified] = "最大玩家数不能小于 2",
        },
        [TextId.MpDescMaxPlayers] = new()
        {
            [Language.English] = "View or set max player limit",
            [Language.ChineseSimplified] = "查看或设置最大玩家数",
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
        GameData.MultiLanguageTextMesh.LoadLanguageType.CNT => Language.ChineseSimplified,
        _ => Language.English,
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


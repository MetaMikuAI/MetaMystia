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
    ConnectCommand,
    ConnectCommandConnected,
    ConnectCommandFail,

    // Multiplayer
    MpUsageHelp,
    MpAlreadyStarted,
    MpStartedAsHost,
    MpStartedAsClient,
    MpStopped,
    MpRestarted,

    // help / usage
    MpSubcommandHelp,
    MpUsageRoot,
    MpUsageSetId,

    // state / result
    MpPlayerIdSet,
    MpNoActiveConnection,
    MpConnecting,
    MpDisconnected,
    MpUnknownSubcommand,

    DLCPeerRecipeNotAvailable,
    DLCPeerBeverageNotAvailable,
    DLCPeerFoodNotAvailable,

    MystiaReadyForWork,
    ReadyForWork
}

public static class L10n
{
    private static readonly Dictionary<TextId, Dictionary<Language, string>> Table = new()
    {
        [TextId.ConnectCommand] = new()
        {
            [Language.English] = "Usage: /mp connect <ip> <port>(optional)",
            [Language.ChineseSimplified] = "使用方法：/mp connect <对方ip:对方端口> (例如：/mp connect 127.0.0.1:40815)",
        },

        [TextId.ConnectCommandConnected] = new()
        {
            [Language.English] = "Connected to {0}",
            [Language.ChineseSimplified] = "已连接到 {0}",
        },

        [TextId.ConnectCommandFail] = new()
        {
            [Language.English] = "Failed to connect to {0}",
            [Language.ChineseSimplified] = "连接到 {0} 失败！",
        },

        [TextId.MpUsageHelp] = new()
        {
            [Language.English] = "Usage: /mp start server or /mp start client",
            [Language.ChineseSimplified] = "用法：/mp start server 或 /mp start client \n(你会不会把server输入成sever了？或者把client输入成cilent了？)",
            [Language.Japanese] = "使用方法：/mp start server または /mp start client"
        },

        [TextId.MpAlreadyStarted] = new()
        {
            [Language.English] = "Multiplayer already started as {0}",
            [Language.ChineseSimplified] = "联机系统已作为 {0} 启动",
            [Language.Japanese] = "マルチプレイはすでに {0} として起動しています"
        },

        [TextId.MpStartedAsHost] = new()
        {
            [Language.English] = "Multiplayer started as Host",
            [Language.ChineseSimplified] = "联机系统已作为主机启动",
            [Language.Japanese] = "マルチプレイをホストとして開始しました"
        },

        [TextId.MpStartedAsClient] = new()
        {
            [Language.English] = "Multiplayer started as Client",
            [Language.ChineseSimplified] = "联机系统已作为客户端启动",
            [Language.Japanese] = "マルチプレイをクライアントとして開始しました"
        },

        [TextId.MpStopped] = new()
        {
            [Language.English] = "Multiplayer stopped",
            [Language.ChineseSimplified] = "联机系统已停止",
            [Language.Japanese] = "マルチプレイを停止しました"
        },

        [TextId.MpRestarted] = new()
        {
            [Language.English] = "Multiplayer restarted",
            [Language.ChineseSimplified] = "联机系统已重启",
            [Language.Japanese] = "マルチプレイを再起動しました"
        },

        [TextId.MpSubcommandHelp] = new()
        {
            [Language.English] = "Subcommands: start, stop, restart, status, id, connect, disconnect",
            [Language.ChineseSimplified] = "子命令：start、stop、restart、status、id、connect、disconnect",
            [Language.Japanese] = "サブコマンド：start、stop、restart、status、id、connect、disconnect"
        },

        [TextId.MpUsageRoot] = new()
        {
            [Language.English] = "Usage: /mp <subcommand> [args]",
            [Language.ChineseSimplified] = "用法：/mp <子命令> [参数] （不要尖括号和方括号哦）",
            [Language.Japanese] = "使用方法：/mp <サブコマンド> [引数]"
        },

        [TextId.MpUsageSetId] = new()
        {
            [Language.English] = "Usage: /mp id <new_id>",
            [Language.ChineseSimplified] = "用法：/mp id <新ID> （不要尖括号哦）",
            [Language.Japanese] = "使用方法：/mp id <新しいID>"
        },
        [TextId.MpPlayerIdSet] = new()
        {
            [Language.English] = "Player ID set to {0}",
            [Language.ChineseSimplified] = "玩家 ID 已设置为 {0}",
            [Language.Japanese] = "プレイヤーIDを {0} に設定しました"
        },

        [TextId.MpNoActiveConnection] = new()
        {
            [Language.English] = "No active connection",
            [Language.ChineseSimplified] = "当前没有活动连接",
            [Language.Japanese] = "アクティブな接続はありません"
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
            [Language.Japanese] = "接続を切断しました"
        },

        [TextId.MpUnknownSubcommand] = new()
        {
            [Language.English] = "Unknown subcommand: {0}",
            [Language.ChineseSimplified] = "未知的子命令：{0}",
            [Language.Japanese] = "不明なサブコマンド：{0}"
        },

        [TextId.DLCPeerFoodNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC that contains the food item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食物 {0} 的 DLC",
        },

        [TextId.DLCPeerBeverageNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC that contains the beverage item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此酒水 {0} 的 DLC",
        },

        [TextId.DLCPeerRecipeNotAvailable] = new()
        {
            [Language.English] = "One or more players have not installed the DLC that contains the recipe item {0}.",
            [Language.ChineseSimplified] = "有玩家未装载有此食谱 {0} 的 DLC",
        },

        [TextId.ReadyForWork] = new()
        {
            [Language.English] = "{0} are ready to open for business.",
            [Language.ChineseSimplified] = "{0} 已经准备好营业啦",
        },
    };

    static L10n()
    {
        PostInitializeTable();
    }

    private static void PostInitializeTable()
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


using BepInEx.Configuration;
using System;

namespace MetaMystia;

/// <summary>
/// 点单请求启用模式：强制关闭、跟随资源包、强制启用
/// </summary>
public enum RequestEnableMode
{
    ForceDisable,    // 强制关闭
    FollowPackage,   // 跟随资源包
    ForceEnable      // 强制启用
}



[AutoLog]
public static partial class ConfigManager
{
    public static ConfigFile Config => Plugin.Instance?.Config;
    public static ConfigEntry<bool> Debug;
    public static ConfigEntry<string> PlayerId;
    public static ConfigEntry<bool> SignatureCheck;
    public static ConfigEntry<RequestEnableMode> FoodRequestMode;
    public static ConfigEntry<RequestEnableMode> BevRequestMode;
    public static ConfigEntry<int> ConsoleHistorySize;
    public static ConfigEntry<string> ConsoleHistoryFile;
    public static ConfigEntry<int> MaxPlayers;

    public static void InitConfigs()
    {
        Debug = Config.Bind("General", "Debug", false, "Enable debug features and hotkeys\n启用调试功能和热键");

        PlayerId = Config.Bind("General", "PlayerId", "", "Player ID for multiplayer, empty to device name\n联机用玩家 ID，为空则默认为设备名称");

        SignatureCheck = Config.Bind("General", "SignatureCheck", true,
            "Enable RSA signature verification for resource pack ID ranges\n启用资源包 ID 段 RSA 签名校验");

        FoodRequestMode = Config.Bind("General", "FoodRequestMode", RequestEnableMode.FollowPackage,
            "Food request enable mode (FollowPackage by default)\n料理点单启用模式(默认跟随资源包)\n" +
            "ForceDisable: 强制关闭 | FollowPackage: 跟随资源包 | ForceEnable: 强制启用");

        BevRequestMode = Config.Bind("General", "BevRequestMode", RequestEnableMode.ForceDisable,
            "Beverage request enable mode (ForceDisable by default)\n酒水点单启用模式(默认关闭)\n" +
            "ForceDisable: 强制关闭 | FollowPackage: 跟随资源包 | ForceEnable: 强制启用");

        ConsoleHistorySize = Config.Bind("General", "ConsoleHistorySize", 200,
            "Max number of console commands to persist across sessions\n控制台命令历史记录最大保存条数");

        ConsoleHistoryFile = Config.Bind("General", "ConsoleHistoryFile", "MetaMystia_console_history.txt",
            "Filename for console command history (stored in BepInEx/config/)\n控制台命令历史文件名(存储于 BepInEx/config/)");

        MaxPlayers = Config.Bind("Multiplayer", "MaxPlayers", 2,
            new BepInEx.Configuration.ConfigDescription(
                "Maximum number of players allowed (including host)\n最大玩家数（含主机）",
                new BepInEx.Configuration.AcceptableValueRange<int>(2, int.MaxValue)));
    }

    public static string GetPlayerId()
    {
        if (string.IsNullOrEmpty(PlayerId.Value))
        {
            return Environment.MachineName;
        }
        return PlayerId.Value;
    }
    public static void SetPlayerId(string id)
    {
        Log.Message($"Player ID {PlayerId.Value} set to: {id}");
        PlayerId.Value = id;
    }
}

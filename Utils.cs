using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using BepInEx.Logging;
using UnityEngine;
using System.IO;
using Common.UI;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.InteropServices;
using System.Reflection;
using DEYU.Utils;

namespace MetaMystia;

public static class Utils
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[Utils.cs]";

    public static string GetMapNameCN(string mapLabel)
    {
        return mapLabel switch
        {
            "Home" => "家",
            "MoveCharacter" => "地下室",
            "BeastForest" => "兽道",
            "HumanVillage" => "人间之里",
            "HakureiShrine" => "博丽神社",
            "DLC1_MagicForest" => "魔法森林",
            "DLC1_YoukaiMountain" => "妖怪之山",
            "DLC2_FormerHell" => "旧地狱",
            "DLC2_EarthSpiritsPalace" => "地灵殿",
            "DLC3_MyourenTemple" => "命莲寺",
            // 不会拼斯卡雷特，其他的没开暂时
            _ => mapLabel
        };
    }
};

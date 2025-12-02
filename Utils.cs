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

namespace MetaMystia;

public static class Utils
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[Utils.cs]";
};

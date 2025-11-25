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
   
    private static DialogPackage KMExampleDialogPackage = null;

    public static void ShowReadyDialog(bool isReady, System.Action onFinishCallback = null) 
    {
        if (KMExampleDialogPackage == null)
        {
            DumpExampleDialog();
        }
        
        try
        {
            var originalDialogPackage = KMExampleDialogPackage;
            System.Action<Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
            {
                if (isReady)
                {
                    replaceDict[0] = "米斯琪——营业时间快要到啦——";
                    replaceDict[1] = "好呐，我们现在就出发吧~";
                }
                else
                {
                    replaceDict[0] = "等等——还有点事没处理好嘛——";
                    replaceDict[1] = "没关系呀，现在距离营业时间还有点时间。";
                }
            }; // 文案: 余烬特调
            
            UniversalGameManager.OpenDialogMenu(
                originalDialogPackage,
                onFinishCallback: onFinishCallback,
                overrideReplaceTextCallback: overrideReplaceTextCallback,
                previousPanelVisualMode: 0
            );
            
            Log.LogInfo($"{LOG_TAG} Opened dialog with custom text");
        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to open dialog: {e.Message}\n{e.StackTrace}");
        }
    }
    public static void DumpExampleDialog()
    {
        try
        {
            var dialogPackageType = Il2CppType.Of<DialogCollectionProfile>();
            var foundAssets = Resources.FindObjectsOfTypeAll(dialogPackageType);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} No DialogCollectionProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"{LOG_TAG} Found {foundAssets.Length} DialogCollectionProfile asset(s).");

            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var collection = foundAssets[assetIndex].TryCast<DialogCollectionProfile>();
                if (collection == null)
                {
                    Log.LogWarning($"{LOG_TAG} Object at index {assetIndex} could not be cast to DialogCollectionProfile.");
                    continue;
                }

                var allContents = collection.allContents;
                if (allContents == null)
                {
                    Log.LogWarning($"{LOG_TAG} DialogCollectionProfile '{collection.name}' has no entries.");
                    continue;
                }

                Log.LogDebug($"{LOG_TAG} --- DialogCollectionProfile '{collection.name}' ({allContents.Length} entries) ---");

                for (var i = 0; i < allContents.Length; i++)
                {
                    var entry = allContents[i];
                    var id = entry.id;
                    var packageName = entry.dialogePack.name;
                    if (packageName == "Kyouko_EA_Dialog")
                    {
                        KMExampleDialogPackage = entry.dialogePack;
                        Log.LogInfo($"{LOG_TAG} Stored Kyouko_EA_Dialog package.");
                    }

                    Log.LogDebug($"{LOG_TAG} [{i}] id={entry.id}, package={packageName}");
                }
            }
        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to dump DialogCollectionProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }
};


public static class DiagnosticUtils
{
    private static ManualLogSource Debug => Plugin.Instance.Log;
    public static void LogMethodInfo(MethodBase method)
    {
        Debug.LogMessage($"[DIAG] Method: {method.DeclaringType?.Name}.{method.Name}");
        Debug.LogMessage($"[DIAG] FullName: {method}");
        Debug.LogMessage($"[DIAG] IsStatic: {method.IsStatic}");
    }

    public static void LogAllProperties(object obj)
    {
        if (obj == null)
        {
            Debug.LogMessage("[DIAG] Object is null");
            return;
        }

        var type = obj.GetType();
        Debug.LogMessage($"[DIAG] =========== Inspecting type: {type.FullName}");

        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
        {
            try
            {
                var value = prop.GetValue(obj);
                Debug.LogMessage($"[DIAG] Property: {prop.Name}, Type: {prop.PropertyType}, Value: {value}");

                // 检查集合属性
                if (value is System.Collections.IEnumerable enumerable &&
                    !(value is string))
                {
                    var isReadOnly = value.GetType().GetProperty("IsReadOnly")?.GetValue(value);
                    Debug.LogMessage($"[DIAG]   -> IsReadOnly: {isReadOnly}");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[DIAG] Error reading {prop.Name}: {ex.Message}");
            }
        }
        Debug.LogMessage($"[DIAG] =========== Inspecting done");

    }

    public static void PrintAllKeyValues<T>(Dictionary<string, T> dict)
    {
        if (dict == null)
        {
            Debug.LogMessage("[DIAG] Dict is null");
            return;
        }

        if (dict.Count == 0)
        {
            Debug.LogMessage("[DIAG] Dict is empty");
            return;
        }

        Debug.LogMessage($"[DIAG] ================= Listing {dict}");
        foreach (var key in dict.Keys)
        {
            T value = dict[key];
            string valueStr = value != null ? value.ToString() : "null";
            Debug.LogMessage($"[DIAG] Key: {key}, Value: {valueStr}");
        }
        Debug.LogMessage($"[DIAG] ================= Done listing {dict}");
    }

}

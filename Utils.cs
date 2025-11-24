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

namespace MetaMystia;

public static class Utils
{
    private static ManualLogSource Log => Plugin.Instance.Log;
   
    private static DialogPackage KMExampleDialogPackage = null;

// 一个准备好了 一个没准备好的
    public static void test(bool isReady) 
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
                onFinishCallback: null,
                overrideReplaceTextCallback: overrideReplaceTextCallback,
                previousPanelVisualMode: 0
            );
            
            Log.LogInfo($"Opened dialog with custom text");
        }
        catch (Exception e)
        {
            Log.LogError($"Failed to open dialog: {e.Message}\n{e.StackTrace}");
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
                Log.LogWarning("No DialogCollectionProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"Found {foundAssets.Length} DialogCollectionProfile asset(s).");

            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var collection = foundAssets[assetIndex].TryCast<DialogCollectionProfile>();
                if (collection == null)
                {
                    Log.LogWarning($"Object at index {assetIndex} could not be cast to DialogCollectionProfile.");
                    continue;
                }

                var allContents = collection.allContents;
                if (allContents == null)
                {
                    Log.LogWarning($"DialogCollectionProfile '{collection.name}' has no entries.");
                    continue;
                }

                Log.LogInfo($"--- DialogCollectionProfile '{collection.name}' ({allContents.Length} entries) ---");

                for (var i = 0; i < allContents.Length; i++)
                {
                    var entry = allContents[i];
                    var id = entry.id;
                    var packageName = entry.dialogePack.name;
                    if (packageName == "Kyouko_EA_Dialog")
                    {
                        KMExampleDialogPackage = entry.dialogePack;
                        Log.LogInfo($"Stored Kyouko_EA_Dialog package.");
                    }

                    Log.LogInfo($"[{i}] id={entry.id}, package={packageName}");
                }
            }
        }
        catch (Exception e)
        {
            Log.LogError($"Failed to dump DialogCollectionProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }

};

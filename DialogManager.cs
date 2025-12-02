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

public static class DialogManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[DialogManager.cs]";
   
    public static DialogPackage KMExampleDialogPackage = null;
    public static DialogPackage Kyouko_Tutorial_Dialog_ForDLC1MainStory = null;
    public static Dictionary<int, DialogPackage> dialogs = new Dictionary<int, DialogPackage>();

    public enum Character
    {
        Mystia = 0,
        Kyouko = 1,
    }

    public static void BuildAndShow(System.Collections.Generic.List<Tuple<Character, string>> dialogs, System.Action onFinishCallback = null)
    {
        if (KMExampleDialogPackage == null)
        {
            DumpExampleDialog();
        }
        var newDialogPackage = UnityEngine.Object.Instantiate(KMExampleDialogPackage);

        var length = dialogs.Count;
        var newMeta = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Common.DialogUtility.DialogMeta>(length);
        for (int i = 0; i < length; i++)
        {
            var (character, message) = dialogs[i];
            var meta = new Common.DialogUtility.DialogMeta();
            switch (character)
            {
                case Character.Mystia:
                    meta = KMExampleDialogPackage.dialogMeta[1];
                    break;
                case Character.Kyouko:
                    meta = KMExampleDialogPackage.dialogMeta[0];
                    break;
                default:
                    Log.LogError($"{LOG_TAG} Unknown character enum: {character}");
                    return;
            }
            meta.dialogId = i;
            newMeta[i] = meta;
        }

        newDialogPackage.dialogMeta = newMeta;
        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
        {
            for (int i = 0; i < length; i++)
            {
                var (_, message) = dialogs[i];
                replaceDict[i] = message;
            }
        };

        UniversalGameManager.OpenDialogMenu(
            newDialogPackage,
            onFinishCallback: onFinishCallback,
            overrideReplaceTextCallback: overrideReplaceTextCallback,
            previousPanelVisualMode: 0
        );
    }

    public static void ShowKMDialog(string KyoukoMessage, string MystiaMessage, System.Action onFinishCallback = null) 
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
                replaceDict[0] = KyoukoMessage;
                replaceDict[1] = MystiaMessage;
            };
            
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
    public static void ShowReadyDialog(bool isReady, System.Action onFinishCallback = null) 
    {
        var dialogList = new System.Collections.Generic.List<Tuple<DialogManager.Character, string>>();
        if (isReady)
        {
            dialogList.Add(new Tuple<DialogManager.Character, string>(DialogManager.Character.Kyouko, "米斯琪——营业时间快要到啦——"));
            dialogList.Add(new Tuple<DialogManager.Character, string>(DialogManager.Character.Mystia, "好呐，我们现在就出发吧~"));
        }
        else
        {
            dialogList.Add(new Tuple<DialogManager.Character, string>(DialogManager.Character.Kyouko, "等等——还有点事没处理好嘛——"));
            dialogList.Add(new Tuple<DialogManager.Character, string>(DialogManager.Character.Mystia, "没关系呀，现在距离营业时间还有点时间。"));
        } // 文案: 余烬特调
        BuildAndShow(dialogList, onFinishCallback);
    }

    public static void ShowSelectedDialog(bool selected, System.Action onFinishCallback = null) 
    {
        string KyoukoMessage;
        string MystiaMessage;
        if (selected)
        {
            KyoukoMessage = "准备好了我们就出发吧"; // TODO: replace xxx with selected spot
            MystiaMessage = "走吧";
        }
        else
        {
            KyoukoMessage = "我想去 xxx 开店";
            MystiaMessage = "我在想想";
        }
        ShowKMDialog(KyoukoMessage, MystiaMessage, onFinishCallback);
    }
    public static void DumpExampleDialog()
    {
        try
        {
            var dialogPackageType = Il2CppType.Of<GameData.Profile.DialogPackage>();
            var foundAssets = Resources.FindObjectsOfTypeAll(dialogPackageType);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} No DialogCollectionProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"{LOG_TAG} Found {foundAssets.Length} DialogCollectionProfile asset(s).");

            int count = 0;
            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var collection = foundAssets[assetIndex].TryCast<GameData.Profile.DialogPackage>();
                if (collection == null)
                {
                    Log.LogWarning($"{LOG_TAG} Object at index {assetIndex} could not be cast to DialogCollectionProfile.");
                    continue;
                }
                var packageName = collection.name;
                if (packageName == "Kyouko_EA_Dialog")
                {
                    KMExampleDialogPackage = collection;
                    Log.LogInfo($"{LOG_TAG} Stored Kyouko_EA_Dialog package.");
                }
                if (packageName == "Kyouko_Tutorial_Dialog_ForDLC1MainStory")
                {
                    Kyouko_Tutorial_Dialog_ForDLC1MainStory = collection;
                    Log.LogInfo($"{LOG_TAG} Stored Kyouko_Tutorial_Dialog_ForDLC1MainStory package.");
                }
                Log.LogWarning($"{LOG_TAG} [{count}] id={collection.name}, package={packageName}");
                if (packageName.ToLower().Contains("kyouko") || packageName == "OnTransitionToNight")
                {
                    dialogs[count] = collection;
                    count++;
                }

            }
        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to dump DialogCollectionProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }
};




/*
[0] id=Kizuna_Rumia_LV1_001, package=Kizuna_Rumia_LV1_001
[1] id=Kizuna_Rumia_LV1_002, package=Kizuna_Rumia_LV1_002
[2] id=Kizuna_Rumia_LV1_Upgrade_001_Await, package=Kizuna_Rumia_LV1_Upgrade_001_Await
[3] id=Kizuna_Rumia_LV2_001, package=Kizuna_Rumia_LV2_001
[4] id=Kizuna_Rumia_LV2_002, package=Kizuna_Rumia_LV2_002
[5] id=Kizuna_Rumia_LV3_Upgrade_001_Await, package=Kizuna_Rumia_LV3_Upgrade_001_Await
[6] id=Kizuna_Rumia_LV3_Upgrade_002_Await, package=Kizuna_Rumia_LV3_Upgrade_002_Await
[7] id=Kizuna_Rumia_LV3_001, package=Kizuna_Rumia_LV3_001
[8] id=Kizuna_Rumia_LV3_002, package=Kizuna_Rumia_LV3_002
[9] id=Kizuna_Rumia_LV4_001, package=Kizuna_Rumia_LV4_001
[10] id=Kizuna_Rumia_LV4_002, package=Kizuna_Rumia_LV4_002
[11] id=Kizuna_Chen_LV1_001, package=Kizuna_Chen_LV1_001
[12] id=Kizuna_Chen_LV1_002, package=Kizuna_Chen_LV1_002
[13] id=Kizuna_Chen_LV2_001, package=Kizuna_Chen_LV2_001
[14] id=Kizuna_Chen_LV2_002, package=Kizuna_Chen_LV2_002
[15] id=Kizuna_Chen_LV3_001, package=Kizuna_Chen_LV3_001
[16] id=Kizuna_Chen_LV3_002, package=Kizuna_Chen_LV3_002
[17] id=Kizuna_Chen_LV4_001, package=Kizuna_Chen_LV4_001
[18] id=Kizuna_Chen_LV4_002, package=Kizuna_Chen_LV4_002
[19] id=Kizuna_Wriggle_LV1_001, package=Kizuna_Wriggle_LV1_001
[20] id=Kizuna_Wriggle_LV1_002, package=Kizuna_Wriggle_LV1_002
[21] id=Kizuna_Wriggle_LV2_001, package=Kizuna_Wriggle_LV2_001
[22] id=Kizuna_Wriggle_LV2_002, package=Kizuna_Wriggle_LV2_002
[23] id=Kizuna_Wriggle_LV2_003, package=Kizuna_Wriggle_LV2_003
[24] id=Kizuna_Wriggle_LV3_001, package=Kizuna_Wriggle_LV3_001
[25] id=Kizuna_Wriggle_LV3_002, package=Kizuna_Wriggle_LV3_002
[26] id=Kizuna_Wriggle_LV4_002, package=Kizuna_Wriggle_LV4_002
[27] id=Kizuna_Wriggle_LV4_001, package=Kizuna_Wriggle_LV4_001
[28] id=Kizuna_Kasen_LV1_001, package=Kizuna_Kasen_LV1_001
[29] id=Kizuna_Kasen_LV1_002, package=Kizuna_Kasen_LV1_002
[30] id=Kizuna_Kasen_LV2_001, package=Kizuna_Kasen_LV2_001
[31] id=Kizuna_Kasen_LV2_002, package=Kizuna_Kasen_LV2_002
[32] id=Kizuna_Kasen_LV3_001, package=Kizuna_Kasen_LV3_001
[33] id=Kizuna_Kasen_LV3_002, package=Kizuna_Kasen_LV3_002
[34] id=Kizuna_Kasen_LV4_001, package=Kizuna_Kasen_LV4_001
[35] id=Kizuna_Kasen_LV4_002, package=Kizuna_Kasen_LV4_002
[36] id=Kizuna_Keine_LV1_001, package=Kizuna_Keine_LV1_001
[37] id=Kizuna_Keine_LV1_002, package=Kizuna_Keine_LV1_002
[38] id=Kizuna_Keine_LV2_001, package=Kizuna_Keine_LV2_001
[39] id=Kizuna_Keine_LV2_002, package=Kizuna_Keine_LV2_002
[40] id=Kizuna_Keine_LV3_001, package=Kizuna_Keine_LV3_001
[41] id=Kizuna_Keine_LV3_002, package=Kizuna_Keine_LV3_002
[42] id=Kizuna_Keine_LV4_001, package=Kizuna_Keine_LV4_001
[43] id=Kizuna_Keine_LV4_002, package=Kizuna_Keine_LV4_002
[44] id=Kizuna_Akkyu_LV1_002, package=Kizuna_Akkyu_LV1_002
[45] id=Kizuna_Akkyu_LV1_001, package=Kizuna_Akkyu_LV1_001
[46] id=Kizuna_Akkyu_LV2_001, package=Kizuna_Akkyu_LV2_001
[47] id=Kizuna_Akkyu_LV2_002, package=Kizuna_Akkyu_LV2_002
[48] id=Kizuna_Akkyu_LV3_001, package=Kizuna_Akkyu_LV3_001
[49] id=Kizuna_Akkyu_LV3_002, package=Kizuna_Akkyu_LV3_002
[50] id=Kizuna_Akkyu_LV4_001, package=Kizuna_Akkyu_LV4_001
[51] id=Kizuna_Akkyu_LV4_002, package=Kizuna_Akkyu_LV4_002
[52] id=Kizuna_Reimu_LV1_001, package=Kizuna_Reimu_LV1_001
[53] id=Kizuna_Reimu_LV1_002, package=Kizuna_Reimu_LV1_002
[54] id=Kizuna_Reimu_LV2_001, package=Kizuna_Reimu_LV2_001
[55] id=Kizuna_Reimu_LV2_002, package=Kizuna_Reimu_LV2_002
[56] id=Kizuna_Reimu_LV3_001, package=Kizuna_Reimu_LV3_001
[57] id=Kizuna_Reimu_LV3_002, package=Kizuna_Reimu_LV3_002
[58] id=Kizuna_Reimu_LV4_001, package=Kizuna_Reimu_LV4_001
[59] id=Kizuna_Reimu_LV4_002, package=Kizuna_Reimu_LV4_002
[60] id=Kizuna_Suika_LV1_001, package=Kizuna_Suika_LV1_001
[61] id=Kizuna_Suika_LV1_002, package=Kizuna_Suika_LV1_002
[62] id=Kizuna_Suika_LV2_001, package=Kizuna_Suika_LV2_001
[63] id=Kizuna_Suika_LV2_002, package=Kizuna_Suika_LV2_002
[64] id=Kizuna_Suika_LV3_001, package=Kizuna_Suika_LV3_001
[65] id=Kizuna_Suika_LV3_002, package=Kizuna_Suika_LV3_002
[66] id=Kizuna_Suika_LV4_002, package=Kizuna_Suika_LV4_002
[67] id=Kizuna_Suika_LV4_001, package=Kizuna_Suika_LV4_001
[68] id=Kizuna_Tenshi_LV1_001, package=Kizuna_Tenshi_LV1_001
[69] id=Kizuna_Tenshi_LV1_002, package=Kizuna_Tenshi_LV1_002
[70] id=Kizuna_Tenshi_LV2_001, package=Kizuna_Tenshi_LV2_001
[71] id=Kizuna_Tenshi_LV2_002, package=Kizuna_Tenshi_LV2_002
[72] id=Kizuna_Tenshi_LV3_001, package=Kizuna_Tenshi_LV3_001
[73] id=Kizuna_Tenshi_LV3_002, package=Kizuna_Tenshi_LV3_002
[74] id=Kizuna_Tenshi_LV4_001, package=Kizuna_Tenshi_LV4_001
[75] id=Kizuna_Tenshi_LV4_002, package=Kizuna_Tenshi_LV4_002
[76] id=Kizuna_Meirin_LV1_001, package=Kizuna_Meirin_LV1_001
[77] id=Kizuna_Meirin_LV1_002, package=Kizuna_Meirin_LV1_002
[78] id=Kizuna_Meirin_LV2_001, package=Kizuna_Meirin_LV2_001
[79] id=Kizuna_Meirin_LV2_002, package=Kizuna_Meirin_LV2_002
[80] id=Kizuna_Meirin_LV3_001, package=Kizuna_Meirin_LV3_001
[81] id=Kizuna_Meirin_LV3_002, package=Kizuna_Meirin_LV3_002
[82] id=Kizuna_Meirin_LV4_001, package=Kizuna_Meirin_LV4_001
[83] id=Kizuna_Meirin_LV4_002, package=Kizuna_Meirin_LV4_002
[84] id=Kizuna_Cirno_LV1_001, package=Kizuna_Cirno_LV1_001
[85] id=Kizuna_Cirno_LV1_002, package=Kizuna_Cirno_LV1_002
[86] id=Kizuna_Cirno_LV2_001, package=Kizuna_Cirno_LV2_001
[87] id=Kizuna_Cirno_LV2_002, package=Kizuna_Cirno_LV2_002
[88] id=Kizuna_Cirno_LV3_001, package=Kizuna_Cirno_LV3_001
[89] id=Kizuna_Cirno_LV3_002, package=Kizuna_Cirno_LV3_002
[90] id=Kizuna_Cirno_LV4_002, package=Kizuna_Cirno_LV4_002
[91] id=Kizuna_Cirno_LV4_001, package=Kizuna_Cirno_LV4_001
[92] id=Kizuna_Patchouli_LV1_001, package=Kizuna_Patchouli_LV1_001
[93] id=Kizuna_Patchouli_LV1_002, package=Kizuna_Patchouli_LV1_002
[94] id=Kizuna_Patchouli_LV2_001, package=Kizuna_Patchouli_LV2_001
[95] id=Kizuna_Patchouli_LV2_002, package=Kizuna_Patchouli_LV2_002
[96] id=Kizuna_Patchouli_LV3_001, package=Kizuna_Patchouli_LV3_001
[97] id=Kizuna_Patchouli_LV3_002, package=Kizuna_Patchouli_LV3_002
[98] id=Kizuna_Patchouli_LV4_001, package=Kizuna_Patchouli_LV4_001
[99] id=Kizuna_Patchouli_LV4_002, package=Kizuna_Patchouli_LV4_002
[100] id=Kizuna_Mokou_LV1_001, package=Kizuna_Mokou_LV1_001
[101] id=Kizuna_Mokou_LV1_002, package=Kizuna_Mokou_LV1_002
[102] id=Kizuna_Mokou_LV2_001, package=Kizuna_Mokou_LV2_001
[103] id=Kizuna_Mokou_LV2_002, package=Kizuna_Mokou_LV2_002
[104] id=Kizuna_Mokou_LV3_001, package=Kizuna_Mokou_LV3_001
[105] id=Kizuna_Mokou_LV3_002, package=Kizuna_Mokou_LV3_002
[106] id=Kizuna_Mokou_LV4_001, package=Kizuna_Mokou_LV4_001
[107] id=Kizuna_Mokou_LV4_002, package=Kizuna_Mokou_LV4_002
[108] id=Kizuna_Kaguya_LV1_002, package=Kizuna_Kaguya_LV1_002
[109] id=Kizuna_Kaguya_LV1_001, package=Kizuna_Kaguya_LV1_001
[110] id=Kizuna_Kaguya_LV2_001, package=Kizuna_Kaguya_LV2_001
[111] id=Kizuna_Kaguya_LV2_002, package=Kizuna_Kaguya_LV2_002
[112] id=Kizuna_Kaguya_LV3_001, package=Kizuna_Kaguya_LV3_001
[113] id=Kizuna_Kaguya_LV3_002, package=Kizuna_Kaguya_LV3_002
[114] id=Kizuna_Kaguya_LV4_001, package=Kizuna_Kaguya_LV4_001
[115] id=Kizuna_Kaguya_LV4_002, package=Kizuna_Kaguya_LV4_002
[116] id=Kizuna_Tewi_LV1_001, package=Kizuna_Tewi_LV1_001
[117] id=Kizuna_Tewi_LV1_002, package=Kizuna_Tewi_LV1_002
[118] id=Kizuna_Tewi_LV2_002, package=Kizuna_Tewi_LV2_002
[119] id=Kizuna_Tewi_LV2_001, package=Kizuna_Tewi_LV2_001
[120] id=Kizuna_Tewi_LV3_001, package=Kizuna_Tewi_LV3_001
[121] id=Kizuna_Tewi_LV3_002, package=Kizuna_Tewi_LV3_002
[122] id=Kizuna_Tewi_LV4_002, package=Kizuna_Tewi_LV4_002
[123] id=Kizuna_Tewi_LV4_001, package=Kizuna_Tewi_LV4_001
[124] id=Youmu_001, package=Youmu_001
[125] id=Youmu_002, package=Youmu_002
[126] id=Yuyuko_001, package=Yuyuko_001
[127] id=Yuyuko_002, package=Yuyuko_002
[0] id=Main_1_BeastForest_001_Kyouko_Idle_Dialog, package=Main_1_BeastForest_001_Kyouko_Idle_Dialog
[1] id=Main_1_BeastForest_004_Kyouko_Idle_Dialog, package=Main_1_BeastForest_004_Kyouko_Idle_Dialog
[2] id=Main_1_BeastForest_008_Kyouko_Idle_Dialog, package=Main_1_BeastForest_008_Kyouko_Idle_Dialog
[3] id=Side_HumanVillage_Loop_Begin, package=Side_HumanVillage_Loop_Begin
[4] id=Side_HakureiShrine_003_ReimuReply, package=Side_HakureiShrine_003_ReimuReply
[5] id=Side_HakureiShrine_003_SuikaReply, package=Side_HakureiShrine_003_SuikaReply
[6] id=Side_HakureiShrine_003_TenshiReply, package=Side_HakureiShrine_003_TenshiReply
[7] id=Kyouko_EA_Dialog, package=Kyouko_EA_Dialog
[8] id=Main_5_BambooForest_008_Kaguya, package=Main_5_BambooForest_008_Kaguya
[9] id=Main_5_BambooForest_008_Mokou, package=Main_5_BambooForest_008_Mokou
[10] id=Main_5_BambooForest_008_Tewi, package=Main_5_BambooForest_008_Tewi
[11] id=Main_5_BambooForest_010_Kaguya, package=Main_5_BambooForest_010_Kaguya
[12] id=Main_5_BambooForest_010_Mokou, package=Main_5_BambooForest_010_Mokou
[13] id=Main_5_BambooForest_010_Reisen, package=Main_5_BambooForest_010_Reisen
[14] id=Main_5_BambooForest_023_Ask, package=Main_5_BambooForest_023_Ask
[15] id=Main_5_BambooForest_023_Reject, package=Main_5_BambooForest_023_Reject
[16] id=Main_5_BambooForest_027_Notify, package=Main_5_BambooForest_027_Notify
[17] id=Main_5_BambooForest_027_Reject, package=Main_5_BambooForest_027_Reject
[18] id=Main_5_BambooForest_028_Notify, package=Main_5_BambooForest_028_Notify
[19] id=Main_5_BambooForest_028_Reject, package=Main_5_BambooForest_028_Reject
[20] id=ContradictionMission_Dialog, package=ContradictionMission
--- DialogCollectionProfile 'NPCDialogProfile' (176 entries) ---
[0] id=Yokai_Cook_1-A, package=Yokai_Cook_1-A
[1] id=Yokai_Cook_1-B, package=Yokai_Cook_1-B
[2] id=Yokai_Cook_1-C, package=Yokai_Cook_1-C
[3] id=Yokai_Cook_2-A, package=Yokai_Cook_2-A
[4] id=Yokai_Cook_2-B, package=Yokai_Cook_2-B
[5] id=Yokai_Cook_2-C, package=Yokai_Cook_2-C
[6] id=Yokai_Cook_3-A, package=Yokai_Cook_3-A
[7] id=Yokai_Kid_1-A, package=Yokai_Kid_1-A
[8] id=Yokai_Kid_1-B, package=Yokai_Kid_1-B
[9] id=Yokai_Kid_1-C, package=Yokai_Kid_1-C
[10] id=Yokai_Kid_2-A, package=Yokai_Kid_2-A
[11] id=Yokai_Kid_2-B, package=Yokai_Kid_2-B
[12] id=Yokai_Kid_2-C, package=Yokai_Kid_2-C
[13] id=Yokai_Kid_3-A, package=Yokai_Kid_3-A
[14] id=Yokai_Elder_1-A, package=Yokai_Elder_1-A
[15] id=Yokai_Elder_1-B, package=Yokai_Elder_1-B
[16] id=Yokai_Elder_1-C, package=Yokai_Elder_1-C
[17] id=Yokai_Elder_2-A, package=Yokai_Elder_2-A
[18] id=Yokai_Elder_2-B, package=Yokai_Elder_2-B
[19] id=Yokai_Elder_2-C, package=Yokai_Elder_2-C
[20] id=Yokai_Lazy_1-A, package=Yokai_Lazy_1-A
[21] id=Yokai_Lazy_1-B, package=Yokai_Lazy_1-B
[22] id=Yokai_Lazy_1-C, package=Yokai_Lazy_1-C
[23] id=Yokai_Lazy_2-A, package=Yokai_Lazy_2-A
[24] id=Yokai_Lazy_2-B, package=Yokai_Lazy_2-B
[25] id=Yokai_Lazy_2-C, package=Yokai_Lazy_2-C
[26] id=Human_FemaleA_1-A, package=Human_FemaleA_1-A
[27] id=Human_FemaleA_1-B, package=Human_FemaleA_1-B
[28] id=Human_FemaleA_1-C, package=Human_FemaleA_1-C
[29] id=Human_FemaleA_2-A, package=Human_FemaleA_2-A
[30] id=Human_FemaleA_2-B, package=Human_FemaleA_2-B
[31] id=Human_FemaleA_2-C, package=Human_FemaleA_2-C
[32] id=Human_FemaleA_4-A, package=Human_FemaleA_4-A
[33] id=Human_MaleA_1-A, package=Human_MaleA_1-A
[34] id=Human_MaleA_1-B, package=Human_MaleA_1-B
[35] id=Human_MaleA_2-A, package=Human_MaleA_2-A
[36] id=Human_MaleA_2-B, package=Human_MaleA_2-B
[37] id=Human_MaleA_3-A, package=Human_MaleA_3-A
[38] id=Human_Adventurer_1-A, package=Human_Adventurer_1-A
[39] id=Human_Adventurer_1-B, package=Human_Adventurer_1-B
[40] id=Human_Adventurer_1-C, package=Human_Adventurer_1-C
[41] id=Human_Adventurer_2-A, package=Human_Adventurer_2-A
[42] id=Human_Adventurer_2-B, package=Human_Adventurer_2-B
[43] id=Human_Adventurer_2-C, package=Human_Adventurer_2-C
[44] id=Human_Adventurer_3-A, package=Human_Adventurer_3-A
[45] id=Human_FemaleB_A-1-A, package=Human_FemaleB_A-1-A
[46] id=Human_FemaleB_A-1-B, package=Human_FemaleB_A-1-B
[47] id=Human_FemaleB_A-1-C, package=Human_FemaleB_A-1-C
[48] id=Human_FemaleB_A-2-A, package=Human_FemaleB_A-2-A
[49] id=Human_FemaleB_A-2-B, package=Human_FemaleB_A-2-B
[50] id=Human_FemaleB_A-2-C, package=Human_FemaleB_A-2-C
[51] id=Human_FemaleB_A-3-A, package=Human_FemaleB_A-3-A
[52] id=Human_FemaleB_A-3-C, package=Human_FemaleB_A-3-C
[53] id=Human_FemaleB_A-4-A, package=Human_FemaleB_A-4-A
[54] id=Human_MaleB_A-1-A, package=Human_MaleB_A-1-A
[55] id=Human_MaleB_A-1-B, package=Human_MaleB_A-1-B
[56] id=Human_MaleB_A-2-A, package=Human_MaleB_A-2-A
[57] id=Human_MaleB_A-2-B, package=Human_MaleB_A-2-B
[58] id=Yokai_Zashiki_1-A, package=Yokai_Zashiki_1-A
[59] id=Yokai_Zashiki_1-B, package=Yokai_Zashiki_1-B
[60] id=Yokai_Zashiki_1-C, package=Yokai_Zashiki_1-C
[61] id=Yokai_Zashiki_2-A, package=Yokai_Zashiki_2-A
[62] id=Yokai_Zashiki_2-B, package=Yokai_Zashiki_2-B
[63] id=Yokai_Zashiki_2-C, package=Yokai_Zashiki_2-C
[64] id=Human_Kid_Wealthy_1-A, package=Human_Kid_Wealthy_1-A
[65] id=Human_Kid_Wealthy_1-B, package=Human_Kid_Wealthy_1-B
[66] id=Human_Kid_Wealthy_1-C, package=Human_Kid_Wealthy_1-C
[67] id=Human_Kid_Wealthy_2-A, package=Human_Kid_Wealthy_2-A
[68] id=Human_Kid_Wealthy_2-B, package=Human_Kid_Wealthy_2-B
[69] id=Human_Kid_Wealthy_2-C, package=Human_Kid_Wealthy_2-C
[70] id=Human_Kid_Poor_1-A, package=Human_Kid_Poor_1-A
[71] id=Human_Kid_Poor_1-B, package=Human_Kid_Poor_1-B
[72] id=Human_Kid_Poor_1-C, package=Human_Kid_Poor_1-C
[73] id=Human_Kid_Poor_2-A, package=Human_Kid_Poor_2-A
[74] id=Human_Kid_Poor_2-B, package=Human_Kid_Poor_2-B
[75] id=Human_Kid_Poor_2-C, package=Human_Kid_Poor_2-C
[76] id=Akyuu_EA_Dialog, package=Akyuu_EA_Dialog
[77] id=Chen_EA_Dialog, package=Chen_EA_Dialog
[78] id=Kasen_EA_Dialog, package=Kasen_EA_Dialog
[79] id=Keine_EA_Dialog, package=Keine_EA_Dialog
[80] id=Meirin_EA_Dialog, package=Meirin_EA_Dialog
[81] id=Reimu_EA_Dialog, package=Reimu_EA_Dialog
[82] id=Rinnosuke_EA_Dialog, package=Rinnosuke_EA_Dialog
[83] id=Rumia_EA_Dialog, package=Rumia_EA_Dialog
[84] id=Tewi_EA_Dialog, package=Tewi_EA_Dialog
[85] id=Wriggle_EA_Dialog, package=Wriggle_EA_Dialog
[86] id=Human_Male_Alcohol_1-A, package=Human_Male_Alcohol_1-A
[87] id=Human_Male_Alcohol_1-B, package=Human_Male_Alcohol_1-B
[88] id=Human_Male_Alcohol_1-C, package=Human_Male_Alcohol_1-C
[89] id=Human_Male_Alcohol_2-A, package=Human_Male_Alcohol_2-A
[90] id=Human_Male_Alcohol_2-B, package=Human_Male_Alcohol_2-B
[91] id=Human_Male_Alcohol_2-C, package=Human_Male_Alcohol_2-C
[92] id=Human_Male_Alcohol_3-A, package=Human_Male_Alcohol_3-A
[93] id=Human_Female_Elder_1-A, package=Human_Female_Elder_1-A
[94] id=Human_Female_Elder_1-B, package=Human_Female_Elder_1-B
[95] id=Human_Female_Elder_1-C, package=Human_Female_Elder_1-C
[96] id=Human_Female_Elder_2-A, package=Human_Female_Elder_2-A
[97] id=Human_Female_Elder_2-B, package=Human_Female_Elder_2-B
[98] id=Human_Female_Elder_2-C, package=Human_Female_Elder_2-C
[99] id=Human_Female_Elder_3-A, package=Human_Female_Elder_3-A
[100] id=Human_Female_Elder_3-B, package=Human_Female_Elder_3-B
[101] id=Human_Female_Elder_3-C, package=Human_Female_Elder_3-C
[102] id=Human_Female_Elder_4-A, package=Human_Female_Elder_4-A
[103] id=Human_Female_Snob_1-A, package=Human_Female_Snob_1-A
[104] id=Human_Female_Snob_1-B, package=Human_Female_Snob_1-B
[105] id=Human_Female_Snob_1-C, package=Human_Female_Snob_1-C
[106] id=Human_Female_Snob_2-A, package=Human_Female_Snob_2-A
[107] id=Human_Female_Snob_2-B, package=Human_Female_Snob_2-B
[108] id=Human_Female_Snob_2-C, package=Human_Female_Snob_2-C
[109] id=Human_Female_Snob_3-A, package=Human_Female_Snob_3-A
[110] id=Tengu_Journalist_1-A, package=Tengu_Journalist_1-A
[111] id=Tengu_Journalist_1-B, package=Tengu_Journalist_1-B
[112] id=Tengu_Journalist_1-C, package=Tengu_Journalist_1-C
[113] id=Tengu_Journalist_2-A, package=Tengu_Journalist_2-A
[114] id=Tengu_Journalist_2-B, package=Tengu_Journalist_2-B
[115] id=Tengu_Journalist_2-C, package=Tengu_Journalist_2-C
[116] id=Human_Male_Fisherman_1-A, package=Human_Male_Fisherman_1-A
[117] id=Human_Male_Fisherman_1-B, package=Human_Male_Fisherman_1-B
[118] id=Human_Male_Fisherman_1-C, package=Human_Male_Fisherman_1-C
[119] id=Human_Male_Fisherman_2-A, package=Human_Male_Fisherman_2-A
[120] id=Human_Male_Fisherman_2-B, package=Human_Male_Fisherman_2-B
[121] id=Human_Male_Fisherman_2-C, package=Human_Male_Fisherman_2-C
[122] id=Human_Male_Fisherman_3-A, package=Human_Male_Fisherman_3-A
[123] id=Goblin_Full_1-A, package=Goblin_Full_1-A
[124] id=Goblin_Full_1-B, package=Goblin_Full_1-B
[125] id=Goblin_Full_1-C, package=Goblin_Full_1-C
[126] id=Goblin_Full_2-A, package=Goblin_Full_2-A
[127] id=Daiyousei_1-A, package=Daiyousei_1-A
[128] id=Daiyousei_1-B, package=Daiyousei_1-B
[129] id=Daiyousei_1-C, package=Daiyousei_1-C
[130] id=Daiyousei_2-A, package=Daiyousei_2-A
[131] id=Daiyousei_2-B, package=Daiyousei_2-B
[132] id=Daiyousei_2-C, package=Daiyousei_2-C
[133] id=Daiyousei_3-A, package=Daiyousei_3-A
[134] id=Yousei_Unreliable_1-A, package=Yousei_Unreliable_1-A
[135] id=Yousei_Unreliable_1-B, package=Yousei_Unreliable_1-B
[136] id=Yousei_Unreliable_1-C, package=Yousei_Unreliable_1-C
[137] id=Yousei_Unreliable_2-A, package=Yousei_Unreliable_2-A
[138] id=Goblin_Want_2B_Popular_1-A, package=Goblin_Want_2B_Popular_1-A
[139] id=Goblin_Want_2B_Popular_1-B, package=Goblin_Want_2B_Popular_1-B
[140] id=Goblin_Want_2B_Popular_1-C, package=Goblin_Want_2B_Popular_1-C
[141] id=Goblin_Want_2B_Popular_2-A, package=Goblin_Want_2B_Popular_2-A
[142] id=Goblin_Want_2B_Popular_2-B, package=Goblin_Want_2B_Popular_2-B
[143] id=Goblin_Want_2B_Popular_2-C, package=Goblin_Want_2B_Popular_2-C
[144] id=Human_Woodman_1-A, package=Human_Woodman_1-A
[145] id=Human_Woodman_2-A, package=Human_Woodman_2-A
[146] id=Human_Woodman_1-B, package=Human_Woodman_1-B
[147] id=Human_Woodman_2-B, package=Human_Woodman_2-B
[148] id=Human_Woodman_1-C, package=Human_Woodman_1-C
[149] id=Human_Woodman_2-C, package=Human_Woodman_2-C
[150] id=Yokai_Rabbit_Careless_1-A-A, package=Yokai_Rabbit_Careless_1-A-A
[151] id=Yokai_Rabbit_Careless_1-A-B, package=Yokai_Rabbit_Careless_1-A-B
[152] id=Yokai_Rabbit_Careless_1-B-A, package=Yokai_Rabbit_Careless_1-B-A
[153] id=Yokai_Rabbit_Careless_1-B-B, package=Yokai_Rabbit_Careless_1-B-B
[154] id=Yokai_Rabbit_Careless_1-C, package=Yokai_Rabbit_Careless_1-C
[155] id=Yokai_Rabbit_Careless_2-A, package=Yokai_Rabbit_Careless_2-A
[156] id=Yokai_Rabbit_Careless_2-C, package=Yokai_Rabbit_Careless_2-C
[157] id=Lunar_Rabbit_Betrayed_1-A-A, package=Lunar_Rabbit_Betrayed_1-A-A
[158] id=Lunar_Rabbit_Betrayed_1-A-B, package=Lunar_Rabbit_Betrayed_1-A-B
[159] id=Lunar_Rabbit_Betrayed_1-B-A, package=Lunar_Rabbit_Betrayed_1-B-A
[160] id=Lunar_Rabbit_Betrayed_1-C-A, package=Lunar_Rabbit_Betrayed_1-C-A
[161] id=Lunar_Rabbit_Betrayed_2-A, package=Lunar_Rabbit_Betrayed_2-A
[162] id=Lunar_Rabbit_Betrayed_2-B, package=Lunar_Rabbit_Betrayed_2-B
[163] id=Lunar_Rabbit_Betrayed_2-C, package=Lunar_Rabbit_Betrayed_2-C
[164] id=Yokai_Rabbit_Idle_1-A-A, package=Yokai_Rabbit_Idle_1-A-A
[165] id=Yokai_Rabbit_Idle_1-A-B, package=Yokai_Rabbit_Idle_1-A-B
[166] id=Yokai_Rabbit_Idle_1-B-A, package=Yokai_Rabbit_Idle_1-B-A
[167] id=Yokai_Rabbit_Idle_1-B-B, package=Yokai_Rabbit_Idle_1-B-B
[168] id=Yokai_Rabbit_Idle_1-C, package=Yokai_Rabbit_Idle_1-C
[169] id=Yokai_Rabbit_Idle_2-B, package=Yokai_Rabbit_Idle_2-B
[170] id=Yokai_Rabbit_Idle_2-C, package=Yokai_Rabbit_Idle_2-C
[171] id=Goblin_Kongfu_2_A, package=Goblin_Kongfu_2_A
[172] id=Goblin_Kongfu_2_B, package=Goblin_Kongfu_2_B
[173] id=Goblin_Kongfu_2_C, package=Goblin_Kongfu_2_C
[174] id=Goblin_Kongfu_A, package=Goblin_Kongfu_A
[175] id=Goblin_Kongfu_B, package=Goblin_Kongfu_B
--- DialogCollectionProfile 'DLC1_SpecialNPCDialogProfile' (49 entries) ---
[0] id=DLC1_Kizuna_Momizi_LV1_001, package=DLC1_Kizuna_Momizi_LV1_001
[1] id=DLC1_Kizuna_Momizi_LV1_002, package=DLC1_Kizuna_Momizi_LV1_002
[2] id=DLC1_Kizuna_Momizi_LV2_001, package=DLC1_Kizuna_Momizi_LV2_001
[3] id=DLC1_Kizuna_Momizi_LV2_002, package=DLC1_Kizuna_Momizi_LV2_002
[4] id=DLC1_Kizuna_Momizi_LV3_001, package=DLC1_Kizuna_Momizi_LV3_001
[5] id=DLC1_Kizuna_Momizi_LV3_002, package=DLC1_Kizuna_Momizi_LV3_002
[6] id=DLC1_Kizuna_Momizi_LV4_001, package=DLC1_Kizuna_Momizi_LV4_001
[7] id=DLC1_Kizuna_Momizi_LV4_002, package=DLC1_Kizuna_Momizi_LV4_002
[8] id=DLC1_Kizuna_Nitori_LV1_001, package=DLC1_Kizuna_Nitori_LV1_001
[9] id=DLC1_Kizuna_Nitori_LV1_002, package=DLC1_Kizuna_Nitori_LV1_002
[10] id=DLC1_Kizuna_Nitori_LV2_001, package=DLC1_Kizuna_Nitori_LV2_001
[11] id=DLC1_Kizuna_Nitori_LV2_002, package=DLC1_Kizuna_Nitori_LV2_002
[12] id=DLC1_Kizuna_Nitori_LV3_001, package=DLC1_Kizuna_Nitori_LV3_001
[13] id=DLC1_Kizuna_Nitori_LV3_002, package=DLC1_Kizuna_Nitori_LV3_002
[14] id=DLC1_Kizuna_Nitori_LV4_001, package=DLC1_Kizuna_Nitori_LV4_001
[15] id=DLC1_Kizuna_Nitori_LV4_002, package=DLC1_Kizuna_Nitori_LV4_002
[16] id=DLC1_Kizuna_Sanae_LV1_001, package=DLC1_Kizuna_Sanae_LV1_001
[17] id=DLC1_Kizuna_Sanae_LV1_002, package=DLC1_Kizuna_Sanae_LV1_002
[18] id=DLC1_Kizuna_Sanae_LV1_003, package=DLC1_Kizuna_Sanae_LV1_003
[19] id=DLC1_Kizuna_Sanae_LV2_001, package=DLC1_Kizuna_Sanae_LV2_001
[20] id=DLC1_Kizuna_Sanae_LV2_002, package=DLC1_Kizuna_Sanae_LV2_002
[21] id=DLC1_Kizuna_Sanae_LV3_001, package=DLC1_Kizuna_Sanae_LV3_001
[22] id=DLC1_Kizuna_Sanae_LV3_002, package=DLC1_Kizuna_Sanae_LV3_002
[23] id=DLC1_Kizuna_Sanae_LV4_001, package=DLC1_Kizuna_Sanae_LV4_001
[24] id=DLC1_Kizuna_Sanae_LV4_002, package=DLC1_Kizuna_Sanae_LV4_002
[25] id=DLC1_Kizuna_Alice_LV1_001, package=DLC1_Kizuna_Alice_LV1_001
[26] id=DLC1_Kizuna_Alice_LV1_002, package=DLC1_Kizuna_Alice_LV1_002
[27] id=DLC1_Kizuna_Alice_LV2_001, package=DLC1_Kizuna_Alice_LV2_001
[28] id=DLC1_Kizuna_Alice_LV2_002, package=DLC1_Kizuna_Alice_LV2_002
[29] id=DLC1_Kizuna_Alice_LV3_001, package=DLC1_Kizuna_Alice_LV3_001
[30] id=DLC1_Kizuna_Alice_LV3_002, package=DLC1_Kizuna_Alice_LV3_002
[31] id=DLC1_Kizuna_Alice_LV4_001, package=DLC1_Kizuna_Alice_LV4_001
[32] id=DLC1_Kizuna_Alice_LV4_002, package=DLC1_Kizuna_Alice_LV4_002
[33] id=DLC1_Kizuna_Marisa_LV1_001, package=DLC1_Kizuna_Marisa_LV1_001
[34] id=DLC1_Kizuna_Marisa_LV1_002, package=DLC1_Kizuna_Marisa_LV1_002
[35] id=DLC1_Kizuna_Marisa_LV2_001, package=DLC1_Kizuna_Marisa_LV2_001
[36] id=DLC1_Kizuna_Marisa_LV2_002, package=DLC1_Kizuna_Marisa_LV2_002
[37] id=DLC1_Kizuna_Marisa_LV3_001, package=DLC1_Kizuna_Marisa_LV3_001
[38] id=DLC1_Kizuna_Marisa_LV3_002, package=DLC1_Kizuna_Marisa_LV3_002
[39] id=DLC1_Kizuna_Marisa_LV4_001, package=DLC1_Kizuna_Marisa_LV4_001
[40] id=DLC1_Kizuna_Marisa_LV4_002, package=DLC1_Kizuna_Marisa_LV4_002
[41] id=DLC1_Kizuna_Narumi_LV1_001, package=DLC1_Kizuna_Narumi_LV1_001
[42] id=DLC1_Kizuna_Narumi_LV1_002, package=DLC1_Kizuna_Narumi_LV1_002
[43] id=DLC1_Kizuna_Narumi_LV2_001, package=DLC1_Kizuna_Narumi_LV2_001
[44] id=DLC1_Kizuna_Narumi_LV2_002, package=DLC1_Kizuna_Narumi_LV2_002
[45] id=DLC1_Kizuna_Narumi_LV3_001, package=DLC1_Kizuna_Narumi_LV3_001
[46] id=DLC1_Kizuna_Narumi_LV3_002, package=DLC1_Kizuna_Narumi_LV3_002
[47] id=DLC1_Kizuna_Narumi_LV4_001, package=DLC1_Kizuna_Narumi_LV4_001
[48] id=DLC1_Kizuna_Narumi_LV4_002, package=DLC1_Kizuna_Narumi_LV4_002
--- DialogCollectionProfile 'DLC1_GeneralDialogProfile' (10 entries) ---
[0] id=DLC1_Main_MagicForest_004_Marisa, package=DLC1_Main_MagicForest_004_Marisa
[1] id=DLC1_Main_MagicForest_004_Alice, package=DLC1_Main_MagicForest_004_Alice
[2] id=DLC1_Main_Toutetsu_004_Confirm, package=DLC1_Main_Toutetsu_004_Confirm
[3] id=DLC1_Main_Toutetsu_004_Refuse, package=DLC1_Main_Toutetsu_004_Refuse
Failed to dump DialogCollectionProfile contents: Object reference not set to an instance of an object.

*/
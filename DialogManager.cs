using System;
using BepInEx.Logging;
using UnityEngine;
using Common.UI;
using GameData.Profile;
using Il2CppInterop.Runtime;
using Common.DialogUtility;

namespace MetaMystia;

public static class DialogManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[DialogManager.cs]";
    public static DialogPackage ExampleDialog = null;

    public static void BuildAndShow(
        CustomDialogList dialogList,
        System.Action onFinishCallback = null)
    {
        // MetaMiku 注:
        // 这里通过抓取游戏原有的 OnTransitionToNight 对话包作为模板来生成新的对话包
        // 构造对话包是对游戏原有逻辑的简化版，适用于简单的对话展示需求
        // 其中对话的文本内容需要通过 overrideReplaceTextCallback 来替换
        // 使用方法可以参考后面的函数
        // TODO: 【重要】如果显示某个对话时又触发新的对话，可能导致回调混乱
        // TODO: 使用 json 或其他格式来定义对话内容，以便避免硬编码
        // TODO: i18n

        if (dialogList == null)
        {
            UniversalGameManager.OpenDialogMenu(
                null,
                onFinishCallback: onFinishCallback,
                overrideReplaceTextCallback: null,
                previousPanelVisualMode: 0
            );
            return;
        }


        if (ExampleDialog == null)
        {
            DumpExampleDialog();
            if (ExampleDialog == null)
            {
                Log.LogError($"{LOG_TAG} ExampleDialog template is not loaded. Cannot build dialog.");
                return;
            }
        }
        var newDialogPackage = UnityEngine.Object.Instantiate(ExampleDialog);
        var length = dialogList.Count;
        var newMeta = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<DialogMeta>(length);
        for (int i = 0; i < length; i++)
        {
            var dialog = dialogList[i];

            var meta = new DialogMeta();
            
            meta = ExampleDialog.dialogMeta[0];

            var si = meta.speakerIdentity;
            si.speakerType = dialog.speakerType;
            si.speakerId = dialog.characterId;
            si.speakerPortrayalVariationId = dialog.speakerPortrayalVariationId;
            meta.speakerIdentity = si;
            
            meta.dialogId = i;
            meta.speakerPosition = dialog.position;
            newMeta[i] = meta;
        }
        newDialogPackage.dialogMeta = newMeta;
        newDialogPackage.name = dialogList.packageName;

        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
        {
            for (int i = 0; i < length; i++)
            {
                replaceDict[i] = dialogList[i].message;
            }
        };

        UniversalGameManager.OpenDialogMenu(
            newDialogPackage,
            onFinishCallback: onFinishCallback,
            overrideReplaceTextCallback: overrideReplaceTextCallback,
            previousPanelVisualMode: 0
        );
    }
    public static void ShowReadyDialog(bool isReady, System.Action onFinishCallback = null) 
    {
        if (isReady)
        {
            var dialogList = new CustomDialogList();
            dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, "米斯琪——营业时间快要到啦——");
            dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 16, Position.Right, "好呐，我们现在就出发吧~");
            BuildAndShow(dialogList, onFinishCallback);
        }
        else
        {
            var dialogList = new CustomDialogList();
            dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, "等等——还有点事没处理好嘛——");
            dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 16, Position.Right, "没关系呀，现在距离营业时间还有点时间。~");
            BuildAndShow(dialogList, onFinishCallback);
        } // 文案: 余烬特调
    }

    public static void ShowSelectedDialog(string mapLabelM, System.Action onFinishCallback = null) 
    {
        var mapNameM = Utils.GetMapNameCN(mapLabelM);
        var textsM = new[] 
        {
            $"那么，今天就决定是「{mapNameM}」了！",
            $"今天的目的地就设定在「{mapNameM}」吧！",
        };
        var textM = textsM[UnityEngine.Random.Range(0, textsM.Length)];
        
        var dialogList = new CustomDialogList();
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 16, Position.Right, textM);
        BuildAndShow(dialogList, onFinishCallback);
    }

    public static void ShowInformDialog(string mapLabelK, System.Action onFinishCallback = null) 
    {
        var mapNameK = Utils.GetMapNameCN(mapLabelK);
        var textsK = new[] 
        {
            $"让我想想……「{mapNameK}」好像是个好主意！",
            $"就决定是这里啦！「{mapNameK}」！",
        };
        var textK = textsK[UnityEngine.Random.Range(0, textsK.Length)];

        var dialogList = new CustomDialogList();
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, textK);
        BuildAndShow(dialogList, onFinishCallback);

    }

    public static void ShowRejectDialog(string mapLabelM, string mapLabelK, System.Action onFinishCallback = null) 
    {
        var mapNameM = Utils.GetMapNameCN(mapLabelM);
        var textsM = new[] 
        {
            $"所以，今天的计划如何？关于去「{mapNameM}」这件事。",
            $"就这么决定了！目标，「{mapNameM}」，出发！",
        };
        var textM = textsM[UnityEngine.Random.Range(0, textsM.Length)];

        var mapNameK = Utils.GetMapNameCN(mapLabelK);
        var textsK = new[] 
        {
            $"不过米斯琪，「{mapNameK}」会不会好些呢？",
            $"不如还是「{mapNameK}」吧，听着就有趣！",
        };
        var textK = textsK[UnityEngine.Random.Range(0, textsK.Length)];

        var dialogList = new CustomDialogList();
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 16, Position.Right, textM);
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, textK);
        BuildAndShow(dialogList, onFinishCallback);
    }

    public static void ShowConfirmDialog(string mapLabel, System.Action onFinishCallback = null) 
    {
        var mapName = Utils.GetMapNameCN(mapLabel); // Confirm 中不分 M/K
        var textsM = new[] 
        {
            $"所以，今天的计划如何？关于去「{mapName}」这件事。",
            $"就这么决定了！目标，「{mapName}」，出发！",
        };
        var textM = textsM[UnityEngine.Random.Range(0, textsM.Length)];

        var textsK = new[] 
        {
            $"好呀好呀，我们现在就出发吧！",
            $"好——我们现在就走吧——",
        };
        var textK = textsK[UnityEngine.Random.Range(0, textsK.Length)];

        var dialogList = new CustomDialogList();
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 16, Position.Right, textM);
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, textK);
        BuildAndShow(dialogList, onFinishCallback);

    }
    public static void ShowTestDialog(System.Action onFinishCallback = null) 
    {
        var dialogList = new CustomDialogList();
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 2, Position.Right, "你为什么上来就粉评啊，夜雀食堂不是这样的啊！");
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 2, Position.Right, "你应该先慢慢跟我提要求，我猜一猜你的喜好，再偶尔来点绿评暗示我你还不够满意，还嘲讽我「您完全没有文化底蕴是吗」");
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 7, Position.Right, "最后我饭团加好料的时候开始提新的要求，我继续加料说「怎么口味这么刁」，然后给你满足你4个喜好tag的食物和酒水你才正式开启奖励符卡啊！");
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 7, Position.Right, "夜雀食堂里根本不是这样的啊我不接受");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 13, Position.Left, "……");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 13, Position.Left, "米斯琪，你还好吗？");
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 18, Position.Right, "没事的，这只是个测试");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 13, Position.Left, "……");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 16, Position.Left, "……好~");
        BuildAndShow(dialogList, onFinishCallback);
    }
    public static void ShowAnimationDialog()
    {
        var dialogList = new CustomDialogList();
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 4, Position.Right, "夜雀食堂的七大不可思议……");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 4, Position.Right, "<i>（啊…）</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 9, Position.Left, "大家好！这里是神秘的探访频道！");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 1, Position.Right, "<i>（呜…）</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 9, Position.Left, "这是我们的特别节目！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 1, Position.Left, "我们将探访夜雀食堂不为人知的七大不可思议！");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 1, Position.Right, "是……是哦！");
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 1, Position.Right, "这是满足游戏玩家的超级福利单元哦！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 9, Position.Left, "今天我们要为玩家们解开的话题是——");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 9, Position.Left, "夜雀食堂的食材并没有米！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 0, Position.Left, "那么饭团到底是怎么做出来的！？");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 3, Position.Right, "<i>（嗯？）</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 8, Position.Left, "<i>（盯—）</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 2, Position.Left, "今天，在这里！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 2, Position.Left, "请务必！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 1, Position.Left, "务必向大家展示一下好吗？！");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 22, Position.Right, "诶~");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 18, Position.Right, "这，原来是这个意思啊—");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 16, Position.Right, "我，我知道啦");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 2, Position.Left, "是吗？竟然真的打算解释吗！？");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 2, Position.Left, "<i>不不不，我原本只是故意来凑个热闹</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 2, Position.Left, "<i>没想到真的打算说明吗？</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 1, Position.Left, "那可就太好了！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 1, Position.Left, "帮了大忙啦！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 0, Position.Left, "（嗯？）");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 8, Position.Right, "<i>（施法中…）</i>");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 8, Position.Left, "（啊？）");
        dialogList.AddDialog(32, SpeakerIdentity.Identity.Special, 9, Position.Right, "好啦~就是这样~！");
        dialogList.AddDialog(18, SpeakerIdentity.Identity.Special, 8, Position.Left, "你就扯吧！");
        BuildAndShow(dialogList);
    }

    public static void DumpExampleDialog()
    {
        try
        {
            // 该方法直接从 Resources.FindObjectsOfTypeAll 获取内存中的 DialogCollectionProfile 资源，更全更简单
            // 其中 ExampleDialog 为只有 Mystia 的对话模板，可作为基础模板使用
            var dialogPackageType = Il2CppType.Of<GameData.Profile.DialogPackage>();
            var foundAssets = Resources.FindObjectsOfTypeAll(dialogPackageType);

            if (foundAssets == null || foundAssets.Length == 0)
            {
                Log.LogWarning($"{LOG_TAG} No DialogCollectionProfile assets found in memory.");
                return;
            }

            Log.LogInfo($"{LOG_TAG} Found {foundAssets.Length} DialogCollectionProfile asset(s).");

            for (var assetIndex = 0; assetIndex < foundAssets.Length; assetIndex++)
            {
                var dialogPackage = foundAssets[assetIndex].TryCast<GameData.Profile.DialogPackage>();
                if (dialogPackage == null)
                {
                    Log.LogWarning($"{LOG_TAG} Object at index {assetIndex} could not be cast to DialogCollectionProfile.");
                    continue;
                }
                var packageName = dialogPackage.name;
                if (packageName == "OnTransitionToNight")
                {
                    ExampleDialog = dialogPackage;
                    Log.LogInfo($"{LOG_TAG} Stored ExampleDialog(OnTransitionToNight) package.");
                }
                Log.LogDebug($"{LOG_TAG} id={dialogPackage.name}, package={packageName}");
            }
            if (ExampleDialog == null)
            {
                Log.LogWarning($"{LOG_TAG} ExampleDialog(OnTransitionToNight) package not found among loaded assets.");
            }
        }
        catch (Exception e)
        {
            Log.LogError($"{LOG_TAG} Failed to dump DialogCollectionProfile contents: {e.Message}\n{e.StackTrace}");
        }
    }
};

public class CustomDialog
{
    public int characterId;
    public SpeakerIdentity.Identity speakerType;
    public int speakerPortrayalVariationId;
    public string message;
    public Position position;
    public CustomDialog(int characterId, SpeakerIdentity.Identity speakerType, int speakerPortrayalVariationId, Position position, string message)
    {
        this.characterId = characterId;
        this.speakerType = speakerType;
        this.speakerPortrayalVariationId = speakerPortrayalVariationId;
        this.message = message;
        this.position = position;
    }
}

public class CustomDialogList
{
    public System.Collections.Generic.List<CustomDialog> dialogs;
    public string packageName = "MetaMystia_CustomDialogPackage";

    public CustomDialogList()
    {
        dialogs = new System.Collections.Generic.List<CustomDialog>();
    }

    public void AddDialog(int characterId, SpeakerIdentity.Identity speakerType, int speakerPortrayalVariationId, Position position, string message)
    {
        dialogs.Add(new CustomDialog(characterId, speakerType, speakerPortrayalVariationId, position, message));
    }

    public void AddDialog(CustomDialog dialog)
    {
        dialogs.Add(dialog);
    }
    
    public int Count
    {
        get { return dialogs.Count; }
    }
    
    public CustomDialog this[int index]
    {
        get { return dialogs[index]; }
    }

}

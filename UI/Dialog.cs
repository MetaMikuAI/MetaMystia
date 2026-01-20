using Common.DialogUtility;
using Common.UI;
using GameData.Profile;
using System.Collections.Generic;

namespace MetaMystia;

[AutoLog]
public static partial class Dialog
{
    public static DialogPackage ExampleDialog { get; private set; }

    // TODO: support other Dialog MetaAction
    public static DialogPackage BuildDialogPackage(CustomDialogList dialogList)
    {
        if (dialogList == null)
        {
            Log.LogWarning($"BuildDialogPackage called with null dialogList.");
            return null;
        }

        var newDialogPackage = UnityEngine.ScriptableObject.CreateInstance<DialogPackage>();
        var length = dialogList.Count;
        var newMeta = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<DialogMeta>(length);
        for (int i = 0; i < length; i++)
        {
            var dialog = dialogList[i];
            
            var meta = new DialogMeta();

            var si = new SpeakerIdentity();
            si.speakerType = dialog.speakerType;
            si.speakerId = dialog.characterId;
            si.speakerPortrayalVariationId = dialog.speakerPortrayalVariationId;
            meta.speakerIdentity = si;
            
            meta.dialogId = i;
            meta.speakerPosition = dialog.position;

            meta.dialogAction = new DialogAction[0];
            meta.isSpeakInForeground = true;
            meta.isDark = false;
            meta.useNameInText = true;
            meta.useOverrideSprite = false;
            meta.m_OverrideSpriteAsset = null;

            newMeta[i] = meta;
        }
        newDialogPackage.dialogMeta = newMeta;
        newDialogPackage.name = dialogList.packageName;

        return newDialogPackage;
    }

    private static void BuildAndShow(
        CustomDialogList dialogList,
        System.Action onFinishCallback = null)
    {
        var newDialogPackage = BuildDialogPackage(dialogList);
        if (newDialogPackage == null)
        {
            UniversalGameManager.OpenDialogMenu(
                null,
                onFinishCallback: onFinishCallback
            );
            return;
        }


        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
        {
            for (int i = 0; i < dialogList.Count; i++)
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

    public static void DumpExampleDialog()
    {
        Utils.FindAndProcessResources<DialogPackage>(dialogPackage =>
        {
            var packageName = dialogPackage.name;
            if (packageName == "OnTransitionToNight")
            {
                ExampleDialog = dialogPackage;
                Log.LogInfo($"Stored ExampleDialog(OnTransitionToNight) package.");
            }
            Log.LogDebug($"id={dialogPackage.name}, package={packageName}");
        });

        if (ExampleDialog == null)
        {
            Log.LogWarning($"ExampleDialog(OnTransitionToNight) package not found among loaded assets.");
        }
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
        var mapNameM = Utils.GetMapLabelNameCN(mapLabelM);
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

    public static void ShowInformDialog(string mapLabelK, int mapLevelK, System.Action onFinishCallback = null) 
    {
        var mapNameK = Utils.GetMapLabelNameCN(mapLabelK);
        var levelNameK = Utils.GetMapLevelNameCN(mapLevelK);
        var textsK = new[] 
        {
            $"让我想想……「{mapNameK} {levelNameK}」好像是个好主意！",
            $"就决定是这里啦！「{mapNameK} {levelNameK}」！",
        };
        var textK = textsK[UnityEngine.Random.Range(0, textsK.Length)];

        var dialogList = new CustomDialogList();
        dialogList.AddDialog(14, SpeakerIdentity.Identity.Special, 0, Position.Left, textK);
        BuildAndShow(dialogList, onFinishCallback);

    }

    public static void ShowRejectDialog(string mapLabelM, string mapLabelK, System.Action onFinishCallback = null) 
    {
        var mapNameM = Utils.GetMapLabelNameCN(mapLabelM);
        var textsM = new[] 
        {
            $"所以，今天的计划如何？关于去「{mapNameM}」这件事。",
            $"就这么决定了！目标，「{mapNameM}」，出发！",
        };
        var textM = textsM[UnityEngine.Random.Range(0, textsM.Length)];

        var mapNameK = Utils.GetMapLabelNameCN(mapLabelK);
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
        var mapName = Utils.GetMapLabelNameCN(mapLabel); // Confirm 中不分 M/K
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

    public static void ShowResourceExPackage(string packageName, System.Action onFinishCallback = null)
    {
        var dialogList = ResourceExManager.GetDialogPackage(packageName);
        if (dialogList != null)
        {
            BuildAndShow(dialogList, onFinishCallback);
        }
        else
        {
            Log.LogWarning($"Dialog package {packageName} not found in ResourceExManager.");
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
    public List<CustomDialog> dialogs;
    public string packageName = "MetaMystia_CustomDialogPackage";

    public CustomDialogList()
    {
        dialogs = new List<CustomDialog>();
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

    public System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> GetOverrideReplaceTextCallback()
    {
        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
        {
            for (int i = 0; i < Count; i++)
            {
                replaceDict[i] = this[i].message;
            }
        };
        return overrideReplaceTextCallback;
    }
}

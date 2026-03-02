using System.Collections.Generic;

using Common.DialogUtility;
using Common.UI;
using GameData.Profile;

namespace MetaMystia.UI;

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

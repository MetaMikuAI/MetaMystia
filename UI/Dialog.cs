using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Collections.Generic;

using Common.DialogUtility;
using Common.UI;
using GameData.Profile;
using UnityEngine.AddressableAssets;

namespace MetaMystia.UI;

// TODO: Refactor
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

            if (dialog.actions != null && dialog.actions.Length > 0)
            {
                meta.dialogAction = new Il2CppReferenceArray<DialogAction>(dialog.actions.Length);
                for (int j = 0; j < dialog.actions.Length; j++)
                {
                    var action = new DialogAction();
                    action.actionType = dialog.actions[j].actionType;
                    action.shouldSet = dialog.actions[j].shouldSet;

                    // For CG/BG actions, m_SpriteAsset and m_MaterialAsset must not be null
                    // (LoadAssetAllowNull throws NullReferenceException on null input).
                    // Provide empty refs with invalid keys so they safely return null handles.
                    if (dialog.actions[j].actionType == ActionType.CG || dialog.actions[j].actionType == ActionType.BG)
                    {
                        action.m_SpriteAsset = dialog.actions[j].spriteAsset ?? new AssetReferenceSprite("");
                        action.m_MaterialAsset = new AssetReferenceT<UnityEngine.Material>("");
                    }

                    meta.dialogAction[j] = action;
                }
            }
            else
            {
                meta.dialogAction = new Il2CppReferenceArray<DialogAction>(0);
            }

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

        Log.LogInfo("Calling OpenDialogMenu...");
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

public class CustomAction
{
    public ActionType actionType { get; set; }

    /// <summary>
    /// For CG/BG actions: relative path to sprite image (e.g. "assets/CG/painting.png").
    /// Used in ResourceEx JSON config; resolved to <see cref="spriteAsset"/> at load time.
    /// </summary>
    public string sprite { get; set; }

    /// <summary>
    /// Runtime-only: the resolved AssetReferenceSprite for CG/BG actions.
    /// Populated automatically when <see cref="sprite"/> is set during ResourceEx loading.
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public AssetReferenceSprite spriteAsset { get; set; }

    public bool shouldSet { get; set; } = true;
}

public class CustomDialog
{
    public int characterId;
    public SpeakerIdentity.Identity speakerType;
    public int speakerPortrayalVariationId;
    public string message;
    public Position position;
    public CustomAction[] actions;
    public CustomDialog(int characterId, SpeakerIdentity.Identity speakerType, int speakerPortrayalVariationId, Position position, string message, CustomAction[] actions = null)
    {
        this.characterId = characterId;
        this.speakerType = speakerType;
        this.speakerPortrayalVariationId = speakerPortrayalVariationId;
        this.message = message;
        this.position = position;
        this.actions = actions ?? new CustomAction[0];
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

    public void AddDialog(int characterId, SpeakerIdentity.Identity speakerType, int speakerPortrayalVariationId, Position position, string message, CustomAction[] actions = null)
    {
        dialogs.Add(new CustomDialog(characterId, speakerType, speakerPortrayalVariationId, position, message, actions));
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

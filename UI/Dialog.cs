using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Collections.Generic;

using Common.DialogUtility;
using Common.UI;
using GameData.Profile;
using MetaMystia.ResourceEx.Addressables;
using UnityEngine.AddressableAssets;

namespace MetaMystia.UI;

[AutoLog]
public static partial class Dialog
{
    public static DialogPackage ExampleDialog { get; private set; }

    private static DialogAction BuildDialogAction(CustomAction customAction, string packageRoot)
    {
        var action = new DialogAction();
        action.actionType = customAction.actionType;
        action.shouldSet = customAction.shouldSet;

        // Keep native dialog loading paths stable: all asset refs must be non-null.
        action.m_SpriteAsset = new AssetReferenceSprite("");
        action.m_SpriteENAsset = new AssetReferenceSprite("");
        action.m_SpriteJPAsset = new AssetReferenceSprite("");
        action.m_SpriteKOAsset = new AssetReferenceSprite("");
        action.m_SpriteCNTAsset = new AssetReferenceSprite("");
        action.m_MaterialAsset = new AssetReferenceT<UnityEngine.Material>("");
        action.m_BgmPackageAsset = new AssetReferenceT<GameData.Profile.LoopedBGMPackage>("");
        action.m_AudioAsset = new AssetReferenceT<UnityEngine.AudioClip>("");

        if (customAction.actionType == ActionType.CG || customAction.actionType == ActionType.BG)
            action.m_SpriteAsset = ResolveSpriteReference(customAction, packageRoot);

        if (customAction.actionType == ActionType.Sound)
            action.m_AudioAsset = ResolveAudioReference(customAction, packageRoot);

        return action;
    }

    public static DialogPackage BuildDialogPackage(CustomDialogList dialogList)
    {
        if (dialogList == null)
        {
            Log.LogWarning("BuildDialogPackage called with null dialogList.");
            return null;
        }

        var newDialogPackage = UnityEngine.ScriptableObject.CreateInstance<DialogPackage>();
        var length = dialogList.Count;
        var newMeta = new Il2CppReferenceArray<DialogMeta>(length);

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
                    meta.dialogAction[j] = BuildDialogAction(dialog.actions[j], dialogList.packageRoot);
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

    private static AssetReferenceSprite ResolveSpriteReference(CustomAction action, string packageRoot)
    {
        if (action == null || string.IsNullOrEmpty(action.sprite))
            return new AssetReferenceSprite("");

        var key = ResourceExManager.ResolveAssetUri(action.sprite, packageRoot);
        if (string.IsNullOrEmpty(key))
        {
            Log.LogWarning($"Failed to resolve dialog sprite URI: {action.sprite}");
            return new AssetReferenceSprite("");
        }

        var sprite = ResourceExManager.GetSprite(action.sprite, packageRoot);
        if (sprite == null)
        {
            Log.LogWarning($"Dialog sprite URI is not a loaded image: {key}");
            return new AssetReferenceSprite("");
        }

        return RuntimeAddressables.RegisterSprite(key, sprite);
    }

    private static AssetReferenceT<UnityEngine.AudioClip> ResolveAudioReference(CustomAction action, string packageRoot)
    {
        if (action == null || string.IsNullOrEmpty(action.sound))
            return new AssetReferenceT<UnityEngine.AudioClip>("");

        var key = ResourceExManager.ResolveAssetUri(action.sound, packageRoot);
        if (string.IsNullOrEmpty(key))
        {
            Log.LogWarning($"Failed to resolve dialog sound URI: {action.sound}");
            return new AssetReferenceT<UnityEngine.AudioClip>("");
        }

        if (!ResourceExManager.TryGetBytes(action.sound, out var audioBytes, packageRoot))
        {
            Log.LogWarning($"Dialog sound URI is not a loaded asset: {key}");
            return new AssetReferenceT<UnityEngine.AudioClip>("");
        }

        try
        {
            var clip = WavLoader.LoadFromBytes(audioBytes, key);
            return RuntimeAddressables.Register(key, clip);
        }
        catch (System.Exception ex)
        {
            Log.LogWarning($"Failed to decode dialog sound {key}: {ex.Message}");
            return new AssetReferenceT<UnityEngine.AudioClip>("");
        }
    }

    private static void BuildAndShow(CustomDialogList dialogList, System.Action onFinishCallback = null)
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

        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = replaceDict =>
        {
            for (int i = 0; i < dialogList.Count; i++)
                replaceDict[i] = dialogList[i].message;
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
                Log.LogInfo("Stored ExampleDialog(OnTransitionToNight) package.");
            }
            Log.LogDebug($"id={dialogPackage.name}, package={packageName}");
        });

        if (ExampleDialog == null)
            Log.LogWarning("ExampleDialog(OnTransitionToNight) package not found among loaded assets.");
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
}

public class CustomAction
{
    public ActionType actionType { get; set; }

    /// <summary>
    /// For CG/BG actions: relative path to sprite image (e.g. "assets/CG/painting.png").
    /// Prefer a full rex URI in ResourceEx JSON config.
    /// </summary>
    public string sprite { get; set; }

    /// <summary>
    /// For Sound actions: relative path or rex URI to a WAV asset.
    /// </summary>
    public string sound { get; set; }

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
    public string packageRoot;

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

    public int Count => dialogs.Count;

    public CustomDialog this[int index] => dialogs[index];

    public System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> GetOverrideReplaceTextCallback()
    {
        return replaceDict =>
        {
            for (int i = 0; i < Count; i++)
                replaceDict[i] = this[i].message;
        };
    }
}

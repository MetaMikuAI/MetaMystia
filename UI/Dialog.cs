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
                        var srcSprite = dialog.actions[j].spriteAsset;
                        action.m_SpriteAsset = srcSprite ?? new AssetReferenceSprite("");
                        action.m_MaterialAsset = new AssetReferenceT<UnityEngine.Material>("");
                        Log.LogInfo($"[BuildDialog] Action[{i}][{j}] type={dialog.actions[j].actionType}, shouldSet={dialog.actions[j].shouldSet}, spriteAsset={(srcSprite != null ? "set" : "null")}, RuntimeKeyIsValid={action.m_SpriteAsset?.RuntimeKeyIsValid()}");
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
        Log.LogInfo($"[BuildAndShow] Building dialog package...");
        var newDialogPackage = BuildDialogPackage(dialogList);
        if (newDialogPackage == null)
        {
            Log.LogWarning("[BuildAndShow] BuildDialogPackage returned null, calling OpenDialogMenu with null.");
            UniversalGameManager.OpenDialogMenu(
                null,
                onFinishCallback: onFinishCallback
            );
            return;
        }

        Log.LogInfo($"[BuildAndShow] Package built: name={newDialogPackage.name}, meta count={newDialogPackage.dialogMeta?.Length}");

        // Log each meta's actions
        if (newDialogPackage.dialogMeta != null)
        {
            for (int i = 0; i < newDialogPackage.dialogMeta.Length; i++)
            {
                var m = newDialogPackage.dialogMeta[i];
                var actionCount = m.dialogAction?.Length ?? 0;
                Log.LogInfo($"[BuildAndShow] Meta[{i}]: dialogId={m.dialogId}, actions={actionCount}");
                for (int j = 0; j < actionCount; j++)
                {
                    var a = m.dialogAction[j];
                    Log.LogInfo($"[BuildAndShow]   Action[{j}]: type={a.actionType}, shouldSet={a.shouldSet}, m_SpriteAsset={(a.m_SpriteAsset != null ? "set" : "null")}, m_MaterialAsset={(a.m_MaterialAsset != null ? "set" : "null")}");
                    if (a.m_SpriteAsset != null)
                    {
                        try
                        {
                            Log.LogInfo($"[BuildAndShow]   m_SpriteAsset.RuntimeKey={a.m_SpriteAsset.RuntimeKey}, RuntimeKeyIsValid={a.m_SpriteAsset.RuntimeKeyIsValid()}");
                        }
                        catch (System.Exception ex)
                        {
                            Log.LogWarning($"[BuildAndShow]   Failed to read m_SpriteAsset RuntimeKey: {ex.Message}");
                        }
                    }
                }
            }
        }


        System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> overrideReplaceTextCallback = (replaceDict) =>
        {
            for (int i = 0; i < dialogList.Count; i++)
            {
                replaceDict[i] = dialogList[i].message;
            }
        };

        Log.LogInfo("[BuildAndShow] Calling UniversalGameManager.OpenDialogMenu...");
        UniversalGameManager.OpenDialogMenu(
            newDialogPackage,
            onFinishCallback: onFinishCallback,
            overrideReplaceTextCallback: overrideReplaceTextCallback,
            previousPanelVisualMode: 0
        );
        Log.LogInfo("[BuildAndShow] OpenDialogMenu returned.");
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

    /// <summary>
    /// Test dialog that displays a CG image loaded via ModAssetRegistry.
    /// Uses the IResourceProvider pipeline to serve a sprite from disk.
    /// </summary>
    public static void ShowCGTestDialog(string imagePath, System.Action onFinishCallback = null)
    {
        const string cgKey = "mod://test/cg_spring";
        Log.LogInfo($"[CG Test] Starting CG test dialog. imagePath={imagePath}");

        // Ensure ModAssetRegistry is initialized
        if (!ModAssetRegistry.IsInitialized)
        {
            Log.LogInfo("[CG Test] ModAssetRegistry not yet initialized, calling Initialize()...");
            ModAssetRegistry.Initialize();
        }

        // Register the image as a mod sprite via ModAssetRegistry
        Log.LogInfo($"[CG Test] Creating sprite reference from file: {imagePath}");
        var spriteRef = ModAssetRegistry.CreateSpriteReferenceFromFile(
            cgKey, imagePath, new UnityEngine.Vector2(0.5f, 0.5f));

        if (spriteRef == null)
        {
            Log.LogError($"[CG Test] Failed to create sprite reference from: {imagePath}");
            return;
        }
        Log.LogInfo($"[CG Test] Registered CG sprite: key={cgKey}, RuntimeKey={spriteRef.RuntimeKey}, IsValid={spriteRef.RuntimeKeyIsValid()}");

        var dialogList = new CustomDialogList();
        dialogList.packageName = "MetaMystia_CG_Test";

        // Dialog 1: Show CG
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 2, Position.Right,
            "看，这是通过 ModAssetRegistry 加载的 CG 图片！",
            new CustomAction[]
            {
                new CustomAction
                {
                    actionType = ActionType.CG,
                    shouldSet = true,
                    spriteAsset = spriteRef
                }
            });

        // Dialog 2: Continue with CG visible
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 7, Position.Right,
            "IResourceProvider 方案完全生效了，Addressables 标准管线加载自定义 CG 成功！");

        // Dialog 3: Clear CG
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 2, Position.Right,
            "现在清除 CG...",
            new CustomAction[]
            {
                new CustomAction
                {
                    actionType = ActionType.CG,
                    shouldSet = false,
                    spriteAsset = spriteRef
                }
            });

        // Dialog 4: Done
        dialogList.AddDialog(-1, SpeakerIdentity.Identity.Self, 2, Position.Right,
            "CG 测试完毕。");

        Log.LogInfo($"[CG Test] Built dialog list with {dialogList.Count} entries, calling BuildAndShow...");
        BuildAndShow(dialogList, onFinishCallback);
        Log.LogInfo("[CG Test] BuildAndShow called.");
    }

};

public class CustomAction
{
    public ActionType actionType { get; set; }
    /// <summary>
    /// For CG/BG actions: the AssetReferenceSprite to display. 
    /// Use ModAssetRegistry.CreateSpriteReference() to create one from a mod sprite.
    /// </summary>
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

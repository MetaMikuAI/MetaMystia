using System.Collections.Generic;
using Common.UI;
using HarmonyLib;

namespace MetaMystia;


[HarmonyPatch(typeof(Common.UI.UniversalGameManager))]
[AutoLog]
public partial class UniversalGameManagerPatch
{
    [HarmonyPatch(nameof(UniversalGameManager.OpenDialogMenu))]
    [HarmonyPrefix]
    public static bool OpenDialogMenu_Prefix(ref GameData.Profile.DialogPackage dialogPackage, Il2CppSystem.Action onFinishCallback, ref Il2CppSystem.Action<Dictionary<int, string>> overrideReplaceTextCallback, DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode.HideVisual)
    {
        Log.Warning($"OpenDialogMenu_Prefix called for dialogPackage: {dialogPackage?.name} onFinishCallback: {onFinishCallback != null} overrideReplaceTextCallback: {overrideReplaceTextCallback != null} previousPanelVisualMode: {previousPanelVisualMode}");

        if (dialogPackage == null)
        {
            // dialogPackage 为空时，直接调用原方法，将 onFinishCallback 传递下去
            return true;
        }

        if (dialogPackage.dialogContext == null)
        {
            if (Dialog.ExampleDialog == null)
            {
                Dialog.DumpExampleDialog();
            }
            dialogPackage.dialogContext = Dialog.ExampleDialog.dialogContext;
            Log.Info($"Replaced dialogPackage.dialogContext with ExampleDialog.dialogContext");
        }
        if (ResourceExManager.ExistsDialogPackage(dialogPackage.name) && overrideReplaceTextCallback == null)
        {
            UniversalGameManager.OpenDialogMenu(
                dialogPackage,
                onFinishCallback: onFinishCallback,
                overrideReplaceTextCallback: ResourceExManager.GetOverrideReplaceTextCallback(dialogPackage),
                previousPanelVisualMode: previousPanelVisualMode
            );
            return false;
        }

        // MetaMiku 注:
        //     该 hook 用于在 多人模式 中跳过原有 单人模式 下结束白天时的 OnTransitionToNight 对话
        //     直接执行 onFinishCallback?.Invoke() 会有异步问题，导致挂起
        //     使用携带原有 onFinishCallback 回调的空对话包替代原有对话包实现

        // Log.LogInfo($"OpenDialogMenu called with dialogPackage: {dialogPackage?.name}");

        if (!MpManager.IsConnected || dialogPackage?.name != "OnTransitionToNight") // dialogPackage 可能为空
        {
            return true;
        }

        Log.LogInfo($"In multiplayer session and dialogPackage is OnTransitionToNight -> show empty dialog instead");
        UniversalGameManager.OpenDialogMenu(
            null,
            onFinishCallback: onFinishCallback,
            overrideReplaceTextCallback: null,
            previousPanelVisualMode: previousPanelVisualMode
        );
        return false;
    }

    [HarmonyPatch(nameof(UniversalGameManager.LoadScene))]
    [HarmonyPrefix]
    public static void LoadScene_Prefix(Scene scene)
    {
        if (MpManager.IsConnected)
        {
            if (MpManager.LocalScene == Scene.DayScene && scene == Scene.WorkScene)
            {
                Notify.ShowOnMainThread(TextId.ChallengeWarning.Get());
            }
        }
        MpManager.OnSceneTransit(Scene.LoadScene);
        Log.LogInfo($"LoadScene called, scene {scene}");
    }
}

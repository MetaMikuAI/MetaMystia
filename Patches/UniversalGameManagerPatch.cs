using HarmonyLib;
using System.Collections.Generic;
using Common.UI;

namespace MetaMystia;


[HarmonyPatch(typeof(Common.UI.UniversalGameManager))]
public class UniversalGameManagerPatch : PatchBase<UniversalGameManagerPatch>
{
    [HarmonyPatch(nameof(UniversalGameManager.OpenDialogMenu))]
    [HarmonyPrefix]
    public static bool OpenDialogMenu_Prefix(ref GameData.Profile.DialogPackage dialogPackage, Il2CppSystem.Action onFinishCallback, Il2CppSystem.Action<Dictionary<int, string>> overrideReplaceTextCallback = null, DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = DEYU.AdpUISystem.Managers.AdpUIPanelManager.PanelVisualMode.HideVisual)
    {
        // MetaMiku 注:
        //     该 hook 用于在 多人模式 中跳过原有 单人模式 下结束白天时的 OnTransitionToNight 对话
        //     直接执行 onFinishCallback?.Invoke() 会有异步问题，导致挂起
        //     使用携带原有 onFinishCallback 回调的空对话包替代原有对话包实现

        // Log.LogInfo($"{LOG_TAG} OpenDialogMenu called with dialogPackage: {dialogPackage?.name}");
        if (!MpManager.Instance.IsConnected || dialogPackage?.name != "OnTransitionToNight") // dialogPackage 可能为空
        {
            return true;
        }
        
        Log.LogInfo($"{LOG_TAG} In multiplayer session and dialogPackage is OnTransitionToNight -> show empty dialog instead");
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
    public static void LoadScene_Prefix()
    {
        PluginManager.CurrentGameScene = Scene.LoadScene;
        Log.LogInfo($"{LOG_TAG} LoadScene called.");
    }
}
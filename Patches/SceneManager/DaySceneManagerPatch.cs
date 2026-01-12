using Common.UI;
using DayScene;
using HarmonyLib;
using SgrYuki.Utils;

namespace MetaMystia;


[HarmonyPatch(typeof(DayScene.SceneManager))]
[AutoLog]
public partial class DaySceneManagerPatch
{
    [HarmonyPatch(nameof(SceneManager.Awake))]
    [HarmonyPostfix]
    public static void Awake_Postfix()
    {
        PluginManager.CurrentGameScene = Scene.DayScene;
        MpManager.Initialize();
        SceneTransitAction.Send(MpManager.LocalScene);
        Log.LogInfo($"CurrentGameStage switched to DayScene");
    }


    private static bool _skipPatchOnDayOver = false;
    public static void OnDayOver_Original()
    {
        _skipPatchOnDayOver = true;
        if (MpManager.IsGameRoleClient)
        {
            GuestInviteAction.Send(GameData.RunTime.Common.StatusTracker.Instance?.InvitedGuests.ToManagedList());
        }
        Panel.CloseActivePanelsBeforeSceneTransit();
        SceneManager.Instance.OnDayOver();
        _skipPatchOnDayOver = false;
    }

    [HarmonyPatch(nameof(SceneManager.OnDayOver))]
    [HarmonyPrefix]
    public static bool OnDayOver_Prefix()
    {
        Log.LogInfo($"OnDayOver called");
        if (_skipPatchOnDayOver)
        {
            Log.LogDebug($"_skipPatchOnDayOver is true, skipping prefix");
            return true;
        }
        
        if (!MpManager.IsConnected)
        {
            Log.LogDebug($"Not in multiplayer session, skipping prefix");
            return true;
        }
        /*
            [MetaMiku 注]
            状态机: 
                由 01 表示 Mystia 未准备好，而 Kyouko 已准备好
                
                                  00
                               ↙    ↘
                             10        01
                               ↘    ↙
                                  11
    
                00->10, 01->11 为游戏原生触发
                    00->10: 需要跳过 OnDayOver 而显示「准备未完成」对话框
                    01->11: 需要先跳过 OnDayOver 后在显示「准备完成」对话框的回调中执行 OnDayOver
                00->01, 10->11 为 MpManager 触发
                    00->01: 正常更新状态，不触发 OnDayOver_Prefix 也不执行 OnDayOver
                    10->11: 需要先显示「准备完成」对话框再在其回调中执行 OnDayOver
            
            BUG & TODO: 解决当游戏原有结束剧情时的错误处理

            优化(20251216): 
                OnDayOver -> 置 Mystia.Ready 为 true 
                          -> 如果 Kyouko.Ready -> 显示「准备完成」对话框 -> 在回调中调用 OnDayOver(No Patch)
                          -> 否则 -> 显示「准备未完成」对话框 -> 结束
                接收对端   -> 置 Kyouko.Ready 为 true
                                         -> 如果 Mystia.Ready 为 true -> 调用 OnDayOver (此后会在 OnDayOver_Prefix 中显示「准备完成」对话框并回调 OnDayOver(No Patch))
                                         -> 否则 -> pass

        */


        MystiaManager.IsDayOver = true;
        ReadyAction.Send();
        if (KyoukoManager.IsReady)
        {
            Dialog.ShowReadyDialog(true, OnDayOver_Original);
            return false;
        }
        else
        {
            Dialog.ShowReadyDialog(false, null);
            return false;
        }
    }

    [HarmonyPatch(nameof(SceneManager.SwapMap))]
    [HarmonyPrefix]
    public static bool SwapMap_Prefix(SceneManager __instance, string targetMapLabel, string targetMarkerName, int travelCount)
    {
        Log.Info($"SwapMap_Prefix called, targetMapLabel {targetMapLabel}, targetMarkerName {targetMarkerName}");
        if (MpManager.IsConnected && MystiaManager.IsDayOver && !MpManager.InStory)
        {
            return false;
        }
        return true;
    }

    [HarmonyPatch(nameof(SceneManager.SwapMap))]
    [HarmonyPostfix]
    public static void SwapMap_Postfix(SceneManager __instance, string targetMapLabel, string targetMarkerName, int travelCount)
    {
        Log.Debug($"SwapMap_Postfix called, targetMapLabel {targetMapLabel}, targetMarkerName {targetMarkerName}");
    }
}

using System;
using HarmonyLib;

using NightScene.EventUtility;

using MetaMystia.Network;
using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(EventManager))]
[AutoLog]
public static partial class NightSceneEventManagerPatch
{
    private static int? ChallengeSingleRoundDuration = null;

    [HarmonyPatch(nameof(EventManager.Fever))]
    [HarmonyPrefix]
    public static void Fever_Prefix(EventManager __instance, int durationSec)
    {
        Log.Info($"Fever Prefix, durationSec {durationSec}");
        if (QTERewardManagerPatch.BuffLocalTrigger)
        {
            BuffAction.Send(QTEBuff.Fever);
        }
    }

    [HarmonyPatch(nameof(EventManager.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix(EventManager __instance)
    {
        WorkSceneManager.GetWholeNightTimeOriginal = __instance.GetWholeNightTime;
        WorkSceneManager.AllowClientClose = false;
        if (MpManager.IsConnected)
        {
            Func<int> GetWholeNightTime = () => MpManager.WorkTimeSecondOverride;
            __instance.GetWholeNightTime = GetWholeNightTime;
            Log.Info($"Initialize_Postfix called, replaced GetWholeNightTime");
        }
    }

    [HarmonyPatch(nameof(EventManager.StartGuestSpawningAndTiming))]
    [HarmonyPrefix]
    public static void StartGuestSpawningAndTiming_Prefix(EventManager __instance, ref int gameTotalSeconds)
    {
        if (MpManager.IsConnected)
        {
            gameTotalSeconds = __instance.GetWholeNightTime.Invoke();
            Log.InfoCaller($"gameTotalSeconds set to {gameTotalSeconds}s");
        }
    }

    [HarmonyPatch(typeof(GameData.Profile.GeneralTrialChallengeBossData), nameof(GameData.Profile.GeneralTrialChallengeBossData.ExecuteRoundAsync))]
    [HarmonyPrefix]
    public static void ExecuteRoundAsync_Prefix(GameData.Profile.GeneralTrialChallengeBossData __instance, int roundNum)
    {
        Log.InfoCaller($"called, roundNum {roundNum}, time {__instance.singleRoundDuration}");
        // __instance.singleRoundDuration = 360;
    }

    // Youmu challenge time control
    [HarmonyPatch(typeof(GameData.Profile.GeneralTrialChallengeBossData), nameof(GameData.Profile.GeneralTrialChallengeBossData.MainChallengeLoopAsync))]
    [HarmonyPrefix]
    public static void MainChallengeLoopAsync_Prefix(GameData.Profile.GeneralTrialChallengeBossData __instance, GameData.Profile.BossData.BossDataContext bossDataContext)
    {
        ChallengeSingleRoundDuration ??= __instance.singleRoundDuration;
        if (MpManager.IsConnected)
        {
            __instance.singleRoundDuration = ChallengeSingleRoundDuration.Value * 2;
        }
        Log.InfoCaller($"time set to {__instance.singleRoundDuration}s");
    }

    [HarmonyPatch(nameof(EventManager.FundEdit))]
    [HarmonyPrefix]
    public static bool FundEdit_Prefix(EventManager __instance, ref float value, EventManager.MathOperation mathOperation)
    {
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            if (WorkSceneManager.InChallenge && mathOperation == EventManager.MathOperation.Set)
            {
                Log.InfoCaller($"InChallenge and mathOperation set, will not prevent, value {value}");
                return RunOriginal;
            }
            Log.DebugCaller($"prevented, value {value}");
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(EventManager.FundEdit))]
    [HarmonyPostfix]
    public static void FundEdit_Postfix(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        if (MpManager.IsConnectedHost)
        {
            Log.DebugCaller($"value {value}, mathOperation {mathOperation}");
            if (WorkSceneManager.InChallenge && mathOperation == EventManager.MathOperation.Set)
            {
                Log.InfoCaller($"InChallenge and mathOperation set, will not send fund, value {value}");
                return;
            }
            // GuestPayAction.SendFund((int)value, mathOperation);
        }
    }

    [HarmonyPatch(nameof(EventManager.FundEdit))]
    [HarmonyReversePatch]
    public static void FundEdit_Original(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyPrefix]
    public static bool TipEdit_Prefix(EventManager __instance, ref int value, EventManager.ServeType serveType)
    {
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            Log.DebugCaller($"prevented, value {value}, type {serveType}");
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyPostfix]
    public static void TipEdit_Postfix(EventManager __instance, int value, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        if (MpManager.IsConnectedHost)
        {
            if (value == 0) return;
            Log.DebugCaller($"value {value}, serveType {serveType}, comboBuff {comboBuff}, moodBuff {moodBuff}, extraBuff {extraBuff}");
            // GuestPayAction.SendTip(value, serveType, comboBuff, moodBuff, extraBuff);
        }
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyReversePatch]
    public static void TipEdit_Original(EventManager __instance, int value, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        throw new NotImplementedException();
    }

    [HarmonyPatch(nameof(EventManager.ComboEdit))]
    [HarmonyPrefix]
    public static bool ComboEdit_Prefix(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            Log.DebugCaller($"prevented, value {value}, mathOperation {mathOperation}");
            return SkipOriginal;
        }
        return RunOriginal;
    }

    [HarmonyPatch(nameof(EventManager.ComboEdit))]
    [HarmonyPostfix]
    public static void ComboEdit_Postfix(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        if (MpManager.IsConnectedHost)
        {
            Log.DebugCaller($"value {value}, mathOperation {mathOperation}");
            // GuestPayAction.SendCombo((int)value, mathOperation);
        }
    }

    [HarmonyPatch(nameof(EventManager.ComboEdit))]
    [HarmonyReversePatch]
    public static void ComboEdit_Original(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 客机：阻止倒计时归零，等待主机 IzakayaCloseAction 后才允许打烊
    /// </summary>
    [HarmonyPatch(nameof(EventManager.ModifyTotalTime))]
    [HarmonyPrefix]
    public static bool ModifyTotalTime_Prefix(EventManager __instance, int time)
    {
        if (!MpManager.IsConnectedClient || WorkSceneManager.AllowClientClose) return RunOriginal;
        if (time >= 0) return RunOriginal;

        int effectiveRemaining = __instance.TotalCountDown + __instance.extraCountDown;
        if (effectiveRemaining + time <= 0)
        {
            Log.DebugCaller($"Blocked countdown to zero: time={time}, remaining={effectiveRemaining}");
            return SkipOriginal;
        }
        return RunOriginal;
    }

    /// <summary>
    /// 停止生成客人 Loop 并执行打烊（ReversePatch 直接调用原始私有方法）
    /// </summary>
    [HarmonyPatch(typeof(EventManager), "StopInstantiationLoopAndCloseIzakaya")]
    [HarmonyReversePatch]
    public static void StopInstantiationLoopAndCloseIzakaya_Original(EventManager __instance)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 客机：阻止快进（跳过夜晚），仅主机可操作
    /// </summary>
    [HarmonyPatch(typeof(NightScene.UI.WorkSceneSustainedPannel), nameof(NightScene.UI.WorkSceneSustainedPannel.OnFastForwardSubmit))]
    [HarmonyPrefix]
    public static bool OnFastForwardSubmit_Prefix()
    {
        if (MpManager.IsConnectedClient)
        {
            Log.Message("Client attempted to fast forward, blocked");
            return SkipOriginal;
        }
        return RunOriginal;
    }
}

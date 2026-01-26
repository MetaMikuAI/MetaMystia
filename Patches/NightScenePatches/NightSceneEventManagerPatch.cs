
using System;
using HarmonyLib;
using NightScene.EventUtility;
using SgrYuki.Utils;

namespace MetaMystia;

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
        if (MpManager.IsConnected)
        {
            __instance.GetWholeNightTime = WorkSceneManager.GetWholeNightTimeReplaced;
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
        if (MpManager.IsConnectedHost)
        {
            var newValue = (float)Math.Round(value * MpManager.MultiplayerFundModifier);
            Log.DebugCaller($"value {value} => {newValue}");
            value = newValue;
        }
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            if (WorkSceneManager.InChallenge && mathOperation == EventManager.MathOperation.Set)
            {
                Log.InfoCaller($"InChallenge and mathOperation set, will not prevent, value {value}");
                return true;
            }
            Log.DebugCaller($"prevented, value {value}");
            return false;
        }
        return true;
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
            GuestPayAction.SendFund((int)value, mathOperation);
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
        if (MpManager.IsConnectedHost)
        {
            int newValue = (int)(value * MpManager.MultiplayerTipModifier);
            Log.DebugCaller($"value {value} => {newValue}");
            value = newValue;
            if (newValue == 0) return false;
        }
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            Log.DebugCaller($"prevented, value {value}, type {serveType}");
            return false;
        }
        return true;
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyPostfix]
    public static void TipEdit_Postfix(EventManager __instance, int value, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        if (MpManager.IsConnectedHost)
        {
            if (value == 0) return;
            Log.DebugCaller($"value {value}, serveType {serveType}, comboBuff {comboBuff}, moodBuff {moodBuff}, extraBuff {extraBuff}");
            GuestPayAction.SendTip(value, serveType, comboBuff, moodBuff, extraBuff);
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
            return false;
        }
        return true;
    }

    [HarmonyPatch(nameof(EventManager.ComboEdit))]
    [HarmonyPostfix]
    public static void ComboEdit_Postfix(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        if (MpManager.IsConnectedHost)
        {
            Log.DebugCaller($"value {value}, mathOperation {mathOperation}");
            GuestPayAction.SendCombo((int)value, mathOperation);
        }
    }

    [HarmonyPatch(nameof(EventManager.ComboEdit))]
    [HarmonyReversePatch]
    public static void ComboEdit_Original(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        throw new NotImplementedException();
    }
}

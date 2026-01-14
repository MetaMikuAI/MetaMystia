
using HarmonyLib;
using NightScene.EventUtility;

namespace MetaMystia;

[HarmonyPatch(typeof(NightScene.EventUtility.EventManager))]
[AutoLog]
public static partial class NightSceneEventManagerPatch
{
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
            Log.Info($"StartGuestSpawningAndTiming_Prefix called, gameTotalSeconds set to {gameTotalSeconds}s");
        }
    }

    [HarmonyPatch(nameof(EventManager.FundEdit))]
    [HarmonyPrefix]
    public static bool FundEdit_Prefix(EventManager __instance, float value)
    {
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            Log.Info($"FundEdit_Prefix prevented, value {value}");
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
            Log.Info($"FundEdit_Postfix called, value {value}, mathOperation {mathOperation}");
            GuestPayAction.SendFund((int)value);
        }
    }

    [HarmonyPatch(nameof(EventManager.FundEdit))]
    [HarmonyReversePatch]
    public static void FundEdit_Original(EventManager __instance, float value, EventManager.MathOperation mathOperation)
    {
        throw new System.NotImplementedException();
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyPrefix]
    public static bool TipEdit_Prefix(EventManager __instance, int value, EventManager.ServeType serveType)
    {
        if (MpManager.IsConnectedClient && !MpManager.InStory)
        {
            Log.Debug($"TipEdit_Prefix prevented, value {value}, type {serveType}");
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
            Log.Debug($"TipEdit_Postfix called, value {value}, serveType {serveType}, comboBuff {comboBuff}, moodBuff {moodBuff}, extraBuff {extraBuff}");
            GuestPayAction.SendTip(value, serveType, comboBuff, moodBuff, extraBuff);
        }
    }

    [HarmonyPatch(nameof(EventManager.TipEdit))]
    [HarmonyReversePatch]
    public static void TipEdit_Original(EventManager __instance, int value, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        throw new System.NotImplementedException();
    }

}
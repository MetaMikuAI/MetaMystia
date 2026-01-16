
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
}
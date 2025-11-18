using HarmonyLib;
using UnityEngine;
using Common.CharacterUtility;
using BepInEx.Logging;
using DayScene.Input;
using GameData.RunTime.Common;
using DayScene;
using System.Collections.Generic;

namespace MetaMystia;

[HarmonyPatch(typeof(CharacterControllerInputGeneratorComponent))]
public class CharacterInputPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(CharacterControllerInputGeneratorComponent.UpdateInputDirection))]
    [HarmonyPrefix]
    public static void UpdateInputDirection_Prefix(CharacterControllerInputGeneratorComponent __instance, Vector2 inputDirection)
    {
        try
        {
            var playerInputGenerator = MystiaManager.Instance.GetInputGenerator();
            if (playerInputGenerator != null && __instance == playerInputGenerator)
            {
                MultiplayerManager.Instance.SendMoveData(inputDirection);
            }
        }
        catch (System.Exception e)
        {
            Log.LogError($"Error in UpdateInputDirection_Prefix: {e.Message}");
        }
    }
}

[HarmonyPatch(typeof(DayScenePlayerInputGenerator))]
public class DayScenePlayerInputPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintPerformed))]
    [HarmonyPrefix]
    public static void OnSprintPerformed_Prefix()
    {
        MultiplayerManager.Instance.SendSprintData(true);
    }

    [HarmonyPatch(nameof(DayScenePlayerInputGenerator.OnSprintCanceled))]
    [HarmonyPrefix]
    public static void OnSprintCanceled_Prefix()
    {
        MultiplayerManager.Instance.SendSprintData(false);
    }
}

[HarmonyPatch(typeof(RunTimeScheduler))]
public class RunTimeSchedulerPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(RunTimeScheduler.OnEnterDaySceneMap))]
    [HarmonyPostfix]
    public static void OnEnterDaySceneMap_Postfix()
    {
        MystiaManager.Instance.UpdateMapLabel();
        MultiplayerManager.Instance.SendMapLabel();
        KyoukoManager.Instance.UpdateVisibility();
    }
}

[HarmonyPatch(typeof(DaySceneMap))]
public class DaySceneMapPatch
{
    private static ManualLogSource Log => Plugin.Instance.Log;

    [HarmonyPatch(nameof(DaySceneMap.SolveAndUpdateCharacterPositionInternal))]
    [HarmonyPostfix]
    public static void SolveAndUpdateCharacterPositionInternal_Postfix(DaySceneMap __instance, GameData.RunTime.DaySceneUtility.Collection.TrackedNPC npc, DayScene.Interactables.Collections.ConditionComponents.CharacterConditionComponent character, ref bool isNPCOnMap, bool changeRotation)
    {
        try
        {
            if (npc == null || character == null)
            {
                return;
            }

            string npcKey = npc.key;
            if (string.IsNullOrEmpty(npcKey))
            {
                return;
            }

            var persistentNPCKeys = new HashSet<string> { "Kyouko" };

            if (persistentNPCKeys.Contains(npcKey) && MultiplayerManager.Instance.IsConnected())
            {
                isNPCOnMap = true;
                Log.LogMessage($"Force visible: {npcKey}");
            }
        }
        catch (System.Exception e)
        {
            Log.LogError($"Error in SolveAndUpdateCharacterPositionInternal_Postfix: {e.Message}");
        }
    }
}

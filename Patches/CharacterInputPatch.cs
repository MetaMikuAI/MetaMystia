using Common.CharacterUtility;
using Common.UI;
using HarmonyLib;
using UnityEngine;


namespace MetaMystia;

[HarmonyPatch(typeof(Common.CharacterUtility.CharacterControllerInputGeneratorComponent))]
[AutoLog]
public partial class CharacterInputPatch
{
    [HarmonyPatch(nameof(CharacterControllerInputGeneratorComponent.UpdateInputDirection))]
    [HarmonyPrefix]
    public static void UpdateInputDirection_Prefix(CharacterControllerInputGeneratorComponent __instance, ref Vector2 inputDirection)
    {
        if (!MpManager.IsConnected)
        {
            return;
        }

        if (MpManager.LocalScene != Scene.DayScene && MpManager.LocalScene != Scene.WorkScene)
        {
            return;
        }

        if (PluginManager.Console != null && PluginManager.Console.IsOpen)
        {
            inputDirection = Vector2.zero;
        }

        try
        {
            var characterCollection = Common.SceneDirector.Instance.characterCollection;
            if (!characterCollection.ContainsKey("Self"))
            {
                Log.LogWarning($"characterCollection does not contain 'Self' key");
                return;
            }
            if (__instance.name == characterCollection["Self"].name)
            {
                MystiaManager.InputDirection = inputDirection;
                SyncAction.Send();
            }
        }
        catch (System.Exception e)
        {
            Log.LogError($"Error in UpdateInputDirection_Prefix: {e.Message}");
        }
    }
}
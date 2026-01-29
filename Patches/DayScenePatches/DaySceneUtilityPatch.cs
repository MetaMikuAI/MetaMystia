
using GameData.RunTime.DaySceneUtility.Collection;
using HarmonyLib;
using MetaMystia.Network;
namespace MetaMystia;

[HarmonyPatch]
[AutoLog]
public static partial class DaySceneUtilityPatch
{
    [HarmonyPatch(typeof(GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable), nameof(TrackedCollectable.Collect))]
    [HarmonyPostfix]
    public static void Collect_Postfix(TrackedCollectable __instance)
    {
        if (MpManager.IsConnected)
        {
            GetCollectableAction.Send(__instance.key);
        }
    }

    [HarmonyPatch(typeof(GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable), nameof(TrackedCollectable.Collect))]
    [HarmonyReversePatch]
    public static void Collect_Original(TrackedCollectable __instance)
    {
        throw new System.NotImplementedException();
    }
}

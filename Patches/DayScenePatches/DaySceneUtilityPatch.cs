// MetaMiku: 这是用于 采集同步 的补丁，暂时废弃，后续可能重新启用


using HarmonyLib;

using GameData.RunTime.DaySceneUtility.Collection;

using MetaMystia.Network;

namespace MetaMystia.Patch;

[HarmonyPatch]
[AutoLog]
public static partial class DaySceneUtilityPatch
{
    // [HarmonyPatch(typeof(GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable), nameof(TrackedCollectable.Collect))]
    // [HarmonyPostfix]
    // public static void Collect_Postfix(TrackedCollectable __instance)
    // {
    //     if (MpManager.IsConnected)
    //     {
    //         GetCollectableAction.Send(__instance.key);
    //     }
    // }

    // [HarmonyPatch(typeof(GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable), nameof(TrackedCollectable.Collect))]
    // [HarmonyReversePatch]
    // public static void Collect_Original(TrackedCollectable __instance)
    // {
    //     throw new System.NotImplementedException();
    // }
}

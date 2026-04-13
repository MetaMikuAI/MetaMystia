using HarmonyLib;

using static MetaMystia.Patch.HarmonyPrefixFlow;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestsManager))]
[AutoLog]
public partial class GuestsManagerPatch
{

}

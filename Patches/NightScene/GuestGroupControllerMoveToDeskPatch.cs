using HarmonyLib;

using NightScene.GuestManagementUtility;

using static MetaMystia.Patch.HarmonyPrefixFlow;


namespace MetaMystia.Patch;

[HarmonyPatch(typeof(NightScene.GuestManagementUtility.GuestGroupController.__c__DisplayClass295_0))]
[TracePatch("Method_Internal_Void_PDM_0", DisplayName = "GuestGroupController.OnArrive")]
[AutoLog]
public partial class GuestGroupController__c__DisplayClass295_0Patch
{
    // 注：如果一个 Group 包含两个 CharacterSprite 则可能触发两次 OnArrive
    // RVA = 0x1804EB2A0 in Release 4.3.0c
}

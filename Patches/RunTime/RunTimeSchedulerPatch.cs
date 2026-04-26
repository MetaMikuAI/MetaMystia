using HarmonyLib;

using GameData.RunTime.Common;
using MetaMystia.Network;


namespace MetaMystia.Patch;

[HarmonyPatch(typeof(GameData.RunTime.Common.RunTimeScheduler))]
[AutoLog]
[TracePatch("Method_Internal_Static_Void_Action_PDM_0", DisplayName = "ReimuProtection")]
public partial class RunTimeSchedulerPatch
{
    public static bool DuringReimuProtection = false;
    
    // <AddReimuPositiveSpellToWorkScene>g__ReimuProtection|160_0(Action onFinish)
    // VA = 0x18064F250 in Release 4.3.0c
    [HarmonyPatch("Method_Internal_Static_Void_Action_PDM_0")]
    [HarmonyPrefix]
    public static void ReimuProtection_Prefix()
    {
        Log.Warning("ReimuProtection prefix called.");
        DuringReimuProtection = true;
    }
    
    [HarmonyPatch("Method_Internal_Static_Void_Action_PDM_0")]
    [HarmonyPostfix]
    public static void ReimuProtection_Postfix()
    {
        Log.Warning("ReimuProtection postfix called.");
        DuringReimuProtection = false;
    }
}

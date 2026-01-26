using Common.UI;
using HarmonyLib;
using SgrYuki;
namespace MetaMystia;

[HarmonyPatch(typeof(Common.UI.ReceivedObjectDisplayerController))]
[AutoLog]
public static partial class ReceivedObjectDisplayerControllerPatch
{
    [HarmonyPatch(nameof(ReceivedObjectDisplayerController.NotifyTextMessage))]
    [HarmonyPostfix]
    public static void NotifyTextMessage_Postfix(string content)
    {
        NotifyOverlay.CacheTMPUGUI(content);
    }
}

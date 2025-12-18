using BepInEx.Logging;
using GameData.Profile;
using Common.UI;

namespace MetaMystia;

public static class Notify
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[Notify.cs]";

    public static void Show(string text)
    {
        ReceivedObjectDisplayerController.Instance.NotifyTextMessage(text);   
    }
}
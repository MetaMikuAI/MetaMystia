using BepInEx.Logging;
using Common.UI;

namespace MetaMystia;

[AutoLog]
public static partial class Notify
{

    // Note: should run on main thread
    public static void Show(string text)
    {
        try
        {
            ReceivedObjectDisplayerController.Instance.NotifyTextMessage(text);
        } 
        catch
        {
            Log.LogWarning($"notify {text} failed");
        }
    }

    public static void ShowOnMainThread(string text)
    {
        PluginManager.Instance.RunOnMainThread(() => Show(text));
    }
}
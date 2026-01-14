using System.Collections.Generic;
using System.Linq;
using Common.UI;

namespace MetaMystia;

[AutoLog]
public static partial class Notify
{
    public readonly static List<Scene> NotAvailableScenes = [Scene.IzakayaPrepScene, Scene.LoadScene, Scene.MainScene];
    public static bool CanNotify(Scene scene) => !NotAvailableScenes.Any((s) => s == scene);
    public static bool CanNotify() => CanNotify(MpManager.LocalScene);

    // Note: should run on main thread
    public static void Show(string text)
    {
        if (!CanNotify()) return;
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

    public static void ShowOnNextAvailableScene(string text)
    {
        SgrYuki.Utils.CommandScheduler.Enqueue(CanNotify, () => Show(text));
    }
}
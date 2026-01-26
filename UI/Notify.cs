using System;
using System.Collections.Generic;
using System.Linq;
using Common.UI;
using SgrYuki;

namespace MetaMystia;

[AutoLog]
public static partial class Notify
{
    private readonly static List<Scene> NotAvailableScenes = [Scene.IzakayaPrepScene, Scene.LoadScene, Scene.MainScene, Scene.EmptyScene];
    private static bool CanNotify(Scene scene) => !NotAvailableScenes.Any((s) => s == scene);
    public static bool CanNotify() => CanNotify(MpManager.LocalScene);

    public static ReceivedObjectDisplayerController Instance => DEYU.Singletons.MonoSingleton<ReceivedObjectDisplayerController>.Instance;

    [OnMainThread]
    public static void Show(string text)
    {
        if (!CanNotify())
        {
            ShowExtern(text);
            return;
        }
        try
        {
            Log.InfoCaller(text);
            ReceivedObjectDisplayerController.Instance?.NotifyTextMessage(text);
        }
        catch
        {
            Log.WarningCaller($"notify {text} failed");
        }
    }

    [OnMainThread]
    public static void ShowExtern(string text)
    {
        Log.InfoCaller(text);
        NotifyOverlay.Show(text);
    }

    public static void ShowOnMainThread(string text)
    {
        PluginManager.Instance.RunOnMainThread(() => Show(text));
    }

    public static void ShowExternOnMainThread(string text)
    {
        PluginManager.Instance.RunOnMainThread(() => ShowExtern(text));
    }

    public static void ShowOnNextAvailableScene(string text, Action afterShow = null)
    {
        SgrYuki.Utils.CommandScheduler.Enqueue(
            executeWhen: CanNotify,
            execute: () =>
            {
                Show(text);
                afterShow?.Invoke();
            },
            timeoutSeconds: 300
        );
    }
}

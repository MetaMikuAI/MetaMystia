using GameData.Profile;
using GameData.Core.Collections.DaySceneUtility;

namespace MetaMystia;


public static partial class ResourceExManager
{
    public static bool ExistsDialogPackage(string name)
    {
        return _dialogPackageConfigs.ContainsKey(name);
    }

    public static CustomDialogList GetDialogPackage(string name)
    {
        if (_dialogPackageConfigs.TryGetValue(name, out var pkg))
        {
            return pkg;
        }
        return null;
    }

    public static DialogPackage GetBuiltDialogPackage(string name)
    {
        if (_builtDialogPackages.TryGetValue(name, out var pkg))
        {
            return pkg;
        }
        Log.Warning($"Dialog package not built: {name}");
        return null;
    }

    private static void BuildAllDialogPackages()
    {
        foreach (var kvp in _dialogPackageConfigs)
        {
            _builtDialogPackages[kvp.Key] = Dialog.BuildDialogPackage(kvp.Value);
            // DataBaseDay.allDialogPackages[kvp.Key] = _builtDialogPackages[kvp.Key]; // 尚未初始化
            Log.Info($"Built dialog package: {kvp.Key}");
        }
    }

    private static void RegisterAllDialogPackages()
    {
        foreach (var kvp in _builtDialogPackages)
        {
            DataBaseDay.allDialogPackages[kvp.Key] = kvp.Value;
            Log.Info($"Registered dialog package to DataBaseDay: {kvp.Key}");
        }
    }

    public static System.Action<Il2CppSystem.Collections.Generic.Dictionary<int, string>> GetOverrideReplaceTextCallback(GameData.Profile.DialogPackage dialogPackage)
    {
        if (dialogPackage == null) return null;

        string name;
        try
        {
            name = dialogPackage.name;
        }
        catch
        {
            return null;
        }

        if (string.IsNullOrEmpty(name)) return null;

        if (_dialogPackageConfigs.TryGetValue(name, out var config))
        {
            return config.GetOverrideReplaceTextCallback();
        }
        return null;
    }
}

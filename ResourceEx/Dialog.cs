using MetaMystia.ResourceEx.Models;
using System.Collections.Generic;
using System.Linq;

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

    public static void BuildAllDialogPackages()
    {
        foreach (var kvp in _dialogPackageConfigs)
        {
            _builtDialogPackages[kvp.Key] = Dialog.BuildDialogPackage(kvp.Value);
            Log.Info($"Built dialog package: {kvp.Key}");
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

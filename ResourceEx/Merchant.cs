using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

using GameData.Core.Collections.DaySceneUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility;

using static GameData.Core.Collections.DaySceneUtility.Collections.Merchant;


using SgrYuki.Utils;
using MetaMystia.ResourceEx.Models;
using MetaMystia.ResourceEx.Mappers;

namespace MetaMystia;


public static partial class ResourceExManager
{
    private static void RegisterAllTrackedMerchant()
    {
        Log.Info("Registering all tracked merchants...");
        MerchantConfigs.Values.ToList().ForEach(RegisterTrackedMerchant);
    }

    private static void RegisterTrackedMerchant(MerchantConfig config)
    {
        RunTimeDayScene.trackedMerchants[config.key] = config.GenTrackedMerchant();
        Log.Info($"Registered tracked merchant {config.key} with {config.merchandise.Count} products.");
    }

    public static void BuildAllMerchants() => MerchantConfigs.Values.ToList().ForEach(BuildMerchant);

    public static void BuildMerchant(MerchantConfig config)
    {
        var newMerchant = DataBaseDay.allMerchants.Values.GetEnumerator().Current;

        newMerchant.key = config.key;

        newMerchant.welcomeDialogPackage = config.welcomeDialogPackageNames.Select(GetBuiltDialogPackage).ToIl2CppReferenceArray();
        newMerchant.nullDialogPackage = config.nullDialogPackageNames.Select(GetBuiltDialogPackage).ToIl2CppReferenceArray();
        newMerchant.priceMultiplierRange = new UnityEngine.Vector2(config.priceMultiplierMin, config.priceMultiplierMax);
        newMerchant.leastSellNum = config.leastSellNum;

        newMerchant.merchandiseCollection = config.merchandise.Select(m => m.ToMerchandise()).ToIl2CppReferenceArray();

        _builtMerchants[config.key] = newMerchant;
        DataBaseDay.allMerchants[config.key] = newMerchant;
        Log.Info($"Built merchant {config.key}.");
    }

    public static bool TryGetExMerchantData(string key, out Merchant merchant)
    {
        if (_builtMerchants.TryGetValue(key, out merchant))
        {
            return true;
        }
        merchant = default;
        return false;
    }
}

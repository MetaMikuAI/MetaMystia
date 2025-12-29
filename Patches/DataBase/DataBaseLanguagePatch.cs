
using HarmonyLib;
using System.Collections.Generic;
using GameData.CoreLanguage.Collections;

namespace MetaMystia;

[HarmonyPatch(typeof(GameData.CoreLanguage.Collections.DataBaseLanguage))]
[AutoLog]
public partial class DataBaseLanguagePatch
{
    public static Dictionary<int, Dictionary<int, string>> FoodRequestsToRegister = new Dictionary<int, Dictionary<int, string>>();
    
    [HarmonyPatch(nameof(DataBaseLanguage.Initialize))]
    [HarmonyPostfix]
    public static void Initialize_Postfix()
    {
        Log.LogInfo("DataBaseLanguage.Initialize Postfix called.");
        foreach (var kvp in FoodRequestsToRegister)
        {
            var id = kvp.Key;
            
            var foodRequests = new Il2CppSystem.Collections.Generic.Dictionary<int, string>();
            foreach (var req in kvp.Value)
            {
                foodRequests.Add(req.Key, req.Value);
            }
            var success = DataBaseLanguage.SpecialGuestFoodRequest.TryAdd(id, foodRequests);
            Log.LogWarning($"Registered Food Requests for Special Guest ID {id}: {success}");
            if (!success)
            {
                Log.LogError($"Failed to register Food Requests for Special Guest ID {id}");
            }
        }
    }
}
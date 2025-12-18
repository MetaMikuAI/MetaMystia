using BepInEx.Logging;
using DEYU.Utils;
using Il2CppSystem.IO;
using NightScene.CookingUtility;
using System.Linq;

using MetaMystia;


public static class CookManager
{
    
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[CookManager.cs]";

    public static CookController GetCookerControllerByIndex(int gridIndex)
    {
        var AllCookerControllers = CookSystemManager.Instance.AllCookerControllers;
        var query = from cooker in AllCookerControllers.ToArray() 
                    where cooker.GridIndex == gridIndex
                    select cooker;
        return query.FirstOrDefault();
    }
}
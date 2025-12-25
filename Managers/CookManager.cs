using BepInEx.Logging;
using DEYU.Utils;
using Il2CppSystem.IO;
using NightScene.CookingUtility;
using System.Linq;

namespace MetaMystia;

[AutoLog]
public static partial class CookManager
{
    public static CookController GetCookerControllerByIndex(int gridIndex)
    {
        var AllCookerControllers = CookSystemManager.Instance?.AllCookerControllers;
        if (AllCookerControllers == null)
        {
            return null;
        }
        var query = from cooker in AllCookerControllers.ToArray() 
                    where cooker.GridIndex == gridIndex
                    select cooker;
        return query.FirstOrDefault();
    }
}
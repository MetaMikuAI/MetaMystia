using System;
using System.Collections.Concurrent;
using BepInEx.Logging;
using MetaMystia;
using NightScene.GuestManagementUtility;

using static NightScene.GuestManagementUtility.GuestsManager;

public static class GuestManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[GuestManager.cs]";

    private static ConcurrentDictionary<string, GuestGroupController> guests = new(); 
    private static ConcurrentDictionary<GuestGroupController, string> guestIds = new();
    public static ConcurrentQueue<(OrderBase, string)> orders = new();
    
    public static string StoreGuest(GuestGroupController guest)
    {
        string uuid = Guid.NewGuid().ToString();
        guests[uuid] = guest;
        guestIds[guest] = uuid;
        return uuid;
    }

    public static void StoreGuest(GuestGroupController guest, string uuid)
    {
        guests[uuid] = guest;
        guestIds[guest] = uuid;
    }

    public static string GetGuestUUID(GuestGroupController guest)
    {
        if (guest == null)
        {
            Log.LogError($"{LOG_TAG} guest is null!");
            return "";
        }
        return guestIds[guest];
    }

    public static GuestGroupController GetGuest(string uuid)
    {
        return guests[uuid]?? null;
    }
}
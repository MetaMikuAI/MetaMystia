using UnityEngine;
using BepInEx.Logging;
using Common.CharacterUtility;
using NightScene.GuestManagementUtility;
using Common.UI;
using Il2CppSystem.Collections.Generic;
using GameData.Core.Collections.NightSceneUtility;
using NightScene.EventUtility;

using MetaMystia;
using Il2CppSystem.IO;

public static class SpawnGuestsManager
{
    private static ManualLogSource Log => Plugin.Instance.Log;
    private static readonly string LOG_TAG = "[SpawnGuestsManager.cs]";
    
    // public static void SpawnAndSyncNormalGuests()
    // {
    //     if (PluginManager.CurrentGameScene != Scene.WorkScene) return;

    //     var randomNormalGuestGroups = NightScene.CookingUtility.CookSystemManager.Instance.GetRandomNormalGuestGroups();
    //     var spawnPos = new Il2CppSystem.Nullable<Vector3>();
    //     var getPostprocessCharacterCallback = GuestsManager.Instance.getPostprocessCharacterCallback;
    //     var action = getPostprocessCharacterCallback.Invoke() ?? new System.Action<AStarInputGeneratorComponent>((_) => { });
    //     var normalGuestsController = new NormalGuestsController(
    //         randomNormalGuestGroups,
    //         spawnPos,
    //         action,
    //         GuestGroupController.LeaveType.Move
    //     );
        
    //     MpManager.SendSpawnNormalGuests();

    //     GuestsManager.Instance.guestIconManager.Add(normalGuestsController);
    //     EventManager.Instance.AddServedGuest(normalGuestsController.guestInstances.Length, false);
    //     GuestsManager.Instance.PostInitializeGuestGroup(normalGuestsController, -1, false, false);
    // }

    public static void SpawnNormalGuestGroup() // NightScene.GuestManagementUtility.GuestsManager$$SpawnNormalGuestGroup
    {
        var instance = GuestsManager.Instance;
        if (instance == null) return;

        var cookSystemManager = NightScene.CookingUtility.CookSystemManager.Instance;
        if (cookSystemManager == null) return;

        var randomNormalGuestGroups = cookSystemManager.GetRandomNormalGuestGroups();
        if (randomNormalGuestGroups == null) return;

        Log.LogWarning($"{LOG_TAG} Spawning normal guest group with {randomNormalGuestGroups.ToArray().ToString()} groups.");

        var eventManager = EventManager.Instance;
        if (eventManager == null) return;

        if (!EventManager.Instance.ShouldNormalGuestInstantiateBySpecialBuff) return;

        var getPostprocessCharacterCallback = GuestsManager.Instance.getPostprocessCharacterCallback;
        if (getPostprocessCharacterCallback == null) return;

        var action = getPostprocessCharacterCallback.Invoke() ?? new System.Action<AStarInputGeneratorComponent>((_) => { });

        var spawnPos = new Il2CppSystem.Nullable<Vector3>();

        var normalGuestsController = new NormalGuestsController(
            randomNormalGuestGroups,
            spawnPos,
            action,
            GuestGroupController.LeaveType.Move
        );
        //GuestsManager.instance.AllGuestInDeskController;
        instance.guestIconManager.Add(normalGuestsController);
        eventManager.AddServedGuest(normalGuestsController.guestInstances.Length, false);
        GuestsManager.Instance.PostInitializeGuestGroup(normalGuestsController, -1, false, false);
    }
}
using System;
using System.Runtime.InteropServices;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using HarmonyLib;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;
using SgrYuki.Utils;

namespace MetaMystia;

[AutoLog]
public static partial class MinHook_SpawnNormalGuestGroup
{
    public const string GameAssembly = "GameAssembly.dll";
    static HookManager hookManager = new();
    static SpawnNormalGuestGroupDelegate _hook;
    static SpawnNormalGuestGroupDelegate _original;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr SpawnNormalGuestGroupDelegate(
        IntPtr @this,
        IntPtr normalGuests,
        IntPtr overrideSpawnPosition,
        int leaveType,
        int targetDeskCode,
        [MarshalAs(UnmanagedType.I1)] bool shouldFade,
        IntPtr method
    );

    public static void InstallHook()
    {
        _hook = Hook_SpawnNormalGuestGroup;

        hookManager.InstallHookByOffset(
            GameAssembly,
            0x4DEC10,
            _hook
        );

        _original = Marshal.GetDelegateForFunctionPointer<SpawnNormalGuestGroupDelegate>(hookManager.OriginalFunction);
        Log.Info("Installed hook for NightScene.GuestManagementUtility.GuestsManager:SpawnNormalGuestGroup/5");
    }

    static IntPtr Hook_SpawnNormalGuestGroup(
        IntPtr @this,               // GuestsManager
        IntPtr normalGuests,        // Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>
        IntPtr overrideSpawnPosition,   // Il2CppSystem.Nullable<UnityEngine.Vector3>
        int leaveType,
        int targetDeskCode,
        bool shouldFade,
        IntPtr method)
    {
        Log.DebugCaller($"called");
        if (!GuestsManagerPatch.SpawnNormalGuestGroup_WithArg_Manual_Call
            && MpManager.IsConnectedClient
            && MpManager.LocalScene == Common.UI.Scene.WorkScene
            && !MpManager.InStory)
        {
            return IntPtr.Zero;
        }

        IntPtr res = _original(
            @this,
            normalGuests,
            overrideSpawnPosition,
            leaveType,
            targetDeskCode,
            shouldFade,
            method
        );

        if (res == IntPtr.Zero)
        {
            Log.WarningCaller($"failed to SpawnNormalGuestGroup, skip");
            return IntPtr.Zero;
        }

        if (MpManager.IsConnectedHost && MpManager.LocalScene == Common.UI.Scene.WorkScene && !MpManager.InStory)
        {
            var guestGroupControllerCvt = new GuestGroupController(res);
            // var normalGuestsCvt = new Il2CppSystem.Collections.Generic.IEnumerable<NormalGuest>(normalGuests);
            var overrideSpawnPositionCvt = new Il2CppSystem.Nullable<UnityEngine.Vector3>(overrideSpawnPosition);

            // uuid stored in PostInitializeGuestGroup_Prefix
            string uuid = WorkSceneManager.GetGuestUUID(guestGroupControllerCvt);
            var array = guestGroupControllerCvt.GetAllGuests().ToIl2CppReferenceArray();

            var guestVisualArraySorted = DataBaseCharacter.NormalGuestVisual.Get(array[0].id).SortByToString();
            int visualId1 = GuestsManagerPatch.IndexAt(uuid, guestVisualArraySorted, array[0].CharacterPixel);

            var info = new WorkSceneManager.GuestInfo
            {
                Id = array[0].id,
                VisualId = visualId1,
                IsSpecial = false,
                LeaveType = (GuestGroupController.LeaveType)leaveType
            };
            if (overrideSpawnPositionCvt.HasValue && overrideSpawnPositionCvt.Value.sqrMagnitude > 0.25 * 0.25 * 3 && overrideSpawnPositionCvt.Value.sqrMagnitude < 15 * 15 * 3) // min: 0.25*0.25*3 / max: 15*15*3
            {
                info.OverrideSpawnPosition = overrideSpawnPositionCvt.Value;
                Log.InfoCaller($"overrideSpawnPositionCvt, {overrideSpawnPositionCvt.Value}");
            }
            if (array.Length > 1)
            {
                var guestVisualArray2Sorted = DataBaseCharacter.NormalGuestVisual.Get(array[1].id).SortByToString();
                int visualId2 = GuestsManagerPatch.IndexAt(uuid, guestVisualArray2Sorted, array[1].CharacterPixel);
                info.Id2 = array[1].id;
                info.VisualId2 = visualId2;
            }
            GuestSpawnAction.Send(uuid, info);

            // 通过FSM转移状态
            var fsm = WorkSceneManager.GetOrCreateGuestFSM(uuid);
            fsm.ChangeState(WorkSceneManager.Status.Generated);
        }
        return res;
    }
}


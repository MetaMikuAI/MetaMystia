using GameData.Core.Collections.NightSceneUtility;
using Iced.Intel;
using MemoryPack;
using NightScene.GuestManagementUtility;
using static NightScene.GuestManagementUtility.GuestsManager;

namespace MetaMystia;


[MemoryPackable]
public partial class GuestSpawnAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SPAWN;

    public int GuestId {get; set; }

    public bool IsSpecial {get; set; }

    public string UUID {get; set; }

    public override void LogActionSend(bool onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.WorkScene)
        {
            return;
        }


        PluginManager.Instance.RunOnMainThread(() =>
        {
            try
            {
                GuestsManagerPatch.GuestSpawnUUID.Value = UUID;
                if (IsSpecial)
                {
                    PrototypingManagers.NightSceneDebugImpl.SpawnSpecialGuest(GuestId);
                } 
                else {
                    PrototypingManagers.NightSceneDebugImpl.SpawnNormalGuest(GuestId);
                }
            }
            finally
            {
                GuestsManagerPatch.GuestSpawnUUID.Value = "";
            }
        });
    }
        
}

[MemoryPackable]
public partial class GuestSeatedAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SEATED;

    public string GuestUniqId {get; set; }

    public int DeskId {get; set; }

    public bool FirstSpawn {get; set; }

    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.WorkScene)
        {
            return;
        }


        PluginManager.Instance.RunOnMainThread(() =>
        {
            var guest = GuestManager.GetGuest(GuestUniqId);
            GuestsManagerPatch.TrySendToSeat_Original(GuestsManager.instance, guest, FirstSpawn, DeskId, true);
        });
    }
}

[MemoryPackable]
public partial class GuestLeaveAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_LEAVE;

    public string GuestUniqId {get; set; }

    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.WorkScene)
        {
            return;
        }


        PluginManager.Instance.RunOnMainThread(() =>
        {
            var guest = GuestManager.GetGuest(GuestUniqId);
        });
    }
        
}

[MemoryPackable]
public partial class GuestGenNormalOrderAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_GEN_NORMAL_ORDER;

    public string GuestUniqId { get; set; }
    public int RequestFoodId { get; set; }
    public int RequestBevId { get; set; }
    public int DeskCode { get; set; }
    public bool NotShowInUI { get; set; }
    public bool IsFree { get; set; }
    public string Message { get; set; }
    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.WorkScene)
        {
            return;
        }


        PluginManager.Instance.RunOnMainThread(() =>
        {
            var guest = GuestManager.GetGuest(GuestUniqId);
            var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            var order = new NormalOrder(array[0], RequestFoodId, RequestBevId, DeskCode, NotShowInUI, IsFree)
            {
                _Type_k__BackingField = OrderBase.OrderType.Normal,
            };
            GuestManager.orders.Enqueue((order, Message));
            GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);
        });
    }
        
}

[MemoryPackable]
public partial class GuestGenSPOrderAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_GEN_SPECIAL_ORDER;
    public string GuestUniqId { get; set; }
    public int RequestFoodTag { get; set; }
    public int RequestBevTag { get; set; }
    public int DeskCode { get; set; }
    public bool NotShowInUI { get; set; }
    public bool IsFree { get; set; }
    public string Message { get; set; }
    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (PluginManager.CurrentGameScene != Common.UI.Scene.WorkScene)
        {
            return;
        }


        PluginManager.Instance.RunOnMainThread(() =>
        {
            var guest = GuestManager.GetGuest(GuestUniqId);
            var array = guest.GetAllGuests().TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GuestBase>>();
            var order = new SpecialOrder(new SpecialGuest(guest.Pointer), RequestFoodTag, RequestBevTag, DeskCode, NotShowInUI, IsFree)
            {
                _Type_k__BackingField = OrderBase.OrderType.Special
            };
            GuestManager.orders.Enqueue((order, Message));

            GuestsManagerPatch.GenerateOrderSession_Original(GuestsManager.instance, guest, true);
        });
    }
        
}
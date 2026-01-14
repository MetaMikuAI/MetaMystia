using GameData.Core.Collections;
using MemoryPack;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using SgrYuki.Utils;

namespace MetaMystia;

public enum GuestPayType
{
    Fund,
    Tip
}

[MemoryPackable]
[AutoLog]
public partial class GuestPayAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_PAY;
    public GuestPayType PayType;
    public int Amount;

    [MemoryPackAllowSerialize]
    public EventManager.ServeType ServeType;
    public float ComboBuff;
    public float MoodBuff;
    public float ExtraBuff;
    public override void LogActionSend(bool _onlyAction, string prefix) => LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    public override void OnReceived()
    {
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene)
        {
            return;
        }
        CommandScheduler.EnqueueWithNoCondition(() => {
            switch (PayType)
            {
                case GuestPayType.Fund:
                    NightSceneEventManagerPatch.FundEdit_Original(EventManager.Instance, Amount, EventManager.MathOperation.Add);
                    break;
                case GuestPayType.Tip:
                    NightSceneEventManagerPatch.TipEdit_Original(EventManager.Instance, Amount, ServeType, ComboBuff, MoodBuff, ExtraBuff);
                    break;
                default:
                    break;
            }
        });
    }

    public static void SendFund(int amount)
    {
        NetPacket packet = new([new GuestPayAction
        {
            Amount = amount,
            PayType = GuestPayType.Fund
        }]);
        SendToHostOrBroadcast(packet);
    }

    public static void SendTip(int amount, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        NetPacket packet = new([new GuestPayAction
        {
            Amount = amount,
            PayType = GuestPayType.Tip,
            ServeType = serveType,
            ComboBuff = comboBuff,
            MoodBuff = moodBuff,
            ExtraBuff = extraBuff
        }]);
        SendToHostOrBroadcast(packet);
    }
}

// OnServe
// PartnerManager.instance.NotifySystemChanged(-1, PartnerManager.OrderChangeContext.FoodDelivered, order);
///[Error  :MetaMystia] [PluginManager.cs] Error executing on main thread: Object reference not set to an instance of an object.
//    at Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase.CreateGCHandle(IntPtr objHdl) in /home/runner/work/Il2CppInterop/Il2CppInterop/Il2CppInterop.Runtime/InteropTypes/Il2CppObjectBase.cs:line 50
//    at Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase..ctor(IntPtr pointer) in /home/runner/work/Il2CppInterop/Il2CppInterop/Il2CppInterop.Runtime/InteropTypes/Il2CppObjectBase.cs:line 21
//    at Il2CppSystem.Object..ctor(IntPtr pointer)
//    at Il2CppSystem.ValueType..ctor(IntPtr pointer)
//    at Il2CppSystem.Nullable`1..ctor(IntPtr pointer)
//    at NightScene.UI.GuestManagementUtility.WorkSceneServePannel.get_OpenContext()
//    at MetaMystia.GuestServeAction.<OnReceived>b__20_0()
//    at MetaMystia.PluginManager.Update()

// WorkSceneServePannelPatch.Send_Original(WorkSceneServePannelPatch.instanceRef, food);
// WorkSceneServePannelPatch.Send_Original(WorkSceneServePannelPatch.instanceRef, beverage);
// [Warning:MetaMystia] instanceRef send ServBeverage fail, System.NullReferenceException: Object reference not set to an instance of an object.
// --- BEGIN IL2CPP STACK TRACE ---
// System.NullReferenceException: Object reference not set to an instance of an object.
// at NightScene.UI.GuestManagementUtility.WorkSceneServePannel.Send (GameData.Core.Collections.Sellable toSend) [0x00000] in <00000000000000000000000000000000>:0 
// --- END IL2CPP STACK TRACE ---
// ,    at Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(IntPtr returnedException) in /home/runner/work/Il2CppInterop/Il2CppInterop/Il2CppInterop.Runtime/Il2CppException.cs:line 36
// at DMD<WorkSceneServePannelPatch::Send_Original>(WorkSceneServePannel __instance, Sellable toSend)
// at MetaMystia.GuestServeAction.<OnReceived>b__20_0()
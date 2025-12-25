using System;
using GameData.Core.Collections;
using MemoryPack;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using SgrYuki.Utils;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class GuestServeAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_SERVE;

    public enum ServeType
    {
        Food,
        Beverage,
        Both
    }

    public string GuestUniqId { get; set; }
    public SellableFood Food { get; set; }
    public int BeverageId { get; set; }
    public ServeType FoodType { get; set; }

    public override void LogActionSend(bool _onlyAction, string prefix)
    {
        LogActionSend(BepInEx.Logging.LogLevel.Info, false, prefix);
    }

    public override void OnReceived()
    {
        LogActionReceived();
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene)
        {
            return;
        }

        const int PatientRecoverSecs = 60;

        CommandScheduler.Enqueue(
            canExecute: () => NightGuestManager.CheckStatusOrThrow(GuestUniqId, NightGuestManager.Status.OrderGenerated),
            execute: () =>
            {
                var guest = NightGuestManager.GetGuest(GuestUniqId);
                var order = guest.PeekOrders();

                var onOrderEvalAction = new Action(() => GuestsManager.instance.EvaluateOrder(guest, false));
                var recoverPatientAction = new Action<int>(count => guest.AddPatient(count * 15));
                var setFoodVisualAction = new Action<UnityEngine.Sprite>(TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetFoodVisual);
                var setBeverageVisualAction = new Action<UnityEngine.Sprite>(TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetBeverageVisual);

                var context = new NightScene.UI.GuestManagementUtility.WorkSceneServePannel.PannelOpenContext
                {
                    operatingOrder = order,
                    onOrderEvaluate = onOrderEvalAction,
                    onRecoverPatient = recoverPatientAction,
                    onFoodDelieverStatusUpdated = setFoodVisualAction,
                    onBevDelieverStatusUpdated = setBeverageVisualAction,
                    currentGuestController = guest

                };
                WorkSceneServePannelPatch.instanceRef?.OpenContext = new Il2CppSystem.Nullable<NightScene.UI.GuestManagementUtility.WorkSceneServePannel.PannelOpenContext>(context);

                switch (FoodType)
                {
                    case ServeType.Food:
                        var food = Food.ToSellable();
                        order.ServFood = food;
                        TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetFoodVisual(food.Text.Visual);
                        // WorkSceneServePannelPatch.instanceRef?.UpdateFoodVisualOnDesk();
                        break;
                    case ServeType.Beverage:
                        var beverage = BeverageId.AsNewBeverage();
                        order.ServBeverage = beverage;
                        TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetBeverageVisual(beverage.Text.Visual);
                        // WorkSceneServePannelPatch.instanceRef?.UpdateBevVisualOnDesk();
                        break;
                    default:
                        food = Food.ToSellable();
                        beverage = BeverageId.AsNewBeverage();
                        order.ServFood = food;
                        order.ServBeverage = beverage;
                        TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetFoodVisual(food.Text.Visual);
                        TileManager.Instance.GuestTables[guest.DeskCode].tableDisplayer.SetBeverageVisual(beverage.Text.Visual);
                        // WorkSceneServePannelPatch.instanceRef?.UpdateFoodVisualOnDesk();
                        // WorkSceneServePannelPatch.instanceRef?.UpdateBevVisualOnDesk();

                        break;
                }
                if (order.IsFullfilled)
                {
                    Log.LogWarning($"handing GUEST_SERVE: begin evaluate order for {GuestUniqId}");
                    GuestsManager.instance.EvaluateOrder(guest, false);
                    guest.AddPatient(PatientRecoverSecs);
                }
                else
                {
                    Log.LogWarning($"handing GUEST_SERVE: not Fullfilled yet for {GuestUniqId}, will not evaluate");
                }

                // already set in EvaluateOrder_Postfix
                // NightGuestManager.SetGuestStatus(GuestUniqId, NightGuestManager.Status.OrderEvaluated); 
            }
        );

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
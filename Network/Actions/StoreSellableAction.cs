using GameData.Core.Collections;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class StoreSellableAction : NetAction
{
    public override ActionType Type => ActionType.STORE_SELLABLE;

    public enum StoreType
    {
        Food,
        Beverage
    }

    public int GridIndex { get; set; }
    public SellableFood Food { get; set; }
    public int BeverageId { get; set; }
    public StoreType FoodType { get; set; }

    protected override bool OnSendLogOnlyAction => true;
    protected override bool OnReceiveLogOnlyAction => true;

    public override void OnReceivedDerived()
    {
        Sellable sellable;
        switch (FoodType)
        {
            case StoreType.Food:
                sellable = Food.ToSellable();
                break;
            case StoreType.Beverage:
                sellable = BeverageId.RefBeverage();
                break;
            default:
                Log.LogError($"StoreSellableAction.OnReceived called with unsupported FoodType: {FoodType}");
                return;
        }
        PluginManager.Instance.RunOnMainThread(() =>
        {
            var cookerController = CookManager.GetCookerControllerByIndex(GridIndex);
            if (cookerController == null)
            {
                Log.LogWarning($"Failed to find CookerController with GridIndex={GridIndex}");
                return;
            }
            CookControllerPatch.Store_Original(cookerController, sellable);
        });
    }

    public static void Send(int gridIndex, Sellable sellable)
    {
        switch (sellable.type)
        {
            case Sellable.SellableType.Food:
                SellableFood food = SellableFood.FromSellable(sellable);
                var action = new StoreSellableAction
                {
                    GridIndex = gridIndex,
                    Food = food,
                    FoodType = StoreType.Food
                };
                action.SendToHostOrBroadcast();
                break;
            case Sellable.SellableType.Beverage:
                int beverageId = sellable.id;
                action = new StoreSellableAction
                {
                    GridIndex = gridIndex,
                    BeverageId = beverageId,
                    FoodType = StoreType.Beverage
                };
                action.SendToHostOrBroadcast();
                break;
            default:
                Log.LogError($"StoreSellableAction.Send called with unsupported sellable type: {sellable.type}");
                return;
        }
    }
}

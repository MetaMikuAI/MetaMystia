using MemoryPack;
using NightScene.EventUtility;
using SgrYuki.Utils;

namespace MetaMystia;

public enum GuestPayType
{
    Fund,
    Tip,
    Combo
}

[MemoryPackable]
[AutoLog]
public partial class GuestPayAction : SendAffectStoryAction
{
    public override ActionType Type => ActionType.GUEST_PAY;
    public GuestPayType PayType;
    public int Amount;

    [MemoryPackAllowSerialize]
    public EventManager.ServeType ServeType;

    [MemoryPackAllowSerialize]
    public EventManager.MathOperation MathOperation;
    public float ComboBuff;
    public float MoodBuff;
    public float ExtraBuff;


    [CheckScene(Common.UI.Scene.WorkScene)]
    [ExecuteAfterStory]
    public override void OnReceivedDerived()
    {
        CommandScheduler.EnqueueWithNoCondition(() =>
        {
            switch (PayType)
            {
                case GuestPayType.Fund:
                    NightSceneEventManagerPatch.FundEdit_Original(EventManager.Instance, Amount, MathOperation);
                    break;
                case GuestPayType.Tip:
                    NightSceneEventManagerPatch.TipEdit_Original(EventManager.Instance, Amount, ServeType, ComboBuff, MoodBuff, ExtraBuff);
                    break;
                case GuestPayType.Combo:
                    NightSceneEventManagerPatch.ComboEdit_Original(EventManager.Instance, Amount, MathOperation);
                    break;
                default:
                    break;
            }
        });
    }

    public static void SendFund(int amount, EventManager.MathOperation mathOperation)
    {
        var action = new GuestPayAction
        {
            Amount = amount,
            PayType = GuestPayType.Fund,
            MathOperation = mathOperation
        };
        action.SendToHostOrBroadcast();
    }

    public static void SendTip(int amount, EventManager.ServeType serveType, float comboBuff, float moodBuff, float extraBuff)
    {
        var action = new GuestPayAction
        {
            Amount = amount,
            PayType = GuestPayType.Tip,
            ServeType = serveType,
            ComboBuff = comboBuff,
            MoodBuff = moodBuff,
            ExtraBuff = extraBuff
        };
        action.SendToHostOrBroadcast();
    }

    public static void SendCombo(int amount, EventManager.MathOperation mathOperation)
    {
        var action = new GuestPayAction
        {
            Amount = amount,
            PayType = GuestPayType.Combo,
            MathOperation = mathOperation
        };
        action.SendToHostOrBroadcast();
    }
}

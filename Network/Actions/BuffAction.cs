using MemoryPack;
using SgrYuki.Utils;

namespace MetaMystia;

public enum QTEBuff
{
    InstantEvaluation, // 立即完食
    PatientFreeze, // 耐心不减 
    ThrowDeliver,   // 投掷上菜

    Fever,      // 热火朝天
    Fever_Infinite  // 永续热火朝天
}

public static class QTEBuffExtension
{
    extension(QTEBuff buff)
    {
        public int ID => buff switch
        {
            QTEBuff.InstantEvaluation => 0,
            QTEBuff.PatientFreeze => 1,
            QTEBuff.ThrowDeliver => 2,

            QTEBuff.Fever => 3,
            QTEBuff.Fever_Infinite => -1,
            _ => throw new System.NotImplementedException(),
        };
    }
}

[MemoryPackable]
[AutoLog]
public partial class BuffAction : NetAction
{
    public override ActionType Type => ActionType.BUFF;
    public QTEBuff Buff;
    public override void LogActionSend(bool _onlyAction, string prefix) => LogActionSend(BepInEx.Logging.LogLevel.Message, false, prefix);
    public override void LogActionReceived(bool _onlyAction = false, string prefix = "") => LogActionReceived(BepInEx.Logging.LogLevel.Message, false, prefix);

    public override void OnReceived()
    {
        LogActionReceived();
        if (MpManager.LocalScene != Common.UI.Scene.WorkScene) return;
        CommandScheduler.EnqueueWithNoCondition(() =>
        {
            QTERewardManagerPatch.BuffLocalTrigger = false;
            NightScene.CookingUtility.QTERewardManager.Instance?.OnQTESucceeded(Buff.ID, true);
            Log.Message($"triggered buff {Buff}");
            QTERewardManagerPatch.BuffLocalTrigger = true;
        });

    }

    public static void Send(QTEBuff buff)
    {
        SendToHostOrBroadcast(NetPacket.FromSingleAction(new BuffAction{Buff = buff}));
    }
}

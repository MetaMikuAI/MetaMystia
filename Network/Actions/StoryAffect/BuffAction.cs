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
            _ => 3,
        };
    }
}

[MemoryPackable]
[AutoLog]
public partial class BuffAction : AffectStoryAction
{
    public override ActionType Type => ActionType.BUFF;
    public QTEBuff Buff;
    protected override BepInEx.Logging.LogLevel OnReceiveLogLevel => BepInEx.Logging.LogLevel.Message;
    protected override BepInEx.Logging.LogLevel OnSendLogLevel => BepInEx.Logging.LogLevel.Message;

    [CheckScene(Common.UI.Scene.WorkScene)]
    public override void OnReceivedDerived()
    {
        CommandScheduler.Enqueue(
            executeWhen: () => !QTERewardManagerPatch.OnQTESucceededExecuting,
            executeInfo: "BuffAction OnQTESucceededExecuting",
            execute: () =>
            {
                QTERewardManagerPatch.BuffLocalTrigger = false;
                QTERewardManagerPatch.OnQTESucceeded(NightScene.CookingUtility.QTERewardManager.Instance, Buff.ID, true);
                QTERewardManagerPatch.BuffLocalTrigger = true;
                Log.Message($"triggered buff {Buff}");
            },
            timeoutSeconds: 10f
        );
    }

    public static void Send(QTEBuff buff)
    {
        new BuffAction { Buff = buff }.SendToHostOrBroadcast();
    }
}

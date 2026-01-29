namespace MetaMystia.Network;

public abstract partial class ReceiveAffectStoryAction : Action
{
    protected override bool SkipReceiveOnStory => true;
}

public abstract partial class SendAffectStoryAction : Action
{
    protected override bool SkipSendOnStory => true;
}

public abstract partial class AffectStoryAction : Action
{
    protected override bool SkipSendOnStory => true;
    protected override bool SkipReceiveOnStory => true;
}

namespace MetaMystia;

public abstract partial class ReceiveAffectStoryAction : NetAction
{
    protected override bool SkipReceiveOnStory => true;
}

public abstract partial class SendAffectStoryAction : NetAction
{
    protected override bool SkipSendOnStory => true;
}

public abstract partial class AffectStoryAction : NetAction
{
    protected override bool SkipSendOnStory => true;
    protected override bool SkipReceiveOnStory => true;
}
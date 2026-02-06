using NightScene.EventUtility;

namespace MetaMystia;

public static class ExtendedBuff
{
    public enum Type
    {
        Null = 1000,
        Daiyousei,
        Koakuma
    }
    extension(Type t)
    {
        public EventManager.BuffType GameBuffType() => (EventManager.BuffType)t;
    }
}




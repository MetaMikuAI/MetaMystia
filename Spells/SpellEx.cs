using System;
using GameData.Core.Collections.NightSceneUtility;

namespace MetaMystia;

public abstract class SpellEx : SpellBase
{
    public SpellEx() { }
    public SpellEx(IntPtr pointer) : base(pointer) { }

    public abstract override string OnGettingSpellOwnerIdentifier();
    public abstract override Il2CppSystem.Collections.IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext);
    public abstract override Il2CppSystem.Collections.IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext);
    public override Il2CppSystem.Collections.IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext)
    {
        return base.OnLeaveBuffExecute(spellExecutionContext);
    }
}

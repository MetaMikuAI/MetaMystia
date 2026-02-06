using System;
using GameData.Core.Collections.NightSceneUtility;

namespace MetaMystia;

// Note: Don't register abstract class using ClassInjector.RegisterTypeInIl2Cpp, game will probably crash!
// That's why we use interface instead of abstract class here
public interface ISpellEx
{
    abstract string OnGettingSpellOwnerIdentifier();
    abstract Il2CppSystem.Collections.IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext);
    abstract Il2CppSystem.Collections.IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext);
    abstract Il2CppSystem.Collections.IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext);
}

using System;
using System.Collections;
using Il2CppDummyDll;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200092F RID: 2351
	[Token(Token = "0x200092F")]
	public class Spell_ : SpellBase
	{
		// Token: 0x06003A80 RID: 14976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x693700", Offset = "0x692100", VA = "0x180693700", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x693730", Offset = "0x692130", VA = "0x180693730", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A82")]
		[Address(RVA = "0x693780", Offset = "0x692180", VA = "0x180693780", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public Spell_()
		{
		}
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200098C RID: 2444
	[Token(Token = "0x200098C")]
	[CreateAssetMenu(fileName = "Spell_Keine(Intro)", menuName = "Spells/Spell_Keine(Intro)", order = 13)]
	public class Spell_Keine_Intro : SpellBase
	{
		// Token: 0x06003C55 RID: 15445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x69E600", Offset = "0x69D000", VA = "0x18069E600", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C56")]
		[Address(RVA = "0x69E630", Offset = "0x69D030", VA = "0x18069E630", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C57")]
		[Address(RVA = "0x69E690", Offset = "0x69D090", VA = "0x18069E690", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Keine_Intro()
		{
		}
	}
}

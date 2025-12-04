using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	[CreateAssetMenu(fileName = "Spell_Flandre(Intro)", menuName = "Spells/DLC4/Flandre", order = 8)]
	public class Spell_Flandre_Intro : SpellBase
	{
		// Token: 0x06003B82 RID: 15234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x69CF80", Offset = "0x69B980", VA = "0x18069CF80", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x69CFB0", Offset = "0x69B9B0", VA = "0x18069CFB0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x69D010", Offset = "0x69BA10", VA = "0x18069D010", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Flandre_Intro()
		{
		}
	}
}

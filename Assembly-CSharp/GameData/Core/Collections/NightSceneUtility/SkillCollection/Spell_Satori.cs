using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x2000A3E")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Satori", menuName = "Spells/DLC2/DLC2_Spell_Satori", order = 3)]
	public class Spell_Satori : SpellBase
	{
		// Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x6CA210", Offset = "0x6C8C10", VA = "0x1806CA210", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x6CA240", Offset = "0x6C8C40", VA = "0x1806CA240", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x6CA2C0", Offset = "0x6C8CC0", VA = "0x1806CA2C0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Satori()
		{
		}

		// Token: 0x040037D4 RID: 14292
		[Token(Token = "0x40037D4")]
		[FieldOffset(Offset = "0x18")]
		public int targetIdInUnityEditor;

		// Token: 0x040037D5 RID: 14293
		[Token(Token = "0x40037D5")]
		[FieldOffset(Offset = "0x20")]
		public int[] positiveCardBanIdInChallenge;
	}
}

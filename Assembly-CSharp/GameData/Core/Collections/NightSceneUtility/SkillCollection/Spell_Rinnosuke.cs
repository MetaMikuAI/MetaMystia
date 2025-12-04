using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	[CreateAssetMenu(fileName = "Spell_Rinnosuke", menuName = "Spells/Rinnosuke", order = 6)]
	public class Spell_Rinnosuke : SpellBase
	{
		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x6C9400", Offset = "0x6C7E00", VA = "0x1806C9400", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x6C9430", Offset = "0x6C7E30", VA = "0x1806C9430", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x6C94B0", Offset = "0x6C7EB0", VA = "0x1806C94B0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x6C95E0", Offset = "0x6C7FE0", VA = "0x1806C95E0")]
		public Spell_Rinnosuke()
		{
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00017430 File Offset: 0x00015630
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x6C9530", Offset = "0x6C7F30", VA = "0x1806C9530")]
		[CompilerGenerated]
		internal static bool <OnNegativeBuffExecute>g__checkIfHaveThingToHide|3_1(int i)
		{
			return default(bool);
		}

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int giveItemId;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x1C")]
		public int removeInfoAmount;
	}
}

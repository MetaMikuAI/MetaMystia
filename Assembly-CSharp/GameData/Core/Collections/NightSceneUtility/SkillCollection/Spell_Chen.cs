using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	[CreateAssetMenu(fileName = "Spell_Chen", menuName = "Spells/Chen", order = 2)]
	public class Spell_Chen : SpellBase
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x69C5D0", Offset = "0x69AFD0", VA = "0x18069C5D0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x69C600", Offset = "0x69B000", VA = "0x18069C600", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x69C680", Offset = "0x69B080", VA = "0x18069C680", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Chen()
		{
		}

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Header("Values")]
		public float normalGuestSpawnRate;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x1C")]
		public int fishGiveAmount;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x20")]
		[Header("Effect")]
		public GameObject getItemEffectParent;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip trail;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject lazyEffectParent;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip bubble;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x40")]
		public float getItemEffectDuration;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x44")]
		public float getItemOffset;
	}
}

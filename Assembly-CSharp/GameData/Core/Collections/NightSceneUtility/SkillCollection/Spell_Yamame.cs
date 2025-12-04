using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Yamame", menuName = "Spells/DLC2/DLC2_Spell_Yamame", order = 0)]
	public class Spell_Yamame : SpellBase
	{
		// Token: 0x06004208 RID: 16904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x6FE620", Offset = "0x6FD020", VA = "0x1806FE620", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x6FE650", Offset = "0x6FD050", VA = "0x1806FE650", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x6FE6E0", Offset = "0x6FD0E0", VA = "0x1806FE6E0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420B")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Yamame()
		{
		}

		// Token: 0x04003A19 RID: 14873
		[Token(Token = "0x4003A19")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int postiveDuration;

		// Token: 0x04003A1A RID: 14874
		[Token(Token = "0x4003A1A")]
		[FieldOffset(Offset = "0x1C")]
		public float slowDownMultiper;

		// Token: 0x04003A1B RID: 14875
		[Token(Token = "0x4003A1B")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x04003A1C RID: 14876
		[Token(Token = "0x4003A1C")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effect")]
		public GameObject lightVFX;

		// Token: 0x04003A1D RID: 14877
		[Token(Token = "0x4003A1D")]
		[FieldOffset(Offset = "0x30")]
		public float positiveVFXDuration;

		// Token: 0x04003A1E RID: 14878
		[Token(Token = "0x4003A1E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject webVFX1;

		// Token: 0x04003A1F RID: 14879
		[Token(Token = "0x4003A1F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject webVFX2;

		// Token: 0x04003A20 RID: 14880
		[Token(Token = "0x4003A20")]
		[FieldOffset(Offset = "0x48")]
		[Header("SFX")]
		public AudioClip rewardSFX;

		// Token: 0x04003A21 RID: 14881
		[Token(Token = "0x4003A21")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip punishmentSFX;

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip punishmentHitSFX;
	}
}

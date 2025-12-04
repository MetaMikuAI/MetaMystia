using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20009CD")]
	[CreateAssetMenu(fileName = "Spell_Mokou", menuName = "Spells/Mokou", order = 24)]
	public class Spell_Mokou : SpellBase
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x6B3420", Offset = "0x6B1E20", VA = "0x1806B3420", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x6B3450", Offset = "0x6B1E50", VA = "0x1806B3450", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x6B34D0", Offset = "0x6B1ED0", VA = "0x1806B34D0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Mokou()
		{
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x6B3680", Offset = "0x6B2080", VA = "0x1806B3680")]
		[CompilerGenerated]
		private string <OnPositiveBuffExecute>g__OnGettingCurrentBuffContext|16_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public float cookTimeEditMultiplier;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0x1C")]
		public int fireDurationSec;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0x20")]
		public int maxEvalLevel;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0x24")]
		public int negativeDurationSec;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effect")]
		public AudioClip fireBirdEffectA;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x30")]
		public float fireBirdEffectOffset;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip fireBirdEffectB;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x40")]
		public GameObject fireBirdEffect;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x48")]
		public float positiveEffectDuration;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x50")]
		public GameObject evalOverrideEffect;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x58")]
		public float negativeEffectDuration;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip negativeEffectAppearSFX;

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip negativeEffectSFX;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x70")]
		public float negativeEffectSFXDelay;
	}
}

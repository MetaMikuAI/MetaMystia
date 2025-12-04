using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A05 RID: 2565
	[Token(Token = "0x2000A05")]
	[CreateAssetMenu(fileName = "Spell_Patchouli", menuName = "Spells/Patchouli", order = 27)]
	public class Spell_Patchouli : SpellBase
	{
		// Token: 0x06003E94 RID: 16020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x6B48C0", Offset = "0x6B32C0", VA = "0x1806B48C0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x6B48F0", Offset = "0x6B32F0", VA = "0x1806B48F0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x6B4970", Offset = "0x6B3370", VA = "0x1806B4970", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E97")]
		[Address(RVA = "0x6B4A80", Offset = "0x6B3480", VA = "0x1806B4A80")]
		public Spell_Patchouli()
		{
		}

		// Token: 0x04003699 RID: 13977
		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int positiveDuration;

		// Token: 0x0400369A RID: 13978
		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x0400369B RID: 13979
		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x20")]
		public int[] philosopherStoneInfluencedTags;

		// Token: 0x0400369C RID: 13980
		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x28")]
		public int baseEval;

		// Token: 0x0400369D RID: 13981
		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0x2C")]
		public float failedFoodRate;

		// Token: 0x0400369E RID: 13982
		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0x30")]
		[Header("effect")]
		public GameObject philosopherStoneEffect;

		// Token: 0x0400369F RID: 13983
		[Token(Token = "0x400369F")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip bookAppearsSFX;

		// Token: 0x040036A0 RID: 13984
		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip bookFlipSFX;

		// Token: 0x040036A1 RID: 13985
		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0x48")]
		public float bookFlipOffset;

		// Token: 0x040036A2 RID: 13986
		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip effectSFX;

		// Token: 0x040036A3 RID: 13987
		[Token(Token = "0x40036A3")]
		[FieldOffset(Offset = "0x58")]
		public float effectOffset;

		// Token: 0x040036A4 RID: 13988
		[Token(Token = "0x40036A4")]
		[FieldOffset(Offset = "0x5C")]
		public float positiveEffectDuration;

		// Token: 0x040036A5 RID: 13989
		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x60")]
		public GameObject mercuryPoisonEffect;

		// Token: 0x040036A6 RID: 13990
		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x68")]
		public float negativeEffectDuration;

		// Token: 0x040036A7 RID: 13991
		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip negativeEffectSFX;

		// Token: 0x040036A8 RID: 13992
		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x78")]
		public float negativeEffectWait;
	}
}

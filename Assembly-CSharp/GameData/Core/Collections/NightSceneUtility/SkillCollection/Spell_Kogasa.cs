using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200098F RID: 2447
	[Token(Token = "0x200098F")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Kogasa", menuName = "Spells/DLC3/Kogasa", order = 0)]
	public class Spell_Kogasa : SpellBase
	{
		// Token: 0x06003C65 RID: 15461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x69EAE0", Offset = "0x69D4E0", VA = "0x18069EAE0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x69EB10", Offset = "0x69D510", VA = "0x18069EB10", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x69EBA0", Offset = "0x69D5A0", VA = "0x18069EBA0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x69EC30", Offset = "0x69D630", VA = "0x18069EC30")]
		public Spell_Kogasa()
		{
		}

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x18")]
		public int weirdoTag;

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x1C")]
		public float weirdoFoodCookSpeedModifier;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x20")]
		public float weirdoFoodExtraOrderRate;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x24")]
		public int positiveDuration;

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x28")]
		public float umbrellaShakeAmplitude;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x2C")]
		public float umbrellaShakeDuration;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x30")]
		public float umbrellaShakeEndDuration;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject rainEffect;

		// Token: 0x0400340E RID: 13326
		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject itemEffect;

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject fogEffect;

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x50")]
		public GameObject cloudEffect;

		// Token: 0x04003411 RID: 13329
		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x58")]
		public GameObject gengarEffect;

		// Token: 0x04003412 RID: 13330
		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x60")]
		[Header("SFX")]
		public AudioClip rainSFX;

		// Token: 0x04003413 RID: 13331
		[Token(Token = "0x4003413")]
		[FieldOffset(Offset = "0x68")]
		public SpellBase.DelayAudioClip itemSpawnSFX;

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x78")]
		public AudioClip throwBallSFX;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x80")]
		public SpellBase.DelayAudioClip gengarSFX;
	}
}

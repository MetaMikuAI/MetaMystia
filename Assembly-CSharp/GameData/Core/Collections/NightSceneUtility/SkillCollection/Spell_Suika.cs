using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	[CreateAssetMenu(fileName = "Spell_Suika", menuName = "Spells/Suika", order = 8)]
	public class Spell_Suika : SpellBase
	{
		// Token: 0x06004068 RID: 16488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x6CC280", Offset = "0x6CAC80", VA = "0x1806CC280", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x6CC2B0", Offset = "0x6CACB0", VA = "0x1806CC2B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x6CC330", Offset = "0x6CAD30", VA = "0x1806CC330", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x6CC3B0", Offset = "0x6CADB0", VA = "0x1806CC3B0")]
		public Spell_Suika()
		{
		}

		// Token: 0x04003881 RID: 14465
		[Token(Token = "0x4003881")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int giveBeverageAmount;

		// Token: 0x04003882 RID: 14466
		[Token(Token = "0x4003882")]
		[FieldOffset(Offset = "0x1C")]
		public int takeBeverageAmount;

		// Token: 0x04003883 RID: 14467
		[Token(Token = "0x4003883")]
		[FieldOffset(Offset = "0x20")]
		public int giveBeveragePriceMin;

		// Token: 0x04003884 RID: 14468
		[Token(Token = "0x4003884")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effect")]
		public AudioClip spawnSFX;

		// Token: 0x04003885 RID: 14469
		[Token(Token = "0x4003885")]
		[FieldOffset(Offset = "0x30")]
		public LoopedBGMPackage stepSFX;

		// Token: 0x04003886 RID: 14470
		[Token(Token = "0x4003886")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip takeItemSFX;

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		[FieldOffset(Offset = "0x40")]
		public float suikaSpawnOffset;

		// Token: 0x04003888 RID: 14472
		[Token(Token = "0x4003888")]
		[FieldOffset(Offset = "0x44")]
		public float suikaStartTakeItemOffset;

		// Token: 0x04003889 RID: 14473
		[Token(Token = "0x4003889")]
		[FieldOffset(Offset = "0x48")]
		public float suikaStartEndOffset;

		// Token: 0x0400388A RID: 14474
		[Token(Token = "0x400388A")]
		[FieldOffset(Offset = "0x4C")]
		public float suikaEndOffset;

		// Token: 0x0400388B RID: 14475
		[Token(Token = "0x400388B")]
		[FieldOffset(Offset = "0x50")]
		public float suikaTakeItemOffset;

		// Token: 0x0400388C RID: 14476
		[Token(Token = "0x400388C")]
		[FieldOffset(Offset = "0x54")]
		public float suikaStartGiveItemOffset;

		// Token: 0x0400388D RID: 14477
		[Token(Token = "0x400388D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject positiveSmallSuika;

		// Token: 0x0400388E RID: 14478
		[Token(Token = "0x400388E")]
		[FieldOffset(Offset = "0x60")]
		public float positiveSuikaRuntime;

		// Token: 0x0400388F RID: 14479
		[Token(Token = "0x400388F")]
		[FieldOffset(Offset = "0x64")]
		public float positiveSuikaWholeTime;

		// Token: 0x04003890 RID: 14480
		[Token(Token = "0x4003890")]
		[FieldOffset(Offset = "0x68")]
		public GameObject negativeSmallSuika;

		// Token: 0x04003891 RID: 14481
		[Token(Token = "0x4003891")]
		[FieldOffset(Offset = "0x70")]
		public float negativeSuikaRuntime;

		// Token: 0x04003892 RID: 14482
		[Token(Token = "0x4003892")]
		[FieldOffset(Offset = "0x74")]
		public float negativeSuikaWholeTime;

		// Token: 0x04003893 RID: 14483
		[Token(Token = "0x4003893")]
		[FieldOffset(Offset = "0x78")]
		public float firstSmallSuikaDisappear;

		// Token: 0x04003894 RID: 14484
		[Token(Token = "0x4003894")]
		[FieldOffset(Offset = "0x7C")]
		public float nextSuikaDisappear;

		// Token: 0x04003895 RID: 14485
		[Token(Token = "0x4003895")]
		[FieldOffset(Offset = "0x80")]
		public GameObject spawnEffectFirst;

		// Token: 0x04003896 RID: 14486
		[Token(Token = "0x4003896")]
		[FieldOffset(Offset = "0x88")]
		public GameObject spawnEffectLast;

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x90")]
		public float effectDuration;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	[CreateAssetMenu(fileName = "Spell_Meirin", menuName = "Spells/Meirin", order = 15)]
	public class Spell_Meirin : SpellBase
	{
		// Token: 0x06003D4B RID: 15691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x6B2D50", Offset = "0x6B1750", VA = "0x1806B2D50", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x6B2D80", Offset = "0x6B1780", VA = "0x1806B2D80", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x6B2E10", Offset = "0x6B1810", VA = "0x1806B2E10", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Meirin()
		{
		}

		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int passionAddPertime;

		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x1C")]
		public float passionAddUnitTime;

		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x20")]
		public int positiveDurationSec;

		// Token: 0x0400351B RID: 13595
		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0x24")]
		public int passionLostNum;

		// Token: 0x0400351C RID: 13596
		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0x28")]
		public int breakTableNum;

		// Token: 0x0400351D RID: 13597
		[Token(Token = "0x400351D")]
		[FieldOffset(Offset = "0x2C")]
		public int negativeDurationSec;

		// Token: 0x0400351E RID: 13598
		[Token(Token = "0x400351E")]
		[FieldOffset(Offset = "0x30")]
		[Header("Effect")]
		public float pandaCameraShakeAmplitude;

		// Token: 0x0400351F RID: 13599
		[Token(Token = "0x400351F")]
		[FieldOffset(Offset = "0x34")]
		public float pandaCameraShakeDuration;

		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x38")]
		public float pandaCameraShakeFadeDuration;

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0x40")]
		public GameObject angryPandaEffect;

		// Token: 0x04003522 RID: 13602
		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x48")]
		public GameObject dummyDesk;

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x50")]
		public float dummyDeskStayDuration;

		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x54")]
		public float waitForAngryPandaJumpTime;

		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x58")]
		public float angryPandaPrepareTime;

		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x5C")]
		public float landShakeAmplitude;

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x60")]
		public float landShakeDuration;

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x64")]
		public float landShakeFadeDuration;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip landSFX;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip smashSFX;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x78")]
		public float[] smashTimeStamp;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x80")]
		public float destroySFXDelay;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x88")]
		public AudioClip destroySFX;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x90")]
		public Sprite clearSprite;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject dancingMeirinEffect;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0xA0")]
		public float dancingMeirinMoveTime;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Parsee", menuName = "Spells/DLC2/DLC2_Spell_Parsee", order = 1)]
	public class Spell_Parsee : SpellBase
	{
		// Token: 0x06003E74 RID: 15988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x6B4780", Offset = "0x6B3180", VA = "0x1806B4780", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x6B47B0", Offset = "0x6B31B0", VA = "0x1806B47B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x6B4830", Offset = "0x6B3230", VA = "0x1806B4830", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Parsee()
		{
		}

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int postiveDuration;

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0x1C")]
		public float partnerExtraWageMultiper;

		// Token: 0x04003673 RID: 13939
		[Token(Token = "0x4003673")]
		[FieldOffset(Offset = "0x20")]
		[Header("Effect")]
		public GameObject rewardObject;

		// Token: 0x04003674 RID: 13940
		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0x28")]
		public GameObject rewardParseeEye;

		// Token: 0x04003675 RID: 13941
		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x30")]
		public GameObject rewardFire;

		// Token: 0x04003676 RID: 13942
		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0x38")]
		public GameObject rewardUIMoney;

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x40")]
		public float flashDuration;

		// Token: 0x04003678 RID: 13944
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x44")]
		public float fireDuration;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x48")]
		public float uiDuration;

		// Token: 0x0400367A RID: 13946
		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x4C")]
		public float uiAnimDuration;

		// Token: 0x0400367B RID: 13947
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 uiOffset;

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x58")]
		public Vector2 flashOffset;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x60")]
		public Vector2 fireOffset;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject punishmentObject;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x70")]
		[Header("SFX")]
		public AudioClip rewardSFX;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x78")]
		public SpellBase.DelayAudioClip punishmentSFX;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x88")]
		public SpellBase.DelayAudioClip punishmentSFX2;
	}
}

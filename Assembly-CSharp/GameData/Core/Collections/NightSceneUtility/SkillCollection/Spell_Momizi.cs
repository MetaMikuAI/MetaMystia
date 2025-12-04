using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009D0 RID: 2512
	[Token(Token = "0x20009D0")]
	[CreateAssetMenu(fileName = "Spell_Momizi", menuName = "Spells/Momizi", order = 43)]
	public class Spell_Momizi : SpellBase
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB2")]
		[Address(RVA = "0x6B3770", Offset = "0x6B2170", VA = "0x1806B3770", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x6B37A0", Offset = "0x6B21A0", VA = "0x1806B37A0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x6B3820", Offset = "0x6B2220", VA = "0x1806B3820", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Momizi()
		{
		}

		// Token: 0x0400358F RID: 13711
		[Token(Token = "0x400358F")]
		private const int TENGU_GUEST_ID = 1000;

		// Token: 0x04003590 RID: 13712
		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int positiveDuration;

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x20")]
		public int tenguGuestNum;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effects")]
		public GameObject cardObject;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x30")]
		public float cardDuration;

		// Token: 0x04003595 RID: 13717
		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip rewardSFX;

		// Token: 0x04003596 RID: 13718
		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x40")]
		public GameObject roadClosedObject;

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x48")]
		public float roadClosedDuration;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x4C")]
		public float cameraShakeAmplitude;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x50")]
		public float cameraShakeDuration;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x54")]
		public float cameraShakeFade;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip punishmentSFX;
	}
}

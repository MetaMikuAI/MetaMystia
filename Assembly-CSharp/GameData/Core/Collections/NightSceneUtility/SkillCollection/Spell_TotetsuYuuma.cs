using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	[CreateAssetMenu(fileName = "Spell_TotetsuYuuma", menuName = "Spells/TotetsuYuuma", order = 1003)]
	public class Spell_TotetsuYuuma : SpellBase
	{
		// Token: 0x060040F3 RID: 16627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x6FCC00", Offset = "0x6FB600", VA = "0x1806FCC00", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x6FCD10", Offset = "0x6FB710", VA = "0x1806FCD10", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x6FCDA0", Offset = "0x6FB7A0", VA = "0x1806FCDA0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x6FCC30", Offset = "0x6FB630", VA = "0x1806FCC30")]
		private void OnGuestSpawn(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x6FCE30", Offset = "0x6FB830", VA = "0x1806FCE30")]
		private GuestsManager.OrderBase YuumaOverrideOrderGeneration(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x6FC910", Offset = "0x6FB310", VA = "0x1806FC910")]
		private void OnBuffEnd()
		{
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x6FCFC0", Offset = "0x6FB9C0", VA = "0x1806FCFC0")]
		public Spell_TotetsuYuuma()
		{
		}

		// Token: 0x04003916 RID: 14614
		[Token(Token = "0x4003916")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int positiveDurationSec;

		// Token: 0x04003917 RID: 14615
		[Token(Token = "0x4003917")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2Int swallowedIngredientsNum;

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x24")]
		public Vector2Int swallowedBevNum;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x2C")]
		public int swallowedCookerNum;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 picOffset;

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 positivePicOffset;

		// Token: 0x0400391C RID: 14620
		[Token(Token = "0x400391C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject swallowAnim;

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject trackTable;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject yuumaSmokeObject;

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject energyVfx;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x60")]
		public GameObject yuumaPositiveSmokeObject;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip rewardSFX;

		// Token: 0x04003922 RID: 14626
		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip punishmentSFX;
	}
}

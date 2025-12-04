using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	[CreateAssetMenu(fileName = "Spell_Kasen", menuName = "Spells/Kasen", order = 5)]
	public class Spell_Kasen : SpellBase
	{
		// Token: 0x06003BEB RID: 15339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x69E300", Offset = "0x69CD00", VA = "0x18069E300", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x69E410", Offset = "0x69CE10", VA = "0x18069E410", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x69E330", Offset = "0x69CD30", VA = "0x18069E330")]
		private void OnGuestSpawn(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEE")]
		[Address(RVA = "0x69DDC0", Offset = "0x69C7C0", VA = "0x18069DDC0")]
		private GuestsManager.OrderBase KasenOverrideOrderGeneration(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEF")]
		[Address(RVA = "0x69E010", Offset = "0x69CA10", VA = "0x18069E010")]
		private void OnBuffEnd()
		{
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x69E490", Offset = "0x69CE90", VA = "0x18069E490", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Kasen()
		{
		}

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int tipAmountMin;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x1C")]
		public int tipAmountMax;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[FieldOffset(Offset = "0x20")]
		public int payIntervalMin;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[FieldOffset(Offset = "0x24")]
		public int payIntervalMax;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[FieldOffset(Offset = "0x28")]
		public int increaseNumIfBuffExist;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[FieldOffset(Offset = "0x2C")]
		public int durationNum;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[FieldOffset(Offset = "0x30")]
		public int negativeDuration;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x34")]
		public int rewardEffectDuration;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[FieldOffset(Offset = "0x38")]
		public float punishmentEffectDuration;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[FieldOffset(Offset = "0x3C")]
		public float launchHeight;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[FieldOffset(Offset = "0x40")]
		[Header("Effects")]
		public GameObject rewardTigerEffect;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x48")]
		public GameObject punishmentEffect;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip punishmentSFX;
	}
}

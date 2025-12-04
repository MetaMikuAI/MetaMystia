using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Toziko", menuName = "Spells/DLC3/Toziko", order = 5)]
	public class Spell_Toziko : SpellBase
	{
		// Token: 0x06004152 RID: 16722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004152")]
		[Address(RVA = "0x6FD2E0", Offset = "0x6FBCE0", VA = "0x1806FD2E0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004153")]
		[Address(RVA = "0x6FD310", Offset = "0x6FBD10", VA = "0x1806FD310", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004154")]
		[Address(RVA = "0x6FD1F0", Offset = "0x6FBBF0", VA = "0x1806FD1F0")]
		private void LightningWhenQteFail(CookController cookController)
		{
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004155")]
		[Address(RVA = "0x6FD390", Offset = "0x6FBD90", VA = "0x1806FD390", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Toziko()
		{
		}

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x20")]
		public float extraMoveSpeedMultipier;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x28")]
		public GameObject rewardThunderSelf;

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x30")]
		public GameObject rewardThunderPartner;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x38")]
		public GameObject negativeThunderEffect;

		// Token: 0x04003973 RID: 14707
		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x40")]
		public GameObject immunityEffect;

		// Token: 0x04003974 RID: 14708
		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x48")]
		public GameObject blackSmokeEffect;

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x50")]
		public GameObject notEffectiveEffect;

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x58")]
		public Sprite stunFace;

		// Token: 0x04003977 RID: 14711
		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0x60")]
		public GameObject stunEffect;

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0x68")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip glowSFX;

		// Token: 0x04003979 RID: 14713
		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0x78")]
		public SpellBase.DelayAudioClip electircSFX;

		// Token: 0x0400397A RID: 14714
		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0x88")]
		public SpellBase.DelayAudioClip buffSFX;

		// Token: 0x0400397B RID: 14715
		[Token(Token = "0x400397B")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip thunderSFX;

		// Token: 0x0400397C RID: 14716
		[Token(Token = "0x400397C")]
		[FieldOffset(Offset = "0xA8")]
		public SpellBase.DelayAudioClip hitAunnSFX;

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0xB8")]
		public SpellBase.DelayAudioClip hitHinaSFX;
	}
}

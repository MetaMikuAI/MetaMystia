using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Kagerou", menuName = "Spells/DLC4/Kagerou ", order = 6)]
	public class Spell_Kagerou : SpellBase
	{
		// Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x69D1C0", Offset = "0x69BBC0", VA = "0x18069D1C0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x69D390", Offset = "0x69BD90", VA = "0x18069D390", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x69D520", Offset = "0x69BF20", VA = "0x18069D520", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x69D1F0", Offset = "0x69BBF0", VA = "0x18069D1F0")]
		private void OnGuestSpawn(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x69DBD0", Offset = "0x69C5D0", VA = "0x18069DBD0")]
		private int[] WolfLikeTags(int[] originalTags, GuestGroupController guestGroupController)
		{
			return null;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x69DB10", Offset = "0x69C510", VA = "0x18069DB10")]
		private int[] WolfHateTags(int[] originalTags, GuestGroupController guestGroupController)
		{
			return null;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x69D410", Offset = "0x69BE10", VA = "0x18069D410")]
		private void OnPositiveBuffEnd()
		{
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Kagerou()
		{
		}

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		private const int MEATED_TAG = 0;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		private const int MOUNTGAINDELICOUS_TAG = 10;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		private const int FULLFILLED_TAG = 9;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x20")]
		public float meatVFXDuration;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x24")]
		public float beastarVFXDuration;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x28")]
		[Header("VFX")]
		public GameObject rewardWolfDanceVFX;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject rewardMeatVFX;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject rewardBeastarVFX;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 rewardBeastarVFXOffset;

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject punishmentVFX;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x50")]
		public float punishmentDuration;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0x54")]
		public float cardArriveDuration;

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x58")]
		public float punishmentAnimDuration;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x5C")]
		public float shakeDuration;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x60")]
		public float shakeFadeDuration;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x68")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip wolfDanceSfx;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x78")]
		public SpellBase.DelayAudioClip meatLoveSfx;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x88")]
		public SpellBase.DelayAudioClip cardDropSfx;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip redEyeShineSfx;
	}
}

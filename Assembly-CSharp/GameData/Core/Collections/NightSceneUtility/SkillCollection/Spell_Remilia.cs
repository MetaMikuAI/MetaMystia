using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Remilia", menuName = "Spells/DLC4/Remilia", order = 7)]
	public class Spell_Remilia : SpellBase
	{
		// Token: 0x06003F0C RID: 16140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x6C7FB0", Offset = "0x6C69B0", VA = "0x1806C7FB0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x6C7FE0", Offset = "0x6C69E0", VA = "0x1806C7FE0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x6C8A40", Offset = "0x6C7440", VA = "0x1806C8A40", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x6C8060", Offset = "0x6C6A60", VA = "0x1806C8060")]
		private void OnNightEnd()
		{
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x6C8AD0", Offset = "0x6C74D0", VA = "0x1806C8AD0")]
		private void SetGuestFund(GuestGroupController guest)
		{
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Remilia()
		{
		}

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		private const int SAKUYA_ID = 20;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		private const int REMILIA_ID = 4008;

		// Token: 0x04003731 RID: 14129
		[Token(Token = "0x4003731")]
		private const int YOUSEI_ID = 14;

		// Token: 0x04003732 RID: 14130
		[Token(Token = "0x4003732")]
		private const string REMILIA_POSITIVE = "Remilia_Positive";

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x1C")]
		public float extraSpawnRate;

		// Token: 0x04003735 RID: 14133
		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x04003736 RID: 14134
		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x24")]
		public float extraPartnerWorkSpeed;

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x28")]
		public int extraMinNGuestFund;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x2C")]
		public float extraOrderRate;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x30")]
		[Header("VFX")]
		public GameObject gangnirVFX;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject gangnirTrailVFX;

		// Token: 0x0400373B RID: 14139
		[Token(Token = "0x400373B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject bloodSmokeVFX;

		// Token: 0x0400373C RID: 14140
		[Token(Token = "0x400373C")]
		[FieldOffset(Offset = "0x48")]
		public float bloodSmokeSpawnWait;

		// Token: 0x0400373D RID: 14141
		[Token(Token = "0x400373D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject redNightVFX;

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x58")]
		public float redNightVFXDuration;

		// Token: 0x0400373F RID: 14143
		[Token(Token = "0x400373F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject rewardVFX;

		// Token: 0x04003740 RID: 14144
		[Token(Token = "0x4003740")]
		[FieldOffset(Offset = "0x68")]
		public GameObject rewardMagicVFX;

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x70")]
		public float rewardVFXDuration;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x74")]
		public float rewardVFXOffset;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x78")]
		public float rewardMagicOffset;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x80")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip gungnirSpawnSfx;

		// Token: 0x04003745 RID: 14149
		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x90")]
		public SpellBase.DelayAudioClip gungnirExplodeSfx;

		// Token: 0x04003746 RID: 14150
		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0xA0")]
		public SpellBase.DelayAudioClip magicStoneSpawnSfx;

		// Token: 0x04003747 RID: 14151
		[Token(Token = "0x4003747")]
		[FieldOffset(Offset = "0xB0")]
		public SpellBase.DelayAudioClip magicStoneReleaseSfx;

		// Token: 0x04003748 RID: 14152
		[Token(Token = "0x4003748")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip redEternalNightSfx;
	}
}

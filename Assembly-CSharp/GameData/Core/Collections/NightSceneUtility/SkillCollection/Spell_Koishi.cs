using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000995 RID: 2453
	[Token(Token = "0x2000995")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Koishi ", menuName = "Spells/DLC2/DLC2_Spell_Koishi ", order = 6)]
	public class Spell_Koishi : SpellBase
	{
		// Token: 0x06003C81 RID: 15489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x69F2C0", Offset = "0x69DCC0", VA = "0x18069F2C0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x69F2F0", Offset = "0x69DCF0", VA = "0x18069F2F0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x69EC40", Offset = "0x69D640", VA = "0x18069EC40")]
		private GuestsManager.OrderBase KoishiSpecialOrder(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x69F410", Offset = "0x69DE10", VA = "0x18069F410")]
		private GuestGroupController.EvaluationResult OverrideFinalEval(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C85")]
		[Address(RVA = "0x69F950", Offset = "0x69E350", VA = "0x18069F950")]
		private void WhenGuestSpawn(GuestGroupController group)
		{
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x69EED0", Offset = "0x69D8D0", VA = "0x18069EED0")]
		private void OnBuffEnd()
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x69F380", Offset = "0x69DD80", VA = "0x18069F380", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Koishi()
		{
		}

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public Sprite hiddenEyePic;

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0x24")]
		public int positiveDuration;

		// Token: 0x0400342B RID: 13355
		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effects")]
		public GameObject rewardPower;

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject negativePower;

		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x38")]
		[Header("SFX")]
		public AudioClip rewardSFX;

		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip punishmentSFX;
	}
}

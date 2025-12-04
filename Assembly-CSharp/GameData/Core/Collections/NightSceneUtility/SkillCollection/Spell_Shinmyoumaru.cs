using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Shinmyoumaru", menuName = "Spells/DLC4/Shinmyoumaru", order = 5)]
	public class Spell_Shinmyoumaru : SpellBase
	{
		// Token: 0x06004032 RID: 16434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x6CBBD0", Offset = "0x6CA5D0", VA = "0x1806CBBD0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x6CBC00", Offset = "0x6CA600", VA = "0x1806CBC00", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x6CBC80", Offset = "0x6CA680", VA = "0x1806CBC80", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x6CC270", Offset = "0x6CAC70", VA = "0x1806CC270")]
		public Spell_Shinmyoumaru()
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x6CC110", Offset = "0x6CAB10", VA = "0x1806CC110")]
		[CompilerGenerated]
		private void <OnPositiveBuffExecute>g__MagicWallet|39_2()
		{
		}

		// Token: 0x0400383E RID: 14398
		[Token(Token = "0x400383E")]
		private const int SEKIBANKI_HEAD_ID = 4011;

		// Token: 0x0400383F RID: 14399
		[Token(Token = "0x400383F")]
		private const int SEKIBANKI_ID = 4010;

		// Token: 0x04003840 RID: 14400
		[Token(Token = "0x4003840")]
		[FieldOffset(Offset = "0x18")]
		public float firstMalletMultiplierRate;

		// Token: 0x04003841 RID: 14401
		[Token(Token = "0x4003841")]
		[FieldOffset(Offset = "0x1C")]
		public float otherMalletMultiplierRate;

		// Token: 0x04003842 RID: 14402
		[Token(Token = "0x4003842")]
		[FieldOffset(Offset = "0x20")]
		public float negativeDuration;

		// Token: 0x04003843 RID: 14403
		[Token(Token = "0x4003843")]
		[FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x28")]
		public float sekibankiSpeedMultiplier;

		// Token: 0x04003845 RID: 14405
		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x2C")]
		public int sekibankiSpeedDuration;

		// Token: 0x04003846 RID: 14406
		[Token(Token = "0x4003846")]
		[FieldOffset(Offset = "0x30")]
		[Header("VFX")]
		public GameObject walletVFX;

		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x38")]
		public GameObject walletVFXSprite;

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x40")]
		public GameObject walletVFXBG;

		// Token: 0x04003849 RID: 14409
		[Token(Token = "0x4003849")]
		[FieldOffset(Offset = "0x48")]
		public GameObject walletVFXCoin;

		// Token: 0x0400384A RID: 14410
		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x50")]
		public float waitForWalletTapTime;

		// Token: 0x0400384B RID: 14411
		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject daiMystiaVFX;

		// Token: 0x0400384C RID: 14412
		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject daiBowlDropFX;

		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x68")]
		public float daiBowlDropDuration;

		// Token: 0x0400384E RID: 14414
		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x6C")]
		public float daiBowlDisappearDuration;

		// Token: 0x0400384F RID: 14415
		[Token(Token = "0x400384F")]
		[FieldOffset(Offset = "0x70")]
		public float daiMystiaWaitToJumpDuration;

		// Token: 0x04003850 RID: 14416
		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0x74")]
		public float daiMystiaSpawnOffset;

		// Token: 0x04003851 RID: 14417
		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x78")]
		public float daiMystiaRotatePerTime;

		// Token: 0x04003852 RID: 14418
		[Token(Token = "0x4003852")]
		[FieldOffset(Offset = "0x7C")]
		public float daiMystiaFlyDuration;

		// Token: 0x04003853 RID: 14419
		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x80")]
		public GameObject daiNewBowlVFX;

		// Token: 0x04003854 RID: 14420
		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x88")]
		public GameObject daiEnlargeEnergyVFX;

		// Token: 0x04003855 RID: 14421
		[Token(Token = "0x4003855")]
		[FieldOffset(Offset = "0x90")]
		public GameObject daiLandSmokeVFX;

		// Token: 0x04003856 RID: 14422
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x98")]
		public float daiEnlargeEnergyOffset;

		// Token: 0x04003857 RID: 14423
		[Token(Token = "0x4003857")]
		[FieldOffset(Offset = "0x9C")]
		public float daiMystiaWaitDuration;

		// Token: 0x04003858 RID: 14424
		[Token(Token = "0x4003858")]
		[FieldOffset(Offset = "0xA0")]
		public float daiMystiaSpawnDuration;

		// Token: 0x04003859 RID: 14425
		[Token(Token = "0x4003859")]
		[FieldOffset(Offset = "0xA4")]
		public float daiMystiaWaitToLandDuration;

		// Token: 0x0400385A RID: 14426
		[Token(Token = "0x400385A")]
		[FieldOffset(Offset = "0xA8")]
		public float daiMystiaLandDuration;

		// Token: 0x0400385B RID: 14427
		[Token(Token = "0x400385B")]
		[FieldOffset(Offset = "0xAC")]
		public float daiMystiaDisappearDuration;

		// Token: 0x0400385C RID: 14428
		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0xB0")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip walletSpawnSfx;

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip walletHitSfx;

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0xD0")]
		public SpellBase.DelayAudioClip coinSfx;

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0xE0")]
		public SpellBase.DelayAudioClip bowlDropSfx;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0xF0")]
		public SpellBase.DelayAudioClip mystyJumpSfx;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x100")]
		public SpellBase.DelayAudioClip dynamaxSfx;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x110")]
		public SpellBase.DelayAudioClip landSfx;
	}
}

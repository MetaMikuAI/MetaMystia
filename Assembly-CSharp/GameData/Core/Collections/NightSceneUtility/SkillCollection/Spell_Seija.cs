using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A49 RID: 2633
	[Token(Token = "0x2000A49")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Seija", menuName = "Spells/DLC4/Seija", order = 3)]
	public class Spell_Seija : SpellBase
	{
		// Token: 0x06003FF6 RID: 16374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x6CA7E0", Offset = "0x6C91E0", VA = "0x1806CA7E0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00017700 File Offset: 0x00015900
		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "5")]
		protected override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			return default(bool);
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x6CABA0", Offset = "0x6C95A0", VA = "0x1806CABA0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x6CA810", Offset = "0x6C9210", VA = "0x1806CA810")]
		private void OnGuestSpawnNegative(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x6CA620", Offset = "0x6C9020", VA = "0x1806CA620")]
		private void OnBuffEndNegative()
		{
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x6CAC30", Offset = "0x6C9630", VA = "0x1806CAC30", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x6CB210", Offset = "0x6C9C10", VA = "0x1806CB210")]
		private int[] ReversedLikeTags(int[] originalTags, GuestGroupController guestGroupController)
		{
			return null;
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x6CB180", Offset = "0x6C9B80", VA = "0x1806CB180")]
		private int[] ReversedHateTags(int[] originalTags, GuestGroupController guestGroupController)
		{
			return null;
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x6CAA00", Offset = "0x6C9400", VA = "0x1806CAA00")]
		private void OnGuestSpawnPositive(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x6CA6D0", Offset = "0x6C90D0", VA = "0x1806CA6D0")]
		private void OnBuffEndPositive()
		{
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00017718 File Offset: 0x00015918
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x6CA4A0", Offset = "0x6C8EA0", VA = "0x1806CA4A0")]
		private bool GetEffectDisplayer(GuestGroupController x, out List<GameObject> myEffects)
		{
			return default(bool);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x6CACC0", Offset = "0x6C96C0", VA = "0x1806CACC0")]
		private void RefreshDisplayer(GuestGroupController guest)
		{
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Seija()
		{
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x6CBA80", Offset = "0x6CA480", VA = "0x1806CBA80")]
		[CompilerGenerated]
		private void <OnPositiveBuffExecute>g__UpdateDisplayer|25_11(GuestGroupController thisGuest)
		{
		}

		// Token: 0x04003801 RID: 14337
		[Token(Token = "0x4003801")]
		private const int SEIJA_SPECIAL_POSITIVE_SPELL = 2;

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		private const string SEIJA_ADD_ORDERCOUNT_KEY = "Seija_Add_OrderCount_Key";

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[FieldOffset(Offset = "0x1C")]
		public int positiveMaxRewardNum;

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[FieldOffset(Offset = "0x20")]
		public float positiveAddMoneyPercent;

		// Token: 0x04003806 RID: 14342
		[Token(Token = "0x4003806")]
		[FieldOffset(Offset = "0x24")]
		public int positiveCheckNum;

		// Token: 0x04003807 RID: 14343
		[Token(Token = "0x4003807")]
		[FieldOffset(Offset = "0x28")]
		public int negativeDuration;

		// Token: 0x04003808 RID: 14344
		[Token(Token = "0x4003808")]
		[FieldOffset(Offset = "0x30")]
		[Header("奖励-超限效应")]
		[Header("VFX")]
		public GameObject reverseObject;

		// Token: 0x04003809 RID: 14345
		[Token(Token = "0x4003809")]
		[FieldOffset(Offset = "0x38")]
		public float reverseDuration;

		// Token: 0x0400380A RID: 14346
		[Token(Token = "0x400380A")]
		[FieldOffset(Offset = "0x40")]
		[Header("VFX")]
		[Header("奖励-天壤梦弓")]
		public GameObject walletObject;

		// Token: 0x0400380B RID: 14347
		[Token(Token = "0x400380B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject fireBallInEyeObject;

		// Token: 0x0400380C RID: 14348
		[Token(Token = "0x400380C")]
		[FieldOffset(Offset = "0x50")]
		public float walletAnimDuration;

		// Token: 0x0400380D RID: 14349
		[Token(Token = "0x400380D")]
		[FieldOffset(Offset = "0x54")]
		public Vector2 fireOffset;

		// Token: 0x0400380E RID: 14350
		[Token(Token = "0x400380E")]
		[FieldOffset(Offset = "0x60")]
		[Header("惩罚-阶级反转")]
		[Header("VFX")]
		public GameObject punishmentObject;

		// Token: 0x0400380F RID: 14351
		[Token(Token = "0x400380F")]
		[FieldOffset(Offset = "0x68")]
		public float reverseDuration_P;

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[FieldOffset(Offset = "0x70")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip reward1Sfx;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x80")]
		public SpellBase.DelayAudioClip reward2Sfx;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x90")]
		public SpellBase.DelayAudioClip yukuriDropSfx;

		// Token: 0x04003813 RID: 14355
		[Token(Token = "0x4003813")]
		[FieldOffset(Offset = "0xA0")]
		public SpellBase.DelayAudioClip OverturningWorldSfx;

		// Token: 0x04003814 RID: 14356
		[Token(Token = "0x4003814")]
		[FieldOffset(Offset = "0xB0")]
		public SpellBase.DelayAudioClip yukuriLiftSfx;
	}
}

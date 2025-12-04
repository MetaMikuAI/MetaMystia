using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	[CreateAssetMenu(fileName = "Spell_Akyuu", menuName = "Spells/Akyuu", order = 3)]
	public class Spell_Akyuu : SpellBase
	{
		// Token: 0x06003A84 RID: 14980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x693380", Offset = "0x691D80", VA = "0x180693380", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x6933B0", Offset = "0x691DB0", VA = "0x1806933B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A86")]
		[Address(RVA = "0x693430", Offset = "0x691E30", VA = "0x180693430", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public Spell_Akyuu()
		{
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x6934C0", Offset = "0x691EC0", VA = "0x1806934C0")]
		[CompilerGenerated]
		internal static Vector3 <OnPositiveBuffExecute>g__GetPlayerHitPos|19_0()
		{
			return default(Vector3);
		}

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public float overrideGuestMoodMin;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x1C")]
		public float overrideGuestMoodMax;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x20")]
		public int curtainDuration;

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x24")]
		public int giveItemID;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject giveItem;

		// Token: 0x040031A2 RID: 12706
		[Token(Token = "0x40031A2")]
		[FieldOffset(Offset = "0x30")]
		[Header("Effects")]
		public float rewardItemDuration;

		// Token: 0x040031A3 RID: 12707
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0x34")]
		public float rewardEffectDuration;

		// Token: 0x040031A4 RID: 12708
		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0x38")]
		public float rewardDelay;

		// Token: 0x040031A5 RID: 12709
		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x3C")]
		public float negativeEffectDuration;

		// Token: 0x040031A6 RID: 12710
		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject rewardEffect;

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject punishmentPic;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x50")]
		public float passionCameraShakeAmplitude;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x54")]
		public float passionCameraShakeDuration;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x58")]
		public float passionCameraShakeFadeDuration;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip rewardAppear;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x68")]
		public float passionDuration;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x70")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset crimeEvidenceTXT;
	}
}

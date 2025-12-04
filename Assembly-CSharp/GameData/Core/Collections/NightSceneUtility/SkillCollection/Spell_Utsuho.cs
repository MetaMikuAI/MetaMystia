using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	[CreateAssetMenu(fileName = "Spell_Utsuho", menuName = "Spells/DLC2/DLC2_Utsuho", order = 5)]
	public class Spell_Utsuho : SpellBase
	{
		// Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x6FE180", Offset = "0x6FCB80", VA = "0x1806FE180", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x6FE1B0", Offset = "0x6FCBB0", VA = "0x1806FE1B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x6FE080", Offset = "0x6FCA80", VA = "0x1806FE080")]
		private void NuclearBombWhenQteFail(CookController cookController)
		{
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x6FE240", Offset = "0x6FCC40", VA = "0x1806FE240", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Utsuho()
		{
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x6FE480", Offset = "0x6FCE80", VA = "0x1806FE480")]
		[CompilerGenerated]
		internal static string <OnPositiveBuffExecute>g__OnGettingCurrentBuffContext|24_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int postiveDuration;

		// Token: 0x040039B5 RID: 14773
		[Token(Token = "0x40039B5")]
		[FieldOffset(Offset = "0x20")]
		public Cooker.CookerType[] cookerTypes;

		// Token: 0x040039B6 RID: 14774
		[Token(Token = "0x40039B6")]
		[FieldOffset(Offset = "0x28")]
		public float multiper;

		// Token: 0x040039B7 RID: 14775
		[Token(Token = "0x40039B7")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2Int scaredGuestNum;

		// Token: 0x040039B8 RID: 14776
		[Token(Token = "0x40039B8")]
		[FieldOffset(Offset = "0x38")]
		[Header("Effect")]
		public GameObject tokamakEffect;

		// Token: 0x040039B9 RID: 14777
		[Token(Token = "0x40039B9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject flareEffect;

		// Token: 0x040039BA RID: 14778
		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject controlRodEffect;

		// Token: 0x040039BB RID: 14779
		[Token(Token = "0x40039BB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject nuclearFireEffect;

		// Token: 0x040039BC RID: 14780
		[Token(Token = "0x40039BC")]
		[FieldOffset(Offset = "0x58")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset scaredGuestsTXT;

		// Token: 0x040039BD RID: 14781
		[Token(Token = "0x40039BD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject nuclearEffectParent;

		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		[FieldOffset(Offset = "0x68")]
		public GameObject brokenCookParent;

		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip bomb;

		// Token: 0x040039C0 RID: 14784
		[Token(Token = "0x40039C0")]
		[FieldOffset(Offset = "0x78")]
		public LoopedBGMPackage warningSFX;

		// Token: 0x040039C1 RID: 14785
		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0x80")]
		public float nuclearEffectDuration;

		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0x84")]
		public float warningDuration;

		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		[FieldOffset(Offset = "0x88")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip dropSFX;

		// Token: 0x040039C4 RID: 14788
		[Token(Token = "0x40039C4")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip chargeSFX;

		// Token: 0x040039C5 RID: 14789
		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0xA8")]
		public SpellBase.DelayAudioClip boomSFX;

		// Token: 0x040039C6 RID: 14790
		[Token(Token = "0x40039C6")]
		[FieldOffset(Offset = "0xB8")]
		public AudioClip energySFX;

		// Token: 0x040039C7 RID: 14791
		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip punishmentSFX;

		// Token: 0x040039C8 RID: 14792
		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0xD0")]
		public AudioClip punishmentFireSFX;
	}
}

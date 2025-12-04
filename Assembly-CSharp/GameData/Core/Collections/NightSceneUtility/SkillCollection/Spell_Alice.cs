using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000937 RID: 2359
	[Token(Token = "0x2000937")]
	[CreateAssetMenu(fileName = "Spell_Alice", menuName = "Spells/Alice", order = 41)]
	public class Spell_Alice : SpellBase
	{
		// Token: 0x06003AA4 RID: 15012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x693510", Offset = "0x691F10", VA = "0x180693510", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x693540", Offset = "0x691F40", VA = "0x180693540", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x6935D0", Offset = "0x691FD0", VA = "0x1806935D0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA7")]
		[Address(RVA = "0x6936E0", Offset = "0x6920E0", VA = "0x1806936E0")]
		public Spell_Alice()
		{
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x693660", Offset = "0x692060", VA = "0x180693660")]
		[CompilerGenerated]
		internal static IEnumerator <OnNegativeBuffExecute>g__ResetVisual|14_2(CookController cookController, float delay)
		{
			return null;
		}

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x18")]
		[Header("Value")]
		public int negativeDurationSec;

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x1C")]
		public int boomedCookerNum;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x20")]
		[Header("Effect")]
		public GameObject rewardDoll;

		// Token: 0x040031C6 RID: 12742
		[Token(Token = "0x40031C6")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 handOffset;

		// Token: 0x040031C7 RID: 12743
		[Token(Token = "0x40031C7")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip rewardSFX;

		// Token: 0x040031C8 RID: 12744
		[Token(Token = "0x40031C8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject punishmentDoll;

		// Token: 0x040031C9 RID: 12745
		[Token(Token = "0x40031C9")]
		[FieldOffset(Offset = "0x40")]
		public float dollFlyTime;

		// Token: 0x040031CA RID: 12746
		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject punishmentBoomEffect;

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject punishmentCookerEffectNormal;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x58")]
		public GameObject punishmentCookerEffectDrop;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x60")]
		public float launchSpeed;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x64")]
		public float launchHeight;

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip punishmentSFX;
	}
}

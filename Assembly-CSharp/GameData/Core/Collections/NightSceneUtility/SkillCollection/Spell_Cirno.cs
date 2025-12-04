using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	[CreateAssetMenu(fileName = "Spell_Cirno", menuName = "Spells/Cirno", order = 28)]
	public class Spell_Cirno : SpellBase
	{
		// Token: 0x06003B29 RID: 15145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x69C700", Offset = "0x69B100", VA = "0x18069C700", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x69C730", Offset = "0x69B130", VA = "0x18069C730", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x69C7C0", Offset = "0x69B1C0", VA = "0x18069C7C0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Cirno()
		{
		}

		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int giveIceNumMin;

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x1C")]
		public int giveIceNumMax;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x20")]
		public int giveBevNum;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x24")]
		public int iceItemId;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x28")]
		public int iceAvailableBevTagId;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x2C")]
		public int bevMaxPrice;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x30")]
		public int lockCookerNum;

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		[FieldOffset(Offset = "0x34")]
		public int lockCookerDuration;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		[FieldOffset(Offset = "0x38")]
		[Header("Effect")]
		public GameObject giveIceItem;

		// Token: 0x04003297 RID: 12951
		[Token(Token = "0x4003297")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip iceInAirSFX;

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip itemGetSFX;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x50")]
		public float intervalGameObjectTime;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x54")]
		public float iceFlyingTime;

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x58")]
		public float waitIceMeltingTime;

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x5C")]
		public float itemMinDashDistance;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x60")]
		public float itemMaxDashDistance;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x64")]
		public float itemControlPoint1AngularOffset;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x68")]
		public float itemControlPoint2AngularOffset;

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x6C")]
		public float iceInAirDuration;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x70")]
		public float iceInAirEndOffset;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x78")]
		public GameObject endIceEffect;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x80")]
		public float endIceDuration;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x88")]
		public GameObject perfectFreezeEffect;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip iceFieldSFX;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x98")]
		public float negativeEffectDuration;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0xA0")]
		public AudioClip iceGenerateSFX;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject iceFogEffect;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0xB0")]
		public float iceFogOffset;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0xB4")]
		public float iceMeltTime;
	}
}

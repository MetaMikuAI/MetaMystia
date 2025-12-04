using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009AD RID: 2477
	[Token(Token = "0x20009AD")]
	[CreateAssetMenu(fileName = "Spell_Marisa", menuName = "Spells/Marisa", order = 10)]
	public class Spell_Marisa : SpellBase
	{
		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x6B2970", Offset = "0x6B1370", VA = "0x1806B2970", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x6B29A0", Offset = "0x6B13A0", VA = "0x1806B29A0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x6B24A0", Offset = "0x6B0EA0", VA = "0x1806B24A0")]
		private Sprite MarisaStealImportantThings(int thingsType)
		{
			return null;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x6B2A30", Offset = "0x6B1430", VA = "0x1806B2A30", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x6B2B80", Offset = "0x6B1580", VA = "0x1806B2B80")]
		public Spell_Marisa()
		{
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00016C20 File Offset: 0x00014E20
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x6B2AC0", Offset = "0x6B14C0", VA = "0x1806B2AC0")]
		[CompilerGenerated]
		internal static Vector3 <OnNegativeBuffExecute>g__getRandomPos|30_2()
		{
			return default(Vector3);
		}

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int giveMushroomNum;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x1C")]
		public float readyToFly;

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x20")]
		public float dashTime;

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x24")]
		public float waitToEscape;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 whereToEscape;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x34")]
		public float escapeTime;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x38")]
		public int stealThingNum;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x3C")]
		public float mushroomStartSpeed;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x40")]
		public float mushroomStartToDash;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x44")]
		public float mushroomRotate;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x48")]
		public float mushroomAddSpeed;

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0x4C")]
		public float mushroomEndSpeed;

		// Token: 0x040034A5 RID: 13477
		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0x50")]
		public float cameraShakeAmplitude;

		// Token: 0x040034A6 RID: 13478
		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x54")]
		public float cameraShakeDuration;

		// Token: 0x040034A7 RID: 13479
		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0x58")]
		public float cameraShakeFade;

		// Token: 0x040034A8 RID: 13480
		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0x60")]
		[Header("Effects")]
		public GameObject magicArrayEffect;

		// Token: 0x040034A9 RID: 13481
		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0x68")]
		public GameObject magicExplosionEffect;

		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x70")]
		public GameObject mushroomMilkyWay;

		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x78")]
		public float magicArrayDuration;

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x7C")]
		public float magicExplosionDuration;

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x80")]
		public float milkyWayDuration;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x84")]
		public float milkyWayEffectsDuration;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x88")]
		public GameObject eyeEffect;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x90")]
		public GameObject punishmenPic;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x98")]
		public GameObject punishmentEffect;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject stolenThing;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0xA8")]
		public RuntimeAnimatorController punishAnim;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0xB0")]
		public float punishmentPicDuration;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0xB4")]
		public float effectDelay;
	}
}

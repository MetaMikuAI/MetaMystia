using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009B6 RID: 2486
	[Token(Token = "0x20009B6")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Medicine", menuName = "Spells/DLC4/Medicine", order = 1)]
	public class Spell_Medicine : SpellBase
	{
		// Token: 0x06003D26 RID: 15654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x6B2BA0", Offset = "0x6B15A0", VA = "0x1806B2BA0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x6B2BD0", Offset = "0x6B15D0", VA = "0x1806B2BD0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x6B2C60", Offset = "0x6B1660", VA = "0x1806B2C60", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x6B2CE0", Offset = "0x6B16E0", VA = "0x1806B2CE0")]
		public Spell_Medicine()
		{
		}

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		private const int MIDDLE_BERVERAGE_TAG = 1;

		// Token: 0x040034D5 RID: 13525
		[Token(Token = "0x40034D5")]
		private const int MEDICINE_SPECIAL_FOOD_TAG = 4000;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		private const string LINGLING_ARRIVE = "Arrive";

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		private const string LINGLING_END = "End";

		// Token: 0x040034D8 RID: 13528
		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x18")]
		public int giveBevNum;

		// Token: 0x040034D9 RID: 13529
		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x1C")]
		public int positiveDuration;

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x040034DB RID: 13531
		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x28")]
		[Header("VFX")]
		public GameObject suspiciousStewVFX;

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x30")]
		public float rewardAnimDuration;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x34")]
		public float rewardSpawnDuration;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x38")]
		public float rewardFlyDuration;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x3C")]
		public float rewardFlyOffset;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x40")]
		[Header("PunishementVFX")]
		public GameObject linglingVFX;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject poisonVFX;

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x50")]
		public float poisonVFXDuration;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 linglingSpawnOffset;

		// Token: 0x040034E4 RID: 13540
		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0x60")]
		[Header("起飞")]
		public float linglingAppearDuration;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x64")]
		public float linglingArriveTime;

		// Token: 0x040034E6 RID: 13542
		[Token(Token = "0x40034E6")]
		[FieldOffset(Offset = "0x68")]
		[Header("浮动")]
		public float linglingSinAmplitude;

		// Token: 0x040034E7 RID: 13543
		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0x6C")]
		public float linglingSinPeriodicity;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x70")]
		public float linglingSpeed;

		// Token: 0x040034E9 RID: 13545
		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0x74")]
		public Vector2 linglingSinOffset;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x7C")]
		public float linglingSinArrivePointOffsetX;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x80")]
		public float linglingMinDashDistance;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x84")]
		public float linglingMaxDashDistance;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x88")]
		public float linglingControlPoint1AngularOffset;

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x8C")]
		public float linglingControlPoint2AngularOffset;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0x90")]
		[Header("回归")]
		public float linglingEndHide;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x94")]
		public float linglingDisAppearTime;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x98")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip craftSfx;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0xA8")]
		public SpellBase.DelayAudioClip resultSfx;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0xB8")]
		public SpellBase.DelayAudioClip dashSfx;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0xC8")]
		public SpellBase.DelayAudioClip poisonSfx;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0xD8")]
		private readonly int s_Arrive;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0xDC")]
		private readonly int s_End;
	}
}

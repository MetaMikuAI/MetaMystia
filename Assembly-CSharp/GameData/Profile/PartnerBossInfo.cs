using System;
using System.Collections.Generic;
using System.Text;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class PartnerBossInfo : PartnerInfo
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06004B83 RID: 19331 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x17000AD5")]
		protected override bool DoNotShowRevenueCut
		{
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06004B84 RID: 19332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD6")]
		public Cooker.CookerType[] PreferCookerType
		{
			[Token(Token = "0x6004B84")]
			[Address(RVA = "0x782A90", Offset = "0x781490", VA = "0x180782A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06004B85 RID: 19333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD7")]
		public int[] PreferTags
		{
			[Token(Token = "0x6004B85")]
			[Address(RVA = "0x782AE0", Offset = "0x7814E0", VA = "0x180782AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x17000AD8")]
		public float TipRate
		{
			[Token(Token = "0x6004B86")]
			[Address(RVA = "0x782B70", Offset = "0x781570", VA = "0x180782B70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x0001B450 File Offset: 0x00019650
		[Token(Token = "0x17000AD9")]
		protected float CookSpeedMultiplier
		{
			[Token(Token = "0x6004B87")]
			[Address(RVA = "0x7827C0", Offset = "0x7811C0", VA = "0x1807827C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x17000ADA")]
		public override float MoveSpdMultiplier
		{
			[Token(Token = "0x6004B88")]
			[Address(RVA = "0x7829A0", Offset = "0x7813A0", VA = "0x1807829A0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06004B89 RID: 19337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADB")]
		public List<PartnerBossInfo.EvalCondition> EvalConditions
		{
			[Token(Token = "0x6004B89")]
			[Address(RVA = "0x7828A0", Offset = "0x7812A0", VA = "0x1807828A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06004B8A RID: 19338 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x17000ADC")]
		public float NormalGuestServeWeight
		{
			[Token(Token = "0x6004B8A")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "10")]
		public override PartnerInfoBase.PartnerType GetPartnerType()
		{
			return PartnerInfoBase.PartnerType.Normal;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x782690", Offset = "0x781090", VA = "0x180782690", Slot = "24")]
		public virtual string GetBossSpecialSkill()
		{
			return null;
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x782740", Offset = "0x781140", VA = "0x180782740", Slot = "21")]
		protected override void PreProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "25")]
		public virtual void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, object[] additionalData)
		{
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x7826C0", Offset = "0x7810C0", VA = "0x1807826C0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public PartnerBossInfo()
		{
		}

		// Token: 0x0400456E RID: 17774
		[Token(Token = "0x400456E")]
		[FieldOffset(Offset = "0x58")]
		[Header("Boss等级")]
		[SerializeField]
		[Range(0f, 50f)]
		private int level;

		// Token: 0x0400456F RID: 17775
		[Token(Token = "0x400456F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("厨具偏好")]
		private Cooker.CookerType[] preferCookerType;

		// Token: 0x04004570 RID: 17776
		[Token(Token = "0x4004570")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Tag偏好")]
		private int[] preferTags;

		// Token: 0x04004571 RID: 17777
		[Token(Token = "0x4004571")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[SerializeField]
		[Header("普通顾客服务权重")]
		private float normalGuestServeWeight;

		// Token: 0x04004572 RID: 17778
		[Token(Token = "0x4004572")]
		[FieldOffset(Offset = "0x74")]
		[Header("稀客评价权重")]
		[SerializeField]
		private PartnerBossInfo.SpecGuestSatisfyWeight specGuestSatisfyWeight;

		// Token: 0x02000CA7 RID: 3239
		[Token(Token = "0x2000CA7")]
		public enum EvalCondition
		{
			// Token: 0x04004574 RID: 17780
			[Token(Token = "0x4004574")]
			None,
			// Token: 0x04004575 RID: 17781
			[Token(Token = "0x4004575")]
			Normal,
			// Token: 0x04004576 RID: 17782
			[Token(Token = "0x4004576")]
			Good,
			// Token: 0x04004577 RID: 17783
			[Token(Token = "0x4004577")]
			ExGood
		}

		// Token: 0x02000CA8 RID: 3240
		[Token(Token = "0x2000CA8")]
		[Serializable]
		public struct SpecGuestSatisfyWeight
		{
			// Token: 0x06004B91 RID: 19345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B91")]
			[Address(RVA = "0x783A10", Offset = "0x782410", VA = "0x180783A10")]
			public SpecGuestSatisfyWeight(int normalEvalWeight, int goodEvalWeight, int exGoodEvalWeight)
			{
			}

			// Token: 0x04004578 RID: 17784
			[Token(Token = "0x4004578")]
			[FieldOffset(Offset = "0x0")]
			public int NormalEvalWeight;

			// Token: 0x04004579 RID: 17785
			[Token(Token = "0x4004579")]
			[FieldOffset(Offset = "0x4")]
			public int GoodEvalWeight;

			// Token: 0x0400457A RID: 17786
			[Token(Token = "0x400457A")]
			[FieldOffset(Offset = "0x8")]
			public int ExGoodEvalWeight;
		}
	}
}

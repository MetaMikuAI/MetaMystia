using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BEE RID: 3054
	[Token(Token = "0x2000BEE")]
	[CreateAssetMenu(fileName = "DLC2_KoishiBossData", menuName = "GameData Profile/BossData/DLC2_KoishiBossData", order = 5)]
	public class DLC2_KoishiBossData : BossData
	{
		// Token: 0x06004783 RID: 18307 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x7352E0", Offset = "0x733CE0", VA = "0x1807352E0")]
		private DLC2_KoishiBossData.KoishiBossData GetBossData()
		{
			return default(DLC2_KoishiBossData.KoishiBossData);
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004784")]
		[Address(RVA = "0x735F60", Offset = "0x734960", VA = "0x180735F60", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004785")]
		[Address(RVA = "0x7361D0", Offset = "0x734BD0", VA = "0x1807361D0")]
		public DLC2_KoishiBossData()
		{
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x6004786")]
		[Address(RVA = "0x736010", Offset = "0x734A10", VA = "0x180736010")]
		[CompilerGenerated]
		internal static bool <GetBossData>g__ifHaveData|12_0(int lineId, out int finalNum, ref DLC2_KoishiBossData.<>c__DisplayClass12_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x040040B6 RID: 16566
		[Token(Token = "0x40040B6")]
		private const int KOISHI_ID = 2006;

		// Token: 0x040040B7 RID: 16567
		[Token(Token = "0x40040B7")]
		[FieldOffset(Offset = "0x30")]
		[Header("- Koishi Boss Data")]
		public DLC2_KoishiBossData.KoishiBossData koishidata;

		// Token: 0x040040B8 RID: 16568
		[Token(Token = "0x40040B8")]
		[FieldOffset(Offset = "0x118")]
		public DLC2_KoishiBossData.KoishiBossData koishiDataNormal;

		// Token: 0x040040B9 RID: 16569
		[Token(Token = "0x40040B9")]
		[FieldOffset(Offset = "0x200")]
		public DLC2_KoishiBossData.KoishiBossData koishiDataHard;

		// Token: 0x040040BA RID: 16570
		[Token(Token = "0x40040BA")]
		[FieldOffset(Offset = "0x2E8")]
		public DLC2_KoishiBossData.KoishiBossData koishiDataLunatic;

		// Token: 0x040040BB RID: 16571
		[Token(Token = "0x40040BB")]
		[FieldOffset(Offset = "0x3D0")]
		public Color satoriColor;

		// Token: 0x040040BC RID: 16572
		[Token(Token = "0x40040BC")]
		[FieldOffset(Offset = "0x3E0")]
		public Color koishiColor;

		// Token: 0x040040BD RID: 16573
		[Token(Token = "0x40040BD")]
		[FieldOffset(Offset = "0x3F0")]
		public GameObject tipEffect;

		// Token: 0x040040BE RID: 16574
		[Token(Token = "0x40040BE")]
		[FieldOffset(Offset = "0x3F8")]
		public GameObject waveEffect;

		// Token: 0x040040BF RID: 16575
		[Token(Token = "0x40040BF")]
		[FieldOffset(Offset = "0x400")]
		public AudioClip hideSFX;

		// Token: 0x040040C0 RID: 16576
		[Token(Token = "0x40040C0")]
		[FieldOffset(Offset = "0x408")]
		public float radiusShake;

		// Token: 0x040040C1 RID: 16577
		[Token(Token = "0x40040C1")]
		[FieldOffset(Offset = "0x40C")]
		public float waitForGuestLeaveDelay;

		// Token: 0x02000BEF RID: 3055
		[Token(Token = "0x2000BEF")]
		[Serializable]
		public struct KoishiBossData
		{
			// Token: 0x040040C2 RID: 16578
			[Token(Token = "0x40040C2")]
			[FieldOffset(Offset = "0x0")]
			[Header("解锁徽章")]
			public int koishiBadgeId;

			// Token: 0x040040C3 RID: 16579
			[Token(Token = "0x40040C3")]
			[FieldOffset(Offset = "0x4")]
			[Header("第一阶段时间")]
			public int koishiPhase1Time;

			// Token: 0x040040C4 RID: 16580
			[Token(Token = "0x40040C4")]
			[FieldOffset(Offset = "0x8")]
			[Header("第一阶段目标分数")]
			public int phase1TargetScore;

			// Token: 0x040040C5 RID: 16581
			[Token(Token = "0x40040C5")]
			[FieldOffset(Offset = "0x10")]
			[Header("第一阶段目标客人出没雀食堂id")]
			public int[] izakayaIndexArray;

			// Token: 0x040040C6 RID: 16582
			[Token(Token = "0x40040C6")]
			[FieldOffset(Offset = "0x18")]
			[Header("第一阶段目标客人携带金额")]
			public Vector2Int basicBaseFundRange;

			// Token: 0x040040C7 RID: 16583
			[Token(Token = "0x40040C7")]
			[FieldOffset(Offset = "0x20")]
			[Header("第一阶段目标客人刷新速率")]
			public Vector2Int basicNormalGuestInterval;

			// Token: 0x040040C8 RID: 16584
			[Token(Token = "0x40040C8")]
			[FieldOffset(Offset = "0x28")]
			[Header("禁闭之瞳图片")]
			public Sprite closedKoishiEyeObject;

			// Token: 0x040040C9 RID: 16585
			[Token(Token = "0x40040C9")]
			[FieldOffset(Offset = "0x30")]
			[Header("第二阶段时间")]
			public int koishiPhase2Time;

			// Token: 0x040040CA RID: 16586
			[Token(Token = "0x40040CA")]
			[FieldOffset(Offset = "0x34")]
			[Header("第二阶段目标分数")]
			public int phase2TargetScore;

			// Token: 0x040040CB RID: 16587
			[Token(Token = "0x40040CB")]
			[FieldOffset(Offset = "0x38")]
			[Header("'怪诞料理'tag池")]
			public int[] wackyFoodTagPool;

			// Token: 0x040040CC RID: 16588
			[Token(Token = "0x40040CC")]
			[FieldOffset(Offset = "0x40")]
			[Header("禁用客人ID")]
			public int[] banGuestId;

			// Token: 0x040040CD RID: 16589
			[Token(Token = "0x40040CD")]
			[FieldOffset(Offset = "0x48")]
			[Header("满足1个tag加的分数")]
			public int satisfy1TagScore;

			// Token: 0x040040CE RID: 16590
			[Token(Token = "0x40040CE")]
			[FieldOffset(Offset = "0x4C")]
			[Header("不满足额外tag加的分数")]
			public int notSatisfyTagScore;

			// Token: 0x040040CF RID: 16591
			[Token(Token = "0x40040CF")]
			[FieldOffset(Offset = "0x50")]
			[Header("'怪诞料理tag'刷新时间")]
			public int tagRefreshTime;

			// Token: 0x040040D0 RID: 16592
			[Token(Token = "0x40040D0")]
			[FieldOffset(Offset = "0x54")]
			[Header("第二阶段目标客人刷新速率")]
			public Vector2Int phase2SpecialGuestInterval;

			// Token: 0x040040D1 RID: 16593
			[Token(Token = "0x40040D1")]
			[FieldOffset(Offset = "0x5C")]
			[Header("第三阶段时间")]
			public int koishiPhase3Time;

			// Token: 0x040040D2 RID: 16594
			[Token(Token = "0x40040D2")]
			[FieldOffset(Offset = "0x60")]
			[Header("第三阶段目标分数")]
			public int phase3TargetScore;

			// Token: 0x040040D3 RID: 16595
			[Token(Token = "0x40040D3")]
			[FieldOffset(Offset = "0x64")]
			[Header("无意识效果持续时间")]
			public int unconsciousTime;

			// Token: 0x040040D4 RID: 16596
			[Token(Token = "0x40040D4")]
			[FieldOffset(Offset = "0x68")]
			[Header("心灵封闭状态解除持续时间")]
			public int durationPerWave;

			// Token: 0x040040D5 RID: 16597
			[Token(Token = "0x40040D5")]
			[FieldOffset(Offset = "0x6C")]
			[Header("心灵封闭解除状态下受到伤害上限")]
			public int maxDamagePerWave;

			// Token: 0x040040D6 RID: 16598
			[Token(Token = "0x40040D6")]
			[FieldOffset(Offset = "0x70")]
			[Header("惩罚进入心灵封闭状态回复血量")]
			public int lockHeartRecoverHp;

			// Token: 0x040040D7 RID: 16599
			[Token(Token = "0x40040D7")]
			[FieldOffset(Offset = "0x74")]
			[Header("生成的tag标签数量")]
			public Vector3Int preferTagType;

			// Token: 0x040040D8 RID: 16600
			[Token(Token = "0x40040D8")]
			[FieldOffset(Offset = "0x80")]
			[Header("对应等级的料理可造成的伤害")]
			public Vector2Int[] levelToDamage;

			// Token: 0x040040D9 RID: 16601
			[Token(Token = "0x40040D9")]
			[FieldOffset(Offset = "0x88")]
			[Header("破防失败X次后会刷新全场")]
			public int maxTimeTobreakShield;

			// Token: 0x040040DA RID: 16602
			[Token(Token = "0x40040DA")]
			[FieldOffset(Offset = "0x8C")]
			[Header("'怪诞料理tag'阶段三刷新时间")]
			public int phase3TagRefreshTime;

			// Token: 0x040040DB RID: 16603
			[Token(Token = "0x40040DB")]
			[FieldOffset(Offset = "0x90")]
			[Header("隐藏物图标")]
			public GameObject icon;

			// Token: 0x040040DC RID: 16604
			[Token(Token = "0x40040DC")]
			[FieldOffset(Offset = "0x98")]
			public Sprite[] iconSprites;

			// Token: 0x040040DD RID: 16605
			[Token(Token = "0x40040DD")]
			[FieldOffset(Offset = "0xA0")]
			[Header("Tag类型图片")]
			public GameObject likeFoodTag;

			// Token: 0x040040DE RID: 16606
			[Token(Token = "0x40040DE")]
			[FieldOffset(Offset = "0xA8")]
			[Header("Tag类型图片")]
			public GameObject hateFoodTag;

			// Token: 0x040040DF RID: 16607
			[Token(Token = "0x40040DF")]
			[FieldOffset(Offset = "0xB0")]
			[Header("Tag类型图片")]
			public GameObject likeBevTag;

			// Token: 0x040040E0 RID: 16608
			[Token(Token = "0x40040E0")]
			[FieldOffset(Offset = "0xB8")]
			[Header("护盾特效")]
			public GameObject highLightEffect;

			// Token: 0x040040E1 RID: 16609
			[Token(Token = "0x40040E1")]
			[FieldOffset(Offset = "0xC0")]
			public Sprite noHopeFace;

			// Token: 0x040040E2 RID: 16610
			[Token(Token = "0x40040E2")]
			[FieldOffset(Offset = "0xC8")]
			public GameObject breakEffect;

			// Token: 0x040040E3 RID: 16611
			[Token(Token = "0x40040E3")]
			[FieldOffset(Offset = "0xD0")]
			[Header("第三阶段不会出现的tag池")]
			public int[] phase3BanTagPool;

			// Token: 0x040040E4 RID: 16612
			[Token(Token = "0x40040E4")]
			[FieldOffset(Offset = "0xD8")]
			[Header("恋恋分身材质")]
			public Material ghostCharacter;

			// Token: 0x040040E5 RID: 16613
			[Token(Token = "0x40040E5")]
			[FieldOffset(Offset = "0xE0")]
			[Header("恋恋分身眼睛材质")]
			public Material ghostCharacterEyes;
		}
	}
}

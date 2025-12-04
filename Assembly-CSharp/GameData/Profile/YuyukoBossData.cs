using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000C63")]
	[CreateAssetMenu(fileName = "YuyukoBossData", menuName = "GameData Profile/BossData/YuyukoBossData", order = 3)]
	public class YuyukoBossData : BossData
	{
		// Token: 0x06004A13 RID: 18963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x791620", Offset = "0x790020", VA = "0x180791620", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x764840", Offset = "0x763240", VA = "0x180764840")]
		public YuyukoBossData()
		{
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x0001AD18 File Offset: 0x00018F18
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x7916E0", Offset = "0x7900E0", VA = "0x1807916E0")]
		[CompilerGenerated]
		internal static bool <MainChallengeLoop>g__NormalOrSpecial|16_48()
		{
			return default(bool);
		}

		// Token: 0x04004435 RID: 17461
		[Token(Token = "0x4004435")]
		private const int YUYUKO_ID = 23;

		// Token: 0x04004436 RID: 17462
		[Token(Token = "0x4004436")]
		private const int CHALLENGE_YUYUKO_ID = 40;

		// Token: 0x04004437 RID: 17463
		[Token(Token = "0x4004437")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected int singleRoundDuration;

		// Token: 0x04004438 RID: 17464
		[Token(Token = "0x4004438")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("- Challenge Yuyuko")]
		private int phase1TargetPoints;

		// Token: 0x04004439 RID: 17465
		[Token(Token = "0x4004439")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int phase1GuestSpawnInterval;

		// Token: 0x0400443A RID: 17466
		[Token(Token = "0x400443A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int phase2TargetPositiveSpells;

		// Token: 0x0400443B RID: 17467
		[Token(Token = "0x400443B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int phase2GuestSpawnInterval;

		// Token: 0x0400443C RID: 17468
		[Token(Token = "0x400443C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int phase2NegativeSpellInterval;

		// Token: 0x0400443D RID: 17469
		[Token(Token = "0x400443D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int phase3YuyukoTotalLife;

		// Token: 0x0400443E RID: 17470
		[Token(Token = "0x400443E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2Int[] phase3FoodLevelToYuyukoHpData;

		// Token: 0x0400443F RID: 17471
		[Token(Token = "0x400443F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int[] allLevel3IzakayaIds;

		// Token: 0x04004440 RID: 17472
		[Token(Token = "0x4004440")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("- Challenge Yuyuko_Retake BOSS Battle")]
		private float phase3ChallengeModePatienceDecreaseMultiplier;

		// Token: 0x04004441 RID: 17473
		[Token(Token = "0x4004441")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int phase3DamageWhenStandBeCompletelyDefeated;

		// Token: 0x04004442 RID: 17474
		[Token(Token = "0x4004442")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int phase3DamageWhenStandBeNormalDefeated;

		// Token: 0x04004443 RID: 17475
		[Token(Token = "0x4004443")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int phase3YuyukoStandSpawnInterval;

		// Token: 0x04004444 RID: 17476
		[Token(Token = "0x4004444")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject yuyukoEatEffect;
	}
}

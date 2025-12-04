using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BDA RID: 3034
	[Token(Token = "0x2000BDA")]
	[CreateAssetMenu(fileName = "DLC1_YuumaBossData", menuName = "GameData Profile/BossData/DLC1_YuumaBossData", order = 4)]
	public class DLC1_YuumaBossData : BossData
	{
		// Token: 0x060046EB RID: 18155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x735220", Offset = "0x733C20", VA = "0x180735220", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x7330B0", Offset = "0x731AB0", VA = "0x1807330B0")]
		public DLC1_YuumaBossData()
		{
		}

		// Token: 0x0400401C RID: 16412
		[Token(Token = "0x400401C")]
		private const int YUUMA_ID = 1003;

		// Token: 0x0400401D RID: 16413
		[Token(Token = "0x400401D")]
		private const string CHALLENGESUCCESS_EVENT_ID = "DLC1_Main_Toutetsu_004_Challange_Success";

		// Token: 0x0400401E RID: 16414
		[Token(Token = "0x400401E")]
		[FieldOffset(Offset = "0x30")]
		[Header("- DLC1 Yuuma Challenge Boss Data")]
		[SerializeField]
		protected int singleRoundDuration;

		// Token: 0x0400401F RID: 16415
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject tutorialObject;

		// Token: 0x04004020 RID: 16416
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int phase1YuumaNum;

		// Token: 0x04004021 RID: 16417
		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int phase2YuumaNum;

		// Token: 0x04004022 RID: 16418
		[Token(Token = "0x4004022")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int phase3YuumaNum;

		// Token: 0x04004023 RID: 16419
		[Token(Token = "0x4004023")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int maxAnger;

		// Token: 0x04004024 RID: 16420
		[Token(Token = "0x4004024")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int satisfyTagDamage;

		// Token: 0x04004025 RID: 16421
		[Token(Token = "0x4004025")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int notSatisfyTagDamage;

		// Token: 0x04004026 RID: 16422
		[Token(Token = "0x4004026")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int notSatisfyTagAnger;

		// Token: 0x04004027 RID: 16423
		[Token(Token = "0x4004027")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int notSatisfyOrderAnger;

		// Token: 0x04004028 RID: 16424
		[Token(Token = "0x4004028")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int onPatienceEndAddAnger;

		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int yuumaTotalLife;

		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x400402A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2Int spell1EatIngNum;

		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x400402B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2Int spell2EatIngNum;

		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x400402C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2Int spell2EatBevNum;

		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x400402D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int spell1RestoreLife;

		// Token: 0x0400402E RID: 16430
		[Token(Token = "0x400402E")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int spell2RestoreLife;

		// Token: 0x0400402F RID: 16431
		[Token(Token = "0x400402F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2Int[] tagToAngerReduction;

		// Token: 0x04004030 RID: 16432
		[Token(Token = "0x4004030")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector2Int[] banTagCouple;

		// Token: 0x04004031 RID: 16433
		[Token(Token = "0x4004031")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject yuumaSpellCard1Effect;

		// Token: 0x04004032 RID: 16434
		[Token(Token = "0x4004032")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject yuumaSpellCard2Effect;

		// Token: 0x04004033 RID: 16435
		[Token(Token = "0x4004033")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject yuumaSpellSmokeEffect;

		// Token: 0x04004034 RID: 16436
		[Token(Token = "0x4004034")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject yuumaEnergyVfx;

		// Token: 0x04004035 RID: 16437
		[Token(Token = "0x4004035")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioClip punishmentSFX;
	}
}

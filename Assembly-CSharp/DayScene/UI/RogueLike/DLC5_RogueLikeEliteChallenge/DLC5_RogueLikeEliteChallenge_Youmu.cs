using System;
using System.Collections;
using GameData.Profile;
using GameData.RunTime.NightSceneUtility;
using Il2CppDummyDll;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Youmu", menuName = "DLC5_RogueLikeElite/Youmu", order = 0)]
	public class DLC5_RogueLikeEliteChallenge_Youmu : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A60 RID: 6752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x4955A0", Offset = "0x493FA0", VA = "0x1804955A0", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x4954F0", Offset = "0x493EF0", VA = "0x1804954F0", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x495690", Offset = "0x494090", VA = "0x180495690")]
		private string GetTagName(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x495450", Offset = "0x493E50", VA = "0x180495450", Slot = "6")]
		public override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x4950E0", Offset = "0x493AE0", VA = "0x1804950E0", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x4953A0", Offset = "0x493DA0", VA = "0x1804953A0", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x494BF0", Offset = "0x4935F0", VA = "0x180494BF0", Slot = "9")]
		public override bool CheckNeedNoticeBeforeWork(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, IzakayaConfigure izakayaConfigure, out string message)
		{
			return default(bool);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeEliteChallenge_Youmu()
		{
		}

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		private const string YOUMU_CHALLENGE_1 = "DLC5_ROGUELIKE_SPECIAL_ELITE_YOUMU_1";

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		private const string YOUMU_CHALLENGE_2 = "DLC5_ROGUELIKE_SPECIAL_ELITE_YOUMU_2";

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		private const string YOUMU_CHALLENGE_3 = "DLC5_ROGUELIKE_SPECIAL_ELITE_YOUMU_3";

		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		private const string YOUMU_CHALLENGE_1_INGTYPE = "COMMON_STORAGE_SEAFOOD";

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		private const string YOUMU_CHALLENGE_2_INGTYPE = "COMMON_STORAGE_MEAT";

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		private const string YOUMU_CHALLENGE_3_INGTYPE = "COMMON_STORAGE_VEGGIE";

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		private const string YOUMU_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YOUMU_DES_2";

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		private const string YOUMU_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_YOUMU_DES_EXTRA";

		// Token: 0x04001822 RID: 6178
		[Token(Token = "0x4001822")]
		private const string YOUMU_CHALLENGE_POSTCHECK = "DLC5_ROGUELIKE_ELITE_TIP_CHECK_YOUMU";

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		private const int MEAT_TAG_ID = 0;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		private const int SEA_TAG_ID = 1;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		private const int VEGGIE_TAG_ID = 2;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		private const int YOUMU_ID = 39;
	}
}

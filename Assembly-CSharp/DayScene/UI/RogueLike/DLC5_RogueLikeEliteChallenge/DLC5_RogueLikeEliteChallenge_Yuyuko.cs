using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Yuyuko", menuName = "DLC5_RogueLikeElite/Yuyuko", order = 1)]
	public class DLC5_RogueLikeEliteChallenge_Yuyuko : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x497700", Offset = "0x496100", VA = "0x180497700", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x497640", Offset = "0x496040", VA = "0x180497640", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x497590", Offset = "0x495F90", VA = "0x180497590", Slot = "6")]
		public override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x496B20", Offset = "0x495520", VA = "0x180496B20", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x4974E0", Offset = "0x495EE0", VA = "0x1804974E0", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x497770", Offset = "0x496170", VA = "0x180497770")]
		public DLC5_RogueLikeEliteChallenge_Yuyuko()
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x497740", Offset = "0x496140", VA = "0x180497740")]
		[CompilerGenerated]
		internal static int <EliteBossChallenge>g__GetDamage|12_4(GuestsManager.OrderBase orderBase)
		{
			return 0;
		}

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0x40")]
		public int baseHealthValue;

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0x44")]
		public int extraHPPerWave;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		private const string YUYUKO_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUYUKO";

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		private const string YUUMA_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUYUKO_DES_2";

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		private const string YUUMA_CHALLENGE_END = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUYUKO_DES_3";

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		private const string YUYUKO_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUYUKO_DES_EXTRA";

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		public const string YUYUKO_ELITE_FINISH_LABEL = "YUYUKO_ELITE_FINISH_LABEL";

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		private const int YUYUKO_ID = 12;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		private const int YUYUKO_MAX_HP = 300;
	}
}

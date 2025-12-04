using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Flandre", menuName = "DLC5_RogueLikeElite/Flandre", order = 5)]
	public class DLC5_RogueLikeEliteChallenge_Flandre : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x474A20", Offset = "0x473420", VA = "0x180474A20", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x4748D0", Offset = "0x4732D0", VA = "0x1804748D0", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x474650", Offset = "0x473050", VA = "0x180474650", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x474820", Offset = "0x473220", VA = "0x180474820", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x474A60", Offset = "0x473460", VA = "0x180474A60")]
		public DLC5_RogueLikeEliteChallenge_Flandre()
		{
		}

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0x40")]
		public int extraGuestRate;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x44")]
		public int extraGuestFund;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		private const string FLANDRE_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_REMILIA";

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		private const string FLANDRE_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_REMILIA_DES";

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		private const string FLANDRE_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_REMILIA_DES_EXTRA";

		// Token: 0x040017E7 RID: 6119
		[Token(Token = "0x40017E7")]
		private const int FLANDRE_ID = 4006;
	}
}

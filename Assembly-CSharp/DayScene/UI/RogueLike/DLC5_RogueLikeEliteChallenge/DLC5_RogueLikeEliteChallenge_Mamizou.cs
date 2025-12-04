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
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Mamizou", menuName = "DLC5_RogueLikeElite/Mamizou", order = 4)]
	public class DLC5_RogueLikeEliteChallenge_Mamizou : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x475490", Offset = "0x473E90", VA = "0x180475490", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x475370", Offset = "0x473D70", VA = "0x180475370", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x475080", Offset = "0x473A80", VA = "0x180475080", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x4752C0", Offset = "0x473CC0", VA = "0x1804752C0", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x4754D0", Offset = "0x473ED0", VA = "0x1804754D0")]
		public DLC5_RogueLikeEliteChallenge_Mamizou()
		{
		}

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0x40")]
		public int qteInterval;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x44")]
		public int addDuration;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0x48")]
		public Sprite kyoukouPotroyal;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		private const string MAMIZOU_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_MAMIZOU";

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		private const string MAMIZOU_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_MAMIZOU_DES_2";

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		private const string MAMIZOU_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_MAMIZOU_DES_EXTRA";

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		private const int KYOUKO_ID = 14;
	}
}

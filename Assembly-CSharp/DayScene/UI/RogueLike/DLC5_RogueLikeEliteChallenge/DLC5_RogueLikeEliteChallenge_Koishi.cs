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
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Koishi", menuName = "DLC5_RogueLikeElite/Koishi", order = 3)]
	public class DLC5_RogueLikeEliteChallenge_Koishi : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x474E40", Offset = "0x473840", VA = "0x180474E40", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x474DA0", Offset = "0x4737A0", VA = "0x180474DA0", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x474A80", Offset = "0x473480", VA = "0x180474A80", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x474CF0", Offset = "0x4736F0", VA = "0x180474CF0", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeEliteChallenge_Koishi()
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x474E80", Offset = "0x473880", VA = "0x180474E80")]
		[CompilerGenerated]
		internal static void <EliteBossChallenge>g__OnGuestSpawn|6_0(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x475050", Offset = "0x473A50", VA = "0x180475050")]
		[CompilerGenerated]
		internal static string <EliteBossChallenge>g__OverrideOrderText|6_1(int tagId, string oldText)
		{
			return null;
		}

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		private const string KOISHI_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_KOISHI";

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		private const string KOISHI_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_KOISHI_DES";

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		private const string KOISHI_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_KOISHI_DES_EXTRA";

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		private const int KOISHI_ID = 2006;
	}
}

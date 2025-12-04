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
	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Yuuma", menuName = "DLC5_RogueLikeElite/Yuuma", order = 2)]
	public class DLC5_RogueLikeEliteChallenge_Yuuma : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x4969A0", Offset = "0x4953A0", VA = "0x1804969A0", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x4968F0", Offset = "0x4952F0", VA = "0x1804968F0", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x4965B0", Offset = "0x494FB0", VA = "0x1804965B0", Slot = "6")]
		public override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x496220", Offset = "0x494C20", VA = "0x180496220", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x496500", Offset = "0x494F00", VA = "0x180496500", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x495DC0", Offset = "0x4947C0", VA = "0x180495DC0", Slot = "9")]
		public override bool CheckNeedNoticeBeforeWork(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, IzakayaConfigure izakayaConfigure, out string message)
		{
			return default(bool);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x496AA0", Offset = "0x4954A0", VA = "0x180496AA0")]
		public DLC5_RogueLikeEliteChallenge_Yuuma()
		{
		}

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x40")]
		public int[] exceptTagId;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		private const string YUUMA_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUUMA";

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		private const string YUUMA_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUUMA_DES";

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		private const string YUUMA_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUUMA_DES_EXTRA";

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		private const string YUUMA_CHALLENGE_POSTCHECK = "DLC5_ROGUELIKE_ELITE_TIP_CHECK_YUUMA";

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		private const int YUUMA_ID = 1003;
	}
}

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
	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeEliteChallenge_Yukari", menuName = "DLC5_RogueLikeElite/Yukari", order = 6)]
	public class DLC5_RogueLikeEliteChallenge_Yukari : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x495D70", Offset = "0x494770", VA = "0x180495D70", Slot = "4")]
		public override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			return null;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x495CD0", Offset = "0x4946D0", VA = "0x180495CD0", Slot = "5")]
		public override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			return null;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x495790", Offset = "0x494190", VA = "0x180495790", Slot = "7")]
		public override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x495C20", Offset = "0x494620", VA = "0x180495C20", Slot = "8")]
		public override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			return null;
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x495DB0", Offset = "0x4947B0", VA = "0x180495DB0")]
		public DLC5_RogueLikeEliteChallenge_Yukari()
		{
		}

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x40")]
		public int banTagDuration;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ingredientPrefab;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		private const string YUKARI_CHALLENGE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUKARI";

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		private const string YUKARI_CHALLENGE_TITLE = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUKARI_DES";

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		private const string YUKARI_CHALLENGE_DESCRIPTION = "DLC5_ROGUELIKE_SPECIAL_ELITE_YUKARI_DES_EXTRA";

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		private const int MIZUCHI_ID = 5013;
	}
}

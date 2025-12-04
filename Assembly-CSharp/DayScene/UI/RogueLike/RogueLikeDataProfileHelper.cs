using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.Managers;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	public static class RogueLikeDataProfileHelper
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x47CA30", Offset = "0x47B430", VA = "0x18047CA30")]
		public static DLC5_RogueLikeDataProfile.RogueLikeRoundSetup GetRoundSetup(this IRogueLikeData profile, int currentRoundNum)
		{
			return null;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x47C820", Offset = "0x47B220", VA = "0x18047C820")]
		public static int GetRoundIncomeRequirement(this IRogueLikeData profile, int currentRoundNum, NightSceneDirector.Difficulty difficulty)
		{
			return 0;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x47AD20", Offset = "0x479720", VA = "0x18047AD20")]
		public static Dictionary<int, int> GetBevLevelTable(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x47B510", Offset = "0x479F10", VA = "0x18047B510")]
		public static Dictionary<string, DLC5_RogueLikeDataProfile.MapSetup> GetMapSetup(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x47B0D0", Offset = "0x479AD0", VA = "0x18047B0D0")]
		public static Dictionary<Cooker.CookerSeries, int> GetCookerPrices(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x47BF90", Offset = "0x47A990", VA = "0x18047BF90")]
		public static Dictionary<TriggerCardCondition, TriggerCardData> GetRogueLikeCardTriggerCondition(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x47BD60", Offset = "0x47A760", VA = "0x18047BD60")]
		public static Dictionary<int, RogueLikeCardRewardRate[]> GetRogueLikeCardRewardPairData(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x47CB80", Offset = "0x47B580", VA = "0x18047CB80")]
		public static int GetRounds(this IRogueLikeData profile)
		{
			return 0;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x47C1C0", Offset = "0x47ABC0", VA = "0x18047C1C0")]
		public static Dictionary<RogueLikeCardBase.CardType, RogueLikeCard> GetRogueLikeCards(this IRogueLikeData profile, out Dictionary<RogueLikeCardBase.Rarity, List<RogueLikeCard>> dictionaryByRarity)
		{
			return null;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x47C620", Offset = "0x47B020", VA = "0x18047C620")]
		public static Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent> GetRogueLikePersistentCards(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x47AF20", Offset = "0x479920", VA = "0x18047AF20")]
		public static Dictionary<RogueLikeCardBase.CardType, string[]> GetCardDescriptionLang(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x47B670", Offset = "0x47A070", VA = "0x18047B670")]
		public static Dictionary<int, int> GetPartnerPrice(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x47BB60", Offset = "0x47A560", VA = "0x18047BB60")]
		public static Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> GetRogueLikeAchievement(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x47B860", Offset = "0x47A260", VA = "0x18047B860")]
		public static Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement[]> GetRogueLikeAchievementByTriggerType(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x47CC00", Offset = "0x47B600", VA = "0x18047CC00")]
		public static void GiveBadge(this DLC5_RogueLikeDataProfile.RogueLikeAchievement rogueLikeAchievement)
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x47B300", Offset = "0x479D00", VA = "0x18047B300")]
		public static Dictionary<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase> GetEliteChallengeData(this IRogueLikeData profile)
		{
			return null;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x47CD70", Offset = "0x47B770", VA = "0x18047CD70")]
		public static void OpenTutorialPanel(this IRogueLikeData profile, bool isFirstTutorial, Action onTutorialEndCallback, AdpUIPanelManager.PanelVisualMode lastPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual, [Optional] Action<Action> beforeOpen)
		{
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x47CC50", Offset = "0x47B650", VA = "0x18047CC50")]
		private static UniTask OpenTutorialPanelInternalAsync(this IRogueLikeData profile, bool isFirstTutorial, Action onTutorialEndCallback, AdpUIPanelManager.PanelVisualMode lastPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual, [Optional] Action<Action> beforeOpen)
		{
			return default(UniTask);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x47CE90", Offset = "0x47B890", VA = "0x18047CE90")]
		[CompilerGenerated]
		internal static void <GetRogueLikeCards>g__CheckRarity|8_0(RogueLikeCardBase.Rarity rarity, RogueLikeCard card, ref RogueLikeDataProfileHelper.<>c__DisplayClass8_0 A_2)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;

namespace GameData.RunTime.Common.AchievementSystem
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	public static class DataBaseAchievement
	{
		// Token: 0x06003657 RID: 13911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x65C7D0", Offset = "0x65B1D0", VA = "0x18065C7D0")]
		public static void OnEnterGame()
		{
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x65C020", Offset = "0x65AA20", VA = "0x18065C020")]
		public static void OnAllCollectionPointsAreCollected(string stringData)
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x65C320", Offset = "0x65AD20", VA = "0x18065C320")]
		public static void OnCollectionPointInteraction(string[] stringData)
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x65C9F0", Offset = "0x65B3F0", VA = "0x18065C9F0")]
		public static void OnFinishEvent(string stringData)
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x65C970", Offset = "0x65B370", VA = "0x18065C970")]
		public static void OnFinishEventStart(string stringData)
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x65CBA0", Offset = "0x65B5A0", VA = "0x18065CBA0")]
		public static void OnGetAnyRecipe()
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x65D1D0", Offset = "0x65BBD0", VA = "0x18065D1D0")]
		public static void OnSell10GreenTeas()
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x65D070", Offset = "0x65BA70", VA = "0x18065D070")]
		public static void OnOnlySell30RiceballsAndAllSatisfied()
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x65DD30", Offset = "0x65C730", VA = "0x18065DD30")]
		public static void OnUnsatisfiedTagFood(int tagId, int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x65C820", Offset = "0x65B220", VA = "0x18065C820")]
		public static void OnEvictGuests(int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x65D0C0", Offset = "0x65BAC0", VA = "0x18065D0C0")]
		public static void OnPreMadeFoodCompletelySold()
		{
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x65C520", Offset = "0x65AF20", VA = "0x18065C520")]
		public static void OnCooking(int foodId, int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x65E030", Offset = "0x65CA30", VA = "0x18065E030")]
		public static void OnWithIngredientsAndHighestRating()
		{
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x65DFE0", Offset = "0x65C9E0", VA = "0x18065DFE0")]
		public static void OnWithIngredientsAndHighestRatingAndTriggerRewardSpell()
		{
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x65D8C0", Offset = "0x65C2C0", VA = "0x18065D8C0")]
		public static void OnTriggerRewardSpell(int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x65D420", Offset = "0x65BE20", VA = "0x18065D420")]
		public static void OnTriggerPunishmentSpell(int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x65DA10", Offset = "0x65C410", VA = "0x18065DA10")]
		public static void OnTriggerRewardSpell(string characterId, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x65D570", Offset = "0x65BF70", VA = "0x18065D570")]
		public static void OnTriggerPunishmentSpell(string characterId, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x65D010", Offset = "0x65BA10", VA = "0x18065D010")]
		public static void OnNightQueuing(int intData)
		{
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366A")]
		[Address(RVA = "0x65D170", Offset = "0x65BB70", VA = "0x18065D170")]
		public static void OnReceiveTip(int intData)
		{
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x65D3C0", Offset = "0x65BDC0", VA = "0x18065D3C0")]
		public static void OnTipSettlement(int intData)
		{
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x65D110", Offset = "0x65BB10", VA = "0x18065D110")]
		public static void OnProfitSettlement(int intData)
		{
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x65C0A0", Offset = "0x65AAA0", VA = "0x18065C0A0")]
		public static void OnAnyKizunaLevelUpgrade(int level, int count)
		{
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x65CF10", Offset = "0x65B910", VA = "0x18065CF10")]
		public static void OnGetItem(int itemId)
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x65CBF0", Offset = "0x65B5F0", VA = "0x18065CBF0")]
		public static void OnGetIngredientsFromResourcePt(int id, int amount, int wholeAmount, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x65CB40", Offset = "0x65B540", VA = "0x18065CB40")]
		public static void OnFinishSideMission(int count)
		{
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x65CF70", Offset = "0x65B970", VA = "0x18065CF70")]
		public static void OnKaguyaWin()
		{
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x65CFC0", Offset = "0x65B9C0", VA = "0x18065CFC0")]
		public static void OnMokouWin()
		{
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x65C480", Offset = "0x65AE80", VA = "0x18065C480")]
		public static void OnConcertEnd()
		{
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x65C4D0", Offset = "0x65AED0", VA = "0x18065C4D0")]
		public static void OnConcertGetAllKizuna()
		{
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x65D270", Offset = "0x65BC70", VA = "0x18065D270")]
		public static void OnStrongBuyAndSell(int count, Action<AchievementNotifyResult> resultCallback)
		{
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x65D220", Offset = "0x65BC20", VA = "0x18065D220")]
		public static void OnSellCharacter()
		{
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x65CA70", Offset = "0x65B470", VA = "0x18065CA70")]
		public static void OnFinishEvents(string stringData, string[] allFinsihedData)
		{
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x65B800", Offset = "0x65A200", VA = "0x18065B800")]
		public static void Initialize(AchievementData[] allAchievements)
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x65B250", Offset = "0x659C50", VA = "0x18065B250")]
		public static void CheckAllAchievement()
		{
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x65BF30", Offset = "0x65A930", VA = "0x18065BF30")]
		private static AchievementNotifyResult NotifyAchievement(AchievementType achievementType)
		{
			return null;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x65B780", Offset = "0x65A180", VA = "0x18065B780")]
		private static bool HasAchievementFinished(string achievementId)
		{
			return default(bool);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x65B4B0", Offset = "0x659EB0", VA = "0x18065B4B0")]
		private static void FinishAndCheckAchievement(string achievementId)
		{
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367D")]
		[Address(RVA = "0x65B3F0", Offset = "0x659DF0", VA = "0x18065B3F0")]
		private static void FinishAchievement(string achievementId)
		{
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x600367E")]
		[Address(RVA = "0x65E180", Offset = "0x65CB80", VA = "0x18065E180")]
		private static int SetAchievementValue(string achievementId, string streamVariable, int value, int min, int max)
		{
			return 0;
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x65E080", Offset = "0x65CA80", VA = "0x18065E080")]
		private static int SetAchievementValue_IncrementByOne(string achievementId, string streamVariable, int value, int min, int max)
		{
			return 0;
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x65B670", Offset = "0x65A070", VA = "0x18065B670")]
		private static bool GetAchievementValueFromSteamDatabase(string achievementId, string streamVariable, out int value)
		{
			return default(bool);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private static void TestLog(string title, params object[] values)
		{
		}

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> achievementsId;

		// Token: 0x04002EFA RID: 12026
		[Token(Token = "0x4002EFA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<AchievementType, Func<AchievementNotifyResult>> achievementCollection;

		// Token: 0x04002EFB RID: 12027
		[Token(Token = "0x4002EFB")]
		[FieldOffset(Offset = "0x10")]
		private static string stringBuffer;

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x18")]
		private static int intBuffer;

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x20")]
		private static List<int> intListBuffer;

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x28")]
		private static List<string> stringListBuffer;
	}
}

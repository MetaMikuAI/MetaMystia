using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GamePlatform.Systems;
using Il2CppDummyDll;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	public class RogueLikeAchievementRunTimeData
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000346")]
		public HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> CurrentActiveAchievementTypes
		{
			[Token(Token = "0x6001891")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x479260", Offset = "0x477C60", VA = "0x180479260")]
		public bool CheckAchievementFinished(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType)
		{
			return default(bool);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x4793C0", Offset = "0x477DC0", VA = "0x1804793C0")]
		public bool GetRogueLikeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, out DLC5_RogueLikeDataProfile.RogueLikeAchievement achievement)
		{
			return default(bool);
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000347")]
		public IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> AllRogueLikeAchievementTypes
		{
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x47A9D0", Offset = "0x4793D0", VA = "0x18047A9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000348")]
		public static RogueLikeAchievementRunTimeData Instance
		{
			[Token(Token = "0x6001895")]
			[Address(RVA = "0x47ABB0", Offset = "0x4795B0", VA = "0x18047ABB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x47A490", Offset = "0x478E90", VA = "0x18047A490")]
		private RogueLikeAchievementRunTimeData(HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> currentActiveAchievementTypes, IRogueLikeData rogueLikeData)
		{
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x479310", Offset = "0x477D10", VA = "0x180479310")]
		private static void EnsureInstanceIsNull()
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x479430", Offset = "0x477E30", VA = "0x180479430")]
		public static RogueLikeAchievementRunTimeData InitializeRoguelikeAchievementRunTimeData(HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> currentActiveAchievementTypes, IRogueLikeData rogueLikeData)
		{
			return null;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x4792C0", Offset = "0x477CC0", VA = "0x1804792C0")]
		public static void DisposeRoguelikeAchievementRunTimeData()
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x47A3D0", Offset = "0x478DD0", VA = "0x18047A3D0")]
		public static UniTask WriteRoguelikeAchievementFile(FileSystemHandle fileSystemHandle)
		{
			return default(UniTask);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		public IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievement> GetAchievementWaitForClaim
		{
			[Token(Token = "0x600189B")]
			[Address(RVA = "0x47AA20", Offset = "0x479420", VA = "0x18047AA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034A")]
		private RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[Token(Token = "0x600189C")]
			[Address(RVA = "0x456CA0", Offset = "0x4556A0", VA = "0x180456CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x47A000", Offset = "0x478A00", VA = "0x18047A000")]
		public void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType)
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x47A010", Offset = "0x478A10", VA = "0x18047A010")]
		public void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, int intValue)
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x47A100", Offset = "0x478B00", VA = "0x18047A100")]
		public void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, float floatValue)
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x47A080", Offset = "0x478A80", VA = "0x18047A080")]
		public void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>> cardValue)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x479F70", Offset = "0x478970", VA = "0x180479F70")]
		public void TryTriggerTargetTypeAchievement_LimitPass(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool booleanValue, float floatValue)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x479EE0", Offset = "0x4788E0", VA = "0x180479EE0")]
		public void TryTriggerTargetTypeAchievement_InstantHit(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool booleanValue, int intValue)
		{
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x4793B0", Offset = "0x477DB0", VA = "0x1804793B0")]
		public void ForceTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType)
		{
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x479560", Offset = "0x477F60", VA = "0x180479560")]
		private void NotifyAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool forceTrigger = false)
		{
		}

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x0")]
		private static RogueLikeAchievementRunTimeData s_Instance;

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> m_RogueLikeAchievementDic;

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement[]> m_RogueLikeAchievementTriggerDic;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>> m_ActiveAchievementFunc;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x8")]
		private static int intBuffer;

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0xC")]
		private static float floatBuffer;

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x10")]
		private static bool booleanBuffer;

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x18")]
		private static IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>> cardBuffer;

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x28")]
		private readonly HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_CurrentActiveAchievementTypes;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x30")]
		private readonly string[] m_CoreMaps;
	}
}

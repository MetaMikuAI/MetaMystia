using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddExtraFund", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddExtraFund", order = 12)]
	public class DLC5_RogueLikeCardPersistentAddExtraFund : RogueLikeCardPersistent
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x6DEE30", Offset = "0x6DD830", VA = "0x1806DEE30", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x6DECF0", Offset = "0x6DD6F0", VA = "0x1806DECF0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddExtraFund()
		{
		}

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x40")]
		public float extraFundRate;
	}
}

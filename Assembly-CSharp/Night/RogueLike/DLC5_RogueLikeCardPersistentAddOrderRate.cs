using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddOrderRate", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddOrderRate", order = 4)]
	public class DLC5_RogueLikeCardPersistentAddOrderRate : RogueLikeCardPersistent
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x6DF680", Offset = "0x6DE080", VA = "0x1806DF680", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x6DF4D0", Offset = "0x6DDED0", VA = "0x1806DF4D0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddOrderRate()
		{
		}

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x40")]
		public float extraOrderRate;
	}
}

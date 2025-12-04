using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentShou", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentShou", order = 2101)]
	public class DLC5_RogueLikeCardPersistentShou : RogueLikeCardPersistent
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x82B4F0", Offset = "0x829EF0", VA = "0x18082B4F0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x82B2D0", Offset = "0x829CD0", VA = "0x18082B2D0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x82B4E0", Offset = "0x829EE0", VA = "0x18082B4E0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentShou()
		{
		}

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x40")]
		public int comboPrice;
	}
}

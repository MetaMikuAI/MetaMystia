using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentStone", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentStone", order = 101)]
	public class DLC5_RogueLikeCardPersistentStone : RogueLikeCardPersistent
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x82B790", Offset = "0x82A190", VA = "0x18082B790", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x82B560", Offset = "0x829F60", VA = "0x18082B560", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x82B4E0", Offset = "0x829EE0", VA = "0x18082B4E0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentStone()
		{
		}

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x40")]
		public int stoneNum;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x44")]
		public int startStonePrice;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x48")]
		public int maxStoneNum;
	}
}

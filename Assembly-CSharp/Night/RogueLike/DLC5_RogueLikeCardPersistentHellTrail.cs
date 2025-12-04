using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentHellTrail", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentHellTrail", order = 103)]
	public class DLC5_RogueLikeCardPersistentHellTrail : RogueLikeCardPersistent
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x828F00", Offset = "0x827900", VA = "0x180828F00", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x828D00", Offset = "0x827700", VA = "0x180828D00", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentHellTrail()
		{
		}

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x40")]
		public int m_NeedCombo;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x44")]
		public int m_BeverageLevelLine;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x48")]
		public int m_BeverageNumOverLine;

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x4C")]
		public int m_BeverageNumBelowLine;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x50")]
		public int m_IngredientLevelLine;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x54")]
		public int m_IngredientNumOverLine;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x58")]
		public int m_IngredientNumBelowLine;
	}
}

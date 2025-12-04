using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe", order = 119)]
	public class DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe : RogueLikeCardPersistent
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x6DEF30", Offset = "0x6DD930", VA = "0x1806DEF30", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x6DEEC0", Offset = "0x6DD8C0", VA = "0x1806DEEC0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x6DEFB0", Offset = "0x6DD9B0", VA = "0x1806DEFB0", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x6DEEF0", Offset = "0x6DD8F0", VA = "0x1806DEEF0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe()
		{
		}

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x40")]
		public int addFreeIngredientFromRecipeNum;
	}
}

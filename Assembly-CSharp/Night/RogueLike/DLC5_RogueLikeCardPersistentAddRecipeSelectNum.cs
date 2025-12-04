using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddRecipeSelectNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddRecipeSelectNum", order = 10)]
	public class DLC5_RogueLikeCardPersistentAddRecipeSelectNum : RogueLikeCardPersistent
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x827BF0", Offset = "0x8265F0", VA = "0x180827BF0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x827B40", Offset = "0x826540", VA = "0x180827B40", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x827C60", Offset = "0x826660", VA = "0x180827C60", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x827B70", Offset = "0x826570", VA = "0x180827B70", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x827BB0", Offset = "0x8265B0", VA = "0x180827BB0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddRecipeSelectNum()
		{
		}

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x40")]
		public int extraSelectNum;
	}
}

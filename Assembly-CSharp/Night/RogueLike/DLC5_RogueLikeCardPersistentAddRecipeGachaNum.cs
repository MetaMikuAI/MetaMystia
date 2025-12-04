using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddRecipeGachaNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddRecipeGachaNum", order = 8)]
	public class DLC5_RogueLikeCardPersistentAddRecipeGachaNum : RogueLikeCardPersistent
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x827AA0", Offset = "0x8264A0", VA = "0x180827AA0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x827A30", Offset = "0x826430", VA = "0x180827A30", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x827B10", Offset = "0x826510", VA = "0x180827B10", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x827A60", Offset = "0x826460", VA = "0x180827A60", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddRecipeGachaNum()
		{
		}

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x40")]
		public int extraGachaNum;
	}
}

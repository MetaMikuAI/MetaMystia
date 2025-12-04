using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddSoldBevNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddSoldBevNum", order = 14)]
	public class DLC5_RogueLikeCardPersistentAddSoldBevNum : RogueLikeCardPersistent
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x827CF0", Offset = "0x8266F0", VA = "0x180827CF0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x827C90", Offset = "0x826690", VA = "0x180827C90", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x827D60", Offset = "0x826760", VA = "0x180827D60", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x827CC0", Offset = "0x8266C0", VA = "0x180827CC0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddSoldBevNum()
		{
		}

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x40")]
		public int addSoldNum;
	}
}

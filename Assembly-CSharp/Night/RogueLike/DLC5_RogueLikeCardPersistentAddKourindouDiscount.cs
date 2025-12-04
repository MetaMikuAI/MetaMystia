using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddKourindouDiscount", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddKourindouDiscount", order = 7)]
	public class DLC5_RogueLikeCardPersistentAddKourindouDiscount : RogueLikeCardPersistent
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x6DF270", Offset = "0x6DDC70", VA = "0x1806DF270", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x6DEFE0", Offset = "0x6DD9E0", VA = "0x1806DEFE0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x6DF300", Offset = "0x6DDD00", VA = "0x1806DF300", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x6DF0A0", Offset = "0x6DDAA0", VA = "0x1806DF0A0", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x6DF010", Offset = "0x6DDA10", VA = "0x1806DF010", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddKourindouDiscount()
		{
		}

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x40")]
		public float extraDiscount;
	}
}

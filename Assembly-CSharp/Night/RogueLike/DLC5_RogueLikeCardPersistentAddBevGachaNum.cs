using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddBevGachaNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddBevGachaNum", order = 9)]
	public class DLC5_RogueLikeCardPersistentAddBevGachaNum : RogueLikeCardPersistent
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x6DE9D0", Offset = "0x6DD3D0", VA = "0x1806DE9D0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x6DE960", Offset = "0x6DD360", VA = "0x1806DE960", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x6DEA40", Offset = "0x6DD440", VA = "0x1806DEA40", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x6DE990", Offset = "0x6DD390", VA = "0x1806DE990", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddBevGachaNum()
		{
		}

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x40")]
		public int extraGachaNum;
	}
}

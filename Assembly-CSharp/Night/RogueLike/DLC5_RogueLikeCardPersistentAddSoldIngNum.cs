using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddSoldIngNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddSoldIngNum", order = 15)]
	public class DLC5_RogueLikeCardPersistentAddSoldIngNum : RogueLikeCardPersistent
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x828010", Offset = "0x826A10", VA = "0x180828010", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x827D90", Offset = "0x826790", VA = "0x180827D90", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x8280E0", Offset = "0x826AE0", VA = "0x1808280E0", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x827E40", Offset = "0x826840", VA = "0x180827E40", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x827DC0", Offset = "0x8267C0", VA = "0x180827DC0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddSoldIngNum()
		{
		}

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x40")]
		public float addSoldMultiplier;
	}
}

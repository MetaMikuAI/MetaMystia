using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentDecreaseComboGachaNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentDecreaseComboGachaNum", order = 18)]
	public class DLC5_RogueLikeCardPersistentDecreaseComboGachaNum : RogueLikeCardPersistent
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x828B50", Offset = "0x827550", VA = "0x180828B50", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x828AE0", Offset = "0x8274E0", VA = "0x180828AE0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x828BC0", Offset = "0x8275C0", VA = "0x180828BC0", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x828B10", Offset = "0x827510", VA = "0x180828B10", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentDecreaseComboGachaNum()
		{
		}

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x40")]
		public int decreaseGachaNum;
	}
}

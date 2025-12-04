using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentDecreaseSpellGachaNum", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentDecreaseSpellGachaNum", order = 19)]
	public class DLC5_RogueLikeCardPersistentDecreaseSpellGachaNum : RogueLikeCardPersistent
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x828C60", Offset = "0x827660", VA = "0x180828C60", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x828BF0", Offset = "0x8275F0", VA = "0x180828BF0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x828CD0", Offset = "0x8276D0", VA = "0x180828CD0", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x828C20", Offset = "0x827620", VA = "0x180828C20", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentDecreaseSpellGachaNum()
		{
		}

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x40")]
		public int decreaseGachaNum;
	}
}

using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentNurgle", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentNurgle", order = 200)]
	public class DLC5_RogueLikeCardPersistentNurgle : RogueLikeCardPersistent
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x43BFB0", Offset = "0x43A9B0", VA = "0x18043BFB0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x43C270", Offset = "0x43AC70", VA = "0x18043C270", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x43BFE0", Offset = "0x43A9E0", VA = "0x18043BFE0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x43C1A0", Offset = "0x43ABA0", VA = "0x18043C1A0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentNurgle()
		{
		}

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x40")]
		public float decreaseOrderRate;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x44")]
		public float extraIngSoldNum;
	}
}

using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentTzeentch", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardTzeentch", order = 203)]
	public class DLC5_RogueLikeCardPersistentTzeentch : RogueLikeCardPersistent
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x43CEA0", Offset = "0x43B8A0", VA = "0x18043CEA0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x43D0F0", Offset = "0x43BAF0", VA = "0x18043D0F0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x43D1C0", Offset = "0x43BBC0", VA = "0x18043D1C0")]
		public DLC5_RogueLikeCardPersistentTzeentch()
		{
		}

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x40")]
		public float extraGuestSpawnRate;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x44")]
		public float patienceExtraDecreaseSpeed;
	}
}

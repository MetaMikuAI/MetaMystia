using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentRefreshFood", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentRefreshFood", order = 120)]
	public class DLC5_RogueLikeCardPersistentRefreshFood : RogueLikeCardPersistent
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x43C320", Offset = "0x43AD20", VA = "0x18043C320", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x43C550", Offset = "0x43AF50", VA = "0x18043C550", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x43C490", Offset = "0x43AE90", VA = "0x18043C490", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentRefreshFood()
		{
		}

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x40")]
		public int num;
	}
}

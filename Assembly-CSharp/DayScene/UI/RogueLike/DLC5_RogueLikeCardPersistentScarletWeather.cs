using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentScarletWeather", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentScarletWeather", order = 2001)]
	public class DLC5_RogueLikeCardPersistentScarletWeather : RogueLikeCardPersistent
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x43C5C0", Offset = "0x43AFC0", VA = "0x18043C5C0", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x43CA60", Offset = "0x43B460", VA = "0x18043CA60", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x43CBB0", Offset = "0x43B5B0", VA = "0x18043CBB0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentScarletWeather()
		{
		}

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x40")]
		public int addCardNum;
	}
}

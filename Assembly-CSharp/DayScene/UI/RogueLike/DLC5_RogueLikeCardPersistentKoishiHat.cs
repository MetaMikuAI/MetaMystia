using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentKoishiHat", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentKoishiHat", order = 102)]
	public class DLC5_RogueLikeCardPersistentKoishiHat : RogueLikeCardPersistent
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x43B580", Offset = "0x439F80", VA = "0x18043B580", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x43B5C0", Offset = "0x439FC0", VA = "0x18043B5C0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentKoishiHat()
		{
		}

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x40")]
		public float multiplier;
	}
}

using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentSlaanesh", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardSlaanesh", order = 202)]
	public class DLC5_RogueLikeCardPersistentSlaanesh : RogueLikeCardPersistent
	{
		// Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x43CC20", Offset = "0x43B620", VA = "0x18043CC20", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentSlaanesh()
		{
		}
	}
}

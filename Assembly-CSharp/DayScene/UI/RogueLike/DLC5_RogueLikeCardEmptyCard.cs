using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardEmptyCard", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardEmptyCard", order = 6)]
	public class DLC5_RogueLikeCardEmptyCard : RogueLikeCard, IRogueLikeCardAssociatedRecord
	{
		// Token: 0x06001237 RID: 4663 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x93DD80", Offset = "0x93C780", VA = "0x18093DD80", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x93DDC0", Offset = "0x93C7C0", VA = "0x18093DDC0", Slot = "9")]
		public void ModifyAssociatedRogueLikeCardInstances(List<RogueLikeCardInstance> associatedRogueLikeCards, RogueLikeManager rogueLikeManager)
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardEmptyCard()
		{
		}
	}
}

using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardKoishiHat", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardKoishiHat", order = 8)]
	public class DLC5_RogueLikeCardKoishiHat : RogueLikeCard
	{
		// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x940310", Offset = "0x93ED10", VA = "0x180940310", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x940240", Offset = "0x93EC40", VA = "0x180940240", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x940280", Offset = "0x93EC80", VA = "0x180940280", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardKoishiHat()
		{
		}

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x38")]
		public float multiplier;
	}
}

using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardSunWukongSoftHair", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardSunWukongSoftHair", order = 11)]
	public class DLC5_RogueLikeCardSunWukongSoftHair : RogueLikeCard
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x941390", Offset = "0x93FD90", VA = "0x180941390", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x941480", Offset = "0x93FE80", VA = "0x180941480", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x941410", Offset = "0x93FE10", VA = "0x180941410", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardSunWukongSoftHair()
		{
		}

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x38")]
		public int num;
	}
}

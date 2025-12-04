using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardJunko", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardJunko", order = 1002)]
	public class DLC5_RogueLikeCardJunko : RogueLikeCard
	{
		// Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x93FA40", Offset = "0x93E440", VA = "0x18093FA40", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x93F900", Offset = "0x93E300", VA = "0x18093F900", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x93F980", Offset = "0x93E380", VA = "0x18093F980", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardJunko()
		{
		}

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x38")]
		public float multiplier;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x3C")]
		public int costCombo;
	}
}

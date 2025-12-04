using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200033A RID: 826
	[Token(Token = "0x200033A")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardKaguyaTreasure", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardKaguyaTreasure", order = 10)]
	public class DLC5_RogueLikeCardKaguyaTreasure : RogueLikeCard
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x93FF90", Offset = "0x93E990", VA = "0x18093FF90", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x93FCD0", Offset = "0x93E6D0", VA = "0x18093FCD0", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x93FEF0", Offset = "0x93E8F0", VA = "0x18093FEF0", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardKaguyaTreasure()
		{
		}

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;
	}
}

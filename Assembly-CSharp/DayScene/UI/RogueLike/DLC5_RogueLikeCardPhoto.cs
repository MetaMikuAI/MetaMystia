using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPhoto", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardPhoto", order = 17)]
	public class DLC5_RogueLikeCardPhoto : RogueLikeCard
	{
		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x941080", Offset = "0x93FA80", VA = "0x180941080", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x940F80", Offset = "0x93F980", VA = "0x180940F80", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x940FB0", Offset = "0x93F9B0", VA = "0x180940FB0", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPhoto()
		{
		}

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x40")]
		public DLC5_RogueLikeCardPhoto.IngredientMapping[] mappingDatas;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		private const int PHOTOGENIC_ID = 20;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		private const int GINKGO_ID = 22;

		// Token: 0x0200034C RID: 844
		[Token(Token = "0x200034C")]
		[Serializable]
		public struct IngredientMapping
		{
			// Token: 0x0400116B RID: 4459
			[Token(Token = "0x400116B")]
			[FieldOffset(Offset = "0x0")]
			public string[] map;

			// Token: 0x0400116C RID: 4460
			[Token(Token = "0x400116C")]
			[FieldOffset(Offset = "0x8")]
			public int id;
		}
	}
}

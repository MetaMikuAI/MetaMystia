using System;
using System.Collections;
using DayScene.UI.RogueLike;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.BossBattle.DLC5_RogueLikeCard
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardCheapBev", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardCheapBev", order = 25)]
	public class DLC5_RogueLikeCardCheapBev : RogueLikeCard
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x827660", Offset = "0x826060", VA = "0x180827660", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x827470", Offset = "0x825E70", VA = "0x180827470", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x827590", Offset = "0x825F90", VA = "0x180827590", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardCheapBev()
		{
		}

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x38")]
		public DLC5_RogueLikeCardCheapBev.BevPropertySet[] BevPropertySets;

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		[Serializable]
		public class BevPropertySet : RarityDataMapping
		{
			// Token: 0x0600081A RID: 2074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
			public BevPropertySet()
			{
			}

			// Token: 0x04000769 RID: 1897
			[Token(Token = "0x4000769")]
			[FieldOffset(Offset = "0x18")]
			public int PriceLine;

			// Token: 0x0400076A RID: 1898
			[Token(Token = "0x400076A")]
			[FieldOffset(Offset = "0x1C")]
			public int Num;
		}
	}
}

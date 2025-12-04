using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	public abstract class DLC5_RogueLikeCardGiveItem : RogueLikeCard
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x93EE60", Offset = "0x93D860", VA = "0x18093EE60")]
		protected DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x93EEB0", Offset = "0x93D8B0", VA = "0x18093EEB0")]
		protected void GetSelectedItem(RogueLikeRunTimeData runTimeData, bool isIngredient, RogueLikeCardBase.Rarity rarity)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		protected DLC5_RogueLikeCardGiveItem()
		{
		}

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x38")]
		public DLC5_RogueLikeCardGiveItem.RarityDataMappingForGiveItem[] datas;

		// Token: 0x02000329 RID: 809
		[Token(Token = "0x2000329")]
		[Serializable]
		public class RarityDataMappingForGiveItem : RarityDataMapping
		{
			// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
			public RarityDataMappingForGiveItem()
			{
			}

			// Token: 0x04001106 RID: 4358
			[Token(Token = "0x4001106")]
			[FieldOffset(Offset = "0x18")]
			public Vector2Int TypeNum;

			// Token: 0x04001107 RID: 4359
			[Token(Token = "0x4001107")]
			[FieldOffset(Offset = "0x20")]
			public Vector2Int GiveNum;
		}
	}
}

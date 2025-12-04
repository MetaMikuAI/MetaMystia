using System;
using System.Collections.Generic;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	public abstract class DLC5_RogueLikeCardGiveItemAfterSettle : RogueLikeCard
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060012CF RID: 4815
		[Token(Token = "0x170001EA")]
		protected abstract int TypeIndex
		{
			[Token(Token = "0x60012CF")]
			get;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x93EC70", Offset = "0x93D670", VA = "0x18093EC70", Slot = "6")]
		public override void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager, out List<Product> products)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x93E8F0", Offset = "0x93D2F0", VA = "0x18093E8F0")]
		protected void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, out List<Product> products)
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x93ECC0", Offset = "0x93D6C0", VA = "0x18093ECC0", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		protected DLC5_RogueLikeCardGiveItemAfterSettle()
		{
		}

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;
	}
}

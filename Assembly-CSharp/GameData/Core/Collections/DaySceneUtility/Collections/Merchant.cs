using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	[Serializable]
	public struct Merchant
	{
		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string key;

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public DialogPackage[] welcomeDialogPackage;

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public DialogPackage[] nullDialogPackage;

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Vector2 priceMultiplierRange;

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Merchant.Merchandise[] merchandiseCollection;

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int leastSellNum;

		// Token: 0x02000AFA RID: 2810
		[Token(Token = "0x2000AFA")]
		[Serializable]
		public struct Merchandise
		{
			// Token: 0x060043DB RID: 17371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043DB")]
			[Address(RVA = "0x71DB40", Offset = "0x71C540", VA = "0x18071DB40")]
			public Merchandise(Product item, float sellProbability, Vector2Int itemAmountRange)
			{
			}

			// Token: 0x04003BE4 RID: 15332
			[Token(Token = "0x4003BE4")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Product item;

			// Token: 0x04003BE5 RID: 15333
			[Token(Token = "0x4003BE5")]
			[FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[SerializeField]
			public float sellProbability;

			// Token: 0x04003BE6 RID: 15334
			[Token(Token = "0x4003BE6")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public Vector2Int itemAmountRange;
		}
	}
}

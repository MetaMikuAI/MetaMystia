using System;
using System.Collections.Generic;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	[Serializable]
	public struct Product
	{
		// Token: 0x060043E8 RID: 17384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E8")]
		[Address(RVA = "0x71F2C0", Offset = "0x71DCC0", VA = "0x18071F2C0")]
		public Product(Product.ProductType productType, int productId, int productAmount, string productLabel)
		{
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E9")]
		[Address(RVA = "0x403870", Offset = "0x402270", VA = "0x180403870")]
		public void SetProductAmount(int amount)
		{
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x71F280", Offset = "0x71DC80", VA = "0x18071F280")]
		public IEnumerable<int> UnfoldProductIds()
		{
			return null;
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x71E8E0", Offset = "0x71D2E0", VA = "0x18071E8E0")]
		public ObjectLanguageBase GetText()
		{
			return null;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00018A08 File Offset: 0x00016C08
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x71E700", Offset = "0x71D100", VA = "0x18071E700")]
		public static bool Equals(Product left, Product right)
		{
			return default(bool);
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00018A20 File Offset: 0x00016C20
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x71E780", Offset = "0x71D180", VA = "0x18071E780")]
		public int GetPerPrice()
		{
			return 0;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00018A38 File Offset: 0x00016C38
		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x71E820", Offset = "0x71D220", VA = "0x18071E820")]
		public int GetPrice()
		{
			return 0;
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00018A50 File Offset: 0x00016C50
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x71F2E0", Offset = "0x71DCE0", VA = "0x18071F2E0")]
		public static bool operator ==(Product left, Product right)
		{
			return default(bool);
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00018A68 File Offset: 0x00016C68
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x71F350", Offset = "0x71DD50", VA = "0x18071F350")]
		public static bool operator !=(Product left, Product right)
		{
			return default(bool);
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00018A80 File Offset: 0x00016C80
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x71E690", Offset = "0x71D090", VA = "0x18071E690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00018A98 File Offset: 0x00016C98
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0x71E720", Offset = "0x71D120", VA = "0x18071E720", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F3")]
		[Address(RVA = "0x71F220", Offset = "0x71DC20", VA = "0x18071F220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F4")]
		[Address(RVA = "0x71ED00", Offset = "0x71D700", VA = "0x18071ED00")]
		public static List<Product> MergeAndDistinctEqualedProduct(IEnumerable<Product> products, bool needOrderByType)
		{
			return null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F5")]
		[Address(RVA = "0x71EB20", Offset = "0x71D520", VA = "0x18071EB20")]
		public static void InsertEqualedProduct(List<Product> productList, Product element)
		{
		}

		// Token: 0x04003BF2 RID: 15346
		[Token(Token = "0x4003BF2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public Product.ProductType productType;

		// Token: 0x04003BF3 RID: 15347
		[Token(Token = "0x4003BF3")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public int productId;

		// Token: 0x04003BF4 RID: 15348
		[Token(Token = "0x4003BF4")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string productLabel;

		// Token: 0x04003BF5 RID: 15349
		[Token(Token = "0x4003BF5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int productAmount;

		// Token: 0x02000AFE RID: 2814
		[Token(Token = "0x2000AFE")]
		public enum ProductType
		{
			// Token: 0x04003BF7 RID: 15351
			[Token(Token = "0x4003BF7")]
			Food,
			// Token: 0x04003BF8 RID: 15352
			[Token(Token = "0x4003BF8")]
			Ingredient,
			// Token: 0x04003BF9 RID: 15353
			[Token(Token = "0x4003BF9")]
			Beverage,
			// Token: 0x04003BFA RID: 15354
			[Token(Token = "0x4003BFA")]
			Money,
			// Token: 0x04003BFB RID: 15355
			[Token(Token = "0x4003BFB")]
			Mission,
			// Token: 0x04003BFC RID: 15356
			[Token(Token = "0x4003BFC")]
			Item,
			// Token: 0x04003BFD RID: 15357
			[Token(Token = "0x4003BFD")]
			Recipe,
			// Token: 0x04003BFE RID: 15358
			[Token(Token = "0x4003BFE")]
			Izakaya,
			// Token: 0x04003BFF RID: 15359
			[Token(Token = "0x4003BFF")]
			Cooker,
			// Token: 0x04003C00 RID: 15360
			[Token(Token = "0x4003C00")]
			Partner,
			// Token: 0x04003C01 RID: 15361
			[Token(Token = "0x4003C01")]
			Badge,
			// Token: 0x04003C02 RID: 15362
			[Token(Token = "0x4003C02")]
			Trophy
		}

		// Token: 0x02000AFF RID: 2815
		[Token(Token = "0x2000AFF")]
		public struct ProductKey
		{
			// Token: 0x060043F6 RID: 17398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043F6")]
			[Address(RVA = "0x41AF60", Offset = "0x419960", VA = "0x18041AF60")]
			public ProductKey(Product.ProductType productType, int id)
			{
			}

			// Token: 0x04003C03 RID: 15363
			[Token(Token = "0x4003C03")]
			[FieldOffset(Offset = "0x0")]
			public Product.ProductType ProductType;

			// Token: 0x04003C04 RID: 15364
			[Token(Token = "0x4003C04")]
			[FieldOffset(Offset = "0x4")]
			public int Id;
		}

		// Token: 0x02000B00 RID: 2816
		[Token(Token = "0x2000B00")]
		public class ProductKeyEqualityComparer : IEqualityComparer<Product.ProductKey>
		{
			// Token: 0x060043F7 RID: 17399 RVA: 0x00018AB0 File Offset: 0x00016CB0
			[Token(Token = "0x60043F7")]
			[Address(RVA = "0x71E660", Offset = "0x71D060", VA = "0x18071E660", Slot = "4")]
			public bool Equals(Product.ProductKey x, Product.ProductKey y)
			{
				return default(bool);
			}

			// Token: 0x060043F8 RID: 17400 RVA: 0x00018AC8 File Offset: 0x00016CC8
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x71E680", Offset = "0x71D080", VA = "0x18071E680", Slot = "5")]
			public int GetHashCode(Product.ProductKey obj)
			{
				return 0;
			}

			// Token: 0x060043F9 RID: 17401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public ProductKeyEqualityComparer()
			{
			}
		}
	}
}

using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2000BA1")]
	[CreateAssetMenu(fileName = "KourindoStaticMerchandiseProfile", menuName = "GameData Profile/KourindoStaticMerchandiseProfile", order = 3)]
	public class KourindoStaticMerchandiseProfile : ScriptableObject
	{
		// Token: 0x0600468A RID: 18058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public KourindoStaticMerchandiseProfile()
		{
		}

		// Token: 0x04003F04 RID: 16132
		[Token(Token = "0x4003F04")]
		[FieldOffset(Offset = "0x18")]
		public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise[] merchandiseCollection;

		// Token: 0x02000BA2 RID: 2978
		[Token(Token = "0x2000BA2")]
		[Serializable]
		public struct KourindoStaticMerchandise
		{
			// Token: 0x0600468B RID: 18059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600468B")]
			[Address(RVA = "0x73F1C0", Offset = "0x73DBC0", VA = "0x18073F1C0")]
			public KourindoStaticMerchandise(string label, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency[] currencies, bool onlyAddOnce, Product product)
			{
			}

			// Token: 0x0600468C RID: 18060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x73F1A0", Offset = "0x73DBA0", VA = "0x18073F1A0")]
			public void SetNewProduct(Product newProduct)
			{
			}

			// Token: 0x04003F05 RID: 16133
			[Token(Token = "0x4003F05")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string label;

			// Token: 0x04003F06 RID: 16134
			[Token(Token = "0x4003F06")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency[] currencies;

			// Token: 0x04003F07 RID: 16135
			[Token(Token = "0x4003F07")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public bool onlyAddOnce;

			// Token: 0x04003F08 RID: 16136
			[Token(Token = "0x4003F08")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Product product;

			// Token: 0x02000BA3 RID: 2979
			[Token(Token = "0x2000BA3")]
			[Serializable]
			public struct Currency
			{
				// Token: 0x0600468D RID: 18061 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600468D")]
				[Address(RVA = "0x735210", Offset = "0x733C10", VA = "0x180735210")]
				public Currency(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType currencyType, int price, int id)
				{
				}

				// Token: 0x04003F09 RID: 16137
				[Token(Token = "0x4003F09")]
				[FieldOffset(Offset = "0x0")]
				[SerializeField]
				public int price;

				// Token: 0x04003F0A RID: 16138
				[Token(Token = "0x4003F0A")]
				[FieldOffset(Offset = "0x4")]
				[SerializeField]
				public int Id;

				// Token: 0x04003F0B RID: 16139
				[Token(Token = "0x4003F0B")]
				[FieldOffset(Offset = "0x8")]
				[SerializeField]
				public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType currencyType;

				// Token: 0x02000BA4 RID: 2980
				[Token(Token = "0x2000BA4")]
				public enum CurrencyType
				{
					// Token: 0x04003F0D RID: 16141
					[Token(Token = "0x4003F0D")]
					Fund,
					// Token: 0x04003F0E RID: 16142
					[Token(Token = "0x4003F0E")]
					Item,
					// Token: 0x04003F0F RID: 16143
					[Token(Token = "0x4003F0F")]
					Cooker
				}
			}
		}
	}
}

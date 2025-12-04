using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	[Serializable]
	public struct Collectable
	{
		// Token: 0x060043D7 RID: 17367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x714D90", Offset = "0x713790", VA = "0x180714D90")]
		public Collectable(string key, bool offByDefault, Vector2Int showTime, int regenerateHours, Product[] primaryProduct, Collectable.ProbabilityDrivenProduct[] secondaryProduct)
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00018930 File Offset: 0x00016B30
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x714D60", Offset = "0x713760", VA = "0x180714D60")]
		public Vector2Int GetTrueShowAction()
		{
			return default(Vector2Int);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00018948 File Offset: 0x00016B48
		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x714D50", Offset = "0x713750", VA = "0x180714D50")]
		public int GetRegenerateActions()
		{
			return 0;
		}

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string key;

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public bool offByDefault;

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Vector2Int showTime;

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Product[] primaryProduct;

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Collectable.ProbabilityDrivenProduct[] secondaryProduct;

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int regenerateHours;

		// Token: 0x02000AF8 RID: 2808
		[Token(Token = "0x2000AF8")]
		[Serializable]
		public struct ProbabilityDrivenProduct
		{
			// Token: 0x060043DA RID: 17370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x71E620", Offset = "0x71D020", VA = "0x18071E620")]
			public ProbabilityDrivenProduct(Product product, int probability)
			{
			}

			// Token: 0x04003BDC RID: 15324
			[Token(Token = "0x4003BDC")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Product product;

			// Token: 0x04003BDD RID: 15325
			[Token(Token = "0x4003BDD")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public int probability;
		}
	}
}

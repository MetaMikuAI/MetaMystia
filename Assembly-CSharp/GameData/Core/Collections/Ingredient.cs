using System;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008CF RID: 2255
	[Token(Token = "0x20008CF")]
	[Serializable]
	public class Ingredient : TradableObjectBase
	{
		// Token: 0x06003819 RID: 14361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x684CE0", Offset = "0x6836E0", VA = "0x180684CE0")]
		public Ingredient(int id, int baseValue, int level, int prefix, int[] tags)
		{
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x17000781")]
		public bool IsFish
		{
			[Token(Token = "0x600381A")]
			[Address(RVA = "0x684D20", Offset = "0x683720", VA = "0x180684D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x17000782")]
		public bool IsMeat
		{
			[Token(Token = "0x600381B")]
			[Address(RVA = "0x684D80", Offset = "0x683780", VA = "0x180684D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x17000783")]
		public bool IsVeg
		{
			[Token(Token = "0x600381C")]
			[Address(RVA = "0x684DE0", Offset = "0x6837E0", VA = "0x180684DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x000152B8 File Offset: 0x000134B8
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000784")]
		public int Prefix
		{
			[Token(Token = "0x600381D")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600381E")]
			[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
			set
			{
			}
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x684790", Offset = "0x683190", VA = "0x180684790", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x684790", Offset = "0x683190", VA = "0x180684790")]
		public Ingredient Duplicate()
		{
			return null;
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x684850", Offset = "0x683250", VA = "0x180684850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x5272A0", Offset = "0x525CA0", VA = "0x1805272A0", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "10")]
		protected override SchedulerNode.Reward.ObjectType OnGetObjectType()
		{
			return SchedulerNode.Reward.ObjectType.Food;
		}

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		private const int MEAT_TAG_ID = 0;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		private const int SEAFOOD_TAG_ID = 1;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		private const int VEGETABLE_TAG_ID = 2;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int prefix;

		// Token: 0x020008D0 RID: 2256
		[Token(Token = "0x20008D0")]
		public new enum SortType
		{
			// Token: 0x04003003 RID: 12291
			[Token(Token = "0x4003003")]
			ID,
			// Token: 0x04003004 RID: 12292
			[Token(Token = "0x4003004")]
			Level,
			// Token: 0x04003005 RID: 12293
			[Token(Token = "0x4003005")]
			Value,
			// Token: 0x04003006 RID: 12294
			[Token(Token = "0x4003006")]
			Stack,
			// Token: 0x04003007 RID: 12295
			[Token(Token = "0x4003007")]
			Tag
		}
	}
}

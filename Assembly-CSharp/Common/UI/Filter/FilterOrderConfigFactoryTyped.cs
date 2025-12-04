using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF5 RID: 3829
	[Token(Token = "0x2000EF5")]
	public abstract class FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType> : FilterConfigFactoryTypedBase<TOrderingType, Order>
	{
		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Token(Token = "0x17000C85")]
		protected virtual bool InvertSelection
		{
			[Token(Token = "0x6005A49")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x0001FB00 File Offset: 0x0001DD00
		[Token(Token = "0x17000C86")]
		public sealed override FilterType FilterType
		{
			[Token(Token = "0x6005A4A")]
			get
			{
				return FilterType.SingleChoice;
			}
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4B")]
		protected sealed override IEnumerable<Order> GetSelectionsTyped()
		{
			return null;
		}

		// Token: 0x06005A4C RID: 23116
		[Token(Token = "0x6005A4C")]
		protected abstract OrderFilterConfig<TOrderingType, TFocusingType> CreateFilterConfig(Order value);

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4D")]
		protected sealed override BaseFilterConfig CreateFilterConfig(IReadOnlyList<object> value)
		{
			return null;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4E")]
		protected FilterOrderConfigFactoryTyped(uint selectionPriorityWeight)
		{
		}
	}
}

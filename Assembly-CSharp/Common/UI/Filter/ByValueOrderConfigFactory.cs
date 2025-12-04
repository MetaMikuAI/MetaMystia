using System;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EE9 RID: 3817
	[Token(Token = "0x2000EE9")]
	public abstract class ByValueOrderConfigFactory<TFocusing, TOrdering> : FilterOrderConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x06005A17 RID: 23063
		[Token(Token = "0x6005A17")]
		protected abstract TFocusing GetFocusing(TOrdering ordering);

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A18")]
		protected override OrderFilterConfig<TOrdering, TFocusing> CreateFilterConfig(Order value)
		{
			return null;
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A19")]
		protected ByValueOrderConfigFactory(uint selectionPriorityWeight)
		{
		}

		// Token: 0x02000EEA RID: 3818
		[Token(Token = "0x2000EEA")]
		private class ByValueOrderConfig : OrderFilterConfig<TOrdering, TFocusing>
		{
			// Token: 0x06005A1A RID: 23066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A1A")]
			public ByValueOrderConfig(IFilterConfigFactory factory, Order order)
			{
			}

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x06005A1B RID: 23067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C77")]
			private ByValueOrderConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[Token(Token = "0x6005A1B")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A1C RID: 23068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A1C")]
			protected override TFocusing GetFocusingElement(TOrdering src)
			{
				return null;
			}
		}
	}
}

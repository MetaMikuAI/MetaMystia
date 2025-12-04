using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF6 RID: 3830
	[Token(Token = "0x2000EF6")]
	public abstract class FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType> : FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>
	{
		// Token: 0x06005A4F RID: 23119
		[Token(Token = "0x6005A4F")]
		protected abstract WhereFilterConfig<TOrderingType> CreateFilterConfig(IEnumerable<TSelectionType> value);

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A50")]
		protected sealed override BaseFilterConfig CreateFilterConfig(IReadOnlyList<object> value)
		{
			return null;
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A51")]
		protected FilterContainsConfigFactoryTyped(uint selectionPriorityWeight)
		{
		}
	}
}

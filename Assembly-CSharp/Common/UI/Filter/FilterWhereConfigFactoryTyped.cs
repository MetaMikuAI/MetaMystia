using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF3 RID: 3827
	[Token(Token = "0x2000EF3")]
	public abstract class FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType> : FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>
	{
		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06005A43 RID: 23107 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[Token(Token = "0x17000C83")]
		public sealed override FilterType FilterType
		{
			[Token(Token = "0x6005A43")]
			get
			{
				return FilterType.SingleChoice;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[Token(Token = "0x17000C84")]
		public sealed override uint ColumnCount
		{
			[Token(Token = "0x6005A44")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06005A45 RID: 23109
		[Token(Token = "0x6005A45")]
		protected abstract WhereFilterConfig<TOrderingType> CreateFilterConfig(TSelectionType value);

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A46")]
		protected sealed override BaseFilterConfig CreateFilterConfig(IReadOnlyList<object> value)
		{
			return null;
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A47")]
		protected FilterWhereConfigFactoryTyped(uint selectionPriorityWeight)
		{
		}
	}
}

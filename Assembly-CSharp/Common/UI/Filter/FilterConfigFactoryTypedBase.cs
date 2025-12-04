using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF2 RID: 3826
	[Token(Token = "0x2000EF2")]
	public abstract class FilterConfigFactoryTypedBase<TOrderingType, TSelectionType> : FilterConfigFactory<TOrderingType>
	{
		// Token: 0x06005A3E RID: 23102
		[Token(Token = "0x6005A3E")]
		protected abstract IEnumerable<TSelectionType> GetSelectionsTyped();

		// Token: 0x06005A3F RID: 23103
		[Token(Token = "0x6005A3F")]
		protected abstract string GetSelectionTextTyped(TSelectionType value);

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A40")]
		protected sealed override IEnumerable<object> GetSelections()
		{
			return null;
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A41")]
		protected sealed override string GetSelectionText(object value)
		{
			return null;
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A42")]
		protected FilterConfigFactoryTypedBase(uint selectionPriorityWeight)
		{
		}
	}
}

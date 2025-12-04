using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EEB RID: 3819
	[Token(Token = "0x2000EEB")]
	public interface IFilterConfig
	{
		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06005A1D RID: 23069
		[Token(Token = "0x17000C78")]
		IEnumerable<object> SelectedElements
		{
			[Token(Token = "0x6005A1D")]
			get;
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06005A1E RID: 23070
		[Token(Token = "0x17000C79")]
		IFilterConfig.Type FilterType
		{
			[Token(Token = "0x6005A1E")]
			get;
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06005A1F RID: 23071
		[Token(Token = "0x17000C7A")]
		IFilterConfigFactory Factory
		{
			[Token(Token = "0x6005A1F")]
			get;
		}

		// Token: 0x06005A20 RID: 23072
		[Token(Token = "0x6005A20")]
		IOrderedEnumerable<object> DoFilter(IEnumerable<object> objectsToFilter);

		// Token: 0x06005A21 RID: 23073
		[Token(Token = "0x6005A21")]
		IOrderedEnumerable<object> DoFilter(IOrderedEnumerable<object> objectsToFilter);

		// Token: 0x06005A22 RID: 23074
		[Token(Token = "0x6005A22")]
		IEnumerable<object> DoWhere(IEnumerable<object> objectsToFilter);

		// Token: 0x02000EEC RID: 3820
		[Token(Token = "0x2000EEC")]
		public enum Type
		{
			// Token: 0x04005478 RID: 21624
			[Token(Token = "0x4005478")]
			Where,
			// Token: 0x04005479 RID: 21625
			[Token(Token = "0x4005479")]
			Order
		}
	}
}

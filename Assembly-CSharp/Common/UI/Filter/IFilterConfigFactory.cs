using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF9 RID: 3833
	[Token(Token = "0x2000EF9")]
	public interface IFilterConfigFactory
	{
		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06005A5F RID: 23135
		[Token(Token = "0x17000C8B")]
		FilterType FilterType
		{
			[Token(Token = "0x6005A5F")]
			get;
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06005A60 RID: 23136
		[Token(Token = "0x17000C8C")]
		string FactoryName
		{
			[Token(Token = "0x6005A60")]
			get;
		}

		// Token: 0x06005A61 RID: 23137
		[Token(Token = "0x6005A61")]
		bool ShouldEnable();

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06005A62 RID: 23138
		[Token(Token = "0x17000C8D")]
		uint ColumnCount
		{
			[Token(Token = "0x6005A62")]
			get;
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06005A63 RID: 23139
		[Token(Token = "0x17000C8E")]
		uint SelectionPriorityWeight
		{
			[Token(Token = "0x6005A63")]
			get;
		}

		// Token: 0x06005A64 RID: 23140
		[Token(Token = "0x6005A64")]
		IEnumerable<object> GetSelections();

		// Token: 0x06005A65 RID: 23141
		[Token(Token = "0x6005A65")]
		IFilterConfig CreateFilterConfig(IReadOnlyList<object> value);

		// Token: 0x06005A66 RID: 23142
		[Token(Token = "0x6005A66")]
		string GetSelectionText(object value);

		// Token: 0x06005A67 RID: 23143
		[Token(Token = "0x6005A67")]
		void OnWillFilter();
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EFA RID: 3834
	[Token(Token = "0x2000EFA")]
	public readonly struct FilterParam
	{
		// Token: 0x06005A68 RID: 23144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
		public FilterParam(IReadOnlyList<IFilterConfigFactory> filterConfigFactories, List<IFilterConfig> currentFilterConfig)
		{
		}

		// Token: 0x04005489 RID: 21641
		[Token(Token = "0x4005489")]
		[FieldOffset(Offset = "0x0")]
		public readonly IReadOnlyList<IFilterConfigFactory> FilterConfigFactories;

		// Token: 0x0400548A RID: 21642
		[Token(Token = "0x400548A")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<IFilterConfig> CurrentFilterConfig;
	}
}

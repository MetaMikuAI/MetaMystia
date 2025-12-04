using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EFB RID: 3835
	[Token(Token = "0x2000EFB")]
	public static class FilterHelper
	{
		// Token: 0x06005A69 RID: 23145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A69")]
		public static IEnumerable<TSrcObject> ExecuteFilterWithDelegation<TSrcObject, TOrderingObject>(this IReadOnlyList<IFilterConfig> configs, IEnumerable<TSrcObject> objects, Func<TSrcObject, TOrderingObject> conversionHandler)
		{
			return null;
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A6A")]
		public static IEnumerable<T> ExecuteFilter<T>(this IReadOnlyList<IFilterConfig> configs, IEnumerable<T> objects)
		{
			return null;
		}

		// Token: 0x0400548B RID: 21643
		[Token(Token = "0x400548B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Queue<IFilterConfig> s_OrderQueue;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF4 RID: 3828
	[Token(Token = "0x2000EF4")]
	public static class OrderingArray
	{
		// Token: 0x04005483 RID: 21635
		[Token(Token = "0x4005483")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IReadOnlyList<Order> Orders;

		// Token: 0x04005484 RID: 21636
		[Token(Token = "0x4005484")]
		[FieldOffset(Offset = "0x8")]
		public static readonly IReadOnlyList<Order> InvertedOrders;
	}
}

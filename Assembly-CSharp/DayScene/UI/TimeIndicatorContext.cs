using System;
using Il2CppDummyDll;

namespace DayScene.UI
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public readonly struct TimeIndicatorContext
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x9439E0", Offset = "0x9423E0", VA = "0x1809439E0")]
		public TimeIndicatorContext(TimeSpan currentTime, TimeSpan targetTime, TimeSpan costTime, int? costMoney)
		{
		}

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x0")]
		public readonly TimeSpan CurrentTime;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x8")]
		public readonly TimeSpan TargetTime;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x10")]
		public readonly TimeSpan CostTime;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x18")]
		public readonly int? CostMoney;
	}
}

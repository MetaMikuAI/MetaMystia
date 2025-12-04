using System;
using Il2CppDummyDll;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public readonly struct RechargeInfo
	{
		// Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x4B9C80", Offset = "0x4B8680", VA = "0x1804B9C80")]
		public RechargeInfo(int letterId, float progress)
		{
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x54D6D0", Offset = "0x54C0D0", VA = "0x18054D6D0")]
		public void Deconstruct(out int letterId, out float progress)
		{
		}

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x0")]
		public readonly int LetterId;

		// Token: 0x0400260A RID: 9738
		[Token(Token = "0x400260A")]
		[FieldOffset(Offset = "0x4")]
		public readonly float Progress;
	}
}

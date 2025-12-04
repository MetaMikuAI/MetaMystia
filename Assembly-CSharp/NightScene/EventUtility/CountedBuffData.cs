using System;
using Il2CppDummyDll;

namespace NightScene.EventUtility
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public struct CountedBuffData
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x531460", Offset = "0x52FE60", VA = "0x180531460")]
		public CountedBuffData(int count, Action<int> onBuffCountUpdateCallback, Action onBuffDeductCallBack, Action onBuffEndCallBack, Guid guid, bool allowZero)
		{
		}

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x0")]
		public int count;

		// Token: 0x04002372 RID: 9074
		[Token(Token = "0x4002372")]
		[FieldOffset(Offset = "0x8")]
		public Action<int> onBuffCountUpdateCallback;

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x10")]
		public Action onBuffDeductCallBack;

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x18")]
		public Action onBuffEndCallBack;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x20")]
		public Guid guid;

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x30")]
		public bool allowZero;
	}
}

using System;
using Il2CppDummyDll;

namespace Common.DialogUtility.History
{
	// Token: 0x02000D9F RID: 3487
	[Token(Token = "0x2000D9F")]
	public readonly struct DialogHistory
	{
		// Token: 0x060051D2 RID: 20946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x7FC2B0", Offset = "0x7FACB0", VA = "0x1807FC2B0")]
		public DialogHistory(string speakerName, string speakContent, uint dialogPackageCount)
		{
		}

		// Token: 0x04004CED RID: 19693
		[Token(Token = "0x4004CED")]
		[FieldOffset(Offset = "0x0")]
		public readonly string SpeakerName;

		// Token: 0x04004CEE RID: 19694
		[Token(Token = "0x4004CEE")]
		[FieldOffset(Offset = "0x8")]
		public readonly string SpeakContent;

		// Token: 0x04004CEF RID: 19695
		[Token(Token = "0x4004CEF")]
		[FieldOffset(Offset = "0x10")]
		public readonly uint DialogPackageCount;
	}
}

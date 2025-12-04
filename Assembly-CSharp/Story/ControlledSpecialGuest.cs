using System;
using Il2CppDummyDll;

namespace Story
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public struct ControlledSpecialGuest
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x421E30", Offset = "0x420830", VA = "0x180421E30")]
		public ControlledSpecialGuest(int id, ControlStatus status)
		{
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x0")]
		public int Id;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x4")]
		public ControlStatus Status;
	}
}

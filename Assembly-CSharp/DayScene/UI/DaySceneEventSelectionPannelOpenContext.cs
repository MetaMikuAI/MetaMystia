using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DayScene.UI
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	public readonly struct DaySceneEventSelectionPannelOpenContext
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x479230", Offset = "0x477C30", VA = "0x180479230")]
		public DaySceneEventSelectionPannelOpenContext(Dictionary<string, Action> options, bool useCustomTitle)
		{
		}

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x0")]
		public readonly Dictionary<string, Action> Options;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool UseCustomTitle;
	}
}

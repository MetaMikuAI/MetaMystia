using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameData.RunTime.Common.AchievementSystem
{
	// Token: 0x020008A2 RID: 2210
	[Token(Token = "0x20008A2")]
	public class AchievementNotifyResult
	{
		// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public AchievementNotifyResult()
		{
		}

		// Token: 0x04002EF7 RID: 12023
		[Token(Token = "0x4002EF7")]
		[FieldOffset(Offset = "0x10")]
		public KeyValuePair<int, int> IntKeyValuePair;

		// Token: 0x04002EF8 RID: 12024
		[Token(Token = "0x4002EF8")]
		[FieldOffset(Offset = "0x18")]
		public int IntValue;
	}
}

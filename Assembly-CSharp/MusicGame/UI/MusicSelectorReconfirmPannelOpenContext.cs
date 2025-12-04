using System;
using Il2CppDummyDll;

namespace MusicGame.UI
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public readonly struct MusicSelectorReconfirmPannelOpenContext
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x428D70", Offset = "0x427770", VA = "0x180428D70")]
		public MusicSelectorReconfirmPannelOpenContext(string musicID, bool isBossMode, DifficultyMode difficulty)
		{
		}

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x0")]
		public readonly string MusicID;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool IsBossMode;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x9")]
		public readonly DifficultyMode Difficulty;
	}
}

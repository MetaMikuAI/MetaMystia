using System;
using Il2CppDummyDll;

namespace MusicGame.UI
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public readonly struct MusicGameMainPannelOpenContext
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4124E0", Offset = "0x410EE0", VA = "0x1804124E0")]
		public MusicGameMainPannelOpenContext(string musicID, bool isEasyMode, float musicalNoteSpeed, bool isAutoPlay, bool skipMode)
		{
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x0")]
		public readonly string MusicID;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool isEasyMode;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xC")]
		public readonly float MusicalNoteSpeed;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool isAutoPlay;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x11")]
		public readonly bool skipMode;
	}
}

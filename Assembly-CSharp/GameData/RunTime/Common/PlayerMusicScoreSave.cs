using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GameData.RunTime.Common
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	[Serializable]
	public struct PlayerMusicScoreSave : IDeepClonable<PlayerMusicScoreSave>
	{
		// Token: 0x060030B9 RID: 12473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x60A750", Offset = "0x609150", VA = "0x18060A750")]
		public PlayerMusicScoreSave(DateTime realSaveTimeCode, [TupleElementNames(new string[] { "EasyHighScore", "HardHighScore" })] Dictionary<string, ValueTuple<int, int>> scoreData)
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x60A6C0", Offset = "0x6090C0", VA = "0x18060A6C0", Slot = "4")]
		public PlayerMusicScoreSave Clone()
		{
			return default(PlayerMusicScoreSave);
		}

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime realSaveTimeCode;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x8")]
		[TupleElementNames(new string[] { "EasyHighScore", "HardHighScore" })]
		public Dictionary<string, ValueTuple<int, int>> scoreData;
	}
}

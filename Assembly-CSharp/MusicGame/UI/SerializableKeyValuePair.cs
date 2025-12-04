using System;
using Il2CppDummyDll;

namespace MusicGame.UI
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public struct SerializableKeyValuePair<TKey, TValue>
	{
		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		public TKey Key;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		public TValue Value;
	}
}

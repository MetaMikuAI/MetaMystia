using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DBA RID: 3514
	[Token(Token = "0x2000DBA")]
	[Serializable]
	public struct MultiLanguageSprite
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		public Sprite Current
		{
			[Token(Token = "0x600526F")]
			[Address(RVA = "0x7FFCE0", Offset = "0x7FE6E0", VA = "0x1807FFCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04004D42 RID: 19778
		[Token(Token = "0x4004D42")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Sprite m_Cn;

		// Token: 0x04004D43 RID: 19779
		[Token(Token = "0x4004D43")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Sprite m_En;

		// Token: 0x04004D44 RID: 19780
		[Token(Token = "0x4004D44")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sprite m_Jp;

		// Token: 0x04004D45 RID: 19781
		[Token(Token = "0x4004D45")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_Ko;

		// Token: 0x04004D46 RID: 19782
		[Token(Token = "0x4004D46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_Cnt;
	}
}

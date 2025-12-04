using System;
using GameData.CoreLanguage;
using Il2CppDummyDll;

namespace GameData.Core.Collections
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	[Serializable]
	public class Badge : NonTradableObjectBase
	{
		// Token: 0x0600380E RID: 14350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x67FAE0", Offset = "0x67E4E0", VA = "0x18067FAE0")]
		public Badge(int id)
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x67FA80", Offset = "0x67E480", VA = "0x18067FA80", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x67FAD0", Offset = "0x67E4D0", VA = "0x18067FAD0", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}
	}
}

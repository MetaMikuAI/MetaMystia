using System;
using GameData.CoreLanguage;
using Il2CppDummyDll;

namespace GameData.Core.Collections
{
	// Token: 0x020008D1 RID: 2257
	[Token(Token = "0x20008D1")]
	public class Item : NonTradableObjectBase
	{
		// Token: 0x06003824 RID: 14372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x67FAE0", Offset = "0x67E4E0", VA = "0x18067FAE0")]
		public Item(int id)
		{
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x17000785")]
		public bool IsClothes
		{
			[Token(Token = "0x6003825")]
			[Address(RVA = "0x684EA0", Offset = "0x6838A0", VA = "0x180684EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x17000786")]
		public bool IsDecoration
		{
			[Token(Token = "0x6003826")]
			[Address(RVA = "0x684EB0", Offset = "0x6838B0", VA = "0x180684EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x17000787")]
		public bool IsRecord
		{
			[Token(Token = "0x6003827")]
			[Address(RVA = "0x684EC0", Offset = "0x6838C0", VA = "0x180684EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x684E40", Offset = "0x683840", VA = "0x180684E40", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x684E90", Offset = "0x683890", VA = "0x180684E90", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}
	}
}

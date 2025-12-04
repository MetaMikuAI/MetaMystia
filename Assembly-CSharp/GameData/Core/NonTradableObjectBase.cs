using System;
using Common.UI;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	[Serializable]
	public abstract class NonTradableObjectBase : ICloneable, ITextProvider<ObjectLanguageBase>
	{
		// Token: 0x060036A4 RID: 13988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x3F94B0", Offset = "0x3F7EB0", VA = "0x1803F94B0")]
		public NonTradableObjectBase(int id)
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x1700071A")]
		public int Id
		{
			[Token(Token = "0x60036A5")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071B")]
		public ObjectLanguageBase Text
		{
			[Token(Token = "0x60036A6")]
			[Address(RVA = "0x665C80", Offset = "0x664680", VA = "0x180665C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071C")]
		public virtual Sprite BGSprite
		{
			[Token(Token = "0x60036A7")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036A8 RID: 13992
		[Token(Token = "0x60036A8")]
		public abstract object Clone();

		// Token: 0x060036A9 RID: 13993
		[Token(Token = "0x60036A9")]
		protected abstract ObjectLanguageBase GetText(int id);

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int id;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.GenericButtonSet
{
	// Token: 0x02000EDE RID: 3806
	[Token(Token = "0x2000EDE")]
	public readonly struct GenericButtonSetParam
	{
		// Token: 0x060059F2 RID: 23026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
		public GenericButtonSetParam(IEnumerable<string> buttonTexts, Action<int> onButtonSubmitHandler)
		{
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x88AF00", Offset = "0x889900", VA = "0x18088AF00")]
		public void Deconstruct(out IEnumerable<string> buttonTexts, out Action<int> onButtonSubmitHandler)
		{
		}

		// Token: 0x04005463 RID: 21603
		[Token(Token = "0x4005463")]
		[FieldOffset(Offset = "0x0")]
		public readonly IEnumerable<string> ButtonTexts;

		// Token: 0x04005464 RID: 21604
		[Token(Token = "0x4005464")]
		[FieldOffset(Offset = "0x8")]
		public readonly Action<int> OnButtonSubmitHandler;
	}
}

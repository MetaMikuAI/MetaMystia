using System;
using GameData.CoreLanguage;
using Il2CppDummyDll;

namespace Common.UI
{
	// Token: 0x02000DEF RID: 3567
	[Token(Token = "0x2000DEF")]
	public interface ITextProvider<out TLanguageBase> where TLanguageBase : LanguageBase
	{
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06005371 RID: 21361
		[Token(Token = "0x17000BE7")]
		TLanguageBase Text
		{
			[Token(Token = "0x6005371")]
			get;
		}
	}
}

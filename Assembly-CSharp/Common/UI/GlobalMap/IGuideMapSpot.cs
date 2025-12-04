using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.UI.GlobalMap
{
	// Token: 0x02000F98 RID: 3992
	[Token(Token = "0x2000F98")]
	public interface IGuideMapSpot
	{
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06005DCB RID: 24011
		[Token(Token = "0x17000D11")]
		string PrimaryName
		{
			[Token(Token = "0x6005DCB")]
			get;
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06005DCC RID: 24012
		[Token(Token = "0x17000D12")]
		UIButtonSimple UIButton
		{
			[Token(Token = "0x6005DCC")]
			get;
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06005DCD RID: 24013
		[Token(Token = "0x17000D13")]
		RectTransform RectTransform
		{
			[Token(Token = "0x6005DCD")]
			get;
		}

		// Token: 0x06005DCE RID: 24014
		[Token(Token = "0x6005DCE")]
		bool MatchesMapNameOrSubset(string mapName);

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06005DCF RID: 24015
		[Token(Token = "0x17000D14")]
		bool IsActivated
		{
			[Token(Token = "0x6005DCF")]
			get;
		}
	}
}

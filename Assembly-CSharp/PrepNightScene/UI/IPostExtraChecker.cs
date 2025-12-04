using System;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;

namespace PrepNightScene.UI
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public interface IPostExtraChecker
	{
		// Token: 0x060003CD RID: 973
		[Token(Token = "0x60003CD")]
		bool PostCheck(out string message);

		// Token: 0x060003CE RID: 974
		[Token(Token = "0x60003CE")]
		UniTask<bool> OpenReminderAsync(string message);

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003CF RID: 975
		[Token(Token = "0x17000064")]
		UISubPanel<IzakayaConfigPannel> SubPannel
		{
			[Token(Token = "0x60003CF")]
			get;
		}
	}
}

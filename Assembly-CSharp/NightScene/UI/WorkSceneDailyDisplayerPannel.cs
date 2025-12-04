using System;
using Common.UI;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI
{
	// Token: 0x020006A3 RID: 1699
	[Token(Token = "0x20006A3")]
	[GenerateCleanupMethod]
	public class WorkSceneDailyDisplayerPannel : UISubPanel<BaseSustainedPannel>, IExternalPanel
	{
		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x555730", Offset = "0x554130", VA = "0x180555730", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x555850", Offset = "0x554250", VA = "0x180555850", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x4101C0", Offset = "0x40EBC0", VA = "0x1804101C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x5558D0", Offset = "0x5542D0", VA = "0x1805558D0")]
		public WorkSceneDailyDisplayerPannel()
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x5556D0", Offset = "0x5540D0", VA = "0x1805556D0", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DailyRecipePrinterNew m_Printer;
	}
}

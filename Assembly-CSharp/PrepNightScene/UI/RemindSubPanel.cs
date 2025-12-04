using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace PrepNightScene.UI
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[GenerateCleanupMethod]
	public class RemindSubPanel : UIPanelParamOpen<string>
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00003498 File Offset: 0x00001698
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006D")]
		public bool CloseContext
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x574E80", Offset = "0x573880", VA = "0x180574E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x574E90", Offset = "0x573890", VA = "0x180574E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x574C70", Offset = "0x573670", VA = "0x180574C70", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x574D70", Offset = "0x573770", VA = "0x180574D70", Slot = "32")]
		protected override void OnPanelOpen(string finalMessage)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x574C10", Offset = "0x573610", VA = "0x180574C10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x574E40", Offset = "0x573840", VA = "0x180574E40")]
		public RemindSubPanel()
		{
		}

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI m_RemindContext;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_RemindConfirmButton;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_RemindRefuseButton;
	}
}

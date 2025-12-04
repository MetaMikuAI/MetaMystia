using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000E9C RID: 3740
	[Token(Token = "0x2000E9C")]
	[GenerateCleanupMethod]
	public class NoteBookNewsPanelSelector : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x060057F6 RID: 22518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x870CD0", Offset = "0x86F6D0", VA = "0x180870CD0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0x870C60", Offset = "0x86F660", VA = "0x180870C60", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x574C10", Offset = "0x573610", VA = "0x180574C10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F9")]
		[Address(RVA = "0x870E70", Offset = "0x86F870", VA = "0x180870E70")]
		public NoteBookNewsPanelSelector()
		{
		}

		// Token: 0x0400525F RID: 21087
		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private NoteBookNewsPannel m_CompactNewsPanel;

		// Token: 0x04005260 RID: 21088
		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private NoteBookNewsPannelExpandable m_ExpandableNewsPanel;

		// Token: 0x04005261 RID: 21089
		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x88")]
		private UISubPanel<NoteBookMainPannel> m_CurrentSubPanel;
	}
}

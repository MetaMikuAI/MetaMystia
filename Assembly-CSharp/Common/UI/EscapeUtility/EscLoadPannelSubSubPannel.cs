using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F53 RID: 3923
	[Token(Token = "0x2000F53")]
	[GenerateCleanupMethod]
	public class EscLoadPannelSubSubPannel : UISubPanel<EscLoadPannelSubPannel>
	{
		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x00020250 File Offset: 0x0001E450
		[Token(Token = "0x17000CF9")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005C4A")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CFA")]
		[CleanupIgnore]
		public string DisplayedContent
		{
			[Token(Token = "0x6005C4B")]
			[Address(RVA = "0x8AA090", Offset = "0x8A8A90", VA = "0x1808AA090")]
			set
			{
			}
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00020268 File Offset: 0x0001E468
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x8A9E30", Offset = "0x8A8830", VA = "0x1808A9E30", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x8A9EA0", Offset = "0x8A88A0", VA = "0x1808A9EA0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x8AA000", Offset = "0x8A8A00", VA = "0x1808AA000")]
		private void Yes()
		{
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x8A9E50", Offset = "0x8A8850", VA = "0x1808A9E50")]
		private void No()
		{
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x8A9FC0", Offset = "0x8A89C0", VA = "0x1808A9FC0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x574C10", Offset = "0x573610", VA = "0x180574C10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x8AA050", Offset = "0x8A8A50", VA = "0x1808AA050")]
		public EscLoadPannelSubSubPannel()
		{
		}

		// Token: 0x0400558A RID: 21898
		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI Text;

		// Token: 0x0400558B RID: 21899
		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple ConfirmBtn;

		// Token: 0x0400558C RID: 21900
		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple DenyBtn;

		// Token: 0x0400558D RID: 21901
		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0x90")]
		public EscLoadPannelSubSubPannel.PannelResult Result;

		// Token: 0x0400558E RID: 21902
		[Token(Token = "0x400558E")]
		[FieldOffset(Offset = "0x94")]
		private bool m_ShouldInstantClose;

		// Token: 0x02000F54 RID: 3924
		[Token(Token = "0x2000F54")]
		public enum PannelResult
		{
			// Token: 0x04005590 RID: 21904
			[Token(Token = "0x4005590")]
			Yes,
			// Token: 0x04005591 RID: 21905
			[Token(Token = "0x4005591")]
			No
		}
	}
}

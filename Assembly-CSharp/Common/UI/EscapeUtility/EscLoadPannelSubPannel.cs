using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F51 RID: 3921
	[Token(Token = "0x2000F51")]
	[GenerateCleanupMethod]
	public class EscLoadPannelSubPannel : UISubPanel<EscLoadPannel>
	{
		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF7")]
		public string SubPanelDisplayedContent
		{
			[Token(Token = "0x6005C3D")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6005C3E")]
			[Address(RVA = "0x52F180", Offset = "0x52DB80", VA = "0x18052F180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x00020220 File Offset: 0x0001E420
		[Token(Token = "0x17000CF8")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005C3F")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x00020238 File Offset: 0x0001E438
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x8A9710", Offset = "0x8A8110", VA = "0x1808A9710", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x8A97A0", Offset = "0x8A81A0", VA = "0x1808A97A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x8A9B90", Offset = "0x8A8590", VA = "0x1808A9B90")]
		private void PopupConfirmationMenu(string displayedContentKey, EscLoadPannelSubPannel.PannelResult confirmationTarget)
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x8A9AE0", Offset = "0x8A84E0", VA = "0x1808A9AE0")]
		private void OnSubPannelExit()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x8A9A80", Offset = "0x8A8480", VA = "0x1808A9A80", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x8A9730", Offset = "0x8A8130", VA = "0x1808A9730", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x8A9670", Offset = "0x8A8070", VA = "0x1808A9670", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x8A9DF0", Offset = "0x8A87F0", VA = "0x1808A9DF0")]
		public EscLoadPannelSubPannel()
		{
		}

		// Token: 0x0400557D RID: 21885
		[Token(Token = "0x400557D")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple LoadBtn;

		// Token: 0x0400557E RID: 21886
		[Token(Token = "0x400557E")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple DeleteBtn;

		// Token: 0x0400557F RID: 21887
		[Token(Token = "0x400557F")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple BackBtn;

		// Token: 0x04005580 RID: 21888
		[Token(Token = "0x4005580")]
		[FieldOffset(Offset = "0x90")]
		public EscLoadPannelSubSubPannel SubPannel;

		// Token: 0x04005581 RID: 21889
		[Token(Token = "0x4005581")]
		[FieldOffset(Offset = "0x98")]
		public EscLoadPannelSubPannel.PannelResult Result;

		// Token: 0x04005583 RID: 21891
		[Token(Token = "0x4005583")]
		[FieldOffset(Offset = "0xA8")]
		private UILogicalGroup m_AllBtns;

		// Token: 0x04005584 RID: 21892
		[Token(Token = "0x4005584")]
		[FieldOffset(Offset = "0xB0")]
		private EscLoadPannelSubPannel.PannelResult m_Result;

		// Token: 0x04005585 RID: 21893
		[Token(Token = "0x4005585")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_ShouldInstantClose;

		// Token: 0x02000F52 RID: 3922
		[Token(Token = "0x2000F52")]
		public enum PannelResult
		{
			// Token: 0x04005587 RID: 21895
			[Token(Token = "0x4005587")]
			GameLoaded,
			// Token: 0x04005588 RID: 21896
			[Token(Token = "0x4005588")]
			SaveDeleted,
			// Token: 0x04005589 RID: 21897
			[Token(Token = "0x4005589")]
			None
		}
	}
}

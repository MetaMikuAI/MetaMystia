using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000ECB RID: 3787
	[Token(Token = "0x2000ECB")]
	[GenerateCleanupMethod]
	public class NoteBookProfileBadgeSubPannel : UIPanelExtern
	{
		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x0001F590 File Offset: 0x0001D790
		[Token(Token = "0x17000C67")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005943")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		[Token(Token = "0x6005945")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005946")]
		[Address(RVA = "0x88CCD0", Offset = "0x88B6D0", VA = "0x18088CCD0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005947")]
		[Address(RVA = "0x88CA90", Offset = "0x88B490", VA = "0x18088CA90")]
		private void OnBadgeElementEnabled(int id, UIElementCluster component, UIButtonSimple button)
		{
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005948")]
		[Address(RVA = "0x88CF60", Offset = "0x88B960", VA = "0x18088CF60")]
		private void OnSelect(int id, UIElementCluster component, UIButtonSimple button)
		{
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005949")]
		[Address(RVA = "0x88CF70", Offset = "0x88B970", VA = "0x18088CF70")]
		private void UpdateBadgeElements()
		{
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594A")]
		[Address(RVA = "0x88CE50", Offset = "0x88B850", VA = "0x18088CE50", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594B")]
		[Address(RVA = "0x88CC70", Offset = "0x88B670", VA = "0x18088CC70", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594C")]
		[Address(RVA = "0x408B00", Offset = "0x407500", VA = "0x180408B00", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594D")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public NoteBookProfileBadgeSubPannel()
		{
		}

		// Token: 0x040053C5 RID: 21445
		[Token(Token = "0x40053C5")]
		[FieldOffset(Offset = "0x70")]
		[Header("Profile Values Page3")]
		public GameObject badgeElement;

		// Token: 0x040053C6 RID: 21446
		[Token(Token = "0x40053C6")]
		[FieldOffset(Offset = "0x78")]
		public VerticalLayoutGroup badgesContent;

		// Token: 0x040053C7 RID: 21447
		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x80")]
		public CanvasGroup selected;

		// Token: 0x040053C8 RID: 21448
		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent progressIndicator;

		// Token: 0x040053C9 RID: 21449
		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x90")]
		private StaticVirtualScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_LogicalGroup;
	}
}

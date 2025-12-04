using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E30 RID: 3632
	[Token(Token = "0x2000E30")]
	[GenerateCleanupMethod]
	public class DaySceneDecorationPannel : UIPanel
	{
		// Token: 0x060054EC RID: 21740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EC")]
		[Address(RVA = "0x475500", Offset = "0x473F00", VA = "0x180475500", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x837970", Offset = "0x836370", VA = "0x180837970", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EE")]
		[Address(RVA = "0x837640", Offset = "0x836040", VA = "0x180837640")]
		private void OnElementEnabled(Decoration decorationInfo, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x837790", Offset = "0x836190", VA = "0x180837790")]
		private void OnElementSelected(Decoration decorationInfo, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x8378A0", Offset = "0x8362A0", VA = "0x1808378A0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x837620", Offset = "0x836020", VA = "0x180837620")]
		private void DescribeDecorations(Decoration decoration)
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0x837630", Offset = "0x836030", VA = "0x180837630")]
		private void DescribeNull()
		{
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x837560", Offset = "0x835F60", VA = "0x180837560", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x837DC0", Offset = "0x8367C0", VA = "0x180837DC0")]
		public DaySceneDecorationPannel()
		{
		}

		// Token: 0x04004FD6 RID: 20438
		[Token(Token = "0x4004FD6")]
		[FieldOffset(Offset = "0x70")]
		public GameObject itemElement;

		// Token: 0x04004FD7 RID: 20439
		[Token(Token = "0x4004FD7")]
		[FieldOffset(Offset = "0x78")]
		public UIElementCluster itemDescrierCluster;

		// Token: 0x04004FD8 RID: 20440
		[Token(Token = "0x4004FD8")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup itemPannel;

		// Token: 0x04004FD9 RID: 20441
		[Token(Token = "0x4004FD9")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent scroller;

		// Token: 0x04004FDA RID: 20442
		[Token(Token = "0x4004FDA")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<Decoration> m_DecorationList;

		// Token: 0x04004FDB RID: 20443
		[Token(Token = "0x4004FDB")]
		[FieldOffset(Offset = "0x98")]
		private StaticVerticalGridScrollListUILogicalGroupT<Decoration, UIElementCluster, UIButtonSimple> m_DecorationGroup;
	}
}

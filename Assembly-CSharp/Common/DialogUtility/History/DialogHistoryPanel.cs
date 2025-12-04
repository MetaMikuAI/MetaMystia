using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.DialogUtility.History
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	[GenerateCleanupMethod]
	public class DialogHistoryPanel : UIPanelParamOpen<IReadOnlyList<DialogHistory>>
	{
		// Token: 0x060051D3 RID: 20947 RVA: 0x0001DB98 File Offset: 0x0001BD98
		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D4")]
		[Address(RVA = "0x7FBA50", Offset = "0x7FA450", VA = "0x1807FBA50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x7FC010", Offset = "0x7FAA10", VA = "0x1807FC010")]
		private UILogicalUnit SnapToUI(MoveDirection dir)
		{
			return null;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x7FBE40", Offset = "0x7FA840", VA = "0x1807FBE40", Slot = "32")]
		protected override void OnPanelOpen(IReadOnlyList<DialogHistory> openParam)
		{
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x7FB9F0", Offset = "0x7FA3F0", VA = "0x1807FB9F0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x7FC190", Offset = "0x7FAB90", VA = "0x1807FC190")]
		private void Update()
		{
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x7FB910", Offset = "0x7FA310", VA = "0x1807FB910", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x7FC210", Offset = "0x7FAC10", VA = "0x1807FC210")]
		public DialogHistoryPanel()
		{
		}

		// Token: 0x04004CF0 RID: 19696
		[Token(Token = "0x4004CF0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIElementCluster m_UIButton;

		// Token: 0x04004CF1 RID: 19697
		[Token(Token = "0x4004CF1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup m_UpArrow;

		// Token: 0x04004CF2 RID: 19698
		[Token(Token = "0x4004CF2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup m_DownArrow;

		// Token: 0x04004CF3 RID: 19699
		[Token(Token = "0x4004CF3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup m_LayoutGroup;

		// Token: 0x04004CF4 RID: 19700
		[Token(Token = "0x4004CF4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_ProgressIndicatorComponent;

		// Token: 0x04004CF5 RID: 19701
		[Token(Token = "0x4004CF5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color32 m_TypeABackgroundColor;

		// Token: 0x04004CF6 RID: 19702
		[Token(Token = "0x4004CF6")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Color32 m_TypeAForegroundColor;

		// Token: 0x04004CF7 RID: 19703
		[Token(Token = "0x4004CF7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color32 m_TypeBBackgroundColor;

		// Token: 0x04004CF8 RID: 19704
		[Token(Token = "0x4004CF8")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Color32 m_TypeBForegroundColor;

		// Token: 0x04004CF9 RID: 19705
		[Token(Token = "0x4004CF9")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<DialogHistory> m_Histories;

		// Token: 0x04004CFA RID: 19706
		[Token(Token = "0x4004CFA")]
		[FieldOffset(Offset = "0xB8")]
		private MoveDirection? m_CurrentMoveDirection;

		// Token: 0x04004CFB RID: 19707
		[Token(Token = "0x4004CFB")]
		[FieldOffset(Offset = "0xC0")]
		private StaticVerticalGridScrollListUILogicalGroupT<DialogHistory, UIElementCluster, UIButtonSimple> m_LogicalGroupT;
	}
}

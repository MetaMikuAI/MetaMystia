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
using UnityEngine.UI;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x02000F66 RID: 3942
	[Token(Token = "0x2000F66")]
	[GenerateCleanupMethod]
	public class DLC5_InfiniteIngredientPanel : UIPanelParam<DLC5_InfiniteIngredientPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x06005CAE RID: 23726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x8A6EC0", Offset = "0x8A58C0", VA = "0x1808A6EC0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x8A7280", Offset = "0x8A5C80", VA = "0x1808A7280", Slot = "32")]
		protected override void OnPanelOpen(DLC5_InfiniteIngredientPanel.OpenContext openParam)
		{
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x8A6E40", Offset = "0x8A5840", VA = "0x1808A6E40", Slot = "33")]
		protected override void OnPanelClose(int? closeParam)
		{
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x8A6D60", Offset = "0x8A5760", VA = "0x1808A6D60", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x8A7480", Offset = "0x8A5E80", VA = "0x1808A7480")]
		public DLC5_InfiniteIngredientPanel()
		{
		}

		// Token: 0x040055D1 RID: 21969
		[Token(Token = "0x40055D1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_ItemPrefab;

		// Token: 0x040055D2 RID: 21970
		[Token(Token = "0x40055D2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup m_ItemField;

		// Token: 0x040055D3 RID: 21971
		[Token(Token = "0x40055D3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_ProgressIndicator;

		// Token: 0x040055D4 RID: 21972
		[Token(Token = "0x40055D4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Sprite m_NullElement;

		// Token: 0x040055D5 RID: 21973
		[Token(Token = "0x40055D5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x040055D6 RID: 21974
		[Token(Token = "0x40055D6")]
		[FieldOffset(Offset = "0xB0")]
		private StaticVerticalGridScrollListUILogicalGroupT<int?, UIElementCluster, UIButtonSimple> m_Grid;

		// Token: 0x040055D7 RID: 21975
		[Token(Token = "0x40055D7")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<int?> m_Backing;

		// Token: 0x02000F67 RID: 3943
		[Token(Token = "0x2000F67")]
		public readonly struct OpenContext
		{
			// Token: 0x06005CB3 RID: 23731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CB3")]
			[Address(RVA = "0x8AFFD0", Offset = "0x8AE9D0", VA = "0x1808AFFD0")]
			public OpenContext(int? currentSelection, IEnumerable<int> selections)
			{
			}

			// Token: 0x040055D8 RID: 21976
			[Token(Token = "0x40055D8")]
			[FieldOffset(Offset = "0x0")]
			public readonly int? CurrentSelection;

			// Token: 0x040055D9 RID: 21977
			[Token(Token = "0x40055D9")]
			[FieldOffset(Offset = "0x8")]
			public readonly IEnumerable<int> Selections;
		}
	}
}

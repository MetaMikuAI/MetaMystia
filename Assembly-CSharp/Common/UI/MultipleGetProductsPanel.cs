using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.UGUIExtensions;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E64 RID: 3684
	[Token(Token = "0x2000E64")]
	public class MultipleGetProductsPanel : UIPanelParamOpen<MultipleGetProductsPanel.MultipleGetProductsOpenContext>
	{
		// Token: 0x0600561C RID: 22044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561C")]
		[Address(RVA = "0x853EF0", Offset = "0x8528F0", VA = "0x180853EF0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x854A30", Offset = "0x853430", VA = "0x180854A30")]
		private void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x8543C0", Offset = "0x852DC0", VA = "0x1808543C0", Slot = "32")]
		protected override void OnPanelOpen(MultipleGetProductsPanel.MultipleGetProductsOpenContext openParam)
		{
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x855060", Offset = "0x853A60", VA = "0x180855060")]
		private void UpdateVisual([CanBeNull] string key)
		{
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x8551E0", Offset = "0x853BE0", VA = "0x1808551E0")]
		public MultipleGetProductsPanel()
		{
		}

		// Token: 0x040050E1 RID: 20705
		[Token(Token = "0x40050E1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AdpVerticalLayoutGroup m_LeftLabelGridContent;

		// Token: 0x040050E2 RID: 20706
		[Token(Token = "0x40050E2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_Element;

		// Token: 0x040050E3 RID: 20707
		[Token(Token = "0x40050E3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI m_TitleText;

		// Token: 0x040050E4 RID: 20708
		[Token(Token = "0x40050E4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GridLayoutGroup m_RightViewerGridContent;

		// Token: 0x040050E5 RID: 20709
		[Token(Token = "0x40050E5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_GetProductScroller;

		// Token: 0x040050E6 RID: 20710
		[Token(Token = "0x40050E6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x040050E7 RID: 20711
		[Token(Token = "0x40050E7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject m_ObjectStackParent;

		// Token: 0x040050E8 RID: 20712
		[Token(Token = "0x40050E8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup m_DescriberCanvasGroup;

		// Token: 0x040050E9 RID: 20713
		[Token(Token = "0x40050E9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x040050EA RID: 20714
		[Token(Token = "0x40050EA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color m_Normal;

		// Token: 0x040050EB RID: 20715
		[Token(Token = "0x40050EB")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color m_Selected;

		// Token: 0x040050EC RID: 20716
		[Token(Token = "0x40050EC")]
		[FieldOffset(Offset = "0xE8")]
		private AdpVirtualScrollListComponent<string, UIButtonSimple> m_UILogicalGroup;

		// Token: 0x040050ED RID: 20717
		[Token(Token = "0x40050ED")]
		[FieldOffset(Offset = "0xF0")]
		private int currentIndex;

		// Token: 0x040050EE RID: 20718
		[Token(Token = "0x40050EE")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<string, List<Product>> m_ProductDictionary;

		// Token: 0x040050EF RID: 20719
		[Token(Token = "0x40050EF")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<string> m_ProductSourceLabelList;

		// Token: 0x040050F0 RID: 20720
		[Token(Token = "0x40050F0")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<Product> m_AllRecordedProductsList;

		// Token: 0x040050F1 RID: 20721
		[Token(Token = "0x40050F1")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<Product> m_GetProductsList;

		// Token: 0x040050F2 RID: 20722
		[Token(Token = "0x40050F2")]
		[FieldOffset(Offset = "0x118")]
		private StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_GetProductsGroup;

		// Token: 0x040050F3 RID: 20723
		[Token(Token = "0x40050F3")]
		private const int MAX_SHOW_TAB = 8;

		// Token: 0x040050F4 RID: 20724
		[Token(Token = "0x40050F4")]
		private const string ALL_TAG = "AllProducts";

		// Token: 0x02000E65 RID: 3685
		[Token(Token = "0x2000E65")]
		public struct MultipleGetProductsOpenContext
		{
			// Token: 0x06005625 RID: 22053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005625")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public MultipleGetProductsOpenContext(string title, Dictionary<string, List<Product>> getProducts)
			{
			}

			// Token: 0x040050F5 RID: 20725
			[Token(Token = "0x40050F5")]
			[FieldOffset(Offset = "0x0")]
			public readonly string Title;

			// Token: 0x040050F6 RID: 20726
			[Token(Token = "0x40050F6")]
			[FieldOffset(Offset = "0x8")]
			public readonly Dictionary<string, List<Product>> GetProducts;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePoolResultPanel : UIPanelParamOpen<DLC5_RogueLikePoolResultPanel.PoolResultType>
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		public List<int> RecipeGachaResult
		{
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027F")]
		public List<int> BevGachaResult
		{
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x4485C0", Offset = "0x446FC0", VA = "0x1804485C0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x448BA0", Offset = "0x4475A0", VA = "0x180448BA0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikePoolResultPanel.PoolResultType poolResultType)
		{
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x448550", Offset = "0x446F50", VA = "0x180448550", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x4483A0", Offset = "0x446DA0", VA = "0x1804483A0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x4491F0", Offset = "0x447BF0", VA = "0x1804491F0")]
		public DLC5_RogueLikePoolResultPanel()
		{
		}

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject m_ObjectStackParent;

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GridLayoutGroup m_RecipeViewerGridContent;

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GridLayoutGroup m_BevViewerGridContent;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_GachaRecipeScroller;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_GachaBevScroller;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI m_ResultRecipeText;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI m_ResultBevText;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0xC0")]
		private StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GachaRecipeGroup;

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0xC8")]
		private StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GachaBevGroup;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<int> m_GachaRecipePool;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<int> m_GachaBevPool;

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		private const string DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE = "DLC5_ROGUELIKE_RESULT_POOL_ADD_RECIPE";

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		private const string DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV = "DLC5_ROGUELIKE_RESULT_POOL_ADD_BEV";

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		private const string DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE = "DLC5_ROGUELIKE_RESULT_POOL_SOLD_RECIPE";

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		private const string DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV = "DLC5_ROGUELIKE_RESULT_POOL_SOLD_BEV";

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0xF0")]
		private CanvasGroup describerCanvasGroup;

		// Token: 0x020003C1 RID: 961
		[Token(Token = "0x20003C1")]
		public enum PoolResultType
		{
			// Token: 0x04001404 RID: 5124
			[Token(Token = "0x4001404")]
			Add,
			// Token: 0x04001405 RID: 5125
			[Token(Token = "0x4001405")]
			Sold
		}
	}
}

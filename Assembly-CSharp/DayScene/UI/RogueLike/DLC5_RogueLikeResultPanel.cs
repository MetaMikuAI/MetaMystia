using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeResultPanel : UIPanelParamOpen<RogueLikeRunTimeData>
	{
		// Token: 0x060016FE RID: 5886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x460070", Offset = "0x45EA70", VA = "0x180460070", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x460D20", Offset = "0x45F720", VA = "0x180460D20", Slot = "32")]
		protected override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x45FF60", Offset = "0x45E960", VA = "0x18045FF60")]
		private string ConvertSecondsToTimeString(float seconds)
		{
			return null;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001701")]
		[Address(RVA = "0x45FC20", Offset = "0x45E620", VA = "0x18045FC20", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001702")]
		[Address(RVA = "0x4621B0", Offset = "0x460BB0", VA = "0x1804621B0")]
		public DLC5_RogueLikeResultPanel()
		{
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x461F90", Offset = "0x460990", VA = "0x180461F90")]
		[CompilerGenerated]
		internal static void <OnPanelOpen>g__ProcessObject|35_9(UIElementCluster cluster, string key, ref DLC5_RogueLikeResultPanel.<>c__DisplayClass35_0 A_2)
		{
		}

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GridLayoutGroup m_IngredientGridLayoutGroup;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GridLayoutGroup m_BevGridLayoutGroup;

		// Token: 0x04001548 RID: 5448
		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GridLayoutGroup m_FoodGridLayoutGroup;

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup m_RecipeGridLayoutGroup;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject m_PassedTip;

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_Difficulty;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI m_Wave;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI m_WholeTime;

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCostInKourindou;

		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TextMeshProUGUI m_ServedGuestNum;

		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI m_EliteFinishNum;

		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCollectFund;

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TextMeshProUGUI m_MaxEarnedFund;

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCollectMikeCard;

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCollectPersistentCard;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCollectRateText;

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject m_ItemStackWithNum;

		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject m_ItemStack;

		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButtonSimple m_ContinueButton;

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIElementCluster m_CoreRect;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIElementCluster m_DLC1Rect;

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIElementCluster m_DLC2Rect;

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIElementCluster m_DLC3Rect;

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private UIElementCluster m_DLC4Rect;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIElementCluster m_DLC5Rect;

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private UIButtonSimple m_PoolButton;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x148")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_IngProductsGroup;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x150")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BevProductsGroup;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x158")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodProductsGroup;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x160")]
		private StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeProductsGroup;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<KeyValuePair<Ingredient, int>> m_IngProductsList;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<KeyValuePair<Sellable, int>> m_BevProductsList;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x178")]
		private readonly List<KeyValuePair<Sellable, int>> m_FoodProductsList;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x180")]
		private readonly List<Recipe> m_RecipeProductsList;
	}
}

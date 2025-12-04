using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.StorageUtility
{
	// Token: 0x02000E7A RID: 3706
	[Token(Token = "0x2000E7A")]
	[GenerateCleanupMethod]
	public class StorageOtherPannel : UISubPanel<StorageMainPannel>
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		[Token(Token = "0x17000C24")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0x85D260", Offset = "0x85BC60", VA = "0x18085D260", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0x85EE40", Offset = "0x85D840", VA = "0x18085EE40")]
		private void ResetFilter()
		{
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x85D1B0", Offset = "0x85BBB0", VA = "0x18085D1B0", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AC")]
		private void OnElementEnabled<T>(KeyValuePair<T, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple) where T : NonTradableObjectBase
		{
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AD")]
		private void OnElementSelected<T>(KeyValuePair<T, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple) where T : NonTradableObjectBase
		{
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x0001EA08 File Offset: 0x0001CC08
		[Token(Token = "0x60056AE")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x85E850", Offset = "0x85D250", VA = "0x18085E850")]
		private void OnTertiarySwitchCalled(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x85EF60", Offset = "0x85D960", VA = "0x18085EF60")]
		private void SetParamValue(bool enablePinning, Func<int, bool> getPinnedCallback, Action<int, bool> setPinnedCallback, Action<object> describeObjectCallback, IStaticGridScrollListUILogicalGroup currentSelectedGroup, bool canFilter)
		{
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x85E010", Offset = "0x85CA10", VA = "0x18085E010", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x85E870", Offset = "0x85D270", VA = "0x18085E870")]
		private void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x85E8D0", Offset = "0x85D2D0", VA = "0x18085E8D0")]
		private void OpenFilterPanel()
		{
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x85D0D0", Offset = "0x85BAD0", VA = "0x18085D0D0")]
		private void HideDescriber()
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x861770", Offset = "0x860170", VA = "0x180861770")]
		private void UpdateItemCollection()
		{
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x860C20", Offset = "0x85F620", VA = "0x180860C20")]
		private void UpdateCookerCollection()
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x860950", Offset = "0x85F350", VA = "0x180860950")]
		private void UpdateBeverageCollection()
		{
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x860FB0", Offset = "0x85F9B0", VA = "0x180860FB0")]
		private void UpdateFoodsCollection()
		{
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x8615E0", Offset = "0x85FFE0", VA = "0x1808615E0")]
		private void UpdateIngredientCollection()
		{
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x85D150", Offset = "0x85BB50", VA = "0x18085D150", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x0001EA20 File Offset: 0x0001CC20
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x85D070", Offset = "0x85BA70", VA = "0x18085D070")]
		private PlayerSaveFile.DefaultProp GetPinnedType(Ingredient pair)
		{
			return PlayerSaveFile.DefaultProp.Ingredients_SeaFood;
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x85CC50", Offset = "0x85B650", VA = "0x18085CC50", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x861B70", Offset = "0x860570", VA = "0x180861B70")]
		public StorageOtherPannel()
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0001EA50 File Offset: 0x0001CC50
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x8608C0", Offset = "0x85F2C0", VA = "0x1808608C0")]
		[CompilerGenerated]
		internal static int <UpdateItemCollection>g__GetItemOrder|55_3(Item item)
		{
			return 0;
		}

		// Token: 0x0400514F RID: 20815
		[Token(Token = "0x400514F")]
		[FieldOffset(Offset = "0x78")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x04005150 RID: 20816
		[Token(Token = "0x4005150")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup IngredientObjectField;

		// Token: 0x04005151 RID: 20817
		[Token(Token = "0x4005151")]
		[FieldOffset(Offset = "0x88")]
		public CanvasGroup IngredientTagField;

		// Token: 0x04005152 RID: 20818
		[Token(Token = "0x4005152")]
		[FieldOffset(Offset = "0x90")]
		public GridLayoutGroup FoodObjectField;

		// Token: 0x04005153 RID: 20819
		[Token(Token = "0x4005153")]
		[FieldOffset(Offset = "0x98")]
		public GridLayoutGroup BeverageObjectField;

		// Token: 0x04005154 RID: 20820
		[Token(Token = "0x4005154")]
		[FieldOffset(Offset = "0xA0")]
		public GridLayoutGroup KitchenwareObjectField;

		// Token: 0x04005155 RID: 20821
		[Token(Token = "0x4005155")]
		[FieldOffset(Offset = "0xA8")]
		public GridLayoutGroup ItemObjectField;

		// Token: 0x04005156 RID: 20822
		[Token(Token = "0x4005156")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonSimple filterButton;

		// Token: 0x04005157 RID: 20823
		[Token(Token = "0x4005157")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ObjectStackParent;

		// Token: 0x04005158 RID: 20824
		[Token(Token = "0x4005158")]
		[FieldOffset(Offset = "0xC0")]
		private readonly List<KeyValuePair<Sellable, int>> m_Beverages;

		// Token: 0x04005159 RID: 20825
		[Token(Token = "0x4005159")]
		[FieldOffset(Offset = "0xC8")]
		private readonly List<IFilterConfig> m_BeveragesFilter;

		// Token: 0x0400515A RID: 20826
		[Token(Token = "0x400515A")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<IFilterConfig> m_CookersFilter;

		// Token: 0x0400515B RID: 20827
		[Token(Token = "0x400515B")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<KeyValuePair<Sellable, int>> m_Foods;

		// Token: 0x0400515C RID: 20828
		[Token(Token = "0x400515C")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<IFilterConfig> m_FoodsFilter;

		// Token: 0x0400515D RID: 20829
		[Token(Token = "0x400515D")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<KeyValuePair<Ingredient, int>> m_IngredientMeat;

		// Token: 0x0400515E RID: 20830
		[Token(Token = "0x400515E")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<KeyValuePair<Ingredient, int>> m_IngredientOther;

		// Token: 0x0400515F RID: 20831
		[Token(Token = "0x400515F")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<KeyValuePair<Ingredient, int>> m_IngredientSeaFood;

		// Token: 0x04005160 RID: 20832
		[Token(Token = "0x4005160")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<IFilterConfig> m_IngredientsFilter;

		// Token: 0x04005161 RID: 20833
		[Token(Token = "0x4005161")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<KeyValuePair<Ingredient, int>> m_IngredientVeggie;

		// Token: 0x04005162 RID: 20834
		[Token(Token = "0x4005162")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<IFilterConfig> m_ItemFilter;

		// Token: 0x04005163 RID: 20835
		[Token(Token = "0x4005163")]
		[FieldOffset(Offset = "0x118")]
		private readonly List<KeyValuePair<Item, int>> m_Items;

		// Token: 0x04005164 RID: 20836
		[Token(Token = "0x4005164")]
		[FieldOffset(Offset = "0x120")]
		private readonly List<KeyValuePair<Cooker, int>> m_Kitchenwares;

		// Token: 0x04005165 RID: 20837
		[Token(Token = "0x4005165")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<GameObject> m_OtherObjectInstances;

		// Token: 0x04005166 RID: 20838
		[Token(Token = "0x4005166")]
		[FieldOffset(Offset = "0x130")]
		private IStaticGridScrollListUILogicalGroup currentSelectedGroup;

		// Token: 0x04005167 RID: 20839
		[Token(Token = "0x4005167")]
		[FieldOffset(Offset = "0x138")]
		private Action<object> describeObjectCallback;

		// Token: 0x04005168 RID: 20840
		[Token(Token = "0x4005168")]
		[FieldOffset(Offset = "0x140")]
		private bool enablePinning;

		// Token: 0x04005169 RID: 20841
		[Token(Token = "0x4005169")]
		[FieldOffset(Offset = "0x148")]
		private Func<int, bool> getPinnedCallback;

		// Token: 0x0400516A RID: 20842
		[Token(Token = "0x400516A")]
		[FieldOffset(Offset = "0x150")]
		private bool isDescriberHidden;

		// Token: 0x0400516B RID: 20843
		[Token(Token = "0x400516B")]
		[FieldOffset(Offset = "0x158")]
		private CanvasGroup m_BeverageObjectFieldCanvasGroup;

		// Token: 0x0400516C RID: 20844
		[Token(Token = "0x400516C")]
		[FieldOffset(Offset = "0x160")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BeveragesGroup;

		// Token: 0x0400516D RID: 20845
		[Token(Token = "0x400516D")]
		[FieldOffset(Offset = "0x168")]
		private Action m_CurrentSetPinnedCallback;

		// Token: 0x0400516E RID: 20846
		[Token(Token = "0x400516E")]
		[FieldOffset(Offset = "0x170")]
		private CanvasGroup m_FilterButtonCanvasGroup;

		// Token: 0x0400516F RID: 20847
		[Token(Token = "0x400516F")]
		[FieldOffset(Offset = "0x178")]
		private CanvasGroup m_FoodObjectFieldCanvasGroup;

		// Token: 0x04005170 RID: 20848
		[Token(Token = "0x4005170")]
		[FieldOffset(Offset = "0x180")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodsGroup;

		// Token: 0x04005171 RID: 20849
		[Token(Token = "0x4005171")]
		[FieldOffset(Offset = "0x188")]
		private CanvasGroup m_IngredientObjectFieldCanvasGroup;

		// Token: 0x04005172 RID: 20850
		[Token(Token = "0x4005172")]
		[FieldOffset(Offset = "0x190")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_IngredientsGroup;

		// Token: 0x04005173 RID: 20851
		[Token(Token = "0x4005173")]
		[FieldOffset(Offset = "0x198")]
		private CanvasGroup m_ItemObjectFieldCanvasGroup;

		// Token: 0x04005174 RID: 20852
		[Token(Token = "0x4005174")]
		[FieldOffset(Offset = "0x1A0")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Item, int>, UIElementCluster, UIButtonSimple> m_ItemsGroup;

		// Token: 0x04005175 RID: 20853
		[Token(Token = "0x4005175")]
		[FieldOffset(Offset = "0x1A8")]
		private CanvasGroup m_KitchenwareObjectFieldCanvasGroup;

		// Token: 0x04005176 RID: 20854
		[Token(Token = "0x4005176")]
		[FieldOffset(Offset = "0x1B0")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Cooker, int>, UIElementCluster, UIButtonSimple> m_KitchenwaresGroup;

		// Token: 0x04005177 RID: 20855
		[Token(Token = "0x4005177")]
		[FieldOffset(Offset = "0x1B8")]
		private Action<int, bool> setPinnedCallback;
	}
}

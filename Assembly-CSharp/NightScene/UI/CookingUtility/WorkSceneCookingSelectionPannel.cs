using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x0200070F RID: 1807
	[Token(Token = "0x200070F")]
	[GenerateCleanupMethod]
	public class WorkSceneCookingSelectionPannel : UIPanelExtern, IExternalPanel
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0000F438 File Offset: 0x0000D638
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E2")]
		public WorkSceneCookingSelectionPannel.PannelOpenContext? OpenContext
		{
			[Token(Token = "0x6002AC0")]
			[Address(RVA = "0x590A80", Offset = "0x58F480", VA = "0x180590A80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6002AC1")]
			[Address(RVA = "0x590AB0", Offset = "0x58F4B0", VA = "0x180590AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0000F450 File Offset: 0x0000D650
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E3")]
		public WorkSceneCookingSelectionPannel.PannelCloseType CloseContext
		{
			[Token(Token = "0x6002AC2")]
			[Address(RVA = "0x590A10", Offset = "0x58F410", VA = "0x180590A10")]
			[CompilerGenerated]
			get
			{
				return WorkSceneCookingSelectionPannel.PannelCloseType.DoNothing;
			}
			[Token(Token = "0x6002AC3")]
			[Address(RVA = "0x590AA0", Offset = "0x58F4A0", VA = "0x180590AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0000F468 File Offset: 0x0000D668
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E4")]
		public float QTEMultiplier
		{
			[Token(Token = "0x6002AC4")]
			[Address(RVA = "0x45EA40", Offset = "0x45D440", VA = "0x18045EA40")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002AC5")]
			[Address(RVA = "0x45F030", Offset = "0x45DA30", VA = "0x18045F030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E5")]
		private CookController CookerParent
		{
			[Token(Token = "0x6002AC6")]
			[Address(RVA = "0x590A20", Offset = "0x58F420", VA = "0x180590A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x170005E6")]
		private bool CheckHasIngredients
		{
			[Token(Token = "0x6002AC7")]
			[Address(RVA = "0x590980", Offset = "0x58F380", VA = "0x180590980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x58D320", Offset = "0x58BD20", VA = "0x18058D320", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x58BED0", Offset = "0x58A8D0", VA = "0x18058BED0")]
		private bool CheckRecipeIsNotLocked(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x58E0E0", Offset = "0x58CAE0", VA = "0x18058E0E0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0x58D220", Offset = "0x58BC20", VA = "0x18058D220", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x590220", Offset = "0x58EC20", VA = "0x180590220")]
		private void UpdateRecipeField()
		{
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x58FF70", Offset = "0x58E970", VA = "0x18058FF70")]
		private void UpdateIngField()
		{
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x590550", Offset = "0x58EF50", VA = "0x180590550")]
		private void UpdateSelectedField()
		{
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x590010", Offset = "0x58EA10", VA = "0x180590010")]
		private void UpdateOutputField()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x58BDC0", Offset = "0x58A7C0", VA = "0x18058BDC0")]
		private static bool CheckPinned(Ingredient ingredient)
		{
			return default(bool);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x58C9A0", Offset = "0x58B3A0", VA = "0x18058C9A0")]
		private void OnIngElementEnabled(KeyValuePair<Ingredient, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x58CCC0", Offset = "0x58B6C0", VA = "0x18058CCC0")]
		private void OnIngElementSelected(KeyValuePair<Ingredient, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x58E840", Offset = "0x58D240", VA = "0x18058E840")]
		private void OnRecipeElementEnabled(Recipe recipe, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x58EBA0", Offset = "0x58D5A0", VA = "0x18058EBA0")]
		private void OnRecipeElementSelected(Recipe recipe, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x58ED60", Offset = "0x58D760", VA = "0x18058ED60")]
		private void OnSelectedIngredientsSelected(Ingredient ingredient, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x58CEE0", Offset = "0x58B8E0", VA = "0x18058CEE0")]
		private void OnOutputSelected(WorkSceneCookingSelectionPannel.MatchedCookCombo solved, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x58FC30", Offset = "0x58E630", VA = "0x18058FC30")]
		private void UpdateAllVisual()
		{
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x58C360", Offset = "0x58AD60", VA = "0x18058C360")]
		private void MatchingSelected(List<WorkSceneCookingSelectionPannel.MatchedCookCombo> matchedCookCombos, out bool haveUnObtainedCombo)
		{
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x58EF00", Offset = "0x58D900", VA = "0x18058EF00")]
		private void TryReturnSelectedIngredients()
		{
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x58BF90", Offset = "0x58A990", VA = "0x18058BF90", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x5906F0", Offset = "0x58F0F0", VA = "0x1805906F0")]
		public WorkSceneCookingSelectionPannel()
		{
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x5561C0", Offset = "0x554BC0", VA = "0x1805561C0", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		[FieldOffset(Offset = "0x78")]
		public Image cookerVisual;

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI cookerName;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		[FieldOffset(Offset = "0x88")]
		public CanvasGroup describerPanel;

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x90")]
		public SellableDescriber sellableDescriber;

		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x98")]
		public GameObject objectStackParent;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject objectParent;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0xA8")]
		public AdpProgressIndicatorComponent scroller;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0xB0")]
		public AdpProgressIndicatorComponent scrollerForRecipe;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0xB8")]
		public AdpProgressIndicatorComponent scrollerForOutput;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0xC0")]
		public CanvasGroup wholeIngField;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0xC8")]
		public GridLayoutGroup ingredientField;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0xD0")]
		public GridLayoutGroup recipeField;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0xD8")]
		public GridLayoutGroup selectedField;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0xE0")]
		public GridLayoutGroup outputField;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject outputElement;

		// Token: 0x0400273D RID: 10045
		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0xF0")]
		public Color noTransparentColor;

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x100")]
		public Color highLightColor;

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x110")]
		public AudioClip potOpenSFX;

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x118")]
		public AudioClip grillOpenSFX;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x120")]
		public AudioClip panOpenSFX;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x128")]
		public AudioClip streamerOpenSFX;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x130")]
		public AudioClip cuttingboardOpenSFX;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<KeyValuePair<Ingredient, int>> m_Ingredient_MeatInstances;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<KeyValuePair<Ingredient, int>> m_Ingredient_OtherInstances;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<KeyValuePair<Ingredient, int>> m_Ingredient_SeaFoodInstances;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<KeyValuePair<Ingredient, int>> m_Ingredient_VeggiesInsatance;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<WorkSceneCookingSelectionPannel.MatchedCookCombo> m_OutputInstances;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<Recipe> m_RecipeInstances;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<Ingredient> m_SelectedInstances;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<int> selectedIngredients;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x178")]
		private Comparer<bool> _comparer;

		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		[FieldOffset(Offset = "0x180")]
		private int ExtraCostIng;

		// Token: 0x0400274E RID: 10062
		[Token(Token = "0x400274E")]
		[FieldOffset(Offset = "0x184")]
		private bool hasImported;

		// Token: 0x0400274F RID: 10063
		[Token(Token = "0x400274F")]
		[FieldOffset(Offset = "0x188")]
		private Recipe importedRecipe;

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x190")]
		private float ingAlpha;

		// Token: 0x04002751 RID: 10065
		[Token(Token = "0x4002751")]
		[FieldOffset(Offset = "0x194")]
		private bool IsFreeCook;

		// Token: 0x04002752 RID: 10066
		[Token(Token = "0x4002752")]
		[FieldOffset(Offset = "0x195")]
		private bool IsQuickCook;

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x196")]
		private bool isSelectingOutputArea;

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		[FieldOffset(Offset = "0x198")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_StaticIngredientsGroup;

		// Token: 0x04002755 RID: 10069
		[Token(Token = "0x4002755")]
		[FieldOffset(Offset = "0x1A0")]
		private StaticVerticalGridScrollListUILogicalGroupT<WorkSceneCookingSelectionPannel.MatchedCookCombo, UIElementCluster, UIButtonSimple> m_StaticOutputGroup;

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x1A8")]
		private StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_StaticRecipeGroup;

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x1B0")]
		private StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple> m_StaticSelectedIngredientsGroup;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x1B8")]
		private CanvasGroup outputFieldCanvasGroup;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x1C0")]
		private float recipeAlpha;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x1C8")]
		private CanvasGroup recipeFieldCanvasGroup;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x1D0")]
		private CanvasGroup selectedFieldCanvasGroup;

		// Token: 0x02000710 RID: 1808
		[Token(Token = "0x2000710")]
		public enum PannelCloseType
		{
			// Token: 0x04002760 RID: 10080
			[Token(Token = "0x4002760")]
			DoNothing,
			// Token: 0x04002761 RID: 10081
			[Token(Token = "0x4002761")]
			RequireGotoQTEPanel
		}

		// Token: 0x02000711 RID: 1809
		[Token(Token = "0x2000711")]
		public readonly struct PannelOpenContext
		{
			// Token: 0x06002AE4 RID: 10980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x584E10", Offset = "0x583810", VA = "0x180584E10")]
			public PannelOpenContext(CookController cookController, float ingredientAlpha, float recipeAlpha)
			{
			}

			// Token: 0x04002762 RID: 10082
			[Token(Token = "0x4002762")]
			[FieldOffset(Offset = "0x0")]
			public readonly CookController CookController;

			// Token: 0x04002763 RID: 10083
			[Token(Token = "0x4002763")]
			[FieldOffset(Offset = "0x8")]
			public readonly float IngredientAlpha;

			// Token: 0x04002764 RID: 10084
			[Token(Token = "0x4002764")]
			[FieldOffset(Offset = "0xC")]
			public readonly float RecipeAlpha;
		}

		// Token: 0x02000712 RID: 1810
		[Token(Token = "0x2000712")]
		public class MatchedCookCombo
		{
			// Token: 0x06002AE5 RID: 10981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002AE5")]
			[Address(RVA = "0x3ED990", Offset = "0x3EC390", VA = "0x1803ED990")]
			public MatchedCookCombo(Recipe recipe, int[] modifiers)
			{
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005E7")]
			public Recipe Recipe
			{
				[Token(Token = "0x6002AE6")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005E8")]
			public int[] Modifiers
			{
				[Token(Token = "0x6002AE7")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06002AE8 RID: 10984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x584BC0", Offset = "0x5835C0", VA = "0x180584BC0")]
			public Sellable GetResult(Cooker cooker)
			{
				return null;
			}
		}
	}
}

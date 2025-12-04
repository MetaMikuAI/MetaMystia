using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	[GenerateCleanupMethod]
	public class DaySceneCookingPannel : UIPanel
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x17000174")]
		private bool IsRegisteredUpToLimit
		{
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x906100", Offset = "0x904B00", VA = "0x180906100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x9040A0", Offset = "0x902AA0", VA = "0x1809040A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x905E00", Offset = "0x904800", VA = "0x180905E00")]
		private void UpdateRecipeRequireIngredients(Recipe recipe)
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x903FF0", Offset = "0x9029F0", VA = "0x180903FF0", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x904650", Offset = "0x903050", VA = "0x180904650", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x903EF0", Offset = "0x9028F0", VA = "0x180903EF0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x903D40", Offset = "0x902740", VA = "0x180903D40")]
		private Sprite GetVisualAtIndex(int index)
		{
			return null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x903C60", Offset = "0x902660", VA = "0x180903C60")]
		private string GetTimeStampAtIndex(int index)
		{
			return null;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x905AC0", Offset = "0x9044C0", VA = "0x180905AC0")]
		private void UpdateElements()
		{
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x904C50", Offset = "0x903650", VA = "0x180904C50")]
		private void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x904E70", Offset = "0x903870", VA = "0x180904E70")]
		private void OpenFilterPanel()
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x903BF0", Offset = "0x9025F0", VA = "0x180903BF0")]
		private void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x903BC0", Offset = "0x9025C0", VA = "0x180903BC0")]
		private void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x903950", Offset = "0x902350", VA = "0x180903950", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x905F30", Offset = "0x904930", VA = "0x180905F30")]
		public DaySceneCookingPannel()
		{
		}

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform customSpacingRect;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x78")]
		public GameObject objectElement;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x80")]
		public GameObject objectStackElement;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIElementCluster[] m_AllRowsBackgrounds;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x90")]
		public GridLayoutGroup recipeField;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x98")]
		public GridLayoutGroup outputField;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0xA0")]
		public SellableDescriber sellableDescriber;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0xA8")]
		public Color onDisabledColor;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonHold onSubmitButton;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0xC0")]
		public Sprite[] timeFieldVariations;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0xC8")]
		public AdpProgressIndicatorComponent RecipeScroller;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0xD0")]
		public AdpProgressIndicatorComponent SelectedScroller;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0xD8")]
		public DescriberSwitcher DescriberSwitcher;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image[] m_RequiredIngredients;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0xE8")]
		public UIButtonSimple filterButton;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<Recipe> allRecipeInstances;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<int> listVariationIndex;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<IFilterConfig> m_FilterConfigs;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<DaySceneCookingPannel.ScheduledRecipe> scheduledRecipes;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<int> willRemovedIngredients;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x118")]
		private int cookCount;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x11C")]
		private int currentCookActions;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x120")]
		private StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeFieldGroup;

		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0x128")]
		private StaticVerticalGridScrollListUILogicalGroupT<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple> m_SelectedFieldGroup;

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x130")]
		private int maxCookCount;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x138")]
		private int[] variations;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x140")]
		private CanvasGroup describerCanvasGroup;

		// Token: 0x02000294 RID: 660
		[Token(Token = "0x2000294")]
		private class ScheduledRecipe
		{
			// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000EF5")]
			[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
			public ScheduledRecipe(Recipe recipe)
			{
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000175")]
			public Recipe Recipe
			{
				[Token(Token = "0x6000EF6")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}
	}
}

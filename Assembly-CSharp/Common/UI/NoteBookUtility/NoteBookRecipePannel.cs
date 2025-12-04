using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using Plugins.DEYU;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000ED3 RID: 3795
	[Token(Token = "0x2000ED3")]
	[GenerateCleanupMethod]
	public class NoteBookRecipePannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6A")]
		public List<int> SelectedTagData
		{
			[Token(Token = "0x60059AC")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060059AD RID: 22957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6B")]
		public List<int> OwnedTagData
		{
			[Token(Token = "0x60059AD")]
			[Address(RVA = "0x4D1EB0", Offset = "0x4D08B0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x0001F968 File Offset: 0x0001DB68
		[Token(Token = "0x17000C6C")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60059AE")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x892FF0", Offset = "0x8919F0", VA = "0x180892FF0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x892F40", Offset = "0x891940", VA = "0x180892F40", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x892E70", Offset = "0x891870", VA = "0x180892E70")]
		private void OnKeyboardMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x892800", Offset = "0x891200", VA = "0x180892800")]
		private void FastForwardRecipeSelection(bool positive)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x893930", Offset = "0x892330", VA = "0x180893930")]
		private void OnRecipeBtnSelected(Recipe recipe, UIElementCluster cluster, UIButtonSimple uIButton)
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x892A70", Offset = "0x891470", VA = "0x180892A70")]
		private void InitRecipe(Recipe recipe, UIElementCluster cluster, UIButtonSimple uIButton)
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x892E20", Offset = "0x891820", VA = "0x180892E20", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x892EE0", Offset = "0x8918E0", VA = "0x180892EE0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x893E80", Offset = "0x892880", VA = "0x180893E80")]
		private void UpdateRecipeElements()
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x8707F0", Offset = "0x86F1F0", VA = "0x1808707F0")]
		private void UpdateRightPanel(bool showForRecipe)
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x8934E0", Offset = "0x891EE0", VA = "0x1808934E0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x892630", Offset = "0x891030", VA = "0x180892630", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x8940E0", Offset = "0x892AE0", VA = "0x1808940E0")]
		public NoteBookRecipePannel()
		{
		}

		// Token: 0x04005420 RID: 21536
		[Token(Token = "0x4005420")]
		public const int ALL_TAG_ID = -2147483648;

		// Token: 0x04005421 RID: 21537
		[Token(Token = "0x4005421")]
		public const int POT_TAG_ID = -9;

		// Token: 0x04005422 RID: 21538
		[Token(Token = "0x4005422")]
		public const int GRILL_TAG_ID = -8;

		// Token: 0x04005423 RID: 21539
		[Token(Token = "0x4005423")]
		public const int FRYING_TAG_ID = -7;

		// Token: 0x04005424 RID: 21540
		[Token(Token = "0x4005424")]
		public const int STREAMER_TAG_ID = -6;

		// Token: 0x04005425 RID: 21541
		[Token(Token = "0x4005425")]
		public const int CUTTINGBOARD_TAG_ID = -5;

		// Token: 0x04005426 RID: 21542
		[Token(Token = "0x4005426")]
		private const int FASTFORWARD_COUNT = 10;

		// Token: 0x04005427 RID: 21543
		[Token(Token = "0x4005427")]
		private const int STARTLOOP_COUNT = 11;

		// Token: 0x04005428 RID: 21544
		[Token(Token = "0x4005428")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x04005429 RID: 21545
		[Token(Token = "0x4005429")]
		[FieldOffset(Offset = "0x80")]
		public RecipeDescriber recipeDescriber;

		// Token: 0x0400542A RID: 21546
		[Token(Token = "0x400542A")]
		[FieldOffset(Offset = "0x88")]
		public GameObject recipeObject;

		// Token: 0x0400542B RID: 21547
		[Token(Token = "0x400542B")]
		[FieldOffset(Offset = "0x90")]
		public VerticalLayoutGroup recipeList;

		// Token: 0x0400542C RID: 21548
		[Token(Token = "0x400542C")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonSimple foodTagFillterButton;

		// Token: 0x0400542D RID: 21549
		[Token(Token = "0x400542D")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup rightPannel;

		// Token: 0x0400542E RID: 21550
		[Token(Token = "0x400542E")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup nullPannel;

		// Token: 0x0400542F RID: 21551
		[Token(Token = "0x400542F")]
		[FieldOffset(Offset = "0xB0")]
		public CanvasGroup selected;

		// Token: 0x04005430 RID: 21552
		[Token(Token = "0x4005430")]
		[FieldOffset(Offset = "0xB8")]
		public AdpProgressIndicatorComponent progressIndicator;

		// Token: 0x04005431 RID: 21553
		[Token(Token = "0x4005431")]
		[FieldOffset(Offset = "0xC0")]
		private readonly NumberFormatInfo m_CurrencyInfo;

		// Token: 0x04005432 RID: 21554
		[Token(Token = "0x4005432")]
		[FieldOffset(Offset = "0xC8")]
		private readonly List<IFilterConfig> m_FilterConfigs;

		// Token: 0x04005433 RID: 21555
		[Token(Token = "0x4005433")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<Recipe> m_FilterRecipes;

		// Token: 0x04005434 RID: 21556
		[Token(Token = "0x4005434")]
		[FieldOffset(Offset = "0xD8")]
		private Comparer<int> _comparer;

		// Token: 0x04005435 RID: 21557
		[Token(Token = "0x4005435")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<int, Cooker.CookerType> cookerTypeTag;

		// Token: 0x04005436 RID: 21558
		[Token(Token = "0x4005436")]
		[FieldOffset(Offset = "0xE8")]
		private StaticVirtualScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeLogicalGroup;
	}
}

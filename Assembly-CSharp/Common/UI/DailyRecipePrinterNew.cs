using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData;
using GameData.Core.Collections;
using Il2CppDummyDll;
using Plugins.DEYU;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E6B RID: 3691
	[Token(Token = "0x2000E6B")]
	[GenerateCleanupMethod]
	public class DailyRecipePrinterNew : MonoBehaviour
	{
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600563C RID: 22076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C10")]
		public StaticHorizontalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> RegisteredRecipeGroup
		{
			[Token(Token = "0x600563B")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600563C")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600563D RID: 22077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600563E RID: 22078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C11")]
		public StaticHorizontalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> RegisteredBeverageGroup
		{
			[Token(Token = "0x600563D")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600563E")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C12")]
		public IReadOnlyList<Recipe> RegisteredRecipeList
		{
			[Token(Token = "0x600563F")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06005640 RID: 22080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public IReadOnlyList<Sellable> RegisteredBeverageList
		{
			[Token(Token = "0x6005640")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C14")]
		public SellableDescriber Describer
		{
			[Token(Token = "0x6005641")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C15")]
		public ActionExecutionScheduler Scheduler
		{
			[Token(Token = "0x6005642")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06005643 RID: 22083 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005644 RID: 22084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000036")]
		public event Action<Recipe, UIElementCluster, UIButtonSimple> RecipeSelected
		{
			[Token(Token = "0x6005643")]
			[Address(RVA = "0x84DF30", Offset = "0x84C930", VA = "0x18084DF30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005644")]
			[Address(RVA = "0x84E450", Offset = "0x84CE50", VA = "0x18084E450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06005645 RID: 22085 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005646 RID: 22086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000037")]
		public event Action<Sellable, UIElementCluster, UIButtonSimple> BeverageSelected
		{
			[Token(Token = "0x6005645")]
			[Address(RVA = "0x84DAD0", Offset = "0x84C4D0", VA = "0x18084DAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005646")]
			[Address(RVA = "0x84DFF0", Offset = "0x84C9F0", VA = "0x18084DFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06005647 RID: 22087 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005648 RID: 22088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000038")]
		public event Action<Recipe> OnDescribeRecipe
		{
			[Token(Token = "0x6005647")]
			[Address(RVA = "0x84DC50", Offset = "0x84C650", VA = "0x18084DC50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005648")]
			[Address(RVA = "0x84E170", Offset = "0x84CB70", VA = "0x18084E170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06005649 RID: 22089 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600564A RID: 22090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000039")]
		public event Action<int, MoveDirection> OnRecipeCustomLoop
		{
			[Token(Token = "0x6005649")]
			[Address(RVA = "0x84DD10", Offset = "0x84C710", VA = "0x18084DD10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600564A")]
			[Address(RVA = "0x84E230", Offset = "0x84CC30", VA = "0x18084E230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600564B RID: 22091 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600564C RID: 22092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003A")]
		public event Action<int, MoveDirection> OnBeverageCustomLoop
		{
			[Token(Token = "0x600564B")]
			[Address(RVA = "0x84DB90", Offset = "0x84C590", VA = "0x18084DB90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600564C")]
			[Address(RVA = "0x84E0B0", Offset = "0x84CAB0", VA = "0x18084E0B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600564D RID: 22093 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600564E RID: 22094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003B")]
		public event Action OnRegisteredRecipeUpDown
		{
			[Token(Token = "0x600564D")]
			[Address(RVA = "0x84DE80", Offset = "0x84C880", VA = "0x18084DE80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600564E")]
			[Address(RVA = "0x84E3A0", Offset = "0x84CDA0", VA = "0x18084E3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600564F RID: 22095 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005650 RID: 22096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003C")]
		public event Action OnRegisteredBeverageUpDown
		{
			[Token(Token = "0x600564F")]
			[Address(RVA = "0x84DDD0", Offset = "0x84C7D0", VA = "0x18084DDD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005650")]
			[Address(RVA = "0x84E2F0", Offset = "0x84CCF0", VA = "0x18084E2F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005651")]
		[Address(RVA = "0x84CAD0", Offset = "0x84B4D0", VA = "0x18084CAD0")]
		public void Init(bool noVerticalMovement, Func<CancellationToken> getTokenCallback)
		{
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005652")]
		[Address(RVA = "0x84D690", Offset = "0x84C090", VA = "0x18084D690")]
		private void OnRecipeCustomLoopCalled(int index, MoveDirection moveDirection)
		{
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005653")]
		[Address(RVA = "0x84D260", Offset = "0x84BC60", VA = "0x18084D260")]
		private void OnBeverageCustomLoopCalled(int index, MoveDirection moveDirection)
		{
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005654")]
		[Address(RVA = "0x84D480", Offset = "0x84BE80", VA = "0x18084D480")]
		private void OnFoodEnabled(Recipe recipe, UIElementCluster ui, UIButtonSimple visual)
		{
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005655")]
		[Address(RVA = "0x84C760", Offset = "0x84B160", VA = "0x18084C760")]
		private void InitValidRecipe(Recipe recipe, UIElementCluster ui)
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x84D280", Offset = "0x84BC80", VA = "0x18084D280")]
		private void OnBeverageEnabled(Sellable beverage, UIElementCluster ui, UIButtonSimple visual)
		{
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x84C600", Offset = "0x84B000", VA = "0x18084C600")]
		private static void InitValidBeverage(Sellable beverage, UIElementCluster ui)
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005658")]
		private void OnElementEnabledShared<TValue>(TValue value, UIElementCluster ui, Action<TValue, UIElementCluster> initValidCallback) where TValue : class
		{
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005659")]
		[Address(RVA = "0x84D540", Offset = "0x84BF40", VA = "0x18084D540")]
		private void OnFoodSelected(Recipe recipe, UIElementCluster ui, UIButtonSimple visual)
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x84D330", Offset = "0x84BD30", VA = "0x18084D330")]
		private void OnBeverageSelected(Sellable beverage, UIElementCluster ui, UIButtonSimple visual)
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x84D710", Offset = "0x84C110", VA = "0x18084D710")]
		public void UpdateDaily()
		{
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565C")]
		[Address(RVA = "0x84C3D0", Offset = "0x84ADD0", VA = "0x18084C3D0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565D")]
		[Address(RVA = "0x84D9A0", Offset = "0x84C3A0", VA = "0x18084D9A0")]
		public DailyRecipePrinterNew()
		{
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565F")]
		[CompilerGenerated]
		internal static void <UpdateDaily>g__InitList|66_0<T>(List<T> value, IEnumerable<T> srcList, int emptyCount, IStaticGridScrollListUILogicalGroup group) where T : class
		{
		}

		// Token: 0x04005102 RID: 20738
		[Token(Token = "0x4005102")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x04005103 RID: 20739
		[Token(Token = "0x4005103")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridLayoutGroup m_RecipeGrid;

		// Token: 0x04005104 RID: 20740
		[Token(Token = "0x4005104")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup m_BeverageGrid;

		// Token: 0x04005105 RID: 20741
		[Token(Token = "0x4005105")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_RecipeParent;

		// Token: 0x04005106 RID: 20742
		[Token(Token = "0x4005106")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_BeverageParent;

		// Token: 0x04005107 RID: 20743
		[Token(Token = "0x4005107")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_RecipeScroller;

		// Token: 0x04005108 RID: 20744
		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_BeverageScroller;

		// Token: 0x04005109 RID: 20745
		[Token(Token = "0x4005109")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup m_DescriberPanel;

		// Token: 0x0400510A RID: 20746
		[Token(Token = "0x400510A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x0400510B RID: 20747
		[Token(Token = "0x400510B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite m_Check;

		// Token: 0x0400510C RID: 20748
		[Token(Token = "0x400510C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite m_Cross;

		// Token: 0x0400510D RID: 20749
		[Token(Token = "0x400510D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color m_CheckColor;

		// Token: 0x0400510E RID: 20750
		[Token(Token = "0x400510E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color m_CrossColor;

		// Token: 0x0400510F RID: 20751
		[Token(Token = "0x400510F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color m_LockColor;

		// Token: 0x04005110 RID: 20752
		[Token(Token = "0x4005110")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageString m_RecipeNamePrefix;

		// Token: 0x04005111 RID: 20753
		[Token(Token = "0x4005111")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<Sellable> m_BeverageList;

		// Token: 0x04005112 RID: 20754
		[Token(Token = "0x4005112")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<Recipe> m_RecipeList;

		// Token: 0x04005113 RID: 20755
		[Token(Token = "0x4005113")]
		[FieldOffset(Offset = "0xB8")]
		private readonly HashSet<Cooker.CookerType> m_RegisteredCookerTypes;

		// Token: 0x04005114 RID: 20756
		[Token(Token = "0x4005114")]
		[FieldOffset(Offset = "0xC0")]
		private Func<CancellationToken> m_GetTokenCallback;
	}
}

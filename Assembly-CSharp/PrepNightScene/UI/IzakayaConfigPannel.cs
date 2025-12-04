using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using Common.UI.Filter;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.RunTime.Common;
using GameData.RunTime.NightSceneUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PrepNightScene.UI
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[GenerateCleanupMethod]
	public class IzakayaConfigPannel : UIPanelParamExternOpen<IPostExtraChecker>
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x569320", Offset = "0x567D20", VA = "0x180569320", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x56A4F0", Offset = "0x568EF0", VA = "0x18056A4F0", Slot = "32")]
		protected override void OnPanelOpen(IPostExtraChecker extraChecker)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x5692F0", Offset = "0x567CF0", VA = "0x1805692F0")]
		public void LoadPreset(in PlayerSaveFile.HistoryIzakayaMenuSelection preset)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x568CE0", Offset = "0x5676E0", VA = "0x180568CE0")]
		private static void LoadPresetInternal(in PlayerSaveFile.HistoryIzakayaMenuSelection preset)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x5681E0", Offset = "0x566BE0", VA = "0x1805681E0")]
		private void GoToSpecific(IzakayaConfigPannel.CurrentConfigType currentConfigType)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x568C70", Offset = "0x567670", VA = "0x180568C70")]
		private static void HighlightObject(CanvasGroup visual)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x568170", Offset = "0x566B70", VA = "0x180568170")]
		private static void DeHighlightObject(CanvasGroup visual)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x56AB50", Offset = "0x569550", VA = "0x18056AB50")]
		private void SolveDailyCompletion()
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x568AC0", Offset = "0x5674C0", VA = "0x180568AC0")]
		private UniTask GotoWork()
		{
			return default(UniTask);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x56A7B0", Offset = "0x5691B0", VA = "0x18056A7B0")]
		public void OpenCurrentGroupFilter()
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x567D20", Offset = "0x566720", VA = "0x180567D20", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x56C220", Offset = "0x56AC20", VA = "0x18056C220")]
		public IzakayaConfigPannel()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x56C190", Offset = "0x56AB90", VA = "0x18056C190")]
		[CompilerGenerated]
		private void <SolveDailyCompletion>g__FadeDelayed|61_14()
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x56C110", Offset = "0x56AB10", VA = "0x18056C110")]
		[CompilerGenerated]
		private IEnumerator <SolveDailyCompletion>g__Execute|61_16()
		{
			return null;
		}

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		private const int LEVEL_1_RECOMMEND_NUM = 5;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		private const int LEVEL_2_RECOMMEND_NUM = 10;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		private const int LEVEL_3_RECOMMEND_NUM = 15;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		private const string LINE_PADDING = "<line-height=30%>\n<line-height=100%>";

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DailyRecipePrinterNew m_DailyRecipePrinter;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DescriberSwitcher m_DescriberSwitcher;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_ObjectStackParent;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject m_RegisteredCookerParent;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GridLayoutGroup m_InStorageRecipeField;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GridLayoutGroup m_InStorageBevField;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GridLayoutGroup m_InStorageCookerField;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GridLayoutGroup m_RegisteredCookerField;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonHold m_GotoWorkButton;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_InStorageScroller;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup m_ItemBlocker;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup m_GotoWorkBlocker;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup m_RecipeHighlighter;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup m_BeverageHighlighter;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup m_CookerHighlighter;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image m_Condition1;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image m_Condition2;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image m_Condition3;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TextMeshProUGUI m_CondText1;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TextMeshProUGUI m_CondText2;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TextMeshProUGUI m_CondText3;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Color32 m_NotFinishColor;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private Color32 m_FinishedColor;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Image m_RequiredCooker;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private CanvasGroup m_RequiredCookerCanvasGroup;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Image[] m_RequiredIngredients;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private CanvasGroup m_WarningDialog;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TextMeshProUGUI m_WarningContext;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float m_WarningContextStayDuration;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private UIButtonSimple m_SubMenuBtn;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private IzakayaConfigSubPannel m_SubPanel;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x168")]
		[FormerlySerializedAs("m_IzakayaConfigRemindSubPanel")]
		[SerializeField]
		private RemindSubPanel m_RemindSubPanel;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<IFilterConfig> m_BeveragesFilter;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x178")]
		private readonly List<IFilterConfig> m_CookersFilter;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x180")]
		private readonly Dictionary<Cooker.CookerType, List<Recipe>> m_FalseCookerRecipe;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x188")]
		private readonly List<Sellable> m_LackBevergaes;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x190")]
		private readonly List<Sellable> m_LackIngredientsRecipe;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x198")]
		private readonly List<IFilterConfig> m_RecipeFilter;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x1A0")]
		[TupleElementNames(new string[] { "ErrorMessage", "GotoHandle" })]
		private readonly List<ValueTuple<string, Action>> m_WarningKey;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x1A8")]
		private IzakayaConfigPannel.SellableGroup<Sellable> m_BeverageGroup;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x1B0")]
		private IzakayaConfigPannel.CookerGroup m_CookerGroup;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x1B8")]
		private IzakayaConfigPannel.CurrentConfigType m_CurrentConfigType;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x1C0")]
		private IzakayaConfigPannel.IGroup m_CurrentGroup;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x1C8")]
		private CanvasGroup m_InStorageBevGroup;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x1D0")]
		private CanvasGroup m_InStorageCookerGroup;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x1D8")]
		private CanvasGroup m_InStorageRecipeGroup;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x1E0")]
		private IzakayaConfigure m_IzakayaConfigure;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x1E8")]
		private IzakayaConfigPannel.SellableGroup<Recipe> m_RecipeGroup;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x1F0")]
		private bool showTipMessageTonight;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x1F8")]
		private UISubPanel<IzakayaConfigPannel> m_TargetIzakayaConfigSubPannel;

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		private enum CurrentConfigType
		{
			// Token: 0x04000430 RID: 1072
			[Token(Token = "0x4000430")]
			Recipe,
			// Token: 0x04000431 RID: 1073
			[Token(Token = "0x4000431")]
			Beverage,
			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			Cooker
		}

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		private interface IGroup
		{
			// Token: 0x060003E8 RID: 1000
			[Token(Token = "0x60003E8")]
			void EnterGroup();

			// Token: 0x060003E9 RID: 1001
			[Token(Token = "0x60003E9")]
			void ExitGroup();
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		private abstract class GroupBase<TInStorageInfo, TRegisteredInfo> where TInStorageInfo : NonTradableObjectBase
		{
			// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003EA")]
			protected GroupBase(Func<int, bool> getPinnedCallback, Func<bool> getCanAddMoreCallback, Action<bool> toggleInStorageBlockerCallback, Action<TRegisteredInfo> registerDataCallback, Action<TInStorageInfo> describeObjectCallback, Action<TRegisteredInfo> describeRegisteredObjectCallback, Action<TRegisteredInfo> deRegisterDataCallback, Action solveDailyCompletionCallback, List<IFilterConfig> filter)
			{
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060003EB RID: 1003
			[Token(Token = "0x17000065")]
			protected abstract int RegisteredElementCount
			{
				[Token(Token = "0x60003EB")]
				get;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003EC")]
			protected void OnInStorageElementSelected(TInStorageInfo value, UIElementCluster cluster, UIButtonSimple btn)
			{
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003ED")]
			private void UpdateAndTrySelectInStorageGroup()
			{
			}

			// Token: 0x060003EE RID: 1006
			[Token(Token = "0x60003EE")]
			protected abstract TRegisteredInfo GetRegisterInfoKey(TInStorageInfo value);

			// Token: 0x060003EF RID: 1007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003EF")]
			protected void OnRegisteredElementSelected(TRegisteredInfo tValue, UIElementCluster ui, UIButtonSimple btn)
			{
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F0")]
			private void UpdateAndTrySelectRegisteredGroup()
			{
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F1")]
			protected void DescribeInStorageObjectCallback(TInStorageInfo value, UIElementCluster cluster, UIButtonSimple btn)
			{
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F2")]
			public void UpdateGroupRaw()
			{
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F3")]
			private void UpdateGroup()
			{
			}

			// Token: 0x060003F4 RID: 1012
			[Token(Token = "0x60003F4")]
			protected abstract void OnUpdateGroup();

			// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F5")]
			public void ExitGroup()
			{
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F6")]
			public void EnterGroup()
			{
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F7")]
			protected void OnRegisteredCustomLoop(int rowIndex, MoveDirection moveDirection)
			{
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F8")]
			protected void ProcessInStorageEdgeElementCallback(UIButtonSimple ui, AdpUISystemUtils.BorderElementType borderElementType, int columnIndex, int rowIndex)
			{
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003F9")]
			protected void TryNavigateToInStorage()
			{
			}

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<TRegisteredInfo> m_DeRegisterDataCallback;

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<TInStorageInfo> m_DescribeObjectCallback;

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<TRegisteredInfo> m_DescribeRegisteredObjectCallback;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x0")]
			protected readonly List<IFilterConfig> m_Filter;

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<bool> m_GetCanAddMoreCallback;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<int, bool> m_GetPinnedCallback;

			// Token: 0x04000439 RID: 1081
			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<TRegisteredInfo> m_RegisterDataCallback;

			// Token: 0x0400043A RID: 1082
			[Token(Token = "0x400043A")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action m_SolveDailyCompletionCallback;

			// Token: 0x0400043B RID: 1083
			[Token(Token = "0x400043B")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<bool> m_ToggleInStorageBlockerCallback;

			// Token: 0x0400043C RID: 1084
			[Token(Token = "0x400043C")]
			[FieldOffset(Offset = "0x0")]
			protected Func<TInStorageInfo, int> GetAmountCallback;

			// Token: 0x0400043D RID: 1085
			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x0")]
			protected IStaticGridScrollListUILogicalGroupT<TInStorageInfo> InStorageGroup;

			// Token: 0x0400043E RID: 1086
			[Token(Token = "0x400043E")]
			[FieldOffset(Offset = "0x0")]
			protected StaticHorizontalGridScrollListUILogicalGroupT<TRegisteredInfo, UIElementCluster, UIButtonSimple> RegisteredGroup;
		}

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		private class CookerGroup : IzakayaConfigPannel.GroupBase<Cooker, KeyValuePair<int, Cooker>>, IzakayaConfigPannel.IGroup
		{
			// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x55ECE0", Offset = "0x55D6E0", VA = "0x18055ECE0")]
			public CookerGroup(GridLayoutGroup inStorageLayout, AdpProgressIndicatorComponent inStorageScroller, GameObject objectStackedParent, GridLayoutGroup registeredLayout, AdpProgressIndicatorComponent registeredScroller, GameObject registeredParent, Func<int, bool> getPinnedCallback, Func<bool> getCanAddMoreCallback, Action<bool> toggleInStorageBlockerCallback, Action<KeyValuePair<int, Cooker>> registerDataCallback, Action<KeyValuePair<int, Cooker>> deRegisterDataCallback, Action<Cooker> describeObjectCallback, Action<KeyValuePair<int, Cooker>> describeRegisteredObjectCallback, Action solveDailyCompletionCallback, List<IFilterConfig> filter)
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00003108 File Offset: 0x00001308
			[Token(Token = "0x17000066")]
			protected override int RegisteredElementCount
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x55F3F0", Offset = "0x55DDF0", VA = "0x18055F3F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00003120 File Offset: 0x00001320
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x55E240", Offset = "0x55CC40", VA = "0x18055E240", Slot = "5")]
			protected override KeyValuePair<int, Cooker> GetRegisterInfoKey(Cooker value)
			{
				return default(KeyValuePair<int, Cooker>);
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x55E5D0", Offset = "0x55CFD0", VA = "0x18055E5D0", Slot = "6")]
			protected override void OnUpdateGroup()
			{
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x55E320", Offset = "0x55CD20", VA = "0x18055E320")]
			public static IEnumerable<Cooker> GetUnAssignedCookers(ref Dictionary<Cooker, int> buffer)
			{
				return null;
			}

			// Token: 0x04000445 RID: 1093
			[Token(Token = "0x4000445")]
			[FieldOffset(Offset = "0x70")]
			private readonly List<Cooker> m_InStorageElements;

			// Token: 0x04000446 RID: 1094
			[Token(Token = "0x4000446")]
			[FieldOffset(Offset = "0x78")]
			private readonly List<KeyValuePair<int, Cooker>> m_RegisteredElements;

			// Token: 0x04000447 RID: 1095
			[Token(Token = "0x4000447")]
			[FieldOffset(Offset = "0x80")]
			private Dictionary<Cooker, int> m_CookerAmountBuffer;
		}

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		private class SellableGroup<T> : IzakayaConfigPannel.GroupBase<T, T>, IzakayaConfigPannel.IGroup where T : NonTradableObjectBase
		{
			// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000417")]
			public SellableGroup(GridLayoutGroup inStorageLayout, GameObject objectStackedParent, AdpProgressIndicatorComponent scroller, Func<T, int> getAmountCallback, Func<int, bool> getPinnedCallback, Action<NonTradableObjectBase> registerDataCallback, Action<NonTradableObjectBase> deRegisterDataCallback, Action<T> describeObjectCallback, Func<IEnumerable<T>> getInStorageObjectCallback, Func<bool> canAddMoreCallback, DailyRecipePrinterNew dailyRecipePrinter, bool isRecipe, Action<bool> toggleInStorageBlockerCallback, Action solveDailyCompletionCallback, StaticHorizontalGridScrollListUILogicalGroupT<T, UIElementCluster, UIButtonSimple> registeredGroup, List<IFilterConfig> filter)
			{
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x00003198 File Offset: 0x00001398
			[Token(Token = "0x17000067")]
			protected override int RegisteredElementCount
			{
				[Token(Token = "0x6000418")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000419")]
			private void OnRegisteredElementSelectedBaseTyped(NonTradableObjectBase tValue, UIElementCluster ui, UIButtonSimple btn)
			{
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600041A")]
			protected override T GetRegisterInfoKey(T value)
			{
				return null;
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600041B")]
			protected override void OnUpdateGroup()
			{
			}

			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			[FieldOffset(Offset = "0x0")]
			private readonly DailyRecipePrinterNew m_DailyRecipePrinter;

			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			[FieldOffset(Offset = "0x0")]
			private readonly List<T> m_Elements;

			// Token: 0x04000455 RID: 1109
			[Token(Token = "0x4000455")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<IEnumerable<T>> m_GetInStorageObjectCallback;

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0x0")]
			private readonly IReadOnlyList<NonTradableObjectBase> m_RegisteredElements;
		}
	}
}

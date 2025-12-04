using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI.DLC5_EllenShopPanel
{
	// Token: 0x02000F77 RID: 3959
	[Token(Token = "0x2000F77")]
	[GenerateCleanupMethod]
	public class DLC5_EllenShopPanel : UIPanel
	{
		// Token: 0x06005D18 RID: 23832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x8A5770", Offset = "0x8A4170", VA = "0x1808A5770")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> CreateGroup(GridLayoutGroup shelfField, int row, [NotNull] Func<DLC5_EllenShopPanel.ProductCondition, bool> checkEnabledFunc, [CanBeNull] Action<DLC5_EllenShopPanel.ProductCondition> afterBuyExtraCallback, [NotNull] IReadOnlyList<DLC5_EllenShopPanel.ProductCondition> targetList, [CanBeNull] Action<int, MoveDirection> onCustomLoop)
		{
			return null;
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06005D19 RID: 23833 RVA: 0x00020550 File Offset: 0x0001E750
		// (set) Token: 0x06005D1A RID: 23834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0B")]
		public bool HasBought
		{
			[Token(Token = "0x6005D19")]
			[Address(RVA = "0x4E0A50", Offset = "0x4DF450", VA = "0x1804E0A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D1A")]
			[Address(RVA = "0x4E0B80", Offset = "0x4DF580", VA = "0x1804E0B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0x8A5A20", Offset = "0x8A4420", VA = "0x1808A5A20", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1C")]
		[Address(RVA = "0x8A5FD0", Offset = "0x8A49D0", VA = "0x1808A5FD0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0x8A6850", Offset = "0x8A5250", VA = "0x1808A6850")]
		private void RefreshFund()
		{
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0x8A55B0", Offset = "0x8A3FB0", VA = "0x1808A55B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0x8A6C20", Offset = "0x8A5620", VA = "0x1808A6C20")]
		public DLC5_EllenShopPanel()
		{
		}

		// Token: 0x04005635 RID: 22069
		[Token(Token = "0x4005635")]
		[FieldOffset(Offset = "0x70")]
		[Header("永久限购")]
		[SerializeField]
		private DLC5_EllenShopPanel.ProductCondition[] m_OnePieceProducts;

		// Token: 0x04005636 RID: 22070
		[Token(Token = "0x4005636")]
		[FieldOffset(Offset = "0x78")]
		[Header("每日限购")]
		[SerializeField]
		private DLC5_EllenShopPanel.ProductCondition[] m_DailyProducts;

		// Token: 0x04005637 RID: 22071
		[Token(Token = "0x4005637")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("无限可购")]
		private DLC5_EllenShopPanel.ProductCondition[] m_NormalProducts;

		// Token: 0x04005638 RID: 22072
		[Token(Token = "0x4005638")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("每日限购刷新数量范围")]
		private Vector2Int m_DailyProductRefreshNum;

		// Token: 0x04005639 RID: 22073
		[Token(Token = "0x4005639")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x0400563A RID: 22074
		[Token(Token = "0x400563A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup m_DescriberPanel;

		// Token: 0x0400563B RID: 22075
		[Token(Token = "0x400563B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private EllenShopDescriber m_Describer;

		// Token: 0x0400563C RID: 22076
		[Token(Token = "0x400563C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GridLayoutGroup m_OnePieceShelfField;

		// Token: 0x0400563D RID: 22077
		[Token(Token = "0x400563D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GridLayoutGroup m_DailyShelfField;

		// Token: 0x0400563E RID: 22078
		[Token(Token = "0x400563E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GridLayoutGroup m_NormalShelfField;

		// Token: 0x0400563F RID: 22079
		[Token(Token = "0x400563F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject m_ObjectStackParent;

		// Token: 0x04005640 RID: 22080
		[Token(Token = "0x4005640")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI m_RemainingCandy;

		// Token: 0x04005641 RID: 22081
		[Token(Token = "0x4005641")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TextMeshProUGUI m_RemainingFund;

		// Token: 0x04005642 RID: 22082
		[Token(Token = "0x4005642")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private DLC5_EllenShopIntroductionSubPanel m_EllenShopIntroductionSubPanel;

		// Token: 0x04005643 RID: 22083
		[Token(Token = "0x4005643")]
		private const string DAILY_PRODUCTS_HAS_REFRESHED = "DailyProductHasRefreshed";

		// Token: 0x04005644 RID: 22084
		[Token(Token = "0x4005644")]
		[FieldOffset(Offset = "0xE0")]
		private List<DLC5_EllenShopPanel.ProductCondition> m_OnePieceProductsList;

		// Token: 0x04005645 RID: 22085
		[Token(Token = "0x4005645")]
		[FieldOffset(Offset = "0xE8")]
		private List<DLC5_EllenShopPanel.ProductCondition> m_DailyProductsList;

		// Token: 0x04005646 RID: 22086
		[Token(Token = "0x4005646")]
		[FieldOffset(Offset = "0xF0")]
		private List<DLC5_EllenShopPanel.ProductCondition> m_NormalProductsList;

		// Token: 0x04005647 RID: 22087
		[Token(Token = "0x4005647")]
		[FieldOffset(Offset = "0xF8")]
		private List<DLC5_EllenShopPanel.ProductCondition> m_RefreshedDailyProductsList;

		// Token: 0x04005648 RID: 22088
		[Token(Token = "0x4005648")]
		[FieldOffset(Offset = "0x100")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_OnePieceGroup;

		// Token: 0x04005649 RID: 22089
		[Token(Token = "0x4005649")]
		[FieldOffset(Offset = "0x108")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_DailyGroup;

		// Token: 0x0400564A RID: 22090
		[Token(Token = "0x400564A")]
		[FieldOffset(Offset = "0x110")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_EllenShopPanel.ProductCondition, UIElementCluster, UIButtonSimple> m_NormalGroup;

		// Token: 0x0400564C RID: 22092
		[Token(Token = "0x400564C")]
		private const int CANDY_ID = 5011;

		// Token: 0x02000F78 RID: 3960
		[Token(Token = "0x2000F78")]
		[Serializable]
		public struct ProductCondition
		{
			// Token: 0x0400564D RID: 22093
			[Token(Token = "0x400564D")]
			[FieldOffset(Offset = "0x0")]
			public DLC5_EllenShopPanel.Currency[] m_Currencies;

			// Token: 0x0400564E RID: 22094
			[Token(Token = "0x400564E")]
			[FieldOffset(Offset = "0x8")]
			public Product m_Reward;

			// Token: 0x0400564F RID: 22095
			[Token(Token = "0x400564F")]
			[FieldOffset(Offset = "0x20")]
			public bool m_ForceRefreshForDaily;
		}

		// Token: 0x02000F79 RID: 3961
		[Token(Token = "0x2000F79")]
		[Serializable]
		public struct Currency
		{
			// Token: 0x06005D23 RID: 23843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D23")]
			[Address(RVA = "0x89F0F0", Offset = "0x89DAF0", VA = "0x18089F0F0")]
			public string GetText()
			{
				return null;
			}

			// Token: 0x06005D24 RID: 23844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D24")]
			[Address(RVA = "0x89F9E0", Offset = "0x89E3E0", VA = "0x18089F9E0")]
			[CompilerGenerated]
			internal static string <GetText>g__GetTagName|4_0(Product product, int tagId)
			{
				return null;
			}

			// Token: 0x06005D25 RID: 23845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D25")]
			[Address(RVA = "0x89F780", Offset = "0x89E180", VA = "0x18089F780")]
			[CompilerGenerated]
			internal static string <GetText>g__GetMultiTagName|4_1(Product product, int[] tags)
			{
				return null;
			}

			// Token: 0x04005650 RID: 22096
			[Token(Token = "0x4005650")]
			[FieldOffset(Offset = "0x0")]
			public MissionNode.FinishCondition.ConditionType m_ProductConditionType;

			// Token: 0x04005651 RID: 22097
			[Token(Token = "0x4005651")]
			[FieldOffset(Offset = "0x8")]
			public Product m_Product;

			// Token: 0x04005652 RID: 22098
			[Token(Token = "0x4005652")]
			[FieldOffset(Offset = "0x20")]
			public int m_ConditionValue;

			// Token: 0x04005653 RID: 22099
			[Token(Token = "0x4005653")]
			[FieldOffset(Offset = "0x28")]
			public int[] m_ConditionValueArray;
		}
	}
}

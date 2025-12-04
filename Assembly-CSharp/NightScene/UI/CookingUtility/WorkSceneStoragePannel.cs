using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	[GenerateCleanupMethod]
	public class WorkSceneStoragePannel : UIPanelExtern, IExternalPanel
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x170005F0")]
		private Sellable.SellableType openType
		{
			[Token(Token = "0x6002B60")]
			[Address(RVA = "0x596840", Offset = "0x595240", VA = "0x180596840")]
			get
			{
				return Sellable.SellableType.Food;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F1")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> ActiveInStorageGroup
		{
			[Token(Token = "0x6002B61")]
			[Address(RVA = "0x5967E0", Offset = "0x5951E0", VA = "0x1805967E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x593C70", Offset = "0x592670", VA = "0x180593C70", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x593BB0", Offset = "0x5925B0", VA = "0x180593BB0", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x5955F0", Offset = "0x593FF0", VA = "0x1805955F0")]
		private void ResetFilter()
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x595130", Offset = "0x593B30", VA = "0x180595130")]
		private void OnTertiarySwtichPressed(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x5950D0", Offset = "0x593AD0", VA = "0x1805950D0")]
		private void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x595320", Offset = "0x593D20", VA = "0x180595320")]
		private void OpenFilterPanel()
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x593EF0", Offset = "0x5928F0", VA = "0x180593EF0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x595260", Offset = "0x593C60", VA = "0x180595260")]
		private void OnTrayUpDownLoop(MoveDirection direction, int index)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x595AC0", Offset = "0x5944C0", VA = "0x180595AC0")]
		private void SetParamValue(Func<int, bool> getPinnedCallback, Func<bool> getGroupCountCallback, Action<Sellable> describeObjectCallback)
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x593430", Offset = "0x591E30", VA = "0x180593430")]
		private void OnElementEnabled(KeyValuePair<Sellable, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x593840", Offset = "0x592240", VA = "0x180593840")]
		private void OnElementSelected(KeyValuePair<Sellable, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x5962C0", Offset = "0x594CC0", VA = "0x1805962C0")]
		private void UpdateFoodField()
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x595F20", Offset = "0x594920", VA = "0x180595F20")]
		private void UpdateBevField()
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x5939B0", Offset = "0x5923B0", VA = "0x1805939B0")]
		private void OnInvalidTrayElementSelect()
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x595150", Offset = "0x593B50", VA = "0x180595150")]
		private void OnTrayElementSelect(Sellable sellable)
		{
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x595680", Offset = "0x594080", VA = "0x180595680")]
		private void ReturnTrayToStorage(Sellable sellable)
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x595BF0", Offset = "0x5945F0", VA = "0x180595BF0")]
		private void TryNavigateToTrayElement([Optional] int? columnIndex)
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x595B30", Offset = "0x594530", VA = "0x180595B30")]
		private void TryNavigateToFirstStorageElement()
		{
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x593020", Offset = "0x591A20", VA = "0x180593020")]
		private void Extract(Sellable toExtract)
		{
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x593A50", Offset = "0x592450", VA = "0x180593A50", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x592D70", Offset = "0x591770", VA = "0x180592D70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x596680", Offset = "0x595080", VA = "0x180596680")]
		public WorkSceneStoragePannel()
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x5561C0", Offset = "0x554BC0", VA = "0x1805561C0", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x040027BE RID: 10174
		[Token(Token = "0x40027BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI title;

		// Token: 0x040027C0 RID: 10176
		[Token(Token = "0x40027C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AdpProgressIndicatorComponent scroller;

		// Token: 0x040027C1 RID: 10177
		[Token(Token = "0x40027C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SellableDescriber describer;

		// Token: 0x040027C2 RID: 10178
		[Token(Token = "0x40027C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public CanvasGroup describerPannel;

		// Token: 0x040027C3 RID: 10179
		[Token(Token = "0x40027C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public CanvasGroup describerSubPannel;

		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject itemParent;

		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GridLayoutGroup foodField;

		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GridLayoutGroup bevField;

		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public CanvasGroup foodCanvasField;

		// Token: 0x040027C8 RID: 10184
		[Token(Token = "0x40027C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public CanvasGroup bevCanvasField;

		// Token: 0x040027C9 RID: 10185
		[Token(Token = "0x40027C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Image contentBG;

		// Token: 0x040027CA RID: 10186
		[Token(Token = "0x40027CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Sprite foodContentBG;

		// Token: 0x040027CB RID: 10187
		[Token(Token = "0x40027CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Sprite beverageContentBG;

		// Token: 0x040027CC RID: 10188
		[Token(Token = "0x40027CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioClip open;

		// Token: 0x040027CD RID: 10189
		[Token(Token = "0x40027CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioClip close;

		// Token: 0x040027CE RID: 10190
		[Token(Token = "0x40027CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Color noTransparentColor;

		// Token: 0x040027CF RID: 10191
		[Token(Token = "0x40027CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Color highLightColor;

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public UIButtonSimple filterButton;

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public WorkSceneStoragePannel.PannelOpenContext? OpenContext;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly List<KeyValuePair<Sellable, int>> m_Beverages;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly List<IFilterConfig> m_BeveragesFilter;

		// Token: 0x040027D4 RID: 10196
		[Token(Token = "0x40027D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly List<KeyValuePair<Sellable, int>> m_Foods;

		// Token: 0x040027D5 RID: 10197
		[Token(Token = "0x40027D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private readonly List<IFilterConfig> m_FoodsFilter;

		// Token: 0x040027D6 RID: 10198
		[Token(Token = "0x40027D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool canOpenFilter;

		// Token: 0x040027D7 RID: 10199
		[Token(Token = "0x40027D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action<Sellable> describeObjectCallback;

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Func<bool> getGroupCountCallback;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Func<int, bool> getPinnedCallback;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BevsGroup;

		// Token: 0x040027DB RID: 10203
		[Token(Token = "0x40027DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Action m_CurrentSwitchAction;

		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private WorkSceneTrayPannel m_CurrentTray;

		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodsGroup;

		// Token: 0x02000729 RID: 1833
		[Token(Token = "0x2000729")]
		public readonly struct PannelOpenContext
		{
			// Token: 0x06002B7C RID: 11132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002B7C")]
			[Address(RVA = "0x5E3400", Offset = "0x5E1E00", VA = "0x1805E3400")]
			public PannelOpenContext(float setFoodAlpha, float setBevAlpha, Sellable.SellableType openType)
			{
			}

			// Token: 0x040027DE RID: 10206
			[Token(Token = "0x40027DE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly float SetFoodAlpha;

			// Token: 0x040027DF RID: 10207
			[Token(Token = "0x40027DF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly float SetBevAlpha;

			// Token: 0x040027E0 RID: 10208
			[Token(Token = "0x40027E0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly Sellable.SellableType OpenType;
		}
	}
}

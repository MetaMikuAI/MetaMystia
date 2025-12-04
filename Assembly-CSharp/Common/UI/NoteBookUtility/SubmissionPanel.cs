using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using Il2CppDummyDll;
using JetBrains.Annotations;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000ED8 RID: 3800
	[Token(Token = "0x2000ED8")]
	[GenerateCleanupMethod]
	public class SubmissionPanel : UIPanelParamOpen<SubmissionPanel.OpenContext>
	{
		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Token(Token = "0x17000C6D")]
		private int Max
		{
			[Token(Token = "0x60059D5")]
			[Address(RVA = "0x897FD0", Offset = "0x8969D0", VA = "0x180897FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D6")]
		[Address(RVA = "0x897190", Offset = "0x895B90", VA = "0x180897190", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D7")]
		[Address(RVA = "0x897630", Offset = "0x896030", VA = "0x180897630", Slot = "32")]
		protected override void OnPanelOpen(SubmissionPanel.OpenContext param)
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x896CE0", Offset = "0x8956E0", VA = "0x180896CE0")]
		private void OnElementEnabled(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0x896EB0", Offset = "0x8958B0", VA = "0x180896EB0")]
		private void OnInventoryElementSelected(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0x897700", Offset = "0x896100", VA = "0x180897700")]
		private void OnSelectedElementSelected(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x896B00", Offset = "0x895500", VA = "0x180896B00")]
		private void CheckEnterGroupSilent()
		{
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x8978E0", Offset = "0x8962E0", VA = "0x1808978E0")]
		private void TryEnterInventoryGroup(bool shouldEnterFirst = false)
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x8979B0", Offset = "0x8963B0", VA = "0x1808979B0")]
		private void TryEnterSelectedGroup(bool shouldEnterFirst = false)
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x897B70", Offset = "0x896570", VA = "0x180897B70")]
		private void UpdateElements()
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x897120", Offset = "0x895B20", VA = "0x180897120", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x8976E0", Offset = "0x8960E0", VA = "0x1808976E0")]
		private void OnSelectAll(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x896B90", Offset = "0x895590", VA = "0x180896B90", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x897EF0", Offset = "0x8968F0", VA = "0x180897EF0")]
		public SubmissionPanel()
		{
		}

		// Token: 0x04005446 RID: 21574
		[Token(Token = "0x4005446")]
		[FieldOffset(Offset = "0xB8")]
		public SellableDescriber SellableDescriber;

		// Token: 0x04005447 RID: 21575
		[Token(Token = "0x4005447")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Detail;

		// Token: 0x04005448 RID: 21576
		[Token(Token = "0x4005448")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject Null;

		// Token: 0x04005449 RID: 21577
		[Token(Token = "0x4005449")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI SubmitAmount;

		// Token: 0x0400544A RID: 21578
		[Token(Token = "0x400544A")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject ObjectStackedParent;

		// Token: 0x0400544B RID: 21579
		[Token(Token = "0x400544B")]
		[FieldOffset(Offset = "0xE0")]
		public GridLayoutGroup InventoryTransform;

		// Token: 0x0400544C RID: 21580
		[Token(Token = "0x400544C")]
		[FieldOffset(Offset = "0xE8")]
		public GridLayoutGroup SelectedTransform;

		// Token: 0x0400544D RID: 21581
		[Token(Token = "0x400544D")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<KeyValuePair<NonTradableObjectBase, int>> allInventoryInstances;

		// Token: 0x0400544E RID: 21582
		[Token(Token = "0x400544E")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<KeyValuePair<NonTradableObjectBase, int>> allSelectedInstances;

		// Token: 0x0400544F RID: 21583
		[Token(Token = "0x400544F")]
		[FieldOffset(Offset = "0x100")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple> m_InventoryGroup;

		// Token: 0x04005450 RID: 21584
		[Token(Token = "0x4005450")]
		[FieldOffset(Offset = "0x108")]
		private Action m_SelectAllAction;

		// Token: 0x04005451 RID: 21585
		[Token(Token = "0x4005451")]
		[FieldOffset(Offset = "0x110")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple> m_SelectedGroup;

		// Token: 0x02000ED9 RID: 3801
		[Token(Token = "0x2000ED9")]
		public struct OpenContext
		{
			// Token: 0x060059E4 RID: 23012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60059E4")]
			[Address(RVA = "0x8942D0", Offset = "0x892CD0", VA = "0x1808942D0")]
			public OpenContext([NotNull] Action<SellableDescriber, NonTradableObjectBase> onDescribeObjectCallback, [NotNull] Func<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>> getElementCallback, [NotNull] Action<IEnumerable<int>, bool> storageInCallback, [NotNull] Action<int, bool> storageOutCallback, [NotNull] Func<int, NonTradableObjectBase> idToObjectCallback, [NotNull] Func<int, int> getObjectAmountCallback, [NotNull] IList<int> selectedObjects, [CanBeNull] Action updateExternalVisualHandle, int max)
			{
			}

			// Token: 0x04005452 RID: 21586
			[Token(Token = "0x4005452")]
			[FieldOffset(Offset = "0x0")]
			public readonly Action<SellableDescriber, NonTradableObjectBase> OnDescribeObjectCallback;

			// Token: 0x04005453 RID: 21587
			[Token(Token = "0x4005453")]
			[FieldOffset(Offset = "0x8")]
			public readonly Func<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>> GetElementCallback;

			// Token: 0x04005454 RID: 21588
			[Token(Token = "0x4005454")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action<IEnumerable<int>, bool> StorageInCallback;

			// Token: 0x04005455 RID: 21589
			[Token(Token = "0x4005455")]
			[FieldOffset(Offset = "0x18")]
			public readonly Action<int, bool> StorageOutCallback;

			// Token: 0x04005456 RID: 21590
			[Token(Token = "0x4005456")]
			[FieldOffset(Offset = "0x20")]
			public readonly Func<int, NonTradableObjectBase> IdToObjectCallback;

			// Token: 0x04005457 RID: 21591
			[Token(Token = "0x4005457")]
			[FieldOffset(Offset = "0x28")]
			public readonly Func<int, int> GetObjectAmountCallback;

			// Token: 0x04005458 RID: 21592
			[Token(Token = "0x4005458")]
			[FieldOffset(Offset = "0x30")]
			public readonly IList<int> SelectedObjects;

			// Token: 0x04005459 RID: 21593
			[Token(Token = "0x4005459")]
			[FieldOffset(Offset = "0x38")]
			public readonly Action UpdateExternalVisualHandle;

			// Token: 0x0400545A RID: 21594
			[Token(Token = "0x400545A")]
			[FieldOffset(Offset = "0x40")]
			public readonly int Max;
		}
	}
}

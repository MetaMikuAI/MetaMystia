using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;

namespace Common.UI.Filter
{
	// Token: 0x02000EFC RID: 3836
	[Token(Token = "0x2000EFC")]
	[GenerateCleanupMethod]
	public class FlattenedFilterPanel : UIPanelParamOpen<FilterParam>
	{
		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x889960", Offset = "0x888360", VA = "0x180889960", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x889A10", Offset = "0x888410", VA = "0x180889A10", Slot = "32")]
		protected override void OnPanelOpen(FilterParam openParam)
		{
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x8897D0", Offset = "0x8881D0", VA = "0x1808897D0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x889560", Offset = "0x887F60", VA = "0x180889560")]
		private FlattenedFilterPanel.IFilterUIController CreateFilterUIController([NotNull] IFilterConfigFactory factory, [CanBeNull] IFilterConfig filterConfig)
		{
			return null;
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x8896F0", Offset = "0x8880F0", VA = "0x1808896F0")]
		private static UIElementCluster GetInstanceAndRecordUsage(IObjectPool<UIElementCluster> pool, Stack<UIElementCluster> occupiedTracker)
		{
			return null;
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x88A070", Offset = "0x888A70", VA = "0x18088A070")]
		private static void ReleaseInstance(IObjectPool<UIElementCluster> pool, Stack<UIElementCluster> occupiedTracker)
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x889430", Offset = "0x887E30", VA = "0x180889430", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x88A510", Offset = "0x888F10", VA = "0x18088A510")]
		public FlattenedFilterPanel()
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x88A1A0", Offset = "0x888BA0", VA = "0x18088A1A0")]
		[CompilerGenerated]
		internal static ObjectPool<UIElementCluster> <OnPanelInitialize>g__CreatePool|13_0(UIElementCluster module, Transform field)
		{
			return null;
		}

		// Token: 0x0400548C RID: 21644
		[Token(Token = "0x400548C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIElementCluster m_Button;

		// Token: 0x0400548D RID: 21645
		[Token(Token = "0x400548D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIElementCluster m_SingleChoiceModule;

		// Token: 0x0400548E RID: 21646
		[Token(Token = "0x400548E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIElementCluster m_MultipleChoiceModule;

		// Token: 0x0400548F RID: 21647
		[Token(Token = "0x400548F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform m_SingleChoiceModuleField;

		// Token: 0x04005490 RID: 21648
		[Token(Token = "0x4005490")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform m_MultipleChoiceModuleField;

		// Token: 0x04005491 RID: 21649
		[Token(Token = "0x4005491")]
		[FieldOffset(Offset = "0xA8")]
		private readonly Queue<FlattenedFilterPanel.IFilterUIController> m_FilterUIControllers;

		// Token: 0x04005492 RID: 21650
		[Token(Token = "0x4005492")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Stack<UIElementCluster> m_UsedMultipleChoiceModule;

		// Token: 0x04005493 RID: 21651
		[Token(Token = "0x4005493")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Stack<UIElementCluster> m_UsedSingleChoiceModule;

		// Token: 0x04005494 RID: 21652
		[Token(Token = "0x4005494")]
		[FieldOffset(Offset = "0xC0")]
		private ObjectPool<UIElementCluster> m_MultipleChoiceModulePool;

		// Token: 0x04005495 RID: 21653
		[Token(Token = "0x4005495")]
		[FieldOffset(Offset = "0xC8")]
		private ObjectPool<UIElementCluster> m_SingleChoiceModulePool;

		// Token: 0x02000EFD RID: 3837
		[Token(Token = "0x2000EFD")]
		private interface IFilterUIController
		{
			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06005A75 RID: 23157
			[Token(Token = "0x17000C8F")]
			uint SelectionPriorityWeight
			{
				[Token(Token = "0x6005A75")]
				get;
			}

			// Token: 0x06005A76 RID: 23158
			[Token(Token = "0x6005A76")]
			void Init();

			// Token: 0x06005A77 RID: 23159
			[Token(Token = "0x6005A77")]
			void Select();

			// Token: 0x06005A78 RID: 23160
			[Token(Token = "0x6005A78")]
			IFilterConfig Release();
		}

		// Token: 0x02000EFE RID: 3838
		[Token(Token = "0x2000EFE")]
		private class MultipleChoiceFilterUIController : FlattenedFilterPanel.IFilterUIController
		{
			// Token: 0x06005A79 RID: 23161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A79")]
			[Address(RVA = "0x88C4C0", Offset = "0x88AEC0", VA = "0x18088C4C0")]
			public MultipleChoiceFilterUIController([NotNull] UIElementCluster buttonPrefab, [NotNull] UIElementCluster moduleInstance, [CanBeNull] IFilterConfig filterConfig, [NotNull] IFilterConfigFactory filterConfigFactory)
			{
			}

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06005A7A RID: 23162 RVA: 0x0001FB60 File Offset: 0x0001DD60
			[Token(Token = "0x17000C90")]
			public uint SelectionPriorityWeight
			{
				[Token(Token = "0x6005A7A")]
				[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06005A7B RID: 23163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A7B")]
			[Address(RVA = "0x88C030", Offset = "0x88AA30", VA = "0x18088C030", Slot = "6")]
			public void Select()
			{
			}

			// Token: 0x06005A7C RID: 23164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A7C")]
			[Address(RVA = "0x88BDF0", Offset = "0x88A7F0", VA = "0x18088BDF0", Slot = "7")]
			public IFilterConfig Release()
			{
				return null;
			}

			// Token: 0x06005A7D RID: 23165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A7D")]
			[Address(RVA = "0x88BDA0", Offset = "0x88A7A0", VA = "0x18088BDA0", Slot = "5")]
			public void Init()
			{
			}

			// Token: 0x04005496 RID: 21654
			[Token(Token = "0x4005496")]
			[FieldOffset(Offset = "0x10")]
			private readonly IFilterConfigFactory m_FilterConfigFactory;

			// Token: 0x04005497 RID: 21655
			[Token(Token = "0x4005497")]
			[FieldOffset(Offset = "0x18")]
			private readonly StaticVerticalGridScrollListUILogicalGroupT<object, UIElementCluster, UIButtonToggle> m_LogicalGroup;

			// Token: 0x04005498 RID: 21656
			[Token(Token = "0x4005498")]
			[FieldOffset(Offset = "0x20")]
			private readonly List<object> m_SelectedList;

			// Token: 0x04005499 RID: 21657
			[Token(Token = "0x4005499")]
			[FieldOffset(Offset = "0x28")]
			private readonly List<object> m_SelectionList;
		}

		// Token: 0x02000F01 RID: 3841
		[Token(Token = "0x2000F01")]
		private class SingleChoiceFilterUIController : FlattenedFilterPanel.IFilterUIController
		{
			// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A87")]
			[Address(RVA = "0x896080", Offset = "0x894A80", VA = "0x180896080")]
			public SingleChoiceFilterUIController([NotNull] UIElementCluster buttonPrefab, [NotNull] UIElementCluster moduleInstance, [CanBeNull] IFilterConfig filterConfig, [NotNull] IFilterConfigFactory filterConfigFactory)
			{
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06005A88 RID: 23176 RVA: 0x0001FB78 File Offset: 0x0001DD78
			[Token(Token = "0x17000C91")]
			public uint SelectionPriorityWeight
			{
				[Token(Token = "0x6005A88")]
				[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06005A89 RID: 23177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A89")]
			[Address(RVA = "0x895A20", Offset = "0x894420", VA = "0x180895A20", Slot = "5")]
			public void Init()
			{
			}

			// Token: 0x06005A8A RID: 23178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A8A")]
			[Address(RVA = "0x895BC0", Offset = "0x8945C0", VA = "0x180895BC0", Slot = "6")]
			public void Select()
			{
			}

			// Token: 0x06005A8B RID: 23179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A8B")]
			[Address(RVA = "0x895A70", Offset = "0x894470", VA = "0x180895A70", Slot = "7")]
			public IFilterConfig Release()
			{
				return null;
			}

			// Token: 0x06005A8C RID: 23180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A8C")]
			[Address(RVA = "0x895EB0", Offset = "0x8948B0", VA = "0x180895EB0")]
			private void UpdateElementsImpl()
			{
			}

			// Token: 0x0400549F RID: 21663
			[Token(Token = "0x400549F")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<GameObject> m_AllElements;

			// Token: 0x040054A0 RID: 21664
			[Token(Token = "0x40054A0")]
			[FieldOffset(Offset = "0x18")]
			[NotNull]
			private readonly UIElementCluster m_Button;

			// Token: 0x040054A1 RID: 21665
			[Token(Token = "0x40054A1")]
			[FieldOffset(Offset = "0x20")]
			[NotNull]
			private readonly RectTransform m_Field;

			// Token: 0x040054A2 RID: 21666
			[Token(Token = "0x40054A2")]
			[FieldOffset(Offset = "0x28")]
			[NotNull]
			private readonly IFilterConfigFactory m_FilterConfigFactory;

			// Token: 0x040054A3 RID: 21667
			[Token(Token = "0x40054A3")]
			[FieldOffset(Offset = "0x30")]
			private readonly UILogicalGroup m_LogicalGroup;

			// Token: 0x040054A4 RID: 21668
			[Token(Token = "0x40054A4")]
			[FieldOffset(Offset = "0x38")]
			private object m_CurrentSelection;
		}
	}
}

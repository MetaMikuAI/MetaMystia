using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x02000F84 RID: 3972
	[Token(Token = "0x2000F84")]
	[GenerateCleanupMethod]
	public class DLC5_CreatorsBoxPanel : UIPanelParam<DLC5_CreatorsBoxPanel.OpenContext, DLC5_CreatorsBoxPanel.OpenContext>
	{
		// Token: 0x06005D55 RID: 23893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x8A0BB0", Offset = "0x89F5B0", VA = "0x1808A0BB0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x89FA90", Offset = "0x89E490", VA = "0x18089FA90")]
		private void AddExtraTime()
		{
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x8A1C20", Offset = "0x8A0620", VA = "0x1808A1C20")]
		private void TrimExtraTime()
		{
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D58")]
		[Address(RVA = "0x8A18A0", Offset = "0x8A02A0", VA = "0x1808A18A0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_CreatorsBoxPanel.OpenContext openContext)
		{
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x8A00F0", Offset = "0x89EAF0", VA = "0x1808A00F0")]
		private void MountDataAndRefreshView(CreatorBoxData creatorBoxData)
		{
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x8A1AF0", Offset = "0x8A04F0", VA = "0x1808A1AF0")]
		private void SortSpecialGuestList()
		{
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x000205E0 File Offset: 0x0001E7E0
		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x8A38C0", Offset = "0x8A22C0", VA = "0x1808A38C0")]
		private ValueTuple<int, DLC5_CreatorsBoxPanel.Cell> UpdateView()
		{
			return default(ValueTuple<int, DLC5_CreatorsBoxPanel.Cell>);
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x000205F8 File Offset: 0x0001E7F8
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x89FDE0", Offset = "0x89E7E0", VA = "0x18089FDE0")]
		private CreatorBoxData CreateReturnValue()
		{
			return default(CreatorBoxData);
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x8A0A30", Offset = "0x89F430", VA = "0x1808A0A30", Slot = "33")]
		protected override void OnPanelClose(DLC5_CreatorsBoxPanel.OpenContext closeParam)
		{
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x8A3450", Offset = "0x8A1E50", VA = "0x1808A3450")]
		private void UpdateAddTimeButton(UIButtonBase currentButton)
		{
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00020610 File Offset: 0x0001E810
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x8A37C0", Offset = "0x8A21C0", VA = "0x1808A37C0")]
		private ValueTuple<bool, bool, bool> UpdateScaleButton()
		{
			return default(ValueTuple<bool, bool, bool>);
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x8A3660", Offset = "0x8A2060", VA = "0x1808A3660")]
		private void UpdateLoadButton()
		{
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x8A19A0", Offset = "0x8A03A0", VA = "0x1808A19A0")]
		private void ProcessScaleButtonReselection(UIButtonBase currentButton, bool canScaleMore, bool canScaleLess, bool canScaleReset)
		{
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x89FB70", Offset = "0x89E570", VA = "0x18089FB70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x8A3BE0", Offset = "0x8A25E0", VA = "0x1808A3BE0")]
		public DLC5_CreatorsBoxPanel()
		{
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0x8A3220", Offset = "0x8A1C20", VA = "0x1808A3220")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__SetupVisual|36_24(DLC5_CreatorsBoxPanel.Cell cell, CreatorsBoxTimelineElement element, UIButtonSimple _)
		{
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0x8A30E0", Offset = "0x8A1AE0", VA = "0x1808A30E0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__SetUpCallback|36_25(DLC5_CreatorsBoxPanel.Cell cell, UIButtonSimple btn)
		{
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D7F")]
		[Address(RVA = "0x8A32D0", Offset = "0x8A1CD0", VA = "0x1808A32D0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__UpdateInbetween|36_26(AdpUISystemUtils.BorderElementType type, int column, int row, ValueTuple<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple>? value)
		{
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D80")]
		[Address(RVA = "0x8A2B70", Offset = "0x8A1570", VA = "0x1808A2B70")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__ScaleMore|36_27(UIButtonBase button)
		{
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D81")]
		[Address(RVA = "0x8A29D0", Offset = "0x8A13D0", VA = "0x1808A29D0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__ScaleLess|36_28(UIButtonBase button)
		{
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D82")]
		[Address(RVA = "0x8A2D20", Offset = "0x8A1720", VA = "0x1808A2D20")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__ScaleReset|36_29(UIButtonBase button)
		{
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D83")]
		[Address(RVA = "0x8A3270", Offset = "0x8A1C70", VA = "0x1808A3270")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__SyncView|36_30()
		{
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D84")]
		[Address(RVA = "0x8A2EB0", Offset = "0x8A18B0", VA = "0x1808A2EB0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__SelectCenter|36_31(DLC5_CreatorsBoxPanel.FocusingType focusingType, int bestViewIndex, DLC5_CreatorsBoxPanel.Cell bestListCell)
		{
		}

		// Token: 0x04005681 RID: 22145
		[Token(Token = "0x4005681")]
		private const int m_RoundTotalTime = 240;

		// Token: 0x04005682 RID: 22146
		[Token(Token = "0x4005682")]
		private const int m_SkipMax = 30;

		// Token: 0x04005683 RID: 22147
		[Token(Token = "0x4005683")]
		private const int m_SkipDefault = 5;

		// Token: 0x04005684 RID: 22148
		[Token(Token = "0x4005684")]
		private const int m_SkipMin = 1;

		// Token: 0x04005685 RID: 22149
		[Token(Token = "0x4005685")]
		private const int m_SkipStep = 5;

		// Token: 0x04005686 RID: 22150
		[Token(Token = "0x4005686")]
		private const int m_FastForwardAmount = 5;

		// Token: 0x04005687 RID: 22151
		[Token(Token = "0x4005687")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CreatorsBoxTimelineElement m_Element;

		// Token: 0x04005688 RID: 22152
		[Token(Token = "0x4005688")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CreatorsBoxTimelineElement m_SecondaryElement;

		// Token: 0x04005689 RID: 22153
		[Token(Token = "0x4005689")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CreatorsBoxTimelineInBetweenElement[] m_InBetweenElement;

		// Token: 0x0400568A RID: 22154
		[Token(Token = "0x400568A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GridLayoutGroup m_Grid;

		// Token: 0x0400568B RID: 22155
		[Token(Token = "0x400568B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GridLayoutGroup m_SecondaryGrid;

		// Token: 0x0400568C RID: 22156
		[Token(Token = "0x400568C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_ProgressIndicatorComponent;

		// Token: 0x0400568D RID: 22157
		[Token(Token = "0x400568D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_SecondaryProgressIndicatorComponent;

		// Token: 0x0400568E RID: 22158
		[Token(Token = "0x400568E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIButtonSimple m_AddExtraTimeBtn;

		// Token: 0x0400568F RID: 22159
		[Token(Token = "0x400568F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIButtonSimple m_RemoveExtraTimeBtn;

		// Token: 0x04005690 RID: 22160
		[Token(Token = "0x4005690")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonSimple m_TrimExtraTimeBtn;

		// Token: 0x04005691 RID: 22161
		[Token(Token = "0x4005691")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIButtonSimple m_ScaleMoreBtn;

		// Token: 0x04005692 RID: 22162
		[Token(Token = "0x4005692")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIButtonSimple m_ScaleLessBtn;

		// Token: 0x04005693 RID: 22163
		[Token(Token = "0x4005693")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIButtonSimple m_ScaleResetBtn;

		// Token: 0x04005694 RID: 22164
		[Token(Token = "0x4005694")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIButtonHold m_ResetAllBtn;

		// Token: 0x04005695 RID: 22165
		[Token(Token = "0x4005695")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIButtonSimple m_LoadPresetBtn;

		// Token: 0x04005696 RID: 22166
		[Token(Token = "0x4005696")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButtonSimple m_SavePresetBtn;

		// Token: 0x04005697 RID: 22167
		[Token(Token = "0x4005697")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIButtonHold m_ExitButton;

		// Token: 0x04005698 RID: 22168
		[Token(Token = "0x4005698")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DLC5_SpecialGuestSelectionPanel m_SpecialGuestSelectionPanel;

		// Token: 0x04005699 RID: 22169
		[Token(Token = "0x4005699")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private DLC5_PresetSelectionPanel m_PresetPanel;

		// Token: 0x0400569A RID: 22170
		[Token(Token = "0x400569A")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<DLC5_CreatorsBoxPanel.Cell> m_CurrentList;

		// Token: 0x0400569B RID: 22171
		[Token(Token = "0x400569B")]
		[FieldOffset(Offset = "0x130")]
		private readonly List<DLC5_CreatorsBoxPanel.Cell> m_CurrentView;

		// Token: 0x0400569C RID: 22172
		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<SpecialGuest> m_AvailableSpecialGuests;

		// Token: 0x0400569D RID: 22173
		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x140")]
		private readonly ObjectPool<DLC5_CreatorsBoxPanel.Cell> m_Pool;

		// Token: 0x0400569E RID: 22174
		[Token(Token = "0x400569E")]
		[FieldOffset(Offset = "0x148")]
		private StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple> m_LogicalGroupT;

		// Token: 0x0400569F RID: 22175
		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x150")]
		private StaticHorizontalGridScrollListUILogicalGroupT<DLC5_CreatorsBoxPanel.Cell, CreatorsBoxTimelineElement, UIButtonSimple> m_SecondaryLogicalGroupT;

		// Token: 0x040056A0 RID: 22176
		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x158")]
		private int m_SkipAmount;

		// Token: 0x040056A1 RID: 22177
		[Token(Token = "0x40056A1")]
		[FieldOffset(Offset = "0x160")]
		private DLC5_CreatorsBoxPanel.Cell m_CurrentSelectedCell;

		// Token: 0x040056A2 RID: 22178
		[Token(Token = "0x40056A2")]
		[FieldOffset(Offset = "0x168")]
		private DLC5_CreatorsBoxPanel.FocusingType m_FocusingType;

		// Token: 0x02000F85 RID: 3973
		[Token(Token = "0x2000F85")]
		public readonly struct OpenContext
		{
			// Token: 0x06005D85 RID: 23941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D85")]
			[Address(RVA = "0x8AFF90", Offset = "0x8AE990", VA = "0x1808AFF90")]
			public OpenContext(CreatorBoxData creatorBoxData, CreatorBoxData?[] creatorBoxDataPresets)
			{
			}

			// Token: 0x040056A3 RID: 22179
			[Token(Token = "0x40056A3")]
			[FieldOffset(Offset = "0x0")]
			public readonly CreatorBoxData CreatorBoxData;

			// Token: 0x040056A4 RID: 22180
			[Token(Token = "0x40056A4")]
			[FieldOffset(Offset = "0x8")]
			public readonly CreatorBoxData?[] CreatorBoxDataPresets;
		}

		// Token: 0x02000F86 RID: 3974
		[Token(Token = "0x2000F86")]
		private enum FocusingType
		{
			// Token: 0x040056A6 RID: 22182
			[Token(Token = "0x40056A6")]
			None,
			// Token: 0x040056A7 RID: 22183
			[Token(Token = "0x40056A7")]
			View,
			// Token: 0x040056A8 RID: 22184
			[Token(Token = "0x40056A8")]
			List
		}

		// Token: 0x02000F87 RID: 3975
		[Token(Token = "0x2000F87")]
		private class Cell
		{
			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x06005D86 RID: 23942 RVA: 0x00020658 File Offset: 0x0001E858
			// (set) Token: 0x06005D87 RID: 23943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D0C")]
			public int TimeStamp
			{
				[Token(Token = "0x6005D86")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005D87")]
				[Address(RVA = "0x403870", Offset = "0x402270", VA = "0x180403870")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x06005D88 RID: 23944 RVA: 0x00020670 File Offset: 0x0001E870
			// (set) Token: 0x06005D89 RID: 23945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D0D")]
			public bool IsLast
			{
				[Token(Token = "0x6005D88")]
				[Address(RVA = "0x653EC0", Offset = "0x6528C0", VA = "0x180653EC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005D89")]
				[Address(RVA = "0x89E720", Offset = "0x89D120", VA = "0x18089E720")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x06005D8A RID: 23946 RVA: 0x00020688 File Offset: 0x0001E888
			// (set) Token: 0x06005D8B RID: 23947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D0E")]
			public bool IsExtra
			{
				[Token(Token = "0x6005D8A")]
				[Address(RVA = "0x653ED0", Offset = "0x6528D0", VA = "0x180653ED0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005D8B")]
				[Address(RVA = "0x89E710", Offset = "0x89D110", VA = "0x18089E710")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06005D8C RID: 23948 RVA: 0x000206A0 File Offset: 0x0001E8A0
			// (set) Token: 0x06005D8D RID: 23949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D0F")]
			public bool NextIsExtra
			{
				[Token(Token = "0x6005D8C")]
				[Address(RVA = "0x89E700", Offset = "0x89D100", VA = "0x18089E700")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005D8D")]
				[Address(RVA = "0x89E730", Offset = "0x89D130", VA = "0x18089E730")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x06005D8E RID: 23950 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005D8F RID: 23951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D10")]
			public SpecialGuest SelectedSpecialGuest
			{
				[Token(Token = "0x6005D8E")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005D8F")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06005D90 RID: 23952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D90")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public Cell()
			{
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	[GenerateCleanupMethod]
	public class DLC4_BossBattlePatchouliSpellPanel : UIPanelExtern
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00005688 File Offset: 0x00003888
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000152")]
		public DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext OpenContext
		{
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x8E4DA0", Offset = "0x8E37A0", VA = "0x1808E4DA0")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext);
			}
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x8E4DE0", Offset = "0x8E37E0", VA = "0x1808E4DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x000056A0 File Offset: 0x000038A0
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000153")]
		public DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext InitializeContext
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x8E4D70", Offset = "0x8E3770", VA = "0x1808E4D70")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext);
			}
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x8E4DB0", Offset = "0x8E37B0", VA = "0x1808E4DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x8E4020", Offset = "0x8E2A20", VA = "0x1808E4020", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x8E48D0", Offset = "0x8E32D0", VA = "0x1808E48D0")]
		private bool ShouldEnableSpellElement(PatchouliMagicSpellCardIndex arg)
		{
			return default(bool);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x8E3F70", Offset = "0x8E2970", VA = "0x1808E3F70")]
		private void Hide(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x8E4270", Offset = "0x8E2C70", VA = "0x1808E4270", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x8E4840", Offset = "0x8E3240", VA = "0x1808E4840")]
		private void Refresh(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x8E47F0", Offset = "0x8E31F0", VA = "0x1808E47F0")]
		private void RefreshFunc()
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x8E4900", Offset = "0x8E3300", VA = "0x1808E4900")]
		private void UpdateVisual(HashSet<PatchouliMagicSpellCardIndex> cards)
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x8E4320", Offset = "0x8E2D20", VA = "0x1808E4320")]
		private void ProcessElements(UIElementCluster uiElement, PatchouliMagicSpellCardIndex card)
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x8E3FA0", Offset = "0x8E29A0", VA = "0x1808E3FA0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x8E3E80", Offset = "0x8E2880", VA = "0x1808E3E80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x8E4CE0", Offset = "0x8E36E0", VA = "0x1808E4CE0")]
		public DLC4_BossBattlePatchouliSpellPanel()
		{
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject m_ItemStack;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform m_ContainerParent;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_RemainingP;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform m_RemainingPanelRect;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup m_ParentCanvas;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonSimple m_RefreshButton;

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_RefreshText;

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup m_RefreshCanvasGroup;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0xB0")]
		private float coolDown;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0xB4")]
		private bool isHide;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0xB8")]
		private List<GameObject> m_AllInstances;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0xC0")]
		private UILogicalGroupT<PatchouliMagicSpellCardIndex> m_UILogicalGroup;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0xC8")]
		private int remainingPPoint;

		// Token: 0x02000203 RID: 515
		[Token(Token = "0x2000203")]
		public struct DLC4BossBattlePatchouliSpellContext
		{
			// Token: 0x06000C46 RID: 3142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x8E3D40", Offset = "0x8E2740", VA = "0x1808E3D40")]
			public DLC4BossBattlePatchouliSpellContext(HashSet<PatchouliMagicSpellCardIndex> enableIdledSpellCardsIndex, float remainingCoolTime, bool canRefresh)
			{
			}

			// Token: 0x04000AE3 RID: 2787
			[Token(Token = "0x4000AE3")]
			[FieldOffset(Offset = "0x0")]
			public readonly HashSet<PatchouliMagicSpellCardIndex> EnableIdledSpellCardsIndex;

			// Token: 0x04000AE4 RID: 2788
			[Token(Token = "0x4000AE4")]
			[FieldOffset(Offset = "0x8")]
			public readonly float RemainingCoolTime;

			// Token: 0x04000AE5 RID: 2789
			[Token(Token = "0x4000AE5")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool CanRefresh;
		}

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		public struct DLC4BossBattlePatchouliSpellInitializeContext
		{
			// Token: 0x06000C47 RID: 3143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x8E3D80", Offset = "0x8E2780", VA = "0x1808E3D80")]
			public DLC4BossBattlePatchouliSpellInitializeContext(Func<PatchouliMagicSpellCardIndex, LanguageBase> getSpellText, float coolDown, int cost, Action<int, PatchouliMagicSpellCardIndex> onBuyCallback, Func<PatchouliMagicSpellCardIndex, string, string> replaceDescriptionMethod, Func<HashSet<PatchouliMagicSpellCardIndex>> onRefreshCallback, Func<int> currentPPoint)
			{
			}

			// Token: 0x04000AE6 RID: 2790
			[Token(Token = "0x4000AE6")]
			[FieldOffset(Offset = "0x0")]
			public readonly Func<PatchouliMagicSpellCardIndex, LanguageBase> GetSpellText;

			// Token: 0x04000AE7 RID: 2791
			[Token(Token = "0x4000AE7")]
			[FieldOffset(Offset = "0x8")]
			public readonly float CoolDown;

			// Token: 0x04000AE8 RID: 2792
			[Token(Token = "0x4000AE8")]
			[FieldOffset(Offset = "0xC")]
			public readonly int Cost;

			// Token: 0x04000AE9 RID: 2793
			[Token(Token = "0x4000AE9")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action<int, PatchouliMagicSpellCardIndex> OnBuyCallback;

			// Token: 0x04000AEA RID: 2794
			[Token(Token = "0x4000AEA")]
			[FieldOffset(Offset = "0x18")]
			public readonly Func<PatchouliMagicSpellCardIndex, string, string> ReplaceDescriptionMethod;

			// Token: 0x04000AEB RID: 2795
			[Token(Token = "0x4000AEB")]
			[FieldOffset(Offset = "0x20")]
			public readonly Func<HashSet<PatchouliMagicSpellCardIndex>> OnRefreshCallback;

			// Token: 0x04000AEC RID: 2796
			[Token(Token = "0x4000AEC")]
			[FieldOffset(Offset = "0x28")]
			public readonly Func<int> CurrentPPoint;
		}
	}
}

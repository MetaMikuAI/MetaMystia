using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	[GenerateCleanupMethod]
	public class DLC4_ChallengeCardSelectorPanel : UIPanelParamExternOpen<IChallengeCardSelectorPanelDB>
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x8E7720", Offset = "0x8E6120", VA = "0x1808E7720", Slot = "32")]
		protected override void OnPanelOpen(IChallengeCardSelectorPanelDB openParam)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x8E7640", Offset = "0x8E6040", VA = "0x1808E7640", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x8E6CA0", Offset = "0x8E56A0", VA = "0x1808E6CA0")]
		private Vector3 GetTopLeftWorldCorner(RectTransform rectTransform)
		{
			return default(Vector3);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x8E7770", Offset = "0x8E6170", VA = "0x1808E7770")]
		private void RefreshElements(GroupedUILogicalGroup.EnterGroupType enterGroupType, bool resetAnimator)
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x8E6D10", Offset = "0x8E5710", VA = "0x1808E6D10")]
		private void InitializeCanUse(UIButtonSimple uiButton, UIElementCluster uiElementCluster, GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x8E7110", Offset = "0x8E5B10", VA = "0x1808E7110")]
		private void InitializeInShopLoading(UIButtonSimple uiButton, UIElementCluster uiElementCluster, in GuestGuardMapping mapping, bool isNoMoneySkin, float progress)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x8E6F00", Offset = "0x8E5900", VA = "0x1808E6F00")]
		private void InitializeInShopCanBuy(UIButtonSimple uiButton, UIElementCluster uiElementCluster, GuestGuardMapping mapping, bool isNoMoneySkin)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x8E7350", Offset = "0x8E5D50", VA = "0x1808E7350")]
		private void InitializeInShopOnField(UIButtonSimple uiButton, UIElementCluster uiElementCluster, in GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x8E7230", Offset = "0x8E5C30", VA = "0x1808E7230")]
		private void InitializeInShopOnFieldLoading(UIButtonSimple uiButton, UIElementCluster uiElementCluster, in GuestGuardMapping mapping, float progress)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x8E6950", Offset = "0x8E5350", VA = "0x1808E6950")]
		private void DescribeGuest(RectTransform rectTransform, in GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x8E7AC0", Offset = "0x8E64C0", VA = "0x1808E7AC0")]
		private void SetBGUI(UIElementCluster uiElementCluster, in GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x8E7460", Offset = "0x8E5E60", VA = "0x1808E7460")]
		private static void InitializeUIElements(UIElementCluster uiElementCluster, GuestGuardMapping mapping, bool showPrice, bool isNoMoneySkin, float progress, bool enableCurtain, bool enableCheckMark, Sprite outline)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x8E7C60", Offset = "0x8E6660", VA = "0x1808E7C60")]
		private static void SetPriceUI(UIElementCluster uiElementCluster, in GuestGuardMapping mapping, bool enable, bool isNoMoneySkin)
		{
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x8E7E70", Offset = "0x8E6870", VA = "0x1808E7E70")]
		private static void SetProgressUI(UIElementCluster uiElementCluster, float progress, bool enableCurtain)
		{
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x8E7B60", Offset = "0x8E6560", VA = "0x1808E7B60")]
		private static void SetCheckUI(UIElementCluster uiElementCluster, bool enable)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x8E7BE0", Offset = "0x8E65E0", VA = "0x1808E7BE0")]
		private static void SetOutlineUI(UIElementCluster uiElementCluster, Sprite outline)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x8E6850", Offset = "0x8E5250", VA = "0x1808E6850", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x8E7FE0", Offset = "0x8E69E0", VA = "0x1808E7FE0")]
		public DLC4_ChallengeCardSelectorPanel()
		{
		}

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_Focus;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform m_CardField;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIElementCluster m_CardPrefab;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Sprite m_NormalBG;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Sprite m_SpecialBG;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Sprite m_NormalOutline;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Sprite m_InvalidOutline;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color32 m_NormalTextColor;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Color32 m_SpecialTextColor;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private DLC4_ChallengeCardSelectorPanel_Describer m_Describer;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform m_DescriberRectTransform;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0xC0")]
		private readonly List<GameObject> m_GameObjects;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0xC8")]
		private readonly UILogicalGroupT<GuestGuardMapping> m_LogicalGroupT;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Vector3[] m_WorldCornerBuffer;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_CurrentDescriberStatus;
	}
}

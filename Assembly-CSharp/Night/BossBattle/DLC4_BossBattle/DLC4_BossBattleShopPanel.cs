using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	[GenerateCleanupMethod]
	public class DLC4_BossBattleShopPanel : UIPanelExtern
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000056D0 File Offset: 0x000038D0
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000154")]
		public DLC4_BossBattleShopPanel.DLC4BossBattleShopContext OpenContext
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x8E67F0", Offset = "0x8E51F0", VA = "0x1808E67F0")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext);
			}
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x8E6820", Offset = "0x8E5220", VA = "0x1808E6820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000155")]
		public List<GuestGuardMapping> SelectedGuard
		{
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x4E0700", Offset = "0x4DF100", VA = "0x1804E0700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x4E0B20", Offset = "0x4DF520", VA = "0x1804E0B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x8E5C10", Offset = "0x8E4610", VA = "0x1808E5C10", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x8E4E00", Offset = "0x8E3800", VA = "0x1808E4E00")]
		private void Buy()
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x8E54A0", Offset = "0x8E3EA0", VA = "0x1808E54A0")]
		private void Hide(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x8E5DA0", Offset = "0x8E47A0", VA = "0x1808E5DA0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x8E54D0", Offset = "0x8E3ED0", VA = "0x1808E54D0")]
		private void OnElementEnabled(GuestGuardMapping guard, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x8E5910", Offset = "0x8E4310", VA = "0x1808E5910")]
		private void OnElementSelected(GuestGuardMapping guard, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x8E4FF0", Offset = "0x8E39F0", VA = "0x1808E4FF0")]
		private void DrawItems()
		{
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x8E64C0", Offset = "0x8E4EC0", VA = "0x1808E64C0")]
		private void ProcessCartElements(UIElementCluster uiElement, GuestGuardMapping guard)
		{
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x8E5B30", Offset = "0x8E4530", VA = "0x1808E5B30", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x8E4E30", Offset = "0x8E3830", VA = "0x1808E4E30", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x8E6710", Offset = "0x8E5110", VA = "0x1808E6710")]
		public DLC4_BossBattleShopPanel()
		{
		}

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI m_WholeFund;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI m_RemainingFund;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_ManualText;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI m_HPText;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI m_CoolDownText;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_PCostText;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonSimple m_ConfirmBuy;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject m_ItemStack;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject m_CartStack;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GridLayoutGroup m_ContainerParent;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform m_CartContainerParent;

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIElementCluster m_DescribeCharacterCluster;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup m_ParentCanvasGroup;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int m_Offset;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_Rotation;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<GameObject> m_AllCartInstances;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<GuestGuardMapping> m_AllLetters;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0xF0")]
		private bool isHide;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0xF8")]
		private StaticVerticalGridScrollListUILogicalGroupT<GuestGuardMapping, UIElementCluster, UIButtonSimple> m_LetterGroup;

		// Token: 0x02000207 RID: 519
		[Token(Token = "0x2000207")]
		public struct DLC4BossBattleShopContext
		{
			// Token: 0x06000C60 RID: 3168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x8E3E00", Offset = "0x8E2800", VA = "0x1808E3E00")]
			public DLC4BossBattleShopContext(Dictionary<int, GuestGuardMapping> allMappings, Dictionary<int, float> remainCoolDownSecond, int remainingPPoint, HashSet<int> enableIdledHeroGuests, HashSet<int> holdingLetters, Action onBuyGuards)
			{
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x7FAC50", Offset = "0x7F9650", VA = "0x1807FAC50")]
			public void CleanAction()
			{
			}

			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			[FieldOffset(Offset = "0x0")]
			public readonly Dictionary<int, GuestGuardMapping> AllMappings;

			// Token: 0x04000B07 RID: 2823
			[Token(Token = "0x4000B07")]
			[FieldOffset(Offset = "0x8")]
			public readonly Dictionary<int, float> RemainCoolDownSecond;

			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4000B08")]
			[FieldOffset(Offset = "0x10")]
			public readonly int RemainingPPoint;

			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4000B09")]
			[FieldOffset(Offset = "0x18")]
			public readonly HashSet<int> EnableIdledHeroGuests;

			// Token: 0x04000B0A RID: 2826
			[Token(Token = "0x4000B0A")]
			[FieldOffset(Offset = "0x20")]
			public readonly HashSet<int> HoldingLetters;

			// Token: 0x04000B0B RID: 2827
			[Token(Token = "0x4000B0B")]
			[FieldOffset(Offset = "0x28")]
			public Action OnBuyGuards;
		}
	}
}

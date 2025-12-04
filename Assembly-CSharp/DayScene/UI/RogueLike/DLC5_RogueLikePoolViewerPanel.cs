using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.UGUIExtensions;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePoolViewerPanel : UIPanelParamOpen<ValueTuple<RogueLikeRunTimeData, DLC5_RogueLikePoolViewerPanel.PoolViewerType>>
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		private RogueLikeRunTimeData RunTimeData
		{
			[Token(Token = "0x6001554")]
			[Address(RVA = "0x44EBF0", Offset = "0x44D5F0", VA = "0x18044EBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x44AD50", Offset = "0x449750", VA = "0x18044AD50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x44B7E0", Offset = "0x44A1E0", VA = "0x18044B7E0", Slot = "32")]
		protected override void OnPanelOpen(ValueTuple<RogueLikeRunTimeData, DLC5_RogueLikePoolViewerPanel.PoolViewerType> openParam)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x44D060", Offset = "0x44BA60", VA = "0x18044D060")]
		private void UpdateCardElement()
		{
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x44DF90", Offset = "0x44C990", VA = "0x18044DF90")]
		private void UpdateCurrentViewer(DLC5_RogueLikePoolViewerPanel.PoolViewerType targetViewer)
		{
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x44E860", Offset = "0x44D260", VA = "0x18044E860")]
		private void UpdateEliteChallengeBorder()
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x44A200", Offset = "0x448C00", VA = "0x18044A200")]
		private void InitCard(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair card, UIElementCluster cluster, UIButtonSimple uIButton)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x44A8A0", Offset = "0x4492A0", VA = "0x18044A8A0")]
		private void OnCardBtnSelected(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair card, UIElementCluster cluster, UIButtonSimple uIButton)
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x449990", Offset = "0x448390", VA = "0x180449990")]
		private void DescribeCardAlbum(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair cardPair)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x44A130", Offset = "0x448B30", VA = "0x18044A130")]
		private void Fade()
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x449350", Offset = "0x447D50", VA = "0x180449350")]
		private void Blink()
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x449480", Offset = "0x447E80", VA = "0x180449480", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x44EA40", Offset = "0x44D440", VA = "0x18044EA40")]
		public DLC5_RogueLikePoolViewerPanel()
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x44CCF0", Offset = "0x44B6F0", VA = "0x18044CCF0")]
		[CompilerGenerated]
		internal static void <UpdateCardElement>g__ProcessCard|76_0(UIElementCluster cluster, ValueTuple<string, string> buffDescription)
		{
		}

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject m_ObjectStackParent;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GridLayoutGroup m_ViewerGridContent;

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup m_BadgeViewerGridContent;

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AdpVerticalLayoutGroup m_CardViewerGridContent;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_GetProductScroller;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_BadgeScroller;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_CardScroller;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI m_CollectRateText;

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int m_DisplayCount;

		// Token: 0x04001418 RID: 5144
		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int m_StartLoopCount;

		// Token: 0x04001419 RID: 5145
		[Token(Token = "0x4001419")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup m_ProductGridCanvas;

		// Token: 0x0400141A RID: 5146
		[Token(Token = "0x400141A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup m_CardGridCanvas;

		// Token: 0x0400141B RID: 5147
		[Token(Token = "0x400141B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup m_BadgeCanvas;

		// Token: 0x0400141C RID: 5148
		[Token(Token = "0x400141C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup m_CollectRateCanvas;

		// Token: 0x0400141D RID: 5149
		[Token(Token = "0x400141D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIButtonToggle m_RecipeButton;

		// Token: 0x0400141E RID: 5150
		[Token(Token = "0x400141E")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIButtonToggle m_BevButton;

		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x400141F")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButtonToggle m_CardButton;

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIButtonToggle m_AchievementButton;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TextMeshProUGUI m_RefreshWaveText;

		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x4001422")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CanvasGroup m_CurrentEliteCanvas;

		// Token: 0x04001423 RID: 5155
		[Token(Token = "0x4001423")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private RectTransform m_CurrentEliteDesRect;

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentEliteTitle;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentEliteDes;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("Buff相关")]
		private GameObject m_CardElement;

		// Token: 0x04001427 RID: 5159
		[Token(Token = "0x4001427")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject m_BuffElement;

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private RectTransform m_BuffElementRectTransform;

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private CanvasGroup m_CardPropertyCanvasGroup;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private CanvasGroup m_CardPropertyForeverCanvasGroup;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private CanvasGroup m_CardPropertyRemainingCanvasGroup;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Image m_DangerousBGForForever;

		// Token: 0x0400142D RID: 5165
		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Image m_DangerousBGForRemaining;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private CanvasGroup m_DangerousTip;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private TextMeshProUGUI m_CardTitleTextForForever;

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private TextMeshProUGUI m_CardTitleTextForRemaining;

		// Token: 0x04001431 RID: 5169
		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private TextMeshProUGUI m_CardDescriptionUpTextForForever;

		// Token: 0x04001432 RID: 5170
		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private TextMeshProUGUI m_CardDescriptionUpTextForRemaining;

		// Token: 0x04001433 RID: 5171
		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private TextMeshProUGUI m_CardDescriptionDownText;

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private TextMeshProUGUI m_CardDescriptionExtraText;

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private TextMeshProUGUI m_CardNumText;

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private Color m_RemainingCardTitleColor;

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private Color m_ForeverCardTitleColor;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private Color m_DangerousCardTitleColor;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private Color m_CardSelectedColor;

		// Token: 0x0400143A RID: 5178
		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private Color m_CardDeSelectedColor;

		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private CanvasGroup m_SelectedCanvasGroup;

		// Token: 0x0400143C RID: 5180
		[Token(Token = "0x400143C")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private List<RogueLikeCardBase.CardType> m_CardTypeOrder;

		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0x220")]
		[Header("成就相关")]
		[SerializeField]
		private GameObject m_BadgeElement;

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private Image m_BadgeImage;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private CanvasGroup m_BadgeDescriberCanvasGroup;

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeNameText;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeDescriptionText;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeCollectRateText;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x250")]
		private readonly Color shadowColor;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x260")]
		private readonly List<int> m_GetProductsList;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x268")]
		private readonly List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_GetBadgeList;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x270")]
		private DLC5_RogueLikePoolViewerPanel.PoolViewerType m_CurrentPoolViewerType;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x278")]
		private UIButtonToggle[] m_AllToggles;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		private const string REFRESH_WAVE_TITLE = "ROGUELIKE_POOL_REFRESH_WAVE";

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		private const string REFRESH_WAVE_INITIAL_TITLE = "ROGUELIKE_POOL_INITIAL";

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x280")]
		private DLC5_RogueLikePoolViewerPanel.IdComparer m_RecipeComparer;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x288")]
		private DLC5_RogueLikePoolViewerPanel.IdComparer m_BevComparer;

		// Token: 0x0400144C RID: 5196
		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x290")]
		private StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GetProductsGroup;

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x298")]
		private StaticVirtualScrollListUILogicalGroupT<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair, UIElementCluster, UIButtonSimple> m_CardLogicalGroup;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x2A0")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple> m_AchievementGroup;

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x2A8")]
		private CanvasGroup m_DescriberCanvas;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x2B0")]
		private RogueLikeCardBase.CardType? m_CurrentCardType;

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x2B8")]
		private bool m_BanOtherPanel;

		// Token: 0x04001452 RID: 5202
		[Token(Token = "0x4001452")]
		[FieldOffset(Offset = "0x2C0")]
		private List<GameObject> m_BuffInstances;

		// Token: 0x020003C6 RID: 966
		[Token(Token = "0x20003C6")]
		public enum PoolViewerType
		{
			// Token: 0x04001454 RID: 5204
			[Token(Token = "0x4001454")]
			Recipe,
			// Token: 0x04001455 RID: 5205
			[Token(Token = "0x4001455")]
			Bev,
			// Token: 0x04001456 RID: 5206
			[Token(Token = "0x4001456")]
			Card,
			// Token: 0x04001457 RID: 5207
			[Token(Token = "0x4001457")]
			Achievement
		}

		// Token: 0x020003C7 RID: 967
		[Token(Token = "0x20003C7")]
		public class RogueLikeCardInstancePair
		{
			// Token: 0x06001570 RID: 5488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001570")]
			[Address(RVA = "0x46C510", Offset = "0x46AF10", VA = "0x18046C510")]
			public RogueLikeCardInstancePair(RogueLikeCardBase.CardType cardType, KeyValuePair<RogueLikePersistentCardInstance, int>[] persistentCardInstances)
			{
			}

			// Token: 0x06001571 RID: 5489 RVA: 0x00008178 File Offset: 0x00006378
			[Token(Token = "0x6001571")]
			[Address(RVA = "0x46C120", Offset = "0x46AB20", VA = "0x18046C120")]
			public int GetActiveCardNum()
			{
				return 0;
			}

			// Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x46C320", Offset = "0x46AD20", VA = "0x18046C320")]
			public string GetAlbumDescription(string oldDescription, RogueLikeRunTimeData runTimeData)
			{
				return null;
			}

			// Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001573")]
			[Address(RVA = "0x46C3B0", Offset = "0x46ADB0", VA = "0x18046C3B0")]
			public string GetTargetIndexCardDescription(string oldDescription, RogueLikeRunTimeData runTimeData, int index)
			{
				return null;
			}

			// Token: 0x04001458 RID: 5208
			[Token(Token = "0x4001458")]
			[FieldOffset(Offset = "0x10")]
			public RogueLikeCardBase.CardType CardType;

			// Token: 0x04001459 RID: 5209
			[Token(Token = "0x4001459")]
			[FieldOffset(Offset = "0x18")]
			public readonly KeyValuePair<RogueLikePersistentCardInstance, int>[] PersistentCardInstances;
		}

		// Token: 0x020003C9 RID: 969
		[Token(Token = "0x20003C9")]
		public class IdComparer : IComparer<int>
		{
			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000281")]
			public HashSet<int> RemainedProductPool
			{
				[Token(Token = "0x6001578")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000282")]
			public HashSet<int> ObtainedProductPool
			{
				[Token(Token = "0x6001579")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000283")]
			public HashSet<int> InitialProductPool
			{
				[Token(Token = "0x600157A")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000284")]
			public HashSet<int> AllProductPool
			{
				[Token(Token = "0x600157B")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600157C")]
			[Address(RVA = "0x46A1C0", Offset = "0x468BC0", VA = "0x18046A1C0")]
			public IdComparer(HashSet<int> remainedProductPool, HashSet<int> obtainedProductPool, HashSet<int> initialProductPool, HashSet<int> allProductPool, Dictionary<int, int> elementRefreshWaveIndex)
			{
			}

			// Token: 0x0600157D RID: 5501 RVA: 0x000081C0 File Offset: 0x000063C0
			[Token(Token = "0x600157D")]
			[Address(RVA = "0x46A160", Offset = "0x468B60", VA = "0x18046A160")]
			public float GetCollectRate()
			{
				return 0f;
			}

			// Token: 0x0600157E RID: 5502 RVA: 0x000081D8 File Offset: 0x000063D8
			[Token(Token = "0x600157E")]
			[Address(RVA = "0x469F00", Offset = "0x468900", VA = "0x180469F00", Slot = "4")]
			public int Compare(int x, int y)
			{
				return 0;
			}

			// Token: 0x0400145D RID: 5213
			[Token(Token = "0x400145D")]
			[FieldOffset(Offset = "0x10")]
			private readonly HashSet<int> remainedProductPool;

			// Token: 0x0400145E RID: 5214
			[Token(Token = "0x400145E")]
			[FieldOffset(Offset = "0x18")]
			private readonly HashSet<int> obtainedProductPool;

			// Token: 0x0400145F RID: 5215
			[Token(Token = "0x400145F")]
			[FieldOffset(Offset = "0x20")]
			private readonly HashSet<int> initialProductPool;

			// Token: 0x04001460 RID: 5216
			[Token(Token = "0x4001460")]
			[FieldOffset(Offset = "0x28")]
			private readonly HashSet<int> allProductPool;

			// Token: 0x04001461 RID: 5217
			[Token(Token = "0x4001461")]
			[FieldOffset(Offset = "0x30")]
			private readonly Dictionary<int, int> elementRefreshWaveIndex;
		}
	}
}

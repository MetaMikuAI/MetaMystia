using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using NightScene;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePurchasePanel : MultiLayerUIPanel<DLC5_RogueLikePurchasePanel, InspectingProductType>, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public IList<ProductReference> AllProducts
		{
			[Token(Token = "0x60015FD")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		public List<ProductReference> Merchandise
		{
			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x45CD70", Offset = "0x45B770", VA = "0x18045CD70", Slot = "39")]
		protected override void OnMultilayerPanelDestroyed()
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x000084D8 File Offset: 0x000066D8
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700028F")]
		public int Fund
		{
			[Token(Token = "0x6001600")]
			[Address(RVA = "0x45EA70", Offset = "0x45D470", VA = "0x18045EA70", Slot = "40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001601")]
			[Address(RVA = "0x45F070", Offset = "0x45DA70", VA = "0x18045F070", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000290")]
		public RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000291")]
		public DLC5_RogueLikePoolResultPanel ResultPanel
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000292")]
		public CanvasGroup NullIndicator
		{
			[Token(Token = "0x6001606")]
			[Address(RVA = "0x45F000", Offset = "0x45DA00", VA = "0x18045F000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001607")]
			[Address(RVA = "0x45F190", Offset = "0x45DB90", VA = "0x18045F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x000084F0 File Offset: 0x000066F0
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000293")]
		public bool HasKourindouCoupon
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x45EFE0", Offset = "0x45D9E0", VA = "0x18045EFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x45F160", Offset = "0x45DB60", VA = "0x18045F160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00008508 File Offset: 0x00006708
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000294")]
		public float CurrentDiscount
		{
			[Token(Token = "0x600160A")]
			[Address(RVA = "0x45EA40", Offset = "0x45D440", VA = "0x18045EA40")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600160B")]
			[Address(RVA = "0x45F030", Offset = "0x45DA30", VA = "0x18045F030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00008520 File Offset: 0x00006720
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000295")]
		public bool FirstOpen
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x45EA50", Offset = "0x45D450", VA = "0x18045EA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x45F040", Offset = "0x45DA40", VA = "0x18045F040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00008538 File Offset: 0x00006738
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000296")]
		public DLC5_RogueLikeExtraMenuSubPanel.CloseContext ShopCloseContext
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x45F010", Offset = "0x45DA10", VA = "0x18045F010")]
			[CompilerGenerated]
			get
			{
				return DLC5_RogueLikeExtraMenuSubPanel.CloseContext.Norm;
			}
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x45F1D0", Offset = "0x45DBD0", VA = "0x18045F1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000297")]
		public Action FundUpdateCallback
		{
			[Token(Token = "0x6001610")]
			[Address(RVA = "0x45EA60", Offset = "0x45D460", VA = "0x18045EA60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6001611")]
			[Address(RVA = "0x45F050", Offset = "0x45DA50", VA = "0x18045F050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000298")]
		public Func<int, int> GetFinalPriceCallback
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x45ED40", Offset = "0x45D740", VA = "0x18045ED40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x45F140", Offset = "0x45DB40", VA = "0x18045F140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000299")]
		public UIButtonHold ConfirmBuyBtn
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x45EA30", Offset = "0x45D430", VA = "0x18045EA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x45E460", Offset = "0x45CE60", VA = "0x18045E460")]
		public void SetSymbol(bool isMinus)
		{
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x45B830", Offset = "0x45A230", VA = "0x18045B830", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>> GetData
		{
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x45EA80", Offset = "0x45D480", VA = "0x18045EA80", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x45D390", Offset = "0x45BD90", VA = "0x18045D390", Slot = "36")]
		protected override void OnPostPanelInitialize()
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001619")]
		private static void DefaultOnItemEnabled<T>(T data, UIElementCluster uiElementCluster, int amount, bool check) where T : ITextProvider<ObjectLanguageBase>
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161A")]
		private static void DecorationOnItemEnabled<T>(T data, UIElementCluster uiElementCluster, bool owned, bool check) where T : ITextProvider<ObjectLanguageBase>
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x45DE90", Offset = "0x45C890", VA = "0x18045DE90")]
		private static void RecipeOnItemEnabled(Recipe data, UIElementCluster uiElementCluster, bool check)
		{
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x45B150", Offset = "0x459B50", VA = "0x18045B150")]
		private static void DefaultOnSpecialGuestEnabled(SpecialGuest guestData, UIElementCluster cluster, int _, bool check)
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x45CDC0", Offset = "0x45B7C0", VA = "0x18045CDC0", Slot = "38")]
		protected override void OnPanelPreOpen()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x45D670", Offset = "0x45C070", VA = "0x18045D670", Slot = "37")]
		protected override void OnPreOpenSubPanel(InspectingProductType panelData, UISubPanel<DLC5_RogueLikePurchasePanel> panel)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x1700029B")]
		protected override InspectingProductType DefaultPanelSelection
		{
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "33")]
			get
			{
				return InspectingProductType.IngredientsAndBeverage;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029C")]
		protected override string SwitchKey
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x45F020", Offset = "0x45DA20", VA = "0x18045F020", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x45ABE0", Offset = "0x4595E0", VA = "0x18045ABE0")]
		public void AfterClose()
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x45E8E0", Offset = "0x45D2E0", VA = "0x18045E8E0")]
		public void UpdateTotalPrice(int calculatePrice)
		{
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x45E390", Offset = "0x45CD90", VA = "0x18045E390")]
		private void RefreshPopularTag()
		{
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x45AC70", Offset = "0x459670", VA = "0x18045AC70")]
		private void CheckCanPopular()
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x45E050", Offset = "0x45CA50", VA = "0x18045E050")]
		private void RefreshPopularTagView()
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x45E8B0", Offset = "0x45D2B0", VA = "0x18045E8B0")]
		public void UpdateShopTitle(string targetTitle)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x45E880", Offset = "0x45D280", VA = "0x18045E880")]
		public void UpdateCartTitle(string targetTitle)
		{
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029D")]
		public DLC5_RogueLikeSpotSelectionPanel_New MapPanel
		{
			[Token(Token = "0x6001628")]
			[Address(RVA = "0x45EFF0", Offset = "0x45D9F0", VA = "0x18045EFF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x45F170", Offset = "0x45DB70", VA = "0x18045F170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		[CleanupIgnore]
		private Dictionary<RogueLikeCardBase.CardType, string> GetSelections
		{
			[Token(Token = "0x600162A")]
			[Address(RVA = "0x45ED50", Offset = "0x45D750", VA = "0x18045ED50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029F")]
		[CleanupIgnore]
		private Dictionary<RogueLikeRunTimeData.EliteChallengeType, string> GetEliteChallengeTypeSelections
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x45EB00", Offset = "0x45D500", VA = "0x18045EB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x45B850", Offset = "0x45A250", VA = "0x18045B850")]
		private void OnGUI()
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x45E4B0", Offset = "0x45CEB0", VA = "0x18045E4B0")]
		private static bool StandardDeductProductAmount(ref Product product, int amount)
		{
			return default(bool);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0")]
		private static bool ForceClearProductAmount()
		{
			return default(bool);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
		private static int StandardGetProductAmount(in Product product)
		{
			return 0;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x45AC10", Offset = "0x459610", VA = "0x18045AC10")]
		private static bool AmountAsPriceDeductProductAmount(ref Product product)
		{
			return default(bool);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x45AC60", Offset = "0x459660", VA = "0x18045AC60")]
		private static int AmountAsPriceGetProductAmount(in Product product)
		{
			return 0;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
		private static int AmountAsPriceGetProductPrice(in Product product)
		{
			return 0;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x45ACE0", Offset = "0x4596E0", VA = "0x18045ACE0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x45E990", Offset = "0x45D390", VA = "0x18045E990")]
		public DLC5_RogueLikePurchasePanel()
		{
		}

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_Fund;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonToggle m_GotoIngredientsToggle;

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonToggle m_GotoRecipeToggle;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonToggle m_GotoCookerToggle;

		// Token: 0x040014CA RID: 5322
		[Token(Token = "0x40014CA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonToggle m_GotoDecorationToggle;

		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40014CB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIButtonToggle m_GotoClothesToggle;

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIButtonToggle m_GotoInviteToggle;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIButtonToggle m_GotoPartnerToggle;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIButtonToggle m_GotoRecycleToggle;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_IngredientsPanel;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private DLC5_RogueLikePurchaseRecipePanel m_RecipePanel;

		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x40014D1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_CookerPanel;

		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_DecorationPanel;

		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_ClothesPanel;

		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_InvitePanel;

		// Token: 0x040014D5 RID: 5333
		[Token(Token = "0x40014D5")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private DLC5_RogueLikePurchaseItemPanel m_PartnerPanel;

		// Token: 0x040014D6 RID: 5334
		[Token(Token = "0x40014D6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DLC5_RogueLikePurchaseRecyclePanel m_RecyclePanel;

		// Token: 0x040014D7 RID: 5335
		[Token(Token = "0x40014D7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int m_CurrentFund;

		// Token: 0x040014D8 RID: 5336
		[Token(Token = "0x40014D8")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TextMeshProUGUI m_TotalCost;

		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private TextMeshProUGUI m_RemainingFund;

		// Token: 0x040014DA RID: 5338
		[Token(Token = "0x40014DA")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private TextMeshProUGUI m_WaveText;

		// Token: 0x040014DB RID: 5339
		[Token(Token = "0x40014DB")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private TextMeshProUGUI m_WaveNeedFundText;

		// Token: 0x040014DC RID: 5340
		[Token(Token = "0x40014DC")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private CanvasGroup m_DisCountTip;

		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject m_KourindouCouponTip;

		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject m_CardTip;

		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private GameObject m_PlusTip;

		// Token: 0x040014E0 RID: 5344
		[Token(Token = "0x40014E0")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentDiscount;

		// Token: 0x040014E1 RID: 5345
		[Token(Token = "0x40014E1")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private TextMeshProUGUI m_PopLikeText;

		// Token: 0x040014E2 RID: 5346
		[Token(Token = "0x40014E2")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject m_PopLikeObject;

		// Token: 0x040014E3 RID: 5347
		[Token(Token = "0x40014E3")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private TextMeshProUGUI m_PopHateText;

		// Token: 0x040014E4 RID: 5348
		[Token(Token = "0x40014E4")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject m_PopHateObject;

		// Token: 0x040014E5 RID: 5349
		[Token(Token = "0x40014E5")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private TextMeshProUGUI m_PopNeutralText;

		// Token: 0x040014E6 RID: 5350
		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject m_PopNeutralObject;

		// Token: 0x040014E7 RID: 5351
		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private TextMeshProUGUI m_PopularRefreshText;

		// Token: 0x040014E8 RID: 5352
		[Token(Token = "0x40014E8")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private UIButtonSimple m_PopularRefreshBtn;

		// Token: 0x040014E9 RID: 5353
		[Token(Token = "0x40014E9")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private UIButtonSimple m_OpenSubSettingBtn;

		// Token: 0x040014EA RID: 5354
		[Token(Token = "0x40014EA")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private UIButtonHold m_ConfirmBuyBtn;

		// Token: 0x040014EC RID: 5356
		[Token(Token = "0x40014EC")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private TextMeshProUGUI m_ShopTitleText;

		// Token: 0x040014ED RID: 5357
		[Token(Token = "0x40014ED")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private TextMeshProUGUI m_CartTitleText;

		// Token: 0x040014EE RID: 5358
		[Token(Token = "0x40014EE")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForPurchase;

		// Token: 0x040014EF RID: 5359
		[Token(Token = "0x40014EF")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GameObject m_FundSymbolMinus;

		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40014F0")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private GameObject m_FundSymbolPlus;

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		private const int COUPONS_ID = 2;

		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40014F7")]
		[FieldOffset(Offset = "0x208")]
		private int m_CalculatePrice;

		// Token: 0x040014F9 RID: 5369
		[Token(Token = "0x40014F9")]
		private const string DISCOUNT_TEXT = "$a%OFF!";

		// Token: 0x040014FA RID: 5370
		[Token(Token = "0x40014FA")]
		[FieldOffset(Offset = "0x218")]
		private bool m_HasPopular;

		// Token: 0x040014FB RID: 5371
		[Token(Token = "0x40014FB")]
		[FieldOffset(Offset = "0x21C")]
		private RogueLikeCardBase.CardType selectedCardType;

		// Token: 0x040014FC RID: 5372
		[Token(Token = "0x40014FC")]
		[FieldOffset(Offset = "0x220")]
		private bool isCardTypeExpanded;

		// Token: 0x040014FD RID: 5373
		[Token(Token = "0x40014FD")]
		[FieldOffset(Offset = "0x224")]
		private RogueLikeRunTimeData.EliteChallengeType selectedEliteChallengeType;

		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		[FieldOffset(Offset = "0x228")]
		private bool isEliteChallengeTypeExpanded;

		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0x230")]
		private Dictionary<RogueLikeCardBase.CardType, string> selections;

		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0x238")]
		private Dictionary<RogueLikeRunTimeData.EliteChallengeType, string> eliteChallengeTypeSelections;

		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0x248")]
		private NightSceneDirector.Difficulty difficulty;

		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x24C")]
		private bool isdifficultyExpanded;

		// Token: 0x04001504 RID: 5380
		[Token(Token = "0x4001504")]
		[FieldOffset(Offset = "0x250")]
		private int roundWave;

		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001505")]
		[FieldOffset(Offset = "0x254")]
		private bool shouldOnGUIBuffConsoleShown;

		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001506")]
		[FieldOffset(Offset = "0x255")]
		private bool consoleDataIsInitialized;

		// Token: 0x04001507 RID: 5383
		[Token(Token = "0x4001507")]
		public const string SOLD_INDICATOR = "SOLD";

		// Token: 0x020003E1 RID: 993
		[Token(Token = "0x20003E1")]
		public static class RogueLikePurchasePanelLanguageProvider
		{
			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A0")]
			public static string WaveText
			{
				[Token(Token = "0x600163C")]
				[Address(RVA = "0x46C710", Offset = "0x46B110", VA = "0x18046C710")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A1")]
			public static string PopRefresh
			{
				[Token(Token = "0x600163D")]
				[Address(RVA = "0x46C650", Offset = "0x46B050", VA = "0x18046C650")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A2")]
			public static string PopNeutral
			{
				[Token(Token = "0x600163E")]
				[Address(RVA = "0x46C610", Offset = "0x46B010", VA = "0x18046C610")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A3")]
			public static string Acquired
			{
				[Token(Token = "0x600163F")]
				[Address(RVA = "0x46C550", Offset = "0x46AF50", VA = "0x18046C550")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A4")]
			public static string Kourindou
			{
				[Token(Token = "0x6001640")]
				[Address(RVA = "0x46C5D0", Offset = "0x46AFD0", VA = "0x18046C5D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A5")]
			public static string Shop_Cart
			{
				[Token(Token = "0x6001641")]
				[Address(RVA = "0x46C690", Offset = "0x46B090", VA = "0x18046C690")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A6")]
			public static string Describer_Inshelf
			{
				[Token(Token = "0x6001642")]
				[Address(RVA = "0x46C590", Offset = "0x46AF90", VA = "0x18046C590")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A7")]
			public static string Store_Recycle
			{
				[Token(Token = "0x6001643")]
				[Address(RVA = "0x46C6D0", Offset = "0x46B0D0", VA = "0x18046C6D0")]
				get
				{
					return null;
				}
			}
		}

		// Token: 0x020003E2 RID: 994
		[Token(Token = "0x20003E2")]
		public abstract class TypedOpenContext<TDataType, TDescribingType, TDescriberType> : DLC5_RogueLikePurchasePanel.OpenContext where TDataType : class, ITextProvider<LanguageBase> where TDescriberType : MonoBehaviour, ITypedDescriber<TDescribingType>
		{
			// Token: 0x06001644 RID: 5700
			[Token(Token = "0x6001644")]
			protected abstract void PreviewObject(TDataType data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData);

			// Token: 0x06001645 RID: 5701
			[Token(Token = "0x6001645")]
			protected abstract TDataType MapProduct(in Product product);

			// Token: 0x06001646 RID: 5702
			[Token(Token = "0x6001646")]
			protected abstract void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<TDataType, int>> boughtData, RogueLikeRunTimeData runTimeData);

			// Token: 0x06001647 RID: 5703
			[Token(Token = "0x6001647")]
			protected abstract TDescribingType MapData(TDataType dataType);

			// Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001648")]
			protected TypedOpenContext(SelectionMode selectionMode, Product.ProductType[] productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy)
			{
			}

			// Token: 0x06001649 RID: 5705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001649")]
			public override void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken)
			{
			}

			// Token: 0x0600164A RID: 5706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600164A")]
			public override void PreviewObject(ITextProvider<LanguageBase> nonTradableObjectBase, UIElementCluster uiElementCluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600164B")]
			public override ITextProvider<LanguageBase> ProductToObject(in Product product)
			{
				return null;
			}

			// Token: 0x0600164C RID: 5708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600164C")]
			public override void Buy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> data, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600164D")]
			private static IEnumerable<ValueTuple<TDataType, int>> Cast([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> collection)
			{
				return null;
			}
		}

		// Token: 0x020003E4 RID: 996
		[Token(Token = "0x20003E4")]
		public abstract class OpenContext
		{
			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06001657 RID: 5719 RVA: 0x00008640 File Offset: 0x00006840
			[Token(Token = "0x170002AA")]
			public SelectionMode SelectionMode
			{
				[Token(Token = "0x6001657")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return SelectionMode.Buy;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AB")]
			public IList<int> Selections
			{
				[Token(Token = "0x6001658")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06001659 RID: 5721 RVA: 0x00008658 File Offset: 0x00006858
			[Token(Token = "0x170002AC")]
			public int MaxBuy
			{
				[Token(Token = "0x6001659")]
				[Address(RVA = "0x3F8D30", Offset = "0x3F7730", VA = "0x1803F8D30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x0600165A RID: 5722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AD")]
			public HashSet<Product.ProductType> ProductsTypeFilter
			{
				[Token(Token = "0x600165A")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AE")]
			public DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource DataSource
			{
				[Token(Token = "0x600165B")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600165C RID: 5724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600165C")]
			[Address(RVA = "0x46AE80", Offset = "0x469880", VA = "0x18046AE80")]
			protected OpenContext(SelectionMode selectionMode, Product.ProductType[] productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy)
			{
			}

			// Token: 0x0600165D RID: 5725 RVA: 0x00008670 File Offset: 0x00006870
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x46AE70", Offset = "0x469870", VA = "0x18046AE70", Slot = "4")]
			public virtual int GetCurrentBuyCount(RogueLikeRunTimeData runTimeData)
			{
				return 0;
			}

			// Token: 0x0600165E RID: 5726
			[Token(Token = "0x600165E")]
			public abstract void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken);

			// Token: 0x0600165F RID: 5727
			[Token(Token = "0x600165F")]
			public abstract void PreviewObject(ITextProvider<LanguageBase> objectBase, UIElementCluster uiElementCluster, int amount, bool check, RogueLikeRunTimeData runTimeData);

			// Token: 0x06001660 RID: 5728
			[Token(Token = "0x6001660")]
			public abstract void Buy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> data, RogueLikeRunTimeData runTimeData);

			// Token: 0x06001661 RID: 5729
			[Token(Token = "0x6001661")]
			public abstract ITextProvider<LanguageBase> ProductToObject(in Product product);

			// Token: 0x06001662 RID: 5730
			[Token(Token = "0x6001662")]
			public abstract int GetProductPrice(in Product product);

			// Token: 0x06001663 RID: 5731
			[Token(Token = "0x6001663")]
			public abstract bool DeductProductAmount(ref Product product, int amount);

			// Token: 0x06001664 RID: 5732
			[Token(Token = "0x6001664")]
			public abstract int GetProductAmount(in Product product);
		}

		// Token: 0x020003E5 RID: 997
		[Token(Token = "0x20003E5")]
		private abstract class ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType> : DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType> where TDataType : class, ITextProvider<ObjectLanguageBase> where TDescriberType : MonoBehaviour, ITypedDescriber<TDescribingType>
		{
			// Token: 0x06001665 RID: 5733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001665")]
			protected ItemTypeOpenContext(SelectionMode selectionMode, Product.ProductType[] productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy)
			{
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001666")]
			protected override void PreviewObject(TDataType data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003E6 RID: 998
		[Token(Token = "0x20003E6")]
		private abstract class SpecialGuestTypeOpenContext<TDescriber> : DLC5_RogueLikePurchasePanel.TypedOpenContext<SpecialGuest, SpecialGuest, TDescriber> where TDescriber : MonoBehaviour, ITypedDescriber<SpecialGuest>
		{
			// Token: 0x06001667 RID: 5735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001667")]
			protected SpecialGuestTypeOpenContext(SelectionMode selectionMode, Product.ProductType[] productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy)
			{
			}

			// Token: 0x06001668 RID: 5736 RVA: 0x00008688 File Offset: 0x00006888
			[Token(Token = "0x6001668")]
			public sealed override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x06001669 RID: 5737 RVA: 0x000086A0 File Offset: 0x000068A0
			[Token(Token = "0x6001669")]
			public sealed override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x0600166A RID: 5738 RVA: 0x000086B8 File Offset: 0x000068B8
			[Token(Token = "0x600166A")]
			public sealed override int GetProductAmount(in Product product)
			{
				return 0;
			}

			// Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600166B")]
			protected sealed override SpecialGuest MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x0600166C RID: 5740 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600166C")]
			protected override SpecialGuest MapData(SpecialGuest dataType)
			{
				return null;
			}

			// Token: 0x0600166D RID: 5741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600166D")]
			protected override void PreviewObject(SpecialGuest data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003E7 RID: 999
		[Token(Token = "0x20003E7")]
		private abstract class UnifiedItemTypeOpenContext<TDataType, TDescriberType> : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDataType, TDescriberType> where TDataType : class, ITextProvider<ObjectLanguageBase> where TDescriberType : MonoBehaviour, ITypedDescriber<TDataType>
		{
			// Token: 0x0600166E RID: 5742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600166E")]
			protected UnifiedItemTypeOpenContext(SelectionMode selectionMode, Product.ProductType[] productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy)
			{
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600166F")]
			protected sealed override TDataType MapData(TDataType dataType)
			{
				return null;
			}
		}

		// Token: 0x020003E8 RID: 1000
		[Token(Token = "0x20003E8")]
		private class IngredientAndBeverageOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TradableObjectBase, SellableDescriber>
		{
			// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001670")]
			[Address(RVA = "0x46A690", Offset = "0x469090", VA = "0x18046A690")]
			public IngredientAndBeverageOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x06001671 RID: 5745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001671")]
			[Address(RVA = "0x46A2C0", Offset = "0x468CC0", VA = "0x18046A2C0", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<TradableObjectBase, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x46A2A0", Offset = "0x468CA0", VA = "0x18046A2A0", Slot = "13")]
			protected override TradableObjectBase MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x06001673 RID: 5747 RVA: 0x000086D0 File Offset: 0x000068D0
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x46A260", Offset = "0x468C60", VA = "0x18046A260", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x06001674 RID: 5748 RVA: 0x000086E8 File Offset: 0x000068E8
			[Token(Token = "0x6001674")]
			[Address(RVA = "0x46A250", Offset = "0x468C50", VA = "0x18046A250", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x06001675 RID: 5749 RVA: 0x00008700 File Offset: 0x00006900
			[Token(Token = "0x6001675")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}
		}

		// Token: 0x020003EA RID: 1002
		[Token(Token = "0x20003EA")]
		private class RecipeOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Recipe, DLC5_RogueLike_RecipeDescriber>
		{
			// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600167C")]
			[Address(RVA = "0x46B990", Offset = "0x46A390", VA = "0x18046B990")]
			public RecipeOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x0600167D RID: 5757 RVA: 0x00008748 File Offset: 0x00006948
			[Token(Token = "0x600167D")]
			[Address(RVA = "0x46B450", Offset = "0x469E50", VA = "0x18046B450", Slot = "4")]
			public override int GetCurrentBuyCount(RogueLikeRunTimeData runTimeData)
			{
				return 0;
			}

			// Token: 0x0600167E RID: 5758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600167E")]
			[Address(RVA = "0x46B480", Offset = "0x469E80", VA = "0x18046B480", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<Recipe, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x0600167F RID: 5759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x46B470", Offset = "0x469E70", VA = "0x18046B470", Slot = "13")]
			protected override Recipe MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x06001680 RID: 5760 RVA: 0x00008760 File Offset: 0x00006960
			[Token(Token = "0x6001680")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x06001681 RID: 5761 RVA: 0x00008778 File Offset: 0x00006978
			[Token(Token = "0x6001681")]
			[Address(RVA = "0x456CE0", Offset = "0x4556E0", VA = "0x180456CE0", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x06001682 RID: 5762 RVA: 0x00008790 File Offset: 0x00006990
			[Token(Token = "0x6001682")]
			[Address(RVA = "0x456D30", Offset = "0x455730", VA = "0x180456D30", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}

			// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001683")]
			[Address(RVA = "0x46B7E0", Offset = "0x46A1E0", VA = "0x18046B7E0", Slot = "12")]
			protected override void PreviewObject(Recipe data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003EC RID: 1004
		[Token(Token = "0x20003EC")]
		private class CookerOpenContext : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<Cooker, ObjectLanguageBase, ObjectLanguageBaseDescriber>
		{
			// Token: 0x06001687 RID: 5767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001687")]
			[Address(RVA = "0x457870", Offset = "0x456270", VA = "0x180457870")]
			public CookerOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x06001688 RID: 5768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001688")]
			[Address(RVA = "0x457700", Offset = "0x456100", VA = "0x180457700", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<Cooker, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x06001689 RID: 5769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001689")]
			[Address(RVA = "0x4575B0", Offset = "0x455FB0", VA = "0x1804575B0", Slot = "5")]
			public override void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken)
			{
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600168A")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0")]
			private static void CookerOnItemEnabled(Cooker data, UIElementCluster uiElementCluster, int amount, bool check)
			{
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600168B")]
			[Address(RVA = "0x457840", Offset = "0x456240", VA = "0x180457840", Slot = "12")]
			protected override void PreviewObject(Cooker data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x0600168C RID: 5772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600168C")]
			[Address(RVA = "0x4576D0", Offset = "0x4560D0", VA = "0x1804576D0", Slot = "15")]
			protected override ObjectLanguageBase MapData(Cooker dataType)
			{
				return null;
			}

			// Token: 0x0600168D RID: 5773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600168D")]
			[Address(RVA = "0x4576F0", Offset = "0x4560F0", VA = "0x1804576F0", Slot = "13")]
			protected override Cooker MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x0600168E RID: 5774 RVA: 0x000087C0 File Offset: 0x000069C0
			[Token(Token = "0x600168E")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x0600168F RID: 5775 RVA: 0x000087D8 File Offset: 0x000069D8
			[Token(Token = "0x600168F")]
			[Address(RVA = "0x456CE0", Offset = "0x4556E0", VA = "0x180456CE0", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x06001690 RID: 5776 RVA: 0x000087F0 File Offset: 0x000069F0
			[Token(Token = "0x6001690")]
			[Address(RVA = "0x456D30", Offset = "0x455730", VA = "0x180456D30", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}
		}

		// Token: 0x020003EF RID: 1007
		[Token(Token = "0x20003EF")]
		private class DecorationOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Decoration, DecorationDescriber>
		{
			// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x469E50", Offset = "0x468850", VA = "0x180469E50")]
			public DecorationOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> decorationSelections)
			{
			}

			// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x469B40", Offset = "0x468540", VA = "0x180469B40", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<Decoration, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x469B30", Offset = "0x468530", VA = "0x180469B30", Slot = "13")]
			protected override Decoration MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x00008820 File Offset: 0x00006A20
			[Token(Token = "0x600169A")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x00008838 File Offset: 0x00006A38
			[Token(Token = "0x600169B")]
			[Address(RVA = "0x456CE0", Offset = "0x4556E0", VA = "0x180456CE0", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x00008850 File Offset: 0x00006A50
			[Token(Token = "0x600169C")]
			[Address(RVA = "0x456D30", Offset = "0x455730", VA = "0x180456D30", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x469DE0", Offset = "0x4687E0", VA = "0x180469DE0", Slot = "12")]
			protected override void PreviewObject(Decoration data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003F1 RID: 1009
		[Token(Token = "0x20003F1")]
		private class ClothesOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Item, ClothesDescriber>
		{
			// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016A1")]
			[Address(RVA = "0x457320", Offset = "0x455D20", VA = "0x180457320")]
			public ClothesOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections)
			{
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x00008880 File Offset: 0x00006A80
			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x00008898 File Offset: 0x00006A98
			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x456CE0", Offset = "0x4556E0", VA = "0x180456CE0", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x060016A4 RID: 5796 RVA: 0x000088B0 File Offset: 0x00006AB0
			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x456D30", Offset = "0x455730", VA = "0x180456D30", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}

			// Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x456D50", Offset = "0x455750", VA = "0x180456D50", Slot = "13")]
			protected override Item MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016A6")]
			[Address(RVA = "0x456D60", Offset = "0x455760", VA = "0x180456D60", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<Item, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016A7")]
			[Address(RVA = "0x456E90", Offset = "0x455890", VA = "0x180456E90", Slot = "12")]
			protected override void PreviewObject(Item data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003F4 RID: 1012
		[Token(Token = "0x20003F4")]
		private class InviteOpenContext : DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<DLC5_RogueLike_InviteDescriber>
		{
			// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x46A9D0", Offset = "0x4693D0", VA = "0x18046A9D0")]
			public InviteOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x46A740", Offset = "0x469140", VA = "0x18046A740", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<SpecialGuest, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003F5 RID: 1013
		[Token(Token = "0x20003F5")]
		private class PartnerOpenContext : DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<DLC5_RogueLike_PartnerDescriber>
		{
			// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016B4")]
			[Address(RVA = "0x46B2A0", Offset = "0x469CA0", VA = "0x18046B2A0")]
			public PartnerOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x46B010", Offset = "0x469A10", VA = "0x18046B010", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<SpecialGuest, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}
		}

		// Token: 0x020003F6 RID: 1014
		[Token(Token = "0x20003F6")]
		private class RecycledItemOpenContext : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<RecycleItemDescriber.RecycleItem, RecycleItemDescriber.RecycleItem, RecycleItemDescriber>
		{
			// Token: 0x060016B6 RID: 5814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x46BEC0", Offset = "0x46A8C0", VA = "0x18046BEC0", Slot = "13")]
			protected override RecycleItemDescriber.RecycleItem MapProduct(in Product product)
			{
				return null;
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x46BF50", Offset = "0x46A950", VA = "0x18046BF50", Slot = "14")]
			protected override void OnBuy([TupleElementNames(new string[] { "Data", "Amount" })] IEnumerable<ValueTuple<RecycleItemDescriber.RecycleItem, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
			}

			// Token: 0x060016B8 RID: 5816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "15")]
			protected override RecycleItemDescriber.RecycleItem MapData(RecycleItemDescriber.RecycleItem dataType)
			{
				return null;
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x000088E0 File Offset: 0x00006AE0
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x46BDE0", Offset = "0x46A7E0", VA = "0x18046BDE0", Slot = "9")]
			public override int GetProductPrice(in Product product)
			{
				return 0;
			}

			// Token: 0x060016BA RID: 5818 RVA: 0x000088F8 File Offset: 0x00006AF8
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x46A250", Offset = "0x468C50", VA = "0x18046A250", Slot = "10")]
			public override bool DeductProductAmount(ref Product product, int amount)
			{
				return default(bool);
			}

			// Token: 0x060016BB RID: 5819 RVA: 0x00008910 File Offset: 0x00006B10
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x456D40", Offset = "0x455740", VA = "0x180456D40", Slot = "11")]
			public override int GetProductAmount(in Product product)
			{
				return 0;
			}

			// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x46C080", Offset = "0x46AA80", VA = "0x18046C080")]
			public RecycledItemOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource)
			{
			}

			// Token: 0x020003F7 RID: 1015
			[Token(Token = "0x20003F7")]
			public class RecycledDataSource : DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource
			{
				// Token: 0x170002AF RID: 687
				// (get) Token: 0x060016BD RID: 5821 RVA: 0x00008928 File Offset: 0x00006B28
				// (set) Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170002AF")]
				public int Fund
				{
					[Token(Token = "0x60016BD")]
					[Address(RVA = "0x46BCE0", Offset = "0x46A6E0", VA = "0x18046BCE0", Slot = "4")]
					get
					{
						return 0;
					}
					[Token(Token = "0x60016BE")]
					[Address(RVA = "0x46BD80", Offset = "0x46A780", VA = "0x18046BD80", Slot = "5")]
					set
					{
					}
				}

				// Token: 0x170002B0 RID: 688
				// (get) Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170002B0")]
				public RogueLikeRunTimeData RogueLikeRunTimeData
				{
					[Token(Token = "0x60016BF")]
					[Address(RVA = "0x46BD30", Offset = "0x46A730", VA = "0x18046BD30", Slot = "7")]
					get
					{
						return null;
					}
				}

				// Token: 0x060016C0 RID: 5824 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60016C0")]
				[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
				public RecycledDataSource(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource baseData)
				{
				}

				// Token: 0x170002B1 RID: 689
				// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170002B1")]
				public IList<ProductReference> AllProducts
				{
					[Token(Token = "0x60016C1")]
					[Address(RVA = "0x46BAB0", Offset = "0x46A4B0", VA = "0x18046BAB0", Slot = "6")]
					get
					{
						return null;
					}
				}

				// Token: 0x04001525 RID: 5413
				[Token(Token = "0x4001525")]
				[FieldOffset(Offset = "0x10")]
				private DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource DataSource;
			}
		}
	}
}

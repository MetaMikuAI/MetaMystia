using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePurchaseItemPanel : UISubPanel<DLC5_RogueLikePurchasePanel>
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000082C8 File Offset: 0x000064C8
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000285")]
		public InspectingProductType InspectingProductType
		{
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x4171F0", Offset = "0x415BF0", VA = "0x1804171F0")]
			[CompilerGenerated]
			get
			{
				return InspectingProductType.IngredientsAndBeverage;
			}
			[Token(Token = "0x60015B2")]
			[Address(RVA = "0x417210", Offset = "0x415C10", VA = "0x180417210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000286")]
		public DLC5_RogueLikePurchasePanel.OpenContext PanelOpenContext
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B4")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000082E0 File Offset: 0x000064E0
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000287")]
		private protected int CalculatedPrice
		{
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x45AA90", Offset = "0x459490", VA = "0x18045AA90")]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x60015B6")]
			[Address(RVA = "0x45AB60", Offset = "0x459560", VA = "0x18045AB60")]
			private set
			{
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x458CE0", Offset = "0x4576E0", VA = "0x180458CE0", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x459A60", Offset = "0x458460", VA = "0x180459A60", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x45A4D0", Offset = "0x458ED0", VA = "0x18045A4D0")]
		private void OnSelectAllPressed(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x45A720", Offset = "0x459120", VA = "0x18045A720")]
		private void OnSelectAllReleased(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x45A770", Offset = "0x459170", VA = "0x18045A770")]
		private void SelectAll()
		{
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x457A60", Offset = "0x456460", VA = "0x180457A60")]
		private void BuyAll(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x458D50", Offset = "0x457750", VA = "0x180458D50", Slot = "33")]
		protected virtual int GetProductPriceAfterDiscount(Product product)
		{
			return 0;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x457F50", Offset = "0x456950", VA = "0x180457F50")]
		private void Buy()
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x458D40", Offset = "0x457740", VA = "0x180458D40", Slot = "34")]
		protected virtual int GetFinalFund(int currentFund)
		{
			return 0;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "35")]
		protected virtual void AfterPanelOpen()
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x457910", Offset = "0x456310", VA = "0x180457910", Slot = "36")]
		protected virtual void AfterBuy()
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "37")]
		protected virtual void AfterAddToCart()
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "38")]
		protected virtual void AfterRemoveFromCart()
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x459680", Offset = "0x458080", VA = "0x180459680")]
		private void OnInStoreItemSubmit(ProductReference productReference)
		{
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x4594D0", Offset = "0x457ED0", VA = "0x1804594D0")]
		private void OnInStoreItemSubmitAll(ProductReference productReference)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x45A810", Offset = "0x459210", VA = "0x18045A810", Slot = "39")]
		protected virtual void UpdateBuyButtonInteractable()
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x17000288")]
		private bool CheckCouldNotBuy
		{
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x45AAA0", Offset = "0x4594A0", VA = "0x18045AAA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x459390", Offset = "0x457D90", VA = "0x180459390")]
		private void OnInCartItemSubmit(ProductReference productReference, bool all)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x458DE0", Offset = "0x4577E0", VA = "0x180458DE0")]
		private static void MoveSelectedCore(ProductReference productReference, IStaticGridScrollListUILogicalGroup moveFromControl, [TupleElementNames(new string[] { "product", "amount" })] List<ValueTuple<ProductReference, int>> moveFrom, IStaticGridScrollListUILogicalGroup moveToControl, [TupleElementNames(new string[] { "product", "amount" })] List<ValueTuple<ProductReference, int>> moveTo, bool moveAll)
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x458FD0", Offset = "0x4579D0", VA = "0x180458FD0")]
		private static void Move([TupleElementNames(new string[] { "product", "amount" })] IList<ValueTuple<ProductReference, int>> moveFrom, [TupleElementNames(new string[] { "product", "amount" })] List<ValueTuple<ProductReference, int>> moveTo, bool moveAll, int index)
		{
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x4589F0", Offset = "0x4573F0", VA = "0x1804589F0")]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> Create(GridLayoutGroup layoutGroup, GameObject elementPrefab, Func<DLC5_RogueLikePurchasePanel.OpenContext> getPanelOpenContextCallback, Func<IDescriber> getActiveDescriberCallback, int columns, int rows, [TupleElementNames(new string[] { "product", "amount" })] IReadOnlyList<ValueTuple<ProductReference, int>> products, Action<ProductReference> onSubmit, Action<ProductReference> onSubmitAll)
		{
			return null;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x459F90", Offset = "0x458990", VA = "0x180459F90", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x45A8D0", Offset = "0x4592D0", VA = "0x18045A8D0")]
		private void UpdateNullIndicator()
		{
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x459970", Offset = "0x458370", VA = "0x180459970", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x43ED60", Offset = "0x43D760", VA = "0x18043ED60", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x458820", Offset = "0x457220", VA = "0x180458820", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x45A9B0", Offset = "0x4593B0", VA = "0x18045A9B0")]
		public DLC5_RogueLikePurchaseItemPanel()
		{
		}

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x78")]
		[TupleElementNames(new string[] { "product", "amount" })]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> m_InStoreGroup;

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x80")]
		[TupleElementNames(new string[] { "product", "amount" })]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> m_InCartGroup;

		// Token: 0x0400148E RID: 5262
		[Token(Token = "0x400148E")]
		[FieldOffset(Offset = "0x98")]
		private IDescriber m_ActiveDescriber;

		// Token: 0x0400148F RID: 5263
		[Token(Token = "0x400148F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GridLayoutGroup m_InStoreLayoutGroup;

		// Token: 0x04001490 RID: 5264
		[Token(Token = "0x4001490")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GridLayoutGroup m_InCartLayoutGroup;

		// Token: 0x04001491 RID: 5265
		[Token(Token = "0x4001491")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject m_ElementPrefab;

		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private MonoBehaviour m_DescriberPrefab;

		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup m_DescriberCanvasGroup;

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int m_InStoreColumns;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private int m_InStoreRows;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int m_InCartColumns;

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int m_InCartRows;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TextMeshProUGUI m_InStorageNum;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private TextMeshProUGUI m_PriceNum;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TextMeshProUGUI m_PriceSymbol;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TextMeshProUGUI m_HasOwned;

		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x400149C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x0400149D RID: 5277
		[Token(Token = "0x400149D")]
		[FieldOffset(Offset = "0x100")]
		[TupleElementNames(new string[] { "product", "amount" })]
		private readonly List<ValueTuple<ProductReference, int>> m_InStoreProducts;

		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		[FieldOffset(Offset = "0x108")]
		[TupleElementNames(new string[] { "product", "amount" })]
		protected readonly List<ValueTuple<ProductReference, int>> m_InCartProducts;

		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		[FieldOffset(Offset = "0x110")]
		private int m_CalculatedPrice;

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x114")]
		private float m_ShouldRunBuyAllFunctionOffset;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x118")]
		private CancellationTokenSource m_Source;

		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40014A2")]
		[FieldOffset(Offset = "0x120")]
		private Action m_SelectAllCall;

		// Token: 0x020003D4 RID: 980
		[Token(Token = "0x20003D4")]
		public interface IRogueLikePurchaseDataSource
		{
			// Token: 0x17000289 RID: 649
			// (get) Token: 0x060015DD RID: 5597
			// (set) Token: 0x060015DE RID: 5598
			[Token(Token = "0x17000289")]
			int Fund
			{
				[Token(Token = "0x60015DD")]
				get;
				[Token(Token = "0x60015DE")]
				set;
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x060015DF RID: 5599
			[Token(Token = "0x1700028A")]
			IList<ProductReference> AllProducts
			{
				[Token(Token = "0x60015DF")]
				get;
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x060015E0 RID: 5600
			[Token(Token = "0x1700028B")]
			RogueLikeRunTimeData RogueLikeRunTimeData
			{
				[Token(Token = "0x60015E0")]
				get;
			}
		}

		// Token: 0x020003D5 RID: 981
		[Token(Token = "0x20003D5")]
		private class ProductReferenceCountPairEqualityComparer : IEqualityComparer<ValueTuple<ProductReference, int>>
		{
			// Token: 0x060015E1 RID: 5601 RVA: 0x000083B8 File Offset: 0x000065B8
			[Token(Token = "0x60015E1")]
			[Address(RVA = "0x46B380", Offset = "0x469D80", VA = "0x18046B380", Slot = "4")]
			public bool Equals([TupleElementNames(new string[] { "product", "amount" })] ValueTuple<ProductReference, int> x, [TupleElementNames(new string[] { "product", "amount" })] ValueTuple<ProductReference, int> y)
			{
				return default(bool);
			}

			// Token: 0x060015E2 RID: 5602 RVA: 0x000083D0 File Offset: 0x000065D0
			[Token(Token = "0x60015E2")]
			[Address(RVA = "0x46B3A0", Offset = "0x469DA0", VA = "0x18046B3A0", Slot = "5")]
			public int GetHashCode([TupleElementNames(new string[] { "product", "amount" })] ValueTuple<ProductReference, int> obj)
			{
				return 0;
			}

			// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60015E3")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public ProductReferenceCountPairEqualityComparer()
			{
			}
		}
	}
}

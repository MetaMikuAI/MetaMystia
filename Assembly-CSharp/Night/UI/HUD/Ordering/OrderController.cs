using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.UI.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.UI.HUD.Ordering
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(CanvasGroup))]
	public class OrderController : MonoBehaviour
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		private static OrderController Instance
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x6F6A40", Offset = "0x6F5440", VA = "0x1806F6A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060006A0 RID: 1696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public static event Action<int> OnFocusingDeskCodeChanged
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x6F67F0", Offset = "0x6F51F0", VA = "0x1806F67F0")]
			add
			{
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x6F6AD0", Offset = "0x6F54D0", VA = "0x1806F6AD0")]
			remove
			{
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x6F5400", Offset = "0x6F3E00", VA = "0x1806F5400")]
		public static bool HasValidOrder()
		{
			return default(bool);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x6F4CC0", Offset = "0x6F36C0", VA = "0x1806F4CC0")]
		public static void AddOrder(GuestsManager.OrderBase orderBase)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x6F5D80", Offset = "0x6F4780", VA = "0x1806F5D80")]
		public static void RemoveOrder(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x6F6330", Offset = "0x6F4D30", VA = "0x1806F6330")]
		public static void TryFocusToOrder(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x6F5700", Offset = "0x6F4100", VA = "0x1806F5700")]
		public static void MoveActionPerformed(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x6F6130", Offset = "0x6F4B30", VA = "0x1806F6130")]
		public static void SetPartnerOrderData(int deskCode, PartnerBase.PartnerType? partnerType, Sellable.SellableType sellableType, string debugMessage)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x6F65A0", Offset = "0x6F4FA0", VA = "0x1806F65A0")]
		public static bool TryGetCurrentSelectedDeskCode(out int deskCode)
		{
			return default(bool);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x6F5270", Offset = "0x6F3C70", VA = "0x1806F5270")]
		public static IEnumerable<GuestsManager.OrderBase> GetShowInUIOrders()
		{
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x6F66E0", Offset = "0x6F50E0", VA = "0x1806F66E0")]
		public static void TryUpdateToCurrentOrder()
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x6F54D0", Offset = "0x6F3ED0", VA = "0x1806F54D0")]
		public static bool IsOrderOpen(OrderingElement element)
		{
			return default(bool);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x6F5520", Offset = "0x6F3F20", VA = "0x1806F5520")]
		public static bool IsOrderOpen(GuestsManager.OrderBase order)
		{
			return default(bool);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public static CanvasGroup CanvasGroup
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x6F6900", Offset = "0x6F5300", VA = "0x1806F6900")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public static RectTransform OrderField
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x6F6A80", Offset = "0x6F5480", VA = "0x1806F6A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public static RectTransform GhostField
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x6F69F0", Offset = "0x6F53F0", VA = "0x1806F69F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x6F5450", Offset = "0x6F3E50", VA = "0x1806F5450")]
		public void Initialize()
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		private OrderController.CurrentSelectionIndexHandler CurrentSelectionIndex
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x6F6950", Offset = "0x6F5350", VA = "0x1806F6950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x6F5320", Offset = "0x6F3D20", VA = "0x1806F5320")]
		private bool HasOrderImpl()
		{
			return default(bool);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x6F5370", Offset = "0x6F3D70", VA = "0x1806F5370")]
		private bool HasValidOrderImpl()
		{
			return default(bool);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x6F4790", Offset = "0x6F3190", VA = "0x1806F4790")]
		private void AddOrderImpl(GuestsManager.OrderBase orderBase)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x6F5A40", Offset = "0x6F4440", VA = "0x1806F5A40")]
		private void RemoveOrderImpl(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x6F61C0", Offset = "0x6F4BC0", VA = "0x1806F61C0")]
		private void TryFocusToOrderImpl(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x6F6690", Offset = "0x6F5090", VA = "0x1806F6690")]
		private void TryUpdateToCurrentOrderImpl()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x6F5630", Offset = "0x6F4030", VA = "0x1806F5630")]
		private void MoveActionPerformedImpl(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x6F5EA0", Offset = "0x6F48A0", VA = "0x1806F5EA0")]
		private void SetPartnerOrderDataImpl(int deskCode, PartnerBase.PartnerType? partnerType, Sellable.SellableType sellableType, string debugMessage)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x6F64D0", Offset = "0x6F4ED0", VA = "0x1806F64D0")]
		private bool TryGetCurrentSelectedDeskCodeImpl(out int deskCode)
		{
			return default(bool);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x6F51F0", Offset = "0x6F3BF0", VA = "0x1806F51F0")]
		private IEnumerable<GuestsManager.OrderBase> GetShowInUIOrdersImpl()
		{
			return null;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x6F4E20", Offset = "0x6F3820", VA = "0x1806F4E20")]
		private OrderingElement CreateOrderingElement(GuestsManager.OrderBase orderBase)
		{
			return null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x6F5DE0", Offset = "0x6F47E0", VA = "0x1806F5DE0")]
		private void SetHighlight(OrderingElement orderingElement, PartnerBase.PartnerType? partnerType, Sellable.SellableType sellableType)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x6F5610", Offset = "0x6F4010", VA = "0x1806F5610")]
		private static GuestsManager.OrderBase MapElement(OrderingElement orderingElement)
		{
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x6F5810", Offset = "0x6F4210", VA = "0x1806F5810")]
		private string PrintOrderContent()
		{
			return null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x60006C0")]
		private static bool Match<TListElement, TPredicateElement>(IList<TListElement> list, Func<TListElement, TPredicateElement> mapHandler, Predicate<TPredicateElement> selector, out TListElement matchResult, out int index) where TListElement : class
		{
			return default(bool);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x6F5020", Offset = "0x6F3A20", VA = "0x1806F5020")]
		private int FindValidIndex(int currentIndex, OrderController.FindType findType)
		{
			return 0;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x6F5560", Offset = "0x6F3F60", VA = "0x1806F5560")]
		private bool IsSelectionIndexValid(int index)
		{
			return default(bool);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x6F4D20", Offset = "0x6F3720", VA = "0x1806F4D20", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x6F6760", Offset = "0x6F5160", VA = "0x1806F6760")]
		public OrderController()
		{
		}

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x0")]
		private static OrderController m_UniqueInstance;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<OrderingElement> m_Orders;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x20")]
		private OrderController.CurrentSelectionIndexHandler m_SelectionIndexHandler;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_OrderField;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform m_GhostField;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Sprite m_CookerSprite;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Sprite m_WaitressSprite;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public Sprite m_BarmaidSprite;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup m_CanvasGroup;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x58")]
		private StringBuilder m_StringBuilder;

		// Token: 0x02000113 RID: 275
		[Token(Token = "0x2000113")]
		private class OrderingElementDeskCodeComparer : IComparer<OrderingElement>
		{
			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007D")]
			public static OrderController.OrderingElementDeskCodeComparer Default
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x6F6CF0", Offset = "0x6F56F0", VA = "0x1806F6CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x000039F0 File Offset: 0x00001BF0
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x6F6BE0", Offset = "0x6F55E0", VA = "0x1806F6BE0", Slot = "4")]
			public int Compare(OrderingElement x, OrderingElement y)
			{
				return 0;
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public OrderingElementDeskCodeComparer()
			{
			}
		}

		// Token: 0x02000114 RID: 276
		[Token(Token = "0x2000114")]
		private enum FindType
		{
			// Token: 0x04000691 RID: 1681
			[Token(Token = "0x4000691")]
			Next,
			// Token: 0x04000692 RID: 1682
			[Token(Token = "0x4000692")]
			Previous
		}

		// Token: 0x02000115 RID: 277
		[Token(Token = "0x2000115")]
		private class CurrentSelectionIndexHandler
		{
			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x14000004")]
			public event Action<int> OnFocusingDeskCodeChangedImpl
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x6DE620", Offset = "0x6DD020", VA = "0x1806DE620")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x6DE6D0", Offset = "0x6DD0D0", VA = "0x1806DE6D0")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x6DE5E0", Offset = "0x6DCFE0", VA = "0x1806DE5E0")]
			public CurrentSelectionIndexHandler(IReadOnlyList<OrderingElement> orders)
			{
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060006CC RID: 1740 RVA: 0x00003A08 File Offset: 0x00001C08
			// (set) Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700007E")]
			public int Value
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x3F8D30", Offset = "0x3F7730", VA = "0x1803F8D30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x3F8D90", Offset = "0x3F7790", VA = "0x1803F8D90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x6DE3B0", Offset = "0x6DCDB0", VA = "0x1806DE3B0")]
			public void UpdateSelectionIndex(int newIndex)
			{
			}

			// Token: 0x04000694 RID: 1684
			[Token(Token = "0x4000694")]
			[FieldOffset(Offset = "0x18")]
			private readonly IReadOnlyList<OrderingElement> m_Orders;
		}
	}
}

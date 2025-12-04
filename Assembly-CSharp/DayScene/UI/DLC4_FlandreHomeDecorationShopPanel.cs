using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Serialization;

namespace DayScene.UI
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	[GenerateCleanupMethod]
	public class DLC4_FlandreHomeDecorationShopPanel : UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>
	{
		// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x93A990", Offset = "0x939390", VA = "0x18093A990", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x93A880", Offset = "0x939280", VA = "0x18093A880")]
		private void CloseAndBack()
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x93AEF0", Offset = "0x9398F0", VA = "0x18093AEF0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x93A900", Offset = "0x939300", VA = "0x18093A900", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x93BA20", Offset = "0x93A420", VA = "0x18093BA20")]
		private void UpdateVisual()
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x93AF30", Offset = "0x939930", VA = "0x18093AF30")]
		private void ProcessPerCartVisualColum(RectTransform field, int rowIndex)
		{
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x93B130", Offset = "0x939B30", VA = "0x18093B130")]
		private void ProcessPerRowObject(UIButtonSimple button, FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x93A360", Offset = "0x938D60", VA = "0x18093A360")]
		private void CalculateRowIndex()
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x93A020", Offset = "0x938A20", VA = "0x18093A020")]
		private void AddToCart(int id)
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x93B480", Offset = "0x939E80", VA = "0x18093B480")]
		private void RemoveFromCart(int id)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x93B630", Offset = "0x93A030", VA = "0x18093B630")]
		private void SetPrice()
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x93A1C0", Offset = "0x938BC0", VA = "0x18093A1C0")]
		private void Buy()
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x93A6B0", Offset = "0x9390B0", VA = "0x18093A6B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x93BB90", Offset = "0x93A590", VA = "0x18093BB90")]
		public DLC4_FlandreHomeDecorationShopPanel()
		{
		}

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		private const float CONTENT_WIDTH = 460f;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		private const float CONTENT_SPACING = 16f;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject m_CartObject;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject m_CartRowObject;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("m_CartTransform")]
		[SerializeField]
		private RectTransform m_CartTransformField;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("m_Title")]
		[SerializeField]
		private TextMeshProUGUI m_LeftPrice;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_TotalPrice;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonHold m_ConfirmButton;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private FlandreFurnitureUIComponent[] m_FurnitureArrays;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AdpScrollListAdaptiveComponent scrollerLeft;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AdpScrollListAdaptiveComponent scrollerRight;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0xC0")]
		private readonly List<GameObject> allInCartColumnInstances;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0xC8")]
		private readonly Dictionary<int, List<GameObject>> allInCartInstances;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Dictionary<int, int> furnituresInCart;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<int> furnituresInCartOrder;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>> furnituresInCartRowIndex;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0xE8")]
		private readonly UILogicalGroupT<int> m_CartGroup;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0xF0")]
		private readonly UILogicalGroupT<int> m_ShelfGroup;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0xF8")]
		private int currentPrice;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x100")]
		private GroupedUILogicalGroup m_AllGroups;
	}
}

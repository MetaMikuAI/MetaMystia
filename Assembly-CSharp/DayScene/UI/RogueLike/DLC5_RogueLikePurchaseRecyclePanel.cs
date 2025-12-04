using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePurchaseRecyclePanel : DLC5_RogueLikePurchaseItemPanel
	{
		// Token: 0x060016F7 RID: 5879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x45FA20", Offset = "0x45E420", VA = "0x18045FA20", Slot = "35")]
		protected override void AfterPanelOpen()
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x45F9A0", Offset = "0x45E3A0", VA = "0x18045F9A0", Slot = "36")]
		protected override void AfterBuy()
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x45FB70", Offset = "0x45E570", VA = "0x18045FB70", Slot = "33")]
		protected override int GetProductPriceAfterDiscount(Product product)
		{
			return 0;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x45FBA0", Offset = "0x45E5A0", VA = "0x18045FBA0", Slot = "39")]
		protected override void UpdateBuyButtonInteractable()
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x45FB60", Offset = "0x45E560", VA = "0x18045FB60", Slot = "34")]
		protected override int GetFinalFund(int currentFund)
		{
			return 0;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x45FB50", Offset = "0x45E550", VA = "0x18045FB50", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x45FC10", Offset = "0x45E610", VA = "0x18045FC10")]
		public DLC5_RogueLikePurchaseRecyclePanel()
		{
		}
	}
}

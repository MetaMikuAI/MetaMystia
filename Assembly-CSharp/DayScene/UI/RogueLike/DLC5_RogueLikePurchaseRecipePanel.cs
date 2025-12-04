using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikePurchaseRecipePanel : DLC5_RogueLikePurchaseItemPanel
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x45F360", Offset = "0x45DD60", VA = "0x18045F360", Slot = "35")]
		protected override void AfterPanelOpen()
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x45F700", Offset = "0x45E100", VA = "0x18045F700")]
		private void UpdateRecipeCartBG()
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x45F1F0", Offset = "0x45DBF0", VA = "0x18045F1F0", Slot = "36")]
		protected override void AfterBuy()
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x45F520", Offset = "0x45DF20", VA = "0x18045F520")]
		private void UpdateCartTitle()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x45F1E0", Offset = "0x45DBE0", VA = "0x18045F1E0", Slot = "37")]
		protected override void AfterAddToCart()
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x45F1E0", Offset = "0x45DBE0", VA = "0x18045F1E0", Slot = "38")]
		protected override void AfterRemoveFromCart()
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x437070", Offset = "0x435A70", VA = "0x180437070", Slot = "34")]
		protected override int GetFinalFund(int currentFund)
		{
			return 0;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x45F470", Offset = "0x45DE70", VA = "0x18045F470", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x45F910", Offset = "0x45E310", VA = "0x18045F910")]
		public DLC5_RogueLikePurchaseRecipePanel()
		{
		}

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject m_StackObject;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private RectTransform m_StackRect;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private TextMeshProUGUI m_FreeIngText;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<GameObject> m_AllStackInstances;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x148")]
		private int m_RemainingCount;
	}
}

using System;
using System.Collections.Generic;
using Common.UI.DLC5_EllenShopPanel;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DE6 RID: 3558
	[Token(Token = "0x2000DE6")]
	public class EllenShopDescriber : SellableDescriber
	{
		// Token: 0x06005355 RID: 21333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005355")]
		[Address(RVA = "0x7FD150", Offset = "0x7FBB50", VA = "0x1807FD150")]
		public void Describe(DLC5_EllenShopPanel.ProductCondition product)
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005356")]
		[Address(RVA = "0x7FD760", Offset = "0x7FC160", VA = "0x1807FD760")]
		public EllenShopDescriber()
		{
		}

		// Token: 0x04004E56 RID: 20054
		[Token(Token = "0x4004E56")]
		[FieldOffset(Offset = "0x130")]
		[Header("EllenShop")]
		public TextMeshProUGUI amount;

		// Token: 0x04004E57 RID: 20055
		[Token(Token = "0x4004E57")]
		[FieldOffset(Offset = "0x138")]
		public GameObject extraCurrencyTextElement;

		// Token: 0x04004E58 RID: 20056
		[Token(Token = "0x4004E58")]
		[FieldOffset(Offset = "0x140")]
		public Transform extraCurrencyTextTransform;

		// Token: 0x04004E59 RID: 20057
		[Token(Token = "0x4004E59")]
		[FieldOffset(Offset = "0x148")]
		private List<GameObject> extraTextInstances;
	}
}

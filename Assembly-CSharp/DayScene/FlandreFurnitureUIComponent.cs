using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	[GenerateCleanupMethod]
	public class FlandreFurnitureUIComponent : MonoBehaviour
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00005910 File Offset: 0x00003B10
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015C")]
		public int Price
		{
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x8EB630", Offset = "0x8EA030", VA = "0x1808EB630")]
			set
			{
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x3EDAB0", Offset = "0x3EC4B0", VA = "0x1803EDAB0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public FlandreFurnitureUIComponent()
		{
		}

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x18")]
		public int furnitureId;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x20")]
		public UIButtonSimple button;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_PriceText;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x30")]
		private int price;
	}
}

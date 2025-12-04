using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using GameData.Core;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	[GenerateCleanupMethod]
	public class SellableDescriber : IngredientDescriber, ITypedDescriber<Sellable>, IDescriber, ITypedDescriber<TradableObjectBase>
	{
		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06005440 RID: 21568 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005441 RID: 21569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000034")]
		public event Action OnToggleToSellable
		{
			[Token(Token = "0x6005440")]
			[Address(RVA = "0x845150", Offset = "0x843B50", VA = "0x180845150")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005441")]
			[Address(RVA = "0x845200", Offset = "0x843C00", VA = "0x180845200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005442")]
		[Address(RVA = "0x844710", Offset = "0x843110", VA = "0x180844710", Slot = "6")]
		protected override void OnPreload()
		{
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005443")]
		[Address(RVA = "0x844670", Offset = "0x843070", VA = "0x180844670", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005444")]
		[Address(RVA = "0x844570", Offset = "0x842F70", VA = "0x180844570", Slot = "12")]
		public void Describe(Sellable detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005445")]
		[Address(RVA = "0x8441E0", Offset = "0x842BE0", VA = "0x1808441E0")]
		public void Describe(Sellable detail)
		{
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005446")]
		[Address(RVA = "0x8444A0", Offset = "0x842EA0", VA = "0x1808444A0")]
		public void Describe(Sellable detail, Sprite bgSprite)
		{
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005447")]
		[Address(RVA = "0x844160", Offset = "0x842B60", VA = "0x180844160")]
		public void DescribeRecipe(Recipe recipe)
		{
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005448")]
		[Address(RVA = "0x8448D0", Offset = "0x8432D0", VA = "0x1808448D0")]
		private void ShowSellableProperty(Sellable detail)
		{
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005449")]
		[Address(RVA = "0x844580", Offset = "0x842F80", VA = "0x180844580", Slot = "7")]
		protected override void HideElements()
		{
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544A")]
		[Address(RVA = "0x844EF0", Offset = "0x8438F0", VA = "0x180844EF0")]
		public void ToggleVisualForSellables()
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544B")]
		[Address(RVA = "0x8442C0", Offset = "0x842CC0", VA = "0x1808442C0", Slot = "13")]
		public void Describe(TradableObjectBase data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544C")]
		[Address(RVA = "0x843FE0", Offset = "0x8429E0", VA = "0x180843FE0", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544D")]
		[Address(RVA = "0x844FC0", Offset = "0x8439C0", VA = "0x180844FC0")]
		public SellableDescriber()
		{
		}

		// Token: 0x04004F28 RID: 20264
		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Sellable")]
		public GameObject foodTagObjectParent;

		// Token: 0x04004F29 RID: 20265
		[Token(Token = "0x4004F29")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject bevTagObjectParent;

		// Token: 0x04004F2A RID: 20266
		[Token(Token = "0x4004F2A")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject bannedTagObjectParent;

		// Token: 0x04004F2B RID: 20267
		[Token(Token = "0x4004F2B")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject addedTagObjectParent;

		// Token: 0x04004F2C RID: 20268
		[Token(Token = "0x4004F2C")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject removedTagObjectParent;

		// Token: 0x04004F2D RID: 20269
		[Token(Token = "0x4004F2D")]
		[FieldOffset(Offset = "0xE8")]
		public Image addModifyParent;

		// Token: 0x04004F2E RID: 20270
		[Token(Token = "0x4004F2E")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject[] sellableVisuals;

		// Token: 0x04004F2F RID: 20271
		[Token(Token = "0x4004F2F")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<GameObject> addedTagInstances;

		// Token: 0x04004F30 RID: 20272
		[Token(Token = "0x4004F30")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<GameObject> banTagInstances;

		// Token: 0x04004F31 RID: 20273
		[Token(Token = "0x4004F31")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<GameObject> bevTagInstances;

		// Token: 0x04004F32 RID: 20274
		[Token(Token = "0x4004F32")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<GameObject> foodTagInstances;

		// Token: 0x04004F33 RID: 20275
		[Token(Token = "0x4004F33")]
		[FieldOffset(Offset = "0x118")]
		private readonly List<GameObject> removedTagInstances;

		// Token: 0x04004F34 RID: 20276
		[Token(Token = "0x4004F34")]
		[FieldOffset(Offset = "0x120")]
		private Sellable.SellableType poolType;

		// Token: 0x04004F35 RID: 20277
		[Token(Token = "0x4004F35")]
		[FieldOffset(Offset = "0x124")]
		private bool m_IsSellable;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DEA RID: 3562
	[Token(Token = "0x2000DEA")]
	[GenerateCleanupMethod]
	public class IngredientDescriber : ObjectLanguageBaseDescriber, ITypedDescriber<Ingredient>, IDescriber
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06005360 RID: 21344 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005361 RID: 21345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002F")]
		public event Action OnToggleToIngredient
		{
			[Token(Token = "0x6005360")]
			[Address(RVA = "0x7FDF30", Offset = "0x7FC930", VA = "0x1807FDF30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005361")]
			[Address(RVA = "0x7FDFE0", Offset = "0x7FC9E0", VA = "0x1807FDFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005362")]
		[Address(RVA = "0x7FDD40", Offset = "0x7FC740", VA = "0x1807FDD40", Slot = "6")]
		protected override void OnPreload()
		{
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005363")]
		[Address(RVA = "0x7FDCE0", Offset = "0x7FC6E0", VA = "0x1807FDCE0", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005364")]
		[Address(RVA = "0x7FD920", Offset = "0x7FC320", VA = "0x1807FD920", Slot = "11")]
		public void Describe(Ingredient detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005365")]
		[Address(RVA = "0x7FD930", Offset = "0x7FC330", VA = "0x1807FD930")]
		public void Describe(Ingredient detail)
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005366")]
		[Address(RVA = "0x7FDC00", Offset = "0x7FC600", VA = "0x1807FDC00", Slot = "7")]
		protected override void HideElements()
		{
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005367")]
		[Address(RVA = "0x7FDDD0", Offset = "0x7FC7D0", VA = "0x1807FDDD0")]
		public void ToggleVisualForIngredient()
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005368")]
		[Address(RVA = "0x7FD840", Offset = "0x7FC240", VA = "0x1807FD840", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005369")]
		[Address(RVA = "0x7FDEA0", Offset = "0x7FC8A0", VA = "0x1807FDEA0")]
		public IngredientDescriber()
		{
		}

		// Token: 0x04004E60 RID: 20064
		[Token(Token = "0x4004E60")]
		[FieldOffset(Offset = "0x80")]
		[Header("Ingredient")]
		public TextMeshProUGUI price;

		// Token: 0x04004E61 RID: 20065
		[Token(Token = "0x4004E61")]
		[FieldOffset(Offset = "0x88")]
		public bool doNotDescribePriceSymbol;

		// Token: 0x04004E62 RID: 20066
		[Token(Token = "0x4004E62")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI tradableLevel;

		// Token: 0x04004E63 RID: 20067
		[Token(Token = "0x4004E63")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ingredientTagObjectParent;

		// Token: 0x04004E64 RID: 20068
		[Token(Token = "0x4004E64")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform tagField;

		// Token: 0x04004E65 RID: 20069
		[Token(Token = "0x4004E65")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject[] ingredientVisuals;

		// Token: 0x04004E66 RID: 20070
		[Token(Token = "0x4004E66")]
		[FieldOffset(Offset = "0xB0")]
		protected readonly List<GameObject> ingredientTagInstances;
	}
}

using System;
using System.Collections.Generic;
using System.Threading;
using Common.UI;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLike_RecipeDescriber : SellableDescriber, ITypedDescriber<Recipe>, IDescriber
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x4769B0", Offset = "0x4753B0", VA = "0x1804769B0", Slot = "14")]
		public void Describe(Recipe detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x476CA0", Offset = "0x4756A0", VA = "0x180476CA0")]
		private static void InitializeElement(UIElementCluster elements, int ingredient)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x476DD0", Offset = "0x4757D0", VA = "0x180476DD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x4768D0", Offset = "0x4752D0", VA = "0x1804768D0", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x476DF0", Offset = "0x4757F0", VA = "0x180476DF0")]
		public DLC5_RogueLike_RecipeDescriber()
		{
		}

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x130")]
		public GameObject ingredeintObjectParent;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0x138")]
		public RectTransform ingredientField;

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x140")]
		public TextMeshProUGUI cookTime;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI cookTime2;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0x150")]
		public TextMeshProUGUI cookerName;

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0x158")]
		public Image cookerVisual;

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<GameObject> ingredientObjectInstances;
	}
}

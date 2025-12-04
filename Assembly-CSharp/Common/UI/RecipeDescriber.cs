using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E0F RID: 3599
	[Token(Token = "0x2000E0F")]
	[GenerateCleanupMethod]
	public class RecipeDescriber : SellableDescriber, ITypedDescriber<Recipe>, IDescriber
	{
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06005432 RID: 21554 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005433 RID: 21555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000033")]
		public event Action OnToggleToRecipe
		{
			[Token(Token = "0x6005432")]
			[Address(RVA = "0x843E80", Offset = "0x842880", VA = "0x180843E80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005433")]
			[Address(RVA = "0x843F30", Offset = "0x842930", VA = "0x180843F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005434")]
		[Address(RVA = "0x843400", Offset = "0x841E00", VA = "0x180843400", Slot = "14")]
		public void Describe(Recipe detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005435")]
		[Address(RVA = "0x843410", Offset = "0x841E10", VA = "0x180843410")]
		public void Describe(Recipe detail)
		{
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005436")]
		[Address(RVA = "0x843990", Offset = "0x842390", VA = "0x180843990", Slot = "6")]
		protected override void OnPreload()
		{
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005437")]
		[Address(RVA = "0x8438B0", Offset = "0x8422B0", VA = "0x1808438B0", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005438")]
		[Address(RVA = "0x843780", Offset = "0x842180", VA = "0x180843780")]
		private void InitializeElement(UIElementCluster elements, int ingredient)
		{
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005439")]
		[Address(RVA = "0x843640", Offset = "0x842040", VA = "0x180843640", Slot = "7")]
		protected override void HideElements()
		{
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543A")]
		[Address(RVA = "0x843BB0", Offset = "0x8425B0", VA = "0x180843BB0", Slot = "15")]
		public virtual void ToggleVisualForRecipes()
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543B")]
		[Address(RVA = "0x8431E0", Offset = "0x841BE0", VA = "0x1808431E0", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543C")]
		[Address(RVA = "0x843C90", Offset = "0x842690", VA = "0x180843C90")]
		public RecipeDescriber()
		{
		}

		// Token: 0x04004F1F RID: 20255
		[Token(Token = "0x4004F1F")]
		[FieldOffset(Offset = "0x130")]
		[Header("Recipe")]
		public GameObject ingredeintObjectParent;

		// Token: 0x04004F20 RID: 20256
		[Token(Token = "0x4004F20")]
		[FieldOffset(Offset = "0x138")]
		public RectTransform ingredientField;

		// Token: 0x04004F21 RID: 20257
		[Token(Token = "0x4004F21")]
		[FieldOffset(Offset = "0x140")]
		public TextMeshProUGUI cookTime;

		// Token: 0x04004F22 RID: 20258
		[Token(Token = "0x4004F22")]
		[FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI cookerName;

		// Token: 0x04004F23 RID: 20259
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x150")]
		public Image cookerVisual;

		// Token: 0x04004F24 RID: 20260
		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x158")]
		public GameObject[] recipeVisuals;

		// Token: 0x04004F25 RID: 20261
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x160")]
		private List<GameObject> ingredientObjectInstances;
	}
}

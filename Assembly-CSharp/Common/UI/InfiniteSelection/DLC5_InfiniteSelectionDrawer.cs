using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x02000F6B RID: 3947
	[Token(Token = "0x2000F6B")]
	[GenerateCleanupMethod]
	public class DLC5_InfiniteSelectionDrawer : MonoBehaviour
	{
		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005CBE RID: 23742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D05")]
		public UIButtonSimple Button
		{
			[Token(Token = "0x6005CBD")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CBE")]
			[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x8A7520", Offset = "0x8A5F20", VA = "0x1808A7520")]
		public void SetValid(bool isValid)
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x8A7590", Offset = "0x8A5F90", VA = "0x1808A7590")]
		public void UpdateVisual(int? currentActiveIngredientId, bool noAnimation)
		{
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x3EEA30", Offset = "0x3ED430", VA = "0x1803EEA30", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DLC5_InfiniteSelectionDrawer()
		{
		}

		// Token: 0x040055E1 RID: 21985
		[Token(Token = "0x40055E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup m_ValidGroup;

		// Token: 0x040055E2 RID: 21986
		[Token(Token = "0x40055E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup m_InValidGroup;

		// Token: 0x040055E3 RID: 21987
		[Token(Token = "0x40055E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup m_LightCanvasGroup;

		// Token: 0x040055E4 RID: 21988
		[Token(Token = "0x40055E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup m_IngredientCanvasGroup;

		// Token: 0x040055E5 RID: 21989
		[Token(Token = "0x40055E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_IngredientIcon;
	}
}

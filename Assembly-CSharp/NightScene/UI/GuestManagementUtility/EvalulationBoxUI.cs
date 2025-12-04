using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020006C0 RID: 1728
	[Token(Token = "0x20006C0")]
	[GenerateCleanupMethod]
	public class EvalulationBoxUI : DialogBoxUI
	{
		// Token: 0x060028DB RID: 10459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x546D30", Offset = "0x545730", VA = "0x180546D30")]
		public IEnumerator SetMessage(string message, GuestGroupController.EvaluationResult evaluationType, Transform followTarget)
		{
			return null;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x546DF0", Offset = "0x5457F0", VA = "0x180546DF0")]
		private void SetSkin(EvalulationBoxUI.EvaluationBoxSkin skin, bool shouldShowHeat = false)
		{
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x546C90", Offset = "0x545690", VA = "0x180546C90", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public EvalulationBoxUI()
		{
		}

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x30")]
		public EvalulationBoxUI.EvaluationBoxSkin exBadSkin;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x48")]
		public EvalulationBoxUI.EvaluationBoxSkin badSkin;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x60")]
		public EvalulationBoxUI.EvaluationBoxSkin normalSkin;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x78")]
		public EvalulationBoxUI.EvaluationBoxSkin goodSkin;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x90")]
		public EvalulationBoxUI.EvaluationBoxSkin exGoodSkin;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0xA8")]
		public Image box;

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[FieldOffset(Offset = "0xB0")]
		public Image handle;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0xB8")]
		public Image head;

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0xC0")]
		public Image heart;

		// Token: 0x020006C1 RID: 1729
		[Token(Token = "0x20006C1")]
		[Serializable]
		public struct EvaluationBoxSkin
		{
			// Token: 0x04002554 RID: 9556
			[Token(Token = "0x4002554")]
			[FieldOffset(Offset = "0x0")]
			public Sprite box;

			// Token: 0x04002555 RID: 9557
			[Token(Token = "0x4002555")]
			[FieldOffset(Offset = "0x8")]
			public Sprite handle;

			// Token: 0x04002556 RID: 9558
			[Token(Token = "0x4002556")]
			[FieldOffset(Offset = "0x10")]
			public Sprite head;
		}
	}
}

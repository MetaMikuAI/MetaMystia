using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	[GenerateCleanupMethod]
	public class IncomeControllerYuyuko : IncomeControllerBase
	{
		// Token: 0x060029F2 RID: 10738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x5845E0", Offset = "0x582FE0", VA = "0x1805845E0")]
		private void SetText(string value)
		{
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x5839E0", Offset = "0x5823E0", VA = "0x1805839E0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x583C70", Offset = "0x582670", VA = "0x180583C70")]
		public void SetContext(string context, int currentValue, int maxValue, IncomeControllerYuyuko.Phase phase)
		{
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x584410", Offset = "0x582E10", VA = "0x180584410")]
		public void SetTargetProgress(int targetValue)
		{
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x5844D0", Offset = "0x582ED0", VA = "0x1805844D0")]
		public void SetTargetTime(float progress)
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x5843C0", Offset = "0x582DC0", VA = "0x1805843C0")]
		public void SetTargetProgressImmediate(int targetValue)
		{
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x584640", Offset = "0x583040", VA = "0x180584640")]
		private void TryUpdateData()
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x584820", Offset = "0x583220", VA = "0x180584820")]
		private void UpdateVisual()
		{
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x583BF0", Offset = "0x5825F0", VA = "0x180583BF0")]
		private IEnumerator OnUpdateFund()
		{
			return null;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x583920", Offset = "0x582320", VA = "0x180583920", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x584B60", Offset = "0x583560", VA = "0x180584B60")]
		public IncomeControllerYuyuko()
		{
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x584700", Offset = "0x583100", VA = "0x180584700")]
		[CompilerGenerated]
		private void <Initialize>g__SetTime|28_0(float progress)
		{
		}

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		private const int CHANGE_AMOUNT = 5;

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x18")]
		public Image progressBar1;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x20")]
		public Image progressBar2;

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x28")]
		public Image timeBar;

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI text1;

		// Token: 0x04002666 RID: 9830
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI progressLiteral;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI valueCurrent;

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI valueTotal;

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x50")]
		public Color32 phase1TitleColor;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x54")]
		public Color32 phase2TitleColor;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x58")]
		public Color32 phase3TitleColor;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x5C")]
		public Color32 phase1ProgressLiteralColor;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x60")]
		public Color32 phase2ProgressLiteralColor;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x64")]
		public Color32 phase3ProgressLiteralColor;

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x68")]
		public Color32 phase1Bar1Color;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x6C")]
		public Color32 phase1Bar2Color;

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x70")]
		public Color32 phase2Bar1Color;

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x74")]
		public Color32 phase2Bar2Color;

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x78")]
		public Color32 phase3Bar1Color;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x7C")]
		public Color32 phase3Bar2Color;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x80")]
		private int currentProgress;

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x84")]
		private bool invert;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x88")]
		private int maxValue;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine onUpdatingData;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x98")]
		private string targetContext;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0xA0")]
		private int targetProgress;

		// Token: 0x020006E9 RID: 1769
		[Token(Token = "0x20006E9")]
		public enum Phase : byte
		{
			// Token: 0x0400267C RID: 9852
			[Token(Token = "0x400267C")]
			Phase1,
			// Token: 0x0400267D RID: 9853
			[Token(Token = "0x400267D")]
			Phase2,
			// Token: 0x0400267E RID: 9854
			[Token(Token = "0x400267E")]
			Phase3
		}
	}
}

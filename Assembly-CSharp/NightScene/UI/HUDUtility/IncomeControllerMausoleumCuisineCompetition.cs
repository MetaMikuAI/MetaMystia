using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	[GenerateCleanupMethod]
	public class IncomeControllerMausoleumCuisineCompetition : IncomeController
	{
		// Token: 0x060029C9 RID: 10697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x54B970", Offset = "0x54A370", VA = "0x18054B970", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x54BDB0", Offset = "0x54A7B0", VA = "0x18054BDB0", Slot = "6")]
		protected override void OnFundUpdate()
		{
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x54BE30", Offset = "0x54A830", VA = "0x18054BE30")]
		public void SetTargetFund(int targetAmount)
		{
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x54B8F0", Offset = "0x54A2F0", VA = "0x18054B8F0", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IncomeControllerMausoleumCuisineCompetition()
		{
		}

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		[FieldOffset(Offset = "0x28")]
		public Image cross;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x30")]
		public Image check;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI targetAmountText;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI targetAmountText2;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI currentAmountText2;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x50")]
		private int targetAmount;
	}
}

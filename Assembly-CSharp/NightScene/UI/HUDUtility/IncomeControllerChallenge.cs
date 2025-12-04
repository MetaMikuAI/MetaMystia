using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	[GenerateCleanupMethod]
	public class IncomeControllerChallenge : IncomeController
	{
		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x5472A0", Offset = "0x545CA0", VA = "0x1805472A0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x547530", Offset = "0x545F30", VA = "0x180547530", Slot = "6")]
		protected override void OnFundUpdate()
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x547580", Offset = "0x545F80", VA = "0x180547580")]
		public void SetSpellMode(bool on)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x547650", Offset = "0x546050", VA = "0x180547650")]
		public void UpdateSpellCount(int current, int total)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x5475E0", Offset = "0x545FE0", VA = "0x1805475E0")]
		public void SetTargetFund(int targetAmount)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x547200", Offset = "0x545C00", VA = "0x180547200", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IncomeControllerChallenge()
		{
		}

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x28")]
		public Image cross;

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x30")]
		public Image check;

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x38")]
		public Image crossSpellCard;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x40")]
		public Image checkSpellCard;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI targetAmountText;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform spellCardCollectionParent;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI spellCardCollectionAmountText;

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x60")]
		private int targetAmount;
	}
}

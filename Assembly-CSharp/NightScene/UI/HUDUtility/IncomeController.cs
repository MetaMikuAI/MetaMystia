using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.Serialization;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	[GenerateCleanupMethod]
	public class IncomeController : IncomeControllerBase
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x54BF10", Offset = "0x54A910", VA = "0x18054BF10", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x54C1A0", Offset = "0x54ABA0", VA = "0x18054C1A0")]
		public void SetFund(int amount)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		protected virtual void OnFundUpdate()
		{
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x54C330", Offset = "0x54AD30", VA = "0x18054C330")]
		private void UpdateFundVisual()
		{
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IncomeController()
		{
		}

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		private const float ChangeDuration = 1f;

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("text")]
		public TextMeshProUGUI m_Text;

		// Token: 0x040025CB RID: 9675
		[Token(Token = "0x40025CB")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFund;

		// Token: 0x040025CC RID: 9676
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0x24")]
		protected int TargetFund;
	}
}

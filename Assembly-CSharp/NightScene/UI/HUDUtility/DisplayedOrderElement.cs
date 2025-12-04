using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	[GenerateCleanupMethod]
	public class DisplayedOrderElement : MonoBehaviour
	{
		// Token: 0x170005DC RID: 1500
		// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DC")]
		[CleanupIgnore]
		public Sprite Indicator
		{
			[Token(Token = "0x6002A07")]
			[Address(RVA = "0x5808B0", Offset = "0x57F2B0", VA = "0x1805808B0")]
			set
			{
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x580520", Offset = "0x57EF20", VA = "0x180580520")]
		public void Initialize(Sprite first, Sprite second, Color fg, Color bg, Sprite trimBack, Sprite trimFront)
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x580790", Offset = "0x57F190", VA = "0x180580790")]
		public void Initialize(Sprite single, DisplayedOrderElement.IndicatorPosition indicatorPosition)
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x580870", Offset = "0x57F270", VA = "0x180580870")]
		public void SetHighlight(Sprite indicatorVisual)
		{
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x580480", Offset = "0x57EE80", VA = "0x180580480", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DisplayedOrderElement()
		{
		}

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x18")]
		public Image first;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x20")]
		public Image second;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x28")]
		public Image third;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x30")]
		public Image fg;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x38")]
		public Image bg;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0x40")]
		public Image trimFront;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x48")]
		public Image trimBack;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x50")]
		public Image statusIndicatorUp;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x58")]
		public Image statusIndicatorDown;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x60")]
		private DisplayedOrderElement.IndicatorPosition indicatorPosition;

		// Token: 0x020006EC RID: 1772
		[Token(Token = "0x20006EC")]
		public enum IndicatorPosition
		{
			// Token: 0x0400268D RID: 9869
			[Token(Token = "0x400268D")]
			Up,
			// Token: 0x0400268E RID: 9870
			[Token(Token = "0x400268E")]
			Down
		}
	}
}

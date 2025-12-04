using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	public class NS_MGuest_MVT_ToSeat_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BB2 RID: 11186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x5E11F0", Offset = "0x5DFBF0", VA = "0x1805E11F0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_MVT_ToSeat_Behaviour()
		{
		}

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x10")]
		public int deskCode;

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x20")]
		public int mood;

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldWaitForFinish;
	}
}

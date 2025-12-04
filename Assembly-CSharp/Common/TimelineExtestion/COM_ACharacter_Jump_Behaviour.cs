using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001005 RID: 4101
	[Token(Token = "0x2001005")]
	public class COM_ACharacter_Jump_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F2D RID: 24365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0x8BB3E0", Offset = "0x8B9DE0", VA = "0x1808BB3E0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Jump_Behaviour()
		{
		}

		// Token: 0x04005829 RID: 22569
		[Token(Token = "0x4005829")]
		[FieldOffset(Offset = "0x10")]
		public float gravity;

		// Token: 0x0400582A RID: 22570
		[Token(Token = "0x400582A")]
		[FieldOffset(Offset = "0x14")]
		public int jumpCount;

		// Token: 0x0400582B RID: 22571
		[Token(Token = "0x400582B")]
		[FieldOffset(Offset = "0x18")]
		public float jumpHeight;

		// Token: 0x0400582C RID: 22572
		[Token(Token = "0x400582C")]
		[FieldOffset(Offset = "0x1C")]
		public float jumpInterval;

		// Token: 0x0400582D RID: 22573
		[Token(Token = "0x400582D")]
		[FieldOffset(Offset = "0x20")]
		public string label;

		// Token: 0x0400582E RID: 22574
		[Token(Token = "0x400582E")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldWaitForFinish;

		// Token: 0x0400582F RID: 22575
		[Token(Token = "0x400582F")]
		[FieldOffset(Offset = "0x2C")]
		public float startPoint;
	}
}

using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001027 RID: 4135
	[Token(Token = "0x2001027")]
	public class COM_LogicBranch_IsSwitchPlatform_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F77 RID: 24439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x8BFEB0", Offset = "0x8BE8B0", VA = "0x1808BFEB0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_LogicBranch_IsSwitchPlatform_Behaviour()
		{
		}

		// Token: 0x0400586B RID: 22635
		[Token(Token = "0x400586B")]
		[FieldOffset(Offset = "0x10")]
		public int trueAddFrames;

		// Token: 0x0400586C RID: 22636
		[Token(Token = "0x400586C")]
		[FieldOffset(Offset = "0x14")]
		public int falseAddFrames;
	}
}

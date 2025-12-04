using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200101C RID: 4124
	[Token(Token = "0x200101C")]
	public class COM_DelayForSeconds_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F61 RID: 24417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x8BF240", Offset = "0x8BDC40", VA = "0x1808BF240", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_DelayForSeconds_Behaviour()
		{
		}

		// Token: 0x04005863 RID: 22627
		[Token(Token = "0x4005863")]
		[FieldOffset(Offset = "0x10")]
		public float delayDuration;
	}
}

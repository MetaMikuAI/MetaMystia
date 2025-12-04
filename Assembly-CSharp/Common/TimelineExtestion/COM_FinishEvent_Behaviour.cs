using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200102A RID: 4138
	[Token(Token = "0x200102A")]
	public class COM_FinishEvent_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F7D RID: 24445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x8BF400", Offset = "0x8BDE00", VA = "0x1808BF400", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_FinishEvent_Behaviour()
		{
		}

		// Token: 0x04005870 RID: 22640
		[Token(Token = "0x4005870")]
		[FieldOffset(Offset = "0x10")]
		public string eventName;
	}
}

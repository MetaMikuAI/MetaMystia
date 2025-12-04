using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200101D RID: 4125
	[Token(Token = "0x200101D")]
	public class COM_SetPlayerInput_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x8C1100", Offset = "0x8BFB00", VA = "0x1808C1100", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_SetPlayerInput_Behaviour()
		{
		}

		// Token: 0x04005864 RID: 22628
		[Token(Token = "0x4005864")]
		[FieldOffset(Offset = "0x10")]
		public bool enabled;
	}
}

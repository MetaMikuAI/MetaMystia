using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001002 RID: 4098
	[Token(Token = "0x2001002")]
	public class COM_SetPlayerPref_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F26 RID: 24358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F26")]
		[Address(RVA = "0x8C1270", Offset = "0x8BFC70", VA = "0x1808C1270", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F27")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_SetPlayerPref_Behaviour()
		{
		}

		// Token: 0x04005821 RID: 22561
		[Token(Token = "0x4005821")]
		[FieldOffset(Offset = "0x10")]
		public string playerPrefLabel;
	}
}

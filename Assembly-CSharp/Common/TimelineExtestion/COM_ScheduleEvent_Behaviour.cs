using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001029 RID: 4137
	[Token(Token = "0x2001029")]
	public class COM_ScheduleEvent_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F7B RID: 24443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x8C0FA0", Offset = "0x8BF9A0", VA = "0x1808C0FA0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ScheduleEvent_Behaviour()
		{
		}

		// Token: 0x0400586F RID: 22639
		[Token(Token = "0x400586F")]
		[FieldOffset(Offset = "0x10")]
		public string eventName;
	}
}

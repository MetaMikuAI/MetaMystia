using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001025 RID: 4133
	[Token(Token = "0x2001025")]
	public class COM_OverrideBGM_PauseOrResume_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F73 RID: 24435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x8C0960", Offset = "0x8BF360", VA = "0x1808C0960", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_OverrideBGM_PauseOrResume_Behaviour()
		{
		}

		// Token: 0x0400586A RID: 22634
		[Token(Token = "0x400586A")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldResume;
	}
}

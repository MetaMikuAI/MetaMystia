using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001001 RID: 4097
	[Token(Token = "0x2001001")]
	public class COM_LogicBranch_OnlyForSkipTutorial_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F24 RID: 24356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x8C0060", Offset = "0x8BEA60", VA = "0x1808C0060", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F25")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_LogicBranch_OnlyForSkipTutorial_Behaviour()
		{
		}

		// Token: 0x04005820 RID: 22560
		[Token(Token = "0x4005820")]
		[FieldOffset(Offset = "0x10")]
		public int skipSkipTutorialFrames;
	}
}

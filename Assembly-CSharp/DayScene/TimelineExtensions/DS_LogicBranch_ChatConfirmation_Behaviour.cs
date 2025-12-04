using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	public class DS_LogicBranch_ChatConfirmation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x497E10", Offset = "0x496810", VA = "0x180497E10", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_LogicBranch_ChatConfirmation_Behaviour()
		{
		}

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0x10")]
		public int acceptAddFrames;

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x14")]
		public int refuseAddFrames;
	}
}

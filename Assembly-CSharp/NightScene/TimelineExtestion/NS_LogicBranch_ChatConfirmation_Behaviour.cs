using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	public class NS_LogicBranch_ChatConfirmation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x5E0480", Offset = "0x5DEE80", VA = "0x1805E0480", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_LogicBranch_ChatConfirmation_Behaviour()
		{
		}

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x10")]
		public int acceptAddFrames;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x14")]
		public int refuseAddFrames;
	}
}

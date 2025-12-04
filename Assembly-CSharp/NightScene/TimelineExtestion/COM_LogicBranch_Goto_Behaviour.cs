using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	public class COM_LogicBranch_Goto_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BBE RID: 11198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBE")]
		[Address(RVA = "0x5DFB20", Offset = "0x5DE520", VA = "0x1805DFB20", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBF")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public COM_LogicBranch_Goto_Behaviour()
		{
		}

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x10")]
		public int ticks;
	}
}

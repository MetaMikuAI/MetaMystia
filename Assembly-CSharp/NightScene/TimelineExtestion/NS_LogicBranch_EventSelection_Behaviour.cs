using System;
using Common.TimelineExtestion;
using DayScene.TimelineExtensions;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	public class NS_LogicBranch_EventSelection_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BC6 RID: 11206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x5E06D0", Offset = "0x5DF0D0", VA = "0x1805E06D0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_LogicBranch_EventSelection_Behaviour()
		{
		}

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x10")]
		public DS_LogicBranch_EventSelection.EventOption[] eventOptions;
	}
}

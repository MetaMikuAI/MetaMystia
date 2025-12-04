using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	public class DS_LogicBranch_EventSelection_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x498060", Offset = "0x496A60", VA = "0x180498060", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_LogicBranch_EventSelection_Behaviour()
		{
		}

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0x10")]
		public DS_LogicBranch_EventSelection.EventOption[] eventOptions;
	}
}

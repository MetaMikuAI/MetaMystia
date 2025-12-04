using System;
using Common.TimelineExtestion;
using GameData.Profile;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	public class COM_LogicBranch_SchedulerNodeFinished_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0x5DFD60", Offset = "0x5DE760", VA = "0x1805DFD60", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x5DFC70", Offset = "0x5DE670", VA = "0x1805DFC70")]
		private bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public COM_LogicBranch_SchedulerNodeFinished_Behaviour()
		{
		}

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x10")]
		public int falseAddFrames;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x18")]
		public string nodeLabel;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x20")]
		public SchedulerNode.NodeType nodeType;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x24")]
		public int trueAddFrames;
	}
}

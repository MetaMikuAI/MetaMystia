using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public class NS_MGuest_PlayEvaluationDialog_Special_Behaviuor : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BDA RID: 11226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x5E1EA0", Offset = "0x5E08A0", VA = "0x1805E1EA0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_PlayEvaluationDialog_Special_Behaviuor()
		{
		}

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x18")]
		public GuestGroupController.EvaluationResult evaluationResult;

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x1C")]
		public bool shouldWaitForFinish;
	}
}

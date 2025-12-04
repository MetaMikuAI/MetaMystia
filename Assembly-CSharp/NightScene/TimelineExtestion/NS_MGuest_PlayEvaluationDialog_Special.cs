using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public class NS_MGuest_PlayEvaluationDialog_Special : PlayableAsset
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x5E1FB0", Offset = "0x5E09B0", VA = "0x1805E1FB0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C09")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_PlayEvaluationDialog_Special()
		{
		}

		// Token: 0x0400284A RID: 10314
		[Token(Token = "0x400284A")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400284B RID: 10315
		[Token(Token = "0x400284B")]
		[FieldOffset(Offset = "0x20")]
		public GuestGroupController.EvaluationResult evaluationResult;

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldWaitForFinish;
	}
}

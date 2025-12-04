using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD5 RID: 4053
	[Token(Token = "0x2000FD5")]
	public class COM_LogicBranch_OnlyForSkipTutorial : PlayableAsset
	{
		// Token: 0x06005EBF RID: 24255 RVA: 0x00020D30 File Offset: 0x0001EF30
		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0x8C01E0", Offset = "0x8BEBE0", VA = "0x1808C01E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_LogicBranch_OnlyForSkipTutorial()
		{
		}

		// Token: 0x040057BE RID: 22462
		[Token(Token = "0x40057BE")]
		[FieldOffset(Offset = "0x18")]
		public int skipSkipTutorialFrames;
	}
}

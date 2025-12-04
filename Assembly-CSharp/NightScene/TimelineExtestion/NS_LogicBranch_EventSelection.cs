using System;
using DayScene.TimelineExtensions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	public class NS_LogicBranch_EventSelection : PlayableAsset
	{
		// Token: 0x06002BF6 RID: 11254 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x5E08D0", Offset = "0x5DF2D0", VA = "0x1805E08D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_LogicBranch_EventSelection()
		{
		}

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x18")]
		public DS_LogicBranch_EventSelection.EventOption[] eventOptions;
	}
}

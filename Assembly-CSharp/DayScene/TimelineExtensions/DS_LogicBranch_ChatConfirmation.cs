using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public class DS_LogicBranch_ChatConfirmation : PlayableAsset
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x497F40", Offset = "0x496940", VA = "0x180497F40", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_LogicBranch_ChatConfirmation()
		{
		}

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x18")]
		public int acceptAddFrames;

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x1C")]
		public int refuseAddFrames;
	}
}
